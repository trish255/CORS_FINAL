<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Button15 = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        MenuButton = New PictureBox()
        Label10 = New Label()
        ButtonIK602 = New Button()
        Label3 = New Label()
        Button3 = New Button()
        Label2 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.DarkGray
        Button15.FlatStyle = FlatStyle.Popup
        Button15.Font = New Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button15.Location = New Point(1714, 937)
        Button15.Name = "Button15"
        Button15.Size = New Size(141, 60)
        Button15.TabIndex = 99
        Button15.Text = "Back"
        Button15.UseVisualStyleBackColor = False
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
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.DarkGray
        Label10.Font = New Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(175, 296)
        Label10.Name = "Label10"
        Label10.Size = New Size(138, 78)
        Label10.TabIndex = 93
        Label10.Text = "2:00pm - 5:30pm" & vbCrLf & "Prof name" & vbCrLf & "Subject" & vbCrLf
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonIK602
        ' 
        ButtonIK602.BackColor = Color.DarkGray
        ButtonIK602.FlatStyle = FlatStyle.Popup
        ButtonIK602.Font = New Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonIK602.Location = New Point(495, 314)
        ButtonIK602.Name = "ButtonIK602"
        ButtonIK602.Size = New Size(171, 60)
        ButtonIK602.TabIndex = 97
        ButtonIK602.Text = "Book Reservation"
        ButtonIK602.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(159), CByte(255), CByte(119))
        Label3.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(485, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 106)
        Label3.TabIndex = 96
        Label3.Text = "Ik602"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(159), CByte(255), CByte(119))
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(437, 184)
        Button3.Name = "Button3"
        Button3.Size = New Size(284, 215)
        Button3.TabIndex = 95
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkGray
        Label2.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(150, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 106)
        Label2.TabIndex = 94
        Label2.Text = "Ik601"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(102, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(284, 215)
        Button1.TabIndex = 92
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(MenuButton)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1902, 86)
        Panel1.TabIndex = 91
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_opacity
        PictureBox1.Location = New Point(686, 230)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(589, 619)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 98
        PictureBox1.TabStop = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1902, 1013)
        Controls.Add(Button15)
        Controls.Add(Label10)
        Controls.Add(ButtonIK602)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(MenuButton, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button15 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonIK602 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
