Imports MySql.Data.MySqlClient
Public Class Form1


    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Try
            loaddata()
        Catch ex As Exception

        End Try

    End Sub



    Private Sub MaterialSingleLineTextField1_TextChanged(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.TextChanged


        Try
            Dim _NAME As String = MaterialSingleLineTextField1.Text.Trim

            Dim str As String = "Data source= localhost;user=root;database=hris"
            Dim con As New MySqlConnection(str)
            Dim com As String = "Select Name from employee where IDNUM like '" + _NAME + "'"
            Dim adpt As New MySqlDataAdapter(com, con)

            Dim ds As New DataSet()

            'adpt.Fill(ds, "NAME")
            adpt.Fill(ds)
            MetroGrid1.DataSource = ds.Tables(0)
            Dim y As Integer = ds.Tables(0).Rows.Count
            MaterialLabel1.Text = y
        Catch ex As Exception

        End Try

    End Sub
    Private Sub loaddata()
        Dim _NAME As String = MaterialSingleLineTextField1.Text.Trim

        Dim str As String = "Data source= localhost;user=root;database=hris"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select Name from employee"
        Dim adpt As New MySqlDataAdapter(com, con)

        Dim ds As New DataSet()

        'adpt.Fill(ds, "NAME")
        adpt.Fill(ds)
        MetroGrid1.DataSource = ds.Tables(0)
        Dim y As Integer = ds.Tables(0).Rows.Count
        MaterialLabel1.Text = y
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class
