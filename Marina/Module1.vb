Module Module1

    Public userId As String = ""
    Public userClave As String = ""

    Public Function getLatitud(grados As Integer, minutos As Integer, segundos As Decimal) As Decimal
        If grados > 90 Or grados < -90 Then
            Throw New ArgumentException("Latitud no válida, el valor debe estar entre -90 y 90")
        End If
        Return (grados + (minutos / 60) + (segundos / 60 / 60))
    End Function

    Public Function getLongitud(grados As Integer, minutos As Integer, segundos As Decimal) As Decimal
        If grados > 90 Or grados < -90 Then
            Throw New ArgumentException("Longitud no válida, el valor debe estar entre -180 y 180")
        End If
        Return (grados + (minutos / 60) + (segundos / 60 / 60))
    End Function

    ''' <summary>
    ''' Devuelve el valor de la coordenada formateada en grados, minutos y segundos.
    ''' </summary>
    ''' <param name="coord">Valor decimal, puede ser la longitud o la latitud.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getCoordenada(coord As Decimal) As String
        Dim grados As Integer = Int(coord)
        Dim temp As Decimal = (coord - Decimal.Parse(grados)) * 60
        Dim minutos As Integer = Int(temp)
        Dim segundos As Decimal = (temp - Decimal.Parse(minutos)) * 60

        Return grados & "º " & minutos & "' " & segundos & "''"
    End Function
End Module
