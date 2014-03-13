Public Class Form3
    Dim fooddrink As Boolean
    Public win As Integer
    Dim willfight As Boolean
    Dim fightingchance As Integer
    Private Sub fight(buttonfight)
        If willfight = True Then
            MsgBox("you are spotted by a pirate who readies his sword")
            Me.Hide()
            Form2.Show()
            win = win + 1
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
        If fooddrink = True Then
            RichTextBox1.Text = ("You wait on the beach for someone to come looking for you while waiting you have some food and drink. Hours pass, you have ran out of food and water again.")
            fightchance(Button3)
        End If
        fooddrink = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim supplies As Integer
        supplies = CInt(Int((15 * Rnd()) + 1))
        If supplies > 10 Then
            MsgBox("You found some food and drink")
            fooddrink = True
        End If
        fightchance(Button4)
        If win = 1 Then
            RichTextBox1.Text = ("After looking for survivors you notice a light off in the distance it looks like a lighthouse. You start walking towards it then you fall into a trap set by pirates")
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class