﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogon
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
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonLogon = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Client = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Language = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Destination = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UserName
        '
        Me.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserName.Location = New System.Drawing.Point(72, 59)
        Me.UserName.MaxLength = 12
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(153, 20)
        Me.UserName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "User"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(72, 86)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(153, 20)
        Me.Password.TabIndex = 2
        Me.Password.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'ButtonLogon
        '
        Me.ButtonLogon.Location = New System.Drawing.Point(12, 145)
        Me.ButtonLogon.Name = "ButtonLogon"
        Me.ButtonLogon.Size = New System.Drawing.Size(54, 25)
        Me.ButtonLogon.TabIndex = 4
        Me.ButtonLogon.Text = "Logon"
        Me.ButtonLogon.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(72, 146)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(54, 25)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.Client.Location = New System.Drawing.Point(72, 33)
        Me.Client.MaxLength = 3
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(34, 20)
        Me.Client.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Client"
        '
        'Language
        '
        Me.Language.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Language.Location = New System.Drawing.Point(72, 112)
        Me.Language.MaxLength = 2
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(34, 20)
        Me.Language.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Language"
        '
        'Destination
        '
        Me.Destination.BackColor = System.Drawing.SystemColors.Control
        Me.Destination.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Destination.Enabled = False
        Me.Destination.Location = New System.Drawing.Point(15, 8)
        Me.Destination.MaxLength = 12
        Me.Destination.Name = "Destination"
        Me.Destination.Size = New System.Drawing.Size(210, 20)
        Me.Destination.TabIndex = 10
        Me.Destination.TabStop = False
        Me.Destination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormLogon
        '
        Me.AcceptButton = Me.ButtonLogon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(244, 181)
        Me.Controls.Add(Me.Destination)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Language)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Client)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonLogon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserName)
        Me.Name = "FormLogon"
        Me.Text = "SAP-Logon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonLogon As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents Client As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Language As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Destination As System.Windows.Forms.TextBox
End Class
