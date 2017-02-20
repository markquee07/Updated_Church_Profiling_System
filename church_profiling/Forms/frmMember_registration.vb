
Public Class frmMember_registration
    Public m_id As Integer
    Public member_path As String = My.Application.Info.DirectoryPath & "\members\"
    Private resized As Image
    Public image_name As String
    Public brwse_click As Boolean = False
    Private extension As String
    Private ps As Integer
    Private member As New Collection
    Private defaultInfo As New Collection

    Public c As New cart
    Public cart_id As cart

    Private Sub frmMember_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btnSave.Text = "Update" Then
            c.displayMemberDetails(m_id)
            With Me

                Dim img_path As String = member_path & c.image_path
                Dim y As New Bitmap(img_path)

                Dim NewSize As New Size(128, 112)
                resized = New Bitmap(rectangle.BackgroundImage, NewSize)
                rectangle.BackgroundImage = resized
                rectangle.BackgroundImageLayout = ImageLayout.Stretch

                rectangle.BackgroundImage = y

                .ID.Text = c.Member_id
                .txtFname.Text = c.First_name
                .txtLname.Text = c.Last_name
                .txtMname.Text = c.Middle_name
                .cboGender.Text = c.Gender
                .dtpDateofbirth.Text = c.Date_of_birth
                .cboBloodType.Text = c.Blood_type
                .txtContactNo.Text = c.Contact_no
                .txtEmail.Text = c.Email_ad
                .txtprovince.Text = c.Province
                .txtCity.Text = c.City
                .txtBarangay.Text = c.Barangay
                .txtChurchName.Text = c.Church_name
                .txtPastorName.Text = c.Pastor_name


                If c.Baptized_date <> "" Then
                    cbBaptizedYes.Checked = True
                    dtpDateBaptize.Enabled = True
                Else
                    cbBaptizedNo.Checked = True
                End If
                .dtpDateBaptize.Text = c.Baptized_date



                If c.Course_graduated = "None" Then
                    cbNone.Checked = True
                    txtCourseGrad.Text = c.Course_graduated
                    txtSchoolGrad.Text = c.Name_of_school_graduated
                ElseIf c.Course_graduated = "Elementary" Then
                    txtCourseGrad.Text = c.Course_graduated
                    txtSchoolGrad.Text = c.Name_of_school_graduated
                    cbElementary.Checked = True
                ElseIf c.Course_graduated = "College" Then
                    txtCourseGrad.Text = c.Course_graduated
                    txtSchoolGrad.Text = c.Name_of_school_graduated
                    cbCollege.Checked = True
                ElseIf c.Course_graduated = "Masters" Then
                    txtCourseGrad.Text = c.Course_graduated
                    txtSchoolGrad.Text = c.Name_of_school_graduated
                    cbMasters.Checked = True
                ElseIf c.Course_graduated = "High School" Then
                    txtCourseGrad.Text = c.Course_graduated
                    txtSchoolGrad.Text = c.Name_of_school_graduated
                    cbHighSchool.Checked = True
                ElseIf c.Course_graduated = "PhD" Then
                    txtCourseGrad.Text = c.Course_graduated
                    txtSchoolGrad.Text = c.Name_of_school_graduated
                    cbPhD.Checked = True
                End If



                If c.License_specification <> "No" Then
                    .txtSpecify.Text = c.License_specification
                    cbLicenseYES.Checked = True
                    cbBaptizedYes.Enabled = False
                Else
                    .txtSpecify.Text = c.Licensure_passer
                    .cbLicenseNo.Checked = True
                    cbBaptizedNo.Enabled = False
                End If


                .dtpMarriedDate.Text = c.Marriage_date
                If c.Marriage_date <> "" Then
                    cbMarried.Checked = True
                Else
                    If c.Civil_status = "Single" Then
                        cbSingle.Checked = True
                    ElseIf c.Civil_status = "Widow" Then
                        cbWidow.Checked = True
                    ElseIf c.Civil_status = "Divorce" Then
                        cbDivorce.Checked = True
                    Else
                    End If
                End If
                If c.Nature_of_work = Nothing Then
                    txtNatureofwork.Text = c.Nature_of_work
                Else
                    txtNatureofwork.Text = c.Nature_of_work
                End If

                txtNameofcomp.Text = c.Name_of_company
                txtSalary.Text = c.Salary
                txtSelfEmplyed.Text = c.Self_employed
                txtBusinessAddress.Text = c.Business_address
                txtEstimatedIncome.Text = c.Estimated_annual_income
                If c.Nature_of_work = Nothing Then
                    txtNameOfBusiness.Text = c.Name_of_business
                Else
                    txtNameOfBusiness.Text = c.Name_of_business
                End If
                If c.Work_status = "None" Then
                    cbWorkNo.Checked =
                        txtWorkAddress.Text = c.Work_address
                Else
                    cbWorkYEs.Checked = True
                    txtWorkAddress.Text = c.Work_address
                End If
            End With
        Else
            ID.Text = generatedID(8)
            dtpMarriedDate.Enabled = False
            txtWorkAddress.Enabled = False
            txtSpecify.Enabled = False
            dtpDateBaptize.Enabled = False

            txtSchoolGrad.Enabled = False
            txtSpecify.Enabled = False
            txtCourseGrad.Enabled = False
            cbLicenseYES.Enabled = False
            cbLicenseNo.Enabled = False

            txtNatureofwork.Enabled = False
            txtNameofcomp.Enabled = False
            txtSalary.Enabled = False
        End If


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

    Private Sub cbBaptizedYes_Click(sender As Object, e As EventArgs) Handles cbBaptizedYes.Click
        dtpDateBaptize.Enabled = True
        c.Baptized_status = "Yes"
        cbBaptizedNo.Checked = False
    End Sub

    Private Sub cbBaptizedNo_Click(sender As Object, e As EventArgs) Handles cbBaptizedNo.Click
        c.Baptized_status = "No"
        dtpDateBaptize.Enabled = False
        cbBaptizedYes.Checked = False
    End Sub

    Private Sub cbNone_Click(sender As Object, e As EventArgs) Handles cbNone.Click
        If cbNone.Checked = True Then
            c.HEA = "None"
        End If
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = False
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseYES.Enabled = False
    End Sub

    Private Sub cbMasters_Click(sender As Object, e As EventArgs) Handles cbMasters.Click
        If cbMasters.Checked = True Then
            c.HEA = "Masters"
        End If
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbNone.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = True
        cbLicenseYES.Enabled = True
        cbLicenseNo.Enabled = True
    End Sub

    Private Sub cbElementary_Click(sender As Object, e As EventArgs) Handles cbElementary.Click
        If cbElementary.Checked = True Then
            c.HEA = "Elementary"
        End If
        cbCollege.Checked = False
        cbNone.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False
    End Sub

    Private Sub cbHighSchool_Click(sender As Object, e As EventArgs) Handles cbHighSchool.Click
        If cbHighSchool.Checked = True Then
            c.HEA = "High School"
        End If
        c.HEA = "High School"
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbNone.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False
    End Sub

    Private Sub cbCollege_Click(sender As Object, e As EventArgs) Handles cbCollege.Click
        If cbCollege.Checked = True Then
            c.HEA = "College"
        End If
        cbNone.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = True
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False
    End Sub

    Private Sub cbPhD_Click(sender As Object, e As EventArgs) Handles cbPhD.Click
        If cbPhD.Checked = True Then
            c.HEA = "PhD"
        End If
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbNone.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = True
        cbLicenseYES.Enabled = True
        cbLicenseNo.Enabled = True
    End Sub

    Private Sub cbLicenseYES_Click(sender As Object, e As EventArgs) Handles cbLicenseYES.Click
        txtSpecify.Enabled = True
        c.Licensure_passer = "Yes"
        cbLicenseNo.Checked = False
    End Sub

    Private Sub cbLicenseNo_Click(sender As Object, e As EventArgs) Handles cbLicenseNo.Click
        txtSpecify.Clear()
        txtSpecify.Enabled = False
        c.Licensure_passer = "No"
        cbLicenseYES.Checked = False
    End Sub

    Private Sub cbWorkYEs_Click(sender As Object, e As EventArgs) Handles cbWorkYEs.Click
        c.Work_status = "Yes"
        txtWorkAddress.Enabled = True
        cbWorkNo.Checked = False

        txtNatureofwork.Enabled = True
        txtNameofcomp.Enabled = True
        txtSalary.Enabled = True
    End Sub

    Private Sub cbWorkNo_Click(sender As Object, e As EventArgs) Handles cbWorkNo.Click
        txtWorkAddress.Clear()
        txtWorkAddress.Enabled = False
        c.Work_status = "No"
        cbWorkYEs.Checked = False

        txtNatureofwork.Enabled = False
        txtNameofcomp.Enabled = False
        txtSalary.Enabled = False
    End Sub

    Private Sub cbSingle_Click(sender As Object, e As EventArgs) Handles cbSingle.Click
        If cbSingle.Checked = True Then
            c.Civil_status = "Single"
        End If
        cbWidow.Checked = False
        cbDivorce.Checked = False
        cbMarried.Checked = False
    End Sub

    Private Sub cbMarried_Click(sender As Object, e As EventArgs) Handles cbMarried.Click
        dtpMarriedDate.Enabled = True
        If cbMarried.Checked Then
            c.Civil_status = "Married"
        End If
        cbWidow.Checked = False
        cbDivorce.Checked = False
        cbSingle.Checked = False
    End Sub

    Private Sub cbWidow_Click(sender As Object, e As EventArgs) Handles cbWidow.Click
        If cbWidow.Checked = True Then
            c.Civil_status = "Widow"
        End If
        cbSingle.Checked = False
        cbDivorce.Checked = False
        cbMarried.Checked = False
    End Sub

    Private Sub cbDivorce_Click(sender As Object, e As EventArgs) Handles cbDivorce.Click
        If cbDivorce.Checked = True Then
            c.Civil_status = "Divorce"
        End If
        cbWidow.Checked = False
        cbSingle.Checked = False
        cbMarried.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With c
            If brwse_click = True Then
                image_name = ID.Text & extension

            Else
                image_name = "image_icon.jpg"
            End If
            .image_path = image_name
            .Member_id = ID.Text
            .First_name = txtFname.Text
            .Last_name = txtLname.Text
            .Middle_name = txtMname.Text
            .Gender = cboGender.Text
            .Date_of_birth = dtpDateofbirth.Text
            .Blood_type = cboBloodType.Text
            .Contact_no = txtContactNo.Text
            .Email_ad = txtEmail.Text
            .Province = txtprovince.Text
            .City = txtCity.Text
            .Barangay = txtBarangay.Text
            .Church_name = txtChurchName.Text
            .Pastor_name = txtPastorName.Text
            .Baptized_date = dtpDateBaptize.Text
            .Course_graduated = txtCourseGrad.Text
            .Name_of_school_graduated = txtSchoolGrad.Text
            .License_specification = txtSpecify.Text
            .Work_address = txtWorkAddress.Text
            .Nature_of_work = txtNatureofwork.Text
            .Name_of_company = txtNameofcomp.Text
            .Salary = txtSalary.Text
            .Self_employed = txtSelfEmplyed.Text
            .Business_address = txtBusinessAddress.Text
            .Estimated_annual_income = txtEstimatedIncome.Text
            .Name_of_business = txtNameOfBusiness.Text
            If cbNone.Checked = True Then
                .HEA = "None"
            ElseIf cbElementary.Checked = True Then
                .HEA = "Elementary"
            ElseIf cbHighSchool.Checked = True Then
                .HEA = "High School"
            ElseIf cbMasters.Checked = True Then
                .HEA = "Masters"
            ElseIf cbPhD.Checked = True Then
                .HEA = "PhD"
            ElseIf cbCollege.Checked = True Then
                .HEA = "College"
            End If

            If cbSingle.Checked = True Then
                .Civil_status = "Single"
            ElseIf cbMarried.Checked = True Then
                .Civil_status = "Married"
            ElseIf cbWidow.Checked = True Then
                .Civil_status = "Widow"
            ElseIf cbDivorce.Checked = True Then
                .Civil_status = "Divorce"
            End If
            member.Add(c)
            Me.checkRequiredField()
        End With
    End Sub

    Public Sub uncheckedHEA()
        If cbNone.Checked = False Or cbElementary.Checked = False Or cbHighSchool.Checked = False Or cbCollege.Checked = False Or cbMasters.Checked = False Or cbPhD.Checked = False Then
            txtSchoolGrad.Enabled = False
            txtSpecify.Enabled = False
            txtCourseGrad.Enabled = False
            cbLicenseYES.Enabled = False
            cbLicenseNo.Enabled = False
        End If
    End Sub

   
    Public Sub checkRequiredField()
        If txtFname.Text = Nothing Or txtLname.Text = Nothing Or cboGender.Text = "" Or cboBloodType.Text = "" Or txtBarangay.Text = Nothing Or txtChurchName.Text = Nothing Or txtPastorName.Text = Nothing Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbBaptizedYes.Checked = False And cbBaptizedNo.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbNone.Checked = False And cbElementary.Checked = False And cbHighSchool.Checked = False And cbCollege.Checked = False And cbMasters.Checked = False And cbPhD.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbWorkNo.Checked = False And cbWorkYEs.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbSingle.Checked = False And cbMarried.Checked = False And cbDivorce.Checked = False And cbWidow.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        Else
            If btnSave.Text = "PROCEED" Then
                Dim d As DialogResult = MsgBox("Do you have children?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
                Dim sr As New frmSiblingsRegistration
                If d = MsgBoxResult.Yes Then
                    defualtValue()
                    If brwse_click = True Then
                        System.IO.File.Copy(OpenFileDialog1.FileName, member_path & c.image_path, True)
                    End If
                    With sr
                        .lblId.Text = ID.Text
                        .mem_last_id = c.member_last_id
                        .member_info = member
                        .defaultValues = defaultInfo
                        .member_brwse = brwse_click
                        .ShowDialog()
                        If GLOBAL_VARS.sibling_save = True Then
                            Me.clearMemberInformation()
                            GLOBAL_VARS.sibling_save = False
                        End If
                    End With
                Else
                    If brwse_click = True Then
                        System.IO.File.Copy(OpenFileDialog1.FileName, member_path & image_name, True)
                    End If
                    Me.defualtValue()
                    c.savePersonalInformation()
                    MsgBox("Information Successfully Saved", MsgBoxStyle.Information)
                    Me.clearMemberInformation()
                End If
            Else
                c.updateMember(m_id)
                c.displayMemberInformation(frmListOfHousehold.lsvListOfMember)
                Me.clearMemberInformation()

            End If

        End If
    End Sub
    Public Sub clearMemberInformation()
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        cboGender.Text = "Select"
        cboBloodType.Text = "Select"
        txtContactNo.Clear()
        txtEmail.Clear()
        txtprovince.Clear()
        txtCity.Clear()
        txtBarangay.Clear()
        txtChurchName.Clear()
        txtPastorName.Clear()
        cbBaptizedNo.Checked = False
        cbBaptizedYes.Checked = False
        cbNone.Checked = False
        cbElementary.Checked = False
        cbCollege.Checked = False
        cbMasters.Checked = False
        cbHighSchool.Checked = False
        cbPhD.Checked = False
        txtCourseGrad.Clear()
        txtSchoolGrad.Clear()
        cbLicenseNo.Checked = False
        cbLicenseYES.Checked = False
        txtSpecify.Clear()
        cbWorkYEs.Checked = False
        cbWorkNo.Checked = False
        txtNatureofwork.Clear()
        txtNameofcomp.Clear()
        txtSalary.Text = "0"
        txtSelfEmplyed.Clear()
        txtBusinessAddress.Clear()
        txtEstimatedIncome.Text = "0"
        txtNameOfBusiness.Clear()
        cbMarried.Checked = False
        cbSingle.Checked = False
        cbWidow.Checked = False
        cbDivorce.Checked = False
        cboGender.Text = "Select"
        cboBloodType.Text = "Select"
        rectangle.BackgroundImage = My.Resources.image_icon
        ID.Text = generatedID(8)
        brwse_click = False
    End Sub

    Public Sub defualtValue()
        If txtContactNo.Text = Nothing Then
            c.Contact_no = "None"
        End If
        If txtEmail.Text = Nothing Then
            c.Email_ad = "None"
        End If
        If txtCourseGrad.Text = Nothing Then
            c.Course_graduated = "None"
        End If
        If txtSchoolGrad.Text = Nothing Then
            c.Name_of_school_graduated = "None"
        End If
        If cbLicenseNo.Checked = False And cbLicenseYES.Checked = False Then
            c.Licensure_passer = "No"
        End If
        If txtSpecify.Text = Nothing Then
            c.License_specification = "None"
        End If
        If txtWorkAddress.Text = Nothing Then
            c.Work_address = "None"
        End If
        If txtNatureofwork.Text = Nothing Then
            c.Nature_of_work = "None"
        End If
        If txtNameOfBusiness.Text = Nothing Then
            c.Name_of_business = "None"
        End If
        If txtNameofcomp.Text = Nothing Then
            c.Name_of_company = "None"
        End If
        If txtBusinessAddress.Text = Nothing Then
            c.Business_address = "None"
        End If
        If cbBaptizedNo.Checked = True Then
            'c.Baptized_date = "0000-00-00"
        End If
        If cbMarried.Checked = False Then
            'c.Marriage_date = "0000-00-00"
        End If

        If txtSelfEmplyed.Text = Nothing Then
            c.Self_employed = "None"
        End If
        defaultInfo.Add(c)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png"
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog1.FileName
            rectangle.BackgroundImage = Image.FromFile(FileName)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(rectangle.BackgroundImage, NewSize)
            rectangle.BackgroundImage = resized
            rectangle.BackgroundImageLayout = ImageLayout.Stretch

            ps = OpenFileDialog1.FileName.LastIndexOf(".")
            extension = OpenFileDialog1.FileName.Substring(ps, OpenFileDialog1.FileName.Length - ps)
        End If
        brwse_click = True

    End Sub

    Private Sub frmMember_registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub txtNameOfBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameOfBusiness.KeyPress
        If Convert.ToInt32(e.KeyChar).ToString() = "13" Then
            With c

                .Member_id = ID.Text
                .First_name = txtFname.Text
                .Last_name = txtLname.Text
                .Middle_name = txtMname.Text
                .Gender = cboGender.Text
                .Date_of_birth = dtpDateofbirth.Text
                .Blood_type = cboBloodType.Text
                .Contact_no = txtContactNo.Text
                .Email_ad = txtEmail.Text
                .Province = txtprovince.Text
                .City = txtCity.Text
                .Barangay = txtBarangay.Text
                .Church_name = txtChurchName.Text
                .Pastor_name = txtPastorName.Text
                .Baptized_date = dtpDateBaptize.Text
                .Course_graduated = txtCourseGrad.Text
                .Name_of_school_graduated = txtSchoolGrad.Text
                .License_specification = txtSpecify.Text
                .Work_address = txtWorkAddress.Text
                .Nature_of_work = txtNatureofwork.Text
                .Name_of_company = txtNameofcomp.Text
                .Salary = txtSalary.Text
                .Self_employed = txtSelfEmplyed.Text
                .Business_address = txtBusinessAddress.Text
                .Estimated_annual_income = txtEstimatedIncome.Text
                .Name_of_business = txtNameOfBusiness.Text
                Me.checkRequiredField()
            End With
        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If IsNumeric(e.KeyChar) Or Convert.ToInt32(e.KeyChar).ToString() = 46 Or Convert.ToInt32(e.KeyChar).ToString() = 8 Then
            e.Handled = False
        Else
            MsgBox("Please Enter number  only ", MsgBoxStyle.Information, "Information")
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstimatedIncome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstimatedIncome.KeyPress
        If IsNumeric(e.KeyChar) Or Convert.ToInt32(e.KeyChar).ToString() = 46 Or Convert.ToInt32(e.KeyChar).ToString() = 8 Then

            e.Handled = False
        Else
            MsgBox("Please Enter number  only ", MsgBoxStyle.Information, "Information")
            e.Handled = True
        End If
    End Sub

    Private Sub txtMname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            MsgBox("Please Enter Alphabates  only ", MsgBoxStyle.Information, "Information")
            e.Handled = True
        End If

    End Sub
End Class
