<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPage
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
        Me.BTNblotter = New System.Windows.Forms.Button()
        Me.BTNcreate = New System.Windows.Forms.Button()
        Me.BTNagree = New System.Windows.Forms.Button()
        Me.BTNlogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNblotter
        '
        Me.BTNblotter.Location = New System.Drawing.Point(273, 185)
        Me.BTNblotter.Name = "BTNblotter"
        Me.BTNblotter.Size = New System.Drawing.Size(235, 59)
        Me.BTNblotter.TabIndex = 0
        Me.BTNblotter.Text = "Blotter Database"
        Me.BTNblotter.UseVisualStyleBackColor = True
        '
        'BTNcreate
        '
        Me.BTNcreate.Location = New System.Drawing.Point(273, 106)
        Me.BTNcreate.Name = "BTNcreate"
        Me.BTNcreate.Size = New System.Drawing.Size(235, 59)
        Me.BTNcreate.TabIndex = 1
        Me.BTNcreate.Text = "Create New Report"
        Me.BTNcreate.UseVisualStyleBackColor = True
        '
        'BTNagree
        '
        Me.BTNagree.Location = New System.Drawing.Point(273, 267)
        Me.BTNagree.Name = "BTNagree"
        Me.BTNagree.Size = New System.Drawing.Size(235, 59)
        Me.BTNagree.TabIndex = 2
        Me.BTNagree.Text = "Agreements"
        Me.BTNagree.UseVisualStyleBackColor = True
        '
        'BTNlogout
        '
        Me.BTNlogout.Location = New System.Drawing.Point(713, 21)
        Me.BTNlogout.Name = "BTNlogout"
        Me.BTNlogout.Size = New System.Drawing.Size(75, 30)
        Me.BTNlogout.TabIndex = 3
        Me.BTNlogout.Text = "Log Out"
        Me.BTNlogout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SoftEngPrototype.My.Resources.Resources.SanIsidroLogo
        Me.PictureBox1.Location = New System.Drawing.Point(652, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MenuPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNlogout)
        Me.Controls.Add(Me.BTNagree)
        Me.Controls.Add(Me.BTNcreate)
        Me.Controls.Add(Me.BTNblotter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MenuPage"
        Me.Text = "Barangay San Isidro Blotter System - Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNblotter As Button
    Friend WithEvents BTNcreate As Button
    Friend WithEvents BTNagree As Button
    Friend WithEvents BTNlogout As Button
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub BTNlogout_Click(sender As Object, e As EventArgs) Handles BTNlogout.Click
        Me.Hide()
        LoginPage.Show()
    End Sub

    Private Sub BTNcreate_Click(sender As Object, e As EventArgs) Handles BTNcreate.Click
        Me.Hide()
        Create.Show()
    End Sub
End Class
