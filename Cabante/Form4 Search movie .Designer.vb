<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4_Search_movie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4_Search_movie))
        txtSearchMovie = New TextBox()
        Label2 = New Label()
        btnSearchMovie = New Button()
        dgvSearchMovies = New DataGridView()
        btnBackDashboard = New Button()
        btnViewDetails = New Button()
        CType(dgvSearchMovies, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchMovie
        ' 
        txtSearchMovie.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearchMovie.Location = New Point(376, 246)
        txtSearchMovie.Multiline = True
        txtSearchMovie.Name = "txtSearchMovie"
        txtSearchMovie.Size = New Size(641, 44)
        txtSearchMovie.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(376, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 38)
        Label2.TabIndex = 2
        Label2.Text = "Search Movie Title"
        ' 
        ' btnSearchMovie
        ' 
        btnSearchMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchMovie.Location = New Point(1023, 246)
        btnSearchMovie.Name = "btnSearchMovie"
        btnSearchMovie.Size = New Size(159, 44)
        btnSearchMovie.TabIndex = 3
        btnSearchMovie.Text = "Search"
        btnSearchMovie.UseVisualStyleBackColor = True
        ' 
        ' dgvSearchMovies
        ' 
        dgvSearchMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSearchMovies.Location = New Point(376, 296)
        dgvSearchMovies.Name = "dgvSearchMovies"
        dgvSearchMovies.RowHeadersWidth = 51
        dgvSearchMovies.Size = New Size(1159, 546)
        dgvSearchMovies.TabIndex = 4
        ' 
        ' btnBackDashboard
        ' 
        btnBackDashboard.BackColor = Color.Silver
        btnBackDashboard.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackDashboard.Location = New Point(1235, 848)
        btnBackDashboard.Name = "btnBackDashboard"
        btnBackDashboard.Size = New Size(300, 54)
        btnBackDashboard.TabIndex = 5
        btnBackDashboard.Text = "Back to Dash board"
        btnBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.Silver
        btnViewDetails.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewDetails.Location = New Point(376, 848)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(300, 54)
        btnViewDetails.TabIndex = 6
        btnViewDetails.Text = "VIEW DETAILS"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' Form4_Search_movie
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(btnViewDetails)
        Controls.Add(btnBackDashboard)
        Controls.Add(dgvSearchMovies)
        Controls.Add(btnSearchMovie)
        Controls.Add(Label2)
        Controls.Add(txtSearchMovie)
        Name = "Form4_Search_movie"
        Text = "Form4_Search_movie"
        CType(dgvSearchMovies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearchMovie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearchMovie As Button
    Friend WithEvents dgvSearchMovies As DataGridView
    Friend WithEvents btnBackDashboard As Button
    Friend WithEvents btnViewDetails As Button
End Class
