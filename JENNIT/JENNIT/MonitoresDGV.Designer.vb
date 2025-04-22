<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoresDGV
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReturnPB = New System.Windows.Forms.PictureBox()
        Me.EliminarPB = New System.Windows.Forms.PictureBox()
        Me.ModificarPB = New System.Windows.Forms.PictureBox()
        Me.AggPB = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EliminarPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificarPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AggPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(514, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Borrar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Modificar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Agregar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(558, 215)
        Me.DataGridView1.TabIndex = 24
        '
        'ReturnPB
        '
        Me.ReturnPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnPB.Image = Global.JENNIT.My.Resources.Resources.ic_back_97586
        Me.ReturnPB.Location = New System.Drawing.Point(8, 12)
        Me.ReturnPB.Name = "ReturnPB"
        Me.ReturnPB.Size = New System.Drawing.Size(44, 43)
        Me.ReturnPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ReturnPB.TabIndex = 31
        Me.ReturnPB.TabStop = False
        '
        'EliminarPB
        '
        Me.EliminarPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EliminarPB.Image = Global.JENNIT.My.Resources.Resources.package_box_cancel_icon_177387
        Me.EliminarPB.Location = New System.Drawing.Point(487, 264)
        Me.EliminarPB.Name = "EliminarPB"
        Me.EliminarPB.Size = New System.Drawing.Size(94, 79)
        Me.EliminarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.EliminarPB.TabIndex = 27
        Me.EliminarPB.TabStop = False
        '
        'ModificarPB
        '
        Me.ModificarPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModificarPB.Image = Global.JENNIT.My.Resources.Resources.package_box_update_icon_177393
        Me.ModificarPB.Location = New System.Drawing.Point(290, 264)
        Me.ModificarPB.Name = "ModificarPB"
        Me.ModificarPB.Size = New System.Drawing.Size(94, 79)
        Me.ModificarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ModificarPB.TabIndex = 26
        Me.ModificarPB.TabStop = False
        '
        'AggPB
        '
        Me.AggPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AggPB.Image = Global.JENNIT.My.Resources.Resources.package_box_add_icon_177397
        Me.AggPB.Location = New System.Drawing.Point(106, 264)
        Me.AggPB.Name = "AggPB"
        Me.AggPB.Size = New System.Drawing.Size(94, 79)
        Me.AggPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AggPB.TabIndex = 25
        Me.AggPB.TabStop = False
        '
        'MonitoresDGV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 417)
        Me.Controls.Add(Me.ReturnPB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EliminarPB)
        Me.Controls.Add(Me.ModificarPB)
        Me.Controls.Add(Me.AggPB)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MonitoresDGV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonitoresDGV"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EliminarPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificarPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AggPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReturnPB As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EliminarPB As PictureBox
    Friend WithEvents ModificarPB As PictureBox
    Friend WithEvents AggPB As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
