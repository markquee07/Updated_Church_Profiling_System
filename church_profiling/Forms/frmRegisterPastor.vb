Public Class frmRegisterPastor

    Dim p As String = My.Application.Info.DirectoryPath & "\pastor\"
    Public brwse_click As Boolean = False
    Public c As New cart
    Public school_grad As Integer
    Public church_exp As Integer
    Dim resized As Image
    Private extension As String
    Private ps As Integer


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtFname.Text = Nothing Or txtLname.Text = Nothing Or txtMname.Text = Nothing Or txtAddress.Text = Nothing Or cboGender.Text = "" Or txtContanctNo.Text = Nothing Then
            MsgBox("Please make sure to fill-up all the requried fields", MsgBoxStyle.Exclamation, "Warning")
        ElseIf cbExperienceNo.Checked = False And cbExperienceYes.Checked = False Then
            MsgBox("Please make sure to fill-up all the requried fields", MsgBoxStyle.Exclamation, "Warning")
        ElseIf cbGradNo.Checked = False And cbGradYes.Checked = False Then
            MsgBox("Please make sure to fill-up all the requried fields", MsgBoxStyle.Exclamation, "Warning")
        Else

            With c
                Dim image_name As String
                If brwse_click = True Then
                    image_name = txtFname.Text & extension
                    System.IO.File.Copy(OpenFileDialog1.FileName, p & image_name, True)
                Else
                    image_name = "image_icon.jpg"
                End If

                If school_grad = 1 Then
                    .p_name_of_school_grad = txtNameOfSchoolGrad.Text
                    .p_address_of_school_grad = txtSchoolGradAdress.Text
                    .p_year_grad = txtyearGrad.Text
                End If
                If church_exp = 1 Then
                    .p_name_of_church = txtExperienceSchool.Text
                    .p_address_of_church = txtExperienceSchoolAddress.Text
                    .p_year_of_service = txtyearsofService.Text
                End If
                .p_pastor_id = lblId.Text
                .p_first_name = txtFname.Text
                .p_last_name = txtLname.Text
                .p_middle_name = txtMname.Text
                .p_address = txtAddress.Text
                .p_gender = cboGender.Text
                .p_contact_no = txtContanctNo.Text
                .p_date_of_birth = dtpBirthDate.Text
                .p_image_path = image_name
                .savePastorMember()
                txtFname.Clear()
                txtLname.Clear()
                txtMname.Clear()
                txtAddress.Clear()
                txtContanctNo.Clear()
                cbExperienceYes.Checked = False
                cbExperienceNo.Checked = False
                cbGradYes.Checked = False
                cbGradNo.Checked = False
                txtSchoolGradAdress.Clear()
                txtNameOfSchoolGrad.Clear()
                txtyearGrad.Clear()
                txtyearsofService.Clear()
                txtExperienceSchool.Clear()
                txtExperienceSchoolAddress.Clear()
                lblGender.Visible = True
                lblBirthDate.Visible = True
                ptbImage.BackgroundImage = My.Resources.image_icon
                lblId.Text = generatedID(8)
                txtFname.Select()
            End With
        End If

    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If txtFname.Text.Length > 0 Then
            lblFname.Visible = False
        Else
            lblFname.Visible = True
        End If
    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If txtLname.Text.Length > 0 Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub txtMname_TextChanged(sender As Object, e As EventArgs) Handles txtMname.TextChanged
        If txtMname.Text.Length > 0 Then
            Label2.Visible = False
        Else
            Label2.Visible = True
        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        If txtAddress.Text.Length > 0 Then
            Label5.Visible = False
        Else
            Label5.Visible = True
        End If
    End Sub

    Private Sub cboGender_Click(sender As Object, e As EventArgs) Handles cboGender.Click
        lblGender.Visible = False
    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        lblBirthDate.Visible = False
    End Sub

    Private Sub txtContanctNo_TextChanged(sender As Object, e As EventArgs) Handles txtContanctNo.TextChanged
        If txtContanctNo.Text.Length > 0 Then
            Label3.Visible = False
        Else
            Label3.Visible = True
        End If
    End Sub

    Private Sub txtNameOfSchoolGrad_TextChanged(sender As Object, e As EventArgs) Handles txtNameOfSchoolGrad.TextChanged
        If txtNameOfSchoolGrad.Text.Length > 0 Then
            Label6.Visible = False
        Else
            Label6.Visible = True
        End If
    End Sub

    Private Sub txtSchoolGradAdress_TextChanged(sender As Object, e As EventArgs) Handles txtSchoolGradAdress.TextChanged
        If txtSchoolGradAdress.Text.Length > 0 Then
            Label8.Visible = False
        Else
            Label8.Visible = True
        End If
    End Sub

    Private Sub txtyearGrad_TextChanged(sender As Object, e As EventArgs) Handles txtyearGrad.TextChanged
        If txtyearGrad.Text.Length > 0 Then
            Label7.Visible = False
        Else
            Label7.Visible = True
        End If
    End Sub

    Private Sub txtExperienceSchool_TextChanged(sender As Object, e As EventArgs) Handles txtExperienceSchool.TextChanged
        If txtExperienceSchool.Text.Length > 0 Then
            Label12.Visible = False
        Else
            Label12.Visible = True
        End If
    End Sub

    Private Sub txtExperienceSchoolAddress_TextChanged(sender As Object, e As EventArgs) Handles txtExperienceSchoolAddress.TextChanged
        If txtExperienceSchoolAddress.Text.Length > 0 Then
            Label10.Visible = False
        Else
            Label10.Visible = True
        End If
    End Sub

    Private Sub txtyearsofService_TextChanged(sender As Object, e As EventArgs) Handles txtyearsofService.TextChanged
        If txtyearsofService.Text.Length > 0 Then
            Label11.Visible = False
        Else
            Label11.Visible = True
        End If
    End Sub

    Private Sub cbGradYes_Click(sender As Object, e As EventArgs) Handles cbGradYes.Click
        If cbGradYes.Checked = True Then
            cbGradYes.Checked = True
            cbGradNo.Checked = False
            school_grad = 1
            With c
                .p_name_of_school_grad = txtNameOfSchoolGrad.Text
                .p_address_of_school_grad = txtSchoolGradAdress.Text
                .p_year_grad = txtyearGrad.Text
            End With

            txtNameOfSchoolGrad.Enabled = True
            txtSchoolGradAdress.Enabled = True
            txtyearGrad.Enabled = True
        Else
            cbGradYes.Checked = False
            cbGradNo.Checked = True

            txtNameOfSchoolGrad.Enabled = False
            txtSchoolGradAdress.Enabled = False
            txtyearGrad.Enabled = False

            With c
                .p_name_of_school_grad = "None"
                .p_address_of_school_grad = "None"
                .p_year_grad = "None"
            End With

            txtNameOfSchoolGrad.Clear()
            txtSchoolGradAdress.Clear()
            txtyearGrad.Clear()
        End If
    End Sub

    Private Sub cbGradNo_Click(sender As Object, e As EventArgs) Handles cbGradNo.Click
        If cbGradNo.Checked = True Then
            cbGradNo.Checked = True
            cbGradYes.Checked = False
            school_grad = 0
            txtNameOfSchoolGrad.Enabled = False
            txtSchoolGradAdress.Enabled = False
            txtyearGrad.Enabled = False

            With c
                .p_name_of_school_grad = "None"
                .p_address_of_school_grad = "None"
                .p_year_grad = "None"
            End With

            txtNameOfSchoolGrad.Clear()
            txtSchoolGradAdress.Clear()
            txtyearGrad.Clear()
        Else
            cbGradNo.Checked = False
            cbGradYes.Checked = True

            With c
                .p_name_of_school_grad = txtNameOfSchoolGrad.Text
                .p_address_of_school_grad = txtSchoolGradAdress.Text
                .p_year_grad = txtyearGrad.Text
            End With

            txtNameOfSchoolGrad.Enabled = True
            txtSchoolGradAdress.Enabled = True
            txtyearGrad.Enabled = True
        End If
    End Sub

    Private Sub frmRegisterPastor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = generatedID(8)
        txtNameOfSchoolGrad.Enabled = False
        txtSchoolGradAdress.Enabled = False
        txtyearGrad.Enabled = False

        txtExperienceSchool.Enabled = False
        txtExperienceSchoolAddress.Enabled = False
        txtyearsofService.Enabled = False
    End Sub

    Private Sub cbExperienceYes_Click(sender As Object, e As EventArgs) Handles cbExperienceYes.Click
        If cbExperienceYes.Checked = True Then
            cbExperienceYes.Checked = True
            cbExperienceNo.Checked = False

            church_exp = 1
            With c
                .p_name_of_church = txtExperienceSchool.Text
                .p_address_of_church = txtExperienceSchoolAddress.Text
                .p_year_of_service = txtyearsofService.Text
            End With

            txtExperienceSchool.Enabled = True
            txtExperienceSchoolAddress.Enabled = True
            txtyearsofService.Enabled = True
        Else
            cbExperienceYes.Checked = False
            cbExperienceNo.Checked = True

            txtExperienceSchool.Enabled = False
            txtExperienceSchoolAddress.Enabled = False
            txtyearsofService.Enabled = False

            With c
                .p_name_of_church = "None"
                .p_address_of_church = "None"
                .p_year_of_service = "None"
            End With

            txtExperienceSchool.Clear()
            txtExperienceSchoolAddress.Clear()
            txtyearsofService.Clear()
        End If
    End Sub


    Private Sub cbExperienceNo_Click(sender As Object, e As EventArgs) Handles cbExperienceNo.Click
        If cbExperienceNo.Checked = True Then
            cbExperienceNo.Checked = True
            cbExperienceYes.Checked = False
            church_exp = 0
            txtExperienceSchool.Enabled = False
            txtExperienceSchoolAddress.Enabled = False
            txtyearsofService.Enabled = False
            With c
                .p_name_of_church = "None"
                .p_address_of_church = "None"
                .p_year_of_service = "None"
            End With

            txtExperienceSchool.Clear()
            txtExperienceSchoolAddress.Clear()
            txtyearsofService.Clear()
        Else
            cbExperienceNo.Checked = False
            cbExperienceYes.Checked = True

            With c
                .p_name_of_church = txtExperienceSchool.Text
                .p_address_of_church = txtExperienceSchoolAddress.Text
                .p_year_of_service = txtyearsofService.Text
            End With

            txtExperienceSchool.Enabled = True
            txtExperienceSchoolAddress.Enabled = True
            txtyearsofService.Enabled = True
        End If
    End Sub

    Private Sub frmRegisterPastor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        txtAddress.Clear()
        txtContanctNo.Clear()
        cbExperienceYes.Checked = False
        cbExperienceNo.Checked = False
        cbGradYes.Checked = False
        cbGradNo.Checked = False
        txtSchoolGradAdress.Clear()
        txtNameOfSchoolGrad.Clear()
        txtyearGrad.Clear()
        txtyearsofService.Clear()
        txtExperienceSchool.Clear()
        txtExperienceSchoolAddress.Clear()
        lblGender.Visible = True
        lblBirthDate.Visible = True
        txtFname.Select()
        ptbImage.BackgroundImage = My.Resources.image_icon
        lblId.Text = generatedID(8)
        brwse_click = False
    End Sub

    Private Sub lblFname_Click(sender As Object, e As EventArgs) Handles lblFname.Click
        txtFname.Select()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        txtLname.Select()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        txtMname.Select()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtAddress.Select()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txtContanctNo.Select()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        txtNameOfSchoolGrad.Select()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        txtSchoolGradAdress.Select()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        txtyearGrad.Select()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        txtExperienceSchool.Select()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        txtExperienceSchoolAddress.Select()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        txtyearsofService.Select()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim dialog As DialogResult = MsgBox("Are you sure you want to clear all the Information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Clear Information")

        If dialog = MsgBoxResult.Yes Then
            txtFname.Clear()
            txtLname.Clear()
            txtMname.Clear()
            txtAddress.Clear()
            txtContanctNo.Clear()
            cbExperienceYes.Checked = False
            cbExperienceNo.Checked = False
            cbGradYes.Checked = False
            cbGradNo.Checked = False
            txtSchoolGradAdress.Clear()
            txtNameOfSchoolGrad.Clear()
            txtyearGrad.Clear()
            txtyearsofService.Clear()
            txtExperienceSchool.Clear()
            txtExperienceSchoolAddress.Clear()
            lblGender.Visible = True
            lblBirthDate.Visible = True
            ptbImage.BackgroundImage = My.Resources.image_icon
            txtFname.Select()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
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
        brwse_click = True
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
End Class