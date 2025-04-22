Imports System.Data.SqlClient

Public Class Form1

    Dim conexion As New SqlConnection("Server=LAPTOP-8632NMPI\SQLEXPRESS; Database=InvBodg2025; Integrated Security= True")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Obtener los valores de los campos de usuario y contraseña
        Dim userName As String = UserNameTB.Text
        Dim password As String = PassTB.Text

        ' Verificamos si los campos no están vacíos
        If userName = "" Or password = "" Then
            MessageBox.Show("Por favor, ingresa el nombre de usuario y la contraseña.")
            Return
        End If

        Try
            ' Consulta SQL para verificar si el usuario y contraseña existen en la tabla 'Users'
            Dim consultaSQL As String = "SELECT * FROM Users WHERE UserName = @userName AND Pass = @password"
            Dim cmd As New SqlCommand(consultaSQL, conexion)
            cmd.Parameters.AddWithValue("@userName", userName)
            cmd.Parameters.AddWithValue("@password", password)

            ' Abrimos la conexión y ejecutamos la consulta
            conexion.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Si encontramos un usuario con esa combinación de datos
            If reader.HasRows Then
                reader.Read()
                MessageBox.Show("¡Bienvenido, " & reader("Nombre") & " " & reader("Apellido_P") & "!")

                Me.Hide()
                Seleccion.Show()

            Else
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
