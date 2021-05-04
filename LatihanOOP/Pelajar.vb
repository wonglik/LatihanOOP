Public Class Pelajar

    Private strNoMatrik As String

    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik
    End Sub

    Public Function Politeknik() As String
        Dim strKodPoli As String = strNoMatrik.Substring(0, 2)

        If strKodPoli = 18 Then
            Return "PTSS"
        Else
            Return "Not PTSS"
        End If
    End Function

    Public Function Program() As String
        Dim strKodPogram As String = strNoMatrik.Substring(2, 3)

        If strKodPogram = "DDT" Then
            Return "Diploma in Digital Technology"
        Else
            Return "Not Diploma in Digital Technology"
        End If
    End Function

    Public Function Ambilan() As String
        Dim strTahun As String = strNoMatrik.Substring(5, 3)
        Dim strSesi As String = strNoMatrik.Substring(8, 1)

        If strTahun = "19F" Then
            If strSesi = "1" Then
                Return "Jun 2019"
            ElseIf strSesi = "2" Then
                Return "Dec 2019"
            End If
        Else
            Return "Not Sesi 2019"
        End If
    End Function
End Class
