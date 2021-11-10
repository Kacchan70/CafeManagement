<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CashierLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CloseBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(439, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 471)
        Me.Panel1.TabIndex = 0
        '
        'CloseBox
        '
        Me.CloseBox.Image = CType(resources.GetObject("CloseBox.Image"), System.Drawing.Image)
        Me.CloseBox.Location = New System.Drawing.Point(308, 3)
        Me.CloseBox.Name = "CloseBox"
        Me.CloseBox.Size = New System.Drawing.Size(50, 47)
        Me.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CloseBox.TabIndex = 19
        Me.CloseBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(13, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BY GROUP 11"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(1, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAFE MANAGEMENT SYSTEM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(12, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(12, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password :"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(126, 225)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(186, 33)
        Me.UsernameTextBox.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(126, 267)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(186, 33)
        Me.PasswordTextBox.TabIndex = 6
        '
        'CashierLabel
        '
        Me.CashierLabel.AutoSize = True
        Me.CashierLabel.Font = New System.Drawing.Font("Impact", 15.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashierLabel.ForeColor = System.Drawing.Color.SandyBrown
        Me.CashierLabel.Location = New System.Drawing.Point(164, 426)
        Me.CashierLabel.Name = "CashierLabel"
        Me.CashierLabel.Size = New System.Drawing.Size(80, 26)
        Me.CashierLabel.TabIndex = 7
        Me.CashierLabel.Text = "Cashier"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LoginButton.Location = New System.Drawing.Point(122, 328)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(194, 36)
        Me.LoginButton.TabIndex = 8
        Me.LoginButton.Text = "LOGIN "
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.CashierLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CashierLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents CloseBox As PictureBox
End Class
