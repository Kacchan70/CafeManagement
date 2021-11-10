Imports System.Data.SqlClient
Public Class Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\VB Net\PROJECT\VBGoupProject\VBGoupProject\RoofTopCaffeDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub LogoutLabel_Click(sender As Object, e As EventArgs) Handles LogoutLabel.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub CloseBox_Click(sender As Object, e As EventArgs) Handles CloseBox.Click
        Application.Exit()
    End Sub


    ' ADD CATEAGORY
    Private Sub AddCatButton_Click(sender As Object, e As EventArgs) Handles AddCatButton.Click

        If AddCatTextBox.Text = "" Then
            MsgBox("Enter The Category")
        Else
            Con.Open()
            Dim query = "insert into CategoryTable values('" & AddCatTextBox.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Added")
            Con.Close()
            AddCatTextBox.Text = ""
            FillCategory()
        End If

    End Sub

    ' RESET function 
    Private Sub Reset()
        NameTextBox.Text = ""
        CategoryComboBox.SelectedIndex = 0
        PriceTextBox.Text = ""
        QuantityTextBox.Text = ""

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

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
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
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If CategoryComboBox.SelectedIndex = -1 Or NameTextBox.Text = "" Or PriceTextBox.Text = "" Or QuantityTextBox.Text = "" Then
            MsgBox("Missing Information")

        Else
            Con.Open()
            Dim query = "insert into ItemTable values('" & NameTextBox.Text & "', '" & CategoryComboBox.SelectedValue.ToString & "'," & PriceTextBox.Text & "," & QuantityTextBox.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Added")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub


    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        NameTextBox.Text = row.Cells(1).Value.ToString
        CategoryComboBox.SelectedValue = row.Cells(2).Value.ToString
        PriceTextBox.Text = row.Cells(3).Value.ToString
        QuantityTextBox.Text = row.Cells(4).Value.ToString

        If NameTextBox.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Select Item To Delete")

        Else
            Con.Open()
            Dim query = "delete from ItemTable where ItemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If CategoryComboBox.SelectedIndex = -1 Or NameTextBox.Text = "" Or PriceTextBox.Text = "" Or QuantityTextBox.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                Con.Open()
                Dim query = "update ItemTable set ItemName= '" & NameTextBox.Text & "' ,ItemCategory='" & CategoryComboBox.SelectedValue.ToString() & "' ,ItemPrice=" & PriceTextBox.Text & ",ItemQuantity=" & QuantityTextBox.Text & " where ItemID=" & key & " "
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

        End If
    End Sub


End Class