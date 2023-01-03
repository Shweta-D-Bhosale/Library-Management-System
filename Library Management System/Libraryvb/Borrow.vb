Imports System.Data.OleDb

Public Class Borrow
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            Dim statu As Integer
            statu = 0
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Database\Library.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO borrow([s_id],[book_id],[b_date],[b_return])VALUES(@s_id, @b_id,@b_d,@sta)"

            sqlquery.Parameters.AddWithValue("@s_id", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@b_id", TextBox2.Text)
            sqlquery.Parameters.AddWithValue("@b_d", DateTimePicker1.Text)
            sqlquery.Parameters.AddWithValue("@sta", statu)
            sqlquery.ExecuteNonQuery()
            MessageBox.Show("Book Issued", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Database\Library.mdb")
            con.Open()
            Dim cmd As New OleDbCommand("update borrow set b_return='1'  WHERE id=" & TextBox1.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Updated Successfully", "Info")
            con.Close()
        Catch
            MessageBox.Show("Unsuccessful", "Alert")
        End Try
    End Sub

    Private Sub Borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Database\Library.mdb"
        '
        'get data into list
        Me.RefreshData()
    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT id, " & _
                                             "s_id as [Studen ID], book_id, b_date,b_return" & _
                                             " FROM borrow ORDER BY id", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class