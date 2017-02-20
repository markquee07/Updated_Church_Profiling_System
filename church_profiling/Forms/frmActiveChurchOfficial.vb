Public Class frmActiveChurchOfficial

    Public resized As Image
    Private Sub frmActiveChurchOfficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim officials As New Collection
        officials = churchOfficial.displayActiveOfficials
        For Each official As churchOfficial In officials
            txtYear.Text = official.year
            Select Case official.position
                Case "HOST PASTOR"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\pastor\" & official.image_path)
                    txtHostPastor.Text = official.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbHostPastor.BackgroundImage, NewSize)
                    ptbHostPastor.BackgroundImage = resized
                    ptbHostPastor.BackgroundImageLayout = ImageLayout.Stretch

                    ptbHostPastor.BackgroundImage = bmp
                    Exit Select
                Case "ELDER"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & official.image_path)
                    txtElder.Text = official.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbElder.BackgroundImage, NewSize)
                    ptbElder.BackgroundImage = resized
                    ptbElder.BackgroundImageLayout = ImageLayout.Stretch

                    ptbElder.BackgroundImage = bmp
                    Exit Select
                Case "DEACON 1"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & official.image_path)
                    txtDeacon1.Text = official.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbDeacon1.BackgroundImage, NewSize)
                    ptbDeacon1.BackgroundImage = resized
                    ptbDeacon1.BackgroundImageLayout = ImageLayout.Stretch

                    ptbDeacon1.BackgroundImage = bmp
                    Exit Select
                Case "DEACON 2"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & official.image_path)
                    txtDeacon2.Text = official.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbDeacon2.BackgroundImage, NewSize)
                    ptbDeacon2.BackgroundImage = resized
                    ptbDeacon2.BackgroundImageLayout = ImageLayout.Stretch

                    ptbDeacon2.BackgroundImage = bmp
                    Exit Select
                Case "DEACON 3"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & official.image_path)
                    txtDeacon3.Text = official.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbDeacon3.BackgroundImage, NewSize)
                    ptbDeacon3.BackgroundImage = resized
                    ptbDeacon3.BackgroundImageLayout = ImageLayout.Stretch

                    ptbDeacon3.BackgroundImage = bmp
                    Exit Select
                Case "TREASURER"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & official.image_path)
                    txtTreasurer.Text = official.member_name

                    Dim NewSize As New Size(128, 110)
                    resized = New Bitmap(ptbTreasurer.BackgroundImage, NewSize)
                    ptbTreasurer.BackgroundImage = resized
                    ptbTreasurer.BackgroundImageLayout = ImageLayout.Stretch

                    ptbTreasurer.BackgroundImage = bmp
                    Exit Select
                Case "SECRETARY"
                    Dim bmp As New Bitmap(My.Application.Info.DirectoryPath & "\members\" & official.image_path)
                    txtSecretary.Text = official.member_name

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