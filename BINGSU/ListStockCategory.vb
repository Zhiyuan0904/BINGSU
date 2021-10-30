Public Class ListStockCategory
    Private Sub ListStockCategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListStockCategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListStockCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBPROJECTDataSet)

    End Sub

    Private Sub ListStockCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBPROJECTDataSet.ListStockCategory' table. You can move, or remove it, as needed.
        Me.ListStockCategoryTableAdapter.Fill(Me.VBPROJECTDataSet.ListStockCategory)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        ListStockCategoryBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        On Error GoTo SaveErr
        ListStockCategoryBindingSource.EndEdit()
        ListStockCategoryTableAdapter.Update(VBPROJECTDataSet.ListStockCategory)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ListStockCategoryBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles preBtn.Click
        ListStockCategoryBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        ListStockCategoryBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class