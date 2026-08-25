Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class Form8_Profile

    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase =
        client.GetDatabase("ProjectAdvanceDB")

    Private collection As IMongoCollection(Of BsonDocument) =
        database.GetCollection(Of BsonDocument)("User")

    ' Store original values for RESET
    Private originalFullName As String = ""
    Private originalEmail As String = ""
    Private originalUsername As String = ""


    ' ==============================
    ' FORM LOAD
    ' ==============================

    Private Sub Form8_Profile_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadProfile()

    End Sub


    ' ==============================
    ' LOAD PROFILE
    ' ==============================

    Private Sub LoadProfile()

        Try

            ' Make sure someone is logged in
            If String.IsNullOrWhiteSpace(UserSession.CurrentUserEmail) Then

                MessageBox.Show(
                    "No user is currently logged in.",
                    "Profile",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' Find current user
            Dim filter As New BsonDocument(
                "Email",
                UserSession.CurrentUserEmail
            )


            Dim user As BsonDocument =
                collection.Find(filter).FirstOrDefault()


            ' User not found
            If user Is Nothing Then

                MessageBox.Show(
                    "User account could not be found.",
                    "Profile",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' ==============================
            ' GET USER INFORMATION
            ' ==============================

            Dim firstName As String = ""
            Dim middleName As String = ""
            Dim lastName As String = ""
            Dim email As String = ""


            If user.Contains("Fname") Then
                firstName = user("Fname").ToString()
            End If

            If user.Contains("Mname") Then
                middleName = user("Mname").ToString()
            End If

            If user.Contains("Lname") Then
                lastName = user("Lname").ToString()
            End If

            If user.Contains("Email") Then
                email = user("Email").ToString()
            End If


            ' Build full name
            Dim fullName As String =
                (firstName & " " &
                 middleName & " " &
                 lastName).Trim()

            fullName =
                String.Join(
                    " ",
                    fullName.Split(
                        {" "c},
                        StringSplitOptions.RemoveEmptyEntries
                    )
                )


            ' ==============================
            ' DISPLAY INFORMATION
            ' ==============================

            TextBox2.Text = fullName
            TextBox3.Text = email

            ' Username was not originally stored
            ' so use email as username for now.
            If user.Contains("Username") Then
                TextBox5.Text = user("Username").ToString()
            Else
                TextBox5.Text = email
            End If


            ' Do NOT display the actual password
            TextBox1.Text = ""
            TextBox4.Text = ""


            ' Save original values for RESET
            originalFullName = TextBox2.Text
            originalEmail = TextBox3.Text
            originalUsername = TextBox5.Text


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load profile." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Profile Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ==============================
    ' SAVE CHANGES
    ' ==============================

    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        Try

            If String.IsNullOrWhiteSpace(UserSession.CurrentUserEmail) Then

                MessageBox.Show(
                    "No user is currently logged in.",
                    "Profile",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' Check required fields
            If TextBox2.Text.Trim() = "" OrElse
               TextBox3.Text.Trim() = "" Then

                MessageBox.Show(
                    "Full Name and Email cannot be empty.",
                    "Profile",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' Split full name
            Dim nameParts() As String =
                TextBox2.Text.Trim().Split(
                    {" "c},
                    StringSplitOptions.RemoveEmptyEntries
                )


            Dim firstName As String = ""
            Dim middleName As String = ""
            Dim lastName As String = ""


            If nameParts.Length = 1 Then

                firstName = nameParts(0)

            ElseIf nameParts.Length = 2 Then

                firstName = nameParts(0)
                lastName = nameParts(1)

            Else

                firstName = nameParts(0)
                lastName = nameParts(nameParts.Length - 1)

                For i As Integer = 1 To nameParts.Length - 2
                    middleName &= nameParts(i) & " "
                Next

                middleName = middleName.Trim()

            End If


            ' Find current account
            Dim filter As New BsonDocument(
                "Email",
                UserSession.CurrentUserEmail
            )


            ' Update user information
            Dim update As New BsonDocument(
                "$set",
                New BsonDocument From {
                    {"Fname", firstName},
                    {"Mname", middleName},
                    {"Lname", lastName},
                    {"Email", TextBox3.Text.Trim()}
                }
            )


            collection.UpdateOne(filter, update)


            ' Update session email
            UserSession.CurrentUserEmail =
                TextBox3.Text.Trim()


            ' Update original values
            originalFullName = TextBox2.Text.Trim()
            originalEmail = TextBox3.Text.Trim()
            originalUsername = TextBox5.Text.Trim()


            MessageBox.Show(
                "Profile updated successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


        Catch ex As Exception

            MessageBox.Show(
                "Unable to save changes." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Profile Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ==============================
    ' RESET
    ' ==============================

    Private Sub Button2_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button2.Click

        TextBox2.Text = originalFullName
        TextBox3.Text = originalEmail
        TextBox5.Text = originalUsername

        TextBox1.Clear()
        TextBox4.Clear()

    End Sub


    ' ==============================
    ' CHANGE PASSWORD
    ' ==============================

    Private Sub Button3_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button3.Click

        Try

            ' Check password fields
            If TextBox1.Text = "" OrElse
               TextBox4.Text = "" Then

                MessageBox.Show(
                    "Please enter your new password and confirm it.",
                    "Change Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' Check password match
            If TextBox1.Text <> TextBox4.Text Then

                MessageBox.Show(
                    "Passwords do not match.",
                    "Change Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' Find current user
            Dim filter As New BsonDocument(
                "Email",
                UserSession.CurrentUserEmail
            )


            ' Update password
            Dim update As New BsonDocument(
                "$set",
                New BsonDocument From {
                    {"Password", TextBox1.Text}
                }
            )


            collection.UpdateOne(filter, update)


            TextBox1.Clear()
            TextBox4.Clear()


            MessageBox.Show(
                "Password changed successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


        Catch ex As Exception

            MessageBox.Show(
                "Unable to change password." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Password Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ==============================
    ' BACK TO DASHBOARD
    ' ==============================

    Private Sub Button4_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button4.Click

        Form3MainDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult =
        MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            ' Clear logged-in user
            UserSession.CurrentUserEmail = ""

            ' Exit the entire application
            Application.Exit()

        End If

    End Sub
End Class