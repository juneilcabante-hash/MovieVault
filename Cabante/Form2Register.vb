Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class Form2Register

    Private client As New MongoClient("mongodb://localhost:27017")
    Private database As IMongoDatabase = client.GetDatabase("ProjectAdvanceDB")
    Private collection As IMongoCollection(Of BsonDocument)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            collection = database.GetCollection(Of BsonDocument)("User")

        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message)
        End Try
    End Sub

    ' Register Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            ' Check if all fields are filled
            If TextBox6.Text.Trim() = "" OrElse
               TextBox1.Text.Trim() = "" OrElse
               TextBox2.Text.Trim() = "" OrElse
               TextBox3.Text.Trim() = "" OrElse
               TextBox4.Text.Trim() = "" OrElse
               TextBox5.Text.Trim() = "" Then

                MessageBox.Show("Please fill in all fields.",
                                "Registration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validate Age
            Dim age As Integer

            If Not Integer.TryParse(TextBox3.Text.Trim(), age) Then

                MessageBox.Show("Please enter a valid age.",
                                "Invalid Age",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                Exit Sub

            End If

            ' Check if email already exists
            Dim email As String = TextBox4.Text.Trim()

            Dim existingUser = collection.Find(
                New BsonDocument("Email", email)
            ).FirstOrDefault()

            If existingUser IsNot Nothing Then

                MessageBox.Show("This email is already registered.",
                                "Registration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                Exit Sub

            End If

            ' Create new user
            Dim user As New BsonDocument From {
                {"Fname", TextBox6.Text.Trim()},
                {"Mname", TextBox1.Text.Trim()},
                {"Lname", TextBox2.Text.Trim()},
                {"Age", age},
                {"Email", email},
                {"Password", TextBox5.Text}
            }

            ' Save user to MongoDB
            collection.InsertOne(user)

            MessageBox.Show("Registration Successful!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ' Return to Login
            Form1.Show()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

End Class