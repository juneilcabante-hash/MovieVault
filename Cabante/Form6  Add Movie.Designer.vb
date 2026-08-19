<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6__Add_Movie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6__Add_Movie))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtTitle = New TextBox()
        txtDirector = New TextBox()
        txtYear = New TextBox()
        txtGenre = New TextBox()
        txtPosterURL = New TextBox()
        txtDescription = New TextBox()
        btnSaveMovie = New Button()
        btnClear = New Button()
        btnBackDashboard = New Button()
        txtDuration = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(485, 331)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 28)
        Label1.TabIndex = 0
        Label1.Text = "MOVIE TITLE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(541, 388)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 28)
        Label2.TabIndex = 1
        Label2.Text = "GENRE:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(469, 446)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 28)
        Label3.TabIndex = 2
        Label3.Text = "RELEASE YEAR:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(510, 505)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 28)
        Label4.TabIndex = 3
        Label4.Text = "DIRECTOR:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(477, 619)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 28)
        Label5.TabIndex = 4
        Label5.Text = "DESCRIPTION:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(489, 732)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 28)
        Label6.TabIndex = 5
        Label6.Text = "POSTER URL:"
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(771, 331)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(587, 34)
        txtTitle.TabIndex = 6
        ' 
        ' txtDirector
        ' 
        txtDirector.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDirector.Location = New Point(771, 505)
        txtDirector.Name = "txtDirector"
        txtDirector.Size = New Size(587, 34)
        txtDirector.TabIndex = 7
        ' 
        ' txtYear
        ' 
        txtYear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtYear.Location = New Point(771, 446)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(587, 34)
        txtYear.TabIndex = 8
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(771, 388)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(587, 34)
        txtGenre.TabIndex = 9
        ' 
        ' txtPosterURL
        ' 
        txtPosterURL.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPosterURL.Location = New Point(771, 736)
        txtPosterURL.Name = "txtPosterURL"
        txtPosterURL.Size = New Size(587, 34)
        txtPosterURL.TabIndex = 10
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(771, 619)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(587, 98)
        txtDescription.TabIndex = 11
        ' 
        ' btnSaveMovie
        ' 
        btnSaveMovie.BackColor = Color.Silver
        btnSaveMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveMovie.Location = New Point(489, 788)
        btnSaveMovie.Name = "btnSaveMovie"
        btnSaveMovie.Size = New Size(370, 48)
        btnSaveMovie.TabIndex = 14
        btnSaveMovie.Text = "SAVE MOVIE"
        btnSaveMovie.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Silver
        btnClear.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(999, 788)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(370, 48)
        btnClear.TabIndex = 15
        btnClear.Text = "CLEAR FORM"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnBackDashboard
        ' 
        btnBackDashboard.BackColor = Color.Silver
        btnBackDashboard.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackDashboard.Location = New Point(686, 855)
        btnBackDashboard.Name = "btnBackDashboard"
        btnBackDashboard.Size = New Size(475, 48)
        btnBackDashboard.TabIndex = 16
        btnBackDashboard.Text = "BACK TO DASHBOARD"
        btnBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' txtDuration
        ' 
        txtDuration.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDuration.Location = New Point(771, 562)
        txtDuration.Name = "txtDuration"
        txtDuration.Size = New Size(587, 34)
        txtDuration.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(502, 562)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 28)
        Label7.TabIndex = 18
        Label7.Text = "DURATION:"
        ' 
        ' Form6__Add_Movie
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label7)
        Controls.Add(txtDuration)
        Controls.Add(btnBackDashboard)
        Controls.Add(btnClear)
        Controls.Add(btnSaveMovie)
        Controls.Add(txtDescription)
        Controls.Add(txtPosterURL)
        Controls.Add(txtGenre)
        Controls.Add(txtYear)
        Controls.Add(txtDirector)
        Controls.Add(txtTitle)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form6__Add_Movie"
        Text = "Form6__Add_Movie"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtPosterURL As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSaveMovie As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBackDashboard As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label7 As Label
End Class
