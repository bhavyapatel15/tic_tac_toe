Public Class Form1
  
    Dim turn As Integer = 1
    Dim flag As Integer = 1

    
    Function check(s) As String
        If turn = 0 Then

            If btn1.Text = s And btn2.Text = s And btn3.Text = s Then
                lbl.Text = "Player 1 won"
                btn1.BackColor = Color.Crimson
                btn2.BackColor = Color.Crimson
                btn3.BackColor = Color.Crimson
                flag = 0


            ElseIf btn4.Text = s And btn5.Text = s And btn6.Text = s Then
                lbl.Text = "Player 1 won"
                btn4.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn6.BackColor = Color.Crimson
                flag = 0

            ElseIf btn7.Text = s And btn8.Text = s And btn9.Text = s Then
                lbl.Text = "Player 1 won"
                btn7.BackColor = Color.Crimson
                btn8.BackColor = Color.Crimson
                btn9.BackColor = Color.Crimson
                flag = 0

            ElseIf btn1.Text = s And btn4.Text = s And btn7.Text = s Then
                lbl.Text = "Player 1 won"
                btn1.BackColor = Color.Crimson
                btn4.BackColor = Color.Crimson
                btn7.BackColor = Color.Crimson
                flag = 0

            ElseIf btn2.Text = s And btn5.Text = s And btn8.Text = s Then
                lbl.Text = "Player 1 won"
                btn2.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn8.BackColor = Color.Crimson
                flag = 0

            ElseIf btn3.Text = s And btn6.Text = s And btn9.Text = s Then
                lbl.Text = "Player 1 won"
                btn3.BackColor = Color.Crimson
                btn6.BackColor = Color.Crimson
                btn9.BackColor = Color.Crimson
                flag = 0

            ElseIf btn1.Text = s And btn5.Text = s And btn9.Text = s Then
                lbl.Text = "Player 1 won"
                btn1.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn9.BackColor = Color.Crimson
                flag = 0

            ElseIf btn3.Text = s And btn5.Text = s And btn7.Text = s Then
                lbl.Text = "Player 1 won"
                btn3.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn7.BackColor = Color.Crimson
                flag = 0

            ElseIf (btn1.Text <> "" And btn2.Text <> "" And btn3.Text <> "" And btn4.Text <> "" And btn5.Text <> "" And btn6.Text <> "" And btn7.Text <> "" And btn8.Text <> "" And btn9.Text <> "") Then
                lbl.Text = "Game Draw!"
            End If
        Else

            If btn1.Text = s And btn2.Text = s And btn3.Text = s Then
                lbl.Text = "Player 2 won"
                btn1.BackColor = Color.Crimson
                btn2.BackColor = Color.Crimson
                btn3.BackColor = Color.Crimson
                flag = 0

            ElseIf btn4.Text = s And btn5.Text = s And btn6.Text = s Then
                lbl.Text = "Player 2 won"
                btn4.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn6.BackColor = Color.Crimson
                flag = 0

            ElseIf btn7.Text = s And btn8.Text = s And btn9.Text = s Then
                lbl.Text = "Player 2 won"
                btn7.BackColor = Color.Crimson
                btn8.BackColor = Color.Crimson
                btn9.BackColor = Color.Crimson
                flag = 0

            ElseIf btn1.Text = s And btn4.Text = s And btn7.Text = s Then
                lbl.Text = "Player 2 won"
                btn1.BackColor = Color.Crimson
                btn4.BackColor = Color.Crimson
                btn7.BackColor = Color.Crimson
                flag = 0


            ElseIf btn2.Text = s And btn5.Text = s And btn8.Text = s Then
                lbl.Text = "Player 2 won"
                btn2.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn8.BackColor = Color.Crimson
                flag = 0

            ElseIf btn3.Text = s And btn6.Text = s And btn9.Text = s Then
                lbl.Text = "Player 2 won"
                btn3.BackColor = Color.Crimson
                btn6.BackColor = Color.Crimson
                btn9.BackColor = Color.Crimson
                flag = 0

            ElseIf btn1.Text = s And btn5.Text = s And btn9.Text = s Then
                lbl.Text = "Player 2 won"
                btn1.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn9.BackColor = Color.Crimson
                flag = 0

            ElseIf btn3.Text = s And btn5.Text = s And btn7.Text = s Then
                lbl.Text = "Player 2 won"
                btn3.BackColor = Color.Crimson
                btn5.BackColor = Color.Crimson
                btn7.BackColor = Color.Crimson
                flag = 0

            ElseIf (btn1.Text <> "" And btn2.Text <> "" And btn3.Text <> "" And btn4.Text <> "" And btn5.Text <> "" And btn6.Text <> "" And btn7.Text <> "" And btn8.Text <> "" And btn9.Text <> "") Then
                lbl.Text = "Game Draw!"

            End If

        End If


    End Function


    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        If flag <> "0" Then
            If btn1.Text = "" Then
                If turn = 1 Then
                    btn1.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn1.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If
                turn = 1 - turn
                check(btn1.Text)
            End If
        End If


    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        If flag <> "0" Then
            If btn2.Text = "" Then
                If turn = 1 Then
                    btn2.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn2.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn2.Text)
            End If
        End If


    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        If flag <> "0" Then
            If btn3.Text = "" Then
                If turn = 1 Then
                    btn3.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn3.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn3.Text)
            End If
        End If


    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        If flag <> "0" Then
            If btn4.Text = "" Then
                If turn = 1 Then
                    btn4.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn4.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn4.Text)
            End If
        End If


    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        If flag <> "0" Then
            If btn5.Text = "" Then

                If turn = 1 Then
                    btn5.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn5.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn5.Text)
            End If
        End If


    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        If flag <> "0" Then
            If btn6.Text = "" Then
                If turn = 1 Then
                    btn6.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn6.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn6.Text)
            End If
        End If


    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        If flag <> "0" Then
            If btn7.Text = "" Then
                If turn = 1 Then
                    btn7.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn7.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn7.Text)
            End If
        End If


    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        If flag <> "0" Then
            If btn8.Text = "" Then
                If turn = 1 Then
                    btn8.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn8.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn8.Text)
            End If
        End If


    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        If flag <> "0" Then
            If btn9.Text = "" Then
                If turn = 1 Then
                    btn9.Text = "X"
                    lbl.Text = "Player 2 turn"
                Else
                    btn9.Text = "O"
                    lbl.Text = "Player 1 turn"
                End If

                turn = 1 - turn
                check(btn9.Text)
            End If

        End If

    End Sub

    Private Sub btnre_Click(sender As System.Object, e As System.EventArgs) Handles btnre.Click
        btn1.Text = ""
        btn1.BackColor = Color.AntiqueWhite

        btn2.Text = ""
        btn2.BackColor = Color.AntiqueWhite

        btn3.Text = ""
        btn3.BackColor = Color.AntiqueWhite

        btn4.Text = ""
        btn4.BackColor = Color.AntiqueWhite

        btn5.Text = ""
        btn5.BackColor = Color.AntiqueWhite

        btn6.Text = ""
        btn6.BackColor = Color.AntiqueWhite

        btn7.Text = ""
        btn7.BackColor = Color.AntiqueWhite

        btn8.Text = ""
        btn8.BackColor = Color.AntiqueWhite

        btn9.Text = ""
        btn9.BackColor = Color.AntiqueWhite

        flag = 1
        turn = 1
        lbl.Text = "Player 1 turn"

    End Sub

   

End Class
