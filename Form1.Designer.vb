<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtTask = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        btnLoad = New Button()
        clbTasks = New CheckedListBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 0
        Label1.Text = "To-do list"
        ' 
        ' txtTask
        ' 
        txtTask.Location = New Point(92, 78)
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(531, 23)
        txtTask.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(92, 311)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(182, 311)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(113, 23)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete selected"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(301, 311)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(113, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(420, 311)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(113, 23)
        btnLoad.TabIndex = 7
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' clbTasks
        ' 
        clbTasks.CheckOnClick = True
        clbTasks.FormattingEnabled = True
        clbTasks.Location = New Point(92, 122)
        clbTasks.Name = "clbTasks"
        clbTasks.Size = New Size(531, 130)
        clbTasks.TabIndex = 8
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(539, 311)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(113, 23)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear Completed"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(clbTasks)
        Controls.Add(btnLoad)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(txtTask)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents clbTasks As CheckedListBox
    Friend WithEvents btnClear As Button

End Class
