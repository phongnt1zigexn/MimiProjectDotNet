<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskEditorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        SqliteCommand1 = New Microsoft.Data.Sqlite.SqliteCommand()
        lbTask = New Label()
        lbPriority = New Label()
        lbEdit = New Label()
        txtTaskName = New TextBox()
        cmbPriority = New ComboBox()
        btnOK = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' SqliteCommand1
        ' 
        SqliteCommand1.CommandTimeout = 30
        SqliteCommand1.Connection = Nothing
        SqliteCommand1.Transaction = Nothing
        SqliteCommand1.UpdatedRowSource = UpdateRowSource.None
        ' 
        ' lbTask
        ' 
        lbTask.AutoSize = True
        lbTask.Location = New Point(36, 85)
        lbTask.Name = "lbTask"
        lbTask.Size = New Size(39, 15)
        lbTask.TabIndex = 0
        lbTask.Text = "Name"
        ' 
        ' lbPriority
        ' 
        lbPriority.AutoSize = True
        lbPriority.Location = New Point(36, 147)
        lbPriority.Name = "lbPriority"
        lbPriority.Size = New Size(45, 15)
        lbPriority.TabIndex = 1
        lbPriority.Text = "Priority"
        ' 
        ' lbEdit
        ' 
        lbEdit.AutoSize = True
        lbEdit.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEdit.Location = New Point(157, 21)
        lbEdit.Name = "lbEdit"
        lbEdit.Size = New Size(137, 40)
        lbEdit.TabIndex = 2
        lbEdit.Text = "Edit Task"
        ' 
        ' txtTaskName
        ' 
        txtTaskName.Location = New Point(111, 82)
        txtTaskName.Name = "txtTaskName"
        txtTaskName.Size = New Size(276, 23)
        txtTaskName.TabIndex = 3
        ' 
        ' cmbPriority
        ' 
        cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPriority.FormattingEnabled = True
        cmbPriority.Items.AddRange(New Object() {"Low", "Medium", "High"})
        cmbPriority.Location = New Point(111, 144)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(121, 23)
        cmbPriority.TabIndex = 4
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(201, 238)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(75, 23)
        btnOK.TabIndex = 5
        btnOK.Text = "Save"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(312, 238)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' TaskEditorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 294)
        Controls.Add(btnCancel)
        Controls.Add(btnOK)
        Controls.Add(cmbPriority)
        Controls.Add(txtTaskName)
        Controls.Add(lbEdit)
        Controls.Add(lbPriority)
        Controls.Add(lbTask)
        Name = "TaskEditorForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SqliteCommand1 As Microsoft.Data.Sqlite.SqliteCommand
    Friend WithEvents lbTask As Label
    Friend WithEvents lbPriority As Label
    Friend WithEvents lbEdit As Label
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
