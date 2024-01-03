<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.cmbProgramStudi = New System.Windows.Forms.ComboBox()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.TxtNim = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbProgramStudi
        '
        Me.cmbProgramStudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgramStudi.FormattingEnabled = True
        Me.cmbProgramStudi.Location = New System.Drawing.Point(244, 198)
        Me.cmbProgramStudi.Name = "cmbProgramStudi"
        Me.cmbProgramStudi.Size = New System.Drawing.Size(274, 33)
        Me.cmbProgramStudi.TabIndex = 19
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(244, 158)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(274, 33)
        Me.cmbJenisKelamin.TabIndex = 18
        '
        'TxtNim
        '
        Me.TxtNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNim.Location = New System.Drawing.Point(244, 120)
        Me.TxtNim.Name = "TxtNim"
        Me.TxtNim.Size = New System.Drawing.Size(274, 30)
        Me.TxtNim.TabIndex = 17
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.Location = New System.Drawing.Point(244, 84)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(274, 30)
        Me.TxtNama.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PROGRAM STUDI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "JENIS KELAMIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "KEHADIRAN MAHASISWA"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 306)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(636, 221)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(240, 251)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(81, 31)
        Me.BtnSimpan.TabIndex = 21
        Me.BtnSimpan.Text = "SAVE"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(334, 251)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(95, 31)
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.Text = "CLEAR"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(440, 251)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(81, 31)
        Me.BtnKeluar.TabIndex = 23
        Me.BtnKeluar.Text = "EXIT"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 539)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cmbProgramStudi)
        Me.Controls.Add(Me.cmbJenisKelamin)
        Me.Controls.Add(Me.TxtNim)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMenuUtama"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProgramStudi As ComboBox
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents TxtNim As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnKeluar As Button
End Class
