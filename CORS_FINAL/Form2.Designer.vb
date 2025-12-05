<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_opacity
        PictureBox1.Location = New Point(516, 211)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(713, 646)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(204, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(1393, 106)
        Label1.TabIndex = 2
        Label1.Text = "Classroom Occupancy Reservation System "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(611, 303)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 40)
        Label2.TabIndex = 3
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(611, 417)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 40)
        Label3.TabIndex = 4
        Label3.Text = "Password:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(611, 346)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(555, 53)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(611, 460)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(555, 53)
        RichTextBox2.TabIndex = 6
        RichTextBox2.Text = ""
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(611, 546)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(192, 40)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Remember me "
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(6), CByte(11), CByte(55))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(648, 611)
        Button1.Name = "Button1"
        Button1.Size = New Size(488, 63)
        Button1.TabIndex = 8
        Button1.Text = "Log in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(680, 721)
        Label4.Name = "Label4"
        Label4.Size = New Size(322, 40)
        Label4.TabIndex = 9
        Label4.Text = "Don't have an account? "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Orange
        Label5.Location = New Point(992, 721)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 40)
        Label5.TabIndex = 10
        Label5.Text = "Sign up"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1902, 1013)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
