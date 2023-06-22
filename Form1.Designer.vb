<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ClickButton = New Button()
        GreetingLabel = New Label()
        NameText = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ClickButton
        ' 
        ClickButton.Location = New Point(243, 340)
        ClickButton.Name = "ClickButton"
        ClickButton.Size = New Size(285, 77)
        ClickButton.TabIndex = 0
        ClickButton.Text = "Click Me!"
        ClickButton.UseVisualStyleBackColor = True
        ' 
        ' GreetingLabel
        ' 
        GreetingLabel.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GreetingLabel.Location = New Point(91, 182)
        GreetingLabel.Name = "GreetingLabel"
        GreetingLabel.Size = New Size(624, 125)
        GreetingLabel.TabIndex = 1
        GreetingLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NameText
        ' 
        NameText.Location = New Point(263, 61)
        NameText.Name = "NameText"
        NameText.Size = New Size(435, 43)
        NameText.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 37)
        Label1.TabIndex = 3
        Label1.Text = "Enter your name:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(NameText)
        Controls.Add(GreetingLabel)
        Controls.Add(ClickButton)
        Name = "Form1"
        Text = "Greeter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ClickButton As Button
    Friend WithEvents GreetingLabel As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents Label1 As Label
End Class
