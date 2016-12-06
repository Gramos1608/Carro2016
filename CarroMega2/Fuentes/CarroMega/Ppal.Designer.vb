<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimIni = New System.Windows.Forms.Timer(Me.components)
        Me.TimRx = New System.Windows.Forms.Timer(Me.components)
        Me.TVelIzq = New System.Windows.Forms.TextBox()
        Me.TVelDer = New System.Windows.Forms.TextBox()
        Me.TRx = New System.Windows.Forms.TextBox()
        Me.TRxAcum = New System.Windows.Forms.TextBox()
        Me.TRelDer = New System.Windows.Forms.TextBox()
        Me.TRelIzq = New System.Windows.Forms.TextBox()
        Me.TSonIzq = New System.Windows.Forms.TextBox()
        Me.TSonDer = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ShRun = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.FRunIzq = New System.Windows.Forms.Button()
        Me.FRunDer = New System.Windows.Forms.Button()
        Me.Com = New System.IO.Ports.SerialPort(Me.components)
        Me.HDir = New System.Windows.Forms.HScrollBar()
        Me.HVel = New System.Windows.Forms.HScrollBar()
        Me.TVel = New System.Windows.Forms.TextBox()
        Me.TSeg = New System.Windows.Forms.TextBox()
        Me.TRelIzqRx = New System.Windows.Forms.TextBox()
        Me.TRelDerRx = New System.Windows.Forms.TextBox()
        Me.TVelIzqRx = New System.Windows.Forms.TextBox()
        Me.TVelDerRx = New System.Windows.Forms.TextBox()
        Me.BAdel = New System.Windows.Forms.Button()
        Me.BRev = New System.Windows.Forms.Button()
        Me.BRun = New System.Windows.Forms.Button()
        Me.BStop = New System.Windows.Forms.Button()
        Me.TDir = New System.Windows.Forms.TextBox()
        Me.TLlantaIzq = New System.Windows.Forms.TextBox()
        Me.TLlantaDer = New System.Windows.Forms.TextBox()
        Me.FLlantas = New System.Windows.Forms.Button()
        Me.FPideEstado = New System.Windows.Forms.Button()
        Me.TSonar = New System.Windows.Forms.TextBox()
        Me.TTacometro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TimIni
        '
        Me.TimIni.Enabled = True
        Me.TimIni.Interval = 30
        '
        'TimRx
        '
        Me.TimRx.Enabled = True
        Me.TimRx.Interval = 200
        '
        'TVelIzq
        '
        Me.TVelIzq.Location = New System.Drawing.Point(76, 349)
        Me.TVelIzq.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TVelIzq.Name = "TVelIzq"
        Me.TVelIzq.Size = New System.Drawing.Size(28, 20)
        Me.TVelIzq.TabIndex = 0
        Me.TVelIzq.Text = "128"
        '
        'TVelDer
        '
        Me.TVelDer.Location = New System.Drawing.Point(263, 349)
        Me.TVelDer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TVelDer.Name = "TVelDer"
        Me.TVelDer.Size = New System.Drawing.Size(26, 20)
        Me.TVelDer.TabIndex = 1
        Me.TVelDer.Text = "128"
        '
        'TRx
        '
        Me.TRx.Location = New System.Drawing.Point(666, 109)
        Me.TRx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TRx.Multiline = True
        Me.TRx.Name = "TRx"
        Me.TRx.Size = New System.Drawing.Size(116, 76)
        Me.TRx.TabIndex = 2
        '
        'TRxAcum
        '
        Me.TRxAcum.Location = New System.Drawing.Point(666, 188)
        Me.TRxAcum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TRxAcum.Multiline = True
        Me.TRxAcum.Name = "TRxAcum"
        Me.TRxAcum.Size = New System.Drawing.Size(116, 170)
        Me.TRxAcum.TabIndex = 3
        '
        'TRelDer
        '
        Me.TRelDer.Location = New System.Drawing.Point(149, 143)
        Me.TRelDer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TRelDer.Name = "TRelDer"
        Me.TRelDer.Size = New System.Drawing.Size(15, 20)
        Me.TRelDer.TabIndex = 4
        Me.TRelDer.Text = "0"
        '
        'TRelIzq
        '
        Me.TRelIzq.Location = New System.Drawing.Point(116, 143)
        Me.TRelIzq.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TRelIzq.Name = "TRelIzq"
        Me.TRelIzq.Size = New System.Drawing.Size(14, 20)
        Me.TRelIzq.TabIndex = 5
        Me.TRelIzq.Text = "0"
        '
        'TSonIzq
        '
        Me.TSonIzq.Location = New System.Drawing.Point(375, 115)
        Me.TSonIzq.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TSonIzq.Name = "TSonIzq"
        Me.TSonIzq.Size = New System.Drawing.Size(38, 20)
        Me.TSonIzq.TabIndex = 6
        '
        'TSonDer
        '
        Me.TSonDer.Location = New System.Drawing.Point(444, 115)
        Me.TSonDer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TSonDer.Name = "TSonDer"
        Me.TSonDer.Size = New System.Drawing.Size(38, 20)
        Me.TSonDer.TabIndex = 7
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ShRun})
        Me.ShapeContainer1.Size = New System.Drawing.Size(819, 407)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'ShRun
        '
        Me.ShRun.BackColor = System.Drawing.Color.Green
        Me.ShRun.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ShRun.Location = New System.Drawing.Point(561, 103)
        Me.ShRun.Name = "ShRun"
        Me.ShRun.Size = New System.Drawing.Size(20, 20)
        '
        'FRunIzq
        '
        Me.FRunIzq.Location = New System.Drawing.Point(374, 209)
        Me.FRunIzq.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FRunIzq.Name = "FRunIzq"
        Me.FRunIzq.Size = New System.Drawing.Size(45, 23)
        Me.FRunIzq.TabIndex = 9
        Me.FRunIzq.Text = "FRunIzq"
        Me.FRunIzq.UseVisualStyleBackColor = True
        Me.FRunIzq.Visible = False
        '
        'FRunDer
        '
        Me.FRunDer.Location = New System.Drawing.Point(435, 209)
        Me.FRunDer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FRunDer.Name = "FRunDer"
        Me.FRunDer.Size = New System.Drawing.Size(45, 23)
        Me.FRunDer.TabIndex = 10
        Me.FRunDer.Text = "FRunDer"
        Me.FRunDer.UseVisualStyleBackColor = True
        Me.FRunDer.Visible = False
        '
        'Com
        '
        Me.Com.PortName = "COM6"
        '
        'HDir
        '
        Me.HDir.Location = New System.Drawing.Point(37, 229)
        Me.HDir.Maximum = 105
        Me.HDir.Minimum = -100
        Me.HDir.Name = "HDir"
        Me.HDir.Size = New System.Drawing.Size(181, 18)
        Me.HDir.TabIndex = 11
        '
        'HVel
        '
        Me.HVel.Location = New System.Drawing.Point(76, 370)
        Me.HVel.Maximum = 255
        Me.HVel.Name = "HVel"
        Me.HVel.Size = New System.Drawing.Size(213, 18)
        Me.HVel.TabIndex = 12
        Me.HVel.Value = 128
        '
        'TVel
        '
        Me.TVel.Location = New System.Drawing.Point(168, 349)
        Me.TVel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TVel.Name = "TVel"
        Me.TVel.Size = New System.Drawing.Size(26, 20)
        Me.TVel.TabIndex = 13
        Me.TVel.Text = "128"
        '
        'TSeg
        '
        Me.TSeg.Location = New System.Drawing.Point(683, 69)
        Me.TSeg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TSeg.Name = "TSeg"
        Me.TSeg.Size = New System.Drawing.Size(38, 20)
        Me.TSeg.TabIndex = 14
        '
        'TRelIzqRx
        '
        Me.TRelIzqRx.Location = New System.Drawing.Point(375, 263)
        Me.TRelIzqRx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TRelIzqRx.Name = "TRelIzqRx"
        Me.TRelIzqRx.Size = New System.Drawing.Size(17, 20)
        Me.TRelIzqRx.TabIndex = 15
        '
        'TRelDerRx
        '
        Me.TRelDerRx.Location = New System.Drawing.Point(465, 263)
        Me.TRelDerRx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TRelDerRx.Name = "TRelDerRx"
        Me.TRelDerRx.Size = New System.Drawing.Size(16, 20)
        Me.TRelDerRx.TabIndex = 16
        '
        'TVelIzqRx
        '
        Me.TVelIzqRx.Location = New System.Drawing.Point(374, 186)
        Me.TVelIzqRx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TVelIzqRx.Name = "TVelIzqRx"
        Me.TVelIzqRx.Size = New System.Drawing.Size(38, 20)
        Me.TVelIzqRx.TabIndex = 17
        '
        'TVelDerRx
        '
        Me.TVelDerRx.Location = New System.Drawing.Point(442, 186)
        Me.TVelDerRx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TVelDerRx.Name = "TVelDerRx"
        Me.TVelDerRx.Size = New System.Drawing.Size(38, 20)
        Me.TVelDerRx.TabIndex = 18
        '
        'BAdel
        '
        Me.BAdel.Location = New System.Drawing.Point(116, 123)
        Me.BAdel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BAdel.Name = "BAdel"
        Me.BAdel.Size = New System.Drawing.Size(47, 18)
        Me.BAdel.TabIndex = 19
        Me.BAdel.Text = "Adel"
        Me.BAdel.UseVisualStyleBackColor = True
        '
        'BRev
        '
        Me.BRev.Location = New System.Drawing.Point(116, 166)
        Me.BRev.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BRev.Name = "BRev"
        Me.BRev.Size = New System.Drawing.Size(47, 18)
        Me.BRev.TabIndex = 20
        Me.BRev.Text = "BRev"
        Me.BRev.UseVisualStyleBackColor = True
        '
        'BRun
        '
        Me.BRun.Location = New System.Drawing.Point(208, 109)
        Me.BRun.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BRun.Name = "BRun"
        Me.BRun.Size = New System.Drawing.Size(47, 29)
        Me.BRun.TabIndex = 21
        Me.BRun.Text = "Run"
        Me.BRun.UseVisualStyleBackColor = True
        '
        'BStop
        '
        Me.BStop.Location = New System.Drawing.Point(208, 143)
        Me.BStop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BStop.Name = "BStop"
        Me.BStop.Size = New System.Drawing.Size(47, 27)
        Me.BStop.TabIndex = 22
        Me.BStop.Text = "Stop"
        Me.BStop.UseVisualStyleBackColor = True
        '
        'TDir
        '
        Me.TDir.Location = New System.Drawing.Point(116, 209)
        Me.TDir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TDir.Name = "TDir"
        Me.TDir.Size = New System.Drawing.Size(24, 20)
        Me.TDir.TabIndex = 23
        Me.TDir.Text = "0"
        '
        'TLlantaIzq
        '
        Me.TLlantaIzq.Location = New System.Drawing.Point(346, 198)
        Me.TLlantaIzq.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TLlantaIzq.Multiline = True
        Me.TLlantaIzq.Name = "TLlantaIzq"
        Me.TLlantaIzq.Size = New System.Drawing.Size(25, 97)
        Me.TLlantaIzq.TabIndex = 24
        '
        'TLlantaDer
        '
        Me.TLlantaDer.Location = New System.Drawing.Point(484, 198)
        Me.TLlantaDer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TLlantaDer.Multiline = True
        Me.TLlantaDer.Name = "TLlantaDer"
        Me.TLlantaDer.Size = New System.Drawing.Size(25, 97)
        Me.TLlantaDer.TabIndex = 25
        '
        'FLlantas
        '
        Me.FLlantas.Location = New System.Drawing.Point(386, 236)
        Me.FLlantas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FLlantas.Name = "FLlantas"
        Me.FLlantas.Size = New System.Drawing.Size(58, 23)
        Me.FLlantas.TabIndex = 26
        Me.FLlantas.Text = "FLlantas"
        Me.FLlantas.UseVisualStyleBackColor = True
        Me.FLlantas.Visible = False
        '
        'FPideEstado
        '
        Me.FPideEstado.Location = New System.Drawing.Point(503, 41)
        Me.FPideEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FPideEstado.Name = "FPideEstado"
        Me.FPideEstado.Size = New System.Drawing.Size(79, 23)
        Me.FPideEstado.TabIndex = 27
        Me.FPideEstado.Text = "FPideEstado"
        Me.FPideEstado.UseVisualStyleBackColor = True
        Me.FPideEstado.Visible = False
        '
        'TSonar
        '
        Me.TSonar.Location = New System.Drawing.Point(37, 83)
        Me.TSonar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TSonar.Name = "TSonar"
        Me.TSonar.Size = New System.Drawing.Size(38, 20)
        Me.TSonar.TabIndex = 28
        Me.TSonar.Text = "120"
        '
        'TTacometro
        '
        Me.TTacometro.Location = New System.Drawing.Point(421, 147)
        Me.TTacometro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TTacometro.Name = "TTacometro"
        Me.TTacometro.Size = New System.Drawing.Size(16, 20)
        Me.TTacometro.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 407)
        Me.Controls.Add(Me.TTacometro)
        Me.Controls.Add(Me.TSonar)
        Me.Controls.Add(Me.FPideEstado)
        Me.Controls.Add(Me.FLlantas)
        Me.Controls.Add(Me.TLlantaDer)
        Me.Controls.Add(Me.TLlantaIzq)
        Me.Controls.Add(Me.TDir)
        Me.Controls.Add(Me.BStop)
        Me.Controls.Add(Me.BRun)
        Me.Controls.Add(Me.BRev)
        Me.Controls.Add(Me.BAdel)
        Me.Controls.Add(Me.TVelDerRx)
        Me.Controls.Add(Me.TVelIzqRx)
        Me.Controls.Add(Me.TRelDerRx)
        Me.Controls.Add(Me.TRelIzqRx)
        Me.Controls.Add(Me.TSeg)
        Me.Controls.Add(Me.TVel)
        Me.Controls.Add(Me.HVel)
        Me.Controls.Add(Me.HDir)
        Me.Controls.Add(Me.FRunDer)
        Me.Controls.Add(Me.FRunIzq)
        Me.Controls.Add(Me.TSonDer)
        Me.Controls.Add(Me.TSonIzq)
        Me.Controls.Add(Me.TRelIzq)
        Me.Controls.Add(Me.TRelDer)
        Me.Controls.Add(Me.TRxAcum)
        Me.Controls.Add(Me.TRx)
        Me.Controls.Add(Me.TVelDer)
        Me.Controls.Add(Me.TVelIzq)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "CarroMega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimIni As System.Windows.Forms.Timer
    Friend WithEvents TimRx As System.Windows.Forms.Timer
    Friend WithEvents TVelIzq As System.Windows.Forms.TextBox
    Friend WithEvents TVelDer As System.Windows.Forms.TextBox
    Friend WithEvents TRx As System.Windows.Forms.TextBox
    Friend WithEvents TRxAcum As System.Windows.Forms.TextBox
    Friend WithEvents TRelDer As System.Windows.Forms.TextBox
    Friend WithEvents TRelIzq As System.Windows.Forms.TextBox
    Friend WithEvents TSonIzq As System.Windows.Forms.TextBox
    Friend WithEvents TSonDer As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ShRun As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents FRunIzq As System.Windows.Forms.Button
    Friend WithEvents FRunDer As System.Windows.Forms.Button
    Friend WithEvents Com As System.IO.Ports.SerialPort
    Friend WithEvents HDir As System.Windows.Forms.HScrollBar
    Friend WithEvents HVel As System.Windows.Forms.HScrollBar
    Friend WithEvents TVel As System.Windows.Forms.TextBox
    Friend WithEvents TSeg As System.Windows.Forms.TextBox
    Friend WithEvents TRelIzqRx As System.Windows.Forms.TextBox
    Friend WithEvents TRelDerRx As System.Windows.Forms.TextBox
    Friend WithEvents TVelIzqRx As System.Windows.Forms.TextBox
    Friend WithEvents TVelDerRx As System.Windows.Forms.TextBox
    Friend WithEvents BAdel As System.Windows.Forms.Button
    Friend WithEvents BRev As System.Windows.Forms.Button
    Friend WithEvents BRun As System.Windows.Forms.Button
    Friend WithEvents BStop As System.Windows.Forms.Button
    Friend WithEvents TDir As System.Windows.Forms.TextBox
    Friend WithEvents TLlantaIzq As System.Windows.Forms.TextBox
    Friend WithEvents TLlantaDer As System.Windows.Forms.TextBox
    Friend WithEvents FLlantas As System.Windows.Forms.Button
    Friend WithEvents FPideEstado As System.Windows.Forms.Button
    Friend WithEvents TSonar As System.Windows.Forms.TextBox
    Friend WithEvents TTacometro As System.Windows.Forms.TextBox

End Class
