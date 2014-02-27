Public Class Form2
    Dim enemystrth As Integer
    Dim enemyintel As Integer
    'Dim enemyagl As Integer
    'Dim enemymarks As Integer
    Dim enemyhealth As Integer = 100
    Dim strth As Integer
    Dim intel As Integer
    'Dim agl As Integer
    'Dim marks As Integer
    Dim health As Integer = 100
    Dim number As Integer
    Dim number2 As Integer
    Dim temp As Double
    Dim temp2 As Double
    Public stamia As Integer = 100
    Public enemystamia As Integer = 100
    Dim value1 As Boolean
    Dim value2 As Boolean
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'this my load for the battle but this is another attempt
        'Dim FILE_NAME As String = "C:\playerstats.txt"

        'If System.IO.File.Exists(FILE_NAME) = True Then
        'Dim objReader As New System.IO.StreamReader(FILE_NAME)
        'TextBox1.Text = objReader.ReadLine & vbNewLine
        'Label1.Text = objReader.ReadLine & vbNewLine
        'Label2.Text = objReader.ReadLine & vbNewLine
        'Label3.Text = objReader.ReadLine & vbNewLine
        'Label4.Text = objReader.ReadLine & vbNewLine
        'Label9.Text = objReader.ReadLine & vbNewLine
        'objReader.Close()
        'Else
        'MsgBox("File Does Not Exist")
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'when the start button is pressed it sets the intergers 
        enemyintel = Int(13 * Rnd()) + 10
        enemystrth = Int(13 * Rnd()) + 10
        intel = Int(13 * Rnd()) + 10
        strth = Int(13 * Rnd()) + 10
        ProgressBar1.Value = 100
        ProgressBar2.Value = 100
        ProgressBar3.Value = 100
        ProgressBar4.Value = 100
        Label1.Text = strth
        Label2.Text = intel
        Label3.Text = enemystrth
        Label4.Text = enemyintel


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'attack
        'If Label1.Text < 20 Then enemyhealth = enemyhealth - 10 Else enemyhealth = enemyhealth - 5
        'ProgressBar2.Value = enemyhealth
        'Label10.Text = "player 1 attacked"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'heal
        'If Label1.Text < 20 Then health = health + 10 Else health = health + 5
        'ProgressBar1.Value = health
        'Label10.Text = "player 1 healed"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'fireball
        'If Label3.Text < 20 Then enemyhealth = enemyhealth - 40 Else enemyhealth = enemyhealth - 20
        'ProgressBar2.Value = enemyhealth
        'Label10.Text = "player 1 shot a fireball"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'shoot
        'If Label4.Text < 20 Then enemyhealth = enemyhealth - 20 Else enemyhealth = enemyhealth - 10
        'ProgressBar2.Value = enemyhealth
        'Label10.Text = "player 1 shot at player 2"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'arrow strike
        'If Label4.Text < 20 Then enemyhealth = enemyhealth - 20 Else enemyhealth = enemyhealth - 10
        'ProgressBar2.Value = enemyhealth
        'Label10.Text = "player 1 shot arrows"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'attack
        'If Label5.Text < 20 Then health = health - 10 Else health = health - 5
        'ProgressBar1.Value = health
        'Label10.Text = "player 2 attacked"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'fireball
        'If Label7.Text < 20 Then health = health - 40 Else health = health - 20
        'ProgressBar1.Value = health
        'Label10.Text = "player 2 shot a fire ball"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'heal
        'If Label5.Text < 20 Then enemyhealth = enemyhealth + 10 Else enemyhealth = enemyhealth + 5
        'ProgressBar1.Value = enemyhealth
        'Label10.Text = "player 2 healed"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'shoot
        'If Label8.Text < 20 Then health = health - 20 Else health = health - 10
        'ProgressBar1.Value = health
        'Label10.Text = "player 2 shot at player 1"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'arrow strike
        'If Label8.Text < 20 Then health = health - 20 Else health = health - 10
        'ProgressBar1.Value = health
        'Label10.Text = "player 2 shot arrows"
        'If health <= 0 Then MsgBox("player 2 wins")
        'If enemyhealth <= 0 Then MsgBox("player 1 wins")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        number = Math.Floor(7 * Rnd())
        TextBox1.Text = number

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'this create my dice roll
        number = Math.Floor(7 * Rnd())
        TextBox2.Text = number
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'this is my auto combat button it clicks the buttons that are needed that then it carry on until one player wins
        Do Until value1 = True Or value2 = True
            Button5.PerformClick()
            Button14.PerformClick()
            Button15.PerformClick()
            If health <= 0 Then value1 = True
            If health <= 0 Then value2 = True
        Loop
        If ProgressBar1.Value <= 0 Then MsgBox("player 2 wins")
        If ProgressBar2.Value <= 0 Then MsgBox("player 1 Wins")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ProgressBar1.Maximum = 100
        ProgressBar2.Maximum = 100
        temp = 0
        health = 50
        enemyhealth = 50
        'this is my battle button it see which number is bigger then the temp number is taken away from the enemy health

        temp = Math.Floor(Val(TextBox1.Text - TextBox2.Text))
        temp2 = Math.Floor(Val(Label2.Text - Label4.Text))
        If TextBox1.Text > TextBox2.Text Then health = health - temp
        If TextBox1.Text < TextBox2.Text Then enemyhealth = enemyhealth - temp
        If Label2.Text > Label4.Text Then stamia = stamia - temp2
        If Label2.Text < Label4.Text Then enemystamia = enemystamia - temp2
        If enemyhealth > 100 Then enemyhealth = 100
        If health > 100 Then health = 100
        If enemystamia > 100 Then enemystamia = 100
        If stamia > 100 Then stamia = 100
        If health <= 0 Then MsgBox("player 2 wins")
        If enemyhealth <= 0 Then MsgBox("player 1 wins")
        ProgressBar1.Value = health
        ProgressBar2.Value = enemyhealth
        ProgressBar3.Value = stamia
        ProgressBar4.Value = enemystamia
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'this is my code to change the stats if the player does not like there stats
        If ComboBox1.SelectedIndex = 0 Then Label2.Text = TextBox3.Text
        If ComboBox1.SelectedIndex = 1 Then Label1.Text = TextBox3.Text
        
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox2.SelectedIndex = 0 Then Label3.Text = TextBox3.Text
        If ComboBox2.SelectedIndex = 0 Then Label4.Text = TextBox3.Text
    End Sub
End Class