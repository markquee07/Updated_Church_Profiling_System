Public Class churchOfficial

    Public member_name As String
    Public position As String
    Public year As String
    Public image_path As String
    Public status As String
    Public active As New Collection

    Public Shared Function displayActiveOfficials() As Collection
        Dim result As New Collection
        Dim sql As String = "SELECT concat(m.first_name,' ',m.middle_name,' ',m.last_name,' ') as Fullname,p.position_type,p.year,m.image_path,p.status FROM tbl_member_information m  inner join tbl_church_officials p on m.id = p.member_id where p.status = 'ACTIVE'"
        GLOBAL_VARS.db.execute(sql)
        While GLOBAL_VARS.db.reader.Read
            If GLOBAL_VARS.db.reader.HasRows Then
                Dim official As New churchOfficial
                With official
                    .member_name = GLOBAL_VARS.db.reader("Fullname").ToString()
                    .position = GLOBAL_VARS.db.reader("position_type").ToString()
                    .year = GLOBAL_VARS.db.reader("year").ToString()
                    .image_path = GLOBAL_VARS.db.reader("image_path").ToString()
                    .status = GLOBAL_VARS.db.reader("status").ToString()
                End With
                result.Add(official)
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
        Return result
    End Function
End Class
