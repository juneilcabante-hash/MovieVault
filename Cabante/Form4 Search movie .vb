Public Class Form4_Search_movie

    Private Sub Form4_Search_movie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create DataGridView columns
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add("colTitle", "Movie Title")
        DataGridView1.Columns.Add("colGenre", "Genre")
        DataGridView1.Columns.Add("colYear", "Release Year")
        DataGridView1.Columns.Add("colDirector", "Director")

        'Movie data
        DataGridView1.Rows.Add("Inception", "Sci-Fi, Thriller", "2010", "Christopher Nolan")
        DataGridView1.Rows.Add("Interstellar", "Sci-Fi, Adventure", "2014", "Christopher Nolan")
        DataGridView1.Rows.Add("The Dark Knight", "Action, Crime, Drama", "2008", "Christopher Nolan")
        DataGridView1.Rows.Add("Avengers: Endgame", "Action, Adventure, Sci-Fi", "2019", "Anthony Russo, Joe Russo")
        DataGridView1.Rows.Add("The Shawshank Redemption", "Drama", "1994", "Frank Darabont")
        DataGridView1.Rows.Add("Forrest Gump", "Drama, Romance", "1994", "Robert Zemeckis")
        DataGridView1.Rows.Add("The Godfather", "Crime, Drama", "1972", "Francis Ford Coppola")
        DataGridView1.Rows.Add("Pulp Fiction", "Crime, Drama", "1994", "Quentin Tarantino")

        'DataGridView settings
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub


    'DataGridView click
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    'Search box
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    'SEARCH BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim searchText As String = TextBox1.Text.Trim().ToLower()
        Dim found As Boolean = False

        'If search box is empty, show all movies
        If searchText = "" Then

            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Visible = True
            Next

            Return

        End If

        'Search through movie information
        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim title As String = row.Cells("colTitle").Value.ToString().ToLower()
            Dim genre As String = row.Cells("colGenre").Value.ToString().ToLower()
            Dim year As String = row.Cells("colYear").Value.ToString().ToLower()
            Dim director As String = row.Cells("colDirector").Value.ToString().ToLower()

            If title.Contains(searchText) OrElse
               genre.Contains(searchText) OrElse
               year.Contains(searchText) OrElse
               director.Contains(searchText) Then

                row.Visible = True
                found = True

            Else

                row.Visible = False

            End If

        Next

        'If no movie was found
        If found = False Then

            MessageBox.Show("Movie not found.",
                            "Search Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        End If

    End Sub


    'BACK TO DASHBOARD BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form3MainDashboard.Show()
        Me.Hide()

    End Sub

End Class