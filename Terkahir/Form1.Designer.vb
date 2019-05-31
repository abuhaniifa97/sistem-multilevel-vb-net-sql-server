<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_hilang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(101, 217)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(70, 104)
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(142, 31)
        Me.txt_user.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(70, 163)
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(142, 28)
        Me.txt_pass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-2, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 70)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_hilang
        '
        Me.lbl_hilang.AutoSize = True
        Me.lbl_hilang.Location = New System.Drawing.Point(218, 88)
        Me.lbl_hilang.Name = "lbl_hilang"
        Me.lbl_hilang.Size = New System.Drawing.Size(55, 13)
        Me.lbl_hilang.TabIndex = 6
        Me.lbl_hilang.Text = "Username"
        Me.lbl_hilang.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 271)
        Me.Controls.Add(Me.lbl_hilang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_hilang As Label
End Class
