<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nop = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.TempatLahir = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.noHP = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.prodi = New System.Windows.Forms.ComboBox()
        Me.TanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nop
        '
        Me.nop.Location = New System.Drawing.Point(177, 38)
        Me.nop.Name = "nop"
        Me.nop.Size = New System.Drawing.Size(143, 20)
        Me.nop.TabIndex = 0
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(177, 105)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(143, 20)
        Me.nama.TabIndex = 1
        '
        'TempatLahir
        '
        Me.TempatLahir.Location = New System.Drawing.Point(177, 183)
        Me.TempatLahir.Name = "TempatLahir"
        Me.TempatLahir.Size = New System.Drawing.Size(143, 20)
        Me.TempatLahir.TabIndex = 2
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(177, 296)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(143, 20)
        Me.alamat.TabIndex = 4
        '
        'noHP
        '
        Me.noHP.Location = New System.Drawing.Point(177, 333)
        Me.noHP.Name = "noHP"
        Me.noHP.Size = New System.Drawing.Size(143, 20)
        Me.noHP.TabIndex = 5
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(177, 370)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(143, 20)
        Me.email.TabIndex = 6
        '
        'agama
        '
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "BUDHA", "HINDU"})
        Me.agama.Location = New System.Drawing.Point(177, 259)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(143, 21)
        Me.agama.TabIndex = 7
        '
        'prodi
        '
        Me.prodi.FormattingEnabled = True
        Me.prodi.Items.AddRange(New Object() {"TEKINIK INFORMATIKA", "TEKNIK MESIN", "TEKNIK ELEKTRO"})
        Me.prodi.Location = New System.Drawing.Point(177, 71)
        Me.prodi.Name = "prodi"
        Me.prodi.Size = New System.Drawing.Size(143, 21)
        Me.prodi.TabIndex = 10
        '
        'TanggalLahir
        '
        Me.TanggalLahir.CustomFormat = "dd/MM/yyyy"
        Me.TanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TanggalLahir.Location = New System.Drawing.Point(177, 222)
        Me.TanggalLahir.Name = "TanggalLahir"
        Me.TanggalLahir.Size = New System.Drawing.Size(143, 20)
        Me.TanggalLahir.TabIndex = 11
        Me.TanggalLahir.Value = New Date(2022, 6, 23, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No, Pendaftaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Program Studi Yang Dipilih"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama Siswa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Agama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "No. Telpom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Alamat Lengkap"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "E-Mail"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(166, 409)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(166, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Report"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(371, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(983, 394)
        Me.DataGridView1.TabIndex = 26
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.Location = New System.Drawing.Point(177, 146)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(74, 17)
        Me.rd1.TabIndex = 27
        Me.rd1.TabStop = True
        Me.rd1.Text = "Laki - Laki"
        Me.rd1.UseVisualStyleBackColor = True
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.Location = New System.Drawing.Point(252, 146)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(79, 17)
        Me.rd2.TabIndex = 28
        Me.rd2.TabStop = True
        Me.rd2.Text = "Perempuan"
        Me.rd2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(85, 409)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 52)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 478)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.rd2)
        Me.Controls.Add(Me.rd1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TanggalLahir)
        Me.Controls.Add(Me.prodi)
        Me.Controls.Add(Me.agama)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.noHP)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.TempatLahir)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nop)
        Me.Name = "Form1"
        Me.Text = "UAS SYAHRIL"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nop As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents TempatLahir As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents noHP As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents agama As ComboBox
    Friend WithEvents prodi As ComboBox
    Friend WithEvents TanggalLahir As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rd1 As RadioButton
    Friend WithEvents rd2 As RadioButton
    Friend WithEvents Button5 As Button
End Class
