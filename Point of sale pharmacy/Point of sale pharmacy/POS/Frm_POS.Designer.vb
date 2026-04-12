<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_POS
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_POS))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvproduct = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columDelUpd = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtVat = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblinvoiceNum = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbldue = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbldisplayotal = New System.Windows.Forms.Label()
        Me.BtnDailySales = New System.Windows.Forms.Button()
        Me.btnSettle = New System.Windows.Forms.Button()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.btnNewtransac = New System.Windows.Forms.Button()
        Me.btnProd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.dgvproduct)
        Me.Panel2.Location = New System.Drawing.Point(3, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(966, 658)
        Me.Panel2.TabIndex = 1
        '
        'dgvproduct
        '
        Me.dgvproduct.AllowUserToAddRows = False
        Me.dgvproduct.AllowUserToDeleteRows = False
        Me.dgvproduct.AllowUserToResizeColumns = False
        Me.dgvproduct.AllowUserToResizeRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvproduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvproduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvproduct.BackgroundColor = System.Drawing.Color.White
        Me.dgvproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvproduct.ColumnHeadersHeight = 37
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvproduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column7, Me.Column10, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column11, Me.Qty, Me.Column9, Me.columDelUpd})
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle31.Padding = New System.Windows.Forms.Padding(1, 1, 1, 2)
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproduct.DefaultCellStyle = DataGridViewCellStyle31
        Me.dgvproduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvproduct.EnableHeadersVisualStyles = False
        Me.dgvproduct.Location = New System.Drawing.Point(0, 0)
        Me.dgvproduct.MultiSelect = False
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.ReadOnly = True
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproduct.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dgvproduct.RowHeadersVisible = False
        Me.dgvproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproduct.Size = New System.Drawing.Size(966, 658)
        Me.dgvproduct.TabIndex = 3055
        '
        'Column8
        '
        Me.Column8.HeaderText = "#"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 25
        '
        'Column7
        '
        Me.Column7.HeaderText = "cartID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "prodID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.DataPropertyName = "Invoice"
        Me.Column1.HeaderText = "Invoice  No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 115
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "brand"
        Me.Column2.HeaderText = "Brand Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.DataPropertyName = "generic"
        Me.Column3.HeaderText = "Generic Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.DataPropertyName = "classification"
        Me.Column4.HeaderText = "Classification"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 110
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.DataPropertyName = "type"
        Me.Column5.HeaderText = "Type"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 110
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.DataPropertyName = "formulation"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle27
        Me.Column6.HeaderText = "Formulation"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 95
        '
        'Column11
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N2"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle28
        Me.Column11.HeaderText = "Price"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Qty
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle29
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Qty.Width = 75
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.DataPropertyName = "total"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "N2"
        DataGridViewCellStyle30.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle30
        Me.Column9.HeaderText = "Total"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column9.Width = 75
        '
        'columDelUpd
        '
        Me.columDelUpd.HeaderText = ""
        Me.columDelUpd.Image = CType(resources.GetObject("columDelUpd.Image"), System.Drawing.Image)
        Me.columDelUpd.Name = "columDelUpd"
        Me.columDelUpd.ReadOnly = True
        Me.columDelUpd.Width = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtVat)
        Me.Panel3.Controls.Add(Me.lblid)
        Me.Panel3.Controls.Add(Me.lbltotal)
        Me.Panel3.Controls.Add(Me.lblinvoiceNum)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 35)
        Me.Panel3.TabIndex = 2
        '
        'txtVat
        '
        Me.txtVat.AutoSize = True
        Me.txtVat.Location = New System.Drawing.Point(790, 12)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(39, 13)
        Me.txtVat.TabIndex = 3062
        Me.txtVat.Text = "Label1"
        Me.txtVat.Visible = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(410, 12)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 13)
        Me.lblid.TabIndex = 3061
        Me.lblid.Visible = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(353, 11)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(39, 13)
        Me.lbltotal.TabIndex = 3060
        Me.lbltotal.Text = "Label1"
        Me.lbltotal.Visible = False
        '
        'lblinvoiceNum
        '
        Me.lblinvoiceNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblinvoiceNum.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblinvoiceNum.ForeColor = System.Drawing.Color.White
        Me.lblinvoiceNum.Location = New System.Drawing.Point(9, 5)
        Me.lblinvoiceNum.Name = "lblinvoiceNum"
        Me.lblinvoiceNum.Size = New System.Drawing.Size(230, 25)
        Me.lblinvoiceNum.TabIndex = 3059
        Me.lblinvoiceNum.Text = "00000000000"
        Me.lblinvoiceNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(140, 47)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(373, 27)
        Me.txtBarcode.TabIndex = 31
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel7.Location = New System.Drawing.Point(519, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(41, 30)
        Me.Panel7.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.lbldue)
        Me.Panel4.Controls.Add(Me.lblVat)
        Me.Panel4.Controls.Add(Me.lblSub)
        Me.Panel4.Controls.Add(Me.lblDisc)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.l)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.BtnDailySales)
        Me.Panel4.Controls.Add(Me.btnSettle)
        Me.Panel4.Controls.Add(Me.btnDiscount)
        Me.Panel4.Controls.Add(Me.btnNewtransac)
        Me.Panel4.Controls.Add(Me.btnProd)
        Me.Panel4.Location = New System.Drawing.Point(975, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(388, 743)
        Me.Panel4.TabIndex = 3057
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(3, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(382, 48)
        Me.btnClose.TabIndex = 3060
        Me.btnClose.Text = "  ( Esc ) Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbldue
        '
        Me.lbldue.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lbldue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.lbldue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldue.Location = New System.Drawing.Point(150, 557)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(225, 36)
        Me.lbldue.TabIndex = 3058
        Me.lbldue.Text = "0.00"
        Me.lbldue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVat
        '
        Me.lblVat.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.lblVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVat.Location = New System.Drawing.Point(150, 506)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(225, 36)
        Me.lblVat.TabIndex = 3059
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSub
        '
        Me.lblSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSub.Location = New System.Drawing.Point(150, 404)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(225, 36)
        Me.lblSub.TabIndex = 3057
        Me.lblSub.Text = "0.00"
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDisc
        '
        Me.lblDisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.lblDisc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDisc.Location = New System.Drawing.Point(150, 455)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(225, 36)
        Me.lblDisc.TabIndex = 3056
        Me.lblDisc.Text = "0.00"
        Me.lblDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblTime)
        Me.Panel5.Controls.Add(Me.lbldate)
        Me.Panel5.Location = New System.Drawing.Point(3, 602)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(382, 131)
        Me.Panel5.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(0, 46)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(382, 85)
        Me.lblTime.TabIndex = 52
        Me.lblTime.Text = "00 : 00 : 00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lbldate.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbldate.Location = New System.Drawing.Point(0, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(382, 46)
        Me.lbldate.TabIndex = 51
        Me.lbldate.Text = "Today is"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l
        '
        Me.l.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.l.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.ForeColor = System.Drawing.Color.MidnightBlue
        Me.l.Location = New System.Drawing.Point(3, 551)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(382, 48)
        Me.l.TabIndex = 46
        Me.l.Text = " Total Due"
        Me.l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(3, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 48)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = " Vat Table"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(3, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 48)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = " Sub - Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(3, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Disc."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lbldisplayotal)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(382, 79)
        Me.Panel6.TabIndex = 38
        '
        'lbldisplayotal
        '
        Me.lbldisplayotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldisplayotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbldisplayotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, System.Drawing.FontStyle.Bold)
        Me.lbldisplayotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldisplayotal.Location = New System.Drawing.Point(0, 0)
        Me.lbldisplayotal.Name = "lbldisplayotal"
        Me.lbldisplayotal.Size = New System.Drawing.Size(382, 79)
        Me.lbldisplayotal.TabIndex = 3058
        Me.lbldisplayotal.Text = "0.00"
        Me.lbldisplayotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnDailySales
        '
        Me.BtnDailySales.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnDailySales.FlatAppearance.BorderSize = 0
        Me.BtnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDailySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDailySales.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDailySales.Image = CType(resources.GetObject("BtnDailySales.Image"), System.Drawing.Image)
        Me.BtnDailySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDailySales.Location = New System.Drawing.Point(3, 296)
        Me.BtnDailySales.Name = "BtnDailySales"
        Me.BtnDailySales.Size = New System.Drawing.Size(382, 48)
        Me.BtnDailySales.TabIndex = 37
        Me.BtnDailySales.Text = "  ( F5 ) Daily Sales "
        Me.BtnDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDailySales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDailySales.UseVisualStyleBackColor = False
        '
        'btnSettle
        '
        Me.btnSettle.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnSettle.FlatAppearance.BorderSize = 0
        Me.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSettle.Image = CType(resources.GetObject("btnSettle.Image"), System.Drawing.Image)
        Me.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettle.Location = New System.Drawing.Point(3, 245)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.Size = New System.Drawing.Size(382, 48)
        Me.btnSettle.TabIndex = 36
        Me.btnSettle.Text = "  ( F4 ) Settle"
        Me.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettle.UseVisualStyleBackColor = False
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnDiscount.FlatAppearance.BorderSize = 0
        Me.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDiscount.Image = CType(resources.GetObject("btnDiscount.Image"), System.Drawing.Image)
        Me.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.Location = New System.Drawing.Point(3, 194)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(382, 48)
        Me.btnDiscount.TabIndex = 35
        Me.btnDiscount.Text = "  ( F3 ) Add Discount"
        Me.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiscount.UseVisualStyleBackColor = False
        '
        'btnNewtransac
        '
        Me.btnNewtransac.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnNewtransac.FlatAppearance.BorderSize = 0
        Me.btnNewtransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewtransac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewtransac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNewtransac.Image = CType(resources.GetObject("btnNewtransac.Image"), System.Drawing.Image)
        Me.btnNewtransac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewtransac.Location = New System.Drawing.Point(3, 92)
        Me.btnNewtransac.Name = "btnNewtransac"
        Me.btnNewtransac.Size = New System.Drawing.Size(382, 48)
        Me.btnNewtransac.TabIndex = 34
        Me.btnNewtransac.Text = "  ( F1 ) New Transaction "
        Me.btnNewtransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewtransac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewtransac.UseVisualStyleBackColor = False
        '
        'btnProd
        '
        Me.btnProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnProd.FlatAppearance.BorderSize = 0
        Me.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProd.Image = CType(resources.GetObject("btnProd.Image"), System.Drawing.Image)
        Me.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProd.Location = New System.Drawing.Point(3, 143)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(382, 48)
        Me.btnProd.TabIndex = 31
        Me.btnProd.Text = "  ( F2 ) Product Inquiry "
        Me.btnProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProd.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(9, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 21)
        Me.Label13.TabIndex = 3058
        Me.Label13.Text = "Scan Barcode"
        '
        'Timer1
        '
        '
        'Frm_POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents dgvproduct As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbldue As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblDisc As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lbldisplayotal As System.Windows.Forms.Label
    Friend WithEvents BtnDailySales As System.Windows.Forms.Button
    Friend WithEvents btnSettle As System.Windows.Forms.Button
    Friend WithEvents btnDiscount As System.Windows.Forms.Button
    Friend WithEvents btnNewtransac As System.Windows.Forms.Button
    Friend WithEvents btnProd As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblinvoiceNum As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtVat As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columDelUpd As System.Windows.Forms.DataGridViewImageColumn
End Class
