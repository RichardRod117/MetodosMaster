<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INewton
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.lblS = New System.Windows.Forms.Label()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.lblM = New System.Windows.Forms.Label()
        Me.Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvSal2 = New System.Windows.Forms.DataGridView()
        Me.ColCoeS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDelKs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSal1 = New System.Windows.Forms.DataGridView()
        Me.colI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColXi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtInter = New System.Windows.Forms.TextBox()
        Me.txtIb = New System.Windows.Forms.TextBox()
        Me.txtCifras = New System.Windows.Forms.TextBox()
        Me.txtValorInter = New System.Windows.Forms.TextBox()
        Me.txtPar = New System.Windows.Forms.TextBox()
        Me.lblInter = New System.Windows.Forms.Label()
        Me.lblIb = New System.Windows.Forms.Label()
        Me.lblCifras = New System.Windows.Forms.Label()
        Me.lblValorInter = New System.Windows.Forms.Label()
        Me.lblPar = New System.Windows.Forms.Label()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(446, 399)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(100, 22)
        Me.txtS.TabIndex = 41
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblS.Location = New System.Drawing.Point(283, 399)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(48, 25)
        Me.lblS.TabIndex = 40
        Me.lblS.Text = "s = "
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(446, 348)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(100, 22)
        Me.txtM.TabIndex = 39
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblM.Location = New System.Drawing.Point(283, 348)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(54, 25)
        Me.lblM.TabIndex = 38
        Me.lblM.Text = "m = "
        '
        'Grafica
        '
        ChartArea2.Name = "ChartArea1"
        Me.Grafica.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Grafica.Legends.Add(Legend2)
        Me.Grafica.Location = New System.Drawing.Point(722, 52)
        Me.Grafica.Name = "Grafica"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.Name = "Series2"
        Me.Grafica.Series.Add(Series3)
        Me.Grafica.Series.Add(Series4)
        Me.Grafica.Size = New System.Drawing.Size(603, 480)
        Me.Grafica.TabIndex = 37
        Me.Grafica.Text = "Chart1"
        '
        'dgvSal2
        '
        Me.dgvSal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSal2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCoeS, Me.ColDelKs})
        Me.dgvSal2.Location = New System.Drawing.Point(746, 554)
        Me.dgvSal2.Name = "dgvSal2"
        Me.dgvSal2.RowHeadersWidth = 51
        Me.dgvSal2.RowTemplate.Height = 24
        Me.dgvSal2.Size = New System.Drawing.Size(554, 180)
        Me.dgvSal2.TabIndex = 36
        '
        'ColCoeS
        '
        Me.ColCoeS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCoeS.HeaderText = "Coeficientes s"
        Me.ColCoeS.MinimumWidth = 6
        Me.ColCoeS.Name = "ColCoeS"
        '
        'ColDelKs
        '
        Me.ColDelKs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColDelKs.HeaderText = "Δs k"
        Me.ColDelKs.MinimumWidth = 6
        Me.ColDelKs.Name = "ColDelKs"
        '
        'dgvSal1
        '
        Me.dgvSal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSal1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colI, Me.ColXi, Me.colYi, Me.colDel1, Me.colDel2, Me.colDel3, Me.colDel4})
        Me.dgvSal1.Location = New System.Drawing.Point(130, 500)
        Me.dgvSal1.Name = "dgvSal1"
        Me.dgvSal1.RowHeadersWidth = 51
        Me.dgvSal1.RowTemplate.Height = 24
        Me.dgvSal1.Size = New System.Drawing.Size(554, 234)
        Me.dgvSal1.TabIndex = 35
        '
        'colI
        '
        Me.colI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colI.HeaderText = "i"
        Me.colI.MinimumWidth = 6
        Me.colI.Name = "colI"
        '
        'ColXi
        '
        Me.ColXi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColXi.HeaderText = "x(i)"
        Me.ColXi.MinimumWidth = 6
        Me.ColXi.Name = "ColXi"
        '
        'colYi
        '
        Me.colYi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colYi.HeaderText = "y(i)"
        Me.colYi.MinimumWidth = 6
        Me.colYi.Name = "colYi"
        '
        'colDel1
        '
        Me.colDel1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDel1.HeaderText = "Δ1"
        Me.colDel1.MinimumWidth = 6
        Me.colDel1.Name = "colDel1"
        '
        'colDel2
        '
        Me.colDel2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDel2.HeaderText = "Δ2"
        Me.colDel2.MinimumWidth = 6
        Me.colDel2.Name = "colDel2"
        '
        'colDel3
        '
        Me.colDel3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDel3.HeaderText = "Δ3"
        Me.colDel3.MinimumWidth = 6
        Me.colDel3.Name = "colDel3"
        '
        'colDel4
        '
        Me.colDel4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDel4.HeaderText = "Δ4"
        Me.colDel4.MinimumWidth = 6
        Me.colDel4.Name = "colDel4"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.Location = New System.Drawing.Point(573, 331)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 39)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLimpiar.Location = New System.Drawing.Point(573, 271)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(130, 39)
        Me.btnLimpiar.TabIndex = 33
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGraficar
        '
        Me.btnGraficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnGraficar.Location = New System.Drawing.Point(573, 211)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(130, 39)
        Me.btnGraficar.TabIndex = 32
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCalcular.Location = New System.Drawing.Point(573, 151)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(130, 39)
        Me.btnCalcular.TabIndex = 31
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'txtInter
        '
        Me.txtInter.Location = New System.Drawing.Point(446, 446)
        Me.txtInter.Name = "txtInter"
        Me.txtInter.Size = New System.Drawing.Size(100, 22)
        Me.txtInter.TabIndex = 30
        '
        'txtIb
        '
        Me.txtIb.Location = New System.Drawing.Point(446, 296)
        Me.txtIb.Name = "txtIb"
        Me.txtIb.Size = New System.Drawing.Size(100, 22)
        Me.txtIb.TabIndex = 29
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(446, 245)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(100, 22)
        Me.txtCifras.TabIndex = 28
        '
        'txtValorInter
        '
        Me.txtValorInter.Location = New System.Drawing.Point(446, 194)
        Me.txtValorInter.Name = "txtValorInter"
        Me.txtValorInter.Size = New System.Drawing.Size(100, 22)
        Me.txtValorInter.TabIndex = 27
        '
        'txtPar
        '
        Me.txtPar.Location = New System.Drawing.Point(446, 143)
        Me.txtPar.Name = "txtPar"
        Me.txtPar.Size = New System.Drawing.Size(100, 22)
        Me.txtPar.TabIndex = 26
        '
        'lblInter
        '
        Me.lblInter.AutoSize = True
        Me.lblInter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblInter.Location = New System.Drawing.Point(229, 446)
        Me.lblInter.Name = "lblInter"
        Me.lblInter.Size = New System.Drawing.Size(136, 25)
        Me.lblInter.TabIndex = 25
        Me.lblInter.Text = "Interpolacion"
        '
        'lblIb
        '
        Me.lblIb.AutoSize = True
        Me.lblIb.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblIb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblIb.Location = New System.Drawing.Point(283, 296)
        Me.lblIb.Name = "lblIb"
        Me.lblIb.Size = New System.Drawing.Size(55, 25)
        Me.lblIb.TabIndex = 24
        Me.lblIb.Text = "Ib = "
        '
        'lblCifras
        '
        Me.lblCifras.AutoSize = True
        Me.lblCifras.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCifras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblCifras.Location = New System.Drawing.Point(151, 245)
        Me.lblCifras.Name = "lblCifras"
        Me.lblCifras.Size = New System.Drawing.Size(256, 25)
        Me.lblCifras.TabIndex = 23
        Me.lblCifras.Text = "Dame cifras significativas"
        '
        'lblValorInter
        '
        Me.lblValorInter.AutoSize = True
        Me.lblValorInter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblValorInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblValorInter.Location = New System.Drawing.Point(162, 194)
        Me.lblValorInter.Name = "lblValorInter"
        Me.lblValorInter.Size = New System.Drawing.Size(235, 25)
        Me.lblValorInter.TabIndex = 22
        Me.lblValorInter.Text = "Dame valor a interpolar"
        '
        'lblPar
        '
        Me.lblPar.AutoSize = True
        Me.lblPar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPar.Location = New System.Drawing.Point(150, 143)
        Me.lblPar.Name = "lblPar"
        Me.lblPar.Size = New System.Drawing.Size(253, 25)
        Me.lblPar.TabIndex = 21
        Me.lblPar.Text = "Dame numero de parejas"
        '
        'INewton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1386, 755)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.Grafica)
        Me.Controls.Add(Me.dgvSal2)
        Me.Controls.Add(Me.dgvSal1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtInter)
        Me.Controls.Add(Me.txtIb)
        Me.Controls.Add(Me.txtCifras)
        Me.Controls.Add(Me.txtValorInter)
        Me.Controls.Add(Me.txtPar)
        Me.Controls.Add(Me.lblInter)
        Me.Controls.Add(Me.lblIb)
        Me.Controls.Add(Me.lblCifras)
        Me.Controls.Add(Me.lblValorInter)
        Me.Controls.Add(Me.lblPar)
        Me.Name = "INewton"
        Me.Text = "INewton"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtS As TextBox
    Friend WithEvents lblS As Label
    Friend WithEvents txtM As TextBox
    Friend WithEvents lblM As Label
    Friend WithEvents Grafica As DataVisualization.Charting.Chart
    Friend WithEvents dgvSal2 As DataGridView
    Friend WithEvents ColCoeS As DataGridViewTextBoxColumn
    Friend WithEvents ColDelKs As DataGridViewTextBoxColumn
    Friend WithEvents dgvSal1 As DataGridView
    Friend WithEvents colI As DataGridViewTextBoxColumn
    Friend WithEvents ColXi As DataGridViewTextBoxColumn
    Friend WithEvents colYi As DataGridViewTextBoxColumn
    Friend WithEvents colDel1 As DataGridViewTextBoxColumn
    Friend WithEvents colDel2 As DataGridViewTextBoxColumn
    Friend WithEvents colDel3 As DataGridViewTextBoxColumn
    Friend WithEvents colDel4 As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGraficar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtInter As TextBox
    Friend WithEvents txtIb As TextBox
    Friend WithEvents txtCifras As TextBox
    Friend WithEvents txtValorInter As TextBox
    Friend WithEvents txtPar As TextBox
    Friend WithEvents lblInter As Label
    Friend WithEvents lblIb As Label
    Friend WithEvents lblCifras As Label
    Friend WithEvents lblValorInter As Label
    Friend WithEvents lblPar As Label
End Class
