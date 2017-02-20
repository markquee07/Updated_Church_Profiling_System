Public Class burialOfficials
    Public member_name As String
    Public position As String
    Public year As String
    Public status As String
    Public image_path As String
    Public active As New Collection

    Public Shared Function displayBurialOfficials() As Collection
        Dim result As New Collection
        Dim sql As String = "SELECT concat(m.first_name,' ',m.middle_name,' ',m.last_name,' ') as Fullname,b.position,b.year,m.image_path,b.status FROM tbl_member_information m  inner join tbl_burialofficial b on m.id = b.member_id where b.status = 'ACTIVE'"
        GLOBAL_VARS.db.execute(sql)
        While GLOBAL_VARS.db.reader.Read
            If GLOBAL_VARS.db.reader.HasRows Then
                Dim official As New burialOfficials
                With official
                    .member_name = GLOBAL_VARS.db.reader("Fullname").ToString()
                    .position = GLOBAL_VARS.db.reader("position").ToString()
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
