﻿' Copyright 2016 Hermann Mundprecht
' This file is licensed under the terms of the license 'CC BY 4.0'. 
' For a human readable version of the license, see https://creativecommons.org/licenses/by/4.0/
Public Class FormLogon
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonLogon_Click(sender As Object, e As EventArgs) Handles ButtonLogon.Click

        If Me.Client.Text = "" Or Me.Password.Text = "" Or Me.UserName.Text = "" Then
            MsgBox("Enter Client, Username and Password", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
        Else
            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class