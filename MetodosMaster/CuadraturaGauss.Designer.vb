<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuadraturaGauss
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.txtFuncion = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtCifras = New System.Windows.Forms.TextBox()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblCifras = New System.Windows.Forms.Label()
        Me.chartSalida = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.colN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntegral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFuncion
        '
        Me.txtFuncion.Location = New System.Drawing.Point(295, 71)
        Me.txtFuncion.Name = "txtFuncion"
        Me.txtFuncion.Size = New System.Drawing.Size(100, 22)
        Me.txtFuncion.TabIndex = 0
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(295, 114)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 22)
        Me.txtA.TabIndex = 1
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(295, 157)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 22)
        Me.txtB.TabIndex = 2
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(295, 200)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(100, 22)
        Me.txtCifras.TabIndex = 3
        '
        'lblFuncion
        '
        Me.lblFuncion.AutoSize = True
        Me.lblFuncion.Location = New System.Drawing.Point(121, 74)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(99, 17)
        Me.lblFuncion.TabIndex = 4
        Me.lblFuncion.Text = "Dame funcion:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(121, 119)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(61, 17)
        Me.lblA.TabIndex = 5
        Me.lblA.Text = "Dame a:"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(121, 157)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(61, 17)
        Me.lblB.TabIndex = 6
        Me.lblB.Text = "Dame b:"
        '
        'lblCifras
        '
        Me.lblCifras.AutoSize = True
        Me.lblCifras.Location = New System.Drawing.Point(121, 200)
        Me.lblCifras.Name = "lblCifras"
        Me.lblCifras.Size = New System.Drawing.Size(87, 17)
        Me.lblCifras.TabIndex = 7
        Me.lblCifras.Text = "Dame cifras:"
        Me.lblCifras.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chartSalida
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartSalida.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartSalida.Legends.Add(Legend1)
        Me.chartSalida.Location = New System.Drawing.Point(727, 67)
        Me.chartSalida.Name = "chartSalida"
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series1.Color = System.Drawing.Color.Aqua
        Series1.Legend = "Legend1"
        Series1.Name = "Area"
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Lime
        Series2.Legend = "Legend1"
        Series2.Name = "Linea"
        Me.chartSalida.Series.Add(Series1)
        Me.chartSalida.Series.Add(Series2)
        Me.chartSalida.Size = New System.Drawing.Size(496, 550)
        Me.chartSalida.TabIndex = 8
        Me.chartSalida.Text = "Chart1"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(522, 67)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnGraficar
        '
        Me.btnGraficar.Location = New System.Drawing.Point(522, 113)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(75, 23)
        Me.btnGraficar.TabIndex = 10
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(522, 153)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(522, 196)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colN, Me.colIntegral, Me.colError})
        Me.dgvSalida.Location = New System.Drawing.Point(51, 276)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersWidth = 51
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(546, 341)
        Me.dgvSalida.TabIndex = 13
        '
        'colN
        '
        Me.colN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colN.HeaderText = "n"
        Me.colN.MinimumWidth = 6
        Me.colN.Name = "colN"
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
        Me.colError.HeaderText = "Error"
        Me.colError.MinimumWidth = 6
        Me.colError.Name = "colError"
        '
        'CuadraturaGauss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 653)
        Me.Controls.Add(Me.dgvSalida)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.chartSalida)
        Me.Controls.Add(Me.lblCifras)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.txtCifras)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtFuncion)
        Me.Name = "CuadraturaGauss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadratura de Gauss"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFuncion As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtCifras As TextBox
    Friend WithEvents lblFuncion As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblCifras As Label
    Friend WithEvents chartSalida As DataVisualization.Charting.Chart
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnGraficar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents colN As DataGridViewTextBoxColumn
    Friend WithEvents colIntegral As DataGridViewTextBoxColumn
    Friend WithEvents colError As DataGridViewTextBoxColumn
End Class
