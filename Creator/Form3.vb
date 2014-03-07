Public Class Form3
    Dim willfight As Boolean
    Dim fightingchance As Integer
    Private Sub fight(buttonfight)
        If willfight = True Then
            MsgBox("you run across a guard who readies his sword")
            Me.Hide()
            Form2.Show()
        End If
    End Sub
    Private Sub fightchance(buttonchance)
        fightingchance = CInt(Int((15 * Rnd()) + 1))
        If fightingchance > 10 Then
            willfight = True
        End If
        fight(buttonchance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fightchance(Button1)
        RichTextBox1.Text = "You walk up and down the beach looking for survivors"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class