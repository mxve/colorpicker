<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.previewUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.history = New System.Windows.Forms.ListBox()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'previewUpdater
        '
        Me.previewUpdater.Interval = 50
        '
        'history
        '
        Me.history.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.history.ColumnWidth = 80
        Me.history.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.history.FormattingEnabled = True
        Me.history.ItemHeight = 16
        Me.history.Location = New System.Drawing.Point(12, 41)
        Me.history.MultiColumn = True
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(162, 162)
        Me.history.TabIndex = 2
        '
        'btnPick
        '
        Me.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPick.Location = New System.Drawing.Point(12, 12)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(162, 23)
        Me.btnPick.TabIndex = 1
        Me.btnPick.Text = "Pick"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(186, 215)
        Me.Controls.Add(Me.btnPick)
        Me.Controls.Add(Me.history)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "Desktop Color Picker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents previewUpdater As Timer
    Friend WithEvents history As ListBox
    Friend WithEvents btnPick As Button
End Class
