Public Class Attendance

    Public member_id As Integer
    Public activity_type As String
    Public date_ As String
    Public meeting_time As String
    Public status As String
    Public description As String

    Public m_member_id As Integer
    Public m_member_ids As String
    Public m_meeting_date As String
    Public m_description As String
    Public m_status As String
    Public m_fines As String
    Public m_balance As Double
    Public m_member_name As String

    Public Sub saveAttendanceInfo()
        Dim sql As String = "insert into tbl_attendance values (" & Me.member_id & ",'" & Me.activity_type & "','" & Me.date_ & "','" & Me.meeting_time & "','" & Me.status & "','" & Me.description & "',null);"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Sub displayAllMembersForAttendance(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id,Member_id,concat(first_name,' ',middle_name,' ',last_name) as full_name,gender FROM tbl_member_information;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("full_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub


    Public Sub searchMember(ByVal lsv As ListView, ByVal search_keyword As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id,Member_id,concat(first_name,' ',middle_name,' ',last_name) as full_name,gender FROM tbl_member_information where member_id like '%" & search_keyword & "%';"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("full_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub


    Public Sub displayAllAttendance(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id, member_id,activity_type,date_format(meeting_date,'%M %d, %Y') as meeting_date,meeting_time,status,description FROM tbl_attendance group by description,meeting_date,meeting_time"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("member_ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Activity_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("meeting_date").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("meeting_time").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("description").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("id").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub searchAllAttendance(ByVal lsv As ListView, key As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id, member_id,activity_type,date_format(meeting_date,'%M %d, %Y') as meeting_date,meeting_time,status,description FROM tbl_attendance where activity_type like '%" & key & "%' or meeting_date like '%" & key & "%' or meeting_time like '%" & key & "%' or description like '%" & key & "%' group by description,meeting_date,meeting_time"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("member_ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Activity_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("meeting_date").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("meeting_time").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("description").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("id").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub displaymemberPresentAttendance(ByVal lsv As ListView, att_date As String, att_desc As String)
        lsv.Items.Clear()
        Dim sql As String = "(SELECT m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,a.status FROM tbl_member_information m inner join tbl_attendance a on m.id = a.member_id where a.description = '" & att_desc & "' and date_format(meeting_date,'%M %d, %Y') = '" & att_date & "') union (select member_id,concat(first_name,' ',middle_name,' ',last_name) as fullname,'Absent' as status from tbl_member_information where id in (select member_id from tbl_fines where description = '" & att_desc & "' and date_format(meeting_date,'%M %d, %Y') = '" & att_date & "'))"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub searchmemberPresentAttendance(ByVal lsv As ListView, att_date As String, att_desc As String, key As String)
        lsv.Items.Clear()
        Dim sql As String = "(SELECT m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,a.status FROM tbl_member_information m inner join tbl_attendance a on m.id = a.member_id where (a.description = '" & att_desc & "' and date_format(meeting_date,'%M %d, %Y') = '" & att_date & "') and (m.first_name like '%" & key & "%' or m.last_name like '%" & key & "%' or m.middle_name like '%" & key & "%' or a.status like '%" & key & "%' or m.member_id like '%" & key & "%')) union (select member_id,concat(first_name,' ',middle_name,' ',last_name) as fullname,'Absent' as status from tbl_member_information where id in (select member_id from tbl_fines where (description = '" & att_desc & "' and date_format(meeting_date,'%M %d, %Y') = '" & att_date & "')) and (first_name like '%" & key & "%' or last_name like '%" & key & "%' or middle_name like '%" & key & "%' or status like '%" & key & "%' or member_id like '%" & key & "%'))  "
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub


    Public Sub listOfAbsentMembers(activity_type As String, meeting_date As String, meeting_time As String, description As String)
        Dim sql As String = "select id,concat(first_name,' ',middle_name,' ',last_name) as fullname from tbl_member_information where id not in (select member_id from tbl_attendance where activity_type = '" & activity_type & "' and meeting_date = '" & meeting_date & "' and meeting_time = '" & meeting_time & "' and description ='" & description & "')"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                member_id = GLOBAL_VARS.db.reader("id").ToString()
                status = "ABSENT"

            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub saveAbsent(mem_id As Integer, activity_type As String, meeting_date As String, meeting_time As String, status As String, description As String)
        Dim sql As String = "insert into tbl_attendance values (" & mem_id & ",'" & activity_type & "','" & meeting_date & "','" & meeting_time & "','" & status & "','" & description & "');"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Shared Function populateAllAbsent(m_date As String, desc As String) As Collection
        Dim result As New Collection
        Dim sql As String = "SELECT id,concat(first_name,' ',middle_name,' ',last_name) as fullname,'ABSENT' as status ,50 as fines FROM tbl_member_information where id not in (SELECT member_id FROM tbl_attendance where meeting_date = '" & m_date & "' and description = '" & desc & "')"
        GLOBAL_VARS.db.execute(sql)
        While GLOBAL_VARS.db.reader.Read
            If GLOBAL_VARS.db.reader.HasRows Then
                Dim official As New Attendance
                With official
                    .m_member_id = GLOBAL_VARS.db.reader("id").ToString()
                    .m_fines = "50"
                    .m_status = "UNPAID"
                    .m_meeting_date = m_date
                    .m_description = desc
                End With
                result.Add(official)
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
        Return result
    End Function

    Public Sub saveAbsentWithFines(m_id As Integer, m_fines As String, m_status As String, m_date As String, m_desc As String)
        Dim sql As String = "insert into tbl_fines values(null," & m_id & ",'" & m_fines & "','" & m_status & "','" & m_date & "','" & m_desc & "',50)"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub


    Public Sub displayFines(lsv As ListView, desc As String, m_date As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT f.id,m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,'ABSENT' as Status,f.fines,f.status as PAID_STATUS,f.balance FROM tbl_member_information m inner join tbl_fines f on m.id = f.member_id where date_format(f.meeting_date,'%M %d, %Y') = '" & m_date & "' and f.description = '" & desc & "'"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fines").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("balance").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("PAID_STATUS").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub displayFinesByID(fines_id As Integer)
        Dim sql As String = "SELECT f.id,m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,date_format(f.meeting_date,'%M %d, %Y') as meeting_date,f.description,f.status,f.balance FROM tbl_member_information m inner join tbl_fines f on m.id = f.member_id where f.id = " & fines_id & ""
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Me.m_member_ids = GLOBAL_VARS.db.reader("member_id").ToString()
                Me.m_member_name = GLOBAL_VARS.db.reader("fullname").ToString()
                Me.m_meeting_date = GLOBAL_VARS.db.reader("meeting_date").ToString()
                Me.m_description = GLOBAL_VARS.db.reader("description").ToString()
                Me.m_status = GLOBAL_VARS.db.reader("status").ToString()
                Me.m_balance = GLOBAL_VARS.db.reader("balance").ToString()
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub searchFines(lsv As ListView, desc As String, m_date As String, key As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT f.id,m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,'ABSENT' as Status,f.fines,f.status as PAID_STATUS FROM tbl_member_information m inner join tbl_fines f on m.id = f.member_id where (date_format(f.meeting_date,'%M %d, %Y') = '" & m_date & "' and f.description = '" & desc & "') and (m.first_name like '%" & key & "%' or m.last_name like '%" & key & "%' or m.middle_name like '%" & key & "%' or f.description like '%" & key & "%' or m.member_id like '%" & key & "%')"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fines").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("PAID_STATUS").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub currentFinesBalance(f_id As Integer)
        Dim sql As String = "SELECT fines - balance as balance FROM tbl_fines where id = " & f_id & ""
        GLOBAL_VARS.db.execute(sql)

        While GLOBAL_VARS.db.reader.Read()
            If GLOBAL_VARS.db.reader.HasRows Then
                With Me
                    .m_balance = GLOBAL_VARS.db.reader("balance").ToString()
                End With
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub currentBalance(f_id As Integer)
        Dim sql As String = "SELECT balance as balance FROM tbl_fines where id = " & f_id & ""
        GLOBAL_VARS.db.execute(sql)

        While GLOBAL_VARS.db.reader.Read()
            If GLOBAL_VARS.db.reader.HasRows Then
                With Me
                    .m_balance = GLOBAL_VARS.db.reader("balance").ToString()
                End With
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub payFines(ammount As Double, f_id As Integer)
        Dim sql As String = "update tbl_fines set balance = " & ammount & " where id= " & f_id & ""
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Sub updateFinesStatus(ByVal f_id As Integer)
        Dim sql As String = "update tbl_fines set status = 'PAID' where id = " & f_id & ""
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub
End Class
