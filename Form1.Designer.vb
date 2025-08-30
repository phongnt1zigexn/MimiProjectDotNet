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
        btnToggleDone = New Button()
        btnDelete = New Button()
        lstTasks = New ListBox()
        cmbPriority = New ComboBox()
        lbTask = New Label()
        Label2 = New Label()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(331, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 45)
        Label1.TabIndex = 0
        Label1.Text = "To-do list"
        ' 
        ' txtTask
        ' 
        txtTask.Location = New Point(100, 114)
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(356, 23)
        txtTask.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(100, 359)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnToggleDone
        ' 
        btnToggleDone.Location = New Point(227, 359)
        btnToggleDone.Name = "btnToggleDone"
        btnToggleDone.Size = New Size(127, 23)
        btnToggleDone.TabIndex = 6
        btnToggleDone.Text = "Mark Done/Undone"
        btnToggleDone.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(533, 359)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(113, 23)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lstTasks
        ' 
        lstTasks.DrawMode = DrawMode.OwnerDrawFixed
        lstTasks.FormattingEnabled = True
        lstTasks.Location = New Point(100, 175)
        lstTasks.Name = "lstTasks"
        lstTasks.Size = New Size(546, 148)
        lstTasks.TabIndex = 10
        ' 
        ' cmbPriority
        ' 
        cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPriority.FormattingEnabled = True
        cmbPriority.Items.AddRange(New Object() {"Low", "Medium", "High"})
        cmbPriority.Location = New Point(525, 114)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(121, 23)
        cmbPriority.TabIndex = 11
        ' 
        ' lbTask
        ' 
        lbTask.AutoSize = True
        lbTask.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTask.Location = New Point(246, 86)
        lbTask.Name = "lbTask"
        lbTask.Size = New Size(67, 15)
        lbTask.TabIndex = 12
        lbTask.Text = "Task Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(563, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 13
        Label2.Text = "Priority"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(406, 359)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEdit)
        Controls.Add(Label2)
        Controls.Add(lbTask)
        Controls.Add(cmbPriority)
        Controls.Add(lstTasks)
        Controls.Add(btnDelete)
        Controls.Add(btnToggleDone)
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
    Friend WithEvents btnToggleDone As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents lbTask As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button

End Class
