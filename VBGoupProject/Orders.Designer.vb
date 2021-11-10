<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.VieworderButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddtobillButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogoutLabel = New System.Windows.Forms.Label()
        Me.CloseBox = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TotalTextBox)
        Me.Panel1.Controls.Add(Me.VieworderButton)
        Me.Panel1.Controls.Add(Me.PrintButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AddtobillButton)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ItemDGV)
        Me.Panel1.Controls.Add(Me.RefreshButton)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BillDGV)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(24, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1139, 820)
        Me.Panel1.TabIndex = 1
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(974, 535)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 25
        '
        'VieworderButton
        '
        Me.VieworderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VieworderButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VieworderButton.Location = New System.Drawing.Point(913, 613)
        Me.VieworderButton.Name = "VieworderButton"
        Me.VieworderButton.Size = New System.Drawing.Size(113, 33)
        Me.VieworderButton.TabIndex = 24
        Me.VieworderButton.Text = "View Orders"
        Me.VieworderButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PrintButton.Location = New System.Drawing.Point(913, 574)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(113, 33)
        Me.PrintButton.TabIndex = 23
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(909, 533)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total :"
        '
        'AddtobillButton
        '
        Me.AddtobillButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddtobillButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddtobillButton.Location = New System.Drawing.Point(974, 379)
        Me.AddtobillButton.Name = "AddtobillButton"
        Me.AddtobillButton.Size = New System.Drawing.Size(113, 33)
        Me.AddtobillButton.TabIndex = 18
        Me.AddtobillButton.Text = "Add to Bill"
        Me.AddtobillButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label9.Location = New System.Drawing.Point(700, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 36)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Place Orders"
        '
        'ItemDGV
        '
        Me.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemDGV.BackgroundColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ItemDGV.ColumnHeadersHeight = 35
        Me.ItemDGV.EnableHeadersVisualStyles = False
        Me.ItemDGV.Location = New System.Drawing.Point(503, 161)
        Me.ItemDGV.Name = "ItemDGV"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.ItemDGV.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.ItemDGV.Size = New System.Drawing.Size(598, 201)
        Me.ItemDGV.TabIndex = 20
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RefreshButton.Location = New System.Drawing.Point(257, 158)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(148, 37)
        Me.RefreshButton.TabIndex = 19
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(588, 379)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(141, 32)
        Me.QuantityTextBox.TabIndex = 10
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(63, 161)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(177, 32)
        Me.CategoryComboBox.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label7.Location = New System.Drawing.Point(57, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 36)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Your Order"
        '
        'BillDGV
        '
        Me.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BillDGV.BackgroundColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.BillDGV.ColumnHeadersHeight = 35
        Me.BillDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.BillDGV.EnableHeadersVisualStyles = False
        Me.BillDGV.Location = New System.Drawing.Point(63, 533)
        Me.BillDGV.Name = "BillDGV"
        Me.BillDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.BillDGV.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.BillDGV.Size = New System.Drawing.Size(813, 234)
        Me.BillDGV.TabIndex = 16
        '
        'Column1
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(499, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(482, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Order Items"
        '
        'LogoutLabel
        '
        Me.LogoutLabel.AutoSize = True
        Me.LogoutLabel.Font = New System.Drawing.Font("Impact", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLabel.ForeColor = System.Drawing.Color.White
        Me.LogoutLabel.Location = New System.Drawing.Point(1183, 814)
        Me.LogoutLabel.Name = "LogoutLabel"
        Me.LogoutLabel.Size = New System.Drawing.Size(95, 36)
        Me.LogoutLabel.TabIndex = 19
        Me.LogoutLabel.Text = "Logout"
        '
        'CloseBox
        '
        Me.CloseBox.Image = CType(resources.GetObject("CloseBox.Image"), System.Drawing.Image)
        Me.CloseBox.Location = New System.Drawing.Point(1228, 12)
        Me.CloseBox.Name = "CloseBox"
        Me.CloseBox.Size = New System.Drawing.Size(50, 47)
        Me.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CloseBox.TabIndex = 20
        Me.CloseBox.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1290, 883)
        Me.Controls.Add(Me.CloseBox)
        Me.Controls.Add(Me.LogoutLabel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents AddtobillButton As Button
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents VieworderButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutLabel As Label
    Friend WithEvents CloseBox As PictureBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
