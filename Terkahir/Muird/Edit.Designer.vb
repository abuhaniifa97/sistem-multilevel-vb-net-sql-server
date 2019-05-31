<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_murid = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.RadioButton_laki = New System.Windows.Forms.RadioButton()
        Me.RadioButton_pr = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Murid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "No hp"
        '
        'txt_murid
        '
        Me.txt_murid.Location = New System.Drawing.Point(120, 42)
        Me.txt_murid.Name = "txt_murid"
        Me.txt_murid.Size = New System.Drawing.Size(100, 20)
        Me.txt_murid.TabIndex = 7
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(120, 115)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(100, 20)
        Me.txt_alamat.TabIndex = 8
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(120, 228)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(100, 20)
        Me.txt.TabIndex = 10
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(120, 73)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(100, 20)
        Me.txt_nama.TabIndex = 11
        '
        'RadioButton_laki
        '
        Me.RadioButton_laki.AutoSize = True
        Me.RadioButton_laki.Location = New System.Drawing.Point(130, 154)
        Me.RadioButton_laki.Name = "RadioButton_laki"
        Me.RadioButton_laki.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton_laki.TabIndex = 12
        Me.RadioButton_laki.TabStop = True
        Me.RadioButton_laki.Text = "Laki-laki"
        Me.RadioButton_laki.UseVisualStyleBackColor = True
        '
        'RadioButton_pr
        '
        Me.RadioButton_pr.AutoSize = True
        Me.RadioButton_pr.Location = New System.Drawing.Point(200, 154)
        Me.RadioButton_pr.Name = "RadioButton_pr"
        Me.RadioButton_pr.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton_pr.TabIndex = 13
        Me.RadioButton_pr.TabStop = True
        Me.RadioButton_pr.Text = "Perempuan"
        Me.RadioButton_pr.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 193)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 307)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RadioButton_pr)
        Me.Controls.Add(Me.RadioButton_laki)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_murid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Edit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_murid As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents RadioButton_laki As RadioButton
    Friend WithEvents RadioButton_pr As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
