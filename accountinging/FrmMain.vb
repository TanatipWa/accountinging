Public Class FrmMain

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Frm As Form
        Frm = New FrmLogin
        Frm.MdiParent = Me
        Frm.Show()

        timTimee.Enabled = True

    End Sub

    Private Sub mnExitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnExitt.Click
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "ตรวจสอบ", MessageBoxButtons.YesNo _
                           , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub timTimee_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timTimee.Tick
        tstTimee.Text = "เวลาปัจจุบัน : " & Now.AddSeconds(1).ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class
