Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Home
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub btn_srchTitle_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(searchText, "Search Book by Name, Call Number, or Author")
        dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookTitle,
                   bookAccession
                 FROM
                   opac.book
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            searchDataTable.DataSource = bindSource
            With searchDataTable
                .Columns(0).HeaderCell.Value = "Book Name"
                .Columns(1).HeaderCell.Value = "Book Accession"
                .Columns(0).Width = Me.Width / 2
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(0).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
                .Columns(1).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ams_Click(sender As Object, e As EventArgs) Handles ams.Click

    End Sub

    Private Sub lsb_Click(sender As Object, e As EventArgs) Handles lsb.Click

    End Sub

    Private Sub piclsb_Click(sender As Object, e As EventArgs) Handles piclsb.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
    Private Sub btnDelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.MouseHover
        btnDelete.Image = New Bitmap(My.Resources.delete2)
    End Sub
    Private Sub btnDelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.MouseLeave
        btnDelete.Image = New Bitmap(My.Resources.delete1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

    End Sub
    Private Sub btnVerify_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerify.MouseHover
        btnVerify.Image = New Bitmap(My.Resources.verify2)
    End Sub
    Private Sub btnVerify_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerify.MouseLeave
        btnVerify.Image = New Bitmap(My.Resources.verify1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    Private Sub btnSave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseHover
        btnSave.Image = New Bitmap(My.Resources.save2)
    End Sub
    Private Sub btnSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseLeave
        btnSave.Image = New Bitmap(My.Resources.save1)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub
    Private Sub btnClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseHover
        btnClose.Image = New Bitmap(My.Resources.close2)
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = New Bitmap(My.Resources.close1)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
    Private Sub btnPrint_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.MouseHover
        btnPrint.Image = New Bitmap(My.Resources.print2)
    End Sub
    Private Sub btnPrint_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.MouseLeave
        btnPrint.Image = New Bitmap(My.Resources.print1)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
    Private Sub btnClear_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.MouseHover
        btnClear.Image = New Bitmap(My.Resources.clear2)
    End Sub
    Private Sub btnClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.MouseLeave
        btnClear.Image = New Bitmap(My.Resources.clear1)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_srchType_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_srchAuthor_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookTitle,
                   bookAccession
                 FROM
                   opac.book
                 WHERE
                   bookTitle LIKE @title or
                   bookAuthor LIKE @author or
                   bookCallNumber LIKE @callnumber
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@title", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@author", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@callnumber", "%" & searchText.Text & "%")
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            searchDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
Public Module CueBannerText
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501

    Public Sub SetCueText(ByVal cntrl As Control, ByVal text As String)
        If TypeOf cntrl Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(cntrl.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf cntrl Is TextBox Then
            SendMessage(cntrl.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
End Module
