Public Class Main
    Dim mi, ti, cd As ULong
    Dim le As Byte
    Dim ts, tn As String
    Dim r As New Random
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 2 To 1024
            CB.Items.Add(i)
        Next
        CB.SelectedIndex = 6
    End Sub

    Private Sub RBT_CheckedChanged(sender As Object, e As EventArgs) Handles RBT.CheckedChanged
        If RBT.Checked = True Then
            G4.Enabled = True
        Else
            G4.Enabled = False
        End If
    End Sub

    Private Sub BG_Click(sender As Object, e As EventArgs) Handles BG.Click
        G1.Enabled = False
        G2.Enabled = False
        G3.Enabled = False
        G4.Enabled = False
        BG.Enabled = False
        If IsNumeric(TB.Text) Then
            If RBT.Checked = True Then
                If CB.SelectedIndex < 17 Then
                    mi = (10 ^ CB.SelectedIndex) * 9
                Else
                    mi = 10 ^ 19
                End If
            Else
                If CB.SelectedIndex < 16 Then
                    mi = (10 ^ (CB.SelectedIndex + 1)) * 9
                Else
                    mi = 10 ^ 19
                End If
            End If
            Try
                ti = CULng(TB.Text)
            Catch ex As Exception
                MsgBox("生成数は10^19以下で入力してください")
                G1.Enabled = True
                G2.Enabled = True
                G3.Enabled = True
                G4.Enabled = True
                BG.Enabled = True
                Exit Sub
            End Try
            If ti <= mi Then
                If ti > 0 Then
                    Dim sw As New IO.StreamWriter("PN.txt", False, System.Text.Encoding.GetEncoding("shift_jis"))
                    ts = ""
                    PB.Maximum = ti
                    For j As ULong = 1 To ti
                        If j Mod 1000 = 0 Then
                            Windows.Forms.Application.DoEvents()
                        End If
                        le = 0
                        Do Until le = 1
                            If RBT.Checked = True Then
                                If CB.SelectedIndex > 8 Then
                                    tn = r.Next(10 ^ ((CB.SelectedIndex + 1) Mod 9 - 1), 10 ^ ((CB.SelectedIndex + 1) Mod 9))
                                    For l As Integer = 1 To (CB.SelectedIndex + 1) \ 9
                                        tn &= r.Next(10 ^ 8, 10 ^ 9)
                                    Next
                                Else
                                    tn = r.Next(10 ^ CB.SelectedIndex, 10 ^ (CB.SelectedIndex + 1))
                                End If
                                cd = 0
                                For k = 1 To tn.ToString.Length
                                    If RPI.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1)) * k
                                    ElseIf RPD.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1)) * (tn.ToString.Length - k)
                                    ElseIf RPT.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1))
                                    ElseIf RPF.Checked = True Then
                                        cd += 9 - CByte(tn.ToString.Substring(k - 1, 1))
                                    ElseIf RPP.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1)) + k
                                    ElseIf RPM.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1)) - k
                                    ElseIf RPS.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1)) ^ 2
                                    ElseIf RPC.Checked = True Then
                                        cd += CByte(tn.ToString.Substring(k - 1, 1)) ^ 3
                                    End If
                                Next
                                cd = CULng(cd.ToString.Substring(cd.ToString.Length - 1, 1))
                                If ts.Contains(tn & cd) = False Then
                                    le = 1
                                    ts &= tn & cd & "!"
                                    sw.WriteLine(tn & cd)
                                End If
                            Else
                                If CB.SelectedIndex > 7 Then
                                    tn = r.Next(10 ^ ((CB.SelectedIndex + 2) Mod 9 - 1), 10 ^ ((CB.SelectedIndex + 2) Mod 9))
                                    For l As Integer = 1 To (CB.SelectedIndex + 2) \ 9
                                        tn &= r.Next(10 ^ 8, 10 ^ 9)
                                    Next
                                Else
                                    tn = r.Next(10 ^ (CB.SelectedIndex + 1), 10 ^ (CB.SelectedIndex + 2))
                                End If
                                If ts.Contains(tn) = False Then
                                    le = 1
                                    ts &= tn & "!"
                                    sw.WriteLine(tn)
                                End If
                            End If
                        Loop
                        PB.Value += 1
                    Next
                    sw.Close()
                    MsgBox("生成が完了しました")
                    PB.Value = 0
                    Diagnostics.Process.Start("PN.txt")
                Else
                    MsgBox("生成数は1以上を指定してください")
                End If
            Else
                MsgBox("指定した生成数が生成可能最大数(" & mi & ")を超えています")
            End If
        Else
            MsgBox("生成数は数字で入力してください")
        End If
        G1.Enabled = True
        G2.Enabled = True
        G3.Enabled = True
        G4.Enabled = True
        BG.Enabled = True
    End Sub
End Class