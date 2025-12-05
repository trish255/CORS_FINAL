<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
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
        Button15.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.Location = New Point(1719, 913)
        Button15.Name = "Button15"
        Button15.Size = New Size(171, 60)
        Button15.TabIndex = 108
        Button15.Text = "Next"
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
        Label1.Size = New Size(294, 53)
        Label1.TabIndex = 13
        Label1.Text = "Reservation Form"
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkGray
        Label2.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(791, 330)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 106)
        Label2.TabIndex = 103
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
        Panel1.Size = New Size(1924, 86)
        Panel1.TabIndex = 100
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(672, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 40)
        Label3.TabIndex = 15
        Label3.Text = "Name: "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(797, 301)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(540, 64)
        RichTextBox1.TabIndex = 109
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(797, 389)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(540, 64)
        RichTextBox2.TabIndex = 111
        RichTextBox2.Text = ""
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(797, 497)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(540, 37)
        DateTimePicker1.TabIndex = 113
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(672, 396)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 40)
        Label4.TabIndex = 114
        Label4.Text = "Subject:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(672, 494)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 40)
        Label5.TabIndex = 115
        Label5.Text = "Date:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(797, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(191, 26)
        Label6.TabIndex = 116
        Label6.Text = "(Surname, Firstname, MI)"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_opacity
        PictureBox1.Location = New Point(724, 238)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(589, 619)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 107
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"7:00am-9:00am ", "7:00am-10:00am ", "8:00am-11:00am "})
        ComboBox1.Location = New Point(797, 568)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(540, 44)
        ComboBox1.TabIndex = 117
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(672, 568)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 40)
        Label7.TabIndex = 118
        Label7.Text = "Time:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1924, 1013)
        Controls.Add(Label7)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker1)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label3)
        Controls.Add(Button15)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form9"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
End Class
