Imports System.Net.Mail
Imports System
Imports System.IO
Imports System.ComponentModel

Public Class Form2
    Dim email As New MailMessage()
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.InitialDirectory = Application.StartupPath.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try

            Dim path As String = Application.StartupPath.ToString() & "/mail.txt"
            Dim sw As StreamWriter

            Dim createText() As String = {"mailAddressHere", "MailAddress2Here"}
            File.WriteAllLines(path, createText)


            Dim readText() As String = File.ReadAllLines(path)
            Dim s As String
            For Each s In readText
                email.To.Add(s)
            Next
            email.From = New MailAddress(TextBox1.Text)
            email.Body = txtMail.Text
            If Not OpenFileDialog1.FileName = vbNullString Then
                Dim attach As New Attachment(Application.StartupPath.ToString() & "/maliyet.xlsx")

                email.Attachments.Add(attach)
            End If
            email.Subject = txtSubject.Text
            email.Priority = email.Priority.Normal

            Using SMTP As New SmtpClient
                SMTP.EnableSsl = True
                SMTP.Port = "587"
                SMTP.Host = "smtp.live.com"
                SMTP.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
                SMTP.Send(email)
            End Using
            MessageBox.Show("Gonderildi!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtDosya.Text = OpenFileDialog1.FileName
    End Sub
End Class