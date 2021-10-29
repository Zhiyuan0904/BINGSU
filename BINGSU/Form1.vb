Public Class Form1
    Private Sub IngredientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IngredientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IngredientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBPROJECTDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBPROJECTDataSet.Ingredients' table. You can move, or remove it, as needed.
        Me.IngredientsTableAdapter.Fill(Me.VBPROJECTDataSet.Ingredients)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo SaveErr
        IngredientsBindingSource.EndEdit()
        IngredientsTableAdapter.Update(VBPROJECTDataSet.Ingredients)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IngredientsBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IngredientsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IngredientsBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IngredientsBindingSource.MoveNext()
    End Sub
End Class
