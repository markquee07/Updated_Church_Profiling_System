Public Class frmPayFines


    Public amount As Double
    Public change As Double
    Public bal As Double
    Private att As New Attendance
    Private Sub frmPayFines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Visible = False
        txtAmount.Enabled = True
        txtAmount.Focus()
        txtChange.Enabled = False
        With att
            .displayFinesByID(lblID.Text)
            lblMemberID.Text = .m_member_ids
            lblMemberName.Text = .m_member_name
            lblMeetingDate.Text = .m_meeting_date
            lblDescription.Text = .m_description
            lblPaidStatus.Text = .m_status
            lblBalance.Text = .m_balance
        End With
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
            amount = 50
            With att
                .payFines(amount, lblID.Text)
                .currentFinesBalance(lblID.Text)
                If .m_balance = 0 Then
                    .updateFinesStatus(lblID.Text)
                    .displayFinesByID(lblID.Text)
                    lblMemberID.Text = .m_member_ids
                    lblMemberName.Text = .m_member_name
                    lblMeetingDate.Text = .m_meeting_date
                    lblDescription.Text = .m_description
                    lblPaidStatus.Text = "PAID"
                    lblBalance.Text = "0"

                    txtAmount.Clear()
                    txtChange.Clear()
                    txtAmount.Enabled = False
                End If
                att.displayFines(frmListOfAttendance.lsvFines, lblDescription.Text, lblMeetingDate.Text)
            End With
        Else
            With att
                Dim z As Double
                .currentBalance(lblID.Text)
                If .m_balance < 50 Then
                    If amount < bal Then
                        z = bal - amount
                        z = 50 - z
                        .payFines(z, lblID.Text)
                    Else
                        z = 50
                        .payFines(z, lblID.Text)
                    End If
                ElseIf .m_balance = 50 Then
                    .payFines(amount, lblID.Text)
                End If

                .currentFinesBalance(lblID.Text)
                If .m_balance < bal Then
                    .displayFinesByID(lblID.Text)
                    .currentFinesBalance(lblID.Text)
                    lblMemberID.Text = .m_member_ids
                    lblMemberName.Text = .m_member_name
                    lblMeetingDate.Text = .m_meeting_date
                    lblDescription.Text = .m_description
                    lblPaidStatus.Text = .m_status
                    lblBalance.Text = .m_balance

                    txtAmount.Clear()
                    txtChange.Clear()
                    txtAmount.Focus()
                    att.displayFines(frmListOfAttendance.lsvFines, lblDescription.Text, lblMeetingDate.Text)
                Else
                    If .m_balance = 0 Then
                        .updateFinesStatus(lblID.Text)
                        .displayFinesByID(lblID.Text)
                        lblMemberID.Text = .m_member_ids
                        lblMemberName.Text = .m_member_name
                        lblMeetingDate.Text = .m_meeting_date
                        lblDescription.Text = .m_description
                        lblPaidStatus.Text = "PAID"
                        lblBalance.Text = "0"

                        txtAmount.Clear()
                        txtChange.Clear()
                        txtAmount.Enabled = False
                    End If
                    att.displayFines(frmListOfAttendance.lsvFines, lblDescription.Text, lblMeetingDate.Text)
                End If
            End With
        End If
    End Sub
End Class