Public Class student
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TextBox2.Text = ""
        'TextBox3.Text = ""
        'TextBox4.Text = ""

    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT s_id as [ID], " & _
                                             "s_name as [Name], gender, phone, address " & _
                                             " FROM student ORDER BY s_id", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.dgvData.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim sqlconn As New OleDb.OleDbConnection
        '    Dim sqlquery As New OleDb.OleDbCommand
        '    Dim connString As String
        '    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DonzKharz\Desktop\Project\Library\Libraryvb\Database\Library.mdb"
        '    sqlconn.ConnectionString = connString
        '    sqlquery.Connection = sqlconn
        '    sqlconn.Open()
        '    sqlquery.CommandText = "INSERT INTO student([s_id],[s_name],[department], [course])VALUES(@s_id, @s_name,@department,@course)"
        '    sqlquery.Parameters.AddWithValue("@s_id", TextBox1.Text)
        '    sqlquery.Parameters.AddWithValue("@s_name", TextBox2.Text)
        '    sqlquery.Parameters.AddWithValue("@department", TextBox3.Text)
        '    sqlquery.Parameters.AddWithValue("@course", TextBox4.Text)
        '    sqlquery.ExecuteNonQuery()
        '    MessageBox.Show("Insert SuccessFully", "Information")
        '    sqlconn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Database\Library.mdb"
        '
        'get data into list
        Me.RefreshData()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim cmd As New OleDb.OleDbCommand

        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If

        cmd.Connection = cnn
        'check whether add new or update
        If Me.txtstdID.Tag & "" = "" Then
            'add new 
            'add data to table
            cmd.CommandText = "INSERT INTO student(s_id, s_name, gender, phone, address) " & _
                            " VALUES(" & Me.txtstdID.Text & ",'" & Me.txtStdName.Text & "','" & _
                            Me.cboGender.Text & "','" & Me.txtPhone.Text & "','" & _
                            Me.txtAddress.Text & "')"
            cmd.ExecuteNonQuery()
        Else
            'update data in table
            cmd.CommandText = "UPDATE student " & _
                        " SET s_id=" & Me.txtstdID.Text & _
                        ", s_name='" & Me.txtStdName.Text & "'" & _
                        ", gender='" & Me.cboGender.Text & "'" & _
                        ", phone='" & Me.txtPhone.Text & "'" & _
                        ", address='" & Me.txtAddress.Text & "'" & _
                        " WHERE s_id=" & Me.txtstdID.Tag
            cmd.ExecuteNonQuery()
        End If
        'refresh data in list
        RefreshData()
        'clear form
        Me.btnClear.PerformClick()

        'close connection
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'check for the selected item in list
        If Me.dgvData.Rows.Count > 0 Then
            If Me.dgvData.SelectedRows.Count > 0 Then
                Dim intStdID As Integer = Me.dgvData.SelectedRows(0).Cells("id").Value
                'get data from database followed by student id
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                'get data into datatable
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM student " & _
                                                     " WHERE s_id=" & intStdID, cnn)
                Dim dt As New DataTable
                da.Fill(dt)

                Me.txtstdID.Text = intStdID
                Me.txtStdName.Text = dt.Rows(0).Item("s_name")
                Me.cboGender.Text = dt.Rows(0).Item("gender")
                Me.txtPhone.Text = dt.Rows(0).Item("phone")
                Me.txtAddress.Text = dt.Rows(0).Item("address")
                '
                'hide the id to be edited in TAG of txtstdid in case id is changed
                Me.txtstdID.Tag = intStdID
                'change button add to update
                Me.btnAdd.Text = "Update"
                'disable button edit
                Me.btnEdit.Enabled = False
                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'check for the selected item in list
        If Me.dgvData.Rows.Count > 0 Then
            If Me.dgvData.SelectedRows.Count > 0 Then
                Dim intStdID As Integer = Me.dgvData.SelectedRows(0).Cells("id").Value
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If

                'delete data
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM student WHERE s_id=" & intStdID
                cmd.ExecuteNonQuery()
                'refresh data
                Me.RefreshData()

                'close connection
                cnn.Close()
            End If
        End If
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtstdID.Text = ""
        Me.txtStdName.Text = ""
        Me.txtPhone.Text = ""
        Me.txtAddress.Text = ""
        Me.txtstdID.Tag = ""
        'enable button edit
        Me.btnEdit.Enabled = True
        'set button add to add label
        Me.btnAdd.Text = "Add"
        '
        Me.txtstdID.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class