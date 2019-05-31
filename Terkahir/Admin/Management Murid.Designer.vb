<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Murid
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel_tambah = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_nohp = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_tambah.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1346, 201)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel_tambah
        '
        Me.Panel_tambah.Controls.Add(Me.DateTimePicker1)
        Me.Panel_tambah.Controls.Add(Me.ComboBox1)
        Me.Panel_tambah.Controls.Add(Me.txt_alamat)
        Me.Panel_tambah.Controls.Add(Me.txt_nohp)
        Me.Panel_tambah.Controls.Add(Me.txt_nama)
        Me.Panel_tambah.Controls.Add(Me.Label5)
        Me.Panel_tambah.Controls.Add(Me.Label4)
        Me.Panel_tambah.Controls.Add(Me.Label3)
        Me.Panel_tambah.Controls.Add(Me.Label2)
        Me.Panel_tambah.Controls.Add(Me.Label1)
        Me.Panel_tambah.Location = New System.Drawing.Point(532, 261)
        Me.Panel_tambah.Name = "Panel_tambah"
        Me.Panel_tambah.Size = New System.Drawing.Size(352, 263)
        Me.Panel_tambah.TabIndex = 1
        Me.Panel_tambah.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 148)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.ComboBox1.Location = New System.Drawing.Point(139, 100)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(136, 42)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(162, 42)
        Me.txt_alamat.TabIndex = 7
        '
        'txt_nohp
        '
        Me.txt_nohp.Location = New System.Drawing.Point(146, 189)
        Me.txt_nohp.Name = "txt_nohp"
        Me.txt_nohp.Size = New System.Drawing.Size(100, 20)
        Me.txt_nohp.TabIndex = 6
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(136, 16)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(162, 20)
        Me.txt_nama.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No Hp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Lahir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(567, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(664, 582)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(758, 582)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 39)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(614, 635)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 39)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(707, 636)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 39)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Management_Murid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel_tambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Management_Murid"
        Me.Text = "Management_Murid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_tambah.ResumeLayout(False)
        Me.Panel_tambah.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel_tambah As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_nohp As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
