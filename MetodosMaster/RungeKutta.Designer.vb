<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RungeKutta
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
        Me.txf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.coln = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntegral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.th = New System.Windows.Forms.TextBox()
        Me.ty = New System.Windows.Forms.TextBox()
        Me.tx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txf
        '
        Me.txf.Location = New System.Drawing.Point(472, 107)
        Me.txf.Name = "txf"
        Me.txf.Size = New System.Drawing.Size(100, 22)
        Me.txf.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(297, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 25)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "xf"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(642, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 39)
        Me.Button3.TabIndex = 98
        Me.Button3.Text = "salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(642, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 39)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(642, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 39)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvSalida
        '
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coln, Me.colIntegral, Me.colError})
        Me.dgvSalida.Location = New System.Drawing.Point(54, 302)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersWidth = 51
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(840, 225)
        Me.dgvSalida.TabIndex = 95
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
        Me.colIntegral.HeaderText = "xi"
        Me.colIntegral.MinimumWidth = 6
        Me.colIntegral.Name = "colIntegral"
        '
        'colError
        '
        Me.colError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colError.HeaderText = "yi"
        Me.colError.MinimumWidth = 6
        Me.colError.Name = "colError"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(472, 245)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 22)
        Me.tc.TabIndex = 89
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(472, 201)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 22)
        Me.tf.TabIndex = 88
        '
        'th
        '
        Me.th.Location = New System.Drawing.Point(471, 153)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(100, 22)
        Me.th.TabIndex = 87
        '
        'ty
        '
        Me.ty.Location = New System.Drawing.Point(471, 61)
        Me.ty.Name = "ty"
        Me.ty.Size = New System.Drawing.Size(100, 22)
        Me.ty.TabIndex = 85
        '
        'tx
        '
        Me.tx.Location = New System.Drawing.Point(471, 19)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(100, 22)
        Me.tx.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(298, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 25)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Dame cifras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(297, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Dame funcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(297, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Dame h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(296, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Dame y()"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(296, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Dame x()"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(472, 568)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(160, 22)
        Me.txtResult.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(214, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 25)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "El valor aproximado es:"
        '
        'RungeKutta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MetodosMaster.My.Resources.Resources.xx
        Me.ClientSize = New System.Drawing.Size(959, 626)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvSalida)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.ty)
        Me.Controls.Add(Me.tx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RungeKutta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RungeKutta"
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txf As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents coln As DataGridViewTextBoxColumn
    Friend WithEvents colIntegral As DataGridViewTextBoxColumn
    Friend WithEvents colError As DataGridViewTextBoxColumn
    Friend WithEvents tc As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents th As TextBox
    Friend WithEvents ty As TextBox
    Friend WithEvents tx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label7 As Label
End Class
