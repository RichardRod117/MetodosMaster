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
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInterpolacion
        '
        Me.txtInterpolacion.Location = New System.Drawing.Point(597, 565)
        Me.txtInterpolacion.Name = "txtInterpolacion"
        Me.txtInterpolacion.Size = New System.Drawing.Size(100, 22)
        Me.txtInterpolacion.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 568)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Interpolacion"
        '
        'txtIb
        '
        Me.txtIb.Location = New System.Drawing.Point(704, 192)
        Me.txtIb.Name = "txtIb"
        Me.txtIb.Size = New System.Drawing.Size(100, 22)
        Me.txtIb.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(482, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ib = "
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(704, 143)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 22)
        Me.txtNum.TabIndex = 29
        '
        'txtParejas
        '
        Me.txtParejas.Location = New System.Drawing.Point(704, 97)
        Me.txtParejas.Name = "txtParejas"
        Me.txtParejas.Size = New System.Drawing.Size(100, 22)
        Me.txtParejas.TabIndex = 28
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(704, 51)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(100, 22)
        Me.txtCifras.TabIndex = 27
        '
        'cmbGrado
        '
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Items.AddRange(New Object() {"Primer grado", "Segundo grado"})
        Me.cmbGrado.Location = New System.Drawing.Point(1001, 141)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(121, 24)
        Me.cmbGrado.TabIndex = 26
        Me.cmbGrado.Text = "Grado"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1024, 438)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(1024, 386)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 24
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGraficar
        '
        Me.btnGraficar.Location = New System.Drawing.Point(1024, 334)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(75, 23)
        Me.btnGraficar.TabIndex = 23
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'btnParejas
        '
        Me.btnParejas.Location = New System.Drawing.Point(990, 50)
        Me.btnParejas.Name = "btnParejas"
        Me.btnParejas.Size = New System.Drawing.Size(143, 23)
        Me.btnParejas.TabIndex = 22
        Me.btnParejas.Text = "Introducir parejas"
        Me.btnParejas.UseVisualStyleBackColor = True
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIndice, Me.colX, Me.colY})
        Me.dgvSalida.Location = New System.Drawing.Point(485, 268)
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
        Me.lblNum.Location = New System.Drawing.Point(482, 146)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(188, 17)
        Me.lblNum.TabIndex = 20
        Me.lblNum.Text = "Dame el numero a interpolar"
        '
        'lblParejas
        '
        Me.lblParejas.AutoSize = True
        Me.lblParejas.Location = New System.Drawing.Point(482, 100)
        Me.lblParejas.Name = "lblParejas"
        Me.lblParejas.Size = New System.Drawing.Size(183, 17)
        Me.lblParejas.TabIndex = 19
        Me.lblParejas.Text = "Dame el numero de parjeas"
        '
        'lblCifras
        '
        Me.lblCifras.AutoSize = True
        Me.lblCifras.Location = New System.Drawing.Point(482, 54)
        Me.lblCifras.Name = "lblCifras"
        Me.lblCifras.Size = New System.Drawing.Size(167, 17)
        Me.lblCifras.TabIndex = 18
        Me.lblCifras.Text = "Dame cifras significativas"
        '
        'Interpolacion_Lagrange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1201, 630)
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
        Me.Text = "Interpolacion_Lagrange"
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
