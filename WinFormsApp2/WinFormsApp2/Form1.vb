Imports Class1.vb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim user As New Users
    Private Sub Valid_Click(sender As Object, e As EventArgs) Handles Valid.Click
        If user.check_content() = False Then
            MessageBox.Show("missing Info")
        Else
            user.showUser()
        End If

    End Sub

    Private Sub AdressBox_TextChanged(sender As Object, e As EventArgs) Handles AdressBox.TextChanged
        user.setAdresse(AdressBox.Text)
    End Sub

    Private Sub NumTelBox_TextChanged(sender As Object, e As EventArgs) Handles NumTelBox.TextChanged
        user.setNumtel(NumTelBox.Text)
    End Sub

    Private Sub MailBox_TextChanged(sender As Object, e As EventArgs) Handles MailBox.TextChanged
        user.setEmail(MailBox.Text)
    End Sub

    Private Sub PostalBox_TextChanged(sender As Object, e As EventArgs) Handles PostalBox.TextChanged
        user.setPostal(PostalBox.Text)
    End Sub

    Private Sub M_CheckedChanged(sender As Object, e As EventArgs) Handles M.CheckedChanged
        user.setGender(M.Text)
    End Sub

    Private Sub F_CheckedChanged(sender As Object, e As EventArgs) Handles F.CheckedChanged
        user.setGender(F.Text)
    End Sub

    Private Sub other_CheckedChanged(sender As Object, e As EventArgs) Handles other.CheckedChanged
        user.setGender(other.Text)
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        user.setName(NameBox.Text)
    End Sub

    Private Sub SurnameBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameBox.TextChanged
        user.setSurname(SurnameBox.Text)
    End Sub

    Private Sub adultBox_CheckedChanged(sender As Object, e As EventArgs) Handles adultBox.CheckedChanged
        user.setAdult(adultBox.Checked)
    End Sub

    Private Sub sportBox_CheckedChanged(sender As Object, e As EventArgs) Handles sportBox.CheckedChanged
        user.setSport(sportBox.Checked)
    End Sub

    Private Sub licenseBox_CheckedChanged(sender As Object, e As EventArgs) Handles licenseBox.CheckedChanged
        user.setLicense(licenseBox.Checked)
    End Sub

    Private Sub VilleBox_TextChanged(sender As Object, e As EventArgs) Handles cityBox.TextChanged
        user.setCity(cityBox.Text)
    End Sub
End Class
