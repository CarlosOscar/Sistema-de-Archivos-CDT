<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.button2 = New System.Windows.Forms.Button()
        Me.observaciones3txt = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ArcPDF3 = New AxAcroPDFLib.AxAcroPDF()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.asunto3txt = New System.Windows.Forms.TextBox()
        Me.Asunto3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.foliocdt3_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.ArcPDF3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(809, 215)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(80, 45)
        Me.button2.TabIndex = 23
        Me.button2.Text = "Editar Observación"
        Me.button2.UseVisualStyleBackColor = True
        '
        'observaciones3txt
        '
        Me.observaciones3txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.observaciones3txt.Location = New System.Drawing.Point(540, 192)
        Me.observaciones3txt.Multiline = True
        Me.observaciones3txt.Name = "observaciones3txt"
        Me.observaciones3txt.Size = New System.Drawing.Size(254, 90)
        Me.observaciones3txt.TabIndex = 19
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(764, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(102, 13)
        Me.label1.TabIndex = 18
        Me.label1.Text = "Consulta por Asunto"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ArcPDF3
        '
        Me.ArcPDF3.Enabled = True
        Me.ArcPDF3.Location = New System.Drawing.Point(12, 35)
        Me.ArcPDF3.Name = "ArcPDF3"
        Me.ArcPDF3.OcxState = CType(resources.GetObject("ArcPDF3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ArcPDF3.Size = New System.Drawing.Size(495, 787)
        Me.ArcPDF3.TabIndex = 27
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(528, 291)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(663, 502)
        Me.DataGridView2.TabIndex = 28
        '
        'asunto3txt
        '
        Me.asunto3txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.asunto3txt.Location = New System.Drawing.Point(545, 69)
        Me.asunto3txt.Multiline = True
        Me.asunto3txt.Name = "asunto3txt"
        Me.asunto3txt.Size = New System.Drawing.Size(413, 24)
        Me.asunto3txt.TabIndex = 29
        '
        'Asunto3
        '
        Me.Asunto3.Location = New System.Drawing.Point(964, 69)
        Me.Asunto3.Name = "Asunto3"
        Me.Asunto3.Size = New System.Drawing.Size(139, 24)
        Me.Asunto3.TabIndex = 30
        Me.Asunto3.Text = "Buscar por asunto"
        Me.Asunto3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(542, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Introduzca un fragmento del asunto a buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(542, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Folio:"
        '
        'foliocdt3_txt
        '
        Me.foliocdt3_txt.Enabled = False
        Me.foliocdt3_txt.Location = New System.Drawing.Point(580, 158)
        Me.foliocdt3_txt.Name = "foliocdt3_txt"
        Me.foliocdt3_txt.Size = New System.Drawing.Size(100, 20)
        Me.foliocdt3_txt.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(964, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Limpiar Campos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(964, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Refrescar Tabla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 826)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.foliocdt3_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Asunto3)
        Me.Controls.Add(Me.asunto3txt)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ArcPDF3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.observaciones3txt)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ArcPDF3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button2 As Button
    Private WithEvents observaciones3txt As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ArcPDF3 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents DataGridView2 As DataGridView
    Private WithEvents asunto3txt As TextBox
    Private WithEvents Asunto3 As Button
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents foliocdt3_txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
