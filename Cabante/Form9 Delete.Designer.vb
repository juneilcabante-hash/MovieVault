<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9_Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9_Delete))
        Label1 = New Label()
        btnDeleteMovie = New Button()
        btnCancel = New Button()
        btnBackLibrary = New Button()
        txtDeleteTitle = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(558, 448)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 28)
        Label1.TabIndex = 0
        Label1.Text = "Movie Title:"
        ' 
        ' btnDeleteMovie
        ' 
        btnDeleteMovie.BackColor = Color.Silver
        btnDeleteMovie.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteMovie.Location = New Point(558, 695)
        btnDeleteMovie.Name = "btnDeleteMovie"
        btnDeleteMovie.Size = New Size(258, 52)
        btnDeleteMovie.TabIndex = 3
        btnDeleteMovie.Text = "DELETE MOVIE"
        btnDeleteMovie.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Silver
        btnCancel.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(1068, 695)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(258, 52)
        btnCancel.TabIndex = 4
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBackLibrary
        ' 
        btnBackLibrary.BackColor = Color.Silver
        btnBackLibrary.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackLibrary.Location = New Point(669, 828)
        btnBackLibrary.Name = "btnBackLibrary"
        btnBackLibrary.Size = New Size(569, 52)
        btnBackLibrary.TabIndex = 5
        btnBackLibrary.Text = "BACK TO LIBRARY"
        btnBackLibrary.UseVisualStyleBackColor = False
        ' 
        ' txtDeleteTitle
        ' 
        txtDeleteTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeleteTitle.Location = New Point(757, 448)
        txtDeleteTitle.Name = "txtDeleteTitle"
        txtDeleteTitle.ReadOnly = True
        txtDeleteTitle.Size = New Size(569, 34)
        txtDeleteTitle.TabIndex = 6
        ' 
        ' Form9_Delete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(txtDeleteTitle)
        Controls.Add(btnBackLibrary)
        Controls.Add(btnCancel)
        Controls.Add(btnDeleteMovie)
        Controls.Add(Label1)
        Name = "Form9_Delete"
        Text = "Form9_Delete"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteMovie As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBackLibrary As Button
    Friend WithEvents txtDeleteTitle As TextBox
End Class
