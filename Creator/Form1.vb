Public Class Form1
    Dim strong As Double
    Dim marks As Double
    Dim agl As Double
    Dim intel As Double
    Dim picture As Integer
    Dim strong2 As Double
    Dim marks2 As Double
    Dim agl2 As Double
    Dim intel2 As Double
    Dim strongmain As Double
    Dim marksmain As Double
    Dim aglmain As Double
    Dim intelmain As Double
    Public win As Integer



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'This creates 2 random numbers and divides them by them self’s and rounded down and put in a label and 10 is added so then maximum is 22 and the minimum is 11
        strong = CInt(Int((15 * Rnd()) + 1))
        strong2 = CInt(Int((5 * Rnd()) + 1))
        strongmain = Math.Floor(Val(strong) / Val(strong2))
        Label10.Text = Val(strongmain) + 10
        Button4.Enabled = False

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        intel = CInt(Int((15 * Rnd()) + 1))
        intel2 = CInt(Int((5 * Rnd()) + 1))
        intelmain = Math.Floor(Val(intel) / Val(intel2))
        Label7.Text = Val(intelmain) + 10
        Button5.Enabled = False

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        marks = CInt(Int((15 * Rnd()) + 1))
        marks2 = CInt(Int((5 * Rnd()) + 1))
        marksmain = Math.Floor(Val(marks) / Val(marks2))
        Label8.Text = Val(marksmain) + 10
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        agl = CInt(Int((15 * Rnd()) + 1))
        agl2 = CInt(Int((5 * Rnd()) + 1))
        aglmain = Math.Floor(Val(agl) / Val(agl2))
        Label11.Text = Val(aglmain) + 10
        Button7.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'this is my loading code
        'Dim FILE_NAME As String = "C:\playerstats.txt"

        'If System.IO.File.Exists(FILE_NAME) = True Then
        'Dim objReader As New System.IO.StreamReader(FILE_NAME)
        'TextBox1.Text = objReader.ReadLine & vbNewLine
        'Label10.Text = objReader.ReadLine & vbNewLine
        'Label7.Text = objReader.ReadLine & vbNewLine
        'Label8.Text = objReader.ReadLine & vbNewLine
        'Label11.Text = objReader.ReadLine & vbNewLine
        'Label12.Text = objReader.ReadLine & vbNewLine
        'objReader.Close()
        'Else
        'MsgBox("File Does Not Exist")
        'End If

        'If Val(Label12.Text) = 1 Then PictureBox3.Image = PictureBox1.Image
        'If Val(Label12.Text) = 2 Then PictureBox3.Image = PictureBox2.Image
        'If Val(Label12.Text) = 3 Then PictureBox3.Image = PictureBox4.Image
        'If Val(Label12.Text) = 4 Then PictureBox3.Image = PictureBox5.Image
        'If Val(Label12.Text) = 5 Then PictureBox3.Image = PictureBox6.Image
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_0(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'this was ment to be my loading code but it isn't working so i tryed i different code
        'Dim FILE_NAME As String = "C:\playerstats.txt"


        'If System.IO.File.Exists(FILE_NAME) Then
        'Dim objReader As New System.IO.StreamReader(FILE_NAME)
        'If ComboBox3.SelectedIndex = 0 Then
        'TextBox1.Text = objReader.ReadLine & vbNewLine
        'Label10.Text = objReader.ReadLine & vbNewLine
        'Label7.Text = objReader.ReadLine & vbNewLine
        'Label8.Text = objReader.ReadLine & vbNewLine
        'Label11.Text = objReader.ReadLine & vbNewLine
        'Label12.Text = objReader.ReadLine & vbNewLine
        'objReader.Close()
        'End If

        'Else
        'MsgBox("File Does Not Exist")
        'End If

        'If System.IO.File.Exists(FILE_NAME) Then
        'Dim objReader As New System.IO.StreamReader(FILE_NAME)
        'If ComboBox3.SelectedIndex = 0 Then
        'TextBox1.Text = objReader.ReadLine & vbNewLine
        'Label10.Text = objReader.ReadLine & vbNewLine
        'Label7.Text = objReader.ReadLine & vbNewLine
        'Label8.Text = objReader.ReadLine & vbNewLine
        'Label11.Text = objReader.ReadLine & vbNewLine
        'Label12.Text = objReader.ReadLine & vbNewLine
        'TextBox1.Text = objReader.ReadLine & vbNewLine
        'Label10.Text = objReader.ReadLine & vbNewLine
        'Label7.Text = objReader.ReadLine & vbNewLine
        'Label8.Text = objReader.ReadLine & vbNewLine
        'Label11.Text = objReader.ReadLine & vbNewLine
        'Label12.Text = objReader.ReadLine & vbNewLine
        'TextBox1.Text = objReader.ReadLine & vbNewLine
        'Label10.Text = objReader.ReadLine & vbNewLine
        'Label7.Text = objReader.ReadLine & vbNewLine
        'Label8.Text = objReader.ReadLine & vbNewLine
        'Label11.Text = objReader.ReadLine & vbNewLine
        'Label12.Text = objReader.ReadLine & vbNewLine
        'objReader.Close()
        'End If

        'Else
        'MsgBox("File Does Not Exist")
        'End If

        'If Val(Label12.Text) = 1 Then PictureBox3.Image = PictureBox1.Image
        'If Val(Label12.Text) = 2 Then PictureBox3.Image = PictureBox2.Image
        'If Val(Label12.Text) = 3 Then PictureBox3.Image = PictureBox4.Image
        'If Val(Label12.Text) = 4 Then PictureBox3.Image = PictureBox5.Image
        'If Val(Label12.Text) = 5 Then PictureBox3.Image = PictureBox6.Image
    End Sub
    'attempt at loading
    'Private Sub ComboBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
    'Dim FILE_NAME As String = "C:\playerstats.txt"

    'If System.IO.File.Exists(FILE_NAME) Then
    'Dim objReader As New System.IO.StreamReader(FILE_NAME)
    'If ComboBox3.SelectedIndex = 1 Then
    'TextBox1.Text = objReader.ReadLine & vbNewLine
    'Label10.Text = objReader.ReadLine & vbNewLine
    'Label7.Text = objReader.ReadLine & vbNewLine
    'Label8.Text = objReader.ReadLine & vbNewLine
    'Label11.Text = objReader.ReadLine & vbNewLine
    'Label12.Text = objReader.ReadLine & vbNewLine

    'TextBox1.Text = objReader.ReadLine & vbNewLine
    'Label10.Text = objReader.ReadLine & vbNewLine
    'Label7.Text = objReader.ReadLine & vbNewLine
    'Label8.Text = objReader.ReadLine & vbNewLine
    'Label11.Text = objReader.ReadLine & vbNewLine
    'Label12.Text = objReader.ReadLine & vbNewLine
    'objReader.Close()
    'End If

    'Else
    'MsgBox("File Does Not Exist")
    'End If


    'If Val(Label12.Text) = 1 Then PictureBox3.Image = PictureBox1.Image
    'If Val(Label12.Text) = 2 Then PictureBox3.Image = PictureBox2.Image
    'If Val(Label12.Text) = 3 Then PictureBox3.Image = PictureBox4.Image
    'If Val(Label12.Text) = 4 Then PictureBox3.Image = PictureBox5.Image
    'If Val(Label12.Text) = 5 Then PictureBox3.Image = PictureBox6.Image
    'End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        'Dim FILE_NAME As String = "C:\playerstats.txt"
        'Dim i As Integer
        'Dim aryText(10) As String
        'Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        'This is my save code it save two profiles on one text files I did intend to load it back but was to hard so I have commented it out so this 
        'If ComboBox2.SelectedIndex = 0 Then
        'aryText(0) = (TextBox1.Text)
        'aryText(1) = (Label10.Text)
        'aryText(2) = (Label7.Text)
        'aryText(3) = (Label8.Text)
        'aryText(4) = (Label11.Text)
        'aryText(5) = (Label12.Text)
        'MsgBox("Saved")

        'ElseIf ComboBox2.SelectedIndex = 1 Then
        'aryText(6) = (TextBox1.Text)
        'aryText(7) = (Label7.Text)
        'aryText(8) = (Label8.Text)
        'aryText(9) = (Label11.Text)
        'aryText(10) = (Label12.Text)
        'MsgBox("Saved")
        'End If
        'For i = 0 To 10
        ' objWriter.WriteLine(aryText(i))
        ' Next

        'objWriter.Close()

        'My.Computer.FileSystem.WriteAllText("C:\programs\fightinggame\save.txt", TextBox1.Text, Label10.Text, Label7.Text, Label8.Text, Label11.Text, Label12.Text, True)
        Dim myarray(0 To 11) As String
        If ComboBox2.SelectedIndex = 0 Then
            myarray(0) = TextBox1.Text
            myarray(1) = Label10.Text
            myarray(2) = Label7.Text
            myarray(3) = Label8.Text
            myarray(4) = Label11.Text
            MsgBox("Saved")
            Dim FileName As String = Application.StartupPath & "\Save1.txt"
            IO.File.WriteAllLines(FileName, myarray)
        End If

        If ComboBox2.SelectedIndex = 1 Then
            myarray(6) = TextBox1.Text
            myarray(7) = Label10.Text
            myarray(8) = Label7.Text
            myarray(9) = Label8.Text
            myarray(10) = Label11.Text
            MsgBox("Saved")
            Dim FileName As String = Application.StartupPath & "\Save2.txt"
            IO.File.WriteAllLines(FileName, myarray)
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
