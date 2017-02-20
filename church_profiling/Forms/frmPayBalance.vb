Public Class frmPayBalance

    Public ex As New Emergencyfund
    Public id As Integer
    Public amount As Double
    Public change As Double
    Public bal As Double

    Private Sub frmPayBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Enabled = True
        txtAmount.Focus()
        txtChange.Enabled = False
        With ex
            .displayCurrentBorrowerByID(id)
            .currentBalance()
            lblMemberID.Text = .members_ids
            lblMemberName.Text = .Fullname
            lblDateBorrowed.Text = .date_borrowed
            lblDueDate.Text = .due_date
            lblPaidStatus.Text = .status
            lblBalance.Text = .balance
        End With
    End Sub

    Private Sub frmPayBalance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bal = Double.Parse(lblBalance.Text)
        If amount >= bal Then
            pay()
        Else
            pay2()
        End If
    End Sub

    Public Sub pay()
        amount = 1000
        With ex
            .payBalance(amount)
            .currentBalance()
            If .balance = 0 Then
                .updateStatus(id)
                .displayCurrentBorrowerByID(id)
                lblBalance.Text = .balance
                lblMemberID.Text = .members_ids
                If lblBalance.Text = "0" Then
                    lblPaidStatus.Text = "PAID"
                Else
                    lblPaidStatus.Text = "UNPAID"
                End If
                lblMemberName.Text = .Fullname
                lblDateBorrowed.Text = .date_borrowed
                lblDueDate.Text = .due_date

            End If
            .updateStatus(id)
            .displayCurrentBorrowerByID(id)
            lblMemberID.Text = .members_ids
            lblMemberName.Text = .Fullname
            lblDateBorrowed.Text = .date_borrowed
            lblDueDate.Text = .due_date
            lblBalance.Text = .balance
            If lblBalance.Text = "0" Then
                lblPaidStatus.Text = "PAID"
            Else
                lblPaidStatus.Text = "UNPAID"
            End If
        End With
        txtAmount.Clear()
        txtChange.Clear()
        If lblBalance.Text = "0" Then
            txtAmount.Enabled = False
        Else
            txtAmount.Enabled = True
        End If
        ex.listOfAllEmergencyFundsRecord(frmListofDebts.lsvEmergencyFund)

    End Sub

    Public Sub pay2()
        With ex
            .payBalance(amount)
            .remainingBalance(bal)
            If .balance = 0 Then
                .updateStatus(id)
                .displayCurrentBorrowerByID(id)
                lblMemberID.Text = .members_ids
                lblBalance.Text = .balance
                If lblBalance.Text = "0" Then
                    lblPaidStatus.Text = "PAID"
                Else
                    lblPaidStatus.Text = "UNPAID"
                End If
                lblMemberName.Text = .Fullname
                lblDateBorrowed.Text = .date_borrowed
                lblDueDate.Text = .due_date
                lblPaidStatus.Text = .status
            End If
            .displayCurrentBorrowerByID(id)
            lblMemberID.Text = .members_ids
            lblMemberName.Text = .Fullname
            lblDateBorrowed.Text = .date_borrowed
            lblDueDate.Text = .due_date
            lblBalance.Text = .rem_balance
            If lblBalance.Text = "0" Then
                lblPaidStatus.Text = "PAID"
            Else
                lblPaidStatus.Text = "UNPAID"
            End If
        End With
        txtAmount.Clear()
        txtChange.Clear()
        If lblBalance.Text = "0" Then
            txtAmount.Enabled = False
        Else
            txtAmount.Enabled = True
        End If
        ex.listOfAllEmergencyFundsRecord(frmListofDebts.lsvEmergencyFund)

    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If IsNumeric(e.KeyChar) Or Convert.ToInt32(e.KeyChar).ToString() = 46 Or Convert.ToInt32(e.KeyChar).ToString() = 8 Then

            e.Handled = False
        Else
            MsgBox("Invalid Amount", MsgBoxStyle.Information, "Information")
            e.Handled = True
        End If
    End Sub
End Class