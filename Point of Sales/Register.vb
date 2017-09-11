Imports System.Data.OleDb

Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNewUsername.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPass.Text = "" Then
            MsgBox("plz fill the info")
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
                Dim insert As String = "Insert into Table1 values('" & txtNewUsername.Text & "','" & txtNewPassword.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("create success")
                Me.Close()
            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub
End Class