Public Class Handpacked
    Private Sub HandpackedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HandpackedBindingNavigatorSaveItem.Click
        Me.HandpackedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBPROJECTDataSet)

    End Sub

    Private Sub Handpacked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBPROJECTDataSet.Handpacked' table. You can move, or remove it, as needed.
        Me.HandpackedTableAdapter.Fill(Me.VBPROJECTDataSet.Handpacked)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        HandpackedBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        On Error GoTo SaveErr
        HandpackedBindingSource.EndEdit()
        HandpackedTableAdapter.Update(VBPROJECTDataSet.Handpacked)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        HandpackedBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles preBtn.Click
        HandpackedBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        HandpackedBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class