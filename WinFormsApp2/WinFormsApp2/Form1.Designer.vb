<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Divers = New System.Windows.Forms.GroupBox()
        Me.licenseBox = New System.Windows.Forms.CheckBox()
        Me.sportBox = New System.Windows.Forms.CheckBox()
        Me.adultBox = New System.Windows.Forms.CheckBox()
        Me.sexe = New System.Windows.Forms.GroupBox()
        Me.other = New System.Windows.Forms.RadioButton()
        Me.F = New System.Windows.Forms.RadioButton()
        Me.M = New System.Windows.Forms.RadioButton()
        Me.info_gen = New System.Windows.Forms.GroupBox()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.ss = New System.Windows.Forms.LinkLabel()
        Me.dd = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.NumTelBox = New System.Windows.Forms.TextBox()
        Me.MailBox = New System.Windows.Forms.TextBox()
        Me.PostalBox = New System.Windows.Forms.TextBox()
        Me.cityBox = New System.Windows.Forms.TextBox()
        Me.AdressBox = New System.Windows.Forms.TextBox()
        Me.SurnameBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Valid = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Divers.SuspendLayout()
        Me.sexe.SuspendLayout()
        Me.info_gen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Divers
        '
        Me.Divers.Controls.Add(Me.licenseBox)
        Me.Divers.Controls.Add(Me.sportBox)
        Me.Divers.Controls.Add(Me.adultBox)
        Me.Divers.Location = New System.Drawing.Point(39, 38)
        Me.Divers.Name = "Divers"
        Me.Divers.Size = New System.Drawing.Size(312, 153)
        Me.Divers.TabIndex = 0
        Me.Divers.TabStop = False
        Me.Divers.Text = "Divers"
        '
        'licenseBox
        '
        Me.licenseBox.AutoSize = True
        Me.licenseBox.Location = New System.Drawing.Point(33, 90)
        Me.licenseBox.Name = "licenseBox"
        Me.licenseBox.Size = New System.Drawing.Size(128, 19)
        Me.licenseBox.TabIndex = 2
        Me.licenseBox.Text = "permis de conduire"
        Me.licenseBox.UseVisualStyleBackColor = True
        '
        'sportBox
        '
        Me.sportBox.AutoSize = True
        Me.sportBox.Location = New System.Drawing.Point(33, 56)
        Me.sportBox.Name = "sportBox"
        Me.sportBox.Size = New System.Drawing.Size(117, 19)
        Me.sportBox.TabIndex = 1
        Me.sportBox.Text = "Pratique un sport"
        Me.sportBox.UseVisualStyleBackColor = True
        '
        'adultBox
        '
        Me.adultBox.AutoSize = True
        Me.adultBox.Location = New System.Drawing.Point(33, 22)
        Me.adultBox.Name = "adultBox"
        Me.adultBox.Size = New System.Drawing.Size(70, 19)
        Me.adultBox.TabIndex = 0
        Me.adultBox.Text = "+ 18 ans"
        Me.adultBox.UseVisualStyleBackColor = True
        '
        'sexe
        '
        Me.sexe.Controls.Add(Me.other)
        Me.sexe.Controls.Add(Me.F)
        Me.sexe.Controls.Add(Me.M)
        Me.sexe.Location = New System.Drawing.Point(39, 219)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(312, 155)
        Me.sexe.TabIndex = 1
        Me.sexe.TabStop = False
        Me.sexe.Text = "sexe*"
        '
        'other
        '
        Me.other.AutoSize = True
        Me.other.Location = New System.Drawing.Point(33, 105)
        Me.other.Name = "other"
        Me.other.Size = New System.Drawing.Size(55, 19)
        Me.other.TabIndex = 2
        Me.other.TabStop = True
        Me.other.Text = "Other"
        Me.other.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.F.AutoSize = True
        Me.F.Location = New System.Drawing.Point(33, 70)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(31, 19)
        Me.F.TabIndex = 1
        Me.F.TabStop = True
        Me.F.Text = "F"
        Me.F.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.AutoSize = True
        Me.M.Location = New System.Drawing.Point(33, 31)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(36, 19)
        Me.M.TabIndex = 0
        Me.M.TabStop = True
        Me.M.Text = "M"
        Me.M.UseVisualStyleBackColor = True
        '
        'info_gen
        '
        Me.info_gen.Controls.Add(Me.LinkLabel8)
        Me.info_gen.Controls.Add(Me.LinkLabel6)
        Me.info_gen.Controls.Add(Me.LinkLabel5)
        Me.info_gen.Controls.Add(Me.LinkLabel4)
        Me.info_gen.Controls.Add(Me.ss)
        Me.info_gen.Controls.Add(Me.dd)
        Me.info_gen.Controls.Add(Me.LinkLabel1)
        Me.info_gen.Controls.Add(Me.NumTelBox)
        Me.info_gen.Controls.Add(Me.MailBox)
        Me.info_gen.Controls.Add(Me.PostalBox)
        Me.info_gen.Controls.Add(Me.cityBox)
        Me.info_gen.Controls.Add(Me.AdressBox)
        Me.info_gen.Controls.Add(Me.SurnameBox)
        Me.info_gen.Controls.Add(Me.NameBox)
        Me.info_gen.Location = New System.Drawing.Point(431, 38)
        Me.info_gen.Name = "info_gen"
        Me.info_gen.Size = New System.Drawing.Size(299, 270)
        Me.info_gen.TabIndex = 2
        Me.info_gen.TabStop = False
        Me.info_gen.Text = "info_gen"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel8.Location = New System.Drawing.Point(6, 212)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(99, 15)
        Me.LinkLabel8.TabIndex = 14
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Num. Telephone*"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel6.Location = New System.Drawing.Point(6, 163)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(90, 15)
        Me.LinkLabel6.TabIndex = 12
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Adresse e-mail*"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel5.Location = New System.Drawing.Point(145, 112)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(75, 15)
        Me.LinkLabel5.TabIndex = 11
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Code Postal*"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel4.Location = New System.Drawing.Point(6, 112)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(29, 15)
        Me.LinkLabel4.TabIndex = 10
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Ville"
        '
        'ss
        '
        Me.ss.AutoSize = True
        Me.ss.LinkColor = System.Drawing.Color.Black
        Me.ss.Location = New System.Drawing.Point(6, 68)
        Me.ss.Name = "ss"
        Me.ss.Size = New System.Drawing.Size(53, 15)
        Me.ss.TabIndex = 9
        Me.ss.TabStop = True
        Me.ss.Text = "Adresse*"
        '
        'dd
        '
        Me.dd.AutoSize = True
        Me.dd.LinkColor = System.Drawing.Color.Black
        Me.dd.Location = New System.Drawing.Point(145, 15)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(59, 15)
        Me.dd.TabIndex = 8
        Me.dd.TabStop = True
        Me.dd.Text = "Surname*"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 15)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Name*"
        '
        'NumTelBox
        '
        Me.NumTelBox.Location = New System.Drawing.Point(6, 232)
        Me.NumTelBox.Name = "NumTelBox"
        Me.NumTelBox.Size = New System.Drawing.Size(106, 23)
        Me.NumTelBox.TabIndex = 6
        '
        'MailBox
        '
        Me.MailBox.Location = New System.Drawing.Point(6, 181)
        Me.MailBox.Name = "MailBox"
        Me.MailBox.Size = New System.Drawing.Size(245, 23)
        Me.MailBox.TabIndex = 5
        '
        'PostalBox
        '
        Me.PostalBox.Location = New System.Drawing.Point(145, 130)
        Me.PostalBox.Name = "PostalBox"
        Me.PostalBox.Size = New System.Drawing.Size(106, 23)
        Me.PostalBox.TabIndex = 4
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(6, 130)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(106, 23)
        Me.cityBox.TabIndex = 3
        '
        'AdressBox
        '
        Me.AdressBox.Location = New System.Drawing.Point(6, 86)
        Me.AdressBox.Name = "AdressBox"
        Me.AdressBox.Size = New System.Drawing.Size(245, 23)
        Me.AdressBox.TabIndex = 2
        '
        'SurnameBox
        '
        Me.SurnameBox.Location = New System.Drawing.Point(145, 33)
        Me.SurnameBox.Name = "SurnameBox"
        Me.SurnameBox.Size = New System.Drawing.Size(106, 23)
        Me.SurnameBox.TabIndex = 1
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(6, 33)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(106, 23)
        Me.NameBox.TabIndex = 0
        '
        'Valid
        '
        Me.Valid.Location = New System.Drawing.Point(502, 338)
        Me.Valid.Name = "Valid"
        Me.Valid.Size = New System.Drawing.Size(180, 50)
        Me.Valid.TabIndex = 3
        Me.Valid.Text = "Valid"
        Me.Valid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "* obligatoire"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Valid)
        Me.Controls.Add(Me.info_gen)
        Me.Controls.Add(Me.sexe)
        Me.Controls.Add(Me.Divers)
        Me.Name = "Form1"
        Me.Text = "d"
        Me.Divers.ResumeLayout(False)
        Me.Divers.PerformLayout()
        Me.sexe.ResumeLayout(False)
        Me.sexe.PerformLayout()
        Me.info_gen.ResumeLayout(False)
        Me.info_gen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Divers As GroupBox
    Friend WithEvents licenseBox As CheckBox
    Friend WithEvents sportBox As CheckBox
    Friend WithEvents adultBox As CheckBox
    Friend WithEvents sexe As GroupBox
    Friend WithEvents F As RadioButton
    Friend WithEvents M As RadioButton
    Friend WithEvents info_gen As GroupBox
    Friend WithEvents Valid As Button
    Friend WithEvents MailBox As TextBox
    Friend WithEvents PostalBox As TextBox
    Friend WithEvents cityBox As TextBox
    Friend WithEvents AdressBox As TextBox
    Friend WithEvents SurnameBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents NumTelBox As TextBox
    Friend WithEvents other As RadioButton
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents ss As LinkLabel
    Friend WithEvents dd As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
