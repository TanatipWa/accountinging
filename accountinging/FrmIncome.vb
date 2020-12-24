Imports System.Data.OracleClient
Public Class FrmIncome
    Dim strConn As String
    Dim Conn As OracleConnection
    Dim cmd As OracleCommand
    Dim dr As OracleDataReader
    Dim dt As DataTable

    Private Sub Frmincome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = "Data Source=6106021610120;User Id=6106021610120;Password=6106021610120;"

        Conn = New OracleConnection(strConn)

        Conn.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sel As String
        sel = "select * from ""6106021621041"".booking where b_id = '" + TextBox1.Text + "'"
        cmd = New OracleCommand(sel, Conn)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dt = New DataTable
            dt.Load(dr)
            Me.DataGridView1.DataSource = dt

        Else
            MessageBox.Show("ERROR! No rows")
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sel As String
        sel = "select * from ""6106021621041"".booking"
        cmd = New OracleCommand(sel, Conn)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dt = New DataTable
            dt.Load(dr)
            Me.DataGridView1.DataSource = dt
        Else
            MessageBox.Show("ERROR! No rows")
            Exit Sub
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        FrmMenu.Show()
        Me.Close()
    End Sub
End Class