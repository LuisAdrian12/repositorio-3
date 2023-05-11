Public Class Form1
    Dim dibujar As Boolean = False
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        dibujar = True
    End Sub

    Private Sub Panel1_MouseMove(Sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If dibujar Then
            Panel1.CreateGraphics.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5)
        End If
    End Sub

    Private Sub Panel1_MouseUp(Sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        dibujar = False
    End Sub

End Class
