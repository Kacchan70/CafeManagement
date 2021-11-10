Imports System.Data.SqlClient
Public Class ViewOrder
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\VB Net\PROJECT\VBGoupProject\VBGoupProject\RoofTopCaffeDatabase.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from OrderTable"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapater = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapater)
        builder = New SqlCommandBuilder(adapater)
        Dim ds = New DataSet()
        adapater.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub ViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim obj = New Orders
        obj.Show()
        Me.Hide()
    End Sub


End Class