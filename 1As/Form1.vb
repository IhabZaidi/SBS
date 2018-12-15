Imports System.Text

Public Class Form1

    Public arabic As String = "عربية"
    Public philo As String = "فلسفة"
    Public physi As String = "فيزياء"
    Public math As String = "رياضيات"
    Public sport As String = "رياضة"
    Public islam As String = "علوم شريعة"
    Dim lst As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lst.Add(arabic)
        lst.Add(philo)
        lst.Add(physi)
        lst.Add(math)
        lst.Add(sport)
        lst.Add(islam)
        Dim rnd As New Random()
        'Get a random number from 10 to 99  (2 digits)
        Dim randomNumber As Integer = rnd.Next(0, 5)
        TextBox1.Text = lst(randomNumber)
    End Sub

   
End Class
