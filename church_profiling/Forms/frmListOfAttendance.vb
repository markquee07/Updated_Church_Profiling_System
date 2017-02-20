Public Class frmListOfAttendance

    Public att As New Attendance
    Public attendance_date As String
    Public attendance_description As String
    Private button_no As Integer

    Private Sub frmListOfAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Visible = False
        lblDesc.Visible = False
        btnPayFines.Visible = False
        button_no = 1
        lsvFines.Visible = False
        lsvPresent.Visible = False
        lsvListOfAttendance.Visible = True
        att.displayAllAttendance(lsvListOfAttendance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnPayFines.Visible = False
        Dim i As Integer = lsvListOfAttendance.SelectedItems.Count
        If i <= 0 Then
            MsgBox("Please Select the Attendance to View", MsgBoxStyle.Information)
        Else
            button_no = 2
            lblSearchAttendance.Text = "Search Member"
            lsvFines.Visible = False
            lsvListOfAttendance.Visible = False
            lsvPresent.Visible = True
            att.displaymemberPresentAttendance(lsvPresent, attendance_date, attendance_description)
            '    With frmMemberAttendance
            '        .att_date = attendance_date
            '        .att_desc = attendance_description
            '        .ShowDialog()
            '    End With
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchAttendance.Visible = False
            If button_no = 1 Then
                att.searchAllAttendance(lsvListOfAttendance, txtSearch.Text)
            ElseIf button_no = 2 Then
                att.searchmemberPresentAttendance(lsvPresent, attendance_date, attendance_description, txtSearch.Text)
            ElseIf button_no = 3 Then
                att.searchFines(lsvFines, attendance_description, attendance_date, txtSearch.Text)
            End If

        Else
            lblSearchAttendance.Visible = True
            att.displayAllAttendance(lsvListOfAttendance)
            att.displaymemberPresentAttendance(lsvPresent, attendance_date, attendance_description)
            att.displayFines(lsvFines, attendance_description, attendance_date)
        End If

    End Sub

    Private Sub lsvListOfAttendance_Click(sender As Object, e As EventArgs) Handles lsvListOfAttendance.Click
        attendance_date = (lsvListOfAttendance.SelectedItems(0).SubItems(2).Text)
        attendance_description = (lsvListOfAttendance.SelectedItems(0).SubItems(5).Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btnPayFines.Visible = False
        lsvFines.Visible = False
        lsvPresent.Visible = False
        lsvListOfAttendance.Visible = True
        button_no = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        btnPayFines.Visible = False
        Dim f As Integer = lsvListOfAttendance.SelectedItems.Count
        If f <= 0 Then
            MsgBox("Please Select the Attendance to View", MsgBoxStyle.Information)
        Else
            lblDesc.Text = lsvListOfAttendance.SelectedItems(0).SubItems(5).Text
            lblDate.Text = lsvListOfAttendance.SelectedItems(0).SubItems(2).Text
            button_no = 3
            lblSearchAttendance.Text = "Search Member"
            lsvPresent.Visible = False
            lsvListOfAttendance.Visible = False
            lsvFines.Visible = True
            att.displayFines(lsvFines, attendance_description, attendance_date)
        End If
    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPayFines.Click

        Dim pf As New frmPayFines
        With pf
            .lblID.Text = lsvFines.SelectedItems(0).SubItems(0).Text
            .ShowDialog()
        End With

    End Sub

    Private Sub lsvFines_Click(sender As Object, e As EventArgs) Handles lsvFines.Click
        Dim x As Integer = lsvFines.SelectedItems.Count
        If x <= 0 Then
            btnPayFines.Visible = False
        Else
            If lsvFines.SelectedItems(0).SubItems(6).Text = "UNPAID" Then
                btnPayFines.Visible = True
            Else
                btnPayFines.Visible = False
            End If
        End If
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        btnPayFines.Visible = False
    End Sub

    Private Sub lblSearchAttendance_Click(sender As Object, e As EventArgs) Handles lblSearchAttendance.Click
        btnPayFines.Visible = False
        txtSearch.Focus()
    End Sub
End Class