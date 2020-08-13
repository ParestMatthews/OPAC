Public Class adminDashboard
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bunifuInventory.selected = True
        pagePanel(InventoryForm)

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles bunifuName.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If pagePanel1.Width = 639 Then
            InventoryForm.Width = 829 'reminder put multiple forms here!!
            bookEntryForm.Width = 829
            approvalForm.Width = 829
            userForm.Width = 829
            logReturnForm.Width = 829
            archiveForm.Width = 829

            bookEntryForm.threePage.Width = 805
            titleStatementForm.Width = 805
            pdiForm.Width = 805
            userAdd.Width = 805
            userEdit.Width = 805
            userTable.Width = 805
            inventoryTable.Width = 805
            inventoryInfo.Width = 805
            inventoryInfo.allInfoPanel.Width = 805
            infoOne.Width = 782
            infoTwo.Width = 782
            infoThree.Width = 782
            logForm.Width = 805

            returnForm.Width = 805

            archiveBooks.Width = 805

        Else
            InventoryForm.Width = 639
            bookEntryForm.Width = 639
            userForm.Width = 639
            approvalForm.Width = 639
            logReturnForm.Width = 639
            archiveForm.Width = 639

            titleStatementForm.Width = 604
            pdiForm.Width = 604
            inventoryInfo.Width = 615
            inventoryTable.Width = 615
            userAdd.Width = 615
            userEdit.Width = 615
            userTable.Width = 615
            infoOne.Width = 591
            infoTwo.Width = 591
            infoThree.Width = 591
            logForm.Width = 591

            returnForm.Width = 591
            archiveBooks.Width = 591
        End If

        If (sidebarPanel.Width = 235) Then
            sidebarPanel.Visible = False
            sidebarPanel.Width = 45
            iconBox.Visible = False
            bunifuName.Visible = False
            sidebarTransition.Show(sidebarPanel)
        Else
            sidebarPanel.Visible = False
            sidebarPanel.Width = 235
            sidebarTransition.Show(sidebarPanel)
            fadeTransition.Show(iconBox)
            fadeTransition.Show(bunifuName)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Sub pagePanel(ByVal panel As Form)
        pagePanel1.Controls.Clear()
        panel.TopLevel = False
        pagePanel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub bunifuInventory_Click(sender As Object, e As EventArgs) Handles bunifuInventory.Click
        pagePanel(InventoryForm)
        masterResets()

        If pagePanel1.Width = 639 Then
            InventoryForm.Width = 639
        Else
            InventoryForm.Width = 829
        End If
    End Sub

    Private Sub panelHeader_Paint(sender As Object, e As PaintEventArgs) Handles panelHeader.Paint

    End Sub

    Private Sub bunifuBooks_Click(sender As Object, e As EventArgs) Handles bunifuBooks.Click
        pagePanel(bookEntryForm)
        masterResets()

        If pagePanel1.Width = 639 Then
            bookEntryForm.Width = 639
        Else
            bookEntryForm.Width = 829
        End If
    End Sub

    Private Sub pagePanel1_Paint(sender As Object, e As PaintEventArgs) Handles pagePanel1.Paint

    End Sub

    Private Sub bunifuUser_Click(sender As Object, e As EventArgs) Handles bunifuUser.Click

        pagePanel(userForm)
        masterResets()

        If pagePanel1.Width = 639 Then
            userForm.Width = 639
        Else
            userForm.Width = 829
        End If
    End Sub

    Private Sub bunifuLogs_Click(sender As Object, e As EventArgs) Handles bunifuLogs.Click

        pagePanel(logReturnForm)
        masterResets()

        If pagePanel1.Width = 639 Then
            logReturnForm.Width = 639
        Else
            logReturnForm.Width = 829
        End If
    End Sub

    Private Sub sidebarPanel_Paint(sender As Object, e As PaintEventArgs) Handles sidebarPanel.Paint

    End Sub

    Private Sub iconBox_Click(sender As Object, e As EventArgs) Handles iconBox.Click

    End Sub

    Private Sub bunifuApproval_Click(sender As Object, e As EventArgs) Handles bunifuApproval.Click
        pagePanel(approvalForm)
        masterResets()

        If pagePanel1.Width = 639 Then
            approvalForm.Width = 639
        Else
            approvalForm.Width = 829
        End If
    End Sub
    Public Function masterResets()
        inventoryInfo.resetTable()
        approvalForm.resetApprovals()
        returnForm.resetReturns()
        inventoryInfo.resetUpdate()
        logForm.logReset()
        userTable.userdatatable()
        archiveBooks.loadBooksTable()
        archiveUser.loadUsersTable()
        InventoryForm.inventoryPanels(inventoryTable)
    End Function

    Private Sub bunifuLogout_Click(sender As Object, e As EventArgs) Handles bunifuLogout.Click
        My.Settings.username = ""
        My.Settings.password = ""
        My.Settings.checked = False
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub bunifuArchive_Click(sender As Object, e As EventArgs) Handles bunifuArchive.Click
        pagePanel(archiveForm)
        masterResets()

        If pagePanel1.Width = 639 Then
            archiveForm.Width = 639
        Else
            archiveForm.Width = 829
        End If
    End Sub
End Class