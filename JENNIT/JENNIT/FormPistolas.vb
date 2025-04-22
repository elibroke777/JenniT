Public Class FormPistolas
    Public Property Marca As String
    Public Property NoSerie As String
    Public Property Etiqueta_HFI As String
    Public Property Modelo As String
    Public Property ID As Integer
    Public Property EsModificar As Boolean = False

    Private Sub FormPistola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EsModificar Then
            txtMarca.Text = Marca
            txtNoSerie.Text = NoSerie
            TxtEtiqueta.Text = Etiqueta_HFI
            txtModelo.Text = Modelo
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Marca = txtMarca.Text
        NoSerie = txtNoSerie.Text
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