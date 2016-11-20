Public Class ClsConexion
    Public Function conexion() As String
        Dim sCn As String = "Data Source=SALO-NET;Initial Catalog=DBMantenimiento;Integrated Security=True"
        Return sCn
    End Function
End Class
