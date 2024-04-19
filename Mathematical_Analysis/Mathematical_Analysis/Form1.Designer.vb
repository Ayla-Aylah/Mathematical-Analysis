<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdisplay
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
        Me.btnupload = New System.Windows.Forms.Button()
        Me.txtupload = New System.Windows.Forms.TextBox()
        Me.txtsolution = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.chkimport = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaccess = New System.Windows.Forms.Button()
        Me.btncarry = New System.Windows.Forms.Button()
        Me.txtimport = New System.Windows.Forms.TextBox()
        Me.cboDecimalPlace = New System.Windows.Forms.ComboBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.chkMode = New System.Windows.Forms.CheckBox()
        Me.chkCC = New System.Windows.Forms.CheckBox()
        Me.btndetermine = New System.Windows.Forms.Button()
        Me.txtreport = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(10, 35)
        Me.btnupload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(207, 50)
        Me.btnupload.TabIndex = 0
        Me.btnupload.Text = "Upload Text File"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'txtupload
        '
        Me.txtupload.BackColor = System.Drawing.Color.White
        Me.txtupload.Enabled = False
        Me.txtupload.Location = New System.Drawing.Point(225, 43)
        Me.txtupload.Margin = New System.Windows.Forms.Padding(4)
        Me.txtupload.Name = "txtupload"
        Me.txtupload.Size = New System.Drawing.Size(347, 34)
        Me.txtupload.TabIndex = 1
        '
        'txtsolution
        '
        Me.txtsolution.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsolution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtsolution.Location = New System.Drawing.Point(53, 401)
        Me.txtsolution.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsolution.Multiline = True
        Me.txtsolution.Name = "txtsolution"
        Me.txtsolution.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtsolution.Size = New System.Drawing.Size(779, 279)
        Me.txtsolution.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(53, 367)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(159, 30)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Solution/Report"
        '
        'btnreport
        '
        Me.btnreport.Enabled = False
        Me.btnreport.Location = New System.Drawing.Point(580, 93)
        Me.btnreport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(258, 50)
        Me.btnreport.TabIndex = 8
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.BackColor = System.Drawing.Color.White
        Me.lblDecimal.Location = New System.Drawing.Point(329, 50)
        Me.lblDecimal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(151, 28)
        Me.lblDecimal.TabIndex = 9
        Me.lblDecimal.Text = "Decimal Places:"
        '
        'chkimport
        '
        Me.chkimport.AutoSize = True
        Me.chkimport.Location = New System.Drawing.Point(29, 111)
        Me.chkimport.Margin = New System.Windows.Forms.Padding(4)
        Me.chkimport.Name = "chkimport"
        Me.chkimport.Size = New System.Drawing.Size(147, 32)
        Me.chkimport.TabIndex = 11
        Me.chkimport.Text = "Import Data"
        Me.chkimport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnaccess)
        Me.GroupBox1.Controls.Add(Me.btncarry)
        Me.GroupBox1.Controls.Add(Me.txtimport)
        Me.GroupBox1.Controls.Add(Me.chkimport)
        Me.GroupBox1.Controls.Add(Me.btnupload)
        Me.GroupBox1.Controls.Add(Me.txtupload)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(864, 175)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Input "
        '
        'btnaccess
        '
        Me.btnaccess.Enabled = False
        Me.btnaccess.Location = New System.Drawing.Point(580, 101)
        Me.btnaccess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaccess.Name = "btnaccess"
        Me.btnaccess.Size = New System.Drawing.Size(258, 50)
        Me.btnaccess.TabIndex = 14
        Me.btnaccess.Text = "Access Data"
        Me.btnaccess.UseVisualStyleBackColor = True
        '
        'btncarry
        '
        Me.btncarry.Enabled = False
        Me.btncarry.Location = New System.Drawing.Point(580, 43)
        Me.btncarry.Margin = New System.Windows.Forms.Padding(4)
        Me.btncarry.Name = "btncarry"
        Me.btncarry.Size = New System.Drawing.Size(258, 49)
        Me.btncarry.TabIndex = 13
        Me.btncarry.Text = "Carry Data"
        Me.btncarry.UseVisualStyleBackColor = True
        '
        'txtimport
        '
        Me.txtimport.BackColor = System.Drawing.Color.White
        Me.txtimport.Enabled = False
        Me.txtimport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtimport.Location = New System.Drawing.Point(225, 109)
        Me.txtimport.Margin = New System.Windows.Forms.Padding(4)
        Me.txtimport.Name = "txtimport"
        Me.txtimport.Size = New System.Drawing.Size(346, 34)
        Me.txtimport.TabIndex = 12
        '
        'cboDecimalPlace
        '
        Me.cboDecimalPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.cboDecimalPlace.FormattingEnabled = True
        Me.cboDecimalPlace.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboDecimalPlace.Location = New System.Drawing.Point(488, 47)
        Me.cboDecimalPlace.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDecimalPlace.Name = "cboDecimalPlace"
        Me.cboDecimalPlace.Size = New System.Drawing.Size(59, 36)
        Me.cboDecimalPlace.TabIndex = 13
        Me.cboDecimalPlace.Text = "3"
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(29, 49)
        Me.chkMean.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(89, 32)
        Me.chkMean.TabIndex = 14
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(126, 49)
        Me.chkMedian.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(106, 32)
        Me.chkMedian.TabIndex = 15
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'chkMode
        '
        Me.chkMode.AutoSize = True
        Me.chkMode.Location = New System.Drawing.Point(240, 49)
        Me.chkMode.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMode.Name = "chkMode"
        Me.chkMode.Size = New System.Drawing.Size(91, 32)
        Me.chkMode.TabIndex = 16
        Me.chkMode.Text = "Mode"
        Me.chkMode.UseVisualStyleBackColor = True
        '
        'chkCC
        '
        Me.chkCC.AutoSize = True
        Me.chkCC.Location = New System.Drawing.Point(29, 103)
        Me.chkCC.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Size = New System.Drawing.Size(241, 32)
        Me.chkCC.TabIndex = 17
        Me.chkCC.Text = "Correlation Coefficient"
        Me.chkCC.UseVisualStyleBackColor = True
        '
        'btndetermine
        '
        Me.btndetermine.Enabled = False
        Me.btndetermine.Location = New System.Drawing.Point(580, 36)
        Me.btndetermine.Margin = New System.Windows.Forms.Padding(4)
        Me.btndetermine.Name = "btndetermine"
        Me.btndetermine.Size = New System.Drawing.Size(259, 49)
        Me.btndetermine.TabIndex = 18
        Me.btndetermine.Text = "Determine"
        Me.btndetermine.UseVisualStyleBackColor = True
        '
        'txtreport
        '
        Me.txtreport.Enabled = False
        Me.txtreport.Location = New System.Drawing.Point(278, 101)
        Me.txtreport.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreport.Name = "txtreport"
        Me.txtreport.Size = New System.Drawing.Size(294, 34)
        Me.txtreport.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblDecimal)
        Me.GroupBox2.Controls.Add(Me.txtreport)
        Me.GroupBox2.Controls.Add(Me.btnreport)
        Me.GroupBox2.Controls.Add(Me.cboDecimalPlace)
        Me.GroupBox2.Controls.Add(Me.btndetermine)
        Me.GroupBox2.Controls.Add(Me.chkMean)
        Me.GroupBox2.Controls.Add(Me.chkCC)
        Me.GroupBox2.Controls.Add(Me.chkMedian)
        Me.GroupBox2.Controls.Add(Me.chkMode)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 157)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'frmdisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(916, 693)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtsolution)
        Me.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmdisplay"
        Me.Text = "Mathematical Analysis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnupload As Button
    Friend WithEvents txtupload As TextBox
    Friend WithEvents txtsolution As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnreport As Button
    Friend WithEvents lblDecimal As Label
    Friend WithEvents chkimport As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtimport As TextBox
    Friend WithEvents btncarry As Button
    Friend WithEvents btnaccess As Button
    Friend WithEvents cboDecimalPlace As ComboBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents chkMode As CheckBox
    Friend WithEvents chkCC As CheckBox
    Friend WithEvents btndetermine As Button
    Friend WithEvents txtreport As TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
