Public Class frmActiveBurialOfficials

    Public resized As Image
    Private Sub frmActiveBurialOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim burial_officials As New Collection

        burial_officials = burialOfficials.displayBurialOfficials
        For Each burial As burialOfficials In burial_officials
            txtYear.Text = burial.year
            Select Case burial.position

                Case "PRESIDENT"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & burial.image_path)
                    txtPresident.Text = burial.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbPresident.BackgroundImage, NewSize)
                    ptbPresident.BackgroundImage = resized
                    ptbPresident.BackgroundImageLayout = ImageLayout.Stretch

                    ptbPresident.BackgroundImage = bmp
                    Exit Select
                Case "VICE-PRESIDENT"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & burial.image_path)
                    txtVicePresident.Text = burial.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbVicePresident.BackgroundImage, NewSize)
                    ptbVicePresident.BackgroundImage = resized
                    ptbVicePresident.BackgroundImageLayout = ImageLayout.Stretch

                    ptbVicePresident.BackgroundImage = bmp
                    Exit Select
                Case "TREASURER"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & burial.image_path)
                    txtTreasurer.Text = burial.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbTreasurer.BackgroundImage, NewSize)
                    ptbTreasurer.BackgroundImage = resized
                    ptbTreasurer.BackgroundImageLayout = ImageLayout.Stretch

                    ptbTreasurer.BackgroundImage = bmp
                    Exit Select
                Case "SECRETARY"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & burial.image_path)
                    txtSecretary.Text = burial.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbSecretary.BackgroundImage, NewSize)
                    ptbSecretary.BackgroundImage = resized
                    ptbSecretary.BackgroundImageLayout = ImageLayout.Stretch

                    ptbSecretary.BackgroundImage = bmp
                    Exit Select
            End Select
        Next
    End Sub
End Class