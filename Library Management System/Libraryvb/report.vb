Imports System.Data.OleDb

Public Class report

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Database\Library.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim cmd As New OleDbCommand

        Dim dr As OleDbDataReader

        Dim status As Integer
        status = 0
        Dim ds As New DataSet
        con.Open()
        If (ComboBox1.SelectedItem = "Overall Report") Then

            Try

                Dim da As New OleDb.OleDbDataAdapter("select * from borrow", con)
                Dim dt As New DataTable
                'fill data to datatable
                da.Fill(dt)

                'offer data in data table into datagridview
                Me.DataGridView1.DataSource = dt




            Catch ex As Exception

                MsgBox(ex.ToString())

            Finally

                con.Close()

            End Try
        End If
        If (ComboBox1.SelectedItem = "Pending Report") Then
            Try

                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM borrow WHERE b_return=" & status, con)
                Dim dt As New DataTable
                'fill data to datatable
                da.Fill(dt)

                'offer data in data table into datagridview
                Me.DataGridView1.DataSource = dt




            Catch ex As Exception

                MsgBox(ex.ToString())

            Finally

            End Try
        End If
       

        con.Close()


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class