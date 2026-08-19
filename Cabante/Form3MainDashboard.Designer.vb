<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3MainDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3MainDashboard))
        btnSearchMovie = New Button()
        btnMovieLibrary = New Button()
        btnAddMovie = New Button()
        btnProfile = New Button()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnSearchMovie
        ' 
        btnSearchMovie.BackColor = Color.Silver
        btnSearchMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchMovie.ForeColor = Color.Black
        btnSearchMovie.Location = New Point(1320, 410)
        btnSearchMovie.Name = "btnSearchMovie"
        btnSearchMovie.Size = New Size(245, 88)
        btnSearchMovie.TabIndex = 4
        btnSearchMovie.Text = "Search Movie"
        btnSearchMovie.UseVisualStyleBackColor = False
        ' 
        ' btnMovieLibrary
        ' 
        btnMovieLibrary.BackColor = Color.Silver
        btnMovieLibrary.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMovieLibrary.Location = New Point(1320, 584)
        btnMovieLibrary.Name = "btnMovieLibrary"
        btnMovieLibrary.Size = New Size(245, 88)
        btnMovieLibrary.TabIndex = 5
        btnMovieLibrary.Text = "Movie Library"
        btnMovieLibrary.UseVisualStyleBackColor = False
        ' 
        ' btnAddMovie
        ' 
        btnAddMovie.BackColor = Color.Silver
        btnAddMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddMovie.Location = New Point(1320, 763)
        btnAddMovie.Name = "btnAddMovie"
        btnAddMovie.Size = New Size(245, 88)
        btnAddMovie.TabIndex = 6
        btnAddMovie.Text = "Add Movie"
        btnAddMovie.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Silver
        btnProfile.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfile.Location = New Point(337, 410)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(203, 47)
        btnProfile.TabIndex = 8
        btnProfile.Text = "Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(368, 317)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 38)
        Label4.TabIndex = 10
        Label4.Text = "ACCOUNT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(1270, 317)
        Label5.Name = "Label5"
        Label5.Size = New Size(320, 38)
        Label5.TabIndex = 11
        Label5.Text = "MOVIE MANAGEMENT"
        ' 
        ' Form3MainDashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnProfile)
        Controls.Add(btnAddMovie)
        Controls.Add(btnMovieLibrary)
        Controls.Add(btnSearchMovie)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form3MainDashboard"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSearchMovie As Button
    Friend WithEvents btnMovieLibrary As Button
    Friend WithEvents btnAddMovie As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
