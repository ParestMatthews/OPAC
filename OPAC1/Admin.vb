Imports MySql.Data.MySqlClient

Public Class Admin
    Public Shared crudStatus As String
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
        Try
            dbConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        LocalPanel.Hide()
        TitlePanel.Hide()
        PubPanel.Hide()
        btnNext.Hide()
        btnPrev.Hide()
        btnPrev.Enabled = False

        Button1.Hide()
        Button2.Hide()
        Button3.Hide()


    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        LocalPanel.Location = New Point(282, 92)
        LocalPanel.Visible = True
        TitlePanel.Visible = False
        PubPanel.Visible = False

        btnNext.Visible = True
        btnPrev.Visible = True
        btnNext.Enabled = True
        btnPrev.Enabled = False
        crudStatus = "update" 'update flag

        Button1.Hide()
        Button2.Show()
        Button3.Show()

    End Sub
    Private Sub btnUpdate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.MouseHover
        btnUpdate.Image = New Bitmap(My.Resources.update2)
    End Sub
    Private Sub btnClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.Image = New Bitmap(My.Resources.update1)
    End Sub
    Private Sub btnInventory_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInventory.MouseHover
        btnInventory.Image = New Bitmap(My.Resources.inventory2)
    End Sub
    Private Sub btnInventory_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInventory.MouseLeave
        btnInventory.Image = New Bitmap(My.Resources.inventory1)
    End Sub

    Private Sub title_btn_r_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub pub_btn_l_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub pub_btn_r_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub local_btn_l_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LocalPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If LocalPanel.Visible = True Then
            LocalPanel.Visible = False
            TitlePanel.Location = New Point(282, 92)
            TitlePanel.Visible = True
            btnPrev.Enabled = True
            btnNext.Enabled = True
            PubPanel.Visible = False
        ElseIf TitlePanel.Visible = True Then
            LocalPanel.Visible = False
            TitlePanel.Visible = False
            PubPanel.Location = New Point(282, 92)
            PubPanel.Visible = True
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub PubPanel_Paint(sender As Object, e As PaintEventArgs) Handles PubPanel.Paint

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If PubPanel.Visible = True Then
            LocalPanel.Visible = False
            TitlePanel.Location = New Point(282, 92)
            TitlePanel.Visible = True
            btnPrev.Enabled = True
            btnNext.Enabled = True
            PubPanel.Visible = False
        ElseIf TitlePanel.Visible = True Then
            LocalPanel.Location = New Point(282, 92)
            LocalPanel.Visible = True
            TitlePanel.Visible = False
            PubPanel.Visible = False
            btnNext.Enabled = True
            btnPrev.Enabled = False
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LocalPanel.Location = New Point(282, 92)
        LocalPanel.Visible = True
        TitlePanel.Visible = False
        PubPanel.Visible = False

        btnNext.Visible = True
        btnPrev.Visible = True
        btnNext.Enabled = True
        btnPrev.Enabled = False

        crudStatus = "Add" 'add flag

        Button1.Show()
        Button2.Hide()
        Button3.Hide()

    End Sub

    Private Sub BtnAdd_MouseHover(sender As Object, e As EventArgs) Handles BtnAdd.MouseHover
        BtnAdd.Image = My.Resources.add22
    End Sub

    Private Sub BtnAdd_MouseLeave(sender As Object, e As EventArgs) Handles BtnAdd.MouseLeave
        BtnAdd.Image = My.Resources.add11
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim msgValidation As MsgBoxResult = MessageBox.Show("Are you sure you want to add this Book?", "Add Book", MessageBoxButtons.YesNo)
            If msgValidation = DialogResult.Yes Then
                dbQuery = "
                Insert into opac.book (
	                bookCallNumber,
                    bookTitle,
                    bookAuthor,
                    bookLocation,
                    bookPublished,
                    bookISBN,
                    bookEdition,
                    bookLanguage,
                    bookAccession
                    ) 
                        values(
                            @callNumber,
                            @title,
                            @author,
                            @location,
                            @published,
                            @ISBN,
                            @edition,
                            @language,
                            @accession
                   )"
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@callNumber", ComboBox2.Text + TextBox29.Text)
                dbCommand.Parameters.AddWithValue("@title", TextBox1.Text)
                dbCommand.Parameters.AddWithValue("@author", TextBox4.Text)
                dbCommand.Parameters.AddWithValue("@location", TextBox27.Text)
                dbCommand.Parameters.AddWithValue("@published", TextBox14.Text)
                dbCommand.Parameters.AddWithValue("@ISBN", TextBox2.Text)
                dbCommand.Parameters.AddWithValue("@edition", TextBox15.Text)
                dbCommand.Parameters.AddWithValue("@language", ComboBox1.Text)
                dbCommand.Parameters.AddWithValue("@accession", TextBox28.Text)
                dbCommand.ExecuteNonQuery()

                MsgBox("Added!", MsgBoxStyle.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TitlePanel_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LocalPanel_Paint_1(sender As Object, e As PaintEventArgs) Handles LocalPanel.Paint

    End Sub
End Class