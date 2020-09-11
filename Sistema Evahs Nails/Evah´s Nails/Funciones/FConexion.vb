Imports System.Data.SqlClient

Public Class FConexion
    Protected cnn As New SqlConnection

    Public Function FnConectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-S193138\SQLEXPRESS; Initial Catalog=Evahs_Nails; Integrated Security=true")
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
