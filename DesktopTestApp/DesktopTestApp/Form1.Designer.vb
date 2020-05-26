<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.cboComboBox = New System.Windows.Forms.ComboBox()
        Me.chkOne = New System.Windows.Forms.CheckBox()
        Me.rdoOne = New System.Windows.Forms.RadioButton()
        Me.btnButton = New System.Windows.Forms.Button()
        Me.lbListBox = New System.Windows.Forms.ListBox()
        Me.rdoTwo = New System.Windows.Forms.RadioButton()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chkThree = New System.Windows.Forms.CheckBox()
        Me.chkFour = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtTextBox
        '
        Me.txtTextBox.Location = New System.Drawing.Point(41, 34)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.Size = New System.Drawing.Size(199, 20)
        Me.txtTextBox.TabIndex = 0
        '
        'cboComboBox
        '
        Me.cboComboBox.FormattingEnabled = True
        Me.cboComboBox.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth", "Fifth"})
        Me.cboComboBox.Location = New System.Drawing.Point(41, 89)
        Me.cboComboBox.Name = "cboComboBox"
        Me.cboComboBox.Size = New System.Drawing.Size(199, 21)
        Me.cboComboBox.TabIndex = 1
        '
        'chkOne
        '
        Me.chkOne.AutoSize = True
        Me.chkOne.Location = New System.Drawing.Point(41, 187)
        Me.chkOne.Name = "chkOne"
        Me.chkOne.Size = New System.Drawing.Size(46, 17)
        Me.chkOne.TabIndex = 2
        Me.chkOne.Text = "One"
        Me.chkOne.UseVisualStyleBackColor = True
        '
        'rdoOne
        '
        Me.rdoOne.AutoSize = True
        Me.rdoOne.Location = New System.Drawing.Point(41, 140)
        Me.rdoOne.Name = "rdoOne"
        Me.rdoOne.Size = New System.Drawing.Size(31, 17)
        Me.rdoOne.TabIndex = 3
        Me.rdoOne.TabStop = True
        Me.rdoOne.Text = "1"
        Me.rdoOne.UseVisualStyleBackColor = True
        '
        'btnButton
        '
        Me.btnButton.Location = New System.Drawing.Point(165, 421)
        Me.btnButton.Name = "btnButton"
        Me.btnButton.Size = New System.Drawing.Size(75, 23)
        Me.btnButton.TabIndex = 4
        Me.btnButton.Text = "Button"
        Me.btnButton.UseVisualStyleBackColor = True
        '
        'lbListBox
        '
        Me.lbListBox.FormattingEnabled = True
        Me.lbListBox.Items.AddRange(New Object() {"AAA", "BBB", "CCC", "DDD", "XXX"})
        Me.lbListBox.Location = New System.Drawing.Point(41, 281)
        Me.lbListBox.Name = "lbListBox"
        Me.lbListBox.Size = New System.Drawing.Size(199, 121)
        Me.lbListBox.TabIndex = 5
        '
        'rdoTwo
        '
        Me.rdoTwo.AutoSize = True
        Me.rdoTwo.Location = New System.Drawing.Point(150, 140)
        Me.rdoTwo.Name = "rdoTwo"
        Me.rdoTwo.Size = New System.Drawing.Size(31, 17)
        Me.rdoTwo.TabIndex = 3
        Me.rdoTwo.TabStop = True
        Me.rdoTwo.Text = "2"
        Me.rdoTwo.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(150, 187)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(47, 17)
        Me.chk2.TabIndex = 2
        Me.chk2.Text = "Two"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chkThree
        '
        Me.chkThree.AutoSize = True
        Me.chkThree.Location = New System.Drawing.Point(41, 234)
        Me.chkThree.Name = "chkThree"
        Me.chkThree.Size = New System.Drawing.Size(54, 17)
        Me.chkThree.TabIndex = 2
        Me.chkThree.Text = "Three"
        Me.chkThree.UseVisualStyleBackColor = True
        '
        'chkFour
        '
        Me.chkFour.AutoSize = True
        Me.chkFour.Location = New System.Drawing.Point(150, 234)
        Me.chkFour.Name = "chkFour"
        Me.chkFour.Size = New System.Drawing.Size(47, 17)
        Me.chkFour.TabIndex = 2
        Me.chkFour.Text = "Four"
        Me.chkFour.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 470)
        Me.Controls.Add(Me.lbListBox)
        Me.Controls.Add(Me.btnButton)
        Me.Controls.Add(Me.rdoTwo)
        Me.Controls.Add(Me.rdoOne)
        Me.Controls.Add(Me.chkFour)
        Me.Controls.Add(Me.chkThree)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chkOne)
        Me.Controls.Add(Me.cboComboBox)
        Me.Controls.Add(Me.txtTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTextBox As TextBox
    Friend WithEvents cboComboBox As ComboBox
    Friend WithEvents chkOne As CheckBox
    Friend WithEvents rdoOne As RadioButton
    Friend WithEvents btnButton As Button
    Friend WithEvents lbListBox As ListBox
    Friend WithEvents rdoTwo As RadioButton
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chkThree As CheckBox
    Friend WithEvents chkFour As CheckBox
End Class
