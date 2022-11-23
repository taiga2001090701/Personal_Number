<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CB = New System.Windows.Forms.ComboBox()
        Me.LD = New System.Windows.Forms.Label()
        Me.RBT = New System.Windows.Forms.RadioButton()
        Me.RBF = New System.Windows.Forms.RadioButton()
        Me.BG = New System.Windows.Forms.Button()
        Me.TB = New System.Windows.Forms.TextBox()
        Me.G1 = New System.Windows.Forms.GroupBox()
        Me.G2 = New System.Windows.Forms.GroupBox()
        Me.G3 = New System.Windows.Forms.GroupBox()
        Me.LI = New System.Windows.Forms.Label()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.G4 = New System.Windows.Forms.GroupBox()
        Me.RPF = New System.Windows.Forms.RadioButton()
        Me.RPT = New System.Windows.Forms.RadioButton()
        Me.RPI = New System.Windows.Forms.RadioButton()
        Me.RPD = New System.Windows.Forms.RadioButton()
        Me.RPP = New System.Windows.Forms.RadioButton()
        Me.RPM = New System.Windows.Forms.RadioButton()
        Me.RPS = New System.Windows.Forms.RadioButton()
        Me.RPC = New System.Windows.Forms.RadioButton()
        Me.G1.SuspendLayout()
        Me.G2.SuspendLayout()
        Me.G3.SuspendLayout()
        Me.G4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB
        '
        Me.CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.CB.FormattingEnabled = True
        Me.CB.Location = New System.Drawing.Point(6, 18)
        Me.CB.Name = "CB"
        Me.CB.Size = New System.Drawing.Size(80, 29)
        Me.CB.TabIndex = 0
        '
        'LD
        '
        Me.LD.AutoSize = True
        Me.LD.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LD.Location = New System.Drawing.Point(92, 21)
        Me.LD.Margin = New System.Windows.Forms.Padding(3)
        Me.LD.Name = "LD"
        Me.LD.Size = New System.Drawing.Size(62, 22)
        Me.LD.TabIndex = 1
        Me.LD.Text = "Digits"
        '
        'RBT
        '
        Me.RBT.AutoSize = True
        Me.RBT.Checked = True
        Me.RBT.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RBT.Location = New System.Drawing.Point(6, 18)
        Me.RBT.Name = "RBT"
        Me.RBT.Size = New System.Drawing.Size(58, 26)
        Me.RBT.TabIndex = 3
        Me.RBT.TabStop = True
        Me.RBT.Text = "ON"
        Me.RBT.UseVisualStyleBackColor = True
        '
        'RBF
        '
        Me.RBF.AutoSize = True
        Me.RBF.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RBF.Location = New System.Drawing.Point(70, 18)
        Me.RBF.Name = "RBF"
        Me.RBF.Size = New System.Drawing.Size(68, 26)
        Me.RBF.TabIndex = 4
        Me.RBF.Text = "OFF"
        Me.RBF.UseVisualStyleBackColor = True
        '
        'BG
        '
        Me.BG.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BG.Location = New System.Drawing.Point(12, 180)
        Me.BG.Name = "BG"
        Me.BG.Size = New System.Drawing.Size(522, 35)
        Me.BG.TabIndex = 5
        Me.BG.Text = "Generate"
        Me.BG.UseVisualStyleBackColor = True
        '
        'TB
        '
        Me.TB.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.TB.Location = New System.Drawing.Point(6, 18)
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(120, 29)
        Me.TB.TabIndex = 6
        Me.TB.Text = "100"
        Me.TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'G1
        '
        Me.G1.AutoSize = True
        Me.G1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.G1.Controls.Add(Me.RBT)
        Me.G1.Controls.Add(Me.RBF)
        Me.G1.Location = New System.Drawing.Point(12, 12)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(144, 62)
        Me.G1.TabIndex = 7
        Me.G1.TabStop = False
        Me.G1.Text = "Checkdigit"
        '
        'G2
        '
        Me.G2.AutoSize = True
        Me.G2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.G2.Controls.Add(Me.CB)
        Me.G2.Controls.Add(Me.LD)
        Me.G2.Location = New System.Drawing.Point(162, 12)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(160, 65)
        Me.G2.TabIndex = 8
        Me.G2.TabStop = False
        Me.G2.Text = "Digit"
        '
        'G3
        '
        Me.G3.AutoSize = True
        Me.G3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.G3.Controls.Add(Me.LI)
        Me.G3.Controls.Add(Me.TB)
        Me.G3.Location = New System.Drawing.Point(328, 12)
        Me.G3.Name = "G3"
        Me.G3.Size = New System.Drawing.Size(198, 65)
        Me.G3.TabIndex = 9
        Me.G3.TabStop = False
        Me.G3.Text = "Item"
        '
        'LI
        '
        Me.LI.AutoSize = True
        Me.LI.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LI.Location = New System.Drawing.Point(132, 21)
        Me.LI.Margin = New System.Windows.Forms.Padding(3)
        Me.LI.Name = "LI"
        Me.LI.Size = New System.Drawing.Size(60, 22)
        Me.LI.TabIndex = 7
        Me.LI.Text = "Items"
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(12, 221)
        Me.PB.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(522, 23)
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PB.TabIndex = 10
        '
        'G4
        '
        Me.G4.AutoSize = True
        Me.G4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.G4.Controls.Add(Me.RPC)
        Me.G4.Controls.Add(Me.RPS)
        Me.G4.Controls.Add(Me.RPM)
        Me.G4.Controls.Add(Me.RPP)
        Me.G4.Controls.Add(Me.RPF)
        Me.G4.Controls.Add(Me.RPT)
        Me.G4.Controls.Add(Me.RPI)
        Me.G4.Controls.Add(Me.RPD)
        Me.G4.Location = New System.Drawing.Point(12, 80)
        Me.G4.Name = "G4"
        Me.G4.Size = New System.Drawing.Size(522, 94)
        Me.G4.TabIndex = 8
        Me.G4.TabStop = False
        Me.G4.Text = "Checkdigit Pattern"
        '
        'RPF
        '
        Me.RPF.AutoSize = True
        Me.RPF.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPF.Location = New System.Drawing.Point(396, 18)
        Me.RPF.Name = "RPF"
        Me.RPF.Size = New System.Drawing.Size(117, 26)
        Me.RPF.TabIndex = 6
        Me.RPF.Text = "Pattern F"
        Me.RPF.UseVisualStyleBackColor = True
        '
        'RPT
        '
        Me.RPT.AutoSize = True
        Me.RPT.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPT.Location = New System.Drawing.Point(266, 18)
        Me.RPT.Name = "RPT"
        Me.RPT.Size = New System.Drawing.Size(118, 26)
        Me.RPT.TabIndex = 5
        Me.RPT.Text = "Pattern T"
        Me.RPT.UseVisualStyleBackColor = True
        '
        'RPI
        '
        Me.RPI.AutoSize = True
        Me.RPI.Checked = True
        Me.RPI.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPI.Location = New System.Drawing.Point(6, 18)
        Me.RPI.Name = "RPI"
        Me.RPI.Size = New System.Drawing.Size(110, 26)
        Me.RPI.TabIndex = 3
        Me.RPI.TabStop = True
        Me.RPI.Text = "Pattern I"
        Me.RPI.UseVisualStyleBackColor = True
        '
        'RPD
        '
        Me.RPD.AutoSize = True
        Me.RPD.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPD.Location = New System.Drawing.Point(136, 18)
        Me.RPD.Name = "RPD"
        Me.RPD.Size = New System.Drawing.Size(119, 26)
        Me.RPD.TabIndex = 4
        Me.RPD.Text = "Pattern D"
        Me.RPD.UseVisualStyleBackColor = True
        '
        'RPP
        '
        Me.RPP.AutoSize = True
        Me.RPP.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPP.Location = New System.Drawing.Point(6, 50)
        Me.RPP.Name = "RPP"
        Me.RPP.Size = New System.Drawing.Size(119, 26)
        Me.RPP.TabIndex = 7
        Me.RPP.Text = "Pattern P"
        Me.RPP.UseVisualStyleBackColor = True
        '
        'RPM
        '
        Me.RPM.AutoSize = True
        Me.RPM.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPM.Location = New System.Drawing.Point(136, 50)
        Me.RPM.Name = "RPM"
        Me.RPM.Size = New System.Drawing.Size(121, 26)
        Me.RPM.TabIndex = 8
        Me.RPM.Text = "Pattern M"
        Me.RPM.UseVisualStyleBackColor = True
        '
        'RPS
        '
        Me.RPS.AutoSize = True
        Me.RPS.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPS.Location = New System.Drawing.Point(266, 50)
        Me.RPS.Name = "RPS"
        Me.RPS.Size = New System.Drawing.Size(118, 26)
        Me.RPS.TabIndex = 9
        Me.RPS.Text = "Pattern S"
        Me.RPS.UseVisualStyleBackColor = True
        '
        'RPC
        '
        Me.RPC.AutoSize = True
        Me.RPC.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.RPC.Location = New System.Drawing.Point(396, 50)
        Me.RPC.Name = "RPC"
        Me.RPC.Size = New System.Drawing.Size(120, 26)
        Me.RPC.TabIndex = 10
        Me.RPC.Text = "Pattern C"
        Me.RPC.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(544, 259)
        Me.Controls.Add(Me.G4)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.G3)
        Me.Controls.Add(Me.G2)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.BG)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.G1.ResumeLayout(False)
        Me.G1.PerformLayout()
        Me.G2.ResumeLayout(False)
        Me.G2.PerformLayout()
        Me.G3.ResumeLayout(False)
        Me.G3.PerformLayout()
        Me.G4.ResumeLayout(False)
        Me.G4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB As Windows.Forms.ComboBox
    Friend WithEvents LD As Windows.Forms.Label
    Friend WithEvents RBT As Windows.Forms.RadioButton
    Friend WithEvents RBF As Windows.Forms.RadioButton
    Friend WithEvents BG As Windows.Forms.Button
    Friend WithEvents TB As Windows.Forms.TextBox
    Friend WithEvents G1 As Windows.Forms.GroupBox
    Friend WithEvents G2 As Windows.Forms.GroupBox
    Friend WithEvents G3 As Windows.Forms.GroupBox
    Friend WithEvents LI As Windows.Forms.Label
    Friend WithEvents PB As Windows.Forms.ProgressBar
    Friend WithEvents G4 As Windows.Forms.GroupBox
    Friend WithEvents RPT As Windows.Forms.RadioButton
    Friend WithEvents RPI As Windows.Forms.RadioButton
    Friend WithEvents RPD As Windows.Forms.RadioButton
    Friend WithEvents RPF As Windows.Forms.RadioButton
    Friend WithEvents RPM As Windows.Forms.RadioButton
    Friend WithEvents RPP As Windows.Forms.RadioButton
    Friend WithEvents RPC As Windows.Forms.RadioButton
    Friend WithEvents RPS As Windows.Forms.RadioButton
End Class
