<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Integracion_trapecios
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.coln = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntegral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblCifras = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtFuncion = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtCifras = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grafica
        '
        ChartArea1.Name = "ChartArea1"
        Me.Grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Grafica.Legends.Add(Legend1)
        Me.Grafica.Location = New System.Drawing.Point(731, 53)
        Me.Grafica.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Grafica.Name = "Grafica"
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series2.Color = System.Drawing.Color.Navy
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Grafica.Series.Add(Series1)
        Me.Grafica.Series.Add(Series2)
        Me.Grafica.Size = New System.Drawing.Size(630, 406)
        Me.Grafica.TabIndex = 47
        Me.Grafica.Text = "Chart1"
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coln, Me.colIntegral, Me.colError})
        Me.dgvSalida.Location = New System.Drawing.Point(41, 405)
        Me.dgvSalida.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersWidth = 51
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(647, 232)
        Me.dgvSalida.TabIndex = 46
        '
        'coln
        '
        Me.coln.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coln.HeaderText = "n"
        Me.coln.MinimumWidth = 6
        Me.coln.Name = "coln"
        '
        'colIntegral
        '
        Me.colIntegral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIntegral.HeaderText = "Integral"
        Me.colIntegral.MinimumWidth = 6
        Me.colIntegral.Name = "colIntegral"
        '
        'colError
        '
        Me.colError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colError.HeaderText = "err(i)"
        Me.colError.MinimumWidth = 6
        Me.colError.Name = "colError"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblN.Location = New System.Drawing.Point(20, 347)
        Me.lblN.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(86, 25)
        Me.lblN.TabIndex = 45
        Me.lblN.Text = "Dame n"
        Me.lblN.Visible = False
        '
        'lblCifras
        '
        Me.lblCifras.AutoSize = True
        Me.lblCifras.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCifras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblCifras.Location = New System.Drawing.Point(20, 228)
        Me.lblCifras.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCifras.Name = "lblCifras"
        Me.lblCifras.Size = New System.Drawing.Size(256, 25)
        Me.lblCifras.TabIndex = 44
        Me.lblCifras.Text = "Dame cifras significativas"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblB.Location = New System.Drawing.Point(20, 308)
        Me.lblB.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(187, 25)
        Me.lblB.TabIndex = 43
        Me.lblB.Text = "Limite superior (b)"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblA.Location = New System.Drawing.Point(20, 267)
        Me.lblA.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(175, 25)
        Me.lblA.TabIndex = 42
        Me.lblA.Text = "Limite inferior (a)"
        '
        'lblFuncion
        '
        Me.lblFuncion.AutoSize = True
        Me.lblFuncion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFuncion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblFuncion.Location = New System.Drawing.Point(20, 188)
        Me.lblFuncion.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(167, 25)
        Me.lblFuncion.TabIndex = 41
        Me.lblFuncion.Text = "Dame la funcion"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(344, 263)
        Me.txtA.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(160, 30)
        Me.txtA.TabIndex = 38
        '
        'txtFuncion
        '
        Me.txtFuncion.Location = New System.Drawing.Point(344, 183)
        Me.txtFuncion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtFuncion.Name = "txtFuncion"
        Me.txtFuncion.Size = New System.Drawing.Size(160, 30)
        Me.txtFuncion.TabIndex = 36
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(344, 343)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(160, 30)
        Me.txtNum.TabIndex = 40
        Me.txtNum.Visible = False
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(344, 223)
        Me.txtCifras.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(160, 30)
        Me.txtCifras.TabIndex = 37
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(344, 303)
        Me.txtB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(160, 30)
        Me.txtB.TabIndex = 39
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.Location = New System.Drawing.Point(578, 244)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 36)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLimpiar.Location = New System.Drawing.Point(578, 198)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(122, 36)
        Me.btnLimpiar.TabIndex = 34
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGraficar
        '
        Me.btnGraficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnGraficar.Location = New System.Drawing.Point(578, 141)
        Me.btnGraficar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(122, 36)
        Me.btnGraficar.TabIndex = 33
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCalcular.Location = New System.Drawing.Point(578, 95)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(122, 36)
        Me.btnCalcular.TabIndex = 32
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(956, 504)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Integral:"
        '
        'txtSalida
        '
        Me.txtSalida.Location = New System.Drawing.Point(1083, 504)
        Me.txtSalida.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(160, 30)
        Me.txtSalida.TabIndex = 49
        '
        'Integracion_trapecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1375, 675)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grafica)
        Me.Controls.Add(Me.dgvSalida)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblCifras)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtFuncion)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtCifras)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Integracion_trapecios"
        Me.Text = "Integracion_trapecios"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grafica As DataVisualization.Charting.Chart
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents coln As DataGridViewTextBoxColumn
    Friend WithEvents colIntegral As DataGridViewTextBoxColumn
    Friend WithEvents colError As DataGridViewTextBoxColumn
    Friend WithEvents lblN As Label
    Friend WithEvents lblCifras As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblFuncion As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtFuncion As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtCifras As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGraficar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSalida As TextBox
End Class
