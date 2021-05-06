<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class minimosCuadrados
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
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.colIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tvx = New System.Windows.Forms.TextBox()
        Me.tn = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblParejas = New System.Windows.Forms.Label()
        Me.lblCifras = New System.Windows.Forms.Label()
        Me.btnParejas = New System.Windows.Forms.Button()
        Me.graficar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gráfica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gráfica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIndice, Me.colX, Me.colY})
        Me.dgvSalida.Location = New System.Drawing.Point(18, 274)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersWidth = 51
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(486, 258)
        Me.dgvSalida.TabIndex = 22
        '
        'colIndice
        '
        Me.colIndice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIndice.HeaderText = "i"
        Me.colIndice.MinimumWidth = 6
        Me.colIndice.Name = "colIndice"
        '
        'colX
        '
        Me.colX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colX.HeaderText = "x(i)"
        Me.colX.MinimumWidth = 6
        Me.colX.Name = "colX"
        '
        'colY
        '
        Me.colY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colY.HeaderText = "y(i)"
        Me.colY.MinimumWidth = 6
        Me.colY.Name = "colY"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(807, 131)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 22)
        Me.tc.TabIndex = 35
        '
        'tvx
        '
        Me.tvx.Location = New System.Drawing.Point(807, 85)
        Me.tvx.Name = "tvx"
        Me.tvx.Size = New System.Drawing.Size(100, 22)
        Me.tvx.TabIndex = 34
        '
        'tn
        '
        Me.tn.Location = New System.Drawing.Point(807, 39)
        Me.tn.Name = "tn"
        Me.tn.Size = New System.Drawing.Size(100, 22)
        Me.tn.TabIndex = 33
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblNum.Location = New System.Drawing.Point(562, 131)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(194, 25)
        Me.lblNum.TabIndex = 32
        Me.lblNum.Text = "cifras significativas"
        '
        'lblParejas
        '
        Me.lblParejas.AutoSize = True
        Me.lblParejas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblParejas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblParejas.Location = New System.Drawing.Point(573, 85)
        Me.lblParejas.Name = "lblParejas"
        Me.lblParejas.Size = New System.Drawing.Size(180, 25)
        Me.lblParejas.TabIndex = 31
        Me.lblParejas.Text = "numero interpolar"
        '
        'lblCifras
        '
        Me.lblCifras.AutoSize = True
        Me.lblCifras.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCifras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblCifras.Location = New System.Drawing.Point(595, 39)
        Me.lblCifras.Name = "lblCifras"
        Me.lblCifras.Size = New System.Drawing.Size(161, 25)
        Me.lblCifras.TabIndex = 30
        Me.lblCifras.Text = "numero parejas"
        '
        'btnParejas
        '
        Me.btnParejas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnParejas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnParejas.Location = New System.Drawing.Point(968, 33)
        Me.btnParejas.Name = "btnParejas"
        Me.btnParejas.Size = New System.Drawing.Size(158, 31)
        Me.btnParejas.TabIndex = 36
        Me.btnParejas.Text = "Introducir parejas"
        Me.btnParejas.UseVisualStyleBackColor = False
        '
        'graficar
        '
        Me.graficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.graficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.graficar.Location = New System.Drawing.Point(968, 125)
        Me.graficar.Name = "graficar"
        Me.graficar.Size = New System.Drawing.Size(158, 41)
        Me.graficar.TabIndex = 37
        Me.graficar.Text = "graficar"
        Me.graficar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(807, 178)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(621, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "interpolacion"
        '
        'Gráfica
        '
        ChartArea1.Name = "ChartArea1"
        Me.Gráfica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Gráfica.Legends.Add(Legend1)
        Me.Gráfica.Location = New System.Drawing.Point(578, 258)
        Me.Gráfica.Name = "Gráfica"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.ShadowColor = System.Drawing.Color.Aqua
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.YellowGreen
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Me.Gráfica.Series.Add(Series1)
        Me.Gráfica.Series.Add(Series2)
        Me.Gráfica.Series.Add(Series3)
        Me.Gráfica.Size = New System.Drawing.Size(533, 300)
        Me.Gráfica.TabIndex = 40
        Me.Gráfica.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(968, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 31)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCalcular.Location = New System.Drawing.Point(968, 79)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(158, 31)
        Me.btnCalcular.TabIndex = 42
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'minimosCuadrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1175, 617)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Gráfica)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.graficar)
        Me.Controls.Add(Me.btnParejas)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tvx)
        Me.Controls.Add(Me.tn)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblParejas)
        Me.Controls.Add(Me.lblCifras)
        Me.Controls.Add(Me.dgvSalida)
        Me.Name = "minimosCuadrados"
        Me.Text = "minimosCuadrados"
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gráfica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents colIndice As DataGridViewTextBoxColumn
    Friend WithEvents colX As DataGridViewTextBoxColumn
    Friend WithEvents colY As DataGridViewTextBoxColumn
    Friend WithEvents tc As TextBox
    Friend WithEvents tvx As TextBox
    Friend WithEvents tn As TextBox
    Friend WithEvents lblNum As Label
    Friend WithEvents lblParejas As Label
    Friend WithEvents lblCifras As Label
    Friend WithEvents btnParejas As Button
    Friend WithEvents graficar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Gráfica As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCalcular As Button
End Class
