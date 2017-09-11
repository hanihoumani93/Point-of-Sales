Imports System.Data.OleDb

Public Class Form1

    Dim iTax As Decimal
    Dim iSubTotal As Decimal
    Dim iTotal As Decimal
    Dim itemcost(100) As Decimal
    Dim mcTax_Rate = 0.75

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if youn want to exit", "Point of sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Change_Color(sender As Object, e As EventArgs) Handles btnWine.MouseEnter,
        btnWhiskey.MouseEnter, btnVodka.MouseEnter, btnTotal.MouseEnter, btnTomatoes.MouseEnter, btnSpringOnion.MouseEnter,
        btnSmokedFish.MouseEnter, btnSmoked.MouseEnter, btnRum.MouseEnter, btnRice.MouseEnter, btnReset.MouseEnter, btnOrange.MouseEnter,
        btnOnions.MouseEnter, btnMushrooms.MouseEnter, btnMilk.MouseEnter, btnMeatBalls.MouseEnter, btnMeat.MouseEnter, btnLettuce.MouseEnter,
        btnGrapes.MouseEnter, btnGin.MouseEnter, btnFish.MouseEnter, btnExit.MouseEnter, btnCucumber.MouseEnter, btnCheese.MouseEnter,
        btnCelery.MouseEnter, btnCarrots.MouseEnter, btnBroccoli.MouseEnter, btnBeansprouts.MouseEnter, btnBeans.MouseEnter,
        btnBacon.MouseEnter, btnApple.MouseEnter

        Dim qButton As Button = sender
        qButton.BackColor = Color.LightBlue




    End Sub

    Private Sub Change_Control(sender As Object, e As EventArgs) Handles btnWine.MouseLeave,
        btnWhiskey.MouseLeave, btnVodka.MouseLeave, btnTotal.MouseLeave,
        btnTomatoes.MouseLeave, btnSpringOnion.MouseLeave, btnSmokedFish.MouseLeave, btnSmoked.MouseLeave,
        btnRum.MouseLeave, btnRice.MouseLeave, btnReset.MouseLeave, btnOrange.MouseLeave, btnOnions.MouseLeave, btnMushrooms.MouseLeave,
        btnMilk.MouseLeave, btnMeatBalls.MouseLeave, btnMeat.MouseLeave, btnLettuce.MouseLeave, btnGrapes.MouseLeave, btnGin.MouseLeave,
        btnFish.MouseLeave, btnExit.MouseLeave, btnCucumber.MouseLeave, btnCheese.MouseLeave, btnCelery.MouseLeave, btnCarrots.MouseLeave,
        btnBroccoli.MouseLeave, btnBeansprouts.MouseLeave, btnBeans.MouseLeave, btnBacon.MouseLeave, btnApple.MouseLeave

        Dim qButton As Button = sender
        qButton.BackColor = Color.FromKnownColor(KnownColor.Control)



    End Sub



    Private Sub Numbers_Only(sender As Object, e As KeyPressEventArgs) Handles txtWine.KeyPress,
        txtWhiskey.KeyPress, txtVodka.KeyPress, txtTomatoe.KeyPress, txtSpringOnion.KeyPress, txtSmokesFish.KeyPress,
        txtSmokes.KeyPress, txtRum.KeyPress, txtRice.KeyPress, txtOrange.KeyPress, txtOnions.KeyPress, txtMushroom.KeyPress,
        txtMilk.KeyPress, txtMeats.KeyPress, txtMeatBalls.KeyPress, txtLettuce.KeyPress, txtGrapes.KeyPress, txtGin.KeyPress,
        txtFish.KeyPress, txtCucumber.KeyPress, txtCheese.KeyPress, txtCelery.KeyPress, txtCarrots.KeyPress, txtBroccoli.KeyPress,
        txtBeansprouts.KeyPress, txtBeans.KeyPress, txtBacons.KeyPress, txtApple.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, lblTax.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Items.txtapple.Text = "0"
        Items.txtorange.Text = "0"
        Items.txtbroccoli.Text = "0"


        Items.txtPriceA.Text = "0"
        Items.txtPriceB.Text = "0"
        Items.txtPriceO.Text = "0"

        Items.txttomateo.Text = "0"
        Items.txtmushroom.Text = "0"
        Items.txtbeansprout.Text = "0"

        Items.txtPriceT.Text = "0"
        Items.txtPriceM.Text = "0"
        Items.txtPriceBE.Text = "0"


        For Each t In {txtWine, txtWhiskey, txtVodka, txtTomatoe, txtSpringOnion, txtSmokesFish, txtSmokes, txtRum, txtRice, txtOrange, txtOnions, txtMushroom,
         txtMilk, txtMeats, txtMeatBalls, txtLettuce, txtGrapes, txtGin, txtFish, txtCucumber, txtCheese, txtCelery, txtCarrots, txtBroccoli, txtBeansprouts,
         txtBeans, txtBacons, txtApple}
            t.Text = "0"

        Next
        For Each k In {Items.txtlettuce, Items.txtPriceL, Items.txtgrapse, Items.txtPriceG,
          Items.txtcucumber, Items.txtPriceC, Items.txtcarrots, Items.txtPriceCarrots, Items.txtcelery, Items.txtPriceCele, Items.txtonions,
          Items.txtspring, Items.txtPriceSpring, Items.txtmilk, Items.txtPriceMilk, Items.txtPriceOnion, Items.txtmeatball, Items.txtmeat,
          Items.txtbacon, Items.txtsmokes, Items.txtsmokedfish, Items.txtfish, Items.txtPriceMeatBall, Items.txtPriceMeat, Items.txtPriceBacon,
          Items.txtPriceSmokes, Items.txtPriceSmokedFish, Items.txtPriceFish, Items.txtrice, Items.txtPriceRice, Items.txtbeans, Items.txtPriceBeans,
        Items.txtcheese, Items.txtPriceCheese, Items.txtvodka, Items.txtPriceVodka, Items.txtwine, Items.txtPriceWine, Items.txtwhiskey, Items.txtPriceWhiskey,
         Items.txtrum, Items.txtPriceRum, Items.txtgin, Items.txtPriceGin}
            k.Text = "0"


            For Each j In {Items.txtLettuce1, Items.txtlettuce, Items.txtPriceL, Items.TextBox12, Items.txtgrapse, Items.txtPriceG,
             Items.TextBox11, Items.txtcucumber, Items.txtPriceC, Items.TextBox10, Items.txtcarrots, Items.txtPriceCarrots, Items.TextBox18,
             Items.TextBox13, Items.TextBox14, Items.TextBox15, Items.txtcelery, Items.txtPriceCele, Items.txtonions,
          Items.txtspring, Items.txtPriceSpring, Items.txtmilk, Items.txtPriceMilk, Items.txtPriceOnion, Items.txtmeatball, Items.txtmeat,
          Items.txtbacon, Items.txtsmokes, Items.txtsmokedfish, Items.txtfish, Items.TextBox26, Items.TextBox27, Items.TextBox28,
           Items.TextBox19, Items.TextBox16, Items.TextBox17, Items.txtPriceMeatBall, Items.txtPriceMeat, Items.txtPriceBacon,
          Items.txtPriceSmokes, Items.txtPriceSmokedFish, Items.txtPriceFish, Items.TextBox40, Items.TextBox37, Items.TextBox25, Items.TextBox35,
             Items.TextBox36, Items.TextBox20, Items.TextBox21, Items.TextBox22, Items.txtrice, Items.txtPriceRice, Items.txtbeans, Items.txtPriceBeans,
        Items.txtcheese, Items.txtPriceCheese, Items.txtvodka, Items.txtPriceVodka, Items.txtwine, Items.txtPriceWine, Items.txtwhiskey, Items.txtPriceWhiskey,
         Items.txtrum, Items.txtPriceRum, Items.txtgin, Items.txtPriceGin}
                j.Enabled = False

            Next


        Next
        lblTax.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""
        rtbReceipt.Text = ""

        For Each chk In {chkWhiskey, chkVodka,
        chkTomatoe, chkSpringOnion, chkSmokedFish, chkSmokes,
        chkRum, chkRice, chkOrange, chkOnions, chkMushroom,
        chkMilk, chkMeatBalls, chkMeat, chkLettuce, chkGrapes, chkGin,
        chkFish, chkCucumber, chkCheese, chkCelery, chkCarrots,
        chkBroccoli, chkBeansprouts, chkBeans, chkBacon, chkApple, chkWine}
            chk.Checked = False
            chk.Enabled = False




        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PointSales_dbDataSet2.TableData' table. You can move, or remove it, as needed.


        For Each t In {txtWine, txtWhiskey, txtVodka, txtTomatoe, txtSpringOnion, txtSmokesFish, txtSmokes, txtRum, txtRice, txtOrange, txtOnions, txtMushroom,
        txtMilk, txtMeats, txtMeatBalls, txtLettuce, txtGrapes, txtGin, txtFish, txtCucumber, txtCheese, txtCelery, txtCarrots, txtBroccoli, txtBeansprouts,
        txtBeans, txtBacons, txtApple}
            t.Enabled = False


        Next


        For Each chk In {chkWhiskey, chkVodka,
        chkTomatoe, chkSpringOnion, chkSmokedFish, chkSmokes,
        chkRum, chkRice, chkOrange, chkOnions, chkMushroom,
        chkMilk, chkMeatBalls, chkMeat, chkLettuce, chkGrapes, chkGin,
        chkFish, chkCucumber, chkCheese, chkCelery, chkCarrots,
        chkBroccoli, chkBeansprouts, chkBeans, chkBacon, chkApple, chkWine}
            chk.Enabled = False




        Next
    End Sub

    Private Sub btnApple_Click(sender As Object, e As EventArgs) Handles btnApple.Click
        chkApple.Enabled = True


    End Sub

    Private Sub btnMeatBalls_Click(sender As Object, e As EventArgs) Handles btnMeatBalls.Click
        chkMeatBalls.Enabled = True

    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        chkOrange.Enabled = True
    End Sub

    Private Sub btnMeat_Click(sender As Object, e As EventArgs) Handles btnMeat.Click
        chkMeat.Enabled = True
    End Sub

    Private Sub btnBroccoli_Click(sender As Object, e As EventArgs) Handles btnBroccoli.Click
        chkBroccoli.Enabled = True
    End Sub

    Private Sub btnBacon_Click(sender As Object, e As EventArgs) Handles btnBacon.Click
        chkBacon.Enabled = True
    End Sub

    Private Sub btnTomatoes_Click(sender As Object, e As EventArgs) Handles btnTomatoes.Click
        chkTomatoe.Enabled = True
    End Sub

    Private Sub btnSmoked_Click(sender As Object, e As EventArgs) Handles btnSmoked.Click
        chkSmokes.Enabled = True
    End Sub

    Private Sub btnMushrooms_Click(sender As Object, e As EventArgs) Handles btnMushrooms.Click
        chkMushroom.Enabled = True
    End Sub

    Private Sub btnSmokedFish_Click(sender As Object, e As EventArgs) Handles btnSmokedFish.Click
        chkSmokedFish.Enabled = True
    End Sub

    Private Sub btnBeansprouts_Click(sender As Object, e As EventArgs) Handles btnBeansprouts.Click
        chkBeansprouts.Enabled = True
    End Sub

    Private Sub btnFish_Click(sender As Object, e As EventArgs) Handles btnFish.Click
        chkFish.Enabled = True
    End Sub

    Private Sub btnLettuce_Click(sender As Object, e As EventArgs) Handles btnLettuce.Click
        chkLettuce.Enabled = True
    End Sub

    Private Sub btnRice_Click(sender As Object, e As EventArgs) Handles btnRice.Click
        chkRice.Enabled = True
    End Sub

    Private Sub btnGrapes_Click(sender As Object, e As EventArgs) Handles btnGrapes.Click
        chkGrapes.Enabled = True
    End Sub

    Private Sub btnBeans_Click(sender As Object, e As EventArgs) Handles btnBeans.Click
        chkBeans.Enabled = True
    End Sub

    Private Sub btnCucumber_Click(sender As Object, e As EventArgs) Handles btnCucumber.Click
        chkCucumber.Enabled = True
    End Sub

    Private Sub btnCheese_Click(sender As Object, e As EventArgs) Handles btnCheese.Click
        chkCheese.Enabled = True
    End Sub

    Private Sub btnCarrots_Click(sender As Object, e As EventArgs) Handles btnCarrots.Click
        chkCarrots.Enabled = True
    End Sub

    Private Sub btnVodka_Click(sender As Object, e As EventArgs) Handles btnVodka.Click
        chkVodka.Enabled = True
    End Sub

    Private Sub btnCelery_Click(sender As Object, e As EventArgs) Handles btnCelery.Click
        chkCelery.Enabled = True
    End Sub

    Private Sub btnWine_Click(sender As Object, e As EventArgs) Handles btnWine.Click
        chkWine.Enabled = True
    End Sub

    Private Sub btnOnions_Click(sender As Object, e As EventArgs) Handles btnOnions.Click
        chkOnions.Enabled = True
    End Sub

    Private Sub btnWhiskey_Click(sender As Object, e As EventArgs) Handles btnWhiskey.Click
        chkWhiskey.Enabled = True
    End Sub

    Private Sub btnSpringOnion_Click(sender As Object, e As EventArgs) Handles btnSpringOnion.Click
        chkSpringOnion.Enabled = True
    End Sub

    Private Sub btnRum_Click(sender As Object, e As EventArgs) Handles btnRum.Click
        chkRum.Enabled = True
    End Sub

    Private Sub btnMilk_Click(sender As Object, e As EventArgs) Handles btnMilk.Click
        chkMilk.Enabled = True
    End Sub

    Private Sub btnGin_Click(sender As Object, e As EventArgs) Handles btnGin.Click
        chkGin.Enabled = True
    End Sub

    Private Sub chkApple_CheckedChanged(sender As Object, e As EventArgs) Handles chkApple.CheckedChanged
        If chkApple.Checked = True Then
            txtApple.Enabled = True
            txtApple.Text = ""
            txtApple.Focus()
        End If
        If chkApple.Checked = False Then
            txtApple.Enabled = False
            txtApple.Text = "0"
            chkApple.Enabled = False

        End If

    End Sub

    Private Sub txtApple_TextChanged(sender As Object, e As EventArgs) Handles txtApple.TextChanged
        If chkApple.Checked = True And txtApple.Text = "0" Then
            chkApple.Checked = False
            chkApple.Enabled = False
        End If

    End Sub

    Private Sub chkOrange_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrange.CheckedChanged
        If chkOrange.Checked = True Then
            txtOrange.Enabled = True
            txtOrange.Text = ""
            txtOrange.Focus()
        End If
        If chkOrange.Checked = False Then
            txtOrange.Enabled = False
            txtOrange.Text = "0"
            chkOrange.Enabled = False

        End If
    End Sub

    Private Sub chkBroccoli_CheckedChanged(sender As Object, e As EventArgs) Handles chkBroccoli.CheckedChanged
        If chkBroccoli.Checked = True Then
            txtBroccoli.Enabled = True
            txtBroccoli.Text = ""
            txtBroccoli.Focus()
        End If
        If chkBroccoli.Checked = False Then
            txtBroccoli.Enabled = False
            txtBroccoli.Text = "0"
            chkBroccoli.Enabled = False

        End If
    End Sub

    Private Sub chkTomatoe_CheckedChanged(sender As Object, e As EventArgs) Handles chkTomatoe.CheckedChanged
        If chkTomatoe.Checked = True Then
            txtTomatoe.Enabled = True
            txtTomatoe.Text = ""
            txtTomatoe.Focus()
        End If
        If chkTomatoe.Checked = False Then
            txtTomatoe.Enabled = False
            txtTomatoe.Text = "0"
            chkTomatoe.Enabled = False

        End If
    End Sub

    Private Sub chkMushroom_CheckedChanged(sender As Object, e As EventArgs) Handles chkMushroom.CheckedChanged
        If chkMushroom.Checked = True Then
            txtMushroom.Enabled = True
            txtMushroom.Text = ""
            txtMushroom.Focus()
        End If
        If chkMushroom.Checked = False Then
            txtMushroom.Enabled = False
            txtMushroom.Text = "0"
            chkMushroom.Enabled = False

        End If
    End Sub

    Private Sub chkBeansprouts_CheckedChanged(sender As Object, e As EventArgs) Handles chkBeansprouts.CheckedChanged
        If chkBeansprouts.Checked = True Then
            txtBeansprouts.Enabled = True
            txtBeansprouts.Text = ""
            txtBeansprouts.Focus()
        End If
        If chkBeansprouts.Checked = False Then
            txtBeansprouts.Enabled = False
            txtBeansprouts.Text = "0"
            chkBeansprouts.Enabled = False

        End If
    End Sub

    Private Sub chkLettuce_CheckedChanged(sender As Object, e As EventArgs) Handles chkLettuce.CheckedChanged
        If chkLettuce.Checked = True Then
            txtLettuce.Enabled = True
            txtLettuce.Text = ""
            txtLettuce.Focus()
        End If
        If chkLettuce.Checked = False Then
            txtLettuce.Enabled = False
            txtLettuce.Text = "0"
            chkLettuce.Enabled = False

        End If
    End Sub

    Private Sub chkGrapes_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrapes.CheckedChanged
        If chkGrapes.Checked = True Then
            txtGrapes.Enabled = True
            txtGrapes.Text = ""
            txtGrapes.Focus()
        End If
        If chkGrapes.Checked = False Then
            txtGrapes.Enabled = False
            txtGrapes.Text = "0"
            chkGrapes.Enabled = False

        End If
    End Sub

    Private Sub chkCucumber_CheckedChanged(sender As Object, e As EventArgs) Handles chkCucumber.CheckedChanged
        If chkCucumber.Checked = True Then
            txtCucumber.Enabled = True
            txtCucumber.Text = ""
            txtCucumber.Focus()
        End If
        If chkCucumber.Checked = False Then
            txtCucumber.Enabled = False
            txtCucumber.Text = "0"
            chkCucumber.Enabled = False

        End If
    End Sub

    Private Sub chkCarrots_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarrots.CheckedChanged
        If chkCarrots.Checked = True Then
            txtCarrots.Enabled = True
            txtCarrots.Text = ""
            txtCarrots.Focus()
        End If
        If chkCarrots.Checked = False Then
            txtCarrots.Enabled = False
            txtCarrots.Text = "0"
            chkCarrots.Enabled = False

        End If
    End Sub

    Private Sub chkCelery_CheckedChanged(sender As Object, e As EventArgs) Handles chkCelery.CheckedChanged
        If chkCelery.Checked = True Then
            txtCelery.Enabled = True
            txtCelery.Text = ""
            txtCelery.Focus()
        End If
        If chkCelery.Checked = False Then
            txtCelery.Enabled = False
            txtCelery.Text = "0"
            chkCelery.Enabled = False

        End If
    End Sub

    Private Sub chkOnions_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnions.CheckedChanged
        If chkOnions.Checked = True Then
            txtOnions.Enabled = True
            txtOnions.Text = ""
            txtOnions.Focus()
        End If
        If chkOnions.Checked = False Then
            txtOnions.Enabled = False
            txtOnions.Text = "0"
            chkOnions.Enabled = False

        End If
    End Sub

    Private Sub chkSpringOnion_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpringOnion.CheckedChanged
        If chkSpringOnion.Checked = True Then
            txtSpringOnion.Enabled = True
            txtSpringOnion.Text = ""
            txtSpringOnion.Focus()
        End If
        If chkSpringOnion.Checked = False Then
            txtSpringOnion.Enabled = False
            txtSpringOnion.Text = "0"
            chkSpringOnion.Enabled = False

        End If
    End Sub

    Private Sub chkMilk_CheckedChanged(sender As Object, e As EventArgs) Handles chkMilk.CheckedChanged
        If chkMilk.Checked = True Then
            txtMilk.Enabled = True
            txtMilk.Text = ""
            txtMilk.Focus()
        End If
        If chkMilk.Checked = False Then
            txtMilk.Enabled = False
            txtMilk.Text = "0"
            chkMilk.Enabled = False

        End If
    End Sub

    Private Sub chkMeatBalls_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeatBalls.CheckedChanged
        If chkMeatBalls.Checked = True Then
            txtMeatBalls.Enabled = True
            txtMeatBalls.Text = ""
            txtMeatBalls.Focus()
        End If
        If chkMeatBalls.Checked = False Then
            txtMeatBalls.Enabled = False
            txtMeatBalls.Text = "0"
            chkMeatBalls.Enabled = False

        End If
    End Sub

    Private Sub chkMeat_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeat.CheckedChanged
        If chkMeat.Checked = True Then
            txtMeats.Enabled = True
            txtMeats.Text = ""
            txtMeats.Focus()
        End If
        If chkMeat.Checked = False Then
            txtMeats.Enabled = False
            txtMeats.Text = "0"
            chkMeat.Enabled = False

        End If
    End Sub

    Private Sub chkBacon_CheckedChanged(sender As Object, e As EventArgs) Handles chkBacon.CheckedChanged
        If chkBacon.Checked = True Then
            txtBacons.Enabled = True
            txtBacons.Text = ""
            txtBacons.Focus()
        End If
        If chkBacon.Checked = False Then
            txtBacons.Enabled = False
            txtBacons.Text = "0"
            chkBacon.Enabled = False

        End If
    End Sub

    Private Sub chkSmokes_CheckedChanged(sender As Object, e As EventArgs) Handles chkSmokes.CheckedChanged
        If chkSmokes.Checked = True Then
            txtSmokes.Enabled = True
            txtSmokes.Text = ""
            txtSmokes.Focus()
        End If
        If chkSmokes.Checked = False Then
            txtSmokes.Enabled = False
            txtSmokes.Text = "0"
            chkSmokes.Enabled = False

        End If
    End Sub

    Private Sub chkSmokedFish_CheckedChanged(sender As Object, e As EventArgs) Handles chkSmokedFish.CheckedChanged
        If chkSmokedFish.Checked = True Then
            txtSmokesFish.Enabled = True
            txtSmokesFish.Text = ""
            txtSmokesFish.Focus()
        End If
        If chkSmokedFish.Checked = False Then
            txtSmokesFish.Enabled = False
            txtSmokesFish.Text = "0"
            chkSmokedFish.Enabled = False

        End If
    End Sub

    Private Sub chkFish_CheckedChanged(sender As Object, e As EventArgs) Handles chkFish.CheckedChanged
        If chkFish.Checked = True Then
            txtFish.Enabled = True
            txtFish.Text = ""
            txtFish.Focus()
        End If
        If chkFish.Checked = False Then
            txtFish.Enabled = False
            txtFish.Text = "0"
            chkFish.Enabled = False

        End If
    End Sub

    Private Sub chkRice_CheckedChanged(sender As Object, e As EventArgs) Handles chkRice.CheckedChanged
        If chkRice.Checked = True Then
            txtRice.Enabled = True
            txtRice.Text = ""
            txtRice.Focus()
        End If
        If chkRice.Checked = False Then
            txtRice.Enabled = False
            txtRice.Text = "0"
            chkRice.Enabled = False

        End If
    End Sub

    Private Sub chkBeans_CheckedChanged(sender As Object, e As EventArgs) Handles chkBeans.CheckedChanged
        If chkBeans.Checked = True Then
            txtBeans.Enabled = True
            txtBeans.Text = ""
            txtBeans.Focus()
        End If
        If chkBeans.Checked = False Then
            txtBeans.Enabled = False
            txtBeans.Text = "0"
            chkBeans.Enabled = False

        End If
    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheese.CheckedChanged
        If chkCheese.Checked = True Then
            txtCheese.Enabled = True
            txtCheese.Text = ""
            txtCheese.Focus()
        End If
        If chkCheese.Checked = False Then
            txtCheese.Enabled = False
            txtCheese.Text = "0"
            chkCheese.Enabled = False

        End If
    End Sub

    Private Sub chkVodka_CheckedChanged(sender As Object, e As EventArgs) Handles chkVodka.CheckedChanged
        If chkVodka.Checked = True Then
            txtVodka.Enabled = True
            txtVodka.Text = ""
            txtVodka.Focus()
        End If
        If chkVodka.Checked = False Then
            txtVodka.Enabled = False
            txtVodka.Text = "0"
            chkVodka.Enabled = False

        End If
    End Sub

    Private Sub chkWine_CheckedChanged(sender As Object, e As EventArgs) Handles chkWine.CheckedChanged
        If chkWine.Checked = True Then
            txtWine.Enabled = True
            txtWine.Text = ""
            txtWine.Focus()
        End If
        If chkWine.Checked = False Then
            txtWine.Enabled = False
            txtWine.Text = "0"
            chkWine.Enabled = False

        End If
    End Sub

    Private Sub chkWhiskey_CheckedChanged(sender As Object, e As EventArgs) Handles chkWhiskey.CheckedChanged
        If chkWhiskey.Checked = True Then
            txtWhiskey.Enabled = True
            txtWhiskey.Text = ""
            txtWhiskey.Focus()
        End If
        If chkWhiskey.Checked = False Then
            txtWhiskey.Enabled = False
            txtWhiskey.Text = "0"
            chkWhiskey.Enabled = False

        End If
    End Sub

    Private Sub chkRum_CheckedChanged(sender As Object, e As EventArgs) Handles chkRum.CheckedChanged
        If chkRum.Checked = True Then
            txtRum.Enabled = True
            txtRum.Text = ""
            txtRum.Focus()
        End If
        If chkRum.Checked = False Then
            txtRum.Enabled = False
            txtRum.Text = "0"
            chkRum.Enabled = False

        End If
    End Sub

    Private Sub chkGin_CheckedChanged(sender As Object, e As EventArgs) Handles chkGin.CheckedChanged
        If chkGin.Checked = True Then
            txtGin.Enabled = True
            txtGin.Text = ""
            txtGin.Focus()
        End If
        If chkGin.Checked = False Then
            txtGin.Enabled = False
            txtGin.Text = "0"
            chkGin.Enabled = False

        End If
    End Sub

    Private Sub txtOrange_TextChanged(sender As Object, e As EventArgs) Handles txtOrange.TextChanged
        If chkOrange.Checked = True And txtOrange.Text = "0" Then
            chkOrange.Checked = False
            chkOrange.Enabled = False
        End If

    End Sub

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub Enter_Value(sender As Object, e As EventArgs) Handles MyBase.MouseHover, GroupBox4.MouseHover, GroupBox3.MouseHover, GroupBox2.MouseHover, GroupBox1.MouseHover, Me.MouseHover
        For Each t In {txtWine, txtWhiskey, txtVodka, txtTomatoe, txtSpringOnion, txtSmokesFish, txtSmokes, txtRum, txtRice, txtOrange, txtOnions, txtMushroom,
         txtMilk, txtMeats, txtMeatBalls, txtLettuce, txtGrapes, txtGin, txtFish, txtCucumber, txtCheese, txtCelery, txtCarrots, txtBroccoli, txtBeansprouts,
         txtBeans, txtBacons, txtApple}

            If t.Text = "" Then


                t.Text = "0"
                t.Enabled = False
            End If
        Next
    End Sub

    Private Sub txtBroccoli_TextChanged(sender As Object, e As EventArgs) Handles txtBroccoli.TextChanged
        If chkBroccoli.Checked = True And txtBroccoli.Text = "0" Then
            chkBroccoli.Checked = False
            chkBroccoli.Enabled = False
        End If

    End Sub

    Private Sub txtTomatoe_TextChanged(sender As Object, e As EventArgs) Handles txtTomatoe.TextChanged
        If chkTomatoe.Checked = True And txtTomatoe.Text = "0" Then
            chkTomatoe.Checked = False
            chkTomatoe.Enabled = False
        End If

    End Sub

    Private Sub txtMushroom_TextChanged(sender As Object, e As EventArgs) Handles txtMushroom.TextChanged
        If chkMushroom.Checked = True And txtMushroom.Text = "0" Then
            chkMushroom.Checked = False
            chkMushroom.Enabled = False
        End If

    End Sub

    Private Sub txtBeansprouts_TextChanged(sender As Object, e As EventArgs) Handles txtBeansprouts.TextChanged
        If chkBeansprouts.Checked = True And txtBeansprouts.Text = "0" Then
            chkBeansprouts.Checked = False
            chkBeansprouts.Enabled = False
        End If

    End Sub

    Private Sub txtLettuce_TextChanged(sender As Object, e As EventArgs) Handles txtLettuce.TextChanged
        If chkLettuce.Checked = True And txtLettuce.Text = "0" Then
            chkLettuce.Checked = False
            chkLettuce.Enabled = False
        End If

    End Sub

    Private Sub txtGrapes_TextChanged(sender As Object, e As EventArgs) Handles txtGrapes.TextChanged
        If chkGrapes.Checked = True And txtGrapes.Text = "0" Then
            chkGrapes.Checked = False
            chkGrapes.Enabled = False
        End If

    End Sub

    Private Sub txtCucumber_TextChanged(sender As Object, e As EventArgs) Handles txtCucumber.TextChanged
        If chkCucumber.Checked = True And txtCucumber.Text = "0" Then
            chkCucumber.Checked = False
            chkCucumber.Enabled = False
        End If

    End Sub

    Private Sub txtCarrots_TextChanged(sender As Object, e As EventArgs) Handles txtCarrots.TextChanged
        If chkCarrots.Checked = True And txtCarrots.Text = "0" Then
            chkCarrots.Checked = False
            chkCarrots.Enabled = False
        End If

    End Sub

    Private Sub txtCelery_TextChanged(sender As Object, e As EventArgs) Handles txtCelery.TextChanged
        If chkCelery.Checked = True And txtCelery.Text = "0" Then
            chkCelery.Checked = False
            chkCelery.Enabled = False
        End If

    End Sub

    Private Sub txtOnions_TextChanged(sender As Object, e As EventArgs) Handles txtOnions.TextChanged
        If chkOnions.Checked = True And txtOnions.Text = "0" Then
            chkOnions.Checked = False
            chkOnions.Enabled = False
        End If

    End Sub

    Private Sub txtSpringOnion_TextChanged(sender As Object, e As EventArgs) Handles txtSpringOnion.TextChanged
        If chkSpringOnion.Checked = True And txtSpringOnion.Text = "0" Then
            chkSpringOnion.Checked = False
            chkSpringOnion.Enabled = False
        End If

    End Sub

    Private Sub txtMilk_TextChanged(sender As Object, e As EventArgs) Handles txtMilk.TextChanged
        If chkApple.Checked = True And txtMilk.Text = "0" Then
            chkMilk.Checked = False
            chkMilk.Enabled = False
        End If

    End Sub

    Private Sub txtMeatBalls_TextChanged(sender As Object, e As EventArgs) Handles txtMeatBalls.TextChanged
        If chkMeatBalls.Checked = True And txtMeatBalls.Text = "0" Then
            chkMeatBalls.Checked = False
            chkMeatBalls.Enabled = False
        End If

    End Sub

    Private Sub txtMeats_TextChanged(sender As Object, e As EventArgs) Handles txtMeats.TextChanged
        If chkMeat.Checked = True And txtMeats.Text = "0" Then
            chkMeat.Checked = False
            chkMeat.Enabled = False
        End If

    End Sub

    Private Sub txtBacons_TextChanged(sender As Object, e As EventArgs) Handles txtBacons.TextChanged
        If chkBacon.Checked = True And txtBacons.Text = "0" Then
            chkBacon.Checked = False
            chkBacon.Enabled = False
        End If

    End Sub

    Private Sub txtSmokes_TextChanged(sender As Object, e As EventArgs) Handles txtSmokes.TextChanged
        If chkSmokes.Checked = True And txtSmokes.Text = "0" Then
            chkSmokes.Checked = False
            chkSmokes.Enabled = False
        End If

    End Sub

    Private Sub txtSmokesFish_TextChanged(sender As Object, e As EventArgs) Handles txtSmokesFish.TextChanged
        If chkSmokedFish.Checked = True And txtSmokesFish.Text = "0" Then
            chkSmokedFish.Checked = False
            chkSmokedFish.Enabled = False
        End If

    End Sub

    Private Sub txtFish_TextChanged(sender As Object, e As EventArgs) Handles txtFish.TextChanged
        If chkFish.Checked = True And txtFish.Text = "0" Then
            chkFish.Checked = False
            chkFish.Enabled = False
        End If

    End Sub

    Private Sub txtRice_TextChanged(sender As Object, e As EventArgs) Handles txtRice.TextChanged
        If chkRice.Checked = True And txtRice.Text = "0" Then
            chkRice.Checked = False
            chkRice.Enabled = False
        End If

    End Sub

    Private Sub txtBeans_TextChanged(sender As Object, e As EventArgs) Handles txtBeans.TextChanged
        If chkBeans.Checked = True And txtBeans.Text = "0" Then
            chkBeans.Checked = False
            chkBeans.Enabled = False
        End If

    End Sub

    Private Sub txtCheese_TextChanged(sender As Object, e As EventArgs) Handles txtCheese.TextChanged
        If chkCheese.Checked = True And txtCheese.Text = "0" Then
            chkCheese.Checked = False
            chkCheese.Enabled = False
        End If

    End Sub

    Private Sub txtVodka_TextChanged(sender As Object, e As EventArgs) Handles txtVodka.TextChanged
        If chkVodka.Checked = True And txtVodka.Text = "0" Then
            chkVodka.Checked = False
            chkVodka.Enabled = False
        End If

    End Sub

    Private Sub txtWine_TextChanged(sender As Object, e As EventArgs) Handles txtWine.TextChanged
        If chkWine.Checked = True And txtWine.Text = "0" Then
            chkWine.Checked = False
            chkWine.Enabled = False
        End If

    End Sub

    Private Sub txtWhiskey_TextChanged(sender As Object, e As EventArgs) Handles txtWhiskey.TextChanged
        If chkWhiskey.Checked = True And txtWhiskey.Text = "0" Then
            chkWhiskey.Checked = False
            chkWhiskey.Enabled = False
        End If

    End Sub

    Private Sub txtRum_TextChanged(sender As Object, e As EventArgs) Handles txtRum.TextChanged
        If chkRum.Checked = True And txtRum.Text = "0" Then
            chkRum.Checked = False
            chkRum.Enabled = False
        End If

    End Sub

    Private Sub txtGin_TextChanged(sender As Object, e As EventArgs) Handles txtGin.TextChanged
        If chkGin.Checked = True And txtGin.Text = "0" Then
            chkGin.Checked = False
            chkGin.Enabled = False
        End If

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        itemcost(0) = Convert.ToDecimal(txtApple.Text) * 1.5
        itemcost(29) = Convert.ToDecimal(itemcost(0))

        itemcost(1) = Convert.ToDecimal(txtOrange.Text) * 1.52
        itemcost(30) = Convert.ToDecimal(itemcost(1))

        itemcost(2) = Convert.ToDecimal(txtBroccoli.Text) * 2.3
        itemcost(31) = Convert.ToDecimal(itemcost(2))

        itemcost(3) = Convert.ToDecimal(txtTomatoe.Text) * 1.2
        itemcost(32) = Convert.ToDecimal(itemcost(3))

        itemcost(4) = Convert.ToDecimal(txtMushroom.Text) * 1
        itemcost(33) = Convert.ToDecimal(itemcost(4))

        itemcost(5) = Convert.ToDecimal(txtBeansprouts.Text) * 2.7
        itemcost(34) = Convert.ToDecimal(itemcost(5))

        itemcost(6) = Convert.ToDecimal(txtLettuce.Text) * 1.3
        itemcost(35) = Convert.ToDecimal(itemcost(6))

        itemcost(7) = Convert.ToDecimal(txtGrapes.Text) * 1.5
        itemcost(36) = Convert.ToDecimal(itemcost(7))

        itemcost(8) = Convert.ToDecimal(txtCucumber.Text) * 1.66
        itemcost(37) = Convert.ToDecimal(itemcost(8))

        itemcost(9) = Convert.ToDecimal(txtCarrots.Text) * 2.9
        itemcost(38) = Convert.ToDecimal(itemcost(9))

        itemcost(10) = Convert.ToDecimal(txtCelery.Text) * 2.1
        itemcost(39) = Convert.ToDecimal(itemcost(10))

        itemcost(11) = Convert.ToDecimal(txtOnions.Text) * 1.5
        itemcost(40) = Convert.ToDecimal(itemcost(11))

        itemcost(12) = Convert.ToDecimal(txtSpringOnion.Text) * 1.52
        itemcost(41) = Convert.ToDecimal(itemcost(12))

        itemcost(13) = Convert.ToDecimal(txtMilk.Text) * 3
        itemcost(42) = Convert.ToDecimal(itemcost(13))

        itemcost(14) = Convert.ToDecimal(txtMeatBalls.Text) * 4.4
        itemcost(43) = Convert.ToDecimal(itemcost(14))

        itemcost(15) = Convert.ToDecimal(txtMeats.Text) * 5.1
        itemcost(44) = Convert.ToDecimal(itemcost(15))

        itemcost(16) = Convert.ToDecimal(txtBacons.Text) * 3
        itemcost(45) = Convert.ToDecimal(itemcost(16))

        itemcost(17) = Convert.ToDecimal(txtSmokes.Text) * 7
        itemcost(46) = Convert.ToDecimal(itemcost(17))

        itemcost(18) = Convert.ToDecimal(txtSmokesFish.Text) * 8.9
        itemcost(47) = Convert.ToDecimal(itemcost(18))

        itemcost(19) = Convert.ToDecimal(txtFish.Text) * 7.1
        itemcost(48) = Convert.ToDecimal(itemcost(19))

        itemcost(20) = Convert.ToDecimal(txtRice.Text) * 3.1
        itemcost(49) = Convert.ToDecimal(itemcost(20))

        itemcost(21) = Convert.ToDecimal(txtBeans.Text) * 1.72
        itemcost(50) = Convert.ToDecimal(itemcost(21))

        itemcost(22) = Convert.ToDecimal(txtCheese.Text) * 4.2
        itemcost(51) = Convert.ToDecimal(itemcost(22))

        itemcost(23) = Convert.ToDecimal(txtVodka.Text) * 12.3
        itemcost(52) = Convert.ToDecimal(itemcost(23))

        itemcost(24) = Convert.ToDecimal(txtWine.Text) * 16.1
        itemcost(53) = Convert.ToDecimal(itemcost(24))

        itemcost(25) = Convert.ToDecimal(txtWhiskey.Text) * 25.3
        itemcost(54) = Convert.ToDecimal(itemcost(25))

        itemcost(26) = Convert.ToDecimal(txtRum.Text) * 3.1
        itemcost(55) = Convert.ToDecimal(itemcost(26))

        itemcost(27) = Convert.ToDecimal(txtGin.Text) * 5.2
        itemcost(56) = Convert.ToDecimal(itemcost(27))



        itemcost(28) = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) + itemcost(7) +
                        itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12) + itemcost(13) +
                         itemcost(14) + itemcost(15) + itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) + itemcost(20) + itemcost(21) +
                        itemcost(22) + itemcost(23) + itemcost(24) + itemcost(25) + itemcost(26) + itemcost(27)




        iTax = cFinalTax(itemcost(28))
        lblSubTotal.Text = itemcost(28)
        lblSubTotal.Text = FormatCurrency(lblSubTotal.Text)
        lblTax.Text = FormatCurrency(iTax)
        lblTotal.Text = FormatCurrency(iTax + itemcost(28))

        rtbReceipt.AppendText(vbTab + vbTab + vbTab + "   Hani's Food" + vbNewLine)
        rtbReceipt.AppendText(vbTab + vbTab + vbTab + "Hamrah Street" + vbNewLine)
        rtbReceipt.AppendText(vbTab + vbTab + "   Lebanon - Beirut City" + vbNewLine + vbNewLine)
        rtbReceipt.AppendText("------------------------------------------------------------" + vbNewLine)

        rtbReceipt.AppendText("Items" + vbTab + vbTab + vbTab + vbTab + "Cost" + vbTab + vbTab + "Quantity" + vbNewLine)
        rtbReceipt.AppendText("------------------------------------------------------------" + vbNewLine)

        If txtApple.Text <> "0" Then
            rtbReceipt.AppendText("Apple" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(29)) + vbTab + vbTab + vbTab + txtApple.Text + vbNewLine)
        End If

        If txtOrange.Text <> "0" Then
            rtbReceipt.AppendText("Orange" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(30)) + vbTab + vbTab + vbTab + txtOrange.Text + vbNewLine)
        End If

        If txtBroccoli.Text <> "0" Then
            rtbReceipt.AppendText("Broccoli" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(31)) + vbTab + vbTab + vbTab + txtBroccoli.Text + vbNewLine)
        End If

        If txtTomatoe.Text <> "0" Then
            rtbReceipt.AppendText("Tomatoe" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(32)) + vbTab + vbTab + vbTab + txtTomatoe.Text + vbNewLine)
        End If

        If txtMushroom.Text <> "0" Then
            rtbReceipt.AppendText("MushRoom" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(33)) + vbTab + vbTab + vbTab + txtMushroom.Text + vbNewLine)
        End If

        If txtBeansprouts.Text <> "0" Then
            rtbReceipt.AppendText("Beansprout" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(34)) + vbTab + vbTab + vbTab + txtBeansprouts.Text + vbNewLine)
        End If

        If txtLettuce.Text <> "0" Then
            rtbReceipt.AppendText("Lettuce" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(35)) + vbTab + vbTab + vbTab + txtLettuce.Text + vbNewLine)
        End If

        If txtGrapes.Text <> "0" Then
            rtbReceipt.AppendText("Grapes" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(36)) + vbTab + vbTab + vbTab + txtGrapes.Text + vbNewLine)
        End If

        If txtCucumber.Text <> "0" Then
            rtbReceipt.AppendText("Cucumber" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(37)) + vbTab + vbTab + vbTab + txtCucumber.Text + vbNewLine)
        End If

        If txtCarrots.Text <> "0" Then
            rtbReceipt.AppendText("Carrots" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(38)) + vbTab + vbTab + vbTab + txtCarrots.Text + vbNewLine)
        End If

        If txtCelery.Text <> "0" Then
            rtbReceipt.AppendText("Celery" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(39)) + vbTab + vbTab + vbTab + txtCelery.Text + vbNewLine)
        End If

        If txtOnions.Text <> "0" Then
            rtbReceipt.AppendText("Onions" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(40)) + vbTab + vbTab + vbTab + txtOnions.Text + vbNewLine)
        End If

        If txtSpringOnion.Text <> "0" Then
            rtbReceipt.AppendText("SpringOnion" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(41)) + vbTab + vbTab + vbTab + txtSpringOnion.Text + vbNewLine)
        End If

        If txtMilk.Text <> "0" Then
            rtbReceipt.AppendText("Milk" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(42)) + vbTab + vbTab + vbTab + txtMilk.Text + vbNewLine)
        End If

        If txtMeatBalls.Text <> "0" Then
            rtbReceipt.AppendText("MeatBalls" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(43)) + vbTab + vbTab + vbTab + txtMeatBalls.Text + vbNewLine)
        End If

        If txtMeats.Text <> "0" Then
            rtbReceipt.AppendText("Meats" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(44)) + vbTab + vbTab + vbTab + txtMeats.Text + vbNewLine)
        End If

        If txtBacons.Text <> "0" Then
            rtbReceipt.AppendText("Bacons" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(45)) + vbTab + vbTab + vbTab + txtBacons.Text + vbNewLine)
        End If

        If txtSmokes.Text <> "0" Then
            rtbReceipt.AppendText("Smokes" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(46)) + vbTab + vbTab + vbTab + txtSmokes.Text + vbNewLine)
        End If

        If txtSmokesFish.Text <> "0" Then
            rtbReceipt.AppendText("SmokesFish" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(47)) + vbTab + vbTab + vbTab + txtSmokesFish.Text + vbNewLine)
        End If

        If txtFish.Text <> "0" Then
            rtbReceipt.AppendText("Fish" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(48)) + vbTab + vbTab + vbTab + txtFish.Text + vbNewLine)
        End If

        If txtRice.Text <> "0" Then
            rtbReceipt.AppendText("Rice" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(49)) + vbTab + vbTab + vbTab + txtRice.Text + vbNewLine)
        End If

        If txtBeans.Text <> "0" Then
            rtbReceipt.AppendText("Beans" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(50)) + vbTab + vbTab + vbTab + txtBeans.Text + vbNewLine)
        End If

        If txtCheese.Text <> "0" Then
            rtbReceipt.AppendText("Cheese" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(51)) + vbTab + vbTab + vbTab + txtCheese.Text + vbNewLine)
        End If

        If txtVodka.Text <> "0" Then
            rtbReceipt.AppendText("Vodka" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(52)) + vbTab + vbTab + txtVodka.Text + vbNewLine)
        End If

        If txtWine.Text <> "0" Then
            rtbReceipt.AppendText("Wine" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(53)) + vbTab + vbTab + txtWine.Text + vbNewLine)
        End If

        If txtWhiskey.Text <> "0" Then
            rtbReceipt.AppendText("Whiskey" + vbTab + vbTab + vbTab + FormatCurrency(itemcost(54)) + vbTab + vbTab + txtWhiskey.Text + vbNewLine)
        End If

        If txtRum.Text <> "0" Then
            rtbReceipt.AppendText("Rum" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(55)) + vbTab + vbTab + vbTab + txtRum.Text + vbNewLine)
        End If

        If txtGin.Text <> "0" Then
            rtbReceipt.AppendText("Gin" + vbTab + vbTab + vbTab + vbTab + FormatCurrency(itemcost(56)) + vbTab + vbTab + vbTab + txtGin.Text + vbNewLine)
        End If













        rtbReceipt.AppendText("====================================" + vbNewLine)
        rtbReceipt.AppendText("SubTotal" + vbTab + vbTab + vbTab + lblSubTotal.Text + vbNewLine)
        rtbReceipt.AppendText("Tax" + vbTab + vbTab + vbTab + vbTab + lblTax.Text + vbNewLine)
        rtbReceipt.AppendText("Total" + vbTab + vbTab + vbTab + vbTab + lblTotal.Text + vbNewLine)
        rtbReceipt.AppendText("====================================" + vbNewLine)
        rtbReceipt.AppendText(vbTab + vbTab + "Thank For Shopping at iFood" + vbNewLine)

        Dim suma As Integer = 0
        Dim pricea As Double = 0.0
        Dim sumo As Integer = 0
        Dim priceo As Double = 0.0
        Dim sumb As Integer = 0
        Dim priceb As Double = 0.0
        Dim sumt As Integer = 0
        Dim pricet As Double = 0.0
        Dim summ As Integer = 0
        Dim pricem As Double = 0.0
        Dim sumbean As Integer = 0
        Dim pricebean As Double = 0.0
        Dim suml As Integer = 0
        Dim pricel As Double = 0.0
        Dim sumg As Integer = 0
        Dim priceg As Double = 0.0
        Dim sumc As Integer = 0
        Dim pricec As Double = 0.0
        Dim sumcro As Integer = 0
        Dim pricecro As Double = 0.0
        Dim sumcele As Integer = 0
        Dim pricecele As Double = 0.0
        Dim sumon As Integer = 0
        Dim priceon As Double = 0.0
        Dim sumspring As Integer = 0
        Dim pricespring As Double = 0.0
        Dim summlk As Integer = 0
        Dim pricemlk As Double = 0.0

        Dim summb As Integer = 0
        Dim pricemb As Double = 0.0
        Dim summeatball As Integer = 0
        Dim pricemeatball As Double = 0.0

        Dim summeat As Integer = 0
        Dim pricemeat As Double = 0.0
        Dim sumbacn As Integer = 0
        Dim pricebacn As Double = 0.0
        Dim sumsmoks As Integer = 0
        Dim pricesmoks As Double = 0.0
        Dim sumsmkfish As Integer = 0
        Dim pricesmkfish As Double = 0.0
        Dim sumfish As Integer = 0
        Dim pricefish As Double = 0.0

        Dim sumrice As Integer = 0
        Dim pricerice As Double = 0.0

        Dim sumbeans As Integer = 0
        Dim pricebeans As Double = 0.0

        Dim sumcheese As Integer = 0
        Dim pricecheese As Double = 0.0

        Dim sumvodka As Integer = 0
        Dim pricevodka As Double = 0.0

        Dim sumwine As Integer = 0
        Dim pricewine As Double = 0.0

        Dim sumwhiskey As Integer = 0
        Dim pricewhiskey As Double = 0.0

        Dim sumrum As Integer = 0
        Dim pricerum As Double = 0.0

        Dim sumgin As Integer = 0
        Dim pricegin As Double = 0.0

        Dim apple As Integer = Convert.ToDecimal(Items.txtapple.Text)
        Dim orange As Integer = Convert.ToDecimal(Items.txtorange.Text)
        Dim broccoli As Integer = Convert.ToDecimal(Items.txtbroccoli.Text)

        Dim tomatoee As Integer = Convert.ToDecimal(Items.txttomateo.Text)
        Dim mushroomm As Integer = Convert.ToDecimal(Items.txtmushroom.Text)
        Dim beansproutss As Integer = Convert.ToDecimal(Items.txtbeansprout.Text)

        Dim lettuce As Integer = Convert.ToDecimal(Items.txtlettuce.Text)
        Dim grapse As Integer = Convert.ToDecimal(Items.txtgrapse.Text)
        Dim cucumbers As Integer = Convert.ToDecimal(Items.txtcucumber.Text)
        Dim carrots As Integer = Convert.ToDecimal(Items.txtcarrots.Text)


        Dim celery As Integer = Convert.ToDecimal(Items.txtcelery.Text)
        Dim onions As Integer = Convert.ToDecimal(Items.txtonions.Text)
        Dim springonion As Integer = Convert.ToDecimal(Items.txtspring.Text)
        Dim milk As Integer = Convert.ToDecimal(Items.txtmilk.Text)

        Dim meatball As Integer = Convert.ToDecimal(Items.txtmeatball.Text)
        Dim meat As Integer = Convert.ToDecimal(Items.txtmeat.Text)
        Dim bacon As Integer = Convert.ToDecimal(Items.txtbacon.Text)
        Dim smokes As Integer = Convert.ToDecimal(Items.txtsmokes.Text)
        Dim smokedfish As Integer = Convert.ToDecimal(Items.txtsmokedfish.Text)
        Dim fish As Integer = Convert.ToDecimal(Items.txtfish.Text)


        Dim rice As Integer = Convert.ToDecimal(Items.txtrice.Text)
        Dim beans As Integer = Convert.ToDecimal(Items.txtbeans.Text)
        Dim cheese As Integer = Convert.ToDecimal(Items.txtcheese.Text)
        Dim vodka As Integer = Convert.ToDecimal(Items.txtvodka.Text)
        Dim wine As Integer = Convert.ToDecimal(Items.txtwine.Text)
        Dim whiskey As Integer = Convert.ToDecimal(Items.txtwhiskey.Text)
        Dim rum As Integer = Convert.ToDecimal(Items.txtrum.Text)
        Dim gin As Integer = Convert.ToDecimal(Items.txtgin.Text)
        If txtApple.Text <> "0" Then

            suma += Convert.ToDecimal(txtApple.Text) + apple

            Items.txtapple.Text = suma


            pricea += Convert.ToDecimal(Items.txtapple.Text) * 1.5
            Items.txtPriceA.Text = pricea



        End If

        If txtOrange.Text <> "0" Then
            sumo += Convert.ToDecimal(txtOrange.Text) + orange

            Items.txtorange.Text = sumo

            priceo += Convert.ToDecimal(Items.txtorange.Text) * 1.52
            Items.txtPriceO.Text = priceo


        End If

        If txtBroccoli.Text <> "0" Then
            sumb += Convert.ToDecimal(txtBroccoli.Text) + broccoli

            Items.txtbroccoli.Text = sumb

            priceb += Convert.ToDecimal(Items.txtbroccoli.Text) * 2.3
            Items.txtPriceB.Text = priceb

        End If

        If txtTomatoe.Text <> "0" Then

            sumt += Convert.ToDecimal(txtTomatoe.Text) + tomatoee

            Items.txttomateo.Text = sumt


            pricet += Convert.ToDecimal(Items.txttomateo.Text) * 1.2
            Items.txtPriceT.Text = pricet



        End If

        If txtMushroom.Text <> "0" Then

            summ += Convert.ToDecimal(txtMushroom.Text) + mushroomm

            Items.txtmushroom.Text = summ


            pricem += Convert.ToDecimal(Items.txtmushroom.Text) * 1
            Items.txtPriceM.Text = pricem



        End If

        If txtBeansprouts.Text <> "0" Then

            sumbean += Convert.ToDecimal(txtBeansprouts.Text) + beansproutss

            Items.txtbeansprout.Text = sumbean


            pricebean += Convert.ToDecimal(Items.txtbeansprout.Text) * 2.7
            Items.txtPriceBE.Text = pricebean

        End If


        If txtLettuce.Text <> "0" Then

            suml += Convert.ToDecimal(txtLettuce.Text) + lettuce

            Items.txtlettuce.Text = suml


            pricel += Convert.ToDecimal(Items.txtlettuce.Text) * 1.3
            Items.txtPriceL.Text = pricel
        End If

        If txtGrapes.Text <> "0" Then

            sumg += Convert.ToDecimal(txtGrapes.Text) + grapse

            Items.txtgrapse.Text = sumg


            priceg += Convert.ToDecimal(Items.txtgrapse.Text) * 1.5
            Items.txtPriceG.Text = priceg

        End If

        If txtCucumber.Text <> "0" Then

            sumc += Convert.ToDecimal(txtCucumber.Text) + cucumbers

            Items.txtcucumber.Text = sumc


            pricec += Convert.ToDecimal(Items.txtcucumber.Text) * 1.66
            Items.txtPriceC.Text = pricec
        End If
        If txtCarrots.Text <> "0" Then

            sumcro += Convert.ToDecimal(txtCarrots.Text) + carrots

            Items.txtcarrots.Text = sumcro


            pricecro += Convert.ToDecimal(Items.txtcarrots.Text) * 2.9
            Items.txtPriceCarrots.Text = pricecro
        End If


        If txtCelery.Text <> "0" Then

            sumcele += Convert.ToDecimal(txtCelery.Text) + celery

            Items.txtcelery.Text = sumcele


            pricecele += Convert.ToDecimal(Items.txtcelery.Text) * 2.1
            Items.txtPriceCele.Text = pricecele



        End If

        If txtOnions.Text <> "0" Then

            sumon += Convert.ToDecimal(txtOnions.Text) + onions

            Items.txtonions.Text = sumon


            priceon += Convert.ToDecimal(Items.txtonions.Text) * 1.5
            Items.txtPriceOnion.Text = priceon



        End If

        If txtSpringOnion.Text <> "0" Then

            sumspring += Convert.ToDecimal(txtSpringOnion.Text) + springonion

            Items.txtspring.Text = sumspring


            pricespring += Convert.ToDecimal(Items.txtspring.Text) * 1.52
            Items.txtPriceSpring.Text = pricespring



        End If

        If txtMilk.Text <> "0" Then

            summlk += Convert.ToDecimal(txtMilk.Text) + milk

            Items.txtmilk.Text = summlk


            pricemlk += Convert.ToDecimal(Items.txtmilk.Text) * 3
            Items.txtPriceMilk.Text = pricemlk

        End If


        If txtMeatBalls.Text <> "0" Then

            summeatball += Convert.ToDecimal(txtMeatBalls.Text) + meatball

            Items.txtmeatball.Text = summeatball


            pricemeatball += Convert.ToDecimal(Items.txtmeatball.Text) * 4.4
            Items.txtPriceMeatBall.Text = pricemeatball



        End If

        If txtMeats.Text <> "0" Then

            summeat += Convert.ToDecimal(txtMeats.Text) + meat

            Items.txtmeat.Text = summeat


            pricemeat += Convert.ToDecimal(Items.txtmeat.Text) * 5.1
            Items.txtPriceMeat.Text = pricemeat



        End If

        If txtBacons.Text <> "0" Then

            sumbacn += Convert.ToDecimal(txtBacons.Text) + bacon

            Items.txtbacon.Text = sumbacn


            pricebacn += Convert.ToDecimal(Items.txtbacon.Text) * 3
            Items.txtPriceBacon.Text = pricebacn



        End If

        If txtSmokes.Text <> "0" Then

            sumsmoks += Convert.ToDecimal(txtSmokes.Text) + smokes

            Items.txtsmokes.Text = sumsmoks


            pricesmoks += Convert.ToDecimal(Items.txtsmokes.Text) * 7
            Items.txtPriceSmokes.Text = pricesmoks



        End If

        If txtSmokesFish.Text <> "0" Then

            sumsmkfish += Convert.ToDecimal(txtSmokesFish.Text) + smokedfish

            Items.txtsmokedfish.Text = sumsmkfish


            pricesmkfish += Convert.ToDecimal(Items.txtsmokedfish.Text) * 8.9
            Items.txtPriceSmokedFish.Text = pricesmkfish



        End If

        If txtFish.Text <> "0" Then

            sumfish += Convert.ToDecimal(txtFish.Text) + fish

            Items.txtfish.Text = sumfish


            pricefish += Convert.ToDecimal(Items.txtfish.Text) * 7.1
            Items.txtPriceFish.Text = pricefish

        End If
        '''''''''''''''''''''''''''''''''''''''''''
        If txtRice.Text <> "0" Then

            sumrice += Convert.ToDecimal(txtRice.Text) + rice

            Items.txtrice.Text = sumrice


            pricerice += Convert.ToDecimal(Items.txtrice.Text) * 3.1
            Items.txtPriceRice.Text = pricerice



        End If
        If txtBeans.Text <> "0" Then

            sumbeans += Convert.ToDecimal(txtBeans.Text) + beans

            Items.txtbeans.Text = sumbeans


            pricebeans += Convert.ToDecimal(Items.txtbeans.Text) * 1.72
            Items.txtPriceBeans.Text = pricebeans



        End If
        If txtCheese.Text <> "0" Then

            sumcheese += Convert.ToDecimal(txtCheese.Text) + cheese

            Items.txtcheese.Text = sumcheese


            pricecheese += Convert.ToDecimal(Items.txtcheese.Text) * 4.2
            Items.txtPriceCheese.Text = pricecheese



        End If
        If txtVodka.Text <> "0" Then

            sumvodka += Convert.ToDecimal(txtVodka.Text) + vodka

            Items.txtvodka.Text = sumvodka


            pricevodka += Convert.ToDecimal(Items.txtvodka.Text) * 16.1
            Items.txtPriceVodka.Text = pricevodka



        End If
        If txtWine.Text <> "0" Then

            sumwine += Convert.ToDecimal(txtWine.Text) + wine

            Items.txtwine.Text = sumwine


            pricewine += Convert.ToDecimal(Items.txtwine.Text) * 12.3
            Items.txtPriceWine.Text = pricewine



        End If
        If txtWhiskey.Text <> "0" Then

            sumwhiskey += Convert.ToDecimal(txtWhiskey.Text) + whiskey

            Items.txtwhiskey.Text = sumwhiskey


            pricewhiskey += Convert.ToDecimal(Items.txtwhiskey.Text) * 25.3
            Items.txtPriceWhiskey.Text = pricewhiskey



        End If
        If txtRum.Text <> "0" Then

            sumrum += Convert.ToDecimal(txtRum.Text) + rum

            Items.txtrum.Text = sumrum


            pricerum += Convert.ToDecimal(Items.txtrum.Text) * 3.1
            Items.txtPriceRum.Text = pricerum



        End If
        If txtGin.Text <> "0" Then

            sumgin += Convert.ToDecimal(txtGin.Text) + gin

            Items.txtgin.Text = sumgin


            pricegin += Convert.ToDecimal(Items.txtgin.Text) * 5.2
            Items.txtPriceGin.Text = pricegin



        End If




        Dim Applename As String
        Dim AppleQ As Integer
        Dim AppleP As Double
        Dim Orangename As String
        Dim OrangeQ As Integer
        Dim OrangeP As Double
        Dim Broccoliname As String
        Dim BroccoliQ As Integer
        Dim BroccoliP As Double
        Dim Tomatoe As String
        Dim TomatoeQ As Integer
        Dim TomatoeP As Double
        Dim Mushroom As String
        Dim MushroomQ As Integer
        Dim MushroomP As Double
        Dim Beansprouts As String
        Dim BeansproutsQ As Integer
        Dim BeansproutsP As Double
        Dim Lettucename As String
        Dim LettuceQ As Integer
        Dim LettuceP As Double
        Dim Grapsename As String
        Dim GrapseQ As Integer
        Dim GrapseP As Double
        Dim Cucumbername As String
        Dim CucumberQ As Integer
        Dim CucumberP As Double
        Dim Carrotsname As String
        Dim CarrotsQ As Integer
        Dim CarrotsP As Double


        Dim Celeryname As String
        Dim CeleryQ As Integer
        Dim CeleryP As Double

        Dim Onionsname As String
        Dim OnionsQ As Integer
        Dim OnionsP As Double

        Dim SprinOnionname As String
        Dim SprinOnionQ As Integer
        Dim SprinOnionP As Double

        Dim Milkname As String
        Dim MilkQ As Integer
        Dim MilkP As Double

        Dim MeatBallname As String
        Dim MeatBallQ As Integer
        Dim MeatBallP As Double
        Dim Meatname As String
        Dim MeatQ As Integer
        Dim MeatP As Double
        Dim Baconname As String
        Dim BaconQ As Integer
        Dim BaconP As Double
        Dim Smokesname As String
        Dim SmokesQ As Integer
        Dim SmokesP As Double
        Dim SmokedFishname As String
        Dim SmokedFishQ As Integer
        Dim SmokedFishP As Double
        Dim Fishname As String
        Dim FishQ As Integer
        Dim FishP As Double
        '''''''''''''''''''''''''''''''''''

        Dim Ricename As String
        Dim RiceQ As Integer
        Dim RiceP As Double


        Dim Beansname As String
        Dim BeansQ As Integer
        Dim BeansP As Double


        Dim Cheesename As String
        Dim CheeseQ As Integer
        Dim CheeseP As Double


        Dim Vodkaname As String
        Dim VodkaQ As Integer
        Dim VodkaP As Double


        Dim Winename As String
        Dim WineQ As Integer
        Dim WineP As Double


        Dim Whiskeyname As String
        Dim WhiskeyQ As Integer
        Dim WhiskeyP As Double


        Dim Rumname As String
        Dim RumQ As Integer
        Dim RumP As Double


        Dim Ginname As String
        Dim GinQ As Integer
        Dim GinP As Double


        Applename = Items.txtapple1.Text
        AppleQ = Items.txtapple.Text
        AppleP = Items.txtPriceA.Text
        Orangename = Items.txtorange1.Text
        OrangeQ = Items.txtorange.Text
        OrangeP = Items.txtPriceO.Text
        Broccoliname = Items.txtbroccoli1.Text
        BroccoliQ = Items.txtbroccoli.Text
        BroccoliP = Items.txtPriceB.Text

        Tomatoe = Items.TextBox9.Text
        TomatoeQ = Items.txttomateo.Text
        TomatoeP = Items.txtPriceT.Text

        Mushroom = Items.TextBox8.Text
        MushroomQ = Items.txtmushroom.Text
        MushroomP = Items.txtPriceM.Text

        Beansprouts = Items.TextBox7.Text
        BeansproutsQ = Items.txtbeansprout.Text
        BeansproutsP = Items.txtPriceBE.Text

        Lettucename = Items.txtLettuce1.Text
        LettuceQ = Items.txtlettuce.Text
        LettuceP = Items.txtPriceL.Text

        Grapsename = Items.TextBox12.Text
        GrapseQ = Items.txtgrapse.Text
        GrapseP = Items.txtPriceG.Text

        Cucumbername = Items.TextBox11.Text
        CucumberQ = Items.txtcucumber.Text
        CucumberP = Items.txtPriceC.Text

        Carrotsname = Items.TextBox10.Text
        CarrotsQ = Items.txtcarrots.Text
        CarrotsP = Items.txtPriceCarrots.Text

        Celeryname = Items.TextBox18.Text
        CeleryQ = Items.txtcelery.Text
        CeleryP = Items.txtPriceCele.Text

        Onionsname = Items.TextBox15.Text
        OnionsQ = Items.txtonions.Text
        OnionsP = Items.txtPriceOnion.Text

        SprinOnionname = Items.TextBox14.Text
        SprinOnionQ = Items.txtspring.Text
        SprinOnionP = Items.txtPriceSpring.Text

        Milkname = Items.TextBox13.Text
        MilkQ = Items.txtmilk.Text
        MilkP = Items.txtPriceMilk.Text

        MeatBallname = Items.TextBox28.Text
        MeatBallQ = Items.txtmeatball.Text
        MeatBallP = Items.txtPriceMeatBall.Text

        Meatname = Items.TextBox27.Text
        MeatQ = Items.txtmeat.Text
        MeatP = Items.txtPriceMeat.Text

        Baconname = Items.TextBox26.Text
        BaconQ = Items.txtbacon.Text
        BaconP = Items.txtPriceBacon.Text

        Smokesname = Items.TextBox19.Text
        SmokesQ = Items.txtsmokes.Text
        SmokesP = Items.txtPriceSmokes.Text

        SmokedFishname = Items.TextBox17.Text
        SmokedFishQ = Items.txtsmokedfish.Text
        SmokedFishP = Items.txtPriceSmokedFish.Text

        Fishname = Items.TextBox16.Text
        FishQ = Items.txtfish.Text
        FishP = Items.txtPriceFish.Text
        '''''''''''''''''''''''''''''''''''''''''''''
        Ricename = Items.TextBox40.Text
        RiceQ = Items.txtrice.Text
        RiceP = Items.txtPriceRice.Text

        Beansname = Items.TextBox37.Text
        BeansQ = Items.txtbeans.Text
        BeansP = Items.txtPriceBeans.Text

        Cheesename = Items.TextBox36.Text
        CheeseQ = Items.txtcheese.Text
        CheeseP = Items.txtPriceCheese.Text

        Vodkaname = Items.TextBox35.Text
        VodkaQ = Items.txtvodka.Text
        VodkaP = Items.txtPriceVodka.Text

        Winename = Items.TextBox25.Text
        WineQ = Items.txtwine.Text
        WineP = Items.txtPriceWine.Text

        Whiskeyname = Items.TextBox22.Text
        WhiskeyQ = Items.txtwhiskey.Text
        WhiskeyP = Items.txtPriceWhiskey.Text

        Rumname = Items.TextBox21.Text
        RumQ = Items.txtrum.Text
        RumP = Items.txtPriceRum.Text

        Ginname = Items.TextBox20.Text
        GinQ = Items.txtgin.Text
        GinP = Items.txtPriceGin.Text


        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toshiba\Documents\Visual Studio 2015\PointSales_db.accdb"
        Dim conn = New OleDbConnection(dbsource)
        conn.Open()

        If txtApple.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Applename & "', '" & AppleQ & "', '" & AppleP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtOrange.Text <> "0" Then
            Dim querry2 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Orangename & "', '" & OrangeQ & "', '" & OrangeP & "')"
            Dim cmd1 As New OleDbCommand(querry2, conn)
            cmd1.ExecuteNonQuery()

        End If

        If txtBroccoli.Text <> "0" Then

            Dim querry3 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Broccoliname & "', '" & BroccoliQ & "', '" & BroccoliP & "')"
            Dim cmd2 As New OleDbCommand(querry3, conn)
            cmd2.ExecuteNonQuery()
        End If

        If txtTomatoe.Text <> "0" Then
            Dim querry4 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Tomatoe & "', '" & TomatoeQ & "', '" & TomatoeP & "')"
            Dim cmd3 As New OleDbCommand(querry4, conn)
            cmd3.ExecuteNonQuery()
        End If

        If txtMushroom.Text <> "0" Then
            Dim querry5 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Mushroom & "', '" & MushroomQ & "', '" & MushroomP & "')"
            Dim cmd4 As New OleDbCommand(querry5, conn)
            cmd4.ExecuteNonQuery()
        End If

        If txtBeansprouts.Text <> "0" Then
            Dim querry6 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Beansprouts & "', '" & BeansproutsQ & "', '" & BeansproutsP & "')"

            Dim cmd5 As New OleDbCommand(querry6, conn)
            cmd5.ExecuteNonQuery()
        End If

        If txtLettuce.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Lettucename & "', '" & LettuceQ & "', '" & LettuceP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtGrapes.Text <> "0" Then
            Dim querry2 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Grapsename & "', '" & GrapseQ & "', '" & GrapseP & "')"
            Dim cmd1 As New OleDbCommand(querry2, conn)
            cmd1.ExecuteNonQuery()

        End If

        If txtCucumber.Text <> "0" Then

            Dim querry3 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Cucumbername & "', '" & CucumberQ & "', '" & CucumberP & "')"
            Dim cmd2 As New OleDbCommand(querry3, conn)
            cmd2.ExecuteNonQuery()
        End If

        If txtCarrots.Text <> "0" Then
            Dim querry4 As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Carrotsname & "', '" & CarrotsQ & "', '" & CarrotsP & "')"
            Dim cmd3 As New OleDbCommand(querry4, conn)
            cmd3.ExecuteNonQuery()
        End If

        If txtOnions.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Onionsname & "', '" & OnionsQ & "', '" & OnionsP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtCelery.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Celeryname & "', '" & CeleryQ & "', '" & CeleryP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtSpringOnion.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & SprinOnionname & "', '" & SprinOnionQ & "', '" & SprinOnionP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtMilk.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Milkname & "', '" & MilkQ & "', '" & MilkP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        '''''''''''''''''''''''''''''''''''
        If txtMeatBalls.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & MeatBallname & "', '" & MeatBallQ & "', '" & MeatBallP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtMeats.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Meatname & "', '" & MeatQ & "', '" & MeatP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtBacons.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Baconname & "', '" & BaconQ & "', '" & BaconP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtSmokes.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Smokesname & "', '" & SmokesQ & "', '" & SmokesP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtSmokesFish.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & SmokedFishname & "', '" & SmokedFishQ & "', '" & SmokedFishP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        If txtFish.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Fishname & "', '" & FishQ & "', '" & FishP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If
        ''''''''''''''''''''''''''''''''''''''''''
        If txtRice.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Ricename & "', '" & RiceQ & "', '" & RiceP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtBeans.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Beansname & "', '" & BeansQ & "', '" & BeansP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtCheese.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Cheesename & "', '" & CheeseQ & "', '" & CheeseP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtWine.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Winename & "', '" & WineQ & "', '" & WineP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtVodka.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Vodkaname & "', '" & VodkaQ & "', '" & VodkaP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtWhiskey.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Whiskeyname & "', '" & WhiskeyQ & "', '" & WhiskeyP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtRum.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Rumname & "', '" & RumQ & "', '" & RumP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        If txtGin.Text <> "0" Then
            Dim querry As String = "INSERT INTO table2 (Item, Quantity, Price)
       VALUES('" & Ginname & "', '" & GinQ & "', '" & GinP & "')"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
        End If

        Dim SAPI
        SAPI = CreateObject("sapi.spvoice")
        SAPI.speak("total price")
        SAPI.speak(lblTotal.Text)
        SAPI.speak("Thanks for shopping at Hani's Food")

    End Sub



    Private Function cFinalTax(ByVal cAmount As Decimal) As Decimal
        cFinalTax = cAmount - (cAmount * mcTax_Rate)
    End Function

    Private Sub AdminLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminLoginToolStripMenuItem.Click
        Login.Show()
    End Sub
End Class


