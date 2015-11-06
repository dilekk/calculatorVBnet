<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.BtnSubstr = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.BtnAddition = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblPrevValue = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelTextBox2 = New New_Calc.LabelTextBox()
        Me.LabelTextBox1 = New New_Calc.LabelTextBox()
        Me.ShappedButton1 = New New_Calc.ShappedButton()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(141, 453)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 31)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.LightCoral
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CheckBox1.Font = New System.Drawing.Font("Myriad Web Pro", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(10, 459)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(10, 111)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 62)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(85, 111)
        Me.btnDivide.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(67, 62)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(159, 111)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(67, 62)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'BtnSubstr
        '
        Me.BtnSubstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubstr.Location = New System.Drawing.Point(234, 111)
        Me.BtnSubstr.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSubstr.Name = "BtnSubstr"
        Me.BtnSubstr.Size = New System.Drawing.Size(67, 62)
        Me.BtnSubstr.TabIndex = 5
        Me.BtnSubstr.Text = "-"
        Me.BtnSubstr.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(159, 180)
        Me.btn9.Margin = New System.Windows.Forms.Padding(4)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(67, 62)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(85, 180)
        Me.btn8.Margin = New System.Windows.Forms.Padding(4)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(67, 62)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(10, 180)
        Me.btn7.Margin = New System.Windows.Forms.Padding(4)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(67, 62)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(159, 249)
        Me.btn6.Margin = New System.Windows.Forms.Padding(4)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(67, 62)
        Me.btn6.TabIndex = 11
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(85, 249)
        Me.btn5.Margin = New System.Windows.Forms.Padding(4)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(67, 62)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(10, 249)
        Me.btn4.Margin = New System.Windows.Forms.Padding(4)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(67, 62)
        Me.btn4.TabIndex = 9
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(85, 318)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(67, 62)
        Me.btn2.TabIndex = 14
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(159, 318)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(67, 62)
        Me.btn3.TabIndex = 13
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(10, 318)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(67, 62)
        Me.btn1.TabIndex = 12
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(159, 384)
        Me.btnDecimal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(67, 62)
        Me.btnDecimal.TabIndex = 17
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'BtnAddition
        '
        Me.BtnAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddition.Location = New System.Drawing.Point(234, 180)
        Me.BtnAddition.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddition.Name = "BtnAddition"
        Me.BtnAddition.Size = New System.Drawing.Size(67, 130)
        Me.BtnAddition.TabIndex = 16
        Me.BtnAddition.Text = "+"
        Me.BtnAddition.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(10, 384)
        Me.btn0.Margin = New System.Windows.Forms.Padding(4)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(141, 62)
        Me.btn0.TabIndex = 15
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'BtnEqual
        '
        Me.BtnEqual.BackColor = System.Drawing.Color.Orchid
        Me.BtnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEqual.Location = New System.Drawing.Point(234, 318)
        Me.BtnEqual.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(67, 128)
        Me.BtnEqual.TabIndex = 18
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = False
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(13, 65)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(288, 38)
        Me.txtResult.TabIndex = 19
        Me.txtResult.Text = "0"
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShappedButton1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 321)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(21, 171)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(153, 300)
        Me.ShapeContainer2.TabIndex = 3
        Me.ShapeContainer2.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(53, 52)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(75, 23)
        '
        'lblPrevValue
        '
        Me.lblPrevValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrevValue.Location = New System.Drawing.Point(13, 26)
        Me.lblPrevValue.Name = "lblPrevValue"
        Me.lblPrevValue.Size = New System.Drawing.Size(288, 34)
        Me.lblPrevValue.TabIndex = 21
        Me.lblPrevValue.Text = "0"
        Me.lblPrevValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 26)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'LabelTextBox2
        '
        Me.LabelTextBox2.LabelLocation = New_Calc.LabelTextBox.LabelStyle.Left
        Me.LabelTextBox2.Location = New System.Drawing.Point(308, 53)
        Me.LabelTextBox2.Name = "LabelTextBox2"
        Me.LabelTextBox2.Size = New System.Drawing.Size(184, 30)
        Me.LabelTextBox2.TabIndex = 24
        Me.LabelTextBox2.TextBoxLabel = "Zipcode"
        Me.LabelTextBox2.TextBoxTest = ""
        '
        'LabelTextBox1
        '
        Me.LabelTextBox1.LabelLocation = New_Calc.LabelTextBox.LabelStyle.Left
        Me.LabelTextBox1.Location = New System.Drawing.Point(311, 12)
        Me.LabelTextBox1.Name = "LabelTextBox1"
        Me.LabelTextBox1.Size = New System.Drawing.Size(169, 35)
        Me.LabelTextBox1.TabIndex = 23
        Me.LabelTextBox1.TextBoxLabel = "Address"
        Me.LabelTextBox1.TextBoxTest = ""
        '
        'ShappedButton1
        '
        Me.ShappedButton1.BorderColor = System.Drawing.Color.Red
        Me.ShappedButton1.ButtonText = "Oval"
        Me.ShappedButton1.Location = New System.Drawing.Point(15, 112)
        Me.ShappedButton1.Name = "ShappedButton1"
        Me.ShappedButton1.NewProperty = System.Drawing.Color.Gray
        Me.ShappedButton1.Shape = New_Calc.ShappedButton.ButtonShapes.Rectangle
        Me.ShappedButton1.Size = New System.Drawing.Size(126, 43)
        Me.ShappedButton1.TabIndex = 4
        '
        'frmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 483)
        Me.Controls.Add(Me.LabelTextBox2)
        Me.Controls.Add(Me.LabelTextBox1)
        Me.Controls.Add(Me.lblPrevValue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.BtnEqual)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.BtnAddition)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.BtnSubstr)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(500, 515)
        Me.MinimumSize = New System.Drawing.Size(335, 471)
        Me.Name = "frmCalc"
        Me.Text = "Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents BtnSubstr As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents BtnAddition As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents BtnEqual As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblPrevValue As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LabelTextBox1 As New_Calc.LabelTextBox
    Friend WithEvents LabelTextBox2 As New_Calc.LabelTextBox
    Friend WithEvents ShappedButton1 As New_Calc.ShappedButton

End Class
