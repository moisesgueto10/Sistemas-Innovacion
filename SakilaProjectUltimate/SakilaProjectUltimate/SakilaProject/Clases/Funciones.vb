Public Class Funciones

    Public id_temp, id1_temp, id2_temp, id_tempcampus As Integer
    Public id_temp3, id_temp4, id_tempusuario As String

    Public Sub setIdcampus(ByVal idcampus As Integer)
        id_tempcampus = idcampus
    End Sub

    Public Function getcampus()
        Return id_tempcampus
    End Function

    Public Sub setIdusuario(ByVal idusuario As String)
        id_tempusuario = idusuario
    End Sub

    Public Function getIdusuario()
        Return id_tempusuario
    End Function

    Public Sub setId4(ByVal id4 As String)
        id_temp4 = id4
    End Sub

    Public Function getId4()
        Return id_temp4
    End Function

    Public Sub setId3(ByVal id3 As String)
        id_temp3 = id3
    End Sub

    Public Function getId3()
        Return id_temp3
    End Function

    Public Sub setId2(ByVal id2 As Integer)
        id2_temp = id2
    End Sub

    Public Function getId2()
        Return id2_temp
    End Function

    Public Sub setId(ByVal id As Integer)
        id_temp = id
    End Sub

    Public Function getId()
        Return id_temp
    End Function

    Public Sub setId1(ByVal id1 As Integer)
        id1_temp = id1
    End Sub

    Public Function getId1()
        Return id1_temp
    End Function



    Public Sub seleccionCb(ByRef cb As ComboBox, ByVal id As Integer)
        For i = 0 To cb.Items.Count - 1
            If cb.Items(i).Value = Int(id) Then
                cb.SelectedIndex = i
            End If
        Next
    End Sub

    Public Sub seleccionCb1(ByRef cb As ComboBox, ByVal id As String)
        For i = 0 To cb.Items.Count - 1
            If cb.Items(i).Value = Int(id) Then
                cb.SelectedIndex = i
            End If
        Next
    End Sub

End Class
