Public Class Monthly_fee

    Public validateMonth As String
    Public lesser_month As String

    Public id As Integer
    Public monthly_fee As Double


    Public Sub validateEqualMonth()
        Dim sql As String = "SELECT if(date_format(month,'%M %Y') = date_format(now(),'%M %Y'),'True','False') as month FROM tbl_month_generator"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                validateMonth = GLOBAL_VARS.db.reader("month").ToString()
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub validateLesserMonth()
        Dim sql As String = "SELECT if(unix_timestamp(date_format(now() - interval (day(now())-1) day,'%Y-%m-%d')) < unix_timestamp(month),'Error','Execute') as month from tbl_month_generator"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                lesser_month = GLOBAL_VARS.db.reader("month").ToString()
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Shared Function selectAllMember() As Collection
        Dim members As New Collection

        Dim sql As String = "SELECT id FROM tbl_member_information"
        GLOBAL_VARS.db.execute(sql)
        While GLOBAL_VARS.db.reader.Read
            If GLOBAL_VARS.db.reader.HasRows Then
                Dim m As New Monthly_fee
                With m
                    .id = GLOBAL_VARS.db.reader("id").ToString()
                End With
                members.Add(m)
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
        Return members
    End Function

    Public Sub saveMonthlyFeeInformation(m_id As Integer, m_amount As Integer)
        Dim sql As String = "insert into tbl_ten values (" & m_id & "," & m_amount & ",'UNPAID',now(),null," & m_amount & ")"
        GLOBAL_VARS.db.executeNonReader(sql)
        Me.updateGeneratedMonth()
    End Sub

    Public Function getMonthlyFee() As Integer
        Dim m_fee As Integer
        Dim sql As String = "SELECT monthly_fee FROM tbl_amount"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                m_fee = GLOBAL_VARS.db.reader("monthly_fee").ToString()
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
        Return m_fee
    End Function

    Private Sub updateGeneratedMonth()
        Dim sql As String = "update tbl_month_generator set month = now()"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Sub displayMonthlyFeeDetails(lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "select t.id,m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,t.amount,t.balance,t.status,date_format(t.month,'%M %Y') as month from tbl_member_information m inner join tbl_ten t on m.id = t.member_id where t.status = 'UNPAID'"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("amount").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("balance").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("month").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub displaySpecificMonthYear(lsv As ListView, month As String, year As String)
        lsv.Items.Clear()
        Dim sql As String = "select t.id,m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,t.amount,t.balance,t.status,date_format(t.month,'%M %Y') as month from tbl_member_information m inner join tbl_ten t on m.id = t.member_id where date_format(month,'%M') = '" & month & "' and date_format(month,'%Y') = '" & year & "' and t.status = 'UNPAID'"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("amount").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("balance").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("month").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub searchUnpaidSpecificMonthYear(lsv As ListView, month As String, year As String, key As String)
        lsv.Items.Clear()
        Dim sql As String = "select t.id,m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,t.amount,t.balance,t.status,date_format(t.month,'%M %Y') as month from tbl_member_information m inner join tbl_ten t on m.id = t.member_id where ((date_format(month,'%M') = '" & month & "' and date_format(month,'%Y') = '" & year & "') and t.status = 'UNPAID') and (m.first_name like '%" & key & "%' or m.last_name like '%" & key & "%' or m.member_id like '%" & key & "%' or m.middle_name like '%" & key & "%')"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("amount").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("balance").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("month").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub addToMonthCombobox(cbo As ComboBox)
        cbo.Items.Clear()
        Dim sql As String = "select distinct date_format(month,'%M') as month from tbl_ten"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                Dim i As Integer = cbo.Items.Count
                With cbo
                    cbo.Items.Add(GLOBAL_VARS.db.reader("month").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub addToYearCombobox(cbo As ComboBox)
        cbo.Items.Clear()
        Dim sql As String = "select distinct date_format(month,'%Y') as month from tbl_ten"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read
                Dim i As Integer = cbo.Items.Count
                With cbo
                    cbo.Items.Add(GLOBAL_VARS.db.reader("month").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
End Class
