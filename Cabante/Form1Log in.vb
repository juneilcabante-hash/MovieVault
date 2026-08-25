Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class Form1

    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            client = New MongoClient("mongodb://localhost:27017")
            database = client.GetDatabase("ProjectAdvanceDB")
            collection = database.GetCollection(Of BsonDocument)("User")

        Catch ex As Exception

            MessageBox.Show(
                "Connection failed: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ==============================
    ' REGISTER BUTTON
    ' ==============================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2Register.Show()
        Me.Hide()

    End Sub


    ' ==============================
    ' LOGIN BUTTON
    ' ==============================

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            ' Check fields
            If TextBox1.Text.Trim() = "" OrElse
               TextBox2.Text.Trim() = "" Then

                MessageBox.Show(
                    "Please enter your email and password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Exit Sub

            End If


            ' Create login filter
            Dim filter As New BsonDocument From {
                {"Email", TextBox1.Text.Trim()},
                {"Password", TextBox2.Text}
            }


            ' Find user
            Dim user As BsonDocument =
                collection.Find(filter).FirstOrDefault()


            ' ==============================
            ' LOGIN SUCCESSFUL
            ' ==============================

            If user IsNot Nothing Then

                ' Save logged-in user's email
                UserSession.CurrentUserEmail =
                    user("Email").AsString


                MessageBox.Show(
                    "Login Successful!",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


                ' Open dashboard
                Dim frm As New Form3MainDashboard()


                ' Send user's full name to dashboard
                frm.UserName =
                    user("Fname").AsString & " " &
                    user("Mname").AsString & " " &
                    user("Lname").AsString


                frm.Show()
                Me.Hide()


            Else

                ' ==============================
                ' LOGIN FAILED
                ' ==============================

                MessageBox.Show(
                    "Invalid email or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Error: " & ex.Message,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class