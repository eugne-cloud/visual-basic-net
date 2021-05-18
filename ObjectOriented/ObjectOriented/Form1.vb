Public Class Form1
    Dim round New Circle 

End Class


Class Circle
        Private intX As Integer
        Private intY As Integer
        Private intDia As Integer

    Public Sub New()
        Xcoord = 0
        Ycoord = 0
        Diameter = 40
    End Sub

    Public Property Xcoord() As Integer
            Get
                Return intX

            End Get

            Set(value As Integer)
                intX = value
            End Set

            Public Property Ycoord() As Integer
        Get
            Return intY
        End Get

        Set(value As Integer)
            intY = value
        End Set

    End Property

    Sub Show(graph As Graphics)
        graph.DrawArcEllipse(Pens.Red, Xcoord, Ycoord, Diameter, Diameter)
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        round.Move(20)
        round.show(picCircle.CreateGraphics)

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
