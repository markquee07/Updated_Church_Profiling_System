Public Class frmBurialOfficers

    Public c As New cart

    Public button_no As Integer
    Public officials As New Collection
    Public o_position As String
    Dim active_official As New Selected_Official

    Public resized As Image
    Public member_path As String = My.Application.Info.DirectoryPath & "\members\"



    Private Sub frmBurialOfficers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHostPastor_Click(sender As Object, e As EventArgs) Handles btnHostPastor.Click
        button_no = 1
        o_position = "PRESIDENT"
        c.displayMemberForBurialOfficial(lsvMemberList)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button_no = 2
        o_position = "VICE-PRESIDENT"
        c.displayMemberForBurialOfficial(lsvMemberList)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        button_no = 3
        o_position = "TREASURER"
        c.displayMemberForBurialOfficial(lsvMemberList)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        button_no = 4
        o_position = "SECRETARY"
        c.displayMemberForBurialOfficial(lsvMemberList)
    End Sub

    Private Sub lsvMemberList_Click(sender As Object, e As EventArgs) Handles lsvMemberList.Click
        If button_no = 1 Then
            txtpresident.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
            Dim img_path As String = member_path & lsvMemberList.SelectedItems(0).SubItems(3).Text
            Dim x As New Bitmap(img_path)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(ptbPresident.BackgroundImage, NewSize)
            ptbPresident.BackgroundImage = resized
            ptbPresident.BackgroundImageLayout = ImageLayout.Stretch

            ptbPresident.BackgroundImage = x

        ElseIf button_no = 2 Then
            txtVice_president.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
            Dim img_path As String = member_path & lsvMemberList.SelectedItems(0).SubItems(3).Text
            Dim x As New Bitmap(img_path)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(ptbVicePresident.BackgroundImage, NewSize)
            ptbVicePresident.BackgroundImage = resized
            ptbVicePresident.BackgroundImageLayout = ImageLayout.Stretch

            ptbVicePresident.BackgroundImage = x

        ElseIf button_no = 3 Then
            txtTreasurer.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
            Dim img_path As String = member_path & lsvMemberList.SelectedItems(0).SubItems(3).Text
            Dim x As New Bitmap(img_path)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(ptbTreasurer.BackgroundImage, NewSize)
            ptbTreasurer.BackgroundImage = resized
            ptbTreasurer.BackgroundImageLayout = ImageLayout.Stretch

            ptbTreasurer.BackgroundImage = x

        ElseIf button_no = 4 Then
            txtSecretary.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
            Dim img_path As String = member_path & lsvMemberList.SelectedItems(0).SubItems(3).Text
            Dim x As New Bitmap(img_path)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(ptbSecretary.BackgroundImage, NewSize)
            ptbSecretary.BackgroundImage = resized
            ptbSecretary.BackgroundImageLayout = ImageLayout.Stretch

            ptbSecretary.BackgroundImage = x
        End If

        Dim active_id As Integer = lsvMemberList.SelectedItems(0).Text
        Me.active_official = New Selected_Official
        Me.active_official.member.loadMember(active_id)
        Me.active_official.position = Me.o_position
        Me.setOfficial()
    End Sub

    Private Sub setOfficial()
        'check if exist
        Dim index As Integer = 1
        For Each official As Selected_Official In Me.officials
            If official.position = Me.active_official.position Then
                Me.officials.Remove(index)
                Exit For
            End If
            index = index + 1
        Next

        'save
        Me.officials.Add(active_official)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtpresident.Text = Nothing Or txtVice_president.Text = Nothing Or txtTreasurer.Text = Nothing Or txtSecretary.Text = Nothing Or txtYear.Text = Nothing Then
            MsgBox("Please make sure to set all the official before saving", MsgBoxStyle.Exclamation, "Warning")
        Else
            For Each mem As Selected_Official In Me.officials
                c.updateBurialOfOfficials(mem.member.id, mem.position, txtYear.Text)
            Next
        End If
        MsgBox("Burial Officials Successfully Save", MsgBoxStyle.Information)
        txtpresident.Clear()
        txtVice_president.Clear()
        txtTreasurer.Clear()
        txtSecretary.Clear()
        txtYear.Clear()
        ptbPresident.BackgroundImage = My.Resources.image_icon
        ptbSecretary.BackgroundImage = My.Resources.image_icon
        ptbTreasurer.BackgroundImage = My.Resources.image_icon
        ptbVicePresident.BackgroundImage = My.Resources.image_icon
        lsvMemberList.Items.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
            c.searhMemberInChurch(txtSearch.Text, lsvMemberList)
        Else
            lblSearchMember.Visible = True
            c.displayMemberForChurchOfficial(lsvMemberList)
        End If
    End Sub


    
    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        'MsgBox(Convert.ToInt32(e.KeyChar).ToString())
        If IsNumeric(e.KeyChar) Or Convert.ToInt32(e.KeyChar).ToString() = 46 Or Convert.ToInt32(e.KeyChar).ToString() = 8 Or Convert.ToInt32(e.KeyChar).ToString() = 45 Then
            e.Handled = False
        Else
            MsgBox("Year format 'yyyy-yyyy' must be a number", MsgBoxStyle.Information, "Information")
            e.Handled = True
        End If
    End Sub
End Class