<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ArcPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
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
        Me.fecharecibido_date = New System.Windows.Forms.DateTimePicker()
        Me.otginp_txt = New System.Windows.Forms.TextBox()
        Me.folioginp_txt = New System.Windows.Forms.TextBox()
        Me.foliocdt_txt = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.observaciones2_txt = New System.Windows.Forms.TextBox()
        Me.ArcPDF2 = New AxAcroPDFLib.AxAcroPDF()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.foliocdt2_txt = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CDTDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CDTDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CDTDataSet = New Sistema_de_Archivos.CDTDataSet()
        Me.MostrarForm2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ArcPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ArcPDF2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDTDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDTDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1231, 865)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.txt_ruta)
        Me.TabPage1.Controls.Add(Me.CheckBox16)
        Me.TabPage1.Controls.Add(Me.CheckBox15)
        Me.TabPage1.Controls.Add(Me.CheckBox14)
        Me.TabPage1.Controls.Add(Me.CheckBox13)
        Me.TabPage1.Controls.Add(Me.CheckBox12)
        Me.TabPage1.Controls.Add(Me.CheckBox11)
        Me.TabPage1.Controls.Add(Me.CheckBox10)
        Me.TabPage1.Controls.Add(Me.CheckBox9)
        Me.TabPage1.Controls.Add(Me.CheckBox8)
        Me.TabPage1.Controls.Add(Me.CheckBox7)
        Me.TabPage1.Controls.Add(Me.CheckBox6)
        Me.TabPage1.Controls.Add(Me.CheckBox5)
        Me.TabPage1.Controls.Add(Me.CheckBox4)
        Me.TabPage1.Controls.Add(Me.CheckBox3)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.ArcPDF)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Guardar)
        Me.TabPage1.Controls.Add(Me.label9)
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
        Me.TabPage1.Controls.Add(Me.fecharecibido_date)
        Me.TabPage1.Controls.Add(Me.otginp_txt)
        Me.TabPage1.Controls.Add(Me.folioginp_txt)
        Me.TabPage1.Controls.Add(Me.foliocdt_txt)
        Me.TabPage1.Controls.Add(Me.label5)
        Me.TabPage1.Controls.Add(Me.label4)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1223, 839)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Enabled = False
        Me.txt_ruta.Location = New System.Drawing.Point(788, 91)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(215, 20)
        Me.txt_ruta.TabIndex = 74
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(7, 536)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox16.TabIndex = 73
        Me.CheckBox16.Text = "ARCHIVAR"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(7, 513)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(179, 17)
        Me.CheckBox15.TabIndex = 72
        Me.CheckBox15.Text = "TRATAR PRÓXIMO ACUERDO"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(7, 490)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox14.TabIndex = 71
        Me.CheckBox14.Text = "TRÁMITE CONDUCENTE"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(7, 467)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(159, 17)
        Me.CheckBox13.TabIndex = 70
        Me.CheckBox13.Text = "PARA SU CONOCIMIENTO"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(7, 444)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox12.TabIndex = 69
        Me.CheckBox12.Text = "PARA SU ANÁLISIS"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(7, 421)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox11.TabIndex = 68
        Me.CheckBox11.Text = "PREPARAR RESPUESTA"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(283, 349)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(237, 17)
        Me.CheckBox10.TabIndex = 67
        Me.CheckBox10.Text = "LIC. ABRAHAM I. GUZMAN BUSTAMANTE"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(283, 326)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(178, 17)
        Me.CheckBox9.TabIndex = 66
        Me.CheckBox9.Text = "LIC. ARTURO SILES BUENDÍA"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(283, 303)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(189, 17)
        Me.CheckBox8.TabIndex = 65
        Me.CheckBox8.Text = "C. CLAUDIA CARAPIA GUEVERA"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(283, 280)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(294, 17)
        Me.CheckBox7.TabIndex = 64
        Me.CheckBox7.Text = "LIC. JESSICA MICHAELLE HERNÁNDEZ FERNÁNDEZ"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(283, 257)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(201, 17)
        Me.CheckBox6.TabIndex = 63
        Me.CheckBox6.Text = "ING. RAÚL CONTRERAS BUENDÍA"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(7, 349)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(256, 17)
        Me.CheckBox5.TabIndex = 62
        Me.CheckBox5.Text = "FIS. RUBÉN LLARENA FERNÁNDEZ DE LARA"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(7, 326)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(168, 17)
        Me.CheckBox4.TabIndex = 61
        Me.CheckBox4.Text = "ING. JORGE GARCÍA LÓPEZ"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(7, 303)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(183, 17)
        Me.CheckBox3.TabIndex = 60
        Me.CheckBox3.Text = "ING. ARMANDO AYALA ABREU"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 280)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(246, 17)
        Me.CheckBox2.TabIndex = 59
        Me.CheckBox2.Text = "ING. JOSÉ ANTONIO BARAJAS CORONADO"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 257)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(206, 17)
        Me.CheckBox1.TabIndex = 58
        Me.CheckBox1.Text = "ING. AGUSTIN G. PATIÑO ACENCIO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ArcPDF
        '
        Me.ArcPDF.Enabled = True
        Me.ArcPDF.Location = New System.Drawing.Point(634, 117)
        Me.ArcPDF.Name = "ArcPDF"
        Me.ArcPDF.OcxState = CType(resources.GetObject("ArcPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ArcPDF.Size = New System.Drawing.Size(545, 567)
        Me.ArcPDF.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(831, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Seleccione un archivo .pdf"
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(612, 710)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(186, 67)
        Me.Guardar.TabIndex = 55
        Me.Guardar.Text = "Guardar Registro"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(0, 395)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(43, 13)
        Me.label9.TabIndex = 54
        Me.label9.Text = "Acción:"
        '
        'observaciones_txt
        '
        Me.observaciones_txt.Location = New System.Drawing.Point(266, 422)
        Me.observaciones_txt.Multiline = True
        Me.observaciones_txt.Name = "observaciones_txt"
        Me.observaciones_txt.Size = New System.Drawing.Size(314, 134)
        Me.observaciones_txt.TabIndex = 52
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(353, 395)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(78, 13)
        Me.label12.TabIndex = 51
        Me.label12.Text = "Observaciones"
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(862, 51)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(66, 32)
        Me.btnPDF.TabIndex = 50
        Me.btnPDF.Text = "Abrir"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'asunto_txt
        '
        Me.asunto_txt.Location = New System.Drawing.Point(266, 612)
        Me.asunto_txt.Multiline = True
        Me.asunto_txt.Name = "asunto_txt"
        Me.asunto_txt.Size = New System.Drawing.Size(314, 118)
        Me.asunto_txt.TabIndex = 49
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(353, 583)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(55, 13)
        Me.label10.TabIndex = 48
        Me.label10.Text = "ASUNTO:"
        '
        'procedencia_txt
        '
        Me.procedencia_txt.Location = New System.Drawing.Point(359, 141)
        Me.procedencia_txt.Name = "procedencia_txt"
        Me.procedencia_txt.Size = New System.Drawing.Size(185, 20)
        Me.procedencia_txt.TabIndex = 47
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(280, 141)
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
        Me.requeridopara_txt.Size = New System.Drawing.Size(185, 20)
        Me.requeridopara_txt.TabIndex = 45
        Me.requeridopara_txt.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(266, 121)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(84, 13)
        Me.label7.TabIndex = 44
        Me.label7.Text = "Requerido Para:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Location = New System.Drawing.Point(386, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(178, 15)
        Me.label1.TabIndex = 43
        Me.label1.Text = "Agregue los datos correspondientes"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(7, 241)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 13)
        Me.label6.TabIndex = 42
        Me.label6.Text = "Dirigido a:"
        '
        'fecharecibido_date
        '
        Me.fecharecibido_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecibido_date.Location = New System.Drawing.Point(140, 143)
        Me.fecharecibido_date.Name = "fecharecibido_date"
        Me.fecharecibido_date.Size = New System.Drawing.Size(100, 20)
        Me.fecharecibido_date.TabIndex = 40
        Me.fecharecibido_date.Value = New Date(2018, 6, 20, 0, 0, 0, 0)
        '
        'otginp_txt
        '
        Me.otginp_txt.Location = New System.Drawing.Point(140, 194)
        Me.otginp_txt.Name = "otginp_txt"
        Me.otginp_txt.Size = New System.Drawing.Size(100, 20)
        Me.otginp_txt.TabIndex = 39
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
        Me.label5.Location = New System.Drawing.Point(34, 146)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(97, 13)
        Me.label5.TabIndex = 36
        Me.label5.Text = "Fecha de Recibido"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(80, 198)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 13)
        Me.label4.TabIndex = 35
        Me.label4.Text = "OT GINP"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(73, 172)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(58, 13)
        Me.label3.TabIndex = 34
        Me.label3.Text = "Folio GINP"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(77, 124)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Folio CDT"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MostrarForm2)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.observaciones2_txt)
        Me.TabPage2.Controls.Add(Me.ArcPDF2)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.button3)
        Me.TabPage2.Controls.Add(Me.label15)
        Me.TabPage2.Controls.Add(Me.label13)
        Me.TabPage2.Controls.Add(Me.foliocdt2_txt)
        Me.TabPage2.Controls.Add(Me.label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1223, 839)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(403, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 81)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Actualizar Observaciones"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'observaciones2_txt
        '
        Me.observaciones2_txt.Location = New System.Drawing.Point(33, 151)
        Me.observaciones2_txt.Multiline = True
        Me.observaciones2_txt.Name = "observaciones2_txt"
        Me.observaciones2_txt.Size = New System.Drawing.Size(350, 125)
        Me.observaciones2_txt.TabIndex = 60
        '
        'ArcPDF2
        '
        Me.ArcPDF2.Enabled = True
        Me.ArcPDF2.Location = New System.Drawing.Point(559, 39)
        Me.ArcPDF2.Name = "ArcPDF2"
        Me.ArcPDF2.OcxState = CType(resources.GetObject("ArcPDF2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ArcPDF2.Size = New System.Drawing.Size(632, 756)
        Me.ArcPDF2.TabIndex = 58
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(503, 365)
        Me.DataGridView1.TabIndex = 38
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(214, 51)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(299, 34)
        Me.button3.TabIndex = 37
        Me.button3.Text = "Consultar por folio"
        Me.button3.UseVisualStyleBackColor = True
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(414, 17)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(51, 13)
        Me.label15.TabIndex = 36
        Me.label15.Text = "Consulta "
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(164, 125)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(78, 13)
        Me.label13.TabIndex = 34
        Me.label13.Text = "Observaciones"
        '
        'foliocdt2_txt
        '
        Me.foliocdt2_txt.Location = New System.Drawing.Point(90, 59)
        Me.foliocdt2_txt.Name = "foliocdt2_txt"
        Me.foliocdt2_txt.Size = New System.Drawing.Size(100, 20)
        Me.foliocdt2_txt.TabIndex = 33
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(30, 59)
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
        'MostrarForm2
        '
        Me.MostrarForm2.Location = New System.Drawing.Point(228, 696)
        Me.MostrarForm2.Name = "MostrarForm2"
        Me.MostrarForm2.Size = New System.Drawing.Size(169, 99)
        Me.MostrarForm2.TabIndex = 62
        Me.MostrarForm2.Text = "Consultar Por Asunto"
        Me.MostrarForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 826)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Sistema de Archivos CDt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ArcPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ArcPDF2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDTDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDTDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents button3 As Button
    Private WithEvents label15 As Label
    Private WithEvents label13 As Label
    Private WithEvents foliocdt2_txt As TextBox
    Private WithEvents label14 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ArcPDF As AxAcroPDFLib.AxAcroPDF
    Private WithEvents Label11 As Label
    Private WithEvents Guardar As Button
    Private WithEvents label9 As Label
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
    Private WithEvents fecharecibido_date As DateTimePicker
    Private WithEvents otginp_txt As TextBox
    Private WithEvents folioginp_txt As TextBox
    Private WithEvents foliocdt_txt As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents CDTDataSetBindingSource1 As BindingSource
    Friend WithEvents CDTDataSetBindingSource As BindingSource
    Friend WithEvents CDTDataSet As CDTDataSet
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Private WithEvents txt_ruta As TextBox
    Friend WithEvents ArcPDF2 As AxAcroPDFLib.AxAcroPDF
    Private WithEvents observaciones2_txt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents MostrarForm2 As Button
End Class
