Imports Microsoft.Data.Sqlite

Public Class Form1
    Private connString As String = "Data Source=todo.db"
    Public Class TaskItem
        Public Property ID As String
        Public Property TaskName As String
        Public Property IsDone As Boolean
        Public Property Priority As Integer

        Public Overrides Function ToString() As String
            Return TaskName & If(IsDone, " ✅", "")
        End Function
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure DB and table exist
        Using cn As New SqliteConnection(connString)
            cn.Open()
            Dim sql As String = "CREATE TABLE IF NOT EXISTS Tasks (" &
                                "ID TEXT PRIMARY KEY, " &
                                "TaskName TEXT, " &
                                "IsDone INTEGER, " &
                                "Priority INTEGER)"
            Using cmd As New SqliteCommand(sql, cn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadTasks()
    End Sub

    Private Sub LoadTasks()
        lstTasks.Items.Clear()

        Using cn As New SqliteConnection(connString)
            cn.Open()
            Dim sql As String = "SELECT ID, TaskName, IsDone, Priority FROM Tasks ORDER BY Priority DESC"
            Using cmd As New SqliteCommand(sql, cn)
                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim task As New TaskItem With {
                            .ID = rdr.GetString(0),
                            .TaskName = rdr.GetString(1),
                            .IsDone = rdr.GetInt32(2) = 1,
                            .Priority = rdr.GetInt32(3)
                        }
                        lstTasks.Items.Add(task)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtTask.Text) Then
            MessageBox.Show("Please enter a task name.")
            Return
        End If

        AddTask(txtTask.Text, cmbPriority.SelectedIndex)

        txtTask.Clear()
        cmbPriority.SelectedIndex = 0
        LoadTasks()
    End Sub

    Private Sub AddTask(taskName As String, priority As Integer)
        Using cn As New SqliteConnection(connString)
            cn.Open()
            Dim sql As String = "INSERT INTO Tasks (ID, TaskName, IsDone, Priority) VALUES (@id, @task, 0, @priority)"
            Using cmd As New SqliteCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", Guid.NewGuid().ToString())
                cmd.Parameters.AddWithValue("@task", taskName)
                cmd.Parameters.AddWithValue("@priority", priority)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub lstTasks_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstTasks.DrawItem
        If e.Index < 0 Then Return

        Dim task As TaskItem = DirectCast(lstTasks.Items(e.Index), TaskItem)

        e.DrawBackground()

        Dim brush As Brush = Brushes.Black
        Select Case task.Priority
            Case 2 : brush = Brushes.Red      ' High
            Case 1 : brush = Brushes.Orange   ' Medium
            Case 0 : brush = Brushes.Green    ' Low
        End Select

        e.Graphics.DrawString(task.ToString(), e.Font, brush, e.Bounds)
        e.DrawFocusRectangle()
    End Sub

    Private Sub btnToggleDone_Click(sender As Object, e As EventArgs) Handles btnToggleDone.Click
        If lstTasks.SelectedIndex = -1 Then
            MessageBox.Show("Please select a task.")
            Return
        End If

        Dim task As TaskItem = DirectCast(lstTasks.SelectedItem, TaskItem)
        Dim newValue As Integer = If(task.IsDone, 0, 1)

        Using cn As New SqliteConnection(connString)
            cn.Open()
            Dim sql As String = "UPDATE Tasks SET IsDone=@done WHERE ID=@id"
            Using cmd As New SqliteCommand(sql, cn)
                cmd.Parameters.AddWithValue("@done", newValue)
                cmd.Parameters.AddWithValue("@id", task.ID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadTasks()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstTasks.SelectedIndex = -1 Then
            MessageBox.Show("Please select a task.")
            Return
        End If

        Dim task As TaskItem = DirectCast(lstTasks.SelectedItem, TaskItem)

        Using cn As New SqliteConnection(connString)
            cn.Open()
            Dim sql As String = "DELETE FROM Tasks WHERE ID=@id"
            Using cmd As New SqliteCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", task.ID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadTasks()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstTasks.SelectedIndex = -1 Then
            MessageBox.Show("Please select a task to edit.")
            Return
        End If

        Dim task As TaskItem = DirectCast(lstTasks.SelectedItem, TaskItem)

        Using editor As New TaskEditorForm(task.TaskName, task.Priority)
            If editor.ShowDialog() = DialogResult.OK Then
                Using cn As New SqliteConnection(connString)
                    cn.Open()
                    Dim sql As String = "UPDATE Tasks SET TaskName=@name, Priority=@priority WHERE ID=@id"
                    Using cmd As New SqliteCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@name", editor.TaskNameValue)
                        cmd.Parameters.AddWithValue("@priority", editor.PriorityValue)
                        cmd.Parameters.AddWithValue("@id", task.ID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadTasks()
            End If
        End Using
    End Sub
End Class
