Public Class frmAttendance

    Public att As New Attendance
    Public hour, mins, openhour, total_hour As Integer
    Public num_of_present As Integer
    Public check_timer As Boolean

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnRemove.Visible = False
        If txtSearch.Text.Length > 0 Then
            Button1.Visible = False
            Button2.Visible = False
            lblSearchMember.Visible = False
            att.searchMember(lsvAttendance, txtSearch.Text)
            lsvAttendance.Visible = True
            lsvPresentMember.Visible = False
        Else
            Button1.Visible = True
            Button2.Visible = True
            lblSearchMember.Visible = True
            lsvAttendance.Visible = False
            lsvPresentMember.Visible = True

        End If
    End Sub

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Button1.Visible = True
        Button2.Visible = True
        Button1.Enabled = False
        Button2.Enabled = False
        btnLogin.Visible = False

        btnRemove.Visible = False
        lsvPresentMember.Visible = True
        lsvAttendance.Visible = False
        txtDescription.Focus()
        btnLogin.Enabled = False
        btnSave.Enabled = False
        lsvAttendance.Enabled = False
        txtSearch.Enabled = False

        Label4.Visible = False
        Label3.Visible = False
        Label1.Visible = False
        lblMins.Visible = False
        lblSec.Visible = False
        Label6.Visible = False

        att.displayAllMembersForAttendance(lsvAttendance)
    End Sub

    Private Sub lblSearchMember_Click(sender As Object, e As EventArgs) Handles lblSearchMember.Click
        txtSearch.Focus()
    End Sub


    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        If cboMeetingtype.Text = "" Then
            MsgBox("Cannot set incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
        ElseIf txtDescription.Text = Nothing Then
            MsgBox("Cannot set incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
        ElseIf cboHour.Text = "" Then
            MsgBox("Cannot set incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
        ElseIf cboMins.Text = "" Then
            MsgBox("Cannot set incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
        ElseIf cboAmPm.Text = "" Then
            MsgBox("Cannot set incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
        ElseIf cboOpenMins.Text = "" Then
            MsgBox("Cannot set incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
        Else

            hour = Integer.Parse(cboHour.Text)
            mins = Integer.Parse(cboMins.Text)
            openhour = Integer.Parse(cboOpenMins.Text)
            Dim Remaining_mins As Integer

            Remaining_mins = openhour - 1
            lblTitle.Text = txtDescription.Text
            lblStatus.Text = "INACTIVE"

            If Remaining_mins < 10 Then
                lblMins.Text = "0" & Remaining_mins.ToString()
            Else
                lblMins.Text = Remaining_mins.ToString()
            End If

            lblSec.Text = "59"

            If cboOpenMins.Text = "60" Then
                total_hour = (hour + 1)
                lblTimeIn.Text = cboHour.Text & ":" & cboMins.Text & " " & cboAmPm.Text & " - " & total_hour.ToString() & ":" & cboMins.Text & " " & cboAmPm.Text
            Else
                total_hour = (mins + openhour)
                If total_hour >= 60 Then
                    total_hour = (hour + 1)
                    mins = (mins + openhour) - 60
                    If mins = 5 Then
                        lblTimeIn.Text = cboHour.Text & ":" & cboMins.Text & " " & cboAmPm.Text & " - " & total_hour.ToString() & ":" & "0" & mins & " " & cboAmPm.Text
                    ElseIf mins = 0 Then
                        lblTimeIn.Text = cboHour.Text & ":" & cboMins.Text & " " & cboAmPm.Text & " - " & total_hour.ToString() & ":" & "0" & mins & " " & cboAmPm.Text
                    Else
                        lblTimeIn.Text = cboHour.Text & ":" & cboMins.Text & " " & cboAmPm.Text & " - " & total_hour.ToString() & ":" & mins & " " & cboAmPm.Text
                    End If
                Else
                    lblTimeIn.Text = cboHour.Text & ":" & cboMins.Text & " " & cboAmPm.Text & " - " & cboHour.Text & ":" & total_hour & " " & cboAmPm.Text
                End If
            End If
        End If
    End Sub

    Private Sub btnActiveNow_Click(sender As Object, e As EventArgs) Handles btnActiveNow.Click


        If btnActiveNow.Text = "ACTIVE NOW" Then
            check_timer = True
            Button1.Enabled = True
            Button2.Enabled = True
            cboMeetingtype.Enabled = False
            txtDescription.Enabled = False
            cboHour.Enabled = False
            cboMins.Enabled = False
            cboAmPm.Enabled = False
            cboOpenMins.Enabled = False
            btnSet.Enabled = False

            If cboMeetingtype.Text = "" Then
                MsgBox("Cannot Activate incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
            ElseIf txtDescription.Text = Nothing Then
                MsgBox("Cannot Activate incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
            ElseIf cboHour.Text = "" Then
                MsgBox("Cannot Activate incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
            ElseIf cboMins.Text = "" Then
                MsgBox("Cannot Activate incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
            ElseIf cboAmPm.Text = "" Then
                MsgBox("Cannot Activate incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
            ElseIf cboOpenMins.Text = "" Then
                MsgBox("Cannot Activate incomplete 'Set-up information'", MsgBoxStyle.Exclamation, Title:="Warning")
            Else
                lblStatus.Text = "ACTIVATED"
                btnLogin.Enabled = True
                btnSave.Enabled = True
                lsvAttendance.Enabled = True
                txtSearch.Enabled = True

                Label4.Visible = True
                Label3.Visible = True
                Label1.Visible = True
                lblMins.Visible = True
                Label6.Visible = True
                lblSec.Visible = True

                timeRemaining.Start()
            End If
            btnActiveNow.Text = "DEACTIVE"
        Else
            check_timer = False
            Button1.Enabled = False
            Button2.Enabled = False
            cboMeetingtype.Enabled = True
            txtDescription.Enabled = True
            cboHour.Enabled = True
            cboMins.Enabled = True
            cboAmPm.Enabled = True
            cboOpenMins.Enabled = True
            btnSet.Enabled = True

            Button1.Visible = False
            Button2.Visible = False
            btnRemove.Visible = False
            lsvPresentMember.Visible = True
            lsvAttendance.Visible = False
            txtDescription.Focus()
            btnLogin.Enabled = False
            btnSave.Enabled = False
            lsvAttendance.Enabled = False
            txtSearch.Enabled = False

            Label4.Visible = False
            Label3.Visible = False
            Label1.Visible = False
            lblMins.Visible = False
            lblSec.Visible = False
            Label6.Visible = False

            timeRemaining.Stop()
            btnActiveNow.Text = "ACTIVE NOW"
        End If

    End Sub

    Private Sub cboAttendanceType_Click(sender As Object, e As EventArgs)
        Label5.Visible = False
    End Sub

    Private Sub cboAttendanceType_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboMeetingtype.Text = "" Then
            Label5.Visible = True
        Else
            Label5.Visible = False
        End If
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        If txtDescription.Text.Length < 1 Then
            Label7.Visible = True
        Else
            Label7.Visible = False
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        txtDescription.Focus()
    End Sub

    Private Sub cboHour_Click(sender As Object, e As EventArgs) Handles cboHour.Click
        If cboHour.Text = "" Then
            Label8.Visible = True
        Else
            Label8.Visible = False
        End If

    End Sub


    Private Sub cboHour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHour.SelectedIndexChanged
        If cboHour.Text = "" Then
            Label8.Visible = True
        Else
            Label8.Visible = False
        End If
    End Sub

    Private Sub cboMins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMins.SelectedIndexChanged
        If cboMins.Text = "" Then
            Label14.Visible = True
        Else
            Label14.Visible = False
        End If

    End Sub

    Private Sub cboAmPm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAmPm.SelectedIndexChanged
        If cboAmPm.Text = "" Then
            Label15.Visible = True
        Else
            Label15.Visible = False
        End If
    End Sub

    Private Sub cboOpenMins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpenMins.SelectedIndexChanged
        If cboOpenMins.Text = "" Then
            Label16.Visible = True
        Else
            Label16.Visible = False
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub




    Public Sub disposeInformation()
        cboMeetingtype.Text = ""
        txtDescription.Clear()
        cboHour.Text = ""
        cboMins.Text = ""
        cboAmPm.Text = ""
        cboOpenMins.Text = ""
        lblTotalPresent.Text = 0
    End Sub

    Public Sub resetForm()
        Me.Dispose()
    End Sub

    Private Sub frmAttendance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Me.resetForm()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim selected_id = lsvAttendance.SelectedItems.Count
        If selected_id <= 0 Then
            MsgBox("Search and select the Member first", MsgBoxStyle.Information, "Information")
        Else
            btnLogin.Visible = False
            num_of_present = num_of_present + 1
            lblTotalPresent.Text = num_of_present.ToString()
            Dim i As Integer = lsvPresentMember.Items.Count
            Dim id As Integer = Integer.Parse(lsvAttendance.SelectedItems(0).SubItems(0).Text)
            Dim exist_ As Boolean = False

            For Each lst As ListViewItem In lsvPresentMember.Items
                Dim present_id As Integer = Integer.Parse(lst.Text)
                If id = present_id Then
                    exist_ = True
                    lsvAttendance.Visible = False
                    lsvPresentMember.Visible = True
                    txtSearch.Clear()
                    txtSearch.Focus()
                End If
            Next
            If exist_ = True Then
                MsgBox(lsvAttendance.SelectedItems(0).SubItems(2).Text & " was already Login", MsgBoxStyle.Information, "Login")
            Else
                lsvPresentMember.Items.Add(lsvAttendance.SelectedItems(0).SubItems(0).Text)
                lsvPresentMember.Items(i).SubItems.Add(lsvAttendance.SelectedItems(0).SubItems(1).Text)
                lsvPresentMember.Items(i).SubItems.Add(lsvAttendance.SelectedItems(0).SubItems(2).Text)
                lsvPresentMember.Items(i).SubItems.Add(Date.Now.ToString("yyyy-MM-dd"))
                lsvPresentMember.Items(i).SubItems.Add("Present")
                lsvPresentMember.Items(i).SubItems.Add(txtDescription.Text)
                lsvPresentMember.Items(i).SubItems.Add(cboHour.Text & ":" & cboMins.Text & ":00")
                lsvPresentMember.Items(i).SubItems.Add(cboMeetingtype.Text)

                lsvAttendance.Visible = False
                lsvPresentMember.Visible = True
                txtSearch.Clear()
                txtSearch.Focus()
                exist_ = False
            End If

        End If
    End Sub


    Private Sub cboMeetingtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMeetingtype.SelectedIndexChanged
        Label5.Visible = False
    End Sub

    Private Sub timeRemaining_Tick(sender As Object, e As EventArgs) Handles timeRemaining.Tick
        Dim r_mins, r_sec As Integer
        r_mins = Integer.Parse(lblMins.Text)
        r_sec = Integer.Parse(lblSec.Text)

        If r_mins > 0 Then
            r_sec -= 1
            If r_sec < 10 Then
                lblSec.Text = "0" & r_sec.ToString()
            Else
                lblSec.Text = r_sec.ToString()
            End If

            If r_sec = 0 Then
                r_mins -= 1
                If r_mins < 10 Then
                    lblMins.Text = "0" & r_mins.ToString()
                Else
                    lblMins.Text = r_mins.ToString()
                End If

                r_sec = 59
                If r_sec < 10 Then
                    lblSec.Text = "0" & r_sec.ToString()
                Else
                    lblSec.Text = r_sec.ToString()
                End If
            End If
        ElseIf r_sec <= 59 Then
            r_sec -= 1
            lblSec.Text = r_sec.ToString()

            If r_sec < 10 Then
                lblMins.ForeColor = Color.Red
                lblSec.ForeColor = Color.Red
                lblSec.Text = "0" & r_sec.ToString()
            End If

            If r_sec = 0 Then
                timeRemaining.Stop()
                MsgBox("Attendance is now Closed" & vbNewLine + vbNewLine & "All Logged in members will automatically saved", MsgBoxStyle.Information, "Times up")
                Me.saveAttendanceInfo()
            End If

        End If
    End Sub

    Private Sub txtCurrentTime_Click(sender As Object, e As EventArgs) Handles txtDay.Click, txtDate.Click, txtCurrentTime.Click
        txtDescription.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.saveAttendanceInfo()
    End Sub
    Public Sub saveAttendanceInfo()
        For Each lst As ListViewItem In lsvPresentMember.Items
            att.member_id = Integer.Parse(lst.Text)
            att.activity_type = lst.SubItems(7).Text
            att.date_ = Date.Now.ToString("yyyy-MM-dd")
            att.status = lst.SubItems(4).Text
            att.meeting_time = lst.SubItems(6).Text
            att.description = lst.SubItems(5).Text
            att.saveAttendanceInfo()
        Next
        'att.listOfAbsentMembers(att.activity_type, att.date_, att.meeting_time, att.description)
        Dim absent As New Collection
        absent = Attendance.populateAllAbsent(att.date_, att.description)
        For Each m_absents As Attendance In absent
            att.saveAbsentWithFines(m_absents.m_member_id, m_absents.m_fines, m_absents.m_status, m_absents.m_meeting_date, m_absents.m_description)
        Next
        MsgBox("Attendance Information Successfully Saved", MsgBoxStyle.Information)
        txtDescription.Clear()
        txtDescription.Enabled = True
        cboMeetingtype.Text = Nothing
        cboMeetingtype.Enabled = True
        cboAmPm.Text = Nothing
        cboAmPm.Enabled = True
        cboHour.Text = Nothing
        cboHour.Enabled = True
        cboMins.Text = Nothing
        cboMins.Enabled = True
        cboOpenMins.Text = Nothing
        cboOpenMins.Enabled = True
        lsvPresentMember.Items.Clear()
        lblTotalPresent.Text = ""
        lblMins.Text = "00"
        lblSec.Text = "00"
        lblStatus.Text = ""
        btnSet.Enabled = True
        btnActiveNow.Text = "ACTIVE NOW"
        lblTitle.Text = ""
        lblTimeIn.Text = ""
        lblSec.ForeColor = Color.White
        lblMins.ForeColor = Color.White
        btnSave.Enabled = False
        txtSearch.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        txtDescription.Focus()
        timeRemaining.Stop()
    End Sub

    Private Sub lsvPresentMember_Click(sender As Object, e As EventArgs) Handles lsvPresentMember.Click


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim s As DialogResult = MsgBox("Are you sure you want to remove '" & lsvPresentMember.SelectedItems(0).SubItems(2).Text & "' from the list ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
        If s = MsgBoxResult.Yes Then
            lsvPresentMember.SelectedItems(0).Remove()
            num_of_present = num_of_present - 1
            lblTotalPresent.Text = num_of_present.ToString()
        End If



    End Sub

    Private Sub lsvPresentMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvPresentMember.SelectedIndexChanged
        Dim selected_p_id = lsvPresentMember.SelectedItems.Count
        If selected_p_id <= 0 Then
            btnRemove.Visible = False
        Else
            btnRemove.Visible = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lsvPresentMember.Visible = True
        lsvAttendance.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        att.displayAllMembersForAttendance(lsvAttendance)
        lsvPresentMember.Visible = False
        lsvAttendance.Visible = True
    End Sub

    Private Sub lsvAttendance_Click(sender As Object, e As EventArgs) Handles lsvAttendance.Click

    End Sub

    Private Sub lsvAttendance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvAttendance.SelectedIndexChanged
        Dim selected_p_id = lsvAttendance.SelectedItems.Count
        If selected_p_id <= 0 Then
            btnLogin.Visible = False
        Else
            btnLogin.Visible = True

        End If
    End Sub

    Private Sub frmAttendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtCurrentTime.Text = System.DateTime.Now.ToString("h:mm tt")
        txtDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        txtDay.Text = Date.Now.ToString("dddd")
    End Sub
End Class