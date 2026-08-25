Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form7_Movie_Details

    ' MongoDB connection
    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase =
        client.GetDatabase("ProjectAdvanceDB")

    Private movieCollection As IMongoCollection(Of BsonDocument) =
        database.GetCollection(Of BsonDocument)("MovieVault")


    ' Store the selected movie
    Private selectedMovie As BsonDocument

    ' Check if edit mode is active
    Private editMode As Boolean = False


    ' LOAD MOVIE DETAILS
    Public Sub LoadMovie(movie As BsonDocument)

        selectedMovie = movie

        ' Display movie information
        txtDetailsTitle.Text =
            movie.GetValue("title", "").ToString()

        txtDetailsGenre.Text =
            movie.GetValue("genre", "").ToString()

        txtDetailsYear.Text =
            movie.GetValue("releaseYear", "").ToString()

        txtDetailsDirector.Text =
            movie.GetValue("director", "").ToString()

        txtDetailsDuration.Text =
            movie.GetValue("duration", "").ToString()

        txtDetailsDescription.Text =
            movie.GetValue("description", "").ToString()

        ' Start in view mode
        editMode = False

        SetEditMode(False)

    End Sub


    ' FORM LOAD
    Private Sub Form7_Movie_Details_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetEditMode(False)

    End Sub


    ' SET EDIT MODE
    Private Sub SetEditMode(isEditing As Boolean)

        editMode = isEditing

        ' Movie title stays read-only
        txtDetailsTitle.ReadOnly = True

        ' Other fields can be edited
        txtDetailsGenre.ReadOnly = Not isEditing
        txtDetailsYear.ReadOnly = Not isEditing
        txtDetailsDirector.ReadOnly = Not isEditing
        txtDetailsDuration.ReadOnly = Not isEditing
        txtDetailsDescription.ReadOnly = Not isEditing

        ' Change button text
        If isEditing Then

            btnEditMovie.Text = "SAVE CHANGES"

        Else

            btnEditMovie.Text = "EDIT MOVIE"

        End If

    End Sub


    ' BACK TO LIBRARY
    Private Sub btnBackLibrary_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBackLibrary.Click

        ' Don't leave while editing
        If editMode Then

            Dim result As DialogResult = MessageBox.Show(
                "You are currently editing this movie." &
                Environment.NewLine &
                Environment.NewLine &
                "Discard your changes?",
                "Cancel Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result <> DialogResult.Yes Then
                Return
            End If

            SetEditMode(False)

        End If

        ' Refresh library before showing it
        Form5_Movie_Library.RefreshMovies()

        Form5_Movie_Library.Show()
        Me.Hide()

    End Sub


    ' BACK TO DASHBOARD
    Private Sub btnBackDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBackDashboard.Click

        ' Don't leave while editing
        If editMode Then

            Dim result As DialogResult = MessageBox.Show(
                "You are currently editing this movie." &
                Environment.NewLine &
                Environment.NewLine &
                "Discard your changes?",
                "Cancel Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result <> DialogResult.Yes Then
                Return
            End If

            SetEditMode(False)

        End If

        Form3MainDashboard.Show()
        Me.Hide()

    End Sub


    ' EDIT / SAVE MOVIE
    Private Sub btnEditMovie_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditMovie.Click

        ' Make sure a movie is loaded
        If selectedMovie Is Nothing Then

            MessageBox.Show(
                "No movie is selected.",
                "Edit Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        ' =========================
        ' ENTER EDIT MODE
        ' =========================

        If Not editMode Then

            SetEditMode(True)

            MessageBox.Show(
                "You can now edit the movie information." &
                Environment.NewLine &
                Environment.NewLine &
                "The Movie Title cannot be changed.",
                "Edit Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        ' =========================
        ' SAVE CHANGES
        ' =========================

        ' Check required fields
        If txtDetailsGenre.Text.Trim() = "" OrElse
           txtDetailsYear.Text.Trim() = "" OrElse
           txtDetailsDirector.Text.Trim() = "" Then

            MessageBox.Show(
                "Please fill in the Genre, Release Year, and Director.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        ' Validate release year
        Dim releaseYear As Integer

        If Not Integer.TryParse(
            txtDetailsYear.Text.Trim(),
            releaseYear
        ) Then

            MessageBox.Show(
                "Please enter a valid release year.",
                "Invalid Year",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            ' Get the original movie title
            Dim originalTitle As String =
                selectedMovie.GetValue("title", "").ToString()


            ' Find the movie by title
            Dim filter As New BsonDocument(
                "title",
                originalTitle
            )


            ' Update movie information
            Dim update As New BsonDocument(
                "$set",
                New BsonDocument From {
                    {"genre", txtDetailsGenre.Text.Trim()},
                    {"releaseYear", releaseYear},
                    {"director", txtDetailsDirector.Text.Trim()},
                    {"duration", txtDetailsDuration.Text.Trim()},
                    {"description", txtDetailsDescription.Text.Trim()}
                }
            )


            ' Update MongoDB
            Dim updateResult =
                movieCollection.UpdateOne(filter, update)


            ' Check if movie was found
            If updateResult.MatchedCount > 0 Then

                ' Update selected movie in memory
                selectedMovie("genre") =
                    txtDetailsGenre.Text.Trim()

                selectedMovie("releaseYear") =
                    releaseYear

                selectedMovie("director") =
                    txtDetailsDirector.Text.Trim()

                selectedMovie("duration") =
                    txtDetailsDuration.Text.Trim()

                selectedMovie("description") =
                    txtDetailsDescription.Text.Trim()


                ' Return to view mode
                SetEditMode(False)


                ' Refresh Movie Library
                Form5_Movie_Library.RefreshMovies()


                MessageBox.Show(
                    "Movie updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


            Else

                MessageBox.Show(
                    "Movie could not be found in the database.",
                    "Update Movie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Unable to update the movie." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' DELETE MOVIE
    Private Sub btnDeleteMovie_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDeleteMovie.Click

        ' Make sure a movie is loaded
        If selectedMovie Is Nothing Then

            MessageBox.Show(
                "No movie is selected.",
                "Delete Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        ' Don't delete while editing
        If editMode Then

            MessageBox.Show(
                "Please save your changes before deleting the movie.",
                "Edit Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        ' Send selected movie to Form9
        Form9_Delete.LoadMovie(selectedMovie)

        ' Open Form9
        Form9_Delete.Show()

        ' Hide Form7
        Me.Hide()

    End Sub

End Class