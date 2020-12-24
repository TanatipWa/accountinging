Imports System.Data.OracleClient
Public Class FrmOutcome
    Dim strConn As String
    Dim Conn As OracleConnection
    Dim cmd As OracleCommand
    Dim dr As OracleDataReader
    Dim dt As DataTable
    Dim sel As String

    Private Sub frmoutcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = "Data Source=6106021610120;User Id=6106021610120;Password=6106021610120;"

        Conn = New OracleConnection(strConn)

        Conn.Open()

        Dim sel1 As String
        Dim sel2 As String
        sel1 = "select * from type_of_outcome"
        sel2 = "select * from type_of_payment"
        cmd = New OracleCommand(sel1, Conn)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbType.Items.Add(dr.Item(0))
        End While
        dr = cmd.ExecuteReader

        cmd = New OracleCommand(sel2, Conn)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbPay.Items.Add(dr.Item(0))
        End While
        dr = cmd.ExecuteReader

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sel = "Insert into outcome ("
        sel += "out_id,out_date,out_name,out_type,out_amount,payment_type,out_detail)"
        sel += "values ('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox1.Text + "','" + cmbType.Text + "','" + txtAmount.Text + "','" + cmbPay.Text + "','" + txtDetail.Text + "')"
        cmd = New OracleCommand(sel, Conn)
        cmd.ExecuteReader()

        Button4.PerformClick()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sel As String
        sel = "select * from outcome"
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
        sel = "UPDATE outcome SET out_date ='" + TextBox3.Text + "',out_name='" + TextBox1.Text + "',out_type='" + cmbType.Text + "',out_amount='" + txtAmount.Text + "',payment_type='" + cmbPay.Text + "',out_detail='" + txtDetail.Text + "'where out_id ='" + TextBox2.Text + "'"
        cmd = New OracleCommand(sel, Conn)
        dr = cmd.ExecuteReader

        Button4.PerformClick()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql As String

        sql = "DELETE outcome where out_id = '" + TextBox2.Text + "'"
        cmd = New OracleCommand(sql, Conn)
        cmd.ExecuteNonQuery()

        Button4.PerformClick()

    End Sub

    Private Sub dgvShow_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShow.CellContentClick
        If e.RowIndex = -1 Then Exit Sub
        With dgvShow
            TextBox2.Text = .Rows.Item(e.RowIndex).Cells(0).Value.ToString()
            TextBox3.Text = .Rows.Item(e.RowIndex).Cells(1).Value.ToString()
            TextBox1.Text = .Rows.Item(e.RowIndex).Cells(2).Value.ToString()
            cmbType.Text = .Rows.Item(e.RowIndex).Cells(3).Value.ToString()
            txtAmount.Text = .Rows.Item(e.RowIndex).Cells(4).Value.ToString()
            cmbPay.Text = .Rows.Item(e.RowIndex).Cells(5).Value.ToString()
            txtDetail.Text = .Rows.Item(e.RowIndex).Cells(6).Value.ToString()

        End With
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()
        cmbType.ResetText()
        txtAmount.Clear()
        cmbPay.ResetText()
        txtDetail.Clear()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub cmdType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdType.Click
        Dim sel As String
        sel = "select * from outcome where out_type = '" + cmbType.Text + "'"
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

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim sel As String
        sel = "select * from outcome where out_date = '" + TextBox4.Text + "'"
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

End Class