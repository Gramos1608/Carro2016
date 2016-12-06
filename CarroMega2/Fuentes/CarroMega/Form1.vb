Public Class Form1
    Dim Recibido As String
    Dim Pos1 As Int16
    Dim Pos2 As Int16
    Dim Pos3 As Int16
    Dim H As String
    Dim Estado As String



    Private Sub TimIni_Tick(sender As System.Object, e As System.EventArgs) Handles TimIni.Tick
        Com.Close()
        Com.Open()
        Estado = ""
        TimIni.Enabled = False
    End Sub

    Private Sub TimRx_Tick(sender As System.Object, e As System.EventArgs) Handles TimRx.Tick
        TSeg.Text = Val(TSeg.Text) + 1
        If Val(TSeg.Text) > 10000 Then TSeg.Text = 1


        Recibido = Com.ReadExisting
        TRx.Text = TRx.Text + Recibido
        TRxAcum.Text = TRxAcum.Text + Recibido

        Pos2 = InStr(1, TRx.Text, vbCrLf)
        If Pos2 > 0 Then
            Pos1 = InStr(1, TRx.Text, "INI")
            If Pos1 > 0 And Pos1 < Pos2 Then
                Pos3 = InStr(Pos1, TRx.Text, ";")
                TRx.Text = Mid(TRx.Text, Pos3 + 1)
                TRelIzqRx.Text = Val(TRx.Text)

                Pos3 = InStr(Pos1, TRx.Text, ";")
                TRx.Text = Mid(TRx.Text, Pos3 + 1)
                TRelDerRx.Text = Val(TRx.Text)

                Pos3 = InStr(Pos1, TRx.Text, ";")
                TRx.Text = Mid(TRx.Text, Pos3 + 1)
                TVelIzqRx.Text = Val(TRx.Text)

                Pos3 = InStr(Pos1, TRx.Text, ";")
                TRx.Text = Mid(TRx.Text, Pos3 + 1)
                TVelDerRx.Text = Val(TRx.Text)

                Pos3 = InStr(Pos1, TRx.Text, ";")
                TRx.Text = Mid(TRx.Text, Pos3 + 1)
                TSonIzq.Text = Val(TRx.Text)

                Pos3 = InStr(Pos1, TRx.Text, ";")
                TRx.Text = Mid(TRx.Text, Pos3 + 1)
                TSonDer.Text = Val(TRx.Text)

                TRx.Text = Mid(TRx.Text, Pos2 + 2)

            ElseIf Pos1 > 0 Then
                TRx.Text = Mid(TRx.Text, Pos2 + 2)

            End If

        End If

    End Sub


    Private Sub BAdel_Click(sender As System.Object, e As System.EventArgs) Handles BAdel.Click
        COM.Write("Ari")
        COM.Write("Ard")

    End Sub

    Private Sub BRev_Click(sender As System.Object, e As System.EventArgs) Handles BRev.Click
        COM.Write("ARI")
        COM.Write("ARD")


    End Sub

    Private Sub BRun_Click(sender As System.Object, e As System.EventArgs) Handles BRun.Click
        ShRun.Visible = True
        Estado = "1.Run"
        FRunIzq_Click(0, Nothing)
        FRunDer_Click(0, Nothing)
    End Sub


    Private Sub BStop_Click(sender As System.Object, e As System.EventArgs) Handles BStop.Click
        COM.Write("AMI" + Chr(1) + Chr(1))
        COM.Write("AMD" + Chr(1) + Chr(1))
        ShRun.Visible = False
        Estado = "20.Stop"
    End Sub

    Private Sub HVel_MouseCaptureChanged(sender As Object, e As System.EventArgs) Handles HVel.MouseCaptureChanged
        TVelIzq.Text = HVel.Value
        TVelDer.Text = HVel.Value
        TVel.Text = HVel.Value
        If Estado = "1.Run" Then BRun_Click(0, Nothing)

    End Sub
    Private Sub HDir_MouseCaptureChanged(sender As Object, e As System.EventArgs) Handles HDir.MouseCaptureChanged
        TDir.Text = HDir.Value

        If HDir.Value <= 0 Then
            TVelIzq.Text = Val(TVel.Text) * (100 + Val(TDir.Text)) / 100
            TVelDer.Text = Val(TVel.Text)
        Else
            TVelDer.Text = Val(TVel.Text) * (100 - Val(TDir.Text)) / 100
            TVelIzq.Text = Val(TVel.Text)
        End If
        If Estado = "1.Run" Then BRun_Click(0, Nothing)

    End Sub


    Private Sub TRx_TextChanged(sender As System.Object, e As System.EventArgs) Handles TRx.TextChanged
        If Len(TRx.Text) > 500 Then TRx.Text = ""
    End Sub



    Private Sub TRxAcum_TextChanged(sender As System.Object, e As System.EventArgs) Handles TRxAcum.TextChanged
        If Len(TRxAcum.Text) > 300 Then TRxAcum.Text = ""
    End Sub

    Private Sub TSonIzq_TextChanged(sender As System.Object, e As System.EventArgs) Handles TSonIzq.TextChanged
        If Val(TSonIzq.Text) < 15 Then
            TSonIzq.BackColor = Color.Red
        Else
            TSonIzq.BackColor = Color.Green
        End If

        If Estado <> "1.Run" Then Exit Sub

        If (Val(TSonIzq.Text) < 15) And (TVelDer.Text > 1) Then
            TVelDer.Text = 1
            If COM.IsOpen Then FRunDer_Click(0, Nothing)
        End If

        If (Val(TSonIzq.Text) >= 15) And (TVelDer.Text = 1) Then
            TVelDer.Text = TVel.Text
            If COM.IsOpen Then FRunDer_Click(0, Nothing)
        End If
    End Sub


    Private Sub TSonDer_TextChanged(sender As System.Object, e As System.EventArgs) Handles TSonDer.TextChanged
        If Val(TSonDer.Text) < 15 Then
            TSonDer.BackColor = Color.Red
        Else
            TSonDer.BackColor = Color.Green
        End If

        If Estado <> "1.Run" Then Exit Sub
        If (Val(TSonDer.Text) < 15) And (TVelIzq.Text > 1) Then
            TVelIzq.Text = 1
            If COM.IsOpen Then FRunIzq_Click(0, Nothing)
        End If

        If (Val(TSonDer.Text) >= 15) And (TVelIzq.Text = 1) Then
            TVelIzq.Text = TVel.Text
            If COM.IsOpen Then FRunIzq_Click(0, Nothing)
        End If

    End Sub

    Private Sub TVelIzqRx_TextChanged(sender As System.Object, e As System.EventArgs) Handles TVelIzqRx.TextChanged
        FLlantas_Click(0, Nothing)
    End Sub

    Private Sub FLlantas_Click(sender As System.Object, e As System.EventArgs) Handles FLlantas.Click
        If Val(TVelIzqRx.Text) < 10 Then
            TLlantaIzq.BackColor = Color.Red
        ElseIf Val(TRelIzqRx.Text) = 1 Then
            TLlantaIzq.BackColor = Color.Orange
        Else
            TLlantaIzq.BackColor = Color.Green
        End If
        If Val(TVelDerRx.Text) < 10 Then
            TLLantaDer.BackColor = Color.Red
        ElseIf Val(TRelDerRx.Text) = 1 Then
            TLLantaDer.BackColor = Color.Orange
        Else
            TLLantaDer.BackColor = Color.Green
        End If

    End Sub

    Private Sub TVelDerRx_TextChanged(sender As System.Object, e As System.EventArgs) Handles TVelDerRx.TextChanged
        FLlantas_Click(0, Nothing)

    End Sub

    Private Sub TRelIzqRx_TextChanged(sender As System.Object, e As System.EventArgs) Handles TRelIzqRx.TextChanged
        FLlantas_Click(0, Nothing)
        If Val(TRelIzqRx.Text) = 1 Then
            TRelIzqRx.BackColor = Color.Orange
        Else
            TRelIzqRx.BackColor = Color.Green
        End If

    End Sub

    Private Sub TRelDerRx_TextChanged(sender As System.Object, e As System.EventArgs) Handles TRelDerRx.TextChanged
        FLlantas_Click(0, Nothing)
        If Val(TRelDerRx.Text) = 1 Then
            TRelDerRx.BackColor = Color.Orange
        Else
            TRelDerRx.BackColor = Color.Green
        End If

    End Sub

    Private Sub FRunIzq_Click(sender As System.Object, e As System.EventArgs) Handles FRunIzq.Click

        If Val(TVelIzq.Text) <= 127 Then
            H = Chr(Val(TVelIzq.Text)) + Chr(1)
        Else
            H = Chr(127) + Chr(Val(TVelIzq.Text) - 127)
        End If
        COM.Write("AMI" + H)

    End Sub

    Private Sub FRunDer_Click(sender As System.Object, e As System.EventArgs) Handles FRunDer.Click
        If Val(TVelDer.Text) <= 127 Then
            H = Chr(Val(TVelDer.Text)) + Chr(1)
        Else
            H = Chr(127) + Chr(Val(TVelDer.Text) - 127)
        End If
        COM.Write("AMD" + H)

    End Sub

    Private Sub FPideEstado_Click(sender As System.Object, e As System.EventArgs) Handles FPideEstado.Click
        COM.Write("AEs")
    End Sub

   
End Class
