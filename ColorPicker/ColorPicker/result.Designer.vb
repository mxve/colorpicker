<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class result
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
        Me.txtHEX = New System.Windows.Forms.TextBox()
        Me.txtCMYK = New System.Windows.Forms.TextBox()
        Me.txtRGB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.colorPanel = New System.Windows.Forms.Panel()
        Me.txtRGBA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRGBf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRGBAf = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHEX
        '
        Me.txtHEX.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtHEX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHEX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtHEX.Location = New System.Drawing.Point(81, 62)
        Me.txtHEX.Name = "txtHEX"
        Me.txtHEX.Size = New System.Drawing.Size(170, 20)
        Me.txtHEX.TabIndex = 1
        '
        'txtCMYK
        '
        Me.txtCMYK.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtCMYK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCMYK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCMYK.Location = New System.Drawing.Point(81, 193)
        Me.txtCMYK.Name = "txtCMYK"
        Me.txtCMYK.Size = New System.Drawing.Size(170, 20)
        Me.txtCMYK.TabIndex = 6
        '
        'txtRGB
        '
        Me.txtRGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRGB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRGB.Location = New System.Drawing.Point(81, 88)
        Me.txtRGB.Name = "txtRGB"
        Me.txtRGB.Size = New System.Drawing.Size(170, 20)
        Me.txtRGB.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.colorPanel)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 37)
        Me.Panel1.TabIndex = 11
        '
        'colorPanel
        '
        Me.colorPanel.Location = New System.Drawing.Point(2, 2)
        Me.colorPanel.Name = "colorPanel"
        Me.colorPanel.Size = New System.Drawing.Size(235, 33)
        Me.colorPanel.TabIndex = 5
        '
        'txtRGBA
        '
        Me.txtRGBA.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtRGBA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRGBA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRGBA.Location = New System.Drawing.Point(81, 140)
        Me.txtRGBA.Name = "txtRGBA"
        Me.txtRGBA.Size = New System.Drawing.Size(170, 20)
        Me.txtRGBA.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "HEX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "RGB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "RGBA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "CMYK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "RGB Float"
        '
        'txtRGBf
        '
        Me.txtRGBf.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtRGBf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRGBf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRGBf.Location = New System.Drawing.Point(81, 114)
        Me.txtRGBf.Name = "txtRGBf"
        Me.txtRGBf.Size = New System.Drawing.Size(170, 20)
        Me.txtRGBf.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "RGBA Float"
        '
        'txtRGBAf
        '
        Me.txtRGBAf.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtRGBAf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRGBAf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRGBAf.Location = New System.Drawing.Point(81, 166)
        Me.txtRGBAf.Name = "txtRGBAf"
        Me.txtRGBAf.Size = New System.Drawing.Size(170, 20)
        Me.txtRGBAf.TabIndex = 5
        '
        'result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(263, 225)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRGBAf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRGBf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHEX)
        Me.Controls.Add(Me.txtCMYK)
        Me.Controls.Add(Me.txtRGB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRGBA)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "result"
        Me.Text = "Color Picker Result"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHEX As TextBox
    Friend WithEvents txtCMYK As TextBox
    Friend WithEvents txtRGB As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents colorPanel As Panel
    Friend WithEvents txtRGBA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRGBf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRGBAf As TextBox
End Class
