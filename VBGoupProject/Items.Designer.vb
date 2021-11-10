<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.AddCatButton = New System.Windows.Forms.Button()
        Me.AddCatTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CloseBox = New System.Windows.Forms.PictureBox()
        Me.LogoutLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ItemDGV)
        Me.Panel1.Controls.Add(Me.AddCatButton)
        Me.Panel1.Controls.Add(Me.AddCatTextBox)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(44, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1329, 757)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label7.Location = New System.Drawing.Point(602, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 36)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Items List"
        '
        'ItemDGV
        '
        Me.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemDGV.ColumnHeadersHeight = 35
        Me.ItemDGV.EnableHeadersVisualStyles = False
        Me.ItemDGV.Location = New System.Drawing.Point(222, 358)
        Me.ItemDGV.Name = "ItemDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.ItemDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ItemDGV.Size = New System.Drawing.Size(940, 321)
        Me.ItemDGV.TabIndex = 16
        '
        'AddCatButton
        '
        Me.AddCatButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddCatButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddCatButton.Location = New System.Drawing.Point(757, 79)
        Me.AddCatButton.Name = "AddCatButton"
        Me.AddCatButton.Size = New System.Drawing.Size(173, 25)
        Me.AddCatButton.TabIndex = 15
        Me.AddCatButton.Text = "Add Category "
        Me.AddCatButton.UseVisualStyleBackColor = False
        '
        'AddCatTextBox
        '
        Me.AddCatTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCatTextBox.Location = New System.Drawing.Point(450, 81)
        Me.AddCatTextBox.Name = "AddCatTextBox"
        Me.AddCatTextBox.Size = New System.Drawing.Size(216, 23)
        Me.AddCatTextBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(350, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Category :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Controls.Add(Me.DeleteButton)
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Controls.Add(Me.QuantityTextBox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CategoryComboBox)
        Me.Panel2.Controls.Add(Me.NameTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PriceTextBox)
        Me.Panel2.Location = New System.Drawing.Point(219, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 155)
        Me.Panel2.TabIndex = 13
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ResetButton.Location = New System.Drawing.Point(677, 110)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(173, 34)
        Me.ResetButton.TabIndex = 19
        Me.ResetButton.Text = "Clear"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DeleteButton.Location = New System.Drawing.Point(483, 110)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(173, 34)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddButton.Location = New System.Drawing.Point(96, 110)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(173, 34)
        Me.AddButton.TabIndex = 16
        Me.AddButton.Text = "Add "
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EditButton.Location = New System.Drawing.Point(290, 110)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(173, 34)
        Me.EditButton.TabIndex = 17
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(722, 60)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(164, 23)
        Me.QuantityTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(287, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Categories :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Food Name :"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(293, 60)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(206, 23)
        Me.CategoryComboBox.TabIndex = 11
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(30, 61)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(216, 23)
        Me.NameTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(534, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Price :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(716, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity :"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(538, 60)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(147, 23)
        Me.PriceTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(562, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Manage Items"
        '
        'CloseBox
        '
        Me.CloseBox.Image = CType(resources.GetObject("CloseBox.Image"), System.Drawing.Image)
        Me.CloseBox.Location = New System.Drawing.Point(1419, 11)
        Me.CloseBox.Name = "CloseBox"
        Me.CloseBox.Size = New System.Drawing.Size(58, 43)
        Me.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CloseBox.TabIndex = 18
        Me.CloseBox.TabStop = False
        '
        'LogoutLabel
        '
        Me.LogoutLabel.AutoSize = True
        Me.LogoutLabel.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLabel.ForeColor = System.Drawing.Color.White
        Me.LogoutLabel.Location = New System.Drawing.Point(1380, 757)
        Me.LogoutLabel.Name = "LogoutLabel"
        Me.LogoutLabel.Size = New System.Drawing.Size(95, 36)
        Me.LogoutLabel.TabIndex = 18
        Me.LogoutLabel.Text = "Logout"
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1505, 815)
        Me.Controls.Add(Me.LogoutLabel)
        Me.Controls.Add(Me.CloseBox)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddCatButton As Button
    Friend WithEvents AddCatTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CategoryComboBox As ComboBox

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents CloseBox As PictureBox
    Friend WithEvents LogoutLabel As Label
    Friend WithEvents ResetButton As Button
End Class
