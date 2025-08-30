Imports Microsoft.Data.Sqlite
Imports System.IO

Public Class Form1
    Private dbFile As String = Path.Combine(Application.StartupPath, "todo.db")
    Private connString As String = $"Data Source={dbFile}"

    Private Class TaskItem
        Public Property ID As String
        Public Property Text As String
        Public Property IsDone As Boolean
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnsureDatabase()
        LoadTasks()
    End Sub

    Private Sub LoadTasks()
        clbTasks.Items.Clear()
        Using cn As New SQLiteConnection(connString)
            cn.Open()
            Dim sql As String = "SELECT ID, TaskName, IsDone FROM Tasks ORDER BY ID"
            Using cmd As New SQLiteCommand(sql, cn)
                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim item As New TaskItem With {
                            .Id = rdr("ID").ToString(),
                            .Text = rdr("TaskName").ToString(),
                            .IsDone = (Convert.ToInt32(rdr("IsDone")) = 1)
                        }
                        clbTasks.Items.Add(item, item.IsDone)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub EnsureDatabase()
        If Not File.Exists(dbFile) Then
            ' file is created automatically when connecting
        End If

        Using cn As New SqliteConnection(connString)
            cn.Open()
            Dim sql As String = "CREATE TABLE IF NOT EXISTS Tasks (" &
                            "ID TEXT PRIMARY KEY, " &
                            "TaskName TEXT, " &
                            "IsDone INTEGER)"
            Using cmd As New SqliteCommand(sql, cn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim taskText = txtTask.Text.Trim()
        If taskText = "" Then
            MessageBox.Show("Enter a task")
            Return
        End If

        Dim newItem As New TaskItem With {
            .ID = Guid.NewGuid().ToString(),
            .Text = taskText,
            .IsDone = False
        }

        ' Insert into DB
        Using cn As New SQLiteConnection(connString)
            cn.Open()
            Dim sql As String = "INSERT INTO Tasks (ID, TaskName, IsDone) VALUES (@id, @name, 0)"
            Using cmd As New SQLiteCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", newItem.ID)
                cmd.Parameters.AddWithValue("@name", newItem.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Add to UI
        clbTasks.Items.Add(newItem, False)
        txtTask.Clear()
        txtTask.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If clbTasks.SelectedItem Is Nothing Then
            MessageBox.Show("Select a task first.")
            Return
        End If

        Dim selectedItem As TaskItem = CType(clbTasks.SelectedItem, TaskItem)

        ' Delete from DB
        Using cn As New SQLiteConnection(connString)
            cn.Open()
            Dim sql As String = "DELETE FROM Tasks WHERE ID=@id"
            Using cmd As New SQLiteCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", selectedItem.ID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Remove from UI
        clbTasks.Items.Remove(selectedItem)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Go backward to safely remove
        For i As Integer = clbTasks.CheckedItems.Count - 1 To 0 Step -1
            Dim item As TaskItem = CType(clbTasks.CheckedItems(i), TaskItem)

            Using cn As New SQLiteConnection(connString)
                cn.Open()
                Dim sql As String = "DELETE FROM Tasks WHERE ID=@id"
                Using cmd As New SQLiteCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", item.ID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            clbTasks.Items.Remove(item)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Update completion status to DB
        For i As Integer = 0 To clbTasks.Items.Count - 1
            Dim item As TaskItem = CType(clbTasks.Items(i), TaskItem)
            Dim isDone As Boolean = clbTasks.GetItemChecked(i)

            Using cn As New SQLiteConnection(connString)
                cn.Open()
                Dim sql As String = "UPDATE Tasks SET IsDone=@done WHERE ID=@id"
                Using cmd As New SQLiteCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@done", If(isDone, 1, 0))
                    cmd.Parameters.AddWithValue("@id", item.ID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Next
        MessageBox.Show("Tasks saved to database.")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadTasks()
    End Sub
End Class
