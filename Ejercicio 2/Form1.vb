Public Class e



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        LstbxListado.Items.Clear()
        For i = 0 To 9
            LstbxListado.Items.Add(CInt(Rnd() * 100))
            If ((i) = 9) Then
                MessageBox.Show("¡Se ha realizado la carga de los datos correctamente!")
            End If
        Next i


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LstbxListado.Items.RemoveAt(LstbxListado.SelectedIndex())
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LstbxListado.Items.Clear()

    End Sub
End Class
