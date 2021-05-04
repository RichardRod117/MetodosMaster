<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JACOBI
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
        Me.txt12 = New System.Windows.Forms.TextBox()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCoeficientes = New System.Windows.Forms.Button()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt9 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCifras = New System.Windows.Forms.TextBox()
        Me.txtSalidaY = New System.Windows.Forms.TextBox()
        Me.txtSalidaZ = New System.Windows.Forms.TextBox()
        Me.txtSalidaX = New System.Windows.Forms.TextBox()
        Me.lblSalidaZ = New System.Windows.Forms.Label()
        Me.lblSalidaY = New System.Windows.Forms.Label()
        Me.lblSalidaX = New System.Windows.Forms.Label()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt12
        '
        Me.txt12.Location = New System.Drawing.Point(644, 359)
        Me.txt12.Name = "txt12"
        Me.txt12.Size = New System.Drawing.Size(100, 22)
        Me.txt12.TabIndex = 56
        Me.txt12.Visible = False
        '
        'txt11
        '
        Me.txt11.Location = New System.Drawing.Point(644, 276)
        Me.txt11.Name = "txt11"
        Me.txt11.Size = New System.Drawing.Size(100, 22)
        Me.txt11.TabIndex = 55
        Me.txt11.Visible = False
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(644, 190)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(100, 22)
        Me.txt10.TabIndex = 54
        Me.txt10.Visible = False
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl9.Location = New System.Drawing.Point(583, 359)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(42, 25)
        Me.lbl9.TabIndex = 53
        Me.lbl9.Text = "z ="
        Me.lbl9.Visible = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl6.Location = New System.Drawing.Point(583, 271)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(42, 25)
        Me.lbl6.TabIndex = 52
        Me.lbl6.Text = "z ="
        Me.lbl6.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl3.Location = New System.Drawing.Point(583, 185)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(42, 25)
        Me.lbl3.TabIndex = 51
        Me.lbl3.Text = "z ="
        Me.lbl3.Visible = False
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl8.Location = New System.Drawing.Point(405, 359)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(42, 25)
        Me.lbl8.TabIndex = 50
        Me.lbl8.Text = "y +"
        Me.lbl8.Visible = False
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl5.Location = New System.Drawing.Point(405, 273)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(42, 25)
        Me.lbl5.TabIndex = 49
        Me.lbl5.Text = "y +"
        Me.lbl5.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl2.Location = New System.Drawing.Point(404, 187)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(42, 25)
        Me.lbl2.TabIndex = 48
        Me.lbl2.Text = "y +"
        Me.lbl2.Visible = False
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl7.Location = New System.Drawing.Point(216, 361)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(42, 25)
        Me.lbl7.TabIndex = 47
        Me.lbl7.Text = "x +"
        Me.lbl7.Visible = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl4.Location = New System.Drawing.Point(216, 273)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(42, 25)
        Me.lbl4.TabIndex = 46
        Me.lbl4.Text = "x +"
        Me.lbl4.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl1.Location = New System.Drawing.Point(216, 187)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(42, 25)
        Me.lbl1.TabIndex = 45
        Me.lbl1.Text = "x +"
        Me.lbl1.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.Location = New System.Drawing.Point(774, 356)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(282, 35)
        Me.btnSalir.TabIndex = 44
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCalcular.Location = New System.Drawing.Point(774, 242)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(282, 35)
        Me.btnCalcular.TabIndex = 43
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLimpiar.Location = New System.Drawing.Point(774, 293)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(282, 35)
        Me.btnLimpiar.TabIndex = 42
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCoeficientes
        '
        Me.btnCoeficientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCoeficientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCoeficientes.Location = New System.Drawing.Point(776, 189)
        Me.btnCoeficientes.Name = "btnCoeficientes"
        Me.btnCoeficientes.Size = New System.Drawing.Size(282, 35)
        Me.btnCoeficientes.TabIndex = 41
        Me.btnCoeficientes.Text = "&Coeficientes y terminos independientes"
        Me.btnCoeficientes.UseVisualStyleBackColor = False
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.colX, Me.colY, Me.colZ, Me.colEx, Me.colEy, Me.colEz})
        Me.dgvSalida.Location = New System.Drawing.Point(152, 416)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersWidth = 51
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(863, 147)
        Me.dgvSalida.TabIndex = 40
        '
        'col
        '
        Me.col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col.HeaderText = "Indíce"
        Me.col.MinimumWidth = 6
        Me.col.Name = "col"
        '
        'colX
        '
        Me.colX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colX.HeaderText = "X"
        Me.colX.MinimumWidth = 6
        Me.colX.Name = "colX"
        '
        'colY
        '
        Me.colY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colY.HeaderText = "Y"
        Me.colY.MinimumWidth = 6
        Me.colY.Name = "colY"
        '
        'colZ
        '
        Me.colZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colZ.HeaderText = "Z"
        Me.colZ.MinimumWidth = 6
        Me.colZ.Name = "colZ"
        '
        'colEx
        '
        Me.colEx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEx.HeaderText = "EX"
        Me.colEx.MinimumWidth = 6
        Me.colEx.Name = "colEx"
        '
        'colEy
        '
        Me.colEy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEy.HeaderText = "EY"
        Me.colEy.MinimumWidth = 6
        Me.colEy.Name = "colEy"
        '
        'colEz
        '
        Me.colEz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEz.HeaderText = "EZ"
        Me.colEz.MinimumWidth = 6
        Me.colEz.Name = "colEz"
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(467, 273)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(100, 22)
        Me.txt6.TabIndex = 39
        Me.txt6.Visible = False
        '
        'txt9
        '
        Me.txt9.Location = New System.Drawing.Point(467, 361)
        Me.txt9.Name = "txt9"
        Me.txt9.Size = New System.Drawing.Size(100, 22)
        Me.txt9.TabIndex = 38
        Me.txt9.Visible = False
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(467, 190)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 22)
        Me.txt3.TabIndex = 37
        Me.txt3.Visible = False
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(94, 272)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(100, 22)
        Me.txt4.TabIndex = 36
        Me.txt4.Visible = False
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(281, 276)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(100, 22)
        Me.txt5.TabIndex = 35
        Me.txt5.Visible = False
        '
        'txt8
        '
        Me.txt8.Location = New System.Drawing.Point(281, 359)
        Me.txt8.Name = "txt8"
        Me.txt8.Size = New System.Drawing.Size(100, 22)
        Me.txt8.TabIndex = 34
        Me.txt8.Visible = False
        '
        'txt7
        '
        Me.txt7.Location = New System.Drawing.Point(94, 358)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(100, 22)
        Me.txt7.TabIndex = 33
        Me.txt7.Visible = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(94, 186)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 32
        Me.txt1.Visible = False
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(281, 190)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 22)
        Me.txt2.TabIndex = 31
        Me.txt2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(619, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Dame cifras significaticas"
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(933, 32)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(100, 22)
        Me.txtCifras.TabIndex = 29
        '
        'txtSalidaY
        '
        Me.txtSalidaY.Location = New System.Drawing.Point(935, 113)
        Me.txtSalidaY.Name = "txtSalidaY"
        Me.txtSalidaY.Size = New System.Drawing.Size(100, 22)
        Me.txtSalidaY.TabIndex = 62
        Me.txtSalidaY.Visible = False
        '
        'txtSalidaZ
        '
        Me.txtSalidaZ.Location = New System.Drawing.Point(935, 151)
        Me.txtSalidaZ.Name = "txtSalidaZ"
        Me.txtSalidaZ.Size = New System.Drawing.Size(100, 22)
        Me.txtSalidaZ.TabIndex = 61
        Me.txtSalidaZ.Visible = False
        '
        'txtSalidaX
        '
        Me.txtSalidaX.Location = New System.Drawing.Point(935, 68)
        Me.txtSalidaX.Name = "txtSalidaX"
        Me.txtSalidaX.Size = New System.Drawing.Size(100, 22)
        Me.txtSalidaX.TabIndex = 60
        Me.txtSalidaX.Visible = False
        '
        'lblSalidaZ
        '
        Me.lblSalidaZ.AutoSize = True
        Me.lblSalidaZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSalidaZ.Location = New System.Drawing.Point(526, 151)
        Me.lblSalidaZ.Name = "lblSalidaZ"
        Me.lblSalidaZ.Size = New System.Drawing.Size(347, 25)
        Me.lblSalidaZ.TabIndex = 59
        Me.lblSalidaZ.Text = "El resultado aproximado para Z es "
        Me.lblSalidaZ.Visible = False
        '
        'lblSalidaY
        '
        Me.lblSalidaY.AutoSize = True
        Me.lblSalidaY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSalidaY.Location = New System.Drawing.Point(527, 113)
        Me.lblSalidaY.Name = "lblSalidaY"
        Me.lblSalidaY.Size = New System.Drawing.Size(348, 25)
        Me.lblSalidaY.TabIndex = 58
        Me.lblSalidaY.Text = "El resultado aproximado para Y es "
        Me.lblSalidaY.Visible = False
        '
        'lblSalidaX
        '
        Me.lblSalidaX.AutoSize = True
        Me.lblSalidaX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSalidaX.Location = New System.Drawing.Point(526, 68)
        Me.lblSalidaX.Name = "lblSalidaX"
        Me.lblSalidaX.Size = New System.Drawing.Size(349, 25)
        Me.lblSalidaX.TabIndex = 57
        Me.lblSalidaX.Text = "El resultado aproximado para X es "
        Me.lblSalidaX.Visible = False
        '
        'JACOBI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1167, 579)
        Me.Controls.Add(Me.txtSalidaY)
        Me.Controls.Add(Me.txtSalidaZ)
        Me.Controls.Add(Me.txtSalidaX)
        Me.Controls.Add(Me.lblSalidaZ)
        Me.Controls.Add(Me.lblSalidaY)
        Me.Controls.Add(Me.lblSalidaX)
        Me.Controls.Add(Me.txt12)
        Me.Controls.Add(Me.txt11)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCoeficientes)
        Me.Controls.Add(Me.dgvSalida)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt9)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt8)
        Me.Controls.Add(Me.txt7)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCifras)
        Me.Name = "JACOBI"
        Me.Text = "JACOBI"
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt12 As TextBox
    Friend WithEvents txt11 As TextBox
    Friend WithEvents txt10 As TextBox
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCoeficientes As Button
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents colX As DataGridViewTextBoxColumn
    Friend WithEvents colY As DataGridViewTextBoxColumn
    Friend WithEvents colZ As DataGridViewTextBoxColumn
    Friend WithEvents colEx As DataGridViewTextBoxColumn
    Friend WithEvents colEy As DataGridViewTextBoxColumn
    Friend WithEvents colEz As DataGridViewTextBoxColumn
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt9 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt8 As TextBox
    Friend WithEvents txt7 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCifras As TextBox
    Friend WithEvents txtSalidaY As TextBox
    Friend WithEvents txtSalidaZ As TextBox
    Friend WithEvents txtSalidaX As TextBox
    Friend WithEvents lblSalidaZ As Label
    Friend WithEvents lblSalidaY As Label
    Friend WithEvents lblSalidaX As Label
End Class
