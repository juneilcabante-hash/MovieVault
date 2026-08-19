Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form7_Movie_Details

    ' Store the selected movie
    Private selectedMovie As BsonDocument


    ' LOAD MOVIE DETAILS
    Public Sub LoadMovie(movie As BsonDocument)

        selectedMovie = movie

        ' Display movie information
        txtDetailsTitle.Text = movie.GetValue("title", "").ToString()
        txtDetailsGenre.Text = movie.GetValue("genre", "").ToString()
        txtDetailsYear.Text = movie.GetValue("releaseYear", "").ToString()
        txtDetailsDirector.Text = movie.GetValue("director", "").ToString()
        txtDetailsDuration.Text = movie.GetValue("duration", "").ToString()
        txtDetailsDescription.Text = movie.GetValue("description", "").ToString()

    End Sub


    ' FORM LOAD
    Private Sub Form7_Movie_Details_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Make detail fields read-only
        txtDetailsTitle.ReadOnly = True
        txtDetailsGenre.ReadOnly = True
        txtDetailsYear.ReadOnly = True
        txtDetailsDirector.ReadOnly = True
        txtDetailsDuration.ReadOnly = True
        txtDetailsDescription.ReadOnly = True

    End Sub


    ' BACK TO LIBRARY
    Private Sub btnBackLibrary_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBackLibrary.Click

        Form5_Movie_Library.Show()
        Me.Hide()

    End Sub


    ' BACK TO DASHBOARD
    Private Sub btnBackDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBackDashboard.Click

        Form3MainDashboard.Show()
        Me.Hide()

    End Sub


    ' EDIT MOVIE
    Private Sub btnEditMovie_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditMovie.Click

        MessageBox.Show(
            "Edit Movie functionality will be added next.",
            "Edit Movie",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

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


        ' Send the selected movie to Form 9
        Form9_Delete.LoadMovie(selectedMovie)

        ' Open Form 9
        Form9_Delete.Show()

        ' Hide Form 7
        Me.Hide()

    End Sub

End Class