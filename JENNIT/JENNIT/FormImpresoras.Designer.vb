<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImpresoras
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoParte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.TxtEtiqueta = New System.Windows.Forms.TextBox()
        Me.txtNoSerie = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.PictureBox()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "NoParte"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNoParte
        '
        Me.txtNoParte.Location = New System.Drawing.Point(62, 93)
        Me.txtNoParte.Name = "txtNoParte"
        Me.txtNoParte.Size = New System.Drawing.Size(100, 20)
        Me.txtNoParte.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Etiqueta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "NoSerie"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(62, 179)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 25
        '
        'TxtEtiqueta
        '
        Me.TxtEtiqueta.Location = New System.Drawing.Point(62, 131)
        Me.TxtEtiqueta.Name = "TxtEtiqueta"
        Me.TxtEtiqueta.Size = New System.Drawing.Size(100, 20)
        Me.TxtEtiqueta.TabIndex = 24
        '
        'txtNoSerie
        '
        Me.txtNoSerie.Location = New System.Drawing.Point(62, 56)
        Me.txtNoSerie.Name = "txtNoSerie"
        Me.txtNoSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtNoSerie.TabIndex = 23
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(62, 12)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 22
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(62, 216)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(100, 20)
        Me.txtIP.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "IP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.JENNIT.My.Resources.Resources._1486395882_close_80604
        Me.btnCancelar.Location = New System.Drawing.Point(247, 119)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 80)
        Me.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.JENNIT.My.Resources.Resources._1486395886_checkmark_80611
        Me.btnAceptar.Location = New System.Drawing.Point(247, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 80)
        Me.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.TabStop = False
        '
        'FormImpresoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 241)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoParte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.TxtEtiqueta)
        Me.Controls.Add(Me.txtNoSerie)
        Me.Controls.Add(Me.txtMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormImpresoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormImpresoras"
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoParte As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As PictureBox
    Friend WithEvents btnAceptar As PictureBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents TxtEtiqueta As TextBox
    Friend WithEvents txtNoSerie As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label6 As Label
End Class
