Public Class OFWApplyForm
    Private Sub btnAddImg_Click(sender As Object, e As EventArgs) Handles btnAddImg.Click
        ' Open a file dialog to select an image
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Load the selected image into the PictureBox
                OFWPic.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception
                ' Handle any errors that occur while loading the image
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

End Class