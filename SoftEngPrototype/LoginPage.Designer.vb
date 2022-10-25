<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBuser = New System.Windows.Forms.TextBox()
        Me.LBLuser = New System.Windows.Forms.Label()
        Me.LBLpass = New System.Windows.Forms.Label()
        Me.TBpass = New System.Windows.Forms.TextBox()
        Me.BTNlogin = New System.Windows.Forms.Button()
        Me.BTNclear = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SoftEngPrototype.My.Resources.Resources.SanIsidroLogo
        Me.PictureBox1.Location = New System.Drawing.Point(268, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TBuser
        '
        Me.TBuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBuser.Location = New System.Drawing.Point(321, 340)
        Me.TBuser.Name = "TBuser"
        Me.TBuser.Size = New System.Drawing.Size(163, 22)
        Me.TBuser.TabIndex = 1
        '
        'LBLuser
        '
        Me.LBLuser.AutoSize = True
        Me.LBLuser.Location = New System.Drawing.Point(366, 321)
        Me.LBLuser.Name = "LBLuser"
        Me.LBLuser.Size = New System.Drawing.Size(70, 16)
        Me.LBLuser.TabIndex = 2
        Me.LBLuser.Text = "Username"
        '
        'LBLpass
        '
        Me.LBLpass.AutoSize = True
        Me.LBLpass.Location = New System.Drawing.Point(369, 385)
        Me.LBLpass.Name = "LBLpass"
        Me.LBLpass.Size = New System.Drawing.Size(67, 16)
        Me.LBLpass.TabIndex = 3
        Me.LBLpass.Text = "Password"
        '
        'TBpass
        '
        Me.TBpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBpass.Location = New System.Drawing.Point(321, 404)
        Me.TBpass.Name = "TBpass"
        Me.TBpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBpass.Size = New System.Drawing.Size(163, 22)
        Me.TBpass.TabIndex = 4
        '
        'BTNlogin
        '
        Me.BTNlogin.Location = New System.Drawing.Point(409, 457)
        Me.BTNlogin.Name = "BTNlogin"
        Me.BTNlogin.Size = New System.Drawing.Size(75, 37)
        Me.BTNlogin.TabIndex = 5
        Me.BTNlogin.Text = "Login"
        Me.BTNlogin.UseVisualStyleBackColor = True
        '
        'BTNclear
        '
        Me.BTNclear.Location = New System.Drawing.Point(321, 457)
        Me.BTNclear.Name = "BTNclear"
        Me.BTNclear.Size = New System.Drawing.Size(75, 37)
        Me.BTNclear.TabIndex = 6
        Me.BTNclear.Text = "Clear"
        Me.BTNclear.UseVisualStyleBackColor = True
        '
        'LoginPage
        '
        Me.AcceptButton = Me.BTNlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(806, 552)
        Me.Controls.Add(Me.BTNclear)
        Me.Controls.Add(Me.BTNlogin)
        Me.Controls.Add(Me.TBpass)
        Me.Controls.Add(Me.LBLpass)
        Me.Controls.Add(Me.LBLuser)
        Me.Controls.Add(Me.TBuser)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBuser As TextBox
    Friend WithEvents LBLuser As Label
    Friend WithEvents LBLpass As Label
    Friend WithEvents TBpass As TextBox
    Friend WithEvents BTNlogin As Button
    Friend WithEvents BTNclear As Button

    Private Sub BTNlogin_Click(sender As Object, e As EventArgs) Handles BTNlogin.Click
        If TBuser.Text = "" Or TBpass.Text = "" Then
            MessageBox.Show("Username and Password cannot be blank", "Error")

        ElseIf TBuser.Text <> "Admin" Or TBpass.Text <> "Admin" Then
            MessageBox.Show("Invalid Login Credentials!", "Error")

        Else
            MenuPage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BTNclear_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        TBuser.Text = ""
        TBpass.Text = ""
    End Sub
End Class
