Public Class Form3MainDashboard

    Public UserName As String
    Private Sub btnSearchMovie_Click(sender As Object, e As EventArgs) Handles btnSearchMovie.Click
        Form4_Search_movie.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnMovieLibrary_Click(sender As Object, e As EventArgs) Handles btnMovieLibrary.Click
        Form5_Movie_Library.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        Form6__Add_Movie.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Form8_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub Form3MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class