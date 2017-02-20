<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShared
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
        Me.txtmoderator = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlocalchurch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmainchurch = New System.Windows.Forms.TextBox()
        Me.txtdistrict = New System.Windows.Forms.TextBox()
        Me.txtchurchpastor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.dtrTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtrFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lsvlistofOffering = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltotalamount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmoderator
        '
        Me.txtmoderator.Enabled = False
        Me.txtmoderator.Location = New System.Drawing.Point(441, 546)
        Me.txtmoderator.Name = "txtmoderator"
        Me.txtmoderator.Size = New System.Drawing.Size(150, 20)
        Me.txtmoderator.TabIndex = 17
        Me.txtmoderator.Text = "5%"
        Me.txtmoderator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(336, 546)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "MODERATOR:"
        '
        'txtlocalchurch
        '
        Me.txtlocalchurch.Enabled = False
        Me.txtlocalchurch.Location = New System.Drawing.Point(441, 519)
        Me.txtlocalchurch.Name = "txtlocalchurch"
        Me.txtlocalchurch.Size = New System.Drawing.Size(150, 20)
        Me.txtlocalchurch.TabIndex = 15
        Me.txtlocalchurch.Text = "15%"
        Me.txtlocalchurch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(329, 524)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "LOCAL CHURCH:"
        '
        'txtmainchurch
        '
        Me.txtmainchurch.Enabled = False
        Me.txtmainchurch.Location = New System.Drawing.Point(441, 493)
        Me.txtmainchurch.Name = "txtmainchurch"
        Me.txtmainchurch.Size = New System.Drawing.Size(150, 20)
        Me.txtmainchurch.TabIndex = 13
        Me.txtmainchurch.Text = "10%"
        Me.txtmainchurch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdistrict
        '
        Me.txtdistrict.Enabled = False
        Me.txtdistrict.Location = New System.Drawing.Point(441, 467)
        Me.txtdistrict.Name = "txtdistrict"
        Me.txtdistrict.Size = New System.Drawing.Size(150, 20)
        Me.txtdistrict.TabIndex = 12
        Me.txtdistrict.Text = "10%"
        Me.txtdistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtchurchpastor
        '
        Me.txtchurchpastor.Enabled = False
        Me.txtchurchpastor.Location = New System.Drawing.Point(441, 440)
        Me.txtchurchpastor.Name = "txtchurchpastor"
        Me.txtchurchpastor.Size = New System.Drawing.Size(150, 20)
        Me.txtchurchpastor.TabIndex = 11
        Me.txtchurchpastor.Text = "60%"
        Me.txtchurchpastor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(336, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "MAIN CHURCH:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(359, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "DISTRICT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(319, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CHURCH PASTOR:"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(491, 108)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(104, 38)
        Me.btnok.TabIndex = 14
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'dtrTo
        '
        Me.dtrTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtrTo.Location = New System.Drawing.Point(283, 124)
        Me.dtrTo.Name = "dtrTo"
        Me.dtrTo.Size = New System.Drawing.Size(186, 22)
        Me.dtrTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(280, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(57, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FROM:"
        '
        'dtrFrom
        '
        Me.dtrFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtrFrom.Location = New System.Drawing.Point(60, 124)
        Me.dtrFrom.Name = "dtrFrom"
        Me.dtrFrom.Size = New System.Drawing.Size(186, 22)
        Me.dtrFrom.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(53, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TOTAL AMOUNT IN EVERY MONTH"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(441, 587)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(154, 50)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lsvlistofOffering
        '
        Me.lsvlistofOffering.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvlistofOffering.FullRowSelect = True
        Me.lsvlistofOffering.GridLines = True
        Me.lsvlistofOffering.Location = New System.Drawing.Point(56, 170)
        Me.lsvlistofOffering.Name = "lsvlistofOffering"
        Me.lsvlistofOffering.Size = New System.Drawing.Size(535, 233)
        Me.lsvlistofOffering.TabIndex = 14
        Me.lsvlistofOffering.UseCompatibleStateImageBehavior = False
        Me.lsvlistofOffering.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "OFFERING TYPE"
        Me.ColumnHeader2.Width = 188
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "AMOUNT"
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATE"
        Me.ColumnHeader4.Width = 218
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CHURCH PASTOR SHARE"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DISTRICT MODERATOR SHARE"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "MAIN CHURCH SHARE"
        Me.ColumnHeader7.Width = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(648, 87)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Enabled = False
        Me.lbltotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.Location = New System.Drawing.Point(56, 473)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(185, 31)
        Me.lbltotalamount.TabIndex = 19
        Me.lbltotalamount.Text = "0"
        Me.lbltotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(57, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 31)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Offering Distribution"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 428)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(648, 228)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'frmShared
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 656)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbltotalamount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dtrFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtrTo)
        Me.Controls.Add(Me.txtmoderator)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lsvlistofOffering)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtlocalchurch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmainchurch)
        Me.Controls.Add(Me.txtdistrict)
        Me.Controls.Add(Me.txtchurchpastor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmShared"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShared"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmoderator As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtlocalchurch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmainchurch As System.Windows.Forms.TextBox
    Friend WithEvents txtdistrict As System.Windows.Forms.TextBox
    Friend WithEvents txtchurchpastor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtrTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtrFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents lsvlistofOffering As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltotalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
