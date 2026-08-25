Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class Form2Register

    ' MongoDB connection
    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase =
        client.GetDatabase("ProjectAdvanceDB")

    Private collection As IMongoCollection(Of BsonDocument)


    ' FORM LOAD
    Private Sub Form2_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            collection =
                database.GetCollection(Of BsonDocument)("User")

            ' Hide password characters
            TextBox5.UseSystemPasswordChar = True
            TextBox7.UseSystemPasswordChar = True

        Catch ex As Exception

            MessageBox.Show(
                "Database connection failed: " &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' REGISTER BUTTON
    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        Try

            ' =========================
            ' CHECK EMPTY FIELDS
            ' =========================

            If TextBox6.Text.Trim() = "" OrElse
               TextBox1.Text.Trim() = "" OrElse
               TextBox2.Text.Trim() = "" OrElse
               TextBox3.Text.Trim() = "" OrElse
               TextBox8.Text.Trim() = "" OrElse
               TextBox4.Text.Trim() = "" OrElse
               TextBox5.Text = "" OrElse
               TextBox7.Text = "" Then

                MessageBox.Show(
                    "Please fill in all fields.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' =========================
            ' VALIDATE AGE
            ' =========================

            Dim age As Integer

            If Not Integer.TryParse(
                TextBox3.Text.Trim(),
                age
            ) Then

                MessageBox.Show(
                    "Please enter a valid age.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' =========================
            ' CHECK PASSWORD
            ' =========================

            If TextBox5.Text <> TextBox7.Text Then

                MessageBox.Show(
                    "Password and Confirm Password do not match.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' =========================
            ' GET USERNAME AND EMAIL
            ' =========================

            Dim username As String =
                TextBox8.Text.Trim()

            Dim email As String =
                TextBox4.Text.Trim()


            ' =========================
            ' CHECK EMAIL
            ' =========================

            Dim existingUser =
                collection.Find(
                    New BsonDocument(
                        "Email",
                        email
                    )
                ).FirstOrDefault()


            If existingUser IsNot Nothing Then

                MessageBox.Show(
                    "This email is already registered.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' =========================
            ' CHECK USERNAME
            ' =========================

            Dim existingUsername =
                collection.Find(
                    New BsonDocument(
                        "Username",
                        username
                    )
                ).FirstOrDefault()


            If existingUsername IsNot Nothing Then

                MessageBox.Show(
                    "This username is already taken.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            ' =========================
            ' CREATE USER
            ' =========================

            Dim user As New BsonDocument From {
                {"Fname", TextBox6.Text.Trim()},
                {"Mname", TextBox1.Text.Trim()},
                {"Lname", TextBox2.Text.Trim()},
                {"Age", age},
                {"Username", username},
                {"Email", email},
                {"Password", TextBox5.Text}
            }


            ' =========================
            ' SAVE TO MONGODB
            ' =========================

            collection.InsertOne(user)


            ' =========================
            ' SUCCESS
            ' =========================

            MessageBox.Show(
                "Registration Successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            ' Return to Login
            Form1.Show()
            Me.Close()


        Catch ex As Exception

            MessageBox.Show(
                "Error: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' EMPTY LABEL EVENTS
    Private Sub Label7_Click(
        sender As Object,
        e As EventArgs
    ) Handles Label7.Click

    End Sub


    Private Sub Label5_Click(
        sender As Object,
        e As EventArgs
    ) Handles Label5.Click

    End Sub


    Private Sub TextBox7_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles TextBox7.TextChanged

    End Sub

End Class