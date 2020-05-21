Public Class ImageSave
    Private CurrentFolder As String = ""

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click

        Try
            Me.PictureBox1.Image = My.Computer.Clipboard.GetImage
        Catch ex As Exception
            Exit Sub
        End Try



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then

            ContextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y)
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then

            ContextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y)
        End If
    End Sub

    Private Sub SetFolder()
        FolderBrowserDialog1.ShowNewFolderButton = True


        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CurrentFolder = FolderBrowserDialog1.SelectedPath & "\"


            cFolder.Text = CurrentFolder
        End If
    End Sub

    Private Sub SetFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFolderToolStripMenuItem.Click
        SetFolder()
    End Sub

    
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveAsImage()

    End Sub
    Private Sub SaveAsImage()
        SaveFileDialog1.AddExtension = False
        SaveFileDialog1.CheckFileExists = False
        SaveFileDialog1.CheckPathExists = True
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        SaveFileDialog1.Filter = "Images (jpg)|*.jpg;"
        SaveFileDialog1.AddExtension = True

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.PictureBox1.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click

        Try
            Me.PictureBox1.Image = My.Computer.Clipboard.GetImage
        Catch ex As Exception
            Exit Sub
        End Try



    End Sub

  
    Private Sub SaveAsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem1.Click
        SaveAsImage()
    End Sub

    Private Sub SetFolderToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFolderToolStripMenuItem1.Click
        SetFolder()
    End Sub
End Class
