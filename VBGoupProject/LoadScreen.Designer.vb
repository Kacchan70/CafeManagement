<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loadbar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(515, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOADING . . . ."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(235, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'loadbar
        '
        Me.loadbar.Location = New System.Drawing.Point(163, 300)
        Me.loadbar.Name = "loadbar"
        Me.loadbar.Size = New System.Drawing.Size(477, 23)
        Me.loadbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.loadbar.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(43, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 388)
        Me.Panel1.TabIndex = 4
        '
        'LoadScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 432)
        Me.Controls.Add(Me.loadbar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loadbar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
End Class
