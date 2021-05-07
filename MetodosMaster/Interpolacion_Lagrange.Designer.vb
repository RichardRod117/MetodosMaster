<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interpolacion_Lagrange
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
        Me.txtInterpolacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtParejas = New System.Windows.Forms.TextBox()
        Me.txtCifras = New System.Windows.Forms.TextBox()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.btnParejas = New System.Windows.Forms.Button()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.colIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblParejas = New System.Windows.Forms.Label()
        Me.lblCifras = New System.Windows.Forms.Label()
        Me.Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInterpolacion
        '
        Me.txtInterpolacion.Location = New System.Drawing.Point(717, 571)
        Me.txtInterpolacion.Name = "txtInterpolacion"
        Me.txtInterpolacion.Size = New System.Drawing.Size(100, 22)
        Me.txtInterpolacion.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(551, 568)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Interpolacion"
        '
        'txtIb
        '
        Me.txtIb.Location = New System.Drawing.Point(922, 195)
        Me.txtIb.Name = "txtIb"
        Me.txtIb.Size = New System.Drawing.Size(100, 22)
        Me.txtIb.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(780, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ib = "
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(922, 146)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 22)
        Me.txtNum.TabIndex = 29
        '
        'txtParejas
        '
        Me.txtParejas.Location = New System.Drawing.Point(922, 100)
        Me.txtParejas.Name = "txtParejas"
        Me.txtParejas.Size = New System.Drawing.Size(100, 22)
        Me.txtParejas.TabIndex = 28
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(922, 54)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(100, 22)
        Me.txtCifras.TabIndex = 27
        '
        'cmbGrado
        '
        Me.cmbGrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Items.AddRange(New Object() {"Primer grado", "Segundo grado"})
        Me.cmbGrado.Location = New System.Drawing.Point(1111, 139)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(121, 33)
        Me.cmbGrado.TabIndex = 26
        Me.cmbGrado.Text = "Grado"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.Location = New System.Drawing.Point(1093, 438)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 37)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLimpiar.Location = New System.Drawing.Point(1093, 386)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(118, 46)
        Me.btnLimpiar.TabIndex = 24
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGraficar
        '
        Me.btnGraficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnGraficar.Location = New System.Drawing.Point(1093, 334)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(118, 46)
        Me.btnGraficar.TabIndex = 23
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = False
        '
        'btnParejas
        '
        Me.btnParejas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnParejas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnParejas.Location = New System.Drawing.Point(1089, 51)
        Me.btnParejas.Name = "btnParejas"
        Me.btnParejas.Size = New System.Drawing.Size(167, 33)
        Me.btnParejas.TabIndex = 22
        Me.btnParejas.Text = "Introducir parejas"
        Me.btnParejas.UseVisualStyleBackColor = False
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIndice, Me.colX, Me.colY})
        Me.dgvSalida.Location = New System.Drawing.Point(554, 268)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersWidth = 51
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(486, 258)
        Me.dgvSalida.TabIndex = 21
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
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblNum.Location = New System.Drawing.Point(551, 146)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(283, 25)
        Me.lblNum.TabIndex = 20
        Me.lblNum.Text = "Dame el numero a interpolar"
        '
        'lblParejas
        '
        Me.lblParejas.AutoSize = True
        Me.lblParejas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblParejas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblParejas.Location = New System.Drawing.Point(558, 100)
        Me.lblParejas.Name = "lblParejas"
        Me.lblParejas.Size = New System.Drawing.Size(276, 25)
        Me.lblParejas.TabIndex = 19
        Me.lblParejas.Text = "Dame el numero de parjeas"
        '
        'lblCifras
        '
        Me.lblCifras.AutoSize = True
        Me.lblCifras.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCifras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblCifras.Location = New System.Drawing.Point(578, 50)
        Me.lblCifras.Name = "lblCifras"
        Me.lblCifras.Size = New System.Drawing.Size(256, 25)
        Me.lblCifras.TabIndex = 18
        Me.lblCifras.Text = "Dame cifras significativas"
        '
        'Grafica
        '
        ChartArea1.Name = "ChartArea1"
        Me.Grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Grafica.Legends.Add(Legend1)
        Me.Grafica.Location = New System.Drawing.Point(12, 226)
        Me.Grafica.Name = "Grafica"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Color = System.Drawing.Color.Blue
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Grafica.Series.Add(Series1)
        Me.Grafica.Series.Add(Series2)
        Me.Grafica.Size = New System.Drawing.Size(489, 300)
        Me.Grafica.TabIndex = 34
        Me.Grafica.Text = "Chart1"
        '
        'Interpolacion_Lagrange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1320, 630)
        Me.Controls.Add(Me.Grafica)
        Me.Controls.Add(Me.txtInterpolacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtParejas)
        Me.Controls.Add(Me.txtCifras)
        Me.Controls.Add(Me.cmbGrado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.btnParejas)
        Me.Controls.Add(Me.dgvSalida)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblParejas)
        Me.Controls.Add(Me.lblCifras)
        Me.Name = "Interpolacion_Lagrange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interpolacion_Lagrange"
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInterpolacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtParejas As TextBox
    Friend WithEvents txtCifras As TextBox
    Friend WithEvents cmbGrado As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGraficar As Button
    Friend WithEvents btnParejas As Button
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents colIndice As DataGridViewTextBoxColumn
    Friend WithEvents colX As DataGridViewTextBoxColumn
    Friend WithEvents colY As DataGridViewTextBoxColumn
    Friend WithEvents lblNum As Label
    Friend WithEvents lblParejas As Label
    Friend WithEvents lblCifras As Label
    Friend WithEvents Grafica As DataVisualization.Charting.Chart
End Class
