Public Class ShappedButton
    Private _BorderColor As Color = Color.Black 'library that gives the color options

    Public Property BorderColor() As Color 'library that gives the color options
        Get
            Return _BorderColor
        End Get
        Set(ByVal value As Color)
            _BorderColor = value
        End Set
    End Property

    Private _FaceColor As Color = Color.Gray 'color of the background of the oval. Private is the scope, _FaceColor is the variable, you can also use DIM
    Public Property NewProperty() As Color
        Get
            Return _FaceColor
        End Get
        Set(ByVal value As Color)
            _FaceColor = value
            Me.Refresh() ''''''<======='
        End Set
    End Property

    'Private Label1.text As String
    Public Property ButtonText() As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property
    Public Enum ButtonShapes
        Rectangle = 0
        Oval = 1
    End Enum

    Private _Shape As ButtonShapes = ButtonShapes.Oval 'set to oval at the begining. Also private makes it hidden.
    Public Property Shape() As ButtonShapes
        Get
            Return _Shape
        End Get
        Set(ByVal value As ButtonShapes)
            _Shape = value
            Me.Refresh() 'to change the shape add refresh, to show it to the user
        End Set
    End Property

    'This is where we draw the oval and rectangle. Find system.drawing in References
    Private Sub ShappedButton_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint 'Me is the current class.
        Dim grf As Graphics = e.Graphics 'Property/method "Graphics" available for user. grf is the variable to hold our canvas to paint.
        Dim objPen As Pen = New Pen(_BorderColor)
        Dim objBrush As Brush = New SolidBrush(_FaceColor)  'variable that will fill the ellipse
        Select Case _Shape
            Case ButtonShapes.Oval

                grf.FillEllipse(objBrush, 0, 0, Me.Width - 1, Me.Height - 1)
                grf.DrawEllipse(objPen, 0, 0, Me.Width - 1, Me.Height - 1)
            Case ButtonShapes.Rectangle
                grf.FillRectangle(objBrush, 0, 0, Me.Width - 1, Me.Height - 1)
                grf.DrawRectangle(objPen, 0, 0, Me.Width - 1, Me.Height - 1) 'instead of Class Pens we will use BorderColor
            Case Else
        End Select

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
