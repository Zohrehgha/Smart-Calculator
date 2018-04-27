Public Class Form1
    Dim MemtoKeep As Double
    Dim MemtokeepAfterEqual As Double
    Dim LastOperation As String
    Dim WhatPressed As String
    Dim FirstOp As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization
        TextBox1.Enabled = False 'shouldn't be typed in textbox(disable)
        WhatPressed = "Digit" 'There is 0(digit) as a default when program is started
        FirstOp = True 'when program is comming up we haven't done any operation
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "1"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "2"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If FirstOp = True Then  'If the operation is the first time
            FirstOp = False
            MemtoKeep = Convert.ToDouble(TextBox1.Text)   'copy the textbox in the memory
            TextBox1.Text = ""    'Clear whatever in the textbox
            LastOperation = "+"
            Exit Sub
        End If
        'If the operation is not the first time
        If WhatPressed = "Operation" Then 'if befor this + there was an operation press
            TextBox1.Text = "" 'so clear the textbox
            LastOperation = "+"
        End If

        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            If LastOperation = "+" Then
                TextBox1.Text = Convert.ToDouble(TextBox1.Text) + MemtoKeep
                WhatPressed = "Operation"
            End If
        End If
        If WhatPressed = "Equal" Then 'press equal after operation doesn't have any meaning
            TextBox1.Text = "0" 'so put 0 
            WhatPressed = "Digit"
        End If
        WhatPressed = "Operation"
    End Sub
    'Adding the equal button and implement add, subtract, multiply and divide buttons along with equal button
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If WhatPressed = "Opeartion" Then
            Exit Sub
        End If
        If WhatPressed = "Digit" Then
            If LastOperation = "+" Then
                TextBox1.Text = Convert.ToDouble(TextBox1.Text) + MemtoKeep
                WhatPressed = "Equal"
            End If
            If LastOperation = "-" Then
                TextBox1.Text = MemtoKeep - Convert.ToDouble(TextBox1.Text)
                WhatPressed = "Equal"
            End If
            If LastOperation = "*" Then
                TextBox1.Text = Convert.ToDouble(TextBox1.Text) * MemtoKeep
                WhatPressed = "Equal"
            End If
            If LastOperation = "/" Then
                TextBox1.Text = MemtoKeep / Convert.ToDouble(TextBox1.Text)
                WhatPressed = "Equal"
            End If
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "."
        End If
        If WhatPressed = "Dot" Then
            Exit Sub
        End If
        If WhatPressed = "Digit" And Not DotExists() Then
            TextBox1.Text = TextBox1.Text + "."
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "."
        End If
        WhatPressed = "Dot"
    End Sub
    Private Function DotExists() As Boolean
        For i = 1 To Len(TextBox1.Text)
            If Mid(TextBox1.Text, i, 1) = "." Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "3"
        End If
        WhatPressed = "Digit"
    End Sub
    'adding numbers of calculater
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "4"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "5"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "6"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "7"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "8"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "9"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
        If WhatPressed = "Operation" Or WhatPressed = "Equal" Then
            MemtoKeep = Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = "0"
        End If
        WhatPressed = "Digit"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If FirstOp = True Then  'If the operation is the first time
            FirstOp = False
            MemtoKeep = Convert.ToDouble(TextBox1.Text)   'copy the textbox in the memory
            TextBox1.Text = ""    'Clear whatever in the textbox
            LastOperation = "-"
            Exit Sub
        End If
        'If the operation is not the first time
        If WhatPressed = "Operation" Then 'if befor this + there was an operation press
            TextBox1.Text = "" 'so clear the textbox
            LastOperation = "-"
        End If

        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            If LastOperation = "-" Then
                TextBox1.Text = MemtoKeep - Convert.ToDouble(TextBox1.Text)
                WhatPressed = "Operation"
            End If
        End If
        If WhatPressed = "Equal" Then 'press equal after operation doesn't have any meaning
            TextBox1.Text = "0" 'so put 0 
            WhatPressed = "Digit"
        End If
        WhatPressed = "Operation"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If FirstOp = True Then  'If the operation is the first time
            FirstOp = False
            MemtoKeep = Convert.ToDouble(TextBox1.Text)   'copy the textbox in the memory
            TextBox1.Text = ""    'Clear whatever in the textbox
            LastOperation = "*"
            Exit Sub
        End If
        'If the operation is not the first time
        If WhatPressed = "Operation" Then 'if befor this + there was an operation press
            TextBox1.Text = "" 'so clear the textbox
            LastOperation = "*"
        End If

        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            If LastOperation = "*" Then
                TextBox1.Text = Convert.ToDouble(TextBox1.Text) * MemtoKeep
                WhatPressed = "Operation"
            End If
        End If
        If WhatPressed = "Equal" Then 'press equal after operation doesn't have any meaning
            TextBox1.Text = "0" 'so put 0 
            WhatPressed = "Digit"
        End If
        WhatPressed = "Operation"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If FirstOp = True Then  'If the operation is the first time
            FirstOp = False
            MemtoKeep = Convert.ToDouble(TextBox1.Text)   'copy the textbox in the memory
            TextBox1.Text = ""    'Clear whatever in the textbox
            LastOperation = "/"
            Exit Sub
        End If
        'If the operation is not the first time
        If WhatPressed = "Operation" Then 'if befor this + there was an operation press
            TextBox1.Text = "" 'so clear the textbox
            LastOperation = "/"
        End If

        If WhatPressed = "Digit" Or WhatPressed = "Dot" Then
            If LastOperation = "/" Then
                TextBox1.Text = MemtoKeep / Convert.ToDouble(TextBox1.Text)
                WhatPressed = "Operation"
            End If
        End If
        If WhatPressed = "Equal" Then 'press equal after operation doesn't have any meaning
            TextBox1.Text = "0" 'so put 0 
            WhatPressed = "Digit"
        End If
        WhatPressed = "Operation"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Clear()
    End Sub
End Class
