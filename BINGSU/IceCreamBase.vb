Public Class IceCreamBase
    Private Sub IceCreamBaseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IceCreamBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IceCreamBaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBPROJECTDataSet)

    End Sub

    Private Sub IceCreamBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBPROJECTDataSet.IceCreamBase' table. You can move, or remove it, as needed.
        Me.IceCreamBaseTableAdapter.Fill(Me.VBPROJECTDataSet.IceCreamBase)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        IceCreamBaseBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        On Error GoTo SaveErr
        IceCreamBaseBindingSource.EndEdit()
        IceCreamBaseTableAdapter.Update(VBPROJECTDataSet.IceCreamBase)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        IceCreamBaseBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles preBtn.Click
        IceCreamBaseBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        IceCreamBaseBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class