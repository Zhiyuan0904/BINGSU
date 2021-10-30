Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ingredientBtn.Click
        Me.Hide()
        Ingredient.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles toppingBtn.Click
        Me.Hide()
        Topping.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles flavourBtn.Click
        Me.Hide()
        Flavour.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles handpackedBtn.Click
        Me.Hide()
        Handpacked.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles icecreambaseBtn.Click
        Me.Hide()
        IceCreamBase.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles liststockcategoryBtn.Click
        Me.Hide()
        ListStockCategory.Show()
    End Sub
End Class