Public Class frmMemberAttendance
    Public att As New Attendance
    Public att_date As String
    Public att_desc As String
    Private Sub frmMemberAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        att.displaymemberPresentAttendance(lsvPresent, att_date, att_desc)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchAttendance.Visible = False
            att.searchmemberPresentAttendance(lsvPresent, att_date, att_desc, txtSearch.Text)
        Else
            lblSearchAttendance.Visible = True
            att.displaymemberPresentAttendance(lsvPresent, att_date, att_desc)
        End If
    End Sub
End Class