Public Class frmFamilyDetails
    Public c As New cart()
    Public prt As Integer
    Public x As Integer
    Public m_id As String

    Public path As String = My.Application.Info.DirectoryPath & "\child\"
    Public resized As Image

    Private Sub frmFamilyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.displayFamilyDetails(lsvListOffamilydetails, frmListOfHousehold.p_id2)
        'prt = c.id
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sr As New frmSiblingsRegistration
        With sr
            .add_child = True
            .lblId.Text = m_id
            .mem_last_id = prt
            .ShowDialog()
        End With
    End Sub

    Private Sub lsvListOffamilydetails_Click(sender As Object, e As EventArgs) Handles lsvListOffamilydetails.Click
        x = lsvListOffamilydetails.SelectedItems.Count
        If x <= 0 Then

        Else

            lblID.Text = lsvListOffamilydetails.SelectedItems(0).SubItems(1).Text
            lblFname.Text = lsvListOffamilydetails.SelectedItems(0).SubItems(2).Text
            lblLname.Text = lsvListOffamilydetails.SelectedItems(0).SubItems(3).Text
            lblMname.Text = lsvListOffamilydetails.SelectedItems(0).SubItems(4).Text
            lblDob.Text = lsvListOffamilydetails.SelectedItems(0).SubItems(5).Text
            lblGender.Text = lsvListOffamilydetails.SelectedItems(0).SubItems(6).Text

            Dim img_path As String = path & lsvListOffamilydetails.SelectedItems(0).SubItems(7).Text
            Dim y As New Bitmap(img_path)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(rectangle.BackgroundImage, NewSize)
            rectangle.BackgroundImage = resized
            rectangle.BackgroundImageLayout = ImageLayout.Stretch

            rectangle.BackgroundImage = y
        End If

    End Sub

End Class