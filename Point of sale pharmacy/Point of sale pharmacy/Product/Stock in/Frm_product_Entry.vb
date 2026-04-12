Imports MySql.Data.MySqlClient
Public Class Frm_product_Entry

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbYesNo + vbQuestion, "Cancel") = vbYes Then
            Me.Dispose()

        End If
    End Sub
    Sub loadbrandName()
        Try
            Call connect()
            Dim cmd As MySqlCommand
            Dim dt As New DataTable
            cmd = New MySqlCommand("select * from tbl_brand order by brand ", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                col.Add(dt.Rows(i)(1).ToString)
            Next
            txtBrandName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBrandName.AutoCompleteCustomSource = col
            txtBrandName.AutoCompleteMode = AutoCompleteMode.Suggest
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub txtBrandName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrandName.TextChanged
        nobrand()

    End Sub
    Private Function nobrand() As Boolean
        Try

            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_brand where brand = '" & txtBrandName.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then
                lblidBrand.Text = dt.Rows(0)(0).ToString
                nobrand = True
            Else
                lblidBrand.Text = Nothing
                nobrand = False

            End If
        Catch ex As Exception

        End Try
    End Function


    Private Sub Frm_product_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
        loadbrandName()
        loadgeneric()
        loadclassification()
        loadtype()
        loadformulation()
    End Sub



    Sub loadgeneric()
        Try
            Call connect()
            Dim cmd As MySqlCommand
            Dim dt As New DataTable
            cmd = New MySqlCommand("select * from tbl_generic order by generic ", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                col.Add(dt.Rows(i)(1).ToString)
            Next
            
            txtGeneric.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtGeneric.AutoCompleteCustomSource = col
            txtGeneric.AutoCompleteMode = AutoCompleteMode.Suggest

            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub



    Private Sub txtGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGeneric.TextChanged
        nogeneric()
    End Sub

    Private Function nogeneric() As Boolean
        Try

            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_generic where generic = '" & txtGeneric.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then
                lblgeneric.Text = dt.Rows(0)(0).ToString
                nogeneric = True
            Else
                lblgeneric.Text = Nothing
                nogeneric = False

            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub txtClassificationName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClassificationName.TextChanged
        noclassification()

    End Sub


    Private Function noclassification() As Boolean
        Try

            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_classification where classification = '" & txtClassificationName.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then
                lblclassification.Text = dt.Rows(0)(0).ToString
                noclassification = True
            Else
                lblclassification.Text = Nothing
                noclassification = False

            End If
        Catch ex As Exception

        End Try
    End Function
    Sub loadclassification()
        Try
            Call connect()
            Dim cmd As MySqlCommand
            Dim dt As New DataTable
            cmd = New MySqlCommand("select * from tbl_classification order by classification ", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                col.Add(dt.Rows(i)(1).ToString)
            Next

            txtClassificationName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtClassificationName.AutoCompleteCustomSource = col
            txtClassificationName.AutoCompleteMode = AutoCompleteMode.Suggest

            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub loadtype()
        Try
            Call connect()
            Dim cmd As MySqlCommand
            Dim dt As New DataTable
            cmd = New MySqlCommand("select * from tbl_type order by type", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                col.Add(dt.Rows(i)(1).ToString)
            Next

            txtType.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtType.AutoCompleteCustomSource = col
            txtType.AutoCompleteMode = AutoCompleteMode.Suggest

            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Function noType() As Boolean
        Try

            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_type where type = '" & txtType.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then
                lbltype.Text = dt.Rows(0)(0).ToString
                noType = True
            Else
                lbltype.Text = Nothing
                noType = False

            End If
        Catch ex As Exception

        End Try
    End Function

    Sub loadformulation()
        Try
            Call connect()
            Dim cmd As MySqlCommand
            Dim dt As New DataTable
            cmd = New MySqlCommand("select * from tbl_formulation order by formulation", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                col.Add(dt.Rows(i)(1).ToString)
            Next

            txtFormulation.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtFormulation.AutoCompleteCustomSource = col
            txtFormulation.AutoCompleteMode = AutoCompleteMode.Suggest

            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Function noformulation() As Boolean
        Try

            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_formulation where formulation = '" & txtFormulation.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then
                lblformulation.Text = dt.Rows(0)(0).ToString
                noformulation = True
            Else
                lblformulation.Text = Nothing
                noformulation = False

            End If
        Catch ex As Exception

        End Try
    End Function
    Private Sub txtType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtType.TextChanged
        noType()
    End Sub

    Private Sub txtFormulation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFormulation.TextChanged
        noformulation()
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try
            If lblidBrand.Text = "" Then
                MsgBox("Select Again ", vbCritical, "BRAND")
                txtBrandName.Text = ""
                txtBrandName.Focus()
            ElseIf lblgeneric.Text = "" Then
                MsgBox("Select Again ", vbCritical, "GENERIC")
                txtGeneric.Text = ""
                txtGeneric.Focus()
            ElseIf lblgeneric.Text = "" Then
                MsgBox("Select Again ", vbCritical, "GENERIC")
                txtGeneric.Text = ""
                txtGeneric.Focus()
            ElseIf lblclassification.Text = "" Then
                MsgBox("Select Again ", vbCritical, "CLASSIFICATION")
                txtClassificationName.Text = ""
                txtClassificationName.Focus()
            ElseIf lbltype.Text = "" Then
                MsgBox("Select Again ", vbCritical, "TYPE")
                txtType.Text = ""
                txtType.Focus()
            ElseIf lblformulation.Text = "" Then
                MsgBox("Select Again ", vbCritical, "FORMULATION")
                txtFormulation.Text = ""
                txtFormulation.Focus()
            ElseIf txtReorder.Text = "" Then
                MsgBox("Fill up Again ", vbCritical, "RE-ORDER")
                txtReorder.Text = ""
                txtReorder.Focus()
            ElseIf txtprice.Text = "" Then
                MsgBox("Fillup Again ", vbCritical, "Price")
                txtprice.Text = ""
                txtprice.Focus()
            ElseIf txtqnty.Text = "" Then
                MsgBox("Fillup Again ", vbCritical, "QUANTITY")
                txtqnty.Text = ""
                txtqnty.Focus()
            Else
                saveproduct("insert into tbl_product(barcode,brandID,genericID,classificationID,typeID,formulationID,reorder,price,qty)values(?,?,?,?,?,?,?,?,?)")
                MsgBox("Sucessfully Saved!", vbInformation, "Saved!")

                Call loader("Select * from vw_product ", frm_Product.dgvproduct)
                frm_Product.number()
                Me.Dispose()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        If txtBarcode.Text = "" Then
            MsgBox("Fill up Barcode ", vbCritical, "BARCODE")
            txtBarcode.Text = ""
            txtBarcode.Focus()
        ElseIf lblidBrand.Text = "" Then
            MsgBox("Select Again ", vbCritical, "BRAND")
            txtBrandName.Text = ""
            txtBrandName.Focus()
        ElseIf lblgeneric.Text = "" Then
            MsgBox("Select Again ", vbCritical, "GENERIC")
            txtGeneric.Text = ""
            txtGeneric.Focus()
        ElseIf lblgeneric.Text = "" Then
            MsgBox("Select Again ", vbCritical, "GENERIC")
            txtGeneric.Text = ""
            txtGeneric.Focus()
        ElseIf lblclassification.Text = "" Then
            MsgBox("Select Again ", vbCritical, "CLASSIFICATION")
            txtClassificationName.Text = ""
            txtClassificationName.Focus()
        ElseIf lbltype.Text = "" Then
            MsgBox("Select Again ", vbCritical, "TYPE")
            txtType.Text = ""
            txtType.Focus()
        ElseIf lblformulation.Text = "" Then
            MsgBox("Select Again ", vbCritical, "FORMULATION")
            txtFormulation.Text = ""
            txtFormulation.Focus()
        ElseIf txtReorder.Text = "" Then
            MsgBox("Fill up Again ", vbCritical, "RE-ORDER")
            txtReorder.Text = ""
            txtReorder.Focus()
        ElseIf txtprice.Text = "" Then
            MsgBox("Fillup Again ", vbCritical, "Price")
            txtprice.Text = ""
            txtprice.Focus()
        ElseIf txtqnty.Text = "" Then
            MsgBox("Fillup Again ", vbCritical, "QUANTITY")
            txtqnty.Text = ""
            txtqnty.Focus()
        Else
            Dim row As DataGridViewRow = frm_Product.dgvproduct.CurrentRow
            Call connect()
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("Update tbl_product set barcode=?,brandID=?,genericID=?,classificationID=?,typeID=?,formulationID=?,reorder=?,price=?,qty=? where prodID =" & row.Cells(2).Value & "", con)
            With cmd.Parameters
                With cmd.Parameters

                    .AddWithValue("barcode", Me.txtBarcode.Text)
                    .AddWithValue("brandID", Me.lblidBrand.Text)
                    .AddWithValue("genericID", Me.lblgeneric.Text)
                    .AddWithValue("classificationID", Me.lblclassification.Text)
                    .AddWithValue("typeID", Me.lbltype.Text)
                    .AddWithValue("formulationID", Me.lblformulation.Text)
                    .AddWithValue("reorder", Me.txtReorder.Text)
                    .AddWithValue("price", Me.txtprice.Text)
                    .AddWithValue("qty", Me.txtqnty.Text)


                End With
                cmd.ExecuteNonQuery()
                MsgBox("Sucessfully Updated", vbInformation, "UPDATED")
                Call loader("Select * from vw_product ", frm_Product.dgvproduct)
                frm_Product.number()
                Me.Dispose()

            End With
        End If


    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        keyprexnum(e, txtprice)

    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged

    End Sub

    Private Sub txtqnty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqnty.KeyPress
        numberonly(e)

    End Sub

    Private Sub txtqnty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqnty.TextChanged

    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class