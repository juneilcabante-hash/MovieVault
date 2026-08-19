<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7_Movie_Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7_Movie_Details))
        btnEditMovie = New Button()
        btnDeleteMovie = New Button()
        btnBackLibrary = New Button()
        btnBackDashboard = New Button()
        txtDetailsTitle = New TextBox()
        txtDetailsDirector = New TextBox()
        txtDetailsDuration = New TextBox()
        txtDetailsYear = New TextBox()
        txtDetailsDescription = New TextBox()
        txtDetailsGenre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btnEditMovie
        ' 
        btnEditMovie.BackColor = Color.Silver
        btnEditMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditMovie.Location = New Point(704, 818)
        btnEditMovie.Name = "btnEditMovie"
        btnEditMovie.Size = New Size(226, 52)
        btnEditMovie.TabIndex = 0
        btnEditMovie.Text = "EDIT MOVIE "
        btnEditMovie.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteMovie
        ' 
        btnDeleteMovie.BackColor = Color.Silver
        btnDeleteMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteMovie.Location = New Point(956, 818)
        btnDeleteMovie.Name = "btnDeleteMovie"
        btnDeleteMovie.Size = New Size(226, 52)
        btnDeleteMovie.TabIndex = 1
        btnDeleteMovie.Text = "DELETE MOVIE"
        btnDeleteMovie.UseVisualStyleBackColor = False
        ' 
        ' btnBackLibrary
        ' 
        btnBackLibrary.BackColor = Color.Silver
        btnBackLibrary.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackLibrary.Location = New Point(346, 818)
        btnBackLibrary.Name = "btnBackLibrary"
        btnBackLibrary.Size = New Size(335, 52)
        btnBackLibrary.TabIndex = 2
        btnBackLibrary.Text = "Back To Library"
        btnBackLibrary.UseVisualStyleBackColor = False
        ' 
        ' btnBackDashboard
        ' 
        btnBackDashboard.BackColor = Color.Silver
        btnBackDashboard.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackDashboard.Location = New Point(1209, 818)
        btnBackDashboard.Name = "btnBackDashboard"
        btnBackDashboard.Size = New Size(335, 52)
        btnBackDashboard.TabIndex = 3
        btnBackDashboard.Text = "BACK TO DASHBOARD"
        btnBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' txtDetailsTitle
        ' 
        txtDetailsTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDetailsTitle.Location = New Point(704, 340)
        txtDetailsTitle.Name = "txtDetailsTitle"
        txtDetailsTitle.ReadOnly = True
        txtDetailsTitle.Size = New Size(803, 34)
        txtDetailsTitle.TabIndex = 4
        ' 
        ' txtDetailsDirector
        ' 
        txtDetailsDirector.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDetailsDirector.Location = New Point(704, 512)
        txtDetailsDirector.Name = "txtDetailsDirector"
        txtDetailsDirector.ReadOnly = True
        txtDetailsDirector.Size = New Size(803, 34)
        txtDetailsDirector.TabIndex = 5
        ' 
        ' txtDetailsDuration
        ' 
        txtDetailsDuration.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDetailsDuration.Location = New Point(704, 572)
        txtDetailsDuration.Name = "txtDetailsDuration"
        txtDetailsDuration.ReadOnly = True
        txtDetailsDuration.Size = New Size(803, 34)
        txtDetailsDuration.TabIndex = 6
        ' 
        ' txtDetailsYear
        ' 
        txtDetailsYear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDetailsYear.Location = New Point(704, 453)
        txtDetailsYear.Name = "txtDetailsYear"
        txtDetailsYear.ReadOnly = True
        txtDetailsYear.Size = New Size(803, 34)
        txtDetailsYear.TabIndex = 7
        ' 
        ' txtDetailsDescription
        ' 
        txtDetailsDescription.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDetailsDescription.Location = New Point(704, 633)
        txtDetailsDescription.Multiline = True
        txtDetailsDescription.Name = "txtDetailsDescription"
        txtDetailsDescription.ReadOnly = True
        txtDetailsDescription.Size = New Size(803, 142)
        txtDetailsDescription.TabIndex = 8
        ' 
        ' txtDetailsGenre
        ' 
        txtDetailsGenre.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDetailsGenre.Location = New Point(704, 395)
        txtDetailsGenre.Name = "txtDetailsGenre"
        txtDetailsGenre.ReadOnly = True
        txtDetailsGenre.Size = New Size(803, 34)
        txtDetailsGenre.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(425, 340)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 28)
        Label1.TabIndex = 10
        Label1.Text = "Movie Title:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(477, 395)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 11
        Label2.Text = "Genre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(414, 453)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 28)
        Label3.TabIndex = 12
        Label3.Text = "Realese Year:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(454, 512)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 28)
        Label4.TabIndex = 13
        Label4.Text = "Director:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(449, 572)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 28)
        Label5.TabIndex = 14
        Label5.Text = "Duration:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(424, 633)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 28)
        Label6.TabIndex = 15
        Label6.Text = "Description:"
        ' 
        ' Form7_Movie_Details
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtDetailsGenre)
        Controls.Add(txtDetailsDescription)
        Controls.Add(txtDetailsYear)
        Controls.Add(txtDetailsDuration)
        Controls.Add(txtDetailsDirector)
        Controls.Add(txtDetailsTitle)
        Controls.Add(btnBackDashboard)
        Controls.Add(btnBackLibrary)
        Controls.Add(btnDeleteMovie)
        Controls.Add(btnEditMovie)
        Name = "Form7_Movie_Details"
        Text = "Form7_Movie_Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEditMovie As Button
    Friend WithEvents btnDeleteMovie As Button
    Friend WithEvents btnBackLibrary As Button
    Friend WithEvents btnBackDashboard As Button
    Friend WithEvents txtDetailsTitle As TextBox
    Friend WithEvents txtDetailsDirector As TextBox
    Friend WithEvents txtDetailsDuration As TextBox
    Friend WithEvents txtDetailsYear As TextBox
    Friend WithEvents txtDetailsDescription As TextBox
    Friend WithEvents txtDetailsGenre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
