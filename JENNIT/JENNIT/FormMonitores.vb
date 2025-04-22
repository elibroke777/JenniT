Public Class FormMonitores

    ' Propiedades públicas para pasar datos entre formularios
    Public Property ID As Integer
    Public Property Marca As String
    Public Property NoSerie As String
    Public Property NoParte As String
    Public Property Modelo As String
    Public Property EsModificar As Boolean = False

    Private Sub FormMonitores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EsModificar Then
            ' Si vamos a modificar, se cargan los datos existentes
            txtMarca.Text = Marca
            txtNoSerie.Text = NoSerie
            txtNoParte.Text = NoParte
            txtModelo.Text = Modelo
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Se guardan los valores que se escribieron en los TextBox
        Marca = txtMarca.Text
        NoSerie = txtNoSerie.Text
        NoParte = txtNoParte.Text
        Modelo = txtModelo.Text

        ' Se indica que el formulario se cerró con éxito
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Se cierra el formulario sin guardar cambios
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
