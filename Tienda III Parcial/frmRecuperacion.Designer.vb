<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperacion))
        Me.rtxHtml = New System.Windows.Forms.RichTextBox()
        Me.txtPswMostra = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnEnviarCorreo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtxHtml
        '
        Me.rtxHtml.Location = New System.Drawing.Point(560, 195)
        Me.rtxHtml.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxHtml.Name = "rtxHtml"
        Me.rtxHtml.Size = New System.Drawing.Size(240, 128)
        Me.rtxHtml.TabIndex = 632
        Me.rtxHtml.Text = resources.GetString("rtxHtml.Text")
        '
        'txtPswMostra
        '
        Me.txtPswMostra.AutoSize = True
        Me.txtPswMostra.BackColor = System.Drawing.Color.White
        Me.txtPswMostra.Location = New System.Drawing.Point(400, 329)
        Me.txtPswMostra.Name = "txtPswMostra"
        Me.txtPswMostra.Size = New System.Drawing.Size(51, 17)
        Me.txtPswMostra.TabIndex = 631
        Me.txtPswMostra.Text = "Label2"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtCorreo.ForeColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(153, 195)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(361, 38)
        Me.txtCorreo.TabIndex = 630
        Me.txtCorreo.Tag = "Ingresar contraseña"
        '
        'btnEnviarCorreo
        '
        Me.btnEnviarCorreo.BackColor = System.Drawing.Color.Black
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarCorreo.FlatAppearance.BorderSize = 0
        Me.btnEnviarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEnviarCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(131, 303)
        Me.btnEnviarCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(336, 64)
        Me.btnEnviarCorreo.TabIndex = 629
        Me.btnEnviarCorreo.Text = "Recuperar"
        Me.btnEnviarCorreo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(35, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 628
        Me.Label1.Text = "Correo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(131, 237)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(413, 1)
        Me.Panel4.TabIndex = 627
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(800, 94)
        Me.Label3.TabIndex = 626
        Me.Label3.Text = "Recuperar contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRecuperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtxHtml)
        Me.Controls.Add(Me.txtPswMostra)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.btnEnviarCorreo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmRecuperacion"
        Me.Text = "frmRecuperacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtxHtml As RichTextBox
    Friend WithEvents txtPswMostra As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnEnviarCorreo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
End Class
