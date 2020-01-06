<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_petugas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnip = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.tabelpetugas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbnamapetugas = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.cbjeniskelamin = New System.Windows.Forms.ComboBox()
        CType(Me.tabelpetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Input Data Petugas Baru"
        '
        'tbnip
        '
        Me.tbnip.Location = New System.Drawing.Point(175, 107)
        Me.tbnip.Name = "tbnip"
        Me.tbnip.Size = New System.Drawing.Size(121, 20)
        Me.tbnip.TabIndex = 1
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(175, 226)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 2
        Me.btntambah.Text = "tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'tabelpetugas
        '
        Me.tabelpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelpetugas.Location = New System.Drawing.Point(64, 266)
        Me.tabelpetugas.Name = "tabelpetugas"
        Me.tabelpetugas.Size = New System.Drawing.Size(404, 150)
        Me.tabelpetugas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = """isi dengan baik dan benar"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NIP :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Petugas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Password :"
        '
        'tbnamapetugas
        '
        Me.tbnamapetugas.Location = New System.Drawing.Point(175, 133)
        Me.tbnamapetugas.Name = "tbnamapetugas"
        Me.tbnamapetugas.Size = New System.Drawing.Size(121, 20)
        Me.tbnamapetugas.TabIndex = 8
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(175, 159)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(121, 20)
        Me.tbpassword.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Jenis Kelamin :"
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(265, 226)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(355, 226)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 13
        Me.btnhapus.Text = "hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'cbjeniskelamin
        '
        Me.cbjeniskelamin.FormattingEnabled = True
        Me.cbjeniskelamin.Items.AddRange(New Object() {"Laki laki" & Global.Microsoft.VisualBasic.ChrW(9), "Perempuan"})
        Me.cbjeniskelamin.Location = New System.Drawing.Point(175, 185)
        Me.cbjeniskelamin.Name = "cbjeniskelamin"
        Me.cbjeniskelamin.Size = New System.Drawing.Size(121, 21)
        Me.cbjeniskelamin.TabIndex = 14
        '
        'tambah_petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 447)
        Me.Controls.Add(Me.cbjeniskelamin)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbnamapetugas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabelpetugas)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.tbnip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tambah_petugas"
        Me.Text = "tambah_petugas"
        CType(Me.tabelpetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnip As System.Windows.Forms.TextBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents tabelpetugas As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbnamapetugas As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents cbjeniskelamin As System.Windows.Forms.ComboBox
End Class
