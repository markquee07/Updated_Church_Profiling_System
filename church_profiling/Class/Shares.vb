Public Class Shares
    Public id As Integer
    Public Pastor_share As Double
    Public District As Double
    Public Main_church As Double
    Public Local_church As Double
    Public Modereator As Double


    Public Sub saveShares(date_from As String, date_to As String)
        Dim sql As String = "INSERT INTO  tbl_shared " & _
               "VALUES(NULL," & Me.Pastor_share & "," & Me.District & "," & Me.Main_church & "," & Me.Local_church & "," & Me.Modereator & ",'" & date_from & "','" & date_to & "',now());"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("New Transaction Saved")
    End Sub

End Class
