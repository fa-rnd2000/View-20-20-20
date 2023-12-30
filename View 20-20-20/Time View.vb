Public Class Time_View
    Dim intTimeS As Integer
    Dim intTimeM As Integer

    Private Sub Time_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intTimeS = 20
        intTimeM = 20 * 60
        System.Console.Beep(800, 800) ' Adjust frequency and duration as needed

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        On Error Resume Next

        intTimeS = intTimeS - 1
        intTimeM = intTimeM - 1

        If intTimeS = 0 Then

            intTimeM = 20 * 60
            System.Console.Beep(500, 500) ' Adjust frequency and duration as needed

            Me.Hide()
        ElseIf intTimeM = 0 Then

            Me.Show()
            intTimeS = 22
            System.Console.Beep(800, 800) ' Adjust frequency and duration as needed
        End If

        If intTimeS > 20 Then
            Label1.Text = "EYE REST"


        Else
            Label1.Text = "EYE REST:" & intTimeS
        End If


        Label2.Text = DateTime.Now.ToString("hh:mm tt")





    End Sub


End Class