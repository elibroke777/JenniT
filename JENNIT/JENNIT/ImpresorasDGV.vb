Imports System.Data.SqlClient
Public Class ImpresorasDGV

    ' Cadena de conexión a tu base de datos SQL Server
    Dim conexion As New SqlConnection("Server=LAPTOP-8632NMPI\SQLEXPRESS; Database=InvBodg2025; Integrated Security=True")
    Dim adaptador As SqlDataAdapter
    Dim tabla As DataTable

    Private Sub ImpresorasDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTabla() ' Llamamos la función MostrarTabla
    End Sub

    Private Sub MostrarTabla()
        Try
            conexion.Open() ' Se abre la conexión
            ' Se hace la consulta en la BD y se utiliza el ISNULL
            ' Para que el DataGridView acepte NULL
            Dim consultaSQL As String = "
                SELECT 
                id_Impresora,
                ISNULL(Marca, '') AS Marca,
                ISNULL(NoSerie, '') AS NoSerie,
                ISNULL(NoParte, '') AS NoParte,
                ISNULL(Etiqueta_HFI, '') AS Etiqueta_HFI,
                ISNULL(Modelo, '') AS Modelo,
                ISNULL(IP_Impresora, '') AS IP_Impresora
                FROM Impresoras"

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
        Dim form As New FormImpresoras() ' Se llama al formulario de agregar Impresora

        If form.ShowDialog() = DialogResult.OK Then
            ' Se crea la Query para insertar a la base de datos
            Dim cmd As New SqlCommand("INSERT INTO Impresoras (Marca, NoSerie, NoParte, Etiqueta_HFI, Modelo, IP_Impresora) VALUES (@marca, @noserie, @noparte, @etiqueta, @modelo, @ip)", conexion)
            ' Se asignan los valores que se reciben desde FormImpresoras
            cmd.Parameters.AddWithValue("@marca", form.Marca)
            cmd.Parameters.AddWithValue("@noserie", form.NoSerie)
            cmd.Parameters.AddWithValue("@noparte", form.NoParte)
            cmd.Parameters.AddWithValue("@etiqueta", form.Etiqueta_HFI)
            cmd.Parameters.AddWithValue("@modelo", form.Modelo)
            cmd.Parameters.AddWithValue("@ip", form.IP_Impresora)

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
        Dim form As New FormImpresoras() ' Se llama al formulario para modificar
        form.EsModificar = True
        form.ID = Convert.ToInt32(row.Cells("id_Impresora").Value)
        form.Marca = row.Cells("Marca").Value.ToString()
        form.NoSerie = row.Cells("NoSerie").Value.ToString()
        form.NoParte = row.Cells("NoParte").Value.ToString()
        form.Etiqueta_HFI = row.Cells("Etiqueta_HFI").Value.ToString()
        form.Modelo = row.Cells("Modelo").Value.ToString()
        form.IP_Impresora = row.Cells("IP_Impresora").Value.ToString()

        If form.ShowDialog() = DialogResult.OK Then
            ' Se crea la query de actualización
            Dim cmd As New SqlCommand("UPDATE Impresoras SET Marca=@marca, NoSerie=@noserie, NoParte=@noparte, Etiqueta_HFI=@etiqueta, Modelo=@modelo, IP_Impresora=@ip WHERE id_Impresora=@id", conexion)
            cmd.Parameters.AddWithValue("@marca", form.Marca)
            cmd.Parameters.AddWithValue("@noserie", form.NoSerie)
            cmd.Parameters.AddWithValue("@noparte", form.NoParte)
            cmd.Parameters.AddWithValue("@etiqueta", form.Etiqueta_HFI)
            cmd.Parameters.AddWithValue("@modelo", form.Modelo)
            cmd.Parameters.AddWithValue("@ip", form.IP_Impresora)
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

        Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_Impresora").Value)
        Dim confirmacion = MessageBox.Show("¿Seguro que deseas eliminar esta impresora?", "Confirmar", MessageBoxButtons.YesNo)

        If confirmacion = DialogResult.Yes Then
            Dim cmd As New SqlCommand("DELETE FROM Impresoras WHERE id_Impresora = @id", conexion)
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
