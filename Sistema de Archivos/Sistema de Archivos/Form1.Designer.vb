<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.accion_box = New System.Windows.Forms.CheckedListBox()
        Me.observaciones_txt = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.asunto_txt = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.procedencia_txt = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.requeridopara_txt = New System.Windows.Forms.DateTimePicker()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.dirigido_box = New System.Windows.Forms.CheckedListBox()
        Me.fecharecibido_date = New System.Windows.Forms.DateTimePicker()
        Me.itginp_txt = New System.Windows.Forms.TextBox()
        Me.folioginp_txt = New System.Windows.Forms.TextBox()
        Me.foliocdt_txt = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label15 = New System.Windows.Forms.Label()
        Me.asunto2_txt = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.foliocdt2_txt = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CDTDataSet = New Sistema_de_Archivos.CDTDataSet()
        Me.CDTDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CDTDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CDTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDTDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDTDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 761)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.button2)
        Me.TabPage1.Controls.Add(Me.label9)
        Me.TabPage1.Controls.Add(Me.accion_box)
        Me.TabPage1.Controls.Add(Me.observaciones_txt)
        Me.TabPage1.Controls.Add(Me.label12)
        Me.TabPage1.Controls.Add(Me.btnPDF)
        Me.TabPage1.Controls.Add(Me.asunto_txt)
        Me.TabPage1.Controls.Add(Me.label10)
        Me.TabPage1.Controls.Add(Me.procedencia_txt)
        Me.TabPage1.Controls.Add(Me.label8)
        Me.TabPage1.Controls.Add(Me.requeridopara_txt)
        Me.TabPage1.Controls.Add(Me.label7)
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Controls.Add(Me.label6)
        Me.TabPage1.Controls.Add(Me.dirigido_box)
        Me.TabPage1.Controls.Add(Me.fecharecibido_date)
        Me.TabPage1.Controls.Add(Me.itginp_txt)
        Me.TabPage1.Controls.Add(Me.folioginp_txt)
        Me.TabPage1.Controls.Add(Me.foliocdt_txt)
        Me.TabPage1.Controls.Add(Me.label5)
        Me.TabPage1.Controls.Add(Me.label4)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 735)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(591, 168)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(192, 435)
        Me.AxAcroPDF1.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(612, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Seleccione un archivo .pdf"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(359, 463)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(149, 23)
        Me.button2.TabIndex = 55
        Me.button2.Text = "Guardar Registro"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(10, 439)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(43, 13)
        Me.label9.TabIndex = 54
        Me.label9.Text = "Acción:"
        '
        'accion_box
        '
        Me.accion_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.accion_box.FormattingEnabled = True
        Me.accion_box.Items.AddRange(New Object() {"PREPARAR RESPUESTA", "PARA SU ANÁLISIS", "PARA SU CONOCIMIENTO", "TRAMITE CONDUCENTE", "TRATAR PRÓXIMO ACUERDO", "ARCHIVAR"})
        Me.accion_box.Location = New System.Drawing.Point(10, 477)
        Me.accion_box.Name = "accion_box"
        Me.accion_box.Size = New System.Drawing.Size(203, 90)
        Me.accion_box.TabIndex = 53
        '
        'observaciones_txt
        '
        Me.observaciones_txt.Location = New System.Drawing.Point(304, 288)
        Me.observaciones_txt.Multiline = True
        Me.observaciones_txt.Name = "observaciones_txt"
        Me.observaciones_txt.Size = New System.Drawing.Size(257, 131)
        Me.observaciones_txt.TabIndex = 52
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(383, 272)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(78, 13)
        Me.label12.TabIndex = 51
        Me.label12.Text = "Observaciones"
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(649, 114)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(66, 32)
        Me.btnPDF.TabIndex = 50
        Me.btnPDF.Text = "Abrir"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'asunto_txt
        '
        Me.asunto_txt.Location = New System.Drawing.Point(330, 215)
        Me.asunto_txt.Multiline = True
        Me.asunto_txt.Name = "asunto_txt"
        Me.asunto_txt.Size = New System.Drawing.Size(185, 42)
        Me.asunto_txt.TabIndex = 49
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(404, 194)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(55, 13)
        Me.label10.TabIndex = 48
        Me.label10.Text = "ASUNTO:"
        '
        'procedencia_txt
        '
        Me.procedencia_txt.Location = New System.Drawing.Point(359, 141)
        Me.procedencia_txt.Name = "procedencia_txt"
        Me.procedencia_txt.Size = New System.Drawing.Size(100, 20)
        Me.procedencia_txt.TabIndex = 47
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(283, 144)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(70, 13)
        Me.label8.TabIndex = 46
        Me.label8.Text = "Procedencia:"
        '
        'requeridopara_txt
        '
        Me.requeridopara_txt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.requeridopara_txt.Location = New System.Drawing.Point(359, 117)
        Me.requeridopara_txt.Name = "requeridopara_txt"
        Me.requeridopara_txt.Size = New System.Drawing.Size(100, 20)
        Me.requeridopara_txt.TabIndex = 45
        Me.requeridopara_txt.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(269, 124)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(84, 13)
        Me.label7.TabIndex = 44
        Me.label7.Text = "Requerido Para:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Location = New System.Drawing.Point(346, 61)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(178, 15)
        Me.label1.TabIndex = 43
        Me.label1.Text = "Agregue los datos correspondientes"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(10, 244)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 13)
        Me.label6.TabIndex = 42
        Me.label6.Text = "Dirigido a:"
        '
        'dirigido_box
        '
        Me.dirigido_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dirigido_box.CheckOnClick = True
        Me.dirigido_box.FormattingEnabled = True
        Me.dirigido_box.Items.AddRange(New Object() {"ING. AGUSTIN G. PATIÑO ACENCIO", "ING. JOSÉ ANTONIO BARAJAS CORONADO", "ING. ARMANDO AYALA ABREU", "ING. JORGE GARCÍA LÓPEZ", "FIS. RUBÉN LLARENA FERNÁNDEZ DE LARA", "ING. RAÚL CONTRERAS BUENDÍA", "LIC. JESSICA MICHAELLE HERNÁNDEZ FERNÁNDEZ", "C. CLAUDIA CARAPIA GUEVARA", "LIC. ARTURO SILES BUENDÍA", "LIC. ABRAHAM I. GUZMÁN BUSTAMANTE"})
        Me.dirigido_box.Location = New System.Drawing.Point(10, 269)
        Me.dirigido_box.Name = "dirigido_box"
        Me.dirigido_box.Size = New System.Drawing.Size(315, 150)
        Me.dirigido_box.TabIndex = 41
        '
        'fecharecibido_date
        '
        Me.fecharecibido_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecibido_date.Location = New System.Drawing.Point(140, 143)
        Me.fecharecibido_date.Name = "fecharecibido_date"
        Me.fecharecibido_date.Size = New System.Drawing.Size(100, 20)
        Me.fecharecibido_date.TabIndex = 40
        Me.fecharecibido_date.Value = New Date(2018, 6, 19, 0, 0, 0, 0)
        '
        'itginp_txt
        '
        Me.itginp_txt.Location = New System.Drawing.Point(140, 194)
        Me.itginp_txt.Name = "itginp_txt"
        Me.itginp_txt.Size = New System.Drawing.Size(100, 20)
        Me.itginp_txt.TabIndex = 39
        '
        'folioginp_txt
        '
        Me.folioginp_txt.Location = New System.Drawing.Point(140, 168)
        Me.folioginp_txt.Name = "folioginp_txt"
        Me.folioginp_txt.Size = New System.Drawing.Size(100, 20)
        Me.folioginp_txt.TabIndex = 38
        '
        'foliocdt_txt
        '
        Me.foliocdt_txt.Location = New System.Drawing.Point(140, 120)
        Me.foliocdt_txt.Name = "foliocdt_txt"
        Me.foliocdt_txt.Size = New System.Drawing.Size(100, 20)
        Me.foliocdt_txt.TabIndex = 37
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(37, 149)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(97, 13)
        Me.label5.TabIndex = 36
        Me.label5.Text = "Fecha de Recibido"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(83, 201)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 13)
        Me.label4.TabIndex = 35
        Me.label4.Text = "OT GINP"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(76, 175)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(58, 13)
        Me.label3.TabIndex = 34
        Me.label3.Text = "Folio GINP"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(80, 127)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Folio CDT"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.button3)
        Me.TabPage2.Controls.Add(Me.label15)
        Me.TabPage2.Controls.Add(Me.asunto2_txt)
        Me.TabPage2.Controls.Add(Me.label13)
        Me.TabPage2.Controls.Add(Me.foliocdt2_txt)
        Me.TabPage2.Controls.Add(Me.label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 735)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(356, 114)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(153, 49)
        Me.button3.TabIndex = 37
        Me.button3.Text = "Consultar/Ver"
        Me.button3.UseVisualStyleBackColor = True
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(382, 49)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(51, 13)
        Me.label15.TabIndex = 36
        Me.label15.Text = "Consulta "
        '
        'asunto2_txt
        '
        Me.asunto2_txt.Location = New System.Drawing.Point(118, 143)
        Me.asunto2_txt.Name = "asunto2_txt"
        Me.asunto2_txt.Size = New System.Drawing.Size(161, 20)
        Me.asunto2_txt.TabIndex = 35
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(58, 150)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(55, 13)
        Me.label13.TabIndex = 34
        Me.label13.Text = "ASUNTO:"
        '
        'foliocdt2_txt
        '
        Me.foliocdt2_txt.Location = New System.Drawing.Point(118, 116)
        Me.foliocdt2_txt.Name = "foliocdt2_txt"
        Me.foliocdt2_txt.Size = New System.Drawing.Size(100, 20)
        Me.foliocdt2_txt.TabIndex = 33
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(58, 123)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(54, 13)
        Me.label14.TabIndex = 32
        Me.label14.Text = "Folio CDT"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CDTDataSet
        '
        Me.CDTDataSet.DataSetName = "CDTDataSet"
        Me.CDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CDTDataSetBindingSource
        '
        Me.CDTDataSetBindingSource.DataSource = Me.CDTDataSet
        Me.CDTDataSetBindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 419)
        Me.DataGridView1.TabIndex = 38
        '
        'CDTDataSetBindingSource1
        '
        Me.CDTDataSetBindingSource1.DataSource = Me.CDTDataSet
        Me.CDTDataSetBindingSource1.Position = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 756)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CDTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDTDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDTDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents button2 As Button
    Private WithEvents label9 As Label
    Private WithEvents accion_box As CheckedListBox
    Private WithEvents observaciones_txt As TextBox
    Private WithEvents label12 As Label
    Private WithEvents btnPDF As Button
    Private WithEvents asunto_txt As TextBox
    Private WithEvents label10 As Label
    Private WithEvents procedencia_txt As TextBox
    Private WithEvents label8 As Label
    Private WithEvents requeridopara_txt As DateTimePicker
    Private WithEvents label7 As Label
    Private WithEvents label1 As Label
    Private WithEvents label6 As Label
    Private WithEvents dirigido_box As CheckedListBox
    Private WithEvents fecharecibido_date As DateTimePicker
    Private WithEvents itginp_txt As TextBox
    Private WithEvents folioginp_txt As TextBox
    Private WithEvents foliocdt_txt As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents button3 As Button
    Private WithEvents label15 As Label
    Private WithEvents asunto2_txt As TextBox
    Private WithEvents label13 As Label
    Private WithEvents foliocdt2_txt As TextBox
    Private WithEvents label14 As Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Private WithEvents Label11 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CDTDataSetBindingSource As BindingSource
    Friend WithEvents CDTDataSet As CDTDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CDTDataSetBindingSource1 As BindingSource
End Class
