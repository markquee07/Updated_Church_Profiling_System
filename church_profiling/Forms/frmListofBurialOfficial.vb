Public Class frmListofBurialOfficial
    Public ch As New Church
    Public c As New cart
    Public cho_id As Integer
    Public buo_id As Integer
    Public church_off As Boolean = False

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
            c.searchBurialOfficial(lsvBurialOfficial, txtSearch.Text)
            ch.searchChurchofficial(lsvChurchOfficial, txtSearch.Text)
        Else

            lblSearchMember.Visible = True
            c.displayBurialOfficial(lsvBurialOfficial)
            ch.loadchurchofficial(lsvChurchOfficial)
        End If
    End Sub

    Private Sub frmListofBurialOfficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ch.loadchurchofficial(lsvChurchOfficial)
        c.displayBurialOfficial(lsvBurialOfficial)
    End Sub

    Private Sub lsvBurialOfficial_Click(sender As Object, e As EventArgs) Handles lsvBurialOfficial.Click
        buo_id = lsvBurialOfficial.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub lsvChurchOfficial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvChurchOfficial.SelectedIndexChanged

    End Sub

    Private Sub lsvChurchOfficial_Click(sender As Object, e As EventArgs) Handles lsvChurchOfficial.Click
        cho_id = lsvChurchOfficial.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If church_off = True Then
            Dim aco As New frmActiveChurchOfficial
            aco.ShowDialog()
        Else
            Dim abo As New frmActiveBurialOfficials
            abo.ShowDialog()
        End If
    End Sub
End Class