Imports System.Data.OracleClient
Public Class Frmreport
    Dim strConn As String
    Dim Conn As OracleConnection
    Dim cmd As OracleCommand
    Dim dr As OracleDataReader
    Dim dr2 As OracleDataReader
    Dim dt As DataTable
    Dim sel As String

    Private Sub frmreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = "Data Source=6106021610120;User Id=6106021610120;Password=6106021610120;"

        Conn = New OracleConnection(strConn)

        Conn.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sel1 As String
        Dim sel2 As String
        sel1 = "select sum(total_price) from ""6106021621041"".booking where date_checkin between '" + TextBox1.Text + "' and + '" + TextBox2.Text + "'"
        sel2 = "select sum(out_amount) from outcome where out_date between '" + TextBox1.Text + "' and + '" + TextBox2.Text + "'"
        cmd = New OracleCommand(sel1, Conn)
        dr = cmd.ExecuteReader

        While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        End While
        dr = cmd.ExecuteReader

        cmd = New OracleCommand(sel2, Conn)
        dr = cmd.ExecuteReader

        While dr.Read
            ComboBox2.Items.Add(dr.Item(0))
        End While
        dr = cmd.ExecuteReader


        'Dim sql3 As String
        'sql3 = "truncate table report_accounting"
        'cmd = New OracleCommand(sql3, Conn)
        'cmd.ExecuteNonQuery()

        'Dim money As String
        'Dim text As String

        'Dim sel As String
        'sel = "select sum(total_price) from ""6106021621041"".booking where date_checkin between '" + TextBox1.Text + "' and + '" + TextBox2.Text + "'"

        'Dim sel1 As String
        'sel1 = "select sum(out_amount) from outcome where out_date between '" + TextBox1.Text + "' and + '" + TextBox2.Text + "'"
        'cmd = New OracleCommand(sel1, Conn)
        'cmd.ExecuteReader()
        'TextBox1.Text = cmd

        'If money < 0 Then
        '    text = "ขาดทุน"
        'Else
        '    text = "กำไร"
        'End If


        'Dim sel2 As String
        'sel2 = "UPDATE outcome SET out_date ='" + TextBox3.Text + "',out_name='" + TextBox1.Text + "',out_type='" + cmbType.Text + "',out_amount='" + txtAmount.Text + "',payment_type='" + cmbPay.Text + "',out_detail='" + txtDetail.Text + "'where out_id ='" + TextBox2.Text + "'"
        'cmd = New OracleCommand(sel2, Conn)
        'dr = cmd.ExecuteReader


    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        FrmMenu.Show()
        Me.Close()
    End Sub
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sel = "Insert into report_accounting ("
        sel += "start_date,end_date,income,outcome)"
        sel += "values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "')"
        cmd = New OracleCommand(sel, Conn)
        cmd.ExecuteReader()

        Dim sel2 As String
        sel2 = "select * from report_accounting"
        cmd = New OracleCommand(sel2, Conn)
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
End Class