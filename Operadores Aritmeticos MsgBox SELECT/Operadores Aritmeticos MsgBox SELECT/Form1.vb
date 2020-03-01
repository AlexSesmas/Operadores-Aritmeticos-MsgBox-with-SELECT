Public Class Form1
    Dim Opcion As DialogResult
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Focus()
        If TextBox1.Text = Nothing Then 'Indica que si en la caja de texto1 no hay nada, entonces mande el mesnaje incluido en el MsgBox
            MsgBox("Faltan datos en el primer textbox1", vbExclamation, "TextBox1 sin datos")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = Nothing Then 'Indica que si en la caja de texto2 no hay nada, entonces mande el mesnaje incluido en el MsgBox
            MsgBox("Faltan datos en el textbox2", vbExclamation, "TextBox2 sin datos")
            TextBox1.Focus()
            Exit Sub
        End If

        If ComboBox1.Text = Nothing Then
            MsgBox("Falta elegir el operador de relacion", vbExclamation, "ComboBox1 sin datos")
            TextBox1.Focus()
            Exit Sub
        End If

        Select Case ComboBox1.Text
            Case "+"
                Opcion = MsgBox("El resultado es:" & Chr(13) & Val(TextBox1.Text) + Val(TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
            Case "-"
                Opcion = MsgBox("El resultado es:" & Chr(13) & (TextBox1.Text) - (TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
            Case "*"
                Opcion = MsgBox("El resultado es:" & Chr(13) & (TextBox1.Text) * (TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
            Case "/"
                Opcion = MsgBox("El resultado es:" & Chr(13) & (TextBox1.Text) / (TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
            Case "\"
                Opcion = MsgBox("El resultado es:" & Chr(13) & (TextBox1.Text) \ (TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
            Case "^"
                Opcion = MsgBox("El resultado es:" & Chr(13) & (TextBox1.Text) ^ (TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
            Case "MOD"
                Opcion = MsgBox("El resultado es:" & Chr(13) & (TextBox1.Text) Mod (TextBox2.Text) & Chr(10) & "Quieres hacer otra operacion?", vbYesNo Or vbExclamation)
                TextBox1.Clear()
                TextBox2.Clear()
                If (Opcion = DialogResult.No) Then
                    End
                End If
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then ' e. es una excepcion y si se captura una tecla diferente a un digito marcara error
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Detecta las teclas de control como F1 a F9, signos de puntuación, etc
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then ' e. es una excepcion y si se captura una tecla diferente a un digito marcara error
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Detecta las teclas de control como F1 a F9, signos de puntuación, etc
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
