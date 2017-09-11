Imports System.Data.OleDb

Public Class Items
    Private Sub txtapple_TextChanged(sender As Object, e As EventArgs) Handles txtapple1.TextChanged
        txtapple1.Enabled = False
    End Sub

    Private Sub txtorange_TextChanged(sender As Object, e As EventArgs) Handles txtorange1.TextChanged
        txtorange1.Enabled = False
    End Sub

    Private Sub txtbroccoli_TextChanged(sender As Object, e As EventArgs) Handles txtbroccoli1.TextChanged
        txtbroccoli1.Enabled = False
    End Sub

    Private Sub txtapple_TextChanged_1(sender As Object, e As EventArgs) Handles txtapple.TextChanged
        txtapple.Enabled = False
    End Sub

    Private Sub txtorange_TextChanged_1(sender As Object, e As EventArgs) Handles txtorange.TextChanged
        txtorange.Enabled = False
    End Sub

    Private Sub txtbroccoli_TextChanged_1(sender As Object, e As EventArgs) Handles txtbroccoli.TextChanged
        txtbroccoli.Enabled = False
    End Sub

    Private Sub txtPriceA_TextChanged(sender As Object, e As EventArgs) Handles txtPriceA.TextChanged
        txtPriceA.Enabled = False
    End Sub

    Private Sub txtPriceO_TextChanged(sender As Object, e As EventArgs) Handles txtPriceO.TextChanged
        txtPriceO.Enabled = False
    End Sub

    Private Sub txtPriceB_TextChanged(sender As Object, e As EventArgs) Handles txtPriceB.TextChanged
        txtPriceB.Enabled = False
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PointSales_dbDataSet2.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter1.Fill(Me.PointSales_dbDataSet2.Table2)
        'TODO: This line of code loads data into the 'PointSales_dbDataSet1.Table2' table. You can move, or remove it, as needed.
        Table2TableAdapter.Fill(PointSales_dbDataSet1.Table2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim appleQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Apple' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                appleQ = CInt(dr(0))
                txtTotalAppleQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim orangeQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Orange' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                orangeQ = CInt(dr(0))
                txtTotalOrangeQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim broccoliQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Broccoli' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                broccoliQ = CInt(dr(0))
                txtTotalBroccoliQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim appleP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Apple' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                appleP = CInt(dr(0))
                txtTotalApplePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim orangeP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Orange' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                orangeP = CInt(dr(0))
                txtTotalOrangePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim broccoliP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Broccoli' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                broccoliP = CInt(dr(0))
                txtTotalBroccoliPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim totalQ As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                totalQ = CInt(dr(0))
                txtTotalQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim totalP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                totalP = CInt(dr(0))
                txtTotalPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txttomateo_TextChanged(sender As Object, e As EventArgs) Handles txttomateo.TextChanged
        txttomateo.Enabled = False
    End Sub

    Private Sub txtPriceT_TextChanged(sender As Object, e As EventArgs) Handles txtPriceT.TextChanged
        txtPriceT.Enabled = False
    End Sub

    Private Sub txtmushroom_TextChanged(sender As Object, e As EventArgs) Handles txtmushroom.TextChanged
        txtmushroom.Enabled = False
    End Sub

    Private Sub txtPriceM_TextChanged(sender As Object, e As EventArgs) Handles txtPriceM.TextChanged
        txtPriceM.Enabled = False
    End Sub

    Private Sub txtbeansprout_TextChanged(sender As Object, e As EventArgs) Handles txtbeansprout.TextChanged
        txtbeansprout.Enabled = False
    End Sub

    Private Sub txtPriceBE_TextChanged(sender As Object, e As EventArgs) Handles txtPriceBE.TextChanged
        txtPriceBE.Enabled = False
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        TextBox9.Enabled = False
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox8.Enabled = False
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)
        TextBox7.Enabled = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim tomatoeQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Tomatoe' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                tomatoeQ = CInt(dr(0))
                txtTotalTomatoeQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim mushroomQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Mushroom' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                mushroomQ = CInt(dr(0))
                txtTotalMushroomQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim beansproutsQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Beansprouts' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                beansproutsQ = CInt(dr(0))
                txtTotalBeansQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim tomatoeP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Tomatoe' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                tomatoeP = CInt(dr(0))
                txtTotalTomatoePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim mushroomP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Mushroom' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                mushroomP = CInt(dr(0))
                txtTotalMushroomPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim beansP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Beansprouts' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                beansP = CInt(dr(0))
                txtTotalBeansPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox7.Enabled = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim lettuceQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Lettuce' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                lettuceQ = CInt(dr(0))
                txtTotalLettuceQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtTotalLettuceQnty_TextChanged(sender As Object, e As EventArgs) Handles txtTotalLettuceQnty.TextChanged

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim grapseQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Grapse' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                grapseQ = CInt(dr(0))
                txtTotalGrapseQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim cucumberQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Cucumber' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                cucumberQ = CInt(dr(0))
                txtTotalCucumberQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim carrotsQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Carrots' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                carrotsQ = CInt(dr(0))
                txtTotalCarrotsQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim lettuceP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Lettuce' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                lettuceP = CInt(dr(0))
                txtTotalLettucePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim grapseP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Grapse' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                grapseP = CInt(dr(0))
                txtTotalGrapsePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim cucumberP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Cucumber' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                cucumberP = CInt(dr(0))
                txtTotalCucumberPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim carrotsP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Carrots' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                carrotsP = CInt(dr(0))
                txtTotalCarrotsPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim celeryQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Celery' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                celeryQ = CInt(dr(0))
                txtTotalCeleryQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim onionsQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Onions' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                onionsQ = CInt(dr(0))
                txtTotalOnionsQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim sprinQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'SpringOnion' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                sprinQ = CInt(dr(0))
                txtTotalSpringOnionQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim milkQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Milk' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                milkQ = CInt(dr(0))
                txtTotalMilkQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim onionsP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Onions' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                onionsP = CInt(dr(0))
                txtTotalOnionsPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim sprinP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'SpringOnion' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                sprinP = CInt(dr(0))
                txtTotalSpringOnionPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim milkP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Milk' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                milkP = CInt(dr(0))
                txtTotalMilkPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim celeryP As Double
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Celery' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                celeryP = CInt(dr(0))
                txtTotalCeleryPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtsmokedfish.TextChanged

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim meatballQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'MeatBall' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                meatballQ = CInt(dr(0))
                txtTotalMeatBallQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim meatQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Meat' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                meatQ = CInt(dr(0))
                txtTotalMeatQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim baconQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Bacon' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                baconQ = CInt(dr(0))
                txtTotalBaconQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim smokesQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Smokes' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                smokesQ = CInt(dr(0))
                txtTotalSmokesQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim smokedfishQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'SmokedFish' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                smokedfishQ = CInt(dr(0))
                txtTotalSmokedFishQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim fishQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Fish' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                fishQ = CInt(dr(0))
                txtTotalFishQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim meatballP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'MeatBall' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                meatballP = CInt(dr(0))
                txtTotalMeatBallPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim meatP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Meat' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                meatP = CInt(dr(0))
                txtTotalMeatPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim baconP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Bacon' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                baconP = CInt(dr(0))
                txtTotalBaconPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim smokesP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Smokes' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                smokesP = CInt(dr(0))
                txtTotalSmokesPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim smokedfishP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'SmokedFish' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                smokedfishP = CInt(dr(0))
                txtTotalSmokedFishPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim fishP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Fish' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                fishP = CInt(dr(0))
                txtTotalFishPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim riceQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Rice' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                riceQ = CInt(dr(0))
                txtTotalRiceQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim beansQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Beans' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                beansQ = CInt(dr(0))
                txtBeansQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim cheeseQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Cheese' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                cheeseQ = CInt(dr(0))
                txtTotalCheeseQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim vodkaQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Vodka' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                vodkaQ = CInt(dr(0))
                txtTotalVodkasQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim wineQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Wine' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                wineQ = CInt(dr(0))
                txtTotalWineQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim whiskeyQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Whiskey' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                whiskeyQ = CInt(dr(0))
                txtTotalWhiskeyQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim rumQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Rum' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                rumQ = CInt(dr(0))
                txtTotalRumQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim ginQ As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Quantity) as Quantity from Table2 where Item = 'Gin' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                ginQ = CInt(dr(0))
                txtTotalGinQnty.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim riceP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Rice' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                riceP = CInt(dr(0))
                txtTotalRicePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim beansP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Beans' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                beansP = CInt(dr(0))
                txtTotalRicePricee.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim cheeseP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Cheese' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                cheeseP = CInt(dr(0))
                txtTotalCheesePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim vodkaP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Vodka' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                vodkaP = CInt(dr(0))
                txtTotalVodkaPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim wineP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Wine' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                wineP = CInt(dr(0))
                txtTotalWinePrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim whiskeyP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Whiskey' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                whiskeyP = CInt(dr(0))
                txtTotalWhiskeyPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim rumP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Rum' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                rumP = CInt(dr(0))
                txtTotalRumPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Dim cn As OleDbConnection

        Dim cmd As OleDbCommand

        Dim dr As OleDbDataReader
        Dim ginP As Integer
        Try

            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb")
            cn.Open()
            cmd = New OleDbCommand("Select sum(Price) as Price from Table2 where Item = 'Gin' ", cn)

            dr = cmd.ExecuteReader

            While dr.Read()
                ginP = CInt(dr(0))
                txtTotalGinPrice.Text = CStr(dr(0))
            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if youn want to Logout", "Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Login.txtUsername.Text = ""
            Login.txtPassword.Text = ""

            Me.Close()

        End If
    End Sub

    Private Sub txtTotalAppleQnty_TextChanged(sender As Object, e As EventArgs) Handles txtTotalAppleQnty.TextChanged

    End Sub
End Class