<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCreateIncident = New System.Windows.Forms.TabPage()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbMainQuery = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHistory = New System.Windows.Forms.PictureBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbInitiator = New System.Windows.Forms.TextBox()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tbRemarks = New System.Windows.Forms.RichTextBox()
        Me.tbAging = New System.Windows.Forms.TextBox()
        Me.dtClosetime = New System.Windows.Forms.DateTimePicker()
        Me.cmbClosedBy = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbRecivedFrom = New System.Windows.Forms.ComboBox()
        Me.cmbquery = New System.Windows.Forms.ComboBox()
        Me.cmbComplainMode = New System.Windows.Forms.ComboBox()
        Me.dtStartDatetime = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabSearchIncident = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbAging = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.cmbSClosedBy = New System.Windows.Forms.ComboBox()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbSComplainMode = New System.Windows.Forms.ComboBox()
        Me.cmbSRecivedFrom = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbSStaus = New System.Windows.Forms.ComboBox()
        Me.cmbSQueryType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabCreateIncident.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearchIncident.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 605)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(726, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(500, 17)
        Me.ToolStripStatusLabel1.Text = "                                                             @2016 Multinet Pakis" & _
            "tan Private Limted.All Right Reserved "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(121, 15)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "WELCOME TO INCIDENT DESK"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCreateIncident)
        Me.TabControl1.Controls.Add(Me.tabSearchIncident)
        Me.TabControl1.Location = New System.Drawing.Point(17, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(688, 534)
        Me.TabControl1.TabIndex = 4
        '
        'tabCreateIncident
        '
        Me.tabCreateIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabCreateIncident.Controls.Add(Me.Label31)
        Me.tabCreateIncident.Controls.Add(Me.cmbMainQuery)
        Me.tabCreateIncident.Controls.Add(Me.Label32)
        Me.tabCreateIncident.Controls.Add(Me.PictureBox1)
        Me.tabCreateIncident.Controls.Add(Me.btnHistory)
        Me.tabCreateIncident.Controls.Add(Me.lbl2)
        Me.tabCreateIncident.Controls.Add(Me.lbl1)
        Me.tabCreateIncident.Controls.Add(Me.Label30)
        Me.tabCreateIncident.Controls.Add(Me.Label29)
        Me.tabCreateIncident.Controls.Add(Me.Label28)
        Me.tabCreateIncident.Controls.Add(Me.Label27)
        Me.tabCreateIncident.Controls.Add(Me.Label25)
        Me.tabCreateIncident.Controls.Add(Me.Label22)
        Me.tabCreateIncident.Controls.Add(Me.btnUpdate)
        Me.tabCreateIncident.Controls.Add(Me.Label19)
        Me.tabCreateIncident.Controls.Add(Me.tbInitiator)
        Me.tabCreateIncident.Controls.Add(Me.tbCategory)
        Me.tabCreateIncident.Controls.Add(Me.btnClear)
        Me.tabCreateIncident.Controls.Add(Me.btnSubmit)
        Me.tabCreateIncident.Controls.Add(Me.tbRemarks)
        Me.tabCreateIncident.Controls.Add(Me.tbAging)
        Me.tabCreateIncident.Controls.Add(Me.dtClosetime)
        Me.tabCreateIncident.Controls.Add(Me.cmbClosedBy)
        Me.tabCreateIncident.Controls.Add(Me.cmbStatus)
        Me.tabCreateIncident.Controls.Add(Me.cmbRecivedFrom)
        Me.tabCreateIncident.Controls.Add(Me.cmbquery)
        Me.tabCreateIncident.Controls.Add(Me.cmbComplainMode)
        Me.tabCreateIncident.Controls.Add(Me.dtStartDatetime)
        Me.tabCreateIncident.Controls.Add(Me.Label12)
        Me.tabCreateIncident.Controls.Add(Me.Label11)
        Me.tabCreateIncident.Controls.Add(Me.Label10)
        Me.tabCreateIncident.Controls.Add(Me.Label9)
        Me.tabCreateIncident.Controls.Add(Me.Label8)
        Me.tabCreateIncident.Controls.Add(Me.Label7)
        Me.tabCreateIncident.Controls.Add(Me.Label6)
        Me.tabCreateIncident.Controls.Add(Me.Label5)
        Me.tabCreateIncident.Controls.Add(Me.Label4)
        Me.tabCreateIncident.Controls.Add(Me.Label3)
        Me.tabCreateIncident.Controls.Add(Me.Label2)
        Me.tabCreateIncident.Controls.Add(Me.Label13)
        Me.tabCreateIncident.Location = New System.Drawing.Point(4, 24)
        Me.tabCreateIncident.Name = "tabCreateIncident"
        Me.tabCreateIncident.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCreateIncident.Size = New System.Drawing.Size(680, 506)
        Me.tabCreateIncident.TabIndex = 1
        Me.tabCreateIncident.Text = "Create Incident"
        Me.tabCreateIncident.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(36, 121)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 15)
        Me.Label31.TabIndex = 4800139
        Me.Label31.Text = "*"
        '
        'cmbMainQuery
        '
        Me.cmbMainQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainQuery.FormattingEnabled = True
        Me.cmbMainQuery.Location = New System.Drawing.Point(168, 118)
        Me.cmbMainQuery.Name = "cmbMainQuery"
        Me.cmbMainQuery.Size = New System.Drawing.Size(177, 23)
        Me.cmbMainQuery.TabIndex = 4800138
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(55, 121)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 15)
        Me.Label32.TabIndex = 4800137
        Me.Label32.Text = "Query"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ISR_Application.My.Resources.Resources.Lense
        Me.PictureBox1.Location = New System.Drawing.Point(628, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnHistory
        '
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.Image = Global.ISR_Application.My.Resources.Resources.Stdu_viewer_icon
        Me.btnHistory.Location = New System.Drawing.Point(533, 328)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(26, 27)
        Me.btnHistory.TabIndex = 4800136
        Me.btnHistory.TabStop = False
        Me.btnHistory.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(467, 153)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 15)
        Me.lbl2.TabIndex = 4800135
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(351, 153)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(109, 15)
        Me.lbl1.TabIndex = 4800134
        Me.lbl1.Text = "Transaction By :"
        Me.lbl1.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(36, 279)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 15)
        Me.Label30.TabIndex = 4800133
        Me.Label30.Text = "*"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(36, 212)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 15)
        Me.Label29.TabIndex = 4800132
        Me.Label29.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(36, 180)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 15)
        Me.Label28.TabIndex = 4800131
        Me.Label28.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(36, 153)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 15)
        Me.Label27.TabIndex = 4800130
        Me.Label27.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(36, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 15)
        Me.Label25.TabIndex = 4800129
        Me.Label25.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(36, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 15)
        Me.Label22.TabIndex = 4800128
        Me.Label22.Text = "*"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.BackgroundImage = Global.ISR_Application.My.Resources.Resources.newbottom
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnUpdate.FlatAppearance.BorderSize = 5
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(312, 388)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4800127
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Navy
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Image = Global.ISR_Application.My.Resources.Resources.border_navy_dw
        Me.Label19.Location = New System.Drawing.Point(-3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label19.Size = New System.Drawing.Size(681, 16)
        Me.Label19.TabIndex = 4800126
        Me.Label19.Text = "Insert Incident" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbInitiator
        '
        Me.tbInitiator.Location = New System.Drawing.Point(168, 245)
        Me.tbInitiator.Name = "tbInitiator"
        Me.tbInitiator.Size = New System.Drawing.Size(177, 21)
        Me.tbInitiator.TabIndex = 49
        '
        'tbCategory
        '
        Me.tbCategory.Location = New System.Drawing.Point(168, 180)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(177, 21)
        Me.tbCategory.TabIndex = 47
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.ISR_Application.My.Resources.Resources.newbottom
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnClear.FlatAppearance.BorderSize = 5
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(393, 388)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 56
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSubmit.BackgroundImage = Global.ISR_Application.My.Resources.Resources.newbottom
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSubmit.FlatAppearance.BorderSize = 5
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(231, 388)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 55
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'tbRemarks
        '
        Me.tbRemarks.Location = New System.Drawing.Point(168, 318)
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(359, 55)
        Me.tbRemarks.TabIndex = 54
        Me.tbRemarks.Text = ""
        '
        'tbAging
        '
        Me.tbAging.Location = New System.Drawing.Point(467, 119)
        Me.tbAging.Name = "tbAging"
        Me.tbAging.ReadOnly = True
        Me.tbAging.Size = New System.Drawing.Size(155, 21)
        Me.tbAging.TabIndex = 53
        '
        'dtClosetime
        '
        Me.dtClosetime.CustomFormat = "MM/dd/yyyy    hh:mm:ss tt"
        Me.dtClosetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtClosetime.Location = New System.Drawing.Point(467, 59)
        Me.dtClosetime.Name = "dtClosetime"
        Me.dtClosetime.Size = New System.Drawing.Size(183, 21)
        Me.dtClosetime.TabIndex = 52
        '
        'cmbClosedBy
        '
        Me.cmbClosedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClosedBy.FormattingEnabled = True
        Me.cmbClosedBy.Location = New System.Drawing.Point(467, 89)
        Me.cmbClosedBy.Name = "cmbClosedBy"
        Me.cmbClosedBy.Size = New System.Drawing.Size(183, 23)
        Me.cmbClosedBy.TabIndex = 51
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(168, 276)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(177, 23)
        Me.cmbStatus.TabIndex = 50
        '
        'cmbRecivedFrom
        '
        Me.cmbRecivedFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecivedFrom.FormattingEnabled = True
        Me.cmbRecivedFrom.Location = New System.Drawing.Point(168, 209)
        Me.cmbRecivedFrom.Name = "cmbRecivedFrom"
        Me.cmbRecivedFrom.Size = New System.Drawing.Size(177, 23)
        Me.cmbRecivedFrom.TabIndex = 48
        '
        'cmbquery
        '
        Me.cmbquery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbquery.FormattingEnabled = True
        Me.cmbquery.Location = New System.Drawing.Point(168, 149)
        Me.cmbquery.Name = "cmbquery"
        Me.cmbquery.Size = New System.Drawing.Size(177, 23)
        Me.cmbquery.TabIndex = 46
        '
        'cmbComplainMode
        '
        Me.cmbComplainMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComplainMode.FormattingEnabled = True
        Me.cmbComplainMode.Location = New System.Drawing.Point(168, 89)
        Me.cmbComplainMode.Name = "cmbComplainMode"
        Me.cmbComplainMode.Size = New System.Drawing.Size(177, 23)
        Me.cmbComplainMode.TabIndex = 45
        '
        'dtStartDatetime
        '
        Me.dtStartDatetime.CustomFormat = "MM/dd/yyyy    hh:mm:ss tt"
        Me.dtStartDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStartDatetime.Location = New System.Drawing.Point(168, 59)
        Me.dtStartDatetime.Name = "dtStartDatetime"
        Me.dtStartDatetime.Size = New System.Drawing.Size(177, 21)
        Me.dtStartDatetime.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Remarks"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(351, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 15)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Aging"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(351, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 15)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Close Date/Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Closed By"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Received From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Initiator"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Sub Query"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Complaint Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Start Date/Time"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(274, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 18)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "IP INCIDENT LOG"
        '
        'tabSearchIncident
        '
        Me.tabSearchIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabSearchIncident.Controls.Add(Me.Label34)
        Me.tabSearchIncident.Controls.Add(Me.dtTo)
        Me.tabSearchIncident.Controls.Add(Me.dtFrom)
        Me.tabSearchIncident.Controls.Add(Me.Label33)
        Me.tabSearchIncident.Controls.Add(Me.lblCount)
        Me.tabSearchIncident.Controls.Add(Me.Label26)
        Me.tabSearchIncident.Controls.Add(Me.Label24)
        Me.tabSearchIncident.Controls.Add(Me.cmbAging)
        Me.tabSearchIncident.Controls.Add(Me.ToolStrip1)
        Me.tabSearchIncident.Controls.Add(Me.cmbSClosedBy)
        Me.tabSearchIncident.Controls.Add(Me.dgView)
        Me.tabSearchIncident.Controls.Add(Me.Label20)
        Me.tabSearchIncident.Controls.Add(Me.Label23)
        Me.tabSearchIncident.Controls.Add(Me.cmbSComplainMode)
        Me.tabSearchIncident.Controls.Add(Me.cmbSRecivedFrom)
        Me.tabSearchIncident.Controls.Add(Me.Label17)
        Me.tabSearchIncident.Controls.Add(Me.Label18)
        Me.tabSearchIncident.Controls.Add(Me.Label16)
        Me.tabSearchIncident.Controls.Add(Me.cmbSStaus)
        Me.tabSearchIncident.Controls.Add(Me.cmbSQueryType)
        Me.tabSearchIncident.Controls.Add(Me.Label14)
        Me.tabSearchIncident.Controls.Add(Me.Label15)
        Me.tabSearchIncident.Location = New System.Drawing.Point(4, 24)
        Me.tabSearchIncident.Name = "tabSearchIncident"
        Me.tabSearchIncident.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearchIncident.Size = New System.Drawing.Size(680, 506)
        Me.tabSearchIncident.TabIndex = 2
        Me.tabSearchIncident.Text = "Search Incident"
        Me.tabSearchIncident.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(252, 111)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(25, 15)
        Me.Label34.TabIndex = 4800142
        Me.Label34.Text = "TO"
        '
        'dtTo
        '
        Me.dtTo.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtTo.CalendarMonthBackground = System.Drawing.SystemColors.ControlText
        Me.dtTo.CustomFormat = "MM/dd/yyy"
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(301, 108)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(120, 21)
        Me.dtTo.TabIndex = 4800141
        Me.dtTo.TabStop = False
        Me.dtTo.UseWaitCursor = True
        Me.dtTo.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtFrom
        '
        Me.dtFrom.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtFrom.CalendarMonthBackground = System.Drawing.SystemColors.ControlText
        Me.dtFrom.CustomFormat = "MM/dd/yyy"
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(125, 110)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(120, 21)
        Me.dtFrom.TabIndex = 4800140
        Me.dtFrom.TabStop = False
        Me.dtFrom.UseWaitCursor = True
        Me.dtFrom.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(10, 112)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(101, 15)
        Me.Label33.TabIndex = 4800139
        Me.Label33.Text = "Date Selection"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(168, 170)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 15)
        Me.lblCount.TabIndex = 4800138
        Me.lblCount.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 170)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(152, 15)
        Me.Label26.TabIndex = 4800137
        Me.Label26.Text = "Total Records Found : "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(430, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 15)
        Me.Label24.TabIndex = 4800134
        Me.Label24.Text = "Aging"
        Me.Label24.Visible = False
        '
        'cmbAging
        '
        Me.cmbAging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAging.FormattingEnabled = True
        Me.cmbAging.Items.AddRange(New Object() {"Please-Select", "Less then 1 Hour", "Greater then 1 Hour", "Greater then 4 Hour"})
        Me.cmbAging.Location = New System.Drawing.Point(506, 82)
        Me.cmbAging.Name = "cmbAging"
        Me.cmbAging.Size = New System.Drawing.Size(120, 23)
        Me.cmbAging.TabIndex = 4800133
        Me.cmbAging.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripButton, Me.ReportToolStripButton, Me.ClearToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(672, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 4800130
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.Image = Global.ISR_Application.My.Resources.Resources.Lookup
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.SearchToolStripButton.Text = "&Search"
        '
        'ReportToolStripButton
        '
        Me.ReportToolStripButton.Image = Global.ISR_Application.My.Resources.Resources.export_icon
        Me.ReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReportToolStripButton.Name = "ReportToolStripButton"
        Me.ReportToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.ReportToolStripButton.Text = "&Excel"
        '
        'ClearToolStripButton
        '
        Me.ClearToolStripButton.Image = CType(resources.GetObject("ClearToolStripButton.Image"), System.Drawing.Image)
        Me.ClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearToolStripButton.Name = "ClearToolStripButton"
        Me.ClearToolStripButton.Size = New System.Drawing.Size(54, 22)
        Me.ClearToolStripButton.Text = "C&lear"
        '
        'cmbSClosedBy
        '
        Me.cmbSClosedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSClosedBy.FormattingEnabled = True
        Me.cmbSClosedBy.Location = New System.Drawing.Point(506, 50)
        Me.cmbSClosedBy.Name = "cmbSClosedBy"
        Me.cmbSClosedBy.Size = New System.Drawing.Size(120, 23)
        Me.cmbSClosedBy.TabIndex = 4800129
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEdit})
        Me.dgView.Location = New System.Drawing.Point(6, 193)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(659, 291)
        Me.dgView.TabIndex = 4800128
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.Image = Global.ISR_Application.My.Resources.Resources.E_
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Visible = False
        Me.colEdit.Width = 50
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Navy
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(0, 144)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label20.Size = New System.Drawing.Size(681, 16)
        Me.Label20.TabIndex = 4800127
        Me.Label20.Text = "Incident Log"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.Color.Navy
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(-4, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label23.Size = New System.Drawing.Size(681, 16)
        Me.Label23.TabIndex = 4800126
        Me.Label23.Text = "Searching Filter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSComplainMode
        '
        Me.cmbSComplainMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSComplainMode.FormattingEnabled = True
        Me.cmbSComplainMode.Location = New System.Drawing.Point(125, 79)
        Me.cmbSComplainMode.Name = "cmbSComplainMode"
        Me.cmbSComplainMode.Size = New System.Drawing.Size(120, 23)
        Me.cmbSComplainMode.TabIndex = 56
        '
        'cmbSRecivedFrom
        '
        Me.cmbSRecivedFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSRecivedFrom.FormattingEnabled = True
        Me.cmbSRecivedFrom.Location = New System.Drawing.Point(125, 50)
        Me.cmbSRecivedFrom.Name = "cmbSRecivedFrom"
        Me.cmbSRecivedFrom.Size = New System.Drawing.Size(120, 23)
        Me.cmbSRecivedFrom.TabIndex = 55
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(251, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 15)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Status"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 15)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Received From"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(430, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 15)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Closed By"
        '
        'cmbSStaus
        '
        Me.cmbSStaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSStaus.FormattingEnabled = True
        Me.cmbSStaus.Location = New System.Drawing.Point(301, 79)
        Me.cmbSStaus.Name = "cmbSStaus"
        Me.cmbSStaus.Size = New System.Drawing.Size(120, 23)
        Me.cmbSStaus.TabIndex = 50
        '
        'cmbSQueryType
        '
        Me.cmbSQueryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSQueryType.FormattingEnabled = True
        Me.cmbSQueryType.Location = New System.Drawing.Point(301, 50)
        Me.cmbSQueryType.Name = "cmbSQueryType"
        Me.cmbSQueryType.Size = New System.Drawing.Size(120, 23)
        Me.cmbSQueryType.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(251, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Query"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 15)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Complaint Mode"
        '
        'btnLogOut
        '
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.Location = New System.Drawing.Point(654, 23)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(22, 21)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(586, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "LOG OUT"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(726, 627)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incident Service Report"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabCreateIncident.ResumeLayout(False)
        Me.tabCreateIncident.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearchIncident.ResumeLayout(False)
        Me.tabSearchIncident.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSearchIncident As System.Windows.Forms.TabPage
    Friend WithEvents tabCreateIncident As System.Windows.Forms.TabPage
    Friend WithEvents btnLogOut As System.Windows.Forms.PictureBox
    Friend WithEvents tbInitiator As System.Windows.Forms.TextBox
    Friend WithEvents tbCategory As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents tbRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents tbAging As System.Windows.Forms.TextBox
    Friend WithEvents dtClosetime As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbClosedBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRecivedFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbquery As System.Windows.Forms.ComboBox
    Friend WithEvents cmbComplainMode As System.Windows.Forms.ComboBox
    Friend WithEvents dtStartDatetime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbSComplainMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSRecivedFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbSStaus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSQueryType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgView As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbSClosedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbAging As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClearToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ReportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnHistory As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbMainQuery As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
End Class
