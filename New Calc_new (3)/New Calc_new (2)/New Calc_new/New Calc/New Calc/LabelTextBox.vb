Public Class LabelTextBox
    'Private _TextBoxLabel As String
    Public Property TextBoxLabel() As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            '_TextBoxLabel = value
            Label1.Text = value
        End Set
    End Property
    'Private TextBox1.text As String
    Public Property TextBoxTest() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As String)
            TextBox1.Text = value
        End Set
    End Property

    Public Enum LabelStyle
        Left = 0
        Top = 1
    End Enum
    Private _LabelLocation As LabelStyle = LabelStyle.Left
    Public Property LabelLocation() As LabelStyle
        Get
            Return _LabelLocation
        End Get
        Set(ByVal value As LabelStyle)
            _LabelLocation = value
            If value = LabelStyle.Left Then
                Label1.Left = 0
                Label1.Top = 3
                TextBox1.Left = Me.Width - TextBox1.Width
                TextBox1.Top = 0
                Me.Height = TextBox1.Height
                TextBox1.Width = Me.Width - Label1.Width
                TextBox1.Left = Me.Width - TextBox1.Width
            Else 'label on top
                Label1.Top = 0
                Label1.Left = 0
                TextBox1.Left = 0
                TextBox1.Top = Label1.Height + 1
                Me.Height = Label1.Height + TextBox1.Height
                TextBox1.Width = Me.Width

            End If
        End Set
    End Property

End Class
