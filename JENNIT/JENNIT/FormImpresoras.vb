Public Class FormImpresoras
    ' Propiedades públicas para enviar y recibir datos entre formularios
    Public Property ID As Integer
    Public Property Marca As String
    Public Property NoSerie As String
    Public Property NoParte As String
    Public Property Etiqueta_HFI As String
    Public Property Modelo As String
    Public Property IP_Impresora As String
    Public Property EsModificar As Boolean = False ' Saber si es para modificar

    Private Sub FormImpresoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Si es modificar, cargamos los datos existentes en los TextBox
        If EsModificar Then
            txtMarca.Text = Marca
            txtNoSerie.Text = NoSerie
            txtNoParte.Text = NoParte
            TxtEtiqueta.Text = Etiqueta_HFI
            txtModelo.Text = Modelo
            txtIP.Text = IP_Impresora
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Validación sencilla por si están vacíos campos importantes
        If txtMarca.Text.Trim() = "" Or txtNoSerie.Text.Trim() = "" Then
            MessageBox.Show("Por favor completa los campos obligatorios (Marca y No. Serie).")
            Return
        End If

        ' Asignamos los valores a las propiedades públicas
        Marca = txtMarca.Text
        NoSerie = txtNoSerie.Text
        NoParte = txtNoParte.Text
        Etiqueta_HFI = TxtEtiqueta.Text
        Modelo = txtModelo.Text
        IP_Impresora = txtIP.Text

        Me.DialogResult = DialogResult.OK ' Para cerrar el formulario con resultado OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel ' Para cerrar sin guardar
        Me.Close()
    End Sub
End Class
