<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Me.DTfiling = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBcomp = New System.Windows.Forms.GroupBox()
        Me.TBcompNum = New System.Windows.Forms.TextBox()
        Me.TBcompAdd = New System.Windows.Forms.TextBox()
        Me.TBcompName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBaccu = New System.Windows.Forms.GroupBox()
        Me.TBaccuNum = New System.Windows.Forms.TextBox()
        Me.TBaccuAdd = New System.Windows.Forms.TextBox()
        Me.TBaccuName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBinci = New System.Windows.Forms.GroupBox()
        Me.TBinciReport = New System.Windows.Forms.TextBox()
        Me.DTincident = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTsubmit = New System.Windows.Forms.Button()
        Me.GBcomp.SuspendLayout()
        Me.GBaccu.SuspendLayout()
        Me.GBinci.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTfiling
        '
        Me.DTfiling.Location = New System.Drawing.Point(229, 16)
        Me.DTfiling.Name = "DTfiling"
        Me.DTfiling.Size = New System.Drawing.Size(245, 22)
        Me.DTfiling.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.73109!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date of Filling:"
        '
        'GBcomp
        '
        Me.GBcomp.Controls.Add(Me.TBcompNum)
        Me.GBcomp.Controls.Add(Me.TBcompAdd)
        Me.GBcomp.Controls.Add(Me.TBcompName)
        Me.GBcomp.Controls.Add(Me.Label4)
        Me.GBcomp.Controls.Add(Me.Label3)
        Me.GBcomp.Controls.Add(Me.Label2)
        Me.GBcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBcomp.Location = New System.Drawing.Point(17, 70)
        Me.GBcomp.Name = "GBcomp"
        Me.GBcomp.Size = New System.Drawing.Size(539, 146)
        Me.GBcomp.TabIndex = 8
        Me.GBcomp.TabStop = False
        Me.GBcomp.Text = "Complainant"
        '
        'TBcompNum
        '
        Me.TBcompNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBcompNum.Location = New System.Drawing.Point(146, 99)
        Me.TBcompNum.Name = "TBcompNum"
        Me.TBcompNum.Size = New System.Drawing.Size(371, 27)
        Me.TBcompNum.TabIndex = 12
        '
        'TBcompAdd
        '
        Me.TBcompAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBcompAdd.Location = New System.Drawing.Point(146, 66)
        Me.TBcompAdd.Name = "TBcompAdd"
        Me.TBcompAdd.Size = New System.Drawing.Size(371, 27)
        Me.TBcompAdd.TabIndex = 12
        '
        'TBcompName
        '
        Me.TBcompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBcompName.Location = New System.Drawing.Point(146, 34)
        Me.TBcompName.Name = "TBcompName"
        Me.TBcompName.Size = New System.Drawing.Size(371, 27)
        Me.TBcompName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'GBaccu
        '
        Me.GBaccu.Controls.Add(Me.TBaccuNum)
        Me.GBaccu.Controls.Add(Me.TBaccuAdd)
        Me.GBaccu.Controls.Add(Me.TBaccuName)
        Me.GBaccu.Controls.Add(Me.Label5)
        Me.GBaccu.Controls.Add(Me.Label6)
        Me.GBaccu.Controls.Add(Me.Label7)
        Me.GBaccu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBaccu.Location = New System.Drawing.Point(573, 70)
        Me.GBaccu.Name = "GBaccu"
        Me.GBaccu.Size = New System.Drawing.Size(539, 146)
        Me.GBaccu.TabIndex = 9
        Me.GBaccu.TabStop = False
        Me.GBaccu.Text = "Accused"
        '
        'TBaccuNum
        '
        Me.TBaccuNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBaccuNum.Location = New System.Drawing.Point(146, 99)
        Me.TBaccuNum.Name = "TBaccuNum"
        Me.TBaccuNum.Size = New System.Drawing.Size(371, 27)
        Me.TBaccuNum.TabIndex = 12
        '
        'TBaccuAdd
        '
        Me.TBaccuAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBaccuAdd.Location = New System.Drawing.Point(146, 66)
        Me.TBaccuAdd.Name = "TBaccuAdd"
        Me.TBaccuAdd.Size = New System.Drawing.Size(371, 27)
        Me.TBaccuAdd.TabIndex = 12
        '
        'TBaccuName
        '
        Me.TBaccuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBaccuName.Location = New System.Drawing.Point(146, 34)
        Me.TBaccuName.Name = "TBaccuName"
        Me.TBaccuName.Size = New System.Drawing.Size(371, 27)
        Me.TBaccuName.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Contact Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name:"
        '
        'GBinci
        '
        Me.GBinci.Controls.Add(Me.TBinciReport)
        Me.GBinci.Controls.Add(Me.DTincident)
        Me.GBinci.Controls.Add(Me.Label9)
        Me.GBinci.Controls.Add(Me.Label10)
        Me.GBinci.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBinci.Location = New System.Drawing.Point(17, 222)
        Me.GBinci.Name = "GBinci"
        Me.GBinci.Size = New System.Drawing.Size(1095, 422)
        Me.GBinci.TabIndex = 10
        Me.GBinci.TabStop = False
        Me.GBinci.Text = "Incident"
        '
        'TBinciReport
        '
        Me.TBinciReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBinciReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBinciReport.Location = New System.Drawing.Point(146, 69)
        Me.TBinciReport.Multiline = True
        Me.TBinciReport.Name = "TBinciReport"
        Me.TBinciReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBinciReport.Size = New System.Drawing.Size(927, 337)
        Me.TBinciReport.TabIndex = 12
        '
        'DTincident
        '
        Me.DTincident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTincident.Location = New System.Drawing.Point(146, 32)
        Me.DTincident.Name = "DTincident"
        Me.DTincident.Size = New System.Drawing.Size(267, 24)
        Me.DTincident.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Report:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Date of Incident:"
        '
        'BTsubmit
        '
        Me.BTsubmit.Location = New System.Drawing.Point(488, 667)
        Me.BTsubmit.Name = "BTsubmit"
        Me.BTsubmit.Size = New System.Drawing.Size(156, 63)
        Me.BTsubmit.TabIndex = 11
        Me.BTsubmit.Text = "Submit"
        Me.BTsubmit.UseVisualStyleBackColor = True
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 760)
        Me.Controls.Add(Me.BTsubmit)
        Me.Controls.Add(Me.GBinci)
        Me.Controls.Add(Me.GBaccu)
        Me.Controls.Add(Me.GBcomp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTfiling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Create"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Create New Report"
        Me.GBcomp.ResumeLayout(False)
        Me.GBcomp.PerformLayout()
        Me.GBaccu.ResumeLayout(False)
        Me.GBaccu.PerformLayout()
        Me.GBinci.ResumeLayout(False)
        Me.GBinci.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTfiling As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GBcomp As GroupBox
    Friend WithEvents TBcompNum As TextBox
    Friend WithEvents TBcompAdd As TextBox
    Friend WithEvents TBcompName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GBaccu As GroupBox
    Friend WithEvents TBaccuNum As TextBox
    Friend WithEvents TBaccuAdd As TextBox
    Friend WithEvents TBaccuName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GBinci As GroupBox
    Friend WithEvents TBinciReport As TextBox
    Friend WithEvents DTincident As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BTsubmit As Button

    Private Sub BTsubmit_Click(sender As Object, e As EventArgs) Handles BTsubmit.Click
        If TBcompName.Text = "" Or TBcompAdd.Text = "" Or TBcompNum.Text = "" Or TBaccuName.Text = "" Or TBaccuAdd.Text = "" Or TBaccuNum.Text = "" Or TBinciReport.Text = "" Then
            MessageBox.Show("There can't be empty fields", "Error")
        Else
            MessageBox.Show("Report Submitted!", "Success")

            Me.Hide()
            MenuPage.Show()
        End If

    End Sub
End Class
