Imports System.Data.SqlClient
Public Class ClsProducto
    Public Function pus_Listar_Producto() As Data.DataSet
        Dim lobjExacute As New ABDMantenimiento.ClsConexion
        Try
            Dim Ds As New DataSet
            Using oCn As New SqlConnection(lobjExacute.conexion())
                Using oCmd As New SqlCommand
                    Using oDa As New SqlDataAdapter(oCmd)
                        oCmd.Connection = oCn
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.CommandText = "usp_s_producto"
                        oDa.SelectCommand.Connection = oCn
                        oDa.Fill(Ds)
                        pus_Listar_Producto = Ds
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'Return 1
        Finally
            lobjExacute = Nothing
        End Try
    End Function
    'funcion INSERTAR
    Public Function pus_i_producto(ByVal Codigo As String, ByVal Descripcion As String) As String
        Dim iRet As Integer
        Dim Ds As New DataSet
        Dim objcadenaconexion As New ABDMantenimiento.ClsConexion
        Using oCn As New SqlConnection
            Using oDa As New SqlDataAdapter
                Using oCmd As New SqlCommand
                    oCn.ConnectionString = objcadenaconexion.conexion
                    oCmd.Connection = oCn
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "usp_i_producto"
                    oCmd.Parameters.Add("@codigo", SqlDbType.Char).Value = Codigo
                    oCmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion
                    oCn.Open()
                    iRet = oCmd.ExecuteScalar()
                    oCn.Close()
                End Using
            End Using
        End Using
        Return iRet
    End Function
    'funcion ACTUALIZAR
    Public Function pus_u_producto(ByVal Codigo As String, ByVal Descripcion As String, ByVal id_producto As Integer) As String
        Dim lobjExecute As New ABDMantenimiento.ClsConexion
        Try
            Using oCn As New SqlConnection
                Using oDa As New SqlDataAdapter
                    Using oCmd As New SqlCommand
                        oCn.ConnectionString = lobjExecute.conexion()
                        oCmd.Connection = oCn
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.CommandText = "usp_u_producto"
                        oCmd.Parameters.Add("@codigo", SqlDbType.Char).Value = Codigo
                        oCmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion
                        oCmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = id_producto
                        oCn.Open()
                        oCmd.ExecuteNonQuery()
                        oCn.Close()
                        pus_u_producto = 1
                    End Using
                End Using
            End Using
        Catch
            pus_u_producto = 0
        Finally
            lobjExecute = Nothing
        End Try
    End Function
    'funcion ELIMINAR
    Public Function pus_eliminar_producto(ByVal id_producto As String) As String
        Dim iRet As Integer
        Dim lobjExecute As New ABDMantenimiento.ClsConexion
        Dim Ds As New DataSet
        Dim objcadenaconexion As New ClsConexion
        Using oCn As New SqlClient.SqlConnection
            Using oDa As New SqlDataAdapter
                Using oCmd As New SqlCommand
                    oCn.ConnectionString = lobjExecute.conexion()
                    oCmd.Connection = oCn
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "usp_d_producto"
                    oCmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = id_producto
                    oCn.Open()
                    iRet = oCmd.ExecuteScalar()
                    oCn.Close()
                End Using
            End Using
        End Using
        Return iRet
    End Function
End Class
