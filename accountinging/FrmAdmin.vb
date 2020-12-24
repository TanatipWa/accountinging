Imports System.Data.OracleClient
Public Class Frmadmin
    Dim strConn As String
    Dim Conn As OracleConnection
    Dim cmd As OracleCommand
    Dim dr As OracleDataReader
    Dim dt As DataTable
    Dim sel As String

    Private Sub frmadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = "Data Source=6106021610120;User Id=6106021610120;Password=6106021610120;"

        Conn = New OracleConnection(strConn)

        Conn.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sel = "Insert into user_admin ("
        sel += "log_user,log_pass)"
        sel += "values ('" + TextBox2.Text + "' , '" + TextBox1.Text + "')"
        cmd = New OracleCommand(sel, Conn)
        cmd.ExecuteReader()

        Button4.PerformClick()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sel As String
        sel = "select * from user_admin"
        cmd = New OracleCommand(sel, Conn)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dt = New DataTable
            dt.Load(dr)
            Me.dgvShow.DataSource = dt

        Else
            MessageBox.Show("ERROR! No rows")
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sel As String
        sel = "UPDATE user_admin SET log_pass ='" + TextBox1.Text + "'where log_user ='" + TextBox2.Text + "'"
        cmd = New OracleCommand(sel, Conn)
        dr = cmd.ExecuteReader

        Button4.PerformClick()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql As String

        sql = "DELETE user_admin where log_user = '" + TextBox2.Text + "'"
        cmd = New OracleCommand(sql, Conn)
        cmd.ExecuteNonQuery()

        Button4.PerformClick()

    End Sub

    Private Sub dgvShow_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShow.CellContentClick
        If e.RowIndex = -1 Then Exit Sub
        With dgvShow
            TextBox2.Text = .Rows.Item(e.RowIndex).Cells(0).Value.ToString()
            TextBox1.Text = .Rows.Item(e.RowIndex).Cells(1).Value.ToString()

        End With
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        TextBox2.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub cmdType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdType.Click
        Dim sel As String
        sel = "select * from user_admin where log_user = '" + TextBox2.Text + "'"
        cmd = New OracleCommand(sel, Conn)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dt = New DataTable
            dt.Load(dr)
            Me.dgvShow.DataSource = dt

        Else
            MessageBox.Show("ERROR! No rows")
            Exit Sub
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class