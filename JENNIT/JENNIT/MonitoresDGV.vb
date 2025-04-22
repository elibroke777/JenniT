Imports System.Data.SqlClient
Public Class MonitoresDGV

    ' Cadena de conexión a tu base de datos SQL Server
    Dim conexion As New SqlConnection("Server=LAPTOP-8632NMPI\SQLEXPRESS; Database=InvBodg2025; Integrated Security=True")
    Dim adaptador As SqlDataAdapter
    Dim tabla As DataTable

    Private Sub MonitoresDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTabla() ' Llamamos la función MostrarTabla
    End Sub

    Private Sub MostrarTabla()
        Try
            conexion.Open() ' Se abre la conexión
            ' Se hace la consulta en la BD y se utiliza el ISNULL
            ' Para que el DataGridView acepte NULL
            Dim consultaSQL As String = "
                SELECT 
                id_Monitor,
                ISNULL(Marca, '') AS Marca,
                ISNULL(NoSerie, '') AS NoSerie,
                ISNULL(NoParte, '') AS NoParte,
                ISNULL(Modelo, '') AS Modelo
                FROM Monitores"

            adaptador = New SqlDataAdapter(consultaSQL, conexion)
            tabla = New DataTable()
            adaptador.Fill(tabla)

            If tabla IsNot Nothing Then ' Se hace un If para que pueda aceptar NULL
                DataGridView1.DataSource = tabla
                DataGridView1.AllowUserToAddRows = False
            Else
                MessageBox.Show("No se pudo cargar la tabla")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al mostrar datos: " & ex.Message)
        Finally
            conexion.Close() ' Se cierra la conexión
        End Try
    End Sub

    Private Sub AggPB_Click(sender As Object, e As EventArgs) Handles AggPB.Click
        Dim form As New FormMonitores() ' Se llama al formulario de agregar Monitor

        If form.ShowDialog() = DialogResult.OK Then
            ' Se crea la Query para insertar a la base de datos
            Dim cmd As New SqlCommand("INSERT INTO Monitores (Marca, NoSerie, NoParte, Modelo) VALUES (@marca, @noserie, @noparte, @modelo)", conexion)
            ' Se asignan los valores que se reciben desde FormMonitores
            cmd.Parameters.AddWithValue("@marca", form.Marca)
            cmd.Parameters.AddWithValue("@noserie", form.NoSerie)
            cmd.Parameters.AddWithValue("@noparte", form.NoParte)
            cmd.Parameters.AddWithValue("@modelo", form.Modelo)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MostrarTabla() ' Actualizar la tabla y mostrar en el DataGridView
        End If
    End Sub

    Private Sub ModificarPB_Click(sender As Object, e As EventArgs) Handles ModificarPB.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona una fila primero.")
            Return
        End If

        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim form As New FormMonitores() ' Se llama al formulario para modificar
        form.EsModificar = True
        form.ID = Convert.ToInt32(row.Cells("id_Monitor").Value)
        form.Marca = row.Cells("Marca").Value.ToString()
        form.NoSerie = row.Cells("NoSerie").Value.ToString()
        form.NoParte = row.Cells("NoParte").Value.ToString()
        form.Modelo = row.Cells("Modelo").Value.ToString()

        If form.ShowDialog() = DialogResult.OK Then
            ' Se crea la query de actualización
            Dim cmd As New SqlCommand("UPDATE Monitores SET Marca=@marca, NoSerie=@noserie, NoParte=@noparte, Modelo=@modelo WHERE id_Monitor=@id", conexion)
            cmd.Parameters.AddWithValue("@marca", form.Marca)
            cmd.Parameters.AddWithValue("@noserie", form.NoSerie)
            cmd.Parameters.AddWithValue("@noparte", form.NoParte)
            cmd.Parameters.AddWithValue("@modelo", form.Modelo)
            cmd.Parameters.AddWithValue("@id", form.ID)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MostrarTabla() ' Refrescar la tabla
        End If
    End Sub

    Private Sub EliminarPB_Click(sender As Object, e As EventArgs) Handles EliminarPB.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona una fila primero.")
            Return
        End If

        Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_Monitor").Value)
        Dim confirmacion = MessageBox.Show("¿Seguro que deseas eliminar este monitor?", "Confirmar", MessageBoxButtons.YesNo)

        If confirmacion = DialogResult.Yes Then
            Dim cmd As New SqlCommand("DELETE FROM Monitores WHERE id_Monitor = @id", conexion)
            cmd.Parameters.AddWithValue("@id", id)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MostrarTabla()
        End If
    End Sub

    Private Sub ReturnPB_Click(sender As Object, e As EventArgs) Handles ReturnPB.Click
        Me.Close() ' Cierra esta ventana
        Seleccion.Show() ' Vuelve a la pantalla de selección
    End Sub
End Class
