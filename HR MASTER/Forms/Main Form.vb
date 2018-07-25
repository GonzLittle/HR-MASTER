Public Class Main_Form
    Public f As New Form1 With {.TopLevel = False, .AutoSize = False}
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            f.Parent = Panel3
            f.Dock = DockStyle.Fill

        Catch ex As Exception

        End Try

    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Panel3.Location = New Point(50, 43)
        'Panel3.Size = New Size(1315, 682)
        Panel4.Width = 50
        Panel4.Visible = True
        BunifuImageButton1.Visible = False
        BunifuImageButton3.Visible = True
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Panel3.Location = New Point(201, 43)
        'Panel3.Size = New Size(1163, 682)
        Panel4.Location = New Point(1, 43)
        Panel4.Size = New Size(202, 683)
        Panel4.Visible = True


        BunifuImageButton1.Visible = True
        BunifuImageButton3.Visible = False

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub



    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click


        Try
            Dim form3 As New Form1
            form3.TopLevel = False

            'form3.Anchor = AnchorStyles.Bottom
            form3.Anchor = AnchorStyles.Top
            form3.Anchor = AnchorStyles.Left
            'form3.Anchor = AnchorStyles.Right
            Panel3.Controls.Add(form3)


            'form3.Dock = DockStyle.Fill
            form3.BringToFront()
            form3.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click


        Try
            Dim form3 As New Login
            form3.TopLevel = False

            form3.Anchor = AnchorStyles.Bottom
            form3.Anchor = AnchorStyles.Top
            form3.Anchor = AnchorStyles.Left
            form3.Anchor = AnchorStyles.Right
            Panel3.Controls.Add(form3)


            form3.Dock = DockStyle.Fill
            form3.BringToFront()

            form3.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class