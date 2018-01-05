<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.pb5MonkeysLogo = New System.Windows.Forms.PictureBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.pb5MonkeysLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb5MonkeysLogo
        '
        Me.pb5MonkeysLogo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pb5MonkeysLogo.Image = CType(resources.GetObject("pb5MonkeysLogo.Image"), System.Drawing.Image)
        Me.pb5MonkeysLogo.Location = New System.Drawing.Point(5, 5)
        Me.pb5MonkeysLogo.Name = "pb5MonkeysLogo"
        Me.pb5MonkeysLogo.Size = New System.Drawing.Size(290, 143)
        Me.pb5MonkeysLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb5MonkeysLogo.TabIndex = 0
        Me.pb5MonkeysLogo.TabStop = False
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtInfo.Font = New System.Drawing.Font("Zolano Sans BTN", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(5, 154)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(290, 89)
        Me.txtInfo.TabIndex = 1
        Me.txtInfo.Text = "            Version: 1.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   5 Monkeys Billing System " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         © Copyright 20" & _
            "12"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 249)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(283, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 285)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.pb5MonkeysLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About "
        CType(Me.pb5MonkeysLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb5MonkeysLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
