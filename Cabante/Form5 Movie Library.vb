Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form5_Movie_Library

    ' MongoDB connection
    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase =
        client.GetDatabase("ProjectAdvanceDB")

    Private movieCollection As IMongoCollection(Of BsonDocument) =
        database.GetCollection(Of BsonDocument)("MovieVault")


    ' FORM LOAD
    Private Sub Form5_Movie_Library_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Create DataGridView columns if they don't exist
        If dgvMovies.Columns.Count = 0 Then

            dgvMovies.Columns.Add("colTitle", "Movie Title")
            dgvMovies.Columns.Add("colGenre", "Genre")
            dgvMovies.Columns.Add("colYear", "Release Year")
            dgvMovies.Columns.Add("colDirector", "Director")
            dgvMovies.Columns.Add("colDuration", "Duration")
            dgvMovies.Columns.Add("colDescription", "Description")
            dgvMovies.Columns.Add("colPosterURL", "Poster URL")

            ' Set column widths
            dgvMovies.Columns("colTitle").FillWeight = 18
            dgvMovies.Columns("colGenre").FillWeight = 12
            dgvMovies.Columns("colYear").FillWeight = 12
            dgvMovies.Columns("colDirector").FillWeight = 16
            dgvMovies.Columns("colDuration").FillWeight = 10
            dgvMovies.Columns("colDescription").FillWeight = 15
            dgvMovies.Columns("colPosterURL").FillWeight = 17

        End If

        ' Load movies
        LoadMovies()

    End Sub


    ' LOAD MOVIES FROM MONGODB
    Private Sub LoadMovies()

        Try

            ' Get all movies
            Dim movies =
                movieCollection.Find(New BsonDocument()).ToList()

            ' Clear existing rows
            dgvMovies.Rows.Clear()


            ' Add movies to DataGridView
            For Each movie In movies

                Dim title As String = ""
                Dim genre As String = ""
                Dim year As String = ""
                Dim director As String = ""
                Dim duration As String = ""
                Dim description As String = ""
                Dim posterURL As String = ""


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

                If movie.Contains("description") Then
                    description = movie("description").ToString()
                End If

                If movie.Contains("posterURL") Then
                    posterURL = movie("posterURL").ToString()
                End If


                dgvMovies.Rows.Add(
                    title,
                    genre,
                    year,
                    director,
                    duration,
                    description,
                    posterURL
                )

            Next


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load movies." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' REFRESH MOVIE LIBRARY
    Public Sub RefreshMovies()

        LoadMovies()

    End Sub


    ' VIEW DETAILS BUTTON
    Private Sub btnViewDetails_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewDetails.Click

        ' Make sure a movie is selected
        If dgvMovies.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a movie first.",
                "No Movie Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            ' Get selected movie
            Dim selectedRow As DataGridViewRow =
                dgvMovies.SelectedRows(0)

            Dim title As String =
                selectedRow.Cells("colTitle").Value.ToString()


            ' Find movie in MongoDB
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

            ' Show Form 7
            Form7_Movie_Details.Show()

            ' Hide Form 5
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