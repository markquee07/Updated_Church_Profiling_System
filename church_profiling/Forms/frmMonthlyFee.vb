Public Class frmMonthlyFee

    Private m As New Monthly_fee
    Public savingMontly_Fee As New Collection

    Private bal As Double
    Private amount As Double
    Public change As Double


    Private Sub frmMonthlyFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With m
            .validateLesserMonth()
            If .lesser_month = "Error" Then

            Else
                .validateEqualMonth()
                If .validateMonth = "True" Then

                Else
                    Me.generate()
                End If
            End If
        End With
        btnPay.Visible = False
        txtAmount.Enabled = False
        m.displayMonthlyFeeDetails(lsvMonthlyFee)
    End Sub

    Private Sub generate()
        Dim all_members As New Collection
        Dim mon_fee As Double

        mon_fee = m.getMonthlyFee

        all_members = Monthly_fee.selectAllMember
        For Each member As Monthly_fee In all_members
            m.id = member.id
            m.monthly_fee = mon_fee
            m.saveMonthlyFeeInformation(m.id, m.monthly_fee)
        Next

    End Sub


    Private Sub cboMonth_DropDown(sender As Object, e As EventArgs) Handles cboMonth.DropDown
        m.addToMonthCombobox(cboMonth)
    End Sub

    Private Sub cboYear_DropDown(sender As Object, e As EventArgs) Handles cboYear.DropDown
        m.addToYearCombobox(cboYear)
    End Sub


    Private Sub lsvMonthlyFee_Click(sender As Object, e As EventArgs) Handles lsvMonthlyFee.Click
        Dim x As Integer = lsvMonthlyFee.Items.Count
        If x <= 0 Then
            btnPay.Visible = False
            txtAmount.Enabled = False
        Else
            If lsvMonthlyFee.SelectedItems(0).SubItems(5).Text = "UNPAID" Then
                btnPay.Visible = True
                txtAmount.Enabled = True

                lblMemberID.Text = lsvMonthlyFee.SelectedItems(0).SubItems(1).Text
                lblMemberName.Text = lsvMonthlyFee.SelectedItems(0).SubItems(2).Text
                lblDateBorrowed.Text = lsvMonthlyFee.SelectedItems(0).SubItems(6).Text
                lblPaidStatus.Text = lsvMonthlyFee.SelectedItems(0).SubItems(5).Text
                lblBalance.Text = lsvMonthlyFee.SelectedItems(0).SubItems(4).Text
            End If
        End If
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click, PictureBox2.Click, lblSearchMember.Click
        If cboMonth.Text = "" Or cboYear.Text = "" Then
            MsgBox("Please Specify the Transaction Month and Year", MsgBoxStyle.Information, "Information")
            cboMonth.Focus()
        Else
            btnPay.Visible = False
            txtAmount.Enabled = False
        End If
    End Sub


    Private Sub cboMonth_Click(sender As Object, e As EventArgs) Handles cboYear.Click, cboMonth.Click
        btnPay.Visible = False
        txtAmount.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If cboMonth.Text = "" Or cboYear.Text = "" Then

        Else
            If txtSearch.Text.Length > 0 Then
                lblSearchMember.Visible = False
                m.searchUnpaidSpecificMonthYear(lsvMonthlyFee, cboMonth.Text, cboYear.Text, txtSearch.Text)
            Else
                lblSearchMember.Visible = True
                m.displaySpecificMonthYear(lsvMonthlyFee, cboMonth.Text, cboYear.Text)
            End If
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If cboMonth.Text = "" Then
            MsgBox("Please Specify the Transaction Month", MsgBoxStyle.Information, "information")
        ElseIf cboYear.Text = "" Then
            MsgBox("Please Specify the Transaction Year", MsgBoxStyle.Information, "information")
        ElseIf cboMonth.Text = "" Or cboYear.Text = "" Then
            MsgBox("Please Specify the Transaction Month and Year", MsgBoxStyle.Information, "Information")
        Else
            btnPay.Visible = False
            txtAmount.Enabled = False
            m.displaySpecificMonthYear(lsvMonthlyFee, cboMonth.Text, cboYear.Text)
        End If

    End Sub

   
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If Double.Parse(txtAmount.Text) < 5 Then
            MsgBox("Invalid Payment Amount", MsgBoxStyle.Critical, "Error Amount")
            txtAmount.Clear()
            txtAmount.Focus()
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        bal = Double.Parse(lblBalance.Text)
        If txtAmount.Text.Length < 1 Then
            amount = 0
        Else
            amount = Double.Parse(txtAmount.Text)
            If amount > bal Then
                change = amount - bal
                txtChange.Text = change.ToString()
            ElseIf amount = bal Then
                txtChange.Text = "0"
            ElseIf amount < bal Then
                txtChange.Text = "0"
            End If
        End If
    End Sub
End Class