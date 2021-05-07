<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biseccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Ta = New System.Windows.Forms.TextBox()
        Me.la = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.lf = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.lb = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ta
        '
        Me.Ta.Location = New System.Drawing.Point(513, 78)
        Me.Ta.Name = "Ta"
        Me.Ta.Size = New System.Drawing.Size(281, 22)
        Me.Ta.TabIndex = 23
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.la.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.Location = New System.Drawing.Point(350, 75)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(86, 25)
        Me.la.TabIndex = 22
        Me.la.Text = "Dame a"
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(1117, 158)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(114, 39)
        Me.Salir.TabIndex = 21
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.Location = New System.Drawing.Point(899, 158)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(130, 39)
        Me.Calcular.TabIndex = 20
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(513, 35)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(281, 22)
        Me.tf.TabIndex = 18
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lf.Location = New System.Drawing.Point(350, 32)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(144, 25)
        Me.lf.TabIndex = 17
        Me.lf.Text = "Dame funcion"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(513, 175)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(281, 22)
        Me.tc.TabIndex = 27
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.Location = New System.Drawing.Point(350, 172)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(126, 25)
        Me.lc.TabIndex = 26
        Me.lc.Text = "Dame cifras"
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(513, 131)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(281, 22)
        Me.tb.TabIndex = 25
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.Location = New System.Drawing.Point(350, 128)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(86, 25)
        Me.lb.TabIndex = 24
        Me.lb.Text = "Dame b"
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.SystemColors.InfoText
        Me.Salida.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Salida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Salida.DefaultCellStyle = DataGridViewCellStyle2
        Me.Salida.Location = New System.Drawing.Point(143, 257)
        Me.Salida.Margin = New System.Windows.Forms.Padding(4)
        Me.Salida.Name = "Salida"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Salida.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Salida.RowHeadersWidth = 51
        Me.Salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Salida.Size = New System.Drawing.Size(886, 197)
        Me.Salida.TabIndex = 28
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(920, 75)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(281, 22)
        Me.txtResultado.TabIndex = 30
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(943, 47)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(231, 25)
        Me.Resultado.TabIndex = 31
        Me.Resultado.Text = "La raiz aproximada es:"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.FillWeight = 80.0!
        Me.Column1.HeaderText = "Índice"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "a"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "xi"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "b"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "f(a)"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "f(xi)"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "f(b)"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "error"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Biseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(1283, 510)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Ta)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.lf)
        Me.Name = "Biseccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biseccion"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ta As TextBox
    Friend WithEvents la As Label
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents tf As TextBox
    Friend WithEvents lf As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents lc As Label
    Friend WithEvents tb As TextBox
    Friend WithEvents lb As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Resultado As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
