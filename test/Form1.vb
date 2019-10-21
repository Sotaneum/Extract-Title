Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, _
       ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Multiselect = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filepath() As String = OpenFileDialog1.FileNames
            Dim ffile As String
            For Each ffile In filepath
                Dim G, J
                G = Len(System.IO.Path.GetFileName(ffile))
                J = Mid(System.IO.Path.GetFileName(ffile), 1, G - TextBox2.Text)
                Me.ListBox1.Items.Add(J & TextBox3.Text)
            Next
            Button2.Enabled = True

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'If Dir(My.Application.Info.DirectoryPath & "\list.txt") = "" Then
        'System.IO.File.OpenRead(My.Application.Info.DirectoryPath & "\list.txt")
        'Dim BAT_MAKE_P As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\DB.txt", True)
        Dim FILE_NAME2 As String = My.Application.Info.DirectoryPath & "\DB.txt"

        Dim objWriter2 As New System.IO.StreamWriter(FILE_NAME2)
        objWriter2.Write(ListBox1.Items.Count - 1)
        objWriter2.Close()

        Dim FILE_NAME As String = My.Application.Info.DirectoryPath & "\list.txt"
        Dim n

        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        n = ListBox1.Items.Count - 1
        For i = 0 To n
            ListBox1.SelectedIndex = i
            objWriter.Write(ListBox1.Text & TextBox1.Text)
        Next

        'objWriter.Write(.Text)
        objWriter.Close()
        MsgBox("Text written to file")

        'Else

        'MsgBox("File Does Not Exist")
        'End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Button2.Enabled = False

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Button2.Enabled = False

    End Sub
End Class
