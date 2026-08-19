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

            MessageBox.Show("Connected to MongoDB!")

        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
    End Sub

    ' Register Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2Register.Show()
        Me.Hide()
    End Sub

    ' Login Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            ' Check if email and password are entered
            If TextBox1.Text = "" OrElse TextBox2.Text = "" Then
                MessageBox.Show("Please enter your email and password.")
                Exit Sub
            End If

            ' Find user
            Dim filter As New BsonDocument From {
                {"Email", TextBox1.Text},
                {"Password", TextBox2.Text}
            }

            Dim user = collection.Find(filter).FirstOrDefault()

            If user IsNot Nothing Then

                MessageBox.Show("Login Successful!")

                Dim frm As New Form3MainDashboard()

                frm.UserName = user("Fname").AsString & " " &
                               user("Mname").AsString & " " &
                               user("Lname").AsString

                frm.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid email or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class