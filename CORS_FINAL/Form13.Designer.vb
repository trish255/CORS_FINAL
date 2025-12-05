<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        MenuButton = New PictureBox()
        Panel3 = New Panel()
        Label3 = New Label()
        Button24 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(MenuButton)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1902, 86)
        Panel1.TabIndex = 101
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1902, 86)
        Panel2.TabIndex = 102
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.profile
        PictureBox1.Location = New Point(1826, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(82, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(694, 53)
        Label2.TabIndex = 13
        Label2.Text = "Classroom Occupancy Reservation System "
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.menu1
        PictureBox3.Location = New Point(12, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(0, 120)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1902, 83)
        Panel3.TabIndex = 102
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(23, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 53)
        Label3.TabIndex = 15
        Label3.Text = "History"
        ' 
        ' Button24
        ' 
        Button24.BackColor = Color.Maroon
        Button24.FlatStyle = FlatStyle.Popup
        Button24.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button24.ForeColor = Color.White
        Button24.Location = New Point(1826, 969)
        Button24.Name = "Button24"
        Button24.Size = New Size(63, 32)
        Button24.TabIndex = 126
        Button24.Text = "<-"
        Button24.UseVisualStyleBackColor = False
        ' 
        ' Form13
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1902, 1013)
        Controls.Add(Button24)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form13"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form13"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button24 As Button
End Class
