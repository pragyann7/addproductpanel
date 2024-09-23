Public Class main

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'formshow()
    End Sub
    Sub formshow(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub


End Class