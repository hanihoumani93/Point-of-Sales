Imports System.Data.OleDb

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Plz Fill All the info")
        Else
            uname = txtUsername.Text
            pword = txtPassword.Text
            Dim querry As String = "Select password From Table1 where username= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exit")
            End Try
            If (pword = pass) Then
                MsgBox("Login success")
                Items.Show()
                If Items.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("login Failed")
                txtUsername.Clear()
                txtPassword.Clear()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Register.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class