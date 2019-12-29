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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Sheet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SenaraiDataSet = New Senarai_Tenaga_Pengajar.SenaraiDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NamaPegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JawatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanPusatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IjazahSarjanaMasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IjazahDoktorKehormatPHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sheet1TableAdapter = New Senarai_Tenaga_Pengajar.SenaraiDataSetTableAdapters.Sheet1TableAdapter()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenaraiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Nama Pegawai", True))
        Me.TextBox1.Location = New System.Drawing.Point(167, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Sheet1BindingSource
        '
        Me.Sheet1BindingSource.DataMember = "Sheet1"
        Me.Sheet1BindingSource.DataSource = Me.SenaraiDataSet
        '
        'SenaraiDataSet
        '
        Me.SenaraiDataSet.DataSetName = "SenaraiDataSet"
        Me.SenaraiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bil. Tahun Berkhidmat di KKM"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Bil Tahun Berkhidmat di KKM", True))
        Me.TextBox2.Location = New System.Drawing.Point(163, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modul"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Modul", True))
        Me.TextBox3.Location = New System.Drawing.Point(163, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(186, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jawatan"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Jawatan", True))
        Me.TextBox4.Location = New System.Drawing.Point(163, 116)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 20)
        Me.TextBox4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jabatan/Pusat"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Jabatan Pusat", True))
        Me.TextBox5.Location = New System.Drawing.Point(163, 149)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(186, 20)
        Me.TextBox5.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ijazah Sarjana Muda"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Ijazah Sarjana Muda (Degree)", True))
        Me.TextBox6.Location = New System.Drawing.Point(163, 186)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(186, 20)
        Me.TextBox6.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ijazah Sarjana"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Ijazah Sarjana (Master)", True))
        Me.TextBox7.Location = New System.Drawing.Point(163, 217)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(186, 20)
        Me.TextBox7.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ijazah Doktor Kehormat"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Ijazah Doktor Kehormat (PHD)", True))
        Me.TextBox8.Location = New System.Drawing.Point(163, 250)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(186, 20)
        Me.TextBox8.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Email"
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Email", True))
        Me.TextBox9.Location = New System.Drawing.Point(163, 290)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(186, 20)
        Me.TextBox9.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "AddNew"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(243, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(81, 371)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(162, 371)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(243, 371)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 409)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(979, 409)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaPegawaiDataGridViewTextBoxColumn, Me.BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn, Me.ModulDataGridViewTextBoxColumn, Me.JawatanDataGridViewTextBoxColumn, Me.JabatanPusatDataGridViewTextBoxColumn, Me.IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn, Me.IjazahSarjanaMasterDataGridViewTextBoxColumn, Me.IjazahDoktorKehormatPHDDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Sheet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'NamaPegawaiDataGridViewTextBoxColumn
        '
        Me.NamaPegawaiDataGridViewTextBoxColumn.DataPropertyName = "Nama Pegawai"
        Me.NamaPegawaiDataGridViewTextBoxColumn.HeaderText = "Nama Pegawai"
        Me.NamaPegawaiDataGridViewTextBoxColumn.Name = "NamaPegawaiDataGridViewTextBoxColumn"
        '
        'BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn
        '
        Me.BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn.DataPropertyName = "Bil Tahun Berkhidmat di KKM"
        Me.BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn.HeaderText = "Bil Tahun Berkhidmat di KKM"
        Me.BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn.Name = "BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn"
        '
        'ModulDataGridViewTextBoxColumn
        '
        Me.ModulDataGridViewTextBoxColumn.DataPropertyName = "Modul"
        Me.ModulDataGridViewTextBoxColumn.HeaderText = "Modul"
        Me.ModulDataGridViewTextBoxColumn.Name = "ModulDataGridViewTextBoxColumn"
        '
        'JawatanDataGridViewTextBoxColumn
        '
        Me.JawatanDataGridViewTextBoxColumn.DataPropertyName = "Jawatan"
        Me.JawatanDataGridViewTextBoxColumn.HeaderText = "Jawatan"
        Me.JawatanDataGridViewTextBoxColumn.Name = "JawatanDataGridViewTextBoxColumn"
        '
        'JabatanPusatDataGridViewTextBoxColumn
        '
        Me.JabatanPusatDataGridViewTextBoxColumn.DataPropertyName = "Jabatan Pusat"
        Me.JabatanPusatDataGridViewTextBoxColumn.HeaderText = "Jabatan Pusat"
        Me.JabatanPusatDataGridViewTextBoxColumn.Name = "JabatanPusatDataGridViewTextBoxColumn"
        '
        'IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn
        '
        Me.IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn.DataPropertyName = "Ijazah Sarjana Muda (Degree)"
        Me.IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn.HeaderText = "Ijazah Sarjana Muda (Degree)"
        Me.IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn.Name = "IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn"
        '
        'IjazahSarjanaMasterDataGridViewTextBoxColumn
        '
        Me.IjazahSarjanaMasterDataGridViewTextBoxColumn.DataPropertyName = "Ijazah Sarjana (Master)"
        Me.IjazahSarjanaMasterDataGridViewTextBoxColumn.HeaderText = "Ijazah Sarjana (Master)"
        Me.IjazahSarjanaMasterDataGridViewTextBoxColumn.Name = "IjazahSarjanaMasterDataGridViewTextBoxColumn"
        '
        'IjazahDoktorKehormatPHDDataGridViewTextBoxColumn
        '
        Me.IjazahDoktorKehormatPHDDataGridViewTextBoxColumn.DataPropertyName = "Ijazah Doktor Kehormat (PHD)"
        Me.IjazahDoktorKehormatPHDDataGridViewTextBoxColumn.HeaderText = "Ijazah Doktor Kehormat (PHD)"
        Me.IjazahDoktorKehormatPHDDataGridViewTextBoxColumn.Name = "IjazahDoktorKehormatPHDDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'Sheet1TableAdapter
        '
        Me.Sheet1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 424)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Senarai Tenaga Pengajar"
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenaraiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SenaraiDataSet As SenaraiDataSet
    Friend WithEvents Sheet1BindingSource As BindingSource
    Friend WithEvents Sheet1TableAdapter As SenaraiDataSetTableAdapters.Sheet1TableAdapter
    Friend WithEvents NamaPegawaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BilTahunBerkhidmatDiKKMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JawatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JabatanPusatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IjazahSarjanaMudaDegreeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IjazahSarjanaMasterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IjazahDoktorKehormatPHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
