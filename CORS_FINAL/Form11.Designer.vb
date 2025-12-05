<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        MenuButton = New PictureBox()
        Button24 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.check
        PictureBox1.Location = New Point(798, 187)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(268, 271)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(712, 461)
        Label3.Name = "Label3"
        Label3.Size = New Size(445, 78)
        Label3.TabIndex = 120
        Label3.Text = "ROOM CONFIRMED"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(778, 520)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 72)
        Label1.TabIndex = 121
        Label1.Text = "SEE YOU AT YOUR CLASSROOM" & vbCrLf & "THANK YOU!" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(860, 592)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 72)
        Label2.TabIndex = 122
        Label2.Text = "Dec 3, 2025" & vbCrLf & "6:09pm"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(MenuButton)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1902, 86)
        Panel1.TabIndex = 123
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(82, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(421, 53)
        Label4.TabIndex = 13
        Label4.Text = "Reservation Confirmation"
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
        ' Button24
        ' 
        Button24.BackColor = Color.Maroon
        Button24.FlatStyle = FlatStyle.Popup
        Button24.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button24.ForeColor = Color.White
        Button24.Location = New Point(1827, 969)
        Button24.Name = "Button24"
        Button24.Size = New Size(63, 32)
        Button24.TabIndex = 126
        Button24.Text = "<-"
        Button24.UseVisualStyleBackColor = False
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1902, 1013)
        Controls.Add(Button24)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form11"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form11"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents Button24 As Button
End Class
