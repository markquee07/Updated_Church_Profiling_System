Public Class frmPastorViewDetails
    Public p As New Pastor
    Public p_id As Integer
    Public path As String = My.Application.Info.DirectoryPath & "\pastor\"
    Public resized As Image

    Private Sub frmPastorViewDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p.displayPastorDetails(p_id)
        txtFname.Text = p.first_name
        txtLname.Text = p.last_name
        txtMname.Text = p.middle_name
        txtAddress.Text = p.address
        txtContanctNo.Text = p.concat_number
        txtgender.Text = p.gender
        txtbdate.Text = p.date_of_birth
        txtage.Text = p.age
        txtNameOfSchoolGrad.Text = p.name_of_school_grad
        txtSchoolGradAdress.Text = p.address_of_school_graduaterd
        txtyearGrad.Text = p.year_graduated
        txtyearsofService.Text = p.years_of_service
        txtExperienceSchoolAddress.Text = p.church_address
        txtExperienceSchool.Text = p.chutch_name
        Dim img_path As String = path & p.image_path
        Dim x As New Bitmap(img_path)

        Dim NewSize As New Size(128, 112)
        resized = New Bitmap(ptbImage.BackgroundImage, NewSize)
        ptbImage.BackgroundImage = resized
        ptbImage.BackgroundImageLayout = ImageLayout.Stretch

        ptbImage.BackgroundImage = x


    End Sub
End Class