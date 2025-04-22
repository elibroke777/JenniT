Imports System.Data.SqlClient
Public Class CPUDGV

    Dim conexion As New SqlConnection("Server=LAPTOP-8632NMPI\SQLEXPRESS; Database=InvBodg2025; Integrated Security= True")
    Dim adaptador As SqlDataAdapter
    Dim tabla As DataTable

    Private Sub CPUDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTabla() ' Llamamos la funcion Mostrar Tabla
    End Sub

    Private Sub MostrarTabla()
        Try
            conexion.Open() ' Se abre la conexion
            ' Se hace la consulta en la BD y se utiliza el ISNULL
            ' Para que el DataGrisView acepte NULL
            Dim consultaSQL As String = "SELECT 
            id_CPU, 
            ISNULL(Marca, '') AS Marca, 
            ISNULL(NoSerie, '') AS NoSerie, 
            ISNULL(NoProducto, '') AS NoProducto,
            ISNULL(Etiqueta_HFI, '') AS Etiqueta_HFI, 
            ISNULL(Modelo, '') AS Modelo 
            FROM CPU"

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
            conexion.Close() ' Se cierra la conexion
        End Try
    End Sub

    Private Sub AggPB_Click(sender As Object, e As EventArgs) Handles AggPB.Click
        Dim form As New FormCPU() ' Se cambia la variable de la ventana FormCPU

        If form.ShowDialog() = DialogResult.OK Then
            ' Para crear la Query y asi agg a la BD
            Dim cmd As New SqlCommand("INSERT INTO CPU (Marca, NoSerie, NoProducto, Etiqueta_HFI, Modelo) VALUES (@marca, @noserie, @noproducto, @etiqueta, @modelo)", conexion)
            ' Lineas que se le asignan a los valores en SQL
            ' Y que se agg desde el FormCPU para Agg
            cmd.Parameters.AddWithValue("@marca", form.Marca)
            cmd.Parameters.AddWithValue("@noserie", form.NoSerie)
            cmd.Parameters.AddWithValue("@noproducto", form.NoProducto)
            cmd.Parameters.AddWithValue("@etiqueta", form.Etiqueta_HFI)
            cmd.Parameters.AddWithValue("@modelo", form.Modelo)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MostrarTabla() ' Actualizar la Tabla y mostrar en el DATAGRISVIEW
        End If
    End Sub

    Private Sub ModificarPB_Click(sender As Object, e As EventArgs) Handles ModificarPB.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            ' Por si no has seleccionando ninguna fila del DGV
            MessageBox.Show("Selecciona una fila primero.")
            Return
        End If

        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0) ' Para saber cual fila seleccionaste
        Dim form As New FormCPU() ' Actulizar el Registro
        form.EsModificar = True
        form.ID = Convert.ToInt32(row.Cells("id_CPU").Value)
        form.Marca = row.Cells("Marca").Value.ToString()
        form.NoSerie = row.Cells("NoSerie").Value.ToString()
        form.NoProducto = row.Cells("NoProducto").Value.ToString()
        form.Etiqueta_HFI = row.Cells("Etiqueta_HFI").Value.ToString()
        form.Modelo = row.Cells("Modelo").Value.ToString()

        If form.ShowDialog() = DialogResult.OK Then
            ' Para actualizar el registro de la Tabla
            Dim cmd As New SqlCommand("UPDATE CPU SET Marca=@marca, NoSerie=@noserie, NoProducto=@noproducto, Etiqueta_HFI=@etiqueta, Modelo=@modelo WHERE id_CPU=@id", conexion)
            cmd.Parameters.AddWithValue("@marca", form.Marca)
            cmd.Parameters.AddWithValue("@noserie", form.NoSerie)
            cmd.Parameters.AddWithValue("@noproducto", form.NoProducto)
            cmd.Parameters.AddWithValue("@etiqueta", form.Etiqueta_HFI)
            cmd.Parameters.AddWithValue("@modelo", form.Modelo)
            cmd.Parameters.AddWithValue("@id", form.ID)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MostrarTabla()
        End If
    End Sub

    Private Sub EliminarPB_Click(sender As Object, e As EventArgs) Handles EliminarPB.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            ' Para ver si seleccionaste una fila
            MessageBox.Show("Selecciona una fila primero.")
            Return
        End If

        Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_CPU").Value)
        ' Para ver cual ID seleccionaste
        Dim confirmacion = MessageBox.Show("¿Seguro que deseas eliminar este CPU?", "Confirmar", MessageBoxButtons.YesNo)
        ' Para confirmar si vas a eliminar ese registro

        If confirmacion = DialogResult.Yes Then
            ' Query para eliminar el registro
            Dim cmd As New SqlCommand("DELETE FROM CPU WHERE id_CPU = @id", conexion)
            cmd.Parameters.AddWithValue("@id", id)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MostrarTabla()
        End If
    End Sub

    Private Sub ReturnPB_Click(sender As Object, e As EventArgs) Handles ReturnPB.Click
        Me.Close() ' Se cierra la ventana CPUDGV
        Seleccion.Show() ' Se muestra Seleccion
    End Sub
End Class
