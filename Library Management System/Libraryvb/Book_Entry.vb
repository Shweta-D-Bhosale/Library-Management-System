Public Class Book_Entry
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Database\Library.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO book([book_id],[b_name],[b_author], [b_category])VALUES(@id, @name,@b_a,@b_c)"
            sqlquery.Parameters.AddWithValue("@id", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@name", TextBox2.Text)
            sqlquery.Parameters.AddWithValue("@b_a", TextBox3.Text)
            sqlquery.Parameters.AddWithValue("@b_c", TextBox4.Text)
            sqlquery.ExecuteNonQuery()
            RefreshData()
            MessageBox.Show("Insert SuccessFully", "Information")
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Book_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim da As New OleDb.OleDbDataAdapter("SELECT book_id as [ID], " & _
                                             "b_name as [Name], b_author, b_category" & _
                                             " FROM book ORDER BY book_id", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'check for the selected item in list
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intStdID As Integer = Me.DataGridView1.SelectedRows(0).Cells("id").Value
                'get data from database followed by student id
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                'get data into datatable
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM book " & _
                                                     " WHERE book_id=" & intStdID, cnn)
                Dim dt As New DataTable
                da.Fill(dt)

                Me.TextBox1.Text = intStdID
                Me.TextBox1.Text = dt.Rows(0).Item("b_name")
                Me.TextBox1.Text = dt.Rows(0).Item("b_author")
                Me.TextBox1.Text = dt.Rows(0).Item("b_category")

                '
                'hide the id to be edited in TAG of txtstdid in case id is changed
                Me.TextBox1.Tag = intStdID
                'change button add to update
            
                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'check for the selected item in list
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intStdID As Integer = Me.DataGridView1.SelectedRows(0).Cells("id").Value
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If

                'delete data
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM book WHERE book_id=" & intStdID
                cmd.ExecuteNonQuery()
                'refresh data
                Me.RefreshData()

                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class