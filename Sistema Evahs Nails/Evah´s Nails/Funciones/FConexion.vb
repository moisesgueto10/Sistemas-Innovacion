Imports System.Data.SqlClient

Public Class FConexion
    Protected cnn As New SqlConnection
    Dim cs As String = "Data Source=LAPTOP-PE7JLK60\SQLEXPRESS;Initial Catalog=Evahs_Nails;Integrated Security=True"
    Public Function Consultas(ByVal Comando As String) As DataSet
        Dim dsa As New DataSet
        Dim sqlCnn As New SqlConnection(cs)
        Dim da As New SqlDataAdapter(Comando, sqlCnn)

        da.Fill(dsa)
        Consultas = dsa

        dsa.Dispose()
        sqlCnn.Dispose()
        da.Dispose()
    End Function
    Public Function Modificaciones(ByVal Comando As String) As Boolean

        Dim sqlCnn As New SqlConnection(cs)
        Dim sqlCm As New SqlCommand(Comando, sqlCnn)
        sqlCnn.Open()
        sqlCm.ExecuteNonQuery()
        sqlCnn.Dispose()
        sqlCm.Dispose()
        Modificaciones = True
    End Function
    Public Function FnConectado()
        Try
            cnn = New SqlConnection("Data Source=LAPTOP-PE7JLK60\SQLEXPRESS; Initial Catalog=Evahs_Nails; Integrated Security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox("ERROR AL CONECTARSE A LA BASE DE DATOS" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function

    Public Function FnDesconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR AL CONECTARSE A LA BASE DE DATOS" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function
End Class
