Imports System.Data.SqlClient
Public Class Orders
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\VB Net\PROJECT\VBGoupProject\VBGoupProject\RoofTopCaffeDatabase.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub LogoutLabel_Click(sender As Object, e As EventArgs) Handles LogoutLabel.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub CloseBox_Click(sender As Object, e As EventArgs) Handles CloseBox.Click
        Application.Exit()
    End Sub

    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("select * from CategoryTable", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Table = New DataTable()
        adapter.Fill(Table)
        CategoryComboBox.DataSource = Table
        CategoryComboBox.DisplayMember = "CategoryName"
        CategoryComboBox.ValueMember = "CategoryName"
        Con.Close()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTable"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapater = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapater)
        builder = New SqlCommandBuilder(adapater)
        Dim ds = New DataSet()
        adapater.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "select * from ItemTable where ItemCategory= '" & CategoryComboBox.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapater = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapater)
        builder = New SqlCommandBuilder(adapater)
        Dim ds = New DataSet()
        adapater.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub

    Private Sub CategoryComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectionChangeCommitted
        FilterByCategory()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        DisplayItem()
    End Sub


    Dim ProdName As String
    Dim i = 0, GrdTotal = 0, price, quantity

    Private Sub AddBill()
        Con.Open()
        Dim query = "insert into OrderTable values('" & DateAndTime.Today.Date & "', " & GrdTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Bill Added")
        Con.Close()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        AddBill()
        PrintPreviewDialog1.Show()
    End Sub

    ' receipt design
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Rooftop Caffe", New Font("Arial", 35), Brushes.BlueViolet, 300, 0)



        e.Graphics.DrawString("***Your Bill***", New Font("Arial", 14), Brushes.BlueViolet, 385, 60)

        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 0, 170)
        e.Graphics.DrawString("Total Amount : RM " + GrdTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, 300, 580)
        e.Graphics.DrawString("=================Thanks For Buying In Our Cafe=================", New Font("Arial", 15), Brushes.Crimson, 60, 600)
    End Sub

    Private Sub VieworderButton_Click(sender As Object, e As EventArgs) Handles VieworderButton.Click
        Dim Obj = New ViewOrder
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateItem()
        Try
            Dim newquantity = stock - Convert.ToInt32(QuantityTextBox.Text)
            Con.Open()
            Dim query = "update ItemTable set ItemQuantity=" & newquantity & " where ItemID=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Edited")
            Con.Close()
            Reset()
            DisplayItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddtobillButton_Click(sender As Object, e As EventArgs) Handles AddtobillButton.Click
        If key = 0 Then
            MsgBox("select a Item")
        ElseIf Convert.ToInt32(QuantityTextBox.Text) > stock Then
            MsgBox("Not Enough Stock")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            Dim total = Convert.ToInt32(QuantityTextBox.Text) * price
            i = i + 1
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = price
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QuantityTextBox.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            TotalTextBox.Text = "RM" + Convert.ToString(GrdTotal)
            UpdateItem()
            QuantityTextBox.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString

        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub
End Class