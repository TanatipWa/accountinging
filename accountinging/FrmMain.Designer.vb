<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnExitt = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstTimee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timTimee = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnExitt})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1012, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnExitt
        '
        Me.mnExitt.Name = "mnExitt"
        Me.mnExitt.Size = New System.Drawing.Size(96, 20)
        Me.mnExitt.Text = "&ออกจากโปรแกรม"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.tstTimee})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 560)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1012, 22)
        Me.StatusStrip2.TabIndex = 2
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(146, 17)
        Me.ToolStripStatusLabel2.Text = "ระบบบัญชี 4SHARE Hostel"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'tstTimee
        '
        Me.tstTimee.AutoSize = False
        Me.tstTimee.Name = "tstTimee"
        Me.tstTimee.Size = New System.Drawing.Size(400, 17)
        '
        'timTimee
        '
        Me.timTimee.Interval = 1000
        '
        'FrmMain
        '
        Me.BackgroundImage = Global.accountinging.My.Resources.Resources.IMG_5160
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1012, 582)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมบัญชี 4SHARE Hostel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timTime As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnExitt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstTimee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timTimee As System.Windows.Forms.Timer

End Class
