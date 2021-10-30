Public Class Topping
    Private Sub ToppingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ToppingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ToppingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBPROJECTDataSet)

    End Sub

    Private Sub Topping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBPROJECTDataSet.Toppings' table. You can move, or remove it, as needed.
        Me.ToppingsTableAdapter.Fill(Me.VBPROJECTDataSet.Toppings)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        ToppingsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        On Error GoTo SaveErr
        ToppingsBindingSource.EndEdit()
        ToppingsTableAdapter.Update(VBPROJECTDataSet.Toppings)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ToppingsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles preBtn.Click
        ToppingsBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        ToppingsBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class