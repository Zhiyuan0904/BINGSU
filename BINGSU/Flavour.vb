Public Class Flavour
    Private Sub FlavourBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FlavourBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlavourBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBPROJECTDataSet)

    End Sub

    Private Sub Flavour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBPROJECTDataSet.Flavour' table. You can move, or remove it, as needed.
        Me.FlavourTableAdapter.Fill(Me.VBPROJECTDataSet.Flavour)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        FlavourBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        On Error GoTo SaveErr
        FlavourBindingSource.EndEdit()
        FlavourTableAdapter.Update(VBPROJECTDataSet.Flavour)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        FlavourBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles preBtn.Click
        FlavourBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        FlavourBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class