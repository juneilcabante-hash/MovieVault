Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form4_Search_movie

    ' MongoDB connection
    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase =
        client.GetDatabase("ProjectAdvanceDB")

    Private movieCollection As IMongoCollection(Of BsonDocument) =
        database.GetCollection(Of BsonDocument)("MovieVault")


    ' FORM LOAD
    Private Sub Form4_Search_movie_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Create DataGridView columns
        If dgvSearchMovies.Columns.Count = 0 Then

            dgvSearchMovies.Columns.Add(
                "colTitle",
                "Movie Title"
            )

            dgvSearchMovies.Columns.Add(
                "colGenre",
                "Genre"
            )

            dgvSearchMovies.Columns.Add(
                "colYear",
                "Release Year"
            )

            dgvSearchMovies.Columns.Add(
                "colDirector",
                "Director"
            )

            dgvSearchMovies.Columns.Add(
                "colDuration",
                "Duration"
            )

        End If

        ' Make columns fill the DataGridView
        dgvSearchMovies.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

    End Sub


    ' SEARCH MOVIE
    Private Sub btnSearchMovie_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSearchMovie.Click

        Dim searchText As String =
            txtSearchMovie.Text.Trim()

        ' Check if search box is empty
        If searchText = "" Then

            MessageBox.Show(
                "Please enter a movie title.",
                "Search Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            ' Get all movies from MongoDB
            Dim movies =
                movieCollection.Find(
                    New BsonDocument()
                ).ToList()

            ' Clear previous search results
            dgvSearchMovies.Rows.Clear()

            Dim found As Boolean = False


            ' Check every movie
            For Each movie In movies

                Dim title As String = ""
                Dim genre As String = ""
                Dim year As String = ""
                Dim director As String = ""
                Dim duration As String = ""


                If movie.Contains("title") Then
                    title = movie("title").ToString()
                End If

                If movie.Contains("genre") Then
                    genre = movie("genre").ToString()
                End If

                If movie.Contains("releaseYear") Then
                    year = movie("releaseYear").ToString()
                End If

                If movie.Contains("director") Then
                    director = movie("director").ToString()
                End If

                If movie.Contains("duration") Then
                    duration = movie("duration").ToString()
                End If


                ' Case-insensitive search
                If title.IndexOf(
                    searchText,
                    StringComparison.OrdinalIgnoreCase
                ) >= 0 Then

                    dgvSearchMovies.Rows.Add(
                        title,
                        genre,
                        year,
                        director,
                        duration
                    )

                    found = True

                End If

            Next


            ' No results
            If Not found Then

                MessageBox.Show(
                    "No movie found with the title: " &
                    searchText,
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Unable to search for the movie." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' VIEW DETAILS BUTTON
    Private Sub btnViewDetails_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewDetails.Click

        ' Make sure a movie is selected
        If dgvSearchMovies.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a movie first.",
                "No Movie Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            ' Get selected row
            Dim selectedRow As DataGridViewRow =
                dgvSearchMovies.SelectedRows(0)


            ' Get movie title
            Dim title As String =
                selectedRow.Cells("colTitle").Value.ToString()


            ' Find the movie in MongoDB
            Dim filter As New BsonDocument(
                "title",
                title
            )

            Dim movie As BsonDocument =
                movieCollection.Find(filter).FirstOrDefault()


            ' Check if movie exists
            If movie Is Nothing Then

                MessageBox.Show(
                    "Movie could not be found in the database.",
                    "Movie Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' Send movie to Form 7
            Form7_Movie_Details.LoadMovie(movie)


            ' Open Form 7
            Form7_Movie_Details.Show()


            ' Hide Form 4
            Me.Hide()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load movie details." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' BACK TO DASHBOARD
    Private Sub btnBackDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBackDashboard.Click

        Form3MainDashboard.Show()
        Me.Hide()

    End Sub

End Class