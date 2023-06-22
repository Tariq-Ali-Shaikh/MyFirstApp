Public Class Form1


    Private Sub ClickButton_Click(sender As Object, e As EventArgs) Handles ClickButton.Click
        GreetingLabel.Text = "Hello, " + NameText.Text + "!"
    End Sub

End Class
