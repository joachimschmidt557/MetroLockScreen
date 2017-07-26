<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelTime
        '
        Me.LabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Segoe UI Light", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.White
        Me.LabelTime.Location = New System.Drawing.Point(12, 321)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(254, 128)
        Me.LabelTime.TabIndex = 0
        Me.LabelTime.Text = "TIME"
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.Color.White
        Me.LabelDate.Location = New System.Drawing.Point(26, 438)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(90, 45)
        Me.LabelDate.TabIndex = 1
        Me.LabelDate.Text = "DATE"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(927, 514)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
