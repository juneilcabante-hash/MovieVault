Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form6__Add_Movie

    ' MongoDB connection
    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase = client.GetDatabase("ProjectAdvanceDB")
    Private movieCollection As IMongoCollection(Of BsonDocument) =
        database.GetCollection(Of BsonDocument)("MovieVault")


    ' CLEAR FORM
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtTitle.Clear()
        txtGenre.Clear()
        txtYear.Clear()
        txtDirector.Clear()
        txtDuration.Clear()
        txtDescription.Clear()
        txtPosterURL.Clear()

    End Sub


    ' BACK TO DASHBOARD
    Private Sub btnBackDashboard_Click(sender As Object, e As EventArgs) Handles btnBackDashboard.Click

        Form3MainDashboard.Show()
        Me.Hide()

    End Sub


    ' SAVE MOVIE
    Private Sub btnSaveMovie_Click(sender As Object, e As EventArgs) Handles btnSaveMovie.Click

        ' Check required fields
        If txtTitle.Text.Trim() = "" OrElse
           txtGenre.Text.Trim() = "" OrElse
           txtYear.Text.Trim() = "" OrElse
           txtDirector.Text.Trim() = "" Then

            MessageBox.Show(
                "Please fill in the Movie Title, Genre, Release Year, and Director.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return
        End If


        ' Check if release year is a valid number
        Dim releaseYear As Integer

        If Not Integer.TryParse(txtYear.Text.Trim(), releaseYear) Then

            MessageBox.Show(
                "Please enter a valid release year.",
                "Invalid Year",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return
        End If


        Try

            ' Create movie document
            Dim movie As New BsonDocument From {
                {"title", txtTitle.Text.Trim()},
                {"genre", txtGenre.Text.Trim()},
                {"releaseYear", releaseYear},
                {"director", txtDirector.Text.Trim()},
                {"duration", txtDuration.Text.Trim()},
                {"description", txtDescription.Text.Trim()},
                {"posterURL", txtPosterURL.Text.Trim()},
                {"dateAdded", DateTime.Now}
            }


            ' Insert movie into MongoDB
            movieCollection.InsertOne(movie)


            ' Success message
            MessageBox.Show(
                "Movie saved successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            ' Clear form after saving
            txtTitle.Clear()
            txtGenre.Clear()
            txtYear.Clear()
            txtDirector.Clear()
            txtDuration.Clear()
            txtDescription.Clear()
            txtPosterURL.Clear()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to save the movie." & Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' FORM LOAD
    Private Sub Form6__Add_Movie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class