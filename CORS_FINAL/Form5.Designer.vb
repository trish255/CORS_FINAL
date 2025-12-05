<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        MenuButton = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(MenuButton)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1904, 86)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.profile
        PictureBox2.Location = New Point(1826, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(82, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(694, 53)
        Label1.TabIndex = 13
        Label1.Text = "Classroom Occupancy Reservation System "
        ' 
        ' MenuButton
        ' 
        MenuButton.Image = My.Resources.Resources.menu1
        MenuButton.Location = New Point(12, 12)
        MenuButton.Name = "MenuButton"
        MenuButton.Size = New Size(64, 62)
        MenuButton.SizeMode = PictureBoxSizeMode.Zoom
        MenuButton.TabIndex = 1
        MenuButton.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1902, 1013)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuButton As PictureBox
End Class
