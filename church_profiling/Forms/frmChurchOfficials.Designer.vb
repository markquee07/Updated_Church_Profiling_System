<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChurchOfficials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChurchOfficials))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lsvMemberInformaion = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtHostPastor = New System.Windows.Forms.TextBox()
        Me.txtElder = New System.Windows.Forms.TextBox()
        Me.txtDeacon1 = New System.Windows.Forms.TextBox()
        Me.txtDeacon2 = New System.Windows.Forms.TextBox()
        Me.txtDeacon3 = New System.Windows.Forms.TextBox()
        Me.txtTreasurer = New System.Windows.Forms.TextBox()
        Me.txtSecretary = New System.Windows.Forms.TextBox()
        Me.btnHostPastor = New System.Windows.Forms.Button()
        Me.btnElder = New System.Windows.Forms.Button()
        Me.btnDeacon1 = New System.Windows.Forms.Button()
        Me.btnDeacon2 = New System.Windows.Forms.Button()
        Me.btnDeacon3 = New System.Windows.Forms.Button()
        Me.btnTreasurer = New System.Windows.Forms.Button()
        Me.btnSecretary = New System.Windows.Forms.Button()
        Me.lblSearchMember = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ptbHostPastor = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ptbElder = New System.Windows.Forms.PictureBox()
        Me.ptbDeacon1 = New System.Windows.Forms.PictureBox()
        Me.ptbDeacon2 = New System.Windows.Forms.PictureBox()
        Me.ptbDeacon3 = New System.Windows.Forms.PictureBox()
        Me.ptbTreasurer = New System.Windows.Forms.PictureBox()
        Me.ptbSecretary = New System.Windows.Forms.PictureBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lsvPastorList = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.ptbHostPastor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbElder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbDeacon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbDeacon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbDeacon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTreasurer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSecretary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Church Officials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(197, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HOST PASTOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(507, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ELDER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(98, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DEACON 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(357, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DEACON 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(622, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "DEACON 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(216, 491)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "TREASURER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(495, 491)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "SECRETARY"
        '
        'lsvMemberInformaion
        '
        Me.lsvMemberInformaion.BackColor = System.Drawing.Color.White
        Me.lsvMemberInformaion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvMemberInformaion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7})
        Me.lsvMemberInformaion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvMemberInformaion.ForeColor = System.Drawing.Color.Black
        Me.lsvMemberInformaion.FullRowSelect = True
        Me.lsvMemberInformaion.Location = New System.Drawing.Point(870, 127)
        Me.lsvMemberInformaion.Name = "lsvMemberInformaion"
        Me.lsvMemberInformaion.Size = New System.Drawing.Size(322, 467)
        Me.lsvMemberInformaion.TabIndex = 56
        Me.lsvMemberInformaion.UseCompatibleStateImageBehavior = False
        Me.lsvMemberInformaion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Member ID"
        Me.ColumnHeader2.Width = 134
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Member Name"
        Me.ColumnHeader3.Width = 187
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Image Path"
        Me.ColumnHeader7.Width = 0
        '
        'txtHostPastor
        '
        Me.txtHostPastor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostPastor.Location = New System.Drawing.Point(168, 237)
        Me.txtHostPastor.Name = "txtHostPastor"
        Me.txtHostPastor.Size = New System.Drawing.Size(178, 22)
        Me.txtHostPastor.TabIndex = 57
        Me.txtHostPastor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtElder
        '
        Me.txtElder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElder.Location = New System.Drawing.Point(442, 237)
        Me.txtElder.Name = "txtElder"
        Me.txtElder.Size = New System.Drawing.Size(178, 22)
        Me.txtElder.TabIndex = 58
        Me.txtElder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDeacon1
        '
        Me.txtDeacon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeacon1.Location = New System.Drawing.Point(52, 435)
        Me.txtDeacon1.Name = "txtDeacon1"
        Me.txtDeacon1.Size = New System.Drawing.Size(178, 22)
        Me.txtDeacon1.TabIndex = 59
        Me.txtDeacon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDeacon2
        '
        Me.txtDeacon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeacon2.Location = New System.Drawing.Point(310, 435)
        Me.txtDeacon2.Name = "txtDeacon2"
        Me.txtDeacon2.Size = New System.Drawing.Size(178, 22)
        Me.txtDeacon2.TabIndex = 60
        Me.txtDeacon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDeacon3
        '
        Me.txtDeacon3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeacon3.Location = New System.Drawing.Point(578, 435)
        Me.txtDeacon3.Name = "txtDeacon3"
        Me.txtDeacon3.Size = New System.Drawing.Size(178, 22)
        Me.txtDeacon3.TabIndex = 61
        Me.txtDeacon3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTreasurer
        '
        Me.txtTreasurer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTreasurer.Location = New System.Drawing.Point(177, 634)
        Me.txtTreasurer.Name = "txtTreasurer"
        Me.txtTreasurer.Size = New System.Drawing.Size(178, 22)
        Me.txtTreasurer.TabIndex = 62
        Me.txtTreasurer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSecretary
        '
        Me.txtSecretary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretary.Location = New System.Drawing.Point(453, 634)
        Me.txtSecretary.Name = "txtSecretary"
        Me.txtSecretary.Size = New System.Drawing.Size(178, 22)
        Me.txtSecretary.TabIndex = 63
        Me.txtSecretary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHostPastor
        '
        Me.btnHostPastor.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnHostPastor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHostPastor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHostPastor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHostPastor.ForeColor = System.Drawing.Color.Transparent
        Me.btnHostPastor.Location = New System.Drawing.Point(345, 237)
        Me.btnHostPastor.Name = "btnHostPastor"
        Me.btnHostPastor.Size = New System.Drawing.Size(45, 22)
        Me.btnHostPastor.TabIndex = 64
        Me.btnHostPastor.Text = "SET"
        Me.btnHostPastor.UseVisualStyleBackColor = False
        '
        'btnElder
        '
        Me.btnElder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnElder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElder.ForeColor = System.Drawing.Color.Transparent
        Me.btnElder.Location = New System.Drawing.Point(617, 237)
        Me.btnElder.Name = "btnElder"
        Me.btnElder.Size = New System.Drawing.Size(45, 22)
        Me.btnElder.TabIndex = 65
        Me.btnElder.Text = "SET"
        Me.btnElder.UseVisualStyleBackColor = False
        '
        'btnDeacon1
        '
        Me.btnDeacon1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeacon1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeacon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeacon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeacon1.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeacon1.Location = New System.Drawing.Point(229, 435)
        Me.btnDeacon1.Name = "btnDeacon1"
        Me.btnDeacon1.Size = New System.Drawing.Size(45, 22)
        Me.btnDeacon1.TabIndex = 66
        Me.btnDeacon1.Text = "SET"
        Me.btnDeacon1.UseVisualStyleBackColor = False
        '
        'btnDeacon2
        '
        Me.btnDeacon2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeacon2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeacon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeacon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeacon2.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeacon2.Location = New System.Drawing.Point(487, 435)
        Me.btnDeacon2.Name = "btnDeacon2"
        Me.btnDeacon2.Size = New System.Drawing.Size(45, 22)
        Me.btnDeacon2.TabIndex = 67
        Me.btnDeacon2.Text = "SET"
        Me.btnDeacon2.UseVisualStyleBackColor = False
        '
        'btnDeacon3
        '
        Me.btnDeacon3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeacon3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeacon3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeacon3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeacon3.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeacon3.Location = New System.Drawing.Point(755, 435)
        Me.btnDeacon3.Name = "btnDeacon3"
        Me.btnDeacon3.Size = New System.Drawing.Size(45, 22)
        Me.btnDeacon3.TabIndex = 68
        Me.btnDeacon3.Text = "SET"
        Me.btnDeacon3.UseVisualStyleBackColor = False
        '
        'btnTreasurer
        '
        Me.btnTreasurer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTreasurer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTreasurer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreasurer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreasurer.ForeColor = System.Drawing.Color.Transparent
        Me.btnTreasurer.Location = New System.Drawing.Point(354, 634)
        Me.btnTreasurer.Name = "btnTreasurer"
        Me.btnTreasurer.Size = New System.Drawing.Size(45, 22)
        Me.btnTreasurer.TabIndex = 69
        Me.btnTreasurer.Text = "SET"
        Me.btnTreasurer.UseVisualStyleBackColor = False
        '
        'btnSecretary
        '
        Me.btnSecretary.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSecretary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecretary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecretary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecretary.ForeColor = System.Drawing.Color.Transparent
        Me.btnSecretary.Location = New System.Drawing.Point(630, 634)
        Me.btnSecretary.Name = "btnSecretary"
        Me.btnSecretary.Size = New System.Drawing.Size(45, 22)
        Me.btnSecretary.TabIndex = 70
        Me.btnSecretary.Text = "SET"
        Me.btnSecretary.UseVisualStyleBackColor = False
        '
        'lblSearchMember
        '
        Me.lblSearchMember.AutoSize = True
        Me.lblSearchMember.BackColor = System.Drawing.Color.White
        Me.lblSearchMember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSearchMember.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMember.ForeColor = System.Drawing.Color.Gray
        Me.lblSearchMember.Location = New System.Drawing.Point(1043, 102)
        Me.lblSearchMember.Name = "lblSearchMember"
        Me.lblSearchMember.Size = New System.Drawing.Size(91, 17)
        Me.lblSearchMember.TabIndex = 74
        Me.lblSearchMember.Text = "Search Member"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1039, 103)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(147, 15)
        Me.txtSearch.TabIndex = 72
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(870, 614)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(322, 49)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(849, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 29)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "List of Members"
        '
        'ptbHostPastor
        '
        Me.ptbHostPastor.BackgroundImage = CType(resources.GetObject("ptbHostPastor.BackgroundImage"), System.Drawing.Image)
        Me.ptbHostPastor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbHostPastor.Location = New System.Drawing.Point(193, 118)
        Me.ptbHostPastor.Name = "ptbHostPastor"
        Me.ptbHostPastor.Size = New System.Drawing.Size(128, 110)
        Me.ptbHostPastor.TabIndex = 78
        Me.ptbHostPastor.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(1001, 98)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 75
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(1023, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(169, 25)
        Me.PictureBox4.TabIndex = 73
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1204, 67)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox2.Location = New System.Drawing.Point(854, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(350, 660)
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'ptbElder
        '
        Me.ptbElder.BackgroundImage = CType(resources.GetObject("ptbElder.BackgroundImage"), System.Drawing.Image)
        Me.ptbElder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbElder.Location = New System.Drawing.Point(469, 118)
        Me.ptbElder.Name = "ptbElder"
        Me.ptbElder.Size = New System.Drawing.Size(128, 110)
        Me.ptbElder.TabIndex = 79
        Me.ptbElder.TabStop = False
        '
        'ptbDeacon1
        '
        Me.ptbDeacon1.BackgroundImage = CType(resources.GetObject("ptbDeacon1.BackgroundImage"), System.Drawing.Image)
        Me.ptbDeacon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbDeacon1.Location = New System.Drawing.Point(78, 315)
        Me.ptbDeacon1.Name = "ptbDeacon1"
        Me.ptbDeacon1.Size = New System.Drawing.Size(128, 110)
        Me.ptbDeacon1.TabIndex = 80
        Me.ptbDeacon1.TabStop = False
        '
        'ptbDeacon2
        '
        Me.ptbDeacon2.BackgroundImage = CType(resources.GetObject("ptbDeacon2.BackgroundImage"), System.Drawing.Image)
        Me.ptbDeacon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbDeacon2.Location = New System.Drawing.Point(337, 315)
        Me.ptbDeacon2.Name = "ptbDeacon2"
        Me.ptbDeacon2.Size = New System.Drawing.Size(128, 110)
        Me.ptbDeacon2.TabIndex = 81
        Me.ptbDeacon2.TabStop = False
        '
        'ptbDeacon3
        '
        Me.ptbDeacon3.BackgroundImage = CType(resources.GetObject("ptbDeacon3.BackgroundImage"), System.Drawing.Image)
        Me.ptbDeacon3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbDeacon3.Location = New System.Drawing.Point(600, 315)
        Me.ptbDeacon3.Name = "ptbDeacon3"
        Me.ptbDeacon3.Size = New System.Drawing.Size(128, 110)
        Me.ptbDeacon3.TabIndex = 82
        Me.ptbDeacon3.TabStop = False
        '
        'ptbTreasurer
        '
        Me.ptbTreasurer.BackgroundImage = CType(resources.GetObject("ptbTreasurer.BackgroundImage"), System.Drawing.Image)
        Me.ptbTreasurer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbTreasurer.Location = New System.Drawing.Point(203, 515)
        Me.ptbTreasurer.Name = "ptbTreasurer"
        Me.ptbTreasurer.Size = New System.Drawing.Size(128, 110)
        Me.ptbTreasurer.TabIndex = 83
        Me.ptbTreasurer.TabStop = False
        '
        'ptbSecretary
        '
        Me.ptbSecretary.BackgroundImage = CType(resources.GetObject("ptbSecretary.BackgroundImage"), System.Drawing.Image)
        Me.ptbSecretary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbSecretary.Location = New System.Drawing.Point(478, 515)
        Me.ptbSecretary.Name = "ptbSecretary"
        Me.ptbSecretary.Size = New System.Drawing.Size(128, 110)
        Me.ptbSecretary.TabIndex = 84
        Me.ptbSecretary.TabStop = False
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(344, 73)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(105, 22)
        Me.txtYear.TabIndex = 85
        Me.txtYear.Text = " "
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lsvPastorList
        '
        Me.lsvPastorList.BackColor = System.Drawing.Color.White
        Me.lsvPastorList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvPastorList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.lsvPastorList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvPastorList.ForeColor = System.Drawing.Color.Black
        Me.lsvPastorList.FullRowSelect = True
        Me.lsvPastorList.Location = New System.Drawing.Point(870, 129)
        Me.lsvPastorList.Name = "lsvPastorList"
        Me.lsvPastorList.Size = New System.Drawing.Size(322, 467)
        Me.lsvPastorList.TabIndex = 86
        Me.lsvPastorList.UseCompatibleStateImageBehavior = False
        Me.lsvPastorList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Pastor Name"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 317
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "imga path"
        Me.ColumnHeader5.Width = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(377, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Year"
        '
        'frmChurchOfficials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1204, 694)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lsvPastorList)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.ptbSecretary)
        Me.Controls.Add(Me.ptbTreasurer)
        Me.Controls.Add(Me.ptbDeacon3)
        Me.Controls.Add(Me.ptbDeacon2)
        Me.Controls.Add(Me.ptbDeacon1)
        Me.Controls.Add(Me.ptbElder)
        Me.Controls.Add(Me.ptbHostPastor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblSearchMember)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lsvMemberInformaion)
        Me.Controls.Add(Me.txtSecretary)
        Me.Controls.Add(Me.txtTreasurer)
        Me.Controls.Add(Me.txtDeacon3)
        Me.Controls.Add(Me.txtDeacon2)
        Me.Controls.Add(Me.txtDeacon1)
        Me.Controls.Add(Me.txtElder)
        Me.Controls.Add(Me.txtHostPastor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDeacon1)
        Me.Controls.Add(Me.btnSecretary)
        Me.Controls.Add(Me.btnTreasurer)
        Me.Controls.Add(Me.btnDeacon3)
        Me.Controls.Add(Me.btnDeacon2)
        Me.Controls.Add(Me.btnElder)
        Me.Controls.Add(Me.btnHostPastor)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Name = "frmChurchOfficials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELDER"
        CType(Me.ptbHostPastor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbElder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbDeacon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbDeacon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbDeacon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTreasurer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSecretary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents lsvMemberInformaion As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtHostPastor As System.Windows.Forms.TextBox
    Friend WithEvents txtElder As System.Windows.Forms.TextBox
    Friend WithEvents txtDeacon1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDeacon2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDeacon3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTreasurer As System.Windows.Forms.TextBox
    Friend WithEvents txtSecretary As System.Windows.Forms.TextBox
    Friend WithEvents btnHostPastor As System.Windows.Forms.Button
    Friend WithEvents btnElder As System.Windows.Forms.Button
    Friend WithEvents btnDeacon1 As System.Windows.Forms.Button
    Friend WithEvents btnDeacon2 As System.Windows.Forms.Button
    Friend WithEvents btnDeacon3 As System.Windows.Forms.Button
    Friend WithEvents btnTreasurer As System.Windows.Forms.Button
    Friend WithEvents btnSecretary As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSearchMember As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ptbHostPastor As System.Windows.Forms.PictureBox
    Friend WithEvents ptbElder As System.Windows.Forms.PictureBox
    Friend WithEvents ptbDeacon1 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbDeacon2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbDeacon3 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbTreasurer As System.Windows.Forms.PictureBox
    Friend WithEvents ptbSecretary As System.Windows.Forms.PictureBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Public WithEvents lsvPastorList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
