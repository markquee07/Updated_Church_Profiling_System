Public Class frmOffering
    Public active_id As Integer
    Dim var As Integer = 0
    Public add As Integer = 1


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim type As String
        Dim amount As Double
        Dim new_info As Integer = 1
        If txtamount.Text = "" Or cboofferingtype.Text = Nothing Then
            MsgBox("Missing field must be filled up", MsgBoxStyle.Exclamation)
        Else
            If add = 1 Then
                Dim x As Integer = lsvAddedOfferings.Items.Count
                lsvAddedOfferings.Items.Add(cboofferingtype.Text)
                lsvAddedOfferings.Items(x).SubItems.Add(txtamount.Text)
                add = add + 1
            Else
                For Each lst As ListViewItem In lsvAddedOfferings.Items
                    type = lst.Text
                    amount = lst.SubItems(1).Text

                    If cboofferingtype.Text = type Then
                        amount = Integer.Parse(txtamount.Text) + amount
                        lst.SubItems(1).Text = amount.ToString()
                        new_info = 0
                    End If
                Next
                If new_info = 1 Then
                    Dim x As Integer = lsvAddedOfferings.Items.Count
                    lsvAddedOfferings.Items.Add(cboofferingtype.Text)
                    lsvAddedOfferings.Items(x).SubItems.Add(txtamount.Text)
                End If
            End If

        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtamount.Text = "" Or cboofferingtype.Text = Nothing Or lsvAddedOfferings.Items.Count = 0 Then
            MsgBox("Missing field must be filled up", MsgBoxStyle.Exclamation)
        Else
            Dim o As New Offering
            With o
                .offering_type = cboofferingtype.Text
                .amount = Val(txtamount.Text)
                If Trim(cboofferingtype.Text) = "" Then
                    MsgBox("Empty field")
                Else
                    For Each lst As ListViewItem In lsvAddedOfferings.Items
                        o.offering_type = lst.Text
                        o.amount = lst.SubItems(1).Text
                        .savechurchOffering()
                    Next
                    MsgBox("Offerings Saved", MsgBoxStyle.Information)
                    cboofferingtype.Text = ""
                    txtamount.Clear()
                    lsvAddedOfferings.Items.Clear()
                    '.displayListOfExpenses(lsvlistofexpenses)
                End If
            End With
        End If

    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        If IsNumeric(e.KeyChar) Or Convert.ToInt32(e.KeyChar).ToString() = 46 Or Convert.ToInt32(e.KeyChar).ToString() = 8 Then

            e.Handled = False
        Else
            MsgBox("Invalid Amount", MsgBoxStyle.Information, "Information")
            e.Handled = True
        End If
    End Sub

   
End Class