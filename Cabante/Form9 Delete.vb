Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form9_Delete

    ' MongoDB connection
    Private client As New MongoClient("mongodb://localhost:27017")

    Private database As IMongoDatabase =
        client.GetDatabase("ProjectAdvanceDB")

    Private movieCollection As IMongoCollection(Of BsonDocument) =
        database.GetCollection(Of BsonDocument)("MovieVault")

    ' Store the selected movie
    Private selectedMovie As BsonDocument


    ' RECEIVE MOVIE FROM FORM 7
    Public Sub LoadMovie(movie As BsonDocument)

        selectedMovie = movie

        txtDeleteTitle.Text =
            movie.GetValue("title", "").ToString()

    End Sub


    ' DELETE MOVIE
    Private Sub btnDeleteMovie_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDeleteMovie.Click

        ' Make sure a movie is selected
        If selectedMovie Is Nothing Then

            MessageBox.Show(
                "No movie has been selected.",
                "Delete Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        ' Get movie title
        Dim movieTitle As String =
            selectedMovie.GetValue("title", "").ToString()


        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to delete:" &
            Environment.NewLine &
            Environment.NewLine &
            movieTitle & "?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )


        ' User selected No
        If result <> DialogResult.Yes Then
            Return
        End If


        Try

            ' Delete movie by title
            Dim filter As New BsonDocument(
                "title",
                movieTitle
            )


            Dim deleteResult =
                movieCollection.DeleteOne(filter)


            ' Check if deletion was successful
            If deleteResult.DeletedCount > 0 Then

                MessageBox.Show(
                    "Movie deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


                ' Refresh Movie Library
                Form5_Movie_Library.RefreshMovies()


                ' Go back to Movie Library
                Form5_Movie_Library.Show()
                Me.Hide()

            Else

                MessageBox.Show(
                    "Movie could not be found.",
                    "Delete Movie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Unable to delete the movie." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' CANCEL
    Private Sub btnCancel_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancel.Click

        Form7_Movie_Details.Show()
        Me.Hide()

    End Sub


    ' BACK TO LIBRARY
    Private Sub btnBackLibrary_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBackLibrary.Click

        Form5_Movie_Library.Show()
        Me.Hide()

    End Sub

    Private Sub Form9_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class