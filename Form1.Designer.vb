﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        txt = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        res = New Label()
        SuspendLayout()
        ' 
        ' txt
        ' 
        txt.Location = New Point(80, 107)
        txt.Name = "txt"
        txt.Size = New Size(200, 38)
        txt.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 31)
        Label1.TabIndex = 1
        Label1.Text = "Check for:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(460, 277)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 2
        Button1.Text = "Yes / No"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(270, 277)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 46)
        Button2.TabIndex = 3
        Button2.Text = "Number"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(80, 277)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 46)
        Button3.TabIndex = 4
        Button3.Text = "Postcode"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(769, 392)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 46)
        Button4.TabIndex = 5
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(591, 392)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 46)
        Button5.TabIndex = 7
        Button5.Text = "Clear"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' res
        ' 
        res.AutoSize = True
        res.Location = New Point(515, 142)
        res.Name = "res"
        res.Size = New Size(24, 31)
        res.TabIndex = 8
        res.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 472)
        Controls.Add(res)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(txt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents res As Label

End Class
