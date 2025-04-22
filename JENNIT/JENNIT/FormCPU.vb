Public Class FormCPU
    ' Propiedades públicas para enviar y recibir datos
    Public Property ID As Integer
    Public Property Marca As String
    Public Property NoSerie As String
    Public Property NoProducto As String
    Public Property Etiqueta_HFI As String
    Public Property Modelo As String
    Public Property EsModificar As Boolean = False

    Private Sub FormCPU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EsModificar Then
            txtMarca.Text = Marca
            txtNoSerie.Text = NoSerie
            txtNoProducto.Text = NoProducto
            TxtEtiqueta.Text = Etiqueta_HFI
            txtModelo.Text = Modelo
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Validaciones simples
        If txtMarca.Text.Trim() = "" Or txtNoSerie.Text.Trim() = "" Then
            MessageBox.Show("Por favor completa todos los campos requeridos.")
            Return
        End If

        Marca = txtMarca.Text
        NoSerie = txtNoSerie.Text
        NoProducto = txtNoProducto.Text
        Etiqueta_HFI = TxtEtiqueta.Text
        Modelo = txtModelo.Text

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
