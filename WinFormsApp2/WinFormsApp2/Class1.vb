Public Class Users
    Private gender As Char
    Private name As String
    Private surname As String
    Private Adresse As String
    Private city As String
    Private postal As String
    Private email As String
    Private numtel As String
    Private adult As Boolean
    Private licence As Boolean
    Private sport As Boolean

    Public Function getGender()
        Return gender
    End Function
    Public Function getName()
        Return name
    End Function
    Public Function getSurname()
        Return surname
    End Function
    Public Function getAdult()
        Return adult
    End Function
    Public Function getLicense()
        Return licence
    End Function
    Public Function getSport()
        Return sport
    End Function
    Public Function getAdress()
        Return Adresse
    End Function
    Public Function getCity()
        Return city
    End Function
    Public Function getemail()
        Return email
    End Function
    Public Function getpostal()
        Return postal
    End Function
    Public Function getnumtel()
        Return numtel
    End Function
    Public Sub setGender(newone As Char)
        gender = newone
    End Sub
    Public Sub setName(newone As String)
        name = newone
    End Sub
    Public Sub setSurname(newone As String)
        surname = newone
    End Sub
    Public Sub setAdresse(newone As String)
        Adresse = newone
    End Sub
    Public Sub setCity(newone As String)
        city = newone
    End Sub
    Public Sub setEmail(newone As String)
        email = newone
    End Sub
    Public Sub setPostal(newone As String)
        postal = newone
    End Sub
    Public Sub setNumtel(newone As String)
        numtel = newone
    End Sub
    Public Sub setAdult(newone As Boolean)
        adult = newone
    End Sub
    Public Sub setLicense(newone As Boolean)
        licence = newone
    End Sub
    Public Sub setSport(newone As Boolean)
        sport = newone
    End Sub

    Public Sub showUser()
        MessageBox.Show("name = " & getName() & vbCrLf & "surname = " & getSurname() & vbCrLf & "adresse = " & getAdress() & " " & getpostal() & vbCrLf _
             & "city = " & getCity() & vbCrLf & "mail = " & getemail() & vbCrLf & "phone numbr = " & getnumtel() & vbCrLf & "gender = " & getGender() & vbCrLf & "adult = " _
            & getAdult() & vbCrLf & "license = " & getLicense() & vbCrLf & "Sport = " & getSport())
    End Sub
    Public Function check_content()
        If name = Nothing Or surname = Nothing Or Adresse = Nothing Or Adresse = Nothing Or postal = Nothing Or email = Nothing Or numtel = Nothing Or gender = Nothing Then
            Return False
        End If
        Return True
    End Function
End Class
