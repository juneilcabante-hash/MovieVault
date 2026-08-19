<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5_Movie_Library
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5_Movie_Library))
        btnViewDetails = New Button()
        btnBackDashboard = New Button()
        dgvMovies = New DataGridView()
        CType(dgvMovies, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.Silver
        btnViewDetails.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewDetails.Location = New Point(385, 861)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(273, 45)
        btnViewDetails.TabIndex = 1
        btnViewDetails.Text = "VIEW DETAILS"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' btnBackDashboard
        ' 
        btnBackDashboard.BackColor = Color.Silver
        btnBackDashboard.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackDashboard.ForeColor = Color.Black
        btnBackDashboard.Location = New Point(1149, 861)
        btnBackDashboard.Name = "btnBackDashboard"
        btnBackDashboard.Size = New Size(390, 45)
        btnBackDashboard.TabIndex = 2
        btnBackDashboard.Text = "BACK TO DASHBOARD"
        btnBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' dgvMovies
        ' 
        dgvMovies.AllowUserToAddRows = False
        dgvMovies.AllowUserToDeleteRows = False
        dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMovies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvMovies.DefaultCellStyle = DataGridViewCellStyle1
        dgvMovies.Location = New Point(385, 232)
        dgvMovies.MultiSelect = False
        dgvMovies.Name = "dgvMovies"
        dgvMovies.RowHeadersWidth = 51
        dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMovies.Size = New Size(1154, 614)
        dgvMovies.TabIndex = 4
        ' 
        ' Form5_Movie_Library
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(dgvMovies)
        Controls.Add(btnBackDashboard)
        Controls.Add(btnViewDetails)
        Name = "Form5_Movie_Library"
        Text = "Form5_Movie_Library"
        CType(dgvMovies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnBackDashboard As Button
    Friend WithEvents dgvMovies As DataGridView
End Class
