Public Class main

    Private Sub main_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        ExitAnimation()
        'Application.Exit()
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        LabelTime.Text = Now.ToString("HH:mm")
        LabelDate.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub main_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        ExitAnimation()
    End Sub

    Private Sub main_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LabelTime.Text = Now.ToString("HH:mm")
        LabelDate.Text = DateTime.Now.ToLongDateString()

        Dim MyRed As Integer
        Dim MyGreen As Integer
        Dim MyBlue As Integer
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyRed = CInt(Int((254 * Rnd()) + 0))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyGreen = CInt(Int((254 * Rnd()) + 0))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyBlue = CInt(Int((254 * Rnd()) + 0))

        Me.BackColor = Color.FromArgb(MyRed, MyGreen, MyBlue)

        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.Location = New Point(0, -Me.Height)
        Me.Refresh()
    End Sub

    Private Sub ExitAnimation()
        'Dim screenHeight = Screen.PrimaryScreen.Bounds.Height
        Do Until Me.Location.Y = -Me.Height + 220
            Me.Location = New Point(0, Me.Location.Y - 1)
            System.Threading.Thread.Sleep(0)
        Loop
        Do Until Me.Location.Y = -Me.Height + 50
            Me.Location = New Point(0, Me.Location.Y - 1)
            System.Threading.Thread.Sleep(1)
        Loop
        Do Until Me.Location.Y = -Me.Height
            Me.Location = New Point(0, Me.Location.Y - 1)
            System.Threading.Thread.Sleep(8)
        Loop
        'End
        Dim loginwindow As New LogIn
        loginwindow.ShowDialog()
        Me.Close()
    End Sub

    Private Sub main_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        Do Until Me.Location.Y = 0
            Me.Location = New Point(0, Me.Location.Y + 1)
            'System.Threading.Thread.Sleep(1)
        Loop
    End Sub
End Class
