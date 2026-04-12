<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_product_Entry
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGeneric = New System.Windows.Forms.TextBox()
        Me.txtClassificationName = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtFormulation = New System.Windows.Forms.TextBox()
        Me.txtReorder = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.lblidBrand = New System.Windows.Forms.Label()
        Me.lblgeneric = New System.Windows.Forms.Label()
        Me.lblclassification = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.lblformulation = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtqnty = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(371, 397)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 31)
        Me.BtnUpdate.TabIndex = 29
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(466, 397)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 31)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btnsave.ForeColor = System.Drawing.Color.White
        Me.Btnsave.Location = New System.Drawing.Point(371, 397)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(89, 31)
        Me.Btnsave.TabIndex = 27
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Product Entry"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(199, 76)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(335, 27)
        Me.txtBarcode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Barcode"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 52)
        Me.Panel1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Brand Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Generic Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Classification Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Formulation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 21)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Re-order level "
        '
        'txtGeneric
        '
        Me.txtGeneric.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneric.Location = New System.Drawing.Point(199, 141)
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.Size = New System.Drawing.Size(335, 27)
        Me.txtGeneric.TabIndex = 3
        '
        'txtClassificationName
        '
        Me.txtClassificationName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassificationName.Location = New System.Drawing.Point(199, 173)
        Me.txtClassificationName.Name = "txtClassificationName"
        Me.txtClassificationName.Size = New System.Drawing.Size(335, 27)
        Me.txtClassificationName.TabIndex = 4
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(199, 205)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(335, 27)
        Me.txtType.TabIndex = 5
        '
        'txtFormulation
        '
        Me.txtFormulation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormulation.Location = New System.Drawing.Point(199, 238)
        Me.txtFormulation.Name = "txtFormulation"
        Me.txtFormulation.Size = New System.Drawing.Size(335, 27)
        Me.txtFormulation.TabIndex = 6
        '
        'txtReorder
        '
        Me.txtReorder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorder.Location = New System.Drawing.Point(199, 270)
        Me.txtReorder.Name = "txtReorder"
        Me.txtReorder.Size = New System.Drawing.Size(335, 27)
        Me.txtReorder.TabIndex = 7
        '
        'txtBrandName
        '
        Me.txtBrandName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandName.Location = New System.Drawing.Point(199, 108)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(335, 27)
        Me.txtBrandName.TabIndex = 2
        '
        'lblidBrand
        '
        Me.lblidBrand.AutoSize = True
        Me.lblidBrand.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidBrand.ForeColor = System.Drawing.Color.Black
        Me.lblidBrand.Location = New System.Drawing.Point(540, 112)
        Me.lblidBrand.Name = "lblidBrand"
        Me.lblidBrand.Size = New System.Drawing.Size(0, 21)
        Me.lblidBrand.TabIndex = 42
        Me.lblidBrand.Visible = False
        '
        'lblgeneric
        '
        Me.lblgeneric.AutoSize = True
        Me.lblgeneric.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgeneric.ForeColor = System.Drawing.Color.Black
        Me.lblgeneric.Location = New System.Drawing.Point(540, 148)
        Me.lblgeneric.Name = "lblgeneric"
        Me.lblgeneric.Size = New System.Drawing.Size(0, 21)
        Me.lblgeneric.TabIndex = 43
        Me.lblgeneric.Visible = False
        '
        'lblclassification
        '
        Me.lblclassification.AutoSize = True
        Me.lblclassification.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclassification.ForeColor = System.Drawing.Color.Black
        Me.lblclassification.Location = New System.Drawing.Point(540, 180)
        Me.lblclassification.Name = "lblclassification"
        Me.lblclassification.Size = New System.Drawing.Size(0, 21)
        Me.lblclassification.TabIndex = 44
        Me.lblclassification.Visible = False
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.ForeColor = System.Drawing.Color.Black
        Me.lbltype.Location = New System.Drawing.Point(540, 207)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(0, 21)
        Me.lbltype.TabIndex = 45
        Me.lbltype.Visible = False
        '
        'lblformulation
        '
        Me.lblformulation.AutoSize = True
        Me.lblformulation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformulation.ForeColor = System.Drawing.Color.Black
        Me.lblformulation.Location = New System.Drawing.Point(540, 240)
        Me.lblformulation.Name = "lblformulation"
        Me.lblformulation.Size = New System.Drawing.Size(0, 21)
        Me.lblformulation.TabIndex = 46
        Me.lblformulation.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 21)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Price"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(199, 304)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(335, 27)
        Me.txtprice.TabIndex = 8
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 338)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 21)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Initial Quantity"
        '
        'txtqnty
        '
        Me.txtqnty.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqnty.Location = New System.Drawing.Point(199, 338)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.Size = New System.Drawing.Size(335, 27)
        Me.txtqnty.TabIndex = 9
        Me.txtqnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frm_product_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(571, 455)
        Me.Controls.Add(Me.txtqnty)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblformulation)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.lblclassification)
        Me.Controls.Add(Me.lblgeneric)
        Me.Controls.Add(Me.lblidBrand)
        Me.Controls.Add(Me.txtReorder)
        Me.Controls.Add(Me.txtFormulation)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtClassificationName)
        Me.Controls.Add(Me.txtGeneric)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_product_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_product_Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGeneric As System.Windows.Forms.TextBox
    Friend WithEvents txtClassificationName As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtFormulation As System.Windows.Forms.TextBox
    Friend WithEvents txtReorder As System.Windows.Forms.TextBox
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents lblidBrand As System.Windows.Forms.Label
    Friend WithEvents lblgeneric As System.Windows.Forms.Label
    Friend WithEvents lblclassification As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents lblformulation As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
End Class
