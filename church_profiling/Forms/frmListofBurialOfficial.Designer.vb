﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofBurialOfficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofBurialOfficial))
        Me.lblTypeOfOfficial = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lsvChurchOfficial = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchMember = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lsvBurialOfficial = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTypeOfOfficial
        '
        Me.lblTypeOfOfficial.AutoSize = True
        Me.lblTypeOfOfficial.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTypeOfOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfOfficial.ForeColor = System.Drawing.Color.White
        Me.lblTypeOfOfficial.Location = New System.Drawing.Point(17, 30)
        Me.lblTypeOfOfficial.Name = "lblTypeOfOfficial"
        Me.lblTypeOfOfficial.Size = New System.Drawing.Size(268, 31)
        Me.lblTypeOfOfficial.TabIndex = 46
        Me.lblTypeOfOfficial.Text = "List of Burial Officials"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(532, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 25)
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(732, 128)
        Me.PictureBox4.TabIndex = 52
        Me.PictureBox4.TabStop = False
        '
        'lsvChurchOfficial
        '
        Me.lsvChurchOfficial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvChurchOfficial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ColumnHeader19, Me.ColumnHeader25, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.lsvChurchOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvChurchOfficial.FullRowSelect = True
        Me.lsvChurchOfficial.Location = New System.Drawing.Point(23, 148)
        Me.lsvChurchOfficial.Name = "lsvChurchOfficial"
        Me.lsvChurchOfficial.Size = New System.Drawing.Size(688, 344)
        Me.lsvChurchOfficial.TabIndex = 53
        Me.lsvChurchOfficial.UseCompatibleStateImageBehavior = False
        Me.lsvChurchOfficial.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Official Name"
        Me.ColumnHeader19.Width = 263
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Position"
        Me.ColumnHeader25.Width = 167
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Year"
        Me.ColumnHeader4.Width = 126
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(544, 92)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 15)
        Me.txtSearch.TabIndex = 48
        '
        'lblSearchMember
        '
        Me.lblSearchMember.AutoSize = True
        Me.lblSearchMember.BackColor = System.Drawing.Color.White
        Me.lblSearchMember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSearchMember.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMember.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblSearchMember.Location = New System.Drawing.Point(546, 91)
        Me.lblSearchMember.Name = "lblSearchMember"
        Me.lblSearchMember.Size = New System.Drawing.Size(73, 15)
        Me.lblSearchMember.TabIndex = 49
        Me.lblSearchMember.Text = "Search Official"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(506, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'lsvBurialOfficial
        '
        Me.lsvBurialOfficial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvBurialOfficial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvBurialOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBurialOfficial.FullRowSelect = True
        Me.lsvBurialOfficial.Location = New System.Drawing.Point(23, 148)
        Me.lsvBurialOfficial.Name = "lsvBurialOfficial"
        Me.lsvBurialOfficial.Size = New System.Drawing.Size(688, 344)
        Me.lsvBurialOfficial.TabIndex = 54
        Me.lsvBurialOfficial.UseCompatibleStateImageBehavior = False
        Me.lsvBurialOfficial.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Official Name"
        Me.ColumnHeader2.Width = 262
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Position"
        Me.ColumnHeader3.Width = 166
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Year"
        Me.ColumnHeader5.Width = 127
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 115
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 513)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(732, 10)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(23, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 33)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Active Official"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.Width = 114
        '
        'frmListofBurialOfficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 523)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lsvBurialOfficial)
        Me.Controls.Add(Me.lsvChurchOfficial)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSearchMember)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblTypeOfOfficial)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "frmListofBurialOfficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListofBurialOfficial"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTypeOfOfficial As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lsvChurchOfficial As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchMember As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lsvBurialOfficial As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
