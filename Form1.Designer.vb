<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        test2 = New TextBox()
        test1 = New TextBox()
        surname = New TextBox()
        title = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(59, 665)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 2
        Button1.Text = "Validate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(767, 655)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 46)
        Button4.TabIndex = 5
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(577, 655)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 46)
        Button5.TabIndex = 7
        Button5.Text = "Clear"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' test2
        ' 
        test2.Location = New Point(496, 359)
        test2.Name = "test2"
        test2.Size = New Size(336, 38)
        test2.TabIndex = 0
        ' 
        ' test1
        ' 
        test1.Location = New Point(496, 315)
        test1.Name = "test1"
        test1.Size = New Size(336, 38)
        test1.TabIndex = 8
        ' 
        ' surname
        ' 
        surname.Location = New Point(496, 241)
        surname.Name = "surname"
        surname.Size = New Size(336, 38)
        surname.TabIndex = 9
        ' 
        ' title
        ' 
        title.Location = New Point(496, 197)
        title.Name = "title"
        title.Size = New Size(336, 38)
        title.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 362)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 31)
        Label1.TabIndex = 11
        Label1.Text = "Test 2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(126, 318)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 31)
        Label2.TabIndex = 12
        Label2.Text = "Test 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(126, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 31)
        Label3.TabIndex = 13
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(126, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(285, 31)
        Label4.TabIndex = 14
        Label4.Text = "Title (Mr, Miss, Ms, Mrs)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(316, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(271, 31)
        Label5.TabIndex = 15
        Label5.Text = "Students Results Entry"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(276, 524)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 31)
        Label6.TabIndex = 16
        Label6.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(961, 735)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(title)
        Controls.Add(surname)
        Controls.Add(test1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(test2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents test2 As TextBox
    Friend WithEvents test1 As TextBox
    Friend WithEvents surname As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
