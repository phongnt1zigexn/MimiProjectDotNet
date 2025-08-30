Public Class TaskEditorForm
    Public Property TaskNameValue As String
    Public Property PriorityValue As Integer

    Public Sub New(Optional name As String = "", Optional priority As Integer = 0)
        InitializeComponent()

        txtTaskName.Text = name
        If priority >= 0 AndAlso priority <= 2 Then
            cmbPriority.SelectedIndex = priority
        Else
            cmbPriority.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If String.IsNullOrWhiteSpace(txtTaskName.Text) Then
            MessageBox.Show("Task name cannot be empty.")
            Return
        End If

        TaskNameValue = txtTaskName.Text.Trim()
        PriorityValue = cmbPriority.SelectedIndex
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
