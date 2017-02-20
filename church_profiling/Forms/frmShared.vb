Public Class frmShared

 

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim start_date As String = dtrFrom.Value.ToString("yyyy-MM-dd")
        Dim end_date As String = dtrTo.Value.ToString("yyyy-MM-dd")
        Dim o As New Offering
        o.displayOfferingListByDateRange(lsvlistofOffering, start_date, end_date)

        total()
    End Sub

    Private Sub total()
        Dim total As Double = 0

        For i = 0 To Me.lsvlistofOffering.Items.Count - 1
            total += Me.lsvlistofOffering.Items(i).SubItems(2).Text

        Next

        Me.lbltotalamount.Text = FormatNumber(total, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault).ToString
        Dim pastorshare As Double
        Dim district As Double
        Dim main_church As Double
        Dim local_church As Double
        Dim moderator As Double

        Dim amount As Double = lbltotalamount.Text
        pastorshare = amount * 0.6
        txtchurchpastor.Text = pastorshare.ToString("N")

        Dim d As Double = lbltotalamount.Text
        district = d * 0.1
        txtdistrict.Text = district.ToString("N")

        Dim mc As Double = lbltotalamount.Text
        main_church = mc * 0.1
        txtmainchurch.Text = main_church.ToString("N")

        Dim lc As Double = lbltotalamount.Text
        local_church = lc * 0.15
        txtlocalchurch.Text = local_church.ToString("N")

        Dim m As Double = lbltotalamount.Text
        moderator = m * 0.05
        txtmoderator.Text = moderator.ToString("N")
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim s As New Shares

        With s
            .Pastor_share = txtchurchpastor.Text
            .District = txtdistrict.Text
            .Main_church = txtmainchurch.Text
            .Local_church = Convert.ToDouble(txtlocalchurch.Text).ToString
            .Modereator = txtmoderator.Text
            .saveShares(dtrFrom.Value.ToString("yyyy-MM-dd"), dtrTo.Value.ToString("yyyy-MM-dd"))
        End With

    End Sub

    Private Sub frmShared_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class