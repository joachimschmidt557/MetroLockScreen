<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxUser.Location = New System.Drawing.Point(143, 101)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(138, 134)
        Me.PictureBoxUser.TabIndex = 0
        Me.PictureBoxUser.TabStop = False
        '
        'LabelUserName
        '
        Me.LabelUserName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserName.ForeColor = System.Drawing.Color.White
        Me.LabelUserName.Location = New System.Drawing.Point(287, 101)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(148, 37)
        Me.LabelUserName.TabIndex = 1
        Me.LabelUserName.Text = "User Name"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(294, 160)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxPassword.Size = New System.Drawing.Size(272, 29)
        Me.TextBoxPassword.TabIndex = 2
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonOK.Location = New System.Drawing.Point(572, 160)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(36, 29)
        Me.ButtonOK.TabIndex = 3
        Me.ButtonOK.Text = "->"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(935, 539)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.PictureBoxUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogIn"
        Me.Text = "LogIn"
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxUser As System.Windows.Forms.PictureBox
    Friend WithEvents LabelUserName As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
End Class
