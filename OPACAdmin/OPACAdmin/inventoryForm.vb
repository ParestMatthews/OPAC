
Public Class InventoryForm

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub inventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inventoryPanels(inventoryTable)
    End Sub

    Private Sub searchDataTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub searchDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles inventoryPanel.Paint

    End Sub

    Private Sub searchDataTable_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Sub inventoryPanels(ByVal panel As Form)
        inventoryPanel.Controls.Clear()
        panel.TopLevel = False
        inventoryPanel.Controls.Add(panel)
        panel.Show()
    End Sub
End Class




