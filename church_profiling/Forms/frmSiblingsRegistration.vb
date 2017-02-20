Public Class frmSiblingsRegistration

    Public add_child As Boolean = False
    Private browse_click As Boolean = False
    Public member_brwse As Boolean = False
    Private resized As Image
    Private child_path As String = My.Application.Info.DirectoryPath & "\child\"
    Private Image_name As String
    Private extension As String
    Private ps As Integer
    Private y As Integer

    Public member_info As New Collection
    Public defaultValues As New Collection
    'Member last id
    Public mem_last_id As Integer
    'cart instantation
    Public carts As New cart
    'collection for siblings

    Public sibling_list As New Collection

    'Count variables
    Public male_count As Integer
    Public female_count As Integer

    'Adding to listview variables
    Public row As Integer
    Public siblings_id As String
    Public fname As String
    Public lname As String
    Public Mname As String
    Public birth_date As String
    Public gender As String
    Public church_member As String


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        If txtFname.Text = Nothing Or txtLname.Text = Nothing Or cboGender.Text = Nothing Or dtpBirthDate.Text = Nothing Then
            MsgBox("Missing field must be filled up", MsgBoxStyle.Exclamation)
        Else
            addToLisView()
            Me.countMaleAndFemale()
        End If

    End Sub

    Public Sub addToLisView()
        If browse_click = True Then
            Image_name = txtFname.Text & "_" & lblId.Text & extension
            System.IO.File.Copy(OpenFileDialog1.FileName, child_path & Image_name, True)
        Else
            Image_name = child_path & "image_icon.jpg"
        End If
        row = lsvSiblingsInformation.Items.Count
        lsvSiblingsInformation.Items.Add(lblId.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(txtFname.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(txtLname.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(txtMiddlename.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(dtpBirthDate.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(cboGender.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(Image_name)

        txtFname.Clear()
        txtLname.Clear()
        txtMiddlename.Clear()
        cboGender.Text = ""
        txtFname.Focus()
        ptbImage.BackgroundImage = My.Resources.image_icon
        lblGender.Visible = True
        lblBirthDate.Visible = True

    End Sub

    Public Function generatedID(ByVal len As Integer)
        Dim pool As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim rnd As New Random
        Dim result As String = ""

        Dim cc = 0
        While cc <= len
            result &= pool(rnd.Next(0, pool.Length))
            cc += 1
        End While

        Return result
    End Function

    Public Sub countMaleAndFemale()
        If cboGender.Text = "MALE" Then
            male_count = male_count + 1
            If male_count > 9 Then
                lblMaleCount.Location = New Point(118, 18)
            End If
            lblMaleCount.Text = male_count.ToString()
        Else
            female_count = female_count + 1
            If male_count > 9 Then
                lblFemaleCount.Location = New Point(321, 18)
            End If
            lblFemaleCount.Text = female_count.ToString()
        End If
    End Sub


    Private Sub lblFname_Click(sender As Object, e As EventArgs) Handles lblFname.Click
        txtFname.Focus()
    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If txtFname.Text.Length > 0 Then
            lblFname.Visible = False
        Else
            lblFname.Visible = True
        End If
    End Sub

    Private Sub lblLname_Click(sender As Object, e As EventArgs) Handles lblLname.Click
        txtLname.Focus()
    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If txtLname.Text.Length > 0 Then
            lblLname.Visible = False
        Else
            lblLname.Visible = True
        End If
    End Sub

    Private Sub lblMname_Click(sender As Object, e As EventArgs) Handles lblMname.Click
        txtMiddlename.Focus()
    End Sub

    Private Sub txtMiddlename_TextChanged(sender As Object, e As EventArgs) Handles txtMiddlename.TextChanged
        If txtMiddlename.Text.Length > 0 Then
            lblMname.Visible = False
        Else
            lblMname.Visible = True
        End If
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        lblGender.Visible = False
    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        lblBirthDate.Visible = False
    End Sub

    Private Sub frmSiblingsRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        'If frmFamilyDetails.Button2.Text = "Add New Child" Then
        '    lblId.Text = frmListOfHousehold.lsvListOfMember.SelectedItems(0).SubItems(1).Text
        'Else
        'End If

    End Sub

    Public Sub clearAllInformation()
        lsvSiblingsInformation.Items.Clear()
        lblMaleCount.Text = "0"
        lblFemaleCount.Text = "0"

        txtFname.Clear()
        txtLname.Clear()
        txtMiddlename.Clear()
        cboGender.Text = ""
        ptbImage.BackgroundImage = My.Resources.image_icon
        txtFname.Focus()
        browse_click = False
        frmMember_registration.clearMemberInformation()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If add_child = True Then
            Me.saveSiblingsInfo1()
            MsgBox("Successfully saved", MsgBoxStyle.Information)
            clearAllInformation()
            Me.Close()
            carts.displayFamilyDetails(frmFamilyDetails.lsvListOffamilydetails, mem_last_id)

        Else
            Dim mr As New frmMember_registration
            With mr
                carts.s_count = 1
                Me.saveMemberInfo()
                Me.defaultVal()
                carts.savePersonalInformation()
                GLOBAL_VARS.sibling_save = True
            End With
            Me.saveSiblingsInfo()
            MsgBox("Successfully saved", MsgBoxStyle.Information)
            Me.clearAllInformation()
            carts.displayFamilyDetails(frmFamilyDetails.lsvListOffamilydetails, mem_last_id)
            Me.Close()
        End If
       


    End Sub

    Public Sub saveSiblingsInfo()
        For Each lsv As ListViewItem In lsvSiblingsInformation.Items
            Dim x As Integer = lsvSiblingsInformation.Items.Count

            carts.s_siblings_id = lsv.Text
            carts.s_First_name = lsv.SubItems(1).Text
            carts.s_Last_name = lsv.SubItems(2).Text
            carts.s_Middle_name = lsv.SubItems(3).Text
            carts.s_Date_of_birth = lsv.SubItems(4).Text
            carts.s_Gender = lsv.SubItems(5).Text
            carts.s_image_path = lsv.SubItems(6).Text
            carts.saveSiblingsInformation(Me.mem_last_id)
        Next
    End Sub

    Public Sub saveSiblingsInfo1()
        For Each lsv As ListViewItem In lsvSiblingsInformation.Items
            Dim x As Integer = lsvSiblingsInformation.Items.Count

            carts.s_siblings_id = lsv.Text
            carts.s_First_name = lsv.SubItems(1).Text
            carts.s_Last_name = lsv.SubItems(2).Text
            carts.s_Middle_name = lsv.SubItems(3).Text
            carts.s_Date_of_birth = lsv.SubItems(4).Text
            carts.s_Gender = lsv.SubItems(5).Text
            carts.s_image_path = lsv.SubItems(6).Text
            carts.saveSiblingsInformation1(Me.mem_last_id)
        Next
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png"
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog1.FileName
            ptbImage.BackgroundImage = Image.FromFile(FileName)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(ptbImage.BackgroundImage, NewSize)
            ptbImage.BackgroundImage = resized
            ptbImage.BackgroundImageLayout = ImageLayout.Stretch

            ps = OpenFileDialog1.FileName.LastIndexOf(".")
            extension = OpenFileDialog1.FileName.Substring(ps, OpenFileDialog1.FileName.Length - ps)
        End If
        browse_click = True
    End Sub

    Private Sub saveMemberInfo()
        For Each mem As cart In member_info
            With carts
                .image_path = mem.image_path
                .Member_id = mem.Member_id
                .First_name = mem.First_name
                .Last_name = mem.Last_name
                .Middle_name = mem.Middle_name
                .Gender = mem.Gender
                .Date_of_birth = mem.Date_of_birth
                .Blood_type = mem.Blood_type
                .Contact_no = mem.Contact_no
                .Email_ad = mem.Email_ad
                .Province = mem.Province
                .City = mem.City
                .Barangay = mem.Barangay
                .Church_name = mem.Church_name
                .Pastor_name = mem.Pastor_name
                .Baptized_date = mem.Baptized_date
                .Course_graduated = mem.Course_graduated
                .Name_of_school_graduated = mem.Name_of_school_graduated
                .License_specification = mem.License_specification
                .Work_address = mem.Work_address
                .Nature_of_work = mem.Nature_of_work
                .Name_of_company = mem.Name_of_company
                .Salary = mem.Salary
                .Self_employed = mem.Self_employed
                .Business_address = mem.Business_address
                .Estimated_annual_income = mem.Estimated_annual_income
                .Name_of_business = mem.Name_of_business

            End With
        Next

    End Sub

    Private Sub defaultVal()
        For Each mem As cart In defaultValues
            With carts
                .Contact_no = mem.Contact_no
                .Email_ad = mem.Email_ad
                .Course_graduated = mem.Course_graduated
                .Name_of_school_graduated = mem.Name_of_school_graduated
                .Licensure_passer = mem.Licensure_passer
                .License_specification = mem.License_specification
                .Work_address = mem.Work_address
                .Nature_of_work = mem.Nature_of_work
                .Name_of_business = mem.Name_of_business
                .Name_of_company = mem.Name_of_company
                .Business_address = mem.Business_address
                .Self_employed = mem.Self_employed
            End With
        Next

    End Sub
End Class