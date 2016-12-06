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
        '
        'TVelIzq
        '
        Me.TVelIzq.Location = New System.Drawing.Point(123, 412)
        Me.TVelIzq.Name = "TVelIzq"
        Me.TVelIzq.Size = New System.Drawing.Size(50, 22)
        Me.TVelIzq.TabIndex = 0
        Me.TVelIzq.Text = "100"
        '
        'TVelDer
        '
        Me.TVelDer.Location = New System.Drawing.Point(305, 412)
        Me.TVelDer.Name = "TVelDer"
        Me.TVelDer.Size = New System.Drawing.Size(50, 22)
        Me.TVelDer.TabIndex = 1
        Me.TVelDer.Text = "100"
        '
        'TRx
        '
        Me.TRx.Location = New System.Drawing.Point(888, 134)
        Me.TRx.Multiline = True
        Me.TRx.Name = "TRx"
        Me.TRx.Size = New System.Drawing.Size(154, 64)
        Me.TRx.TabIndex = 2
        '
        'TRxAcum
        '
        Me.TRxAcum.Location = New System.Drawing.Point(888, 204)
        Me.TRxAcum.Multiline = True
        Me.TRxAcum.Name = "TRxAcum"
        Me.TRxAcum.Size = New System.Drawing.Size(154, 236)
        Me.TRxAcum.TabIndex = 3
        '
        'TRelDer
        '
        Me.TRelDer.Location = New System.Drawing.Point(224, 340)
        Me.TRelDer.Name = "TRelDer"
        Me.TRelDer.Size = New System.Drawing.Size(50, 22)
        Me.TRelDer.TabIndex = 4
        Me.TRelDer.Text = "0"
        '
        'TRelIzq
        '
        Me.TRelIzq.Location = New System.Drawing.Point(101, 340)
        Me.TRelIzq.Name = "TRelIzq"
        Me.TRelIzq.Size = New System.Drawing.Size(50, 22)
        Me.TRelIzq.TabIndex = 5
        Me.TRelIzq.Text = "0"
        '
        'TSonIzq
        '
        Me.TSonIzq.Location = New System.Drawing.Point(500, 166)
        Me.TSonIzq.Name = "TSonIzq"
        Me.TSonIzq.Size = New System.Drawing.Size(50, 22)
        Me.TSonIzq.TabIndex = 6
        '
        'TSonDer
        '
        Me.TSonDer.Location = New System.Drawing.Point(628, 166)
        Me.TSonDer.Name = "TSonDer"
        Me.TSonDer.Size = New System.Drawing.Size(50, 22)
        Me.TSonDer.TabIndex = 7
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ShRun})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1092, 501)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'ShRun
        '
        Me.ShRun.BackColor = System.Drawing.Color.Green
        Me.ShRun.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ShRun.Location = New System.Drawing.Point(592, 74)
        Me.ShRun.Name = "ShRun"
        Me.ShRun.Size = New System.Drawing.Size(20, 20)
        '
        'FRunIzq
        '
        Me.FRunIzq.Location = New System.Drawing.Point(499, 257)
        Me.FRunIzq.Name = "FRunIzq"
        Me.FRunIzq.Size = New System.Drawing.Size(60, 28)
        Me.FRunIzq.TabIndex = 9
        Me.FRunIzq.Text = "FRunIzq"
        Me.FRunIzq.UseVisualStyleBackColor = True
        Me.FRunIzq.Visible = False
        '
        'FRunDer
        '
        Me.FRunDer.Location = New System.Drawing.Point(618, 257)
        Me.FRunDer.Name = "FRunDer"
        Me.FRunDer.Size = New System.Drawing.Size(60, 28)
        Me.FRunDer.TabIndex = 10
        Me.FRunDer.Text = "FRunDer"
        Me.FRunDer.UseVisualStyleBackColor = True
        Me.FRunDer.Visible = False
        '
        'Com
        '
        Me.Com.PortName = "COM4"
        '
        'HDir
        '
        Me.HDir.Location = New System.Drawing.Point(49, 282)
        Me.HDir.Minimum = -100
        Me.HDir.Name = "HDir"
        Me.HDir.Size = New System.Drawing.Size(241, 18)
        Me.HDir.TabIndex = 11
        '
        'HVel
        '
        Me.HVel.Location = New System.Drawing.Point(101, 455)
        Me.HVel.Maximum = 255
        Me.HVel.Name = "HVel"
        Me.HVel.Size = New System.Drawing.Size(284, 18)
        Me.HVel.TabIndex = 12
        '
        'TVel
        '
        Me.TVel.Location = New System.Drawing.Point(212, 412)
        Me.TVel.Name = "TVel"
        Me.TVel.Size = New System.Drawing.Size(50, 22)
        Me.TVel.TabIndex = 13
        Me.TVel.Text = "100"
        '
        'TSeg
        '
        Me.TSeg.Location = New System.Drawing.Point(911, 85)
        Me.TSeg.Name = "TSeg"
        Me.TSeg.Size = New System.Drawing.Size(50, 22)
        Me.TSeg.TabIndex = 14
        '
        'TRelIzqRx
        '
        Me.TRelIzqRx.Location = New System.Drawing.Point(500, 324)
        Me.TRelIzqRx.Name = "TRelIzqRx"
        Me.TRelIzqRx.Size = New System.Drawing.Size(50, 22)
        Me.TRelIzqRx.TabIndex = 15
        '
        'TRelDerRx
        '
        Me.TRelDerRx.Location = New System.Drawing.Point(628, 324)
        Me.TRelDerRx.Name = "TRelDerRx"
        Me.TRelDerRx.Size = New System.Drawing.Size(50, 22)
        Me.TRelDerRx.TabIndex = 16
        '
        'TVelIzqRx
        '
        Me.TVelIzqRx.Location = New System.Drawing.Point(499, 229)
        Me.TVelIzqRx.Name = "TVelIzqRx"
        Me.TVelIzqRx.Size = New System.Drawing.Size(50, 22)
        Me.TVelIzqRx.TabIndex = 17
        '
        'TVelDerRx
        '
        Me.TVelDerRx.Location = New System.Drawing.Point(628, 229)
        Me.TVelDerRx.Name = "TVelDerRx"
        Me.TVelDerRx.Size = New System.Drawing.Size(50, 22)
        Me.TVelDerRx.TabIndex = 18
        '
        'BAdel
        '
        Me.BAdel.Location = New System.Drawing.Point(155, 151)
        Me.BAdel.Name = "BAdel"
        Me.BAdel.Size = New System.Drawing.Size(63, 22)
        Me.BAdel.TabIndex = 19
        Me.BAdel.Text = "Adel"
        Me.BAdel.UseVisualStyleBackColor = True
        '
        'BRev
        '
        Me.BRev.Location = New System.Drawing.Point(155, 204)
        Me.BRev.Name = "BRev"
        Me.BRev.Size = New System.Drawing.Size(63, 22)
        Me.BRev.TabIndex = 20
        Me.BRev.Text = "BRev"
        Me.BRev.UseVisualStyleBackColor = True
        '
        'BRun
        '
        Me.BRun.Location = New System.Drawing.Point(155, 73)
        Me.BRun.Name = "BRun"
        Me.BRun.Size = New System.Drawing.Size(63, 22)
        Me.BRun.TabIndex = 21
        Me.BRun.Text = "Run"
        Me.BRun.UseVisualStyleBackColor = True
        '
        'BStop
        '
        Me.BStop.Location = New System.Drawing.Point(155, 101)
        Me.BStop.Name = "BStop"
        Me.BStop.Size = New System.Drawing.Size(63, 22)
        Me.BStop.TabIndex = 22
        Me.BStop.Text = "Stop"
        Me.BStop.UseVisualStyleBackColor = True
        '
        'TDir
        '
        Me.TDir.Location = New System.Drawing.Point(142, 257)
        Me.TDir.Name = "TDir"
        Me.TDir.Size = New System.Drawing.Size(50, 22)
        Me.TDir.TabIndex = 23
        Me.TDir.Text = "0"
        '
        'TLlantaIzq
        '
        Me.TLlantaIzq.Location = New System.Drawing.Point(461, 244)
        Me.TLlantaIzq.Multiline = True
        Me.TLlantaIzq.Name = "TLlantaIzq"
        Me.TLlantaIzq.Size = New System.Drawing.Size(32, 118)
        Me.TLlantaIzq.TabIndex = 24
        '
        'TLlantaDer
        '
        Me.TLlantaDer.Location = New System.Drawing.Point(684, 244)
        Me.TLlantaDer.Multiline = True
        Me.TLlantaDer.Name = "TLlantaDer"
        Me.TLlantaDer.Size = New System.Drawing.Size(32, 118)
        Me.TLlantaDer.TabIndex = 25
        '
        'FLlantas
        '
        Me.FLlantas.Location = New System.Drawing.Point(552, 291)
        Me.FLlantas.Name = "FLlantas"
        Me.FLlantas.Size = New System.Drawing.Size(77, 28)
        Me.FLlantas.TabIndex = 26
        Me.FLlantas.Text = "FLlantas"
        Me.FLlantas.UseVisualStyleBackColor = True
        Me.FLlantas.Visible = False
        '
        'FPideEstado
        '
        Me.FPideEstado.Location = New System.Drawing.Point(671, 51)
        Me.FPideEstado.Name = "FPideEstado"
        Me.FPideEstado.Size = New System.Drawing.Size(105, 28)
        Me.FPideEstado.TabIndex = 27
        Me.FPideEstado.Text = "FPideEstado"
        Me.FPideEstado.UseVisualStyleBackColor = True
        Me.FPideEstado.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 501)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
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

End Class
