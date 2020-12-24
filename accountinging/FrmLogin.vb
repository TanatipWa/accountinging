Imports System.Data.OracleClient
Public Class FrmLogin
    Dim strConn As String
    Dim Conn As OracleConnection
    Dim cmd As OracleCommand
    Dim dr As OracleDataReader
    Dim dt As DataTable
    Dim sel As String
    
    Private Sub Frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        strConn = "Data Source=6106021610120;User Id=6106021610120;Password=6106021610120;"

        Conn = New OracleConnection(strConn)

        Conn.Open()

        Dim intNumRows As Integer
        sel = "SELECT COUNT(*) FROM user_admin WHERE log_user = '" & Me.TextBox3.Text & "' AND log_pass = '" & Me.TextBox4.Text & "' "
        cmd = New OracleCommand(sel, Conn)
        intNumRows = cmd.ExecuteScalar

        If intNumRows > 0 Then

            MsgBox("You are Now Logged In", MsgBoxStyle.Information, "Login")
            FrmMenu.Show()
            Me.Close()
        Else

            If TextBox3.Text = "" And TextBox4.Text = "" Then
                MsgBox("No Username and/or Password Found!", MsgBoxStyle.Critical, "Error")
            Else

                If TextBox3.Text = "" Then
                    MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
                Else

                    If TextBox4.Text = "" Then
                        MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")

                    Else
                        MsgBox("Invalid Username And/Or Password!", MsgBoxStyle.Critical, "Error")


                    End If

                End If
            End If

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

End Class