<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Utama
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
        Me.Panel_guru = New System.Windows.Forms.Panel()
        Me.btn_logut = New System.Windows.Forms.Button()
        Me.btn_mengajarguru = New System.Windows.Forms.Button()
        Me.btn_editguru = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_header = New System.Windows.Forms.Label()
        Me.panel_admin = New System.Windows.Forms.Panel()
        Me.btn_logutadmin = New System.Windows.Forms.Button()
        Me.btn_managemntjadwal = New System.Windows.Forms.Button()
        Me.btn_managementkelas = New System.Windows.Forms.Button()
        Me.btn_managemntguru = New System.Windows.Forms.Button()
        Me.btn_mangemntmurid = New System.Windows.Forms.Button()
        Me.Panel_guru.SuspendLayout()
        Me.panel_admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_guru
        '
        Me.Panel_guru.Controls.Add(Me.btn_logut)
        Me.Panel_guru.Controls.Add(Me.btn_mengajarguru)
        Me.Panel_guru.Controls.Add(Me.btn_editguru)
        Me.Panel_guru.Location = New System.Drawing.Point(38, 100)
        Me.Panel_guru.Name = "Panel_guru"
        Me.Panel_guru.Size = New System.Drawing.Size(201, 140)
        Me.Panel_guru.TabIndex = 0
        '
        'btn_logut
        '
        Me.btn_logut.Location = New System.Drawing.Point(0, 96)
        Me.btn_logut.Name = "btn_logut"
        Me.btn_logut.Size = New System.Drawing.Size(201, 41)
        Me.btn_logut.TabIndex = 3
        Me.btn_logut.Text = "Logut"
        Me.btn_logut.UseVisualStyleBackColor = True
        '
        'btn_mengajarguru
        '
        Me.btn_mengajarguru.Location = New System.Drawing.Point(0, 54)
        Me.btn_mengajarguru.Name = "btn_mengajarguru"
        Me.btn_mengajarguru.Size = New System.Drawing.Size(201, 42)
        Me.btn_mengajarguru.TabIndex = 2
        Me.btn_mengajarguru.Text = "Jadwal Mengajar"
        Me.btn_mengajarguru.UseVisualStyleBackColor = True
        '
        'btn_editguru
        '
        Me.btn_editguru.Location = New System.Drawing.Point(0, 10)
        Me.btn_editguru.Name = "btn_editguru"
        Me.btn_editguru.Size = New System.Drawing.Size(201, 44)
        Me.btn_editguru.TabIndex = 1
        Me.btn_editguru.Text = "Edit Guru"
        Me.btn_editguru.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Walcome,"
        '
        'Label_header
        '
        Me.Label_header.AutoSize = True
        Me.Label_header.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_header.Location = New System.Drawing.Point(136, 43)
        Me.Label_header.Name = "Label_header"
        Me.Label_header.Size = New System.Drawing.Size(103, 24)
        Me.Label_header.TabIndex = 2
        Me.Label_header.Text = "Walcome,"
        '
        'panel_admin
        '
        Me.panel_admin.Controls.Add(Me.btn_logutadmin)
        Me.panel_admin.Controls.Add(Me.btn_managemntjadwal)
        Me.panel_admin.Controls.Add(Me.btn_managementkelas)
        Me.panel_admin.Controls.Add(Me.btn_managemntguru)
        Me.panel_admin.Controls.Add(Me.btn_mangemntmurid)
        Me.panel_admin.Location = New System.Drawing.Point(33, 70)
        Me.panel_admin.Name = "panel_admin"
        Me.panel_admin.Size = New System.Drawing.Size(203, 192)
        Me.panel_admin.TabIndex = 3
        '
        'btn_logutadmin
        '
        Me.btn_logutadmin.Location = New System.Drawing.Point(3, 154)
        Me.btn_logutadmin.Name = "btn_logutadmin"
        Me.btn_logutadmin.Size = New System.Drawing.Size(200, 35)
        Me.btn_logutadmin.TabIndex = 8
        Me.btn_logutadmin.Text = "Logut"
        Me.btn_logutadmin.UseVisualStyleBackColor = True
        '
        'btn_managemntjadwal
        '
        Me.btn_managemntjadwal.Location = New System.Drawing.Point(3, 119)
        Me.btn_managemntjadwal.Name = "btn_managemntjadwal"
        Me.btn_managemntjadwal.Size = New System.Drawing.Size(200, 35)
        Me.btn_managemntjadwal.TabIndex = 7
        Me.btn_managemntjadwal.Text = "Management Jadwal"
        Me.btn_managemntjadwal.UseVisualStyleBackColor = True
        '
        'btn_managementkelas
        '
        Me.btn_managementkelas.Location = New System.Drawing.Point(2, 83)
        Me.btn_managementkelas.Name = "btn_managementkelas"
        Me.btn_managementkelas.Size = New System.Drawing.Size(200, 35)
        Me.btn_managementkelas.TabIndex = 6
        Me.btn_managementkelas.Text = "Management Kelas"
        Me.btn_managementkelas.UseVisualStyleBackColor = True
        '
        'btn_managemntguru
        '
        Me.btn_managemntguru.Location = New System.Drawing.Point(3, 47)
        Me.btn_managemntguru.Name = "btn_managemntguru"
        Me.btn_managemntguru.Size = New System.Drawing.Size(200, 35)
        Me.btn_managemntguru.TabIndex = 5
        Me.btn_managemntguru.Text = "Management Guru"
        Me.btn_managemntguru.UseVisualStyleBackColor = True
        '
        'btn_mangemntmurid
        '
        Me.btn_mangemntmurid.Location = New System.Drawing.Point(3, 11)
        Me.btn_mangemntmurid.Name = "btn_mangemntmurid"
        Me.btn_mangemntmurid.Size = New System.Drawing.Size(200, 35)
        Me.btn_mangemntmurid.TabIndex = 4
        Me.btn_mangemntmurid.Text = "Management Murid"
        Me.btn_mangemntmurid.UseVisualStyleBackColor = True
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.panel_admin)
        Me.Controls.Add(Me.Label_header)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_guru)
        Me.Name = "Form_Utama"
        Me.Text = "Form_Utama"
        Me.Panel_guru.ResumeLayout(False)
        Me.panel_admin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_guru As Panel
    Friend WithEvents btn_logut As Button
    Friend WithEvents btn_mengajarguru As Button
    Friend WithEvents btn_editguru As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_header As Label
    Friend WithEvents panel_admin As Panel
    Friend WithEvents btn_logutadmin As Button
    Friend WithEvents btn_managemntjadwal As Button
    Friend WithEvents btn_managementkelas As Button
    Friend WithEvents btn_managemntguru As Button
    Friend WithEvents btn_mangemntmurid As Button
End Class
