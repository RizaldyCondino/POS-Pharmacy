Imports MySql.Data.MySqlClient
Public Class Frm_maintenance

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub datagridcateg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Frm_maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
        Call loader("select * from tbl_classification", datagridclassif)
        Call loader("select * from tbl_brand", datagridBrand)
        Call loader("select * from tbl_generic", datagridgeneric)
        Call loader("select * from tbl_type", datagridtype)
        Call loader("select * from tbl_formulation", datagridformulation)
        getvat()
        loaderdis()

        btnSave.Enabled = True
        btnUpdatedis.Enabled = False
        btnCancel.Enabled = False
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo, "CLOSE") = vbYes Then

            main.pnldisp.Enabled = True
            main.toltop.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub datagridclassif_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridclassif.CellClick
        Try
            Dim colName As String = datagridclassif.Columns(e.ColumnIndex).Name
            If datagridclassif.RowCount = 0 Then
            Else

                If colName = "Column3" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With Frm_Classification_Entry
                            Dim row As DataGridViewRow = datagridclassif.CurrentRow
                            .txtCategory.Text = row.Cells(3).Value
                            .Btnsave.Visible = False
                            .BtnUpdate.Visible = True
                            .ShowDialog()

                        End With
                    End If
                ElseIf colName = "Column4" Then
                    If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                        Try
                            Call connect()

                            Dim row As DataGridViewRow = datagridclassif.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_classification where classifID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()
                            Call loader("select * from tbl_classification", datagridclassif)
                            MsgBox("Sucessfully DELETE", vbInformation, "DELETE")

                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        Finally
                            GC.Collect()

                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub

    Private Sub datagridclassif_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridclassif.CellContentClick

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        With Frm_Classification_Entry
            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub datagridBrand_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridBrand.CellClick
        Try
            Dim colName As String = datagridBrand.Columns(e.ColumnIndex).Name
            If datagridBrand.RowCount = 0 Then
            Else

                If colName = "brandupdate" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With frm_brand_Entry
                            Dim row As DataGridViewRow = datagridBrand.CurrentRow
                            .txtCategory.Text = row.Cells(3).Value
                            .Btnsave.Visible = False
                            .BtnUpdate.Visible = True
                            .ShowDialog()

                        End With
                    End If
                ElseIf colName = "branddelete" Then
                    If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                        Try
                            Call connect()

                            Dim row As DataGridViewRow = datagridBrand.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_brand where brandID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()
                            Call loader("select * from tbl_brand", datagridBrand)
                            MsgBox("Sucessfully DELETE", vbInformation, "DELETE")

                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        Finally
                            GC.Collect()

                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub


    Private Sub datagridBrand_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridBrand.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With frm_brand_Entry
            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub datagridgeneric_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridgeneric.CellClick
        Try
            Dim colName As String = datagridgeneric.Columns(e.ColumnIndex).Name
            If datagridgeneric.RowCount = 0 Then
            Else

                If colName = "genericUpdate" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With Frm_Generic_Entry
                            Dim row As DataGridViewRow = datagridgeneric.CurrentRow
                            .txtCategory.Text = row.Cells(3).Value
                            .Btnsave.Visible = False
                            .BtnUpdate.Visible = True
                            .ShowDialog()

                        End With
                    End If
                ElseIf colName = "genericDelete" Then
                    If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                        Try
                            Call connect()

                            Dim row As DataGridViewRow = datagridgeneric.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_generic where brandID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()
                            Call loader("select * from tbl_generic", datagridgeneric)
                            MsgBox("Sucessfully DELETE", vbInformation, "DELETE")

                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        Finally
                            GC.Collect()

                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridgeneric.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With Frm_Generic_Entry
            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With Frm_Types_Entry
            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub datagridtype_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridtype.CellClick
        Try
            Dim colName As String = datagridtype.Columns(e.ColumnIndex).Name
            If datagridtype.RowCount = 0 Then
            Else

                If colName = "typeUpdate" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With Frm_Types_Entry
                            Dim row As DataGridViewRow = datagridtype.CurrentRow
                            .txtCategory.Text = row.Cells(3).Value
                            .Btnsave.Visible = False
                            .BtnUpdate.Visible = True
                            .ShowDialog()

                        End With
                    End If
                ElseIf colName = "typeDelete" Then
                    If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                        Try
                            Call connect()

                            Dim row As DataGridViewRow = datagridtype.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_type where typeID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()
                            Call loader("select * from tbl_type", datagridtype)
                            MsgBox("Sucessfully DELETE", vbInformation, "DELETE")

                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        Finally
                            GC.Collect()

                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub

    Private Sub datagridtype_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridtype.CellContentClick

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        With frm_Formulation_Entry
            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub datagridformulation_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridformulation.CellClick
        Try
            Dim colName As String = datagridformulation.Columns(e.ColumnIndex).Name
            If datagridformulation.RowCount = 0 Then
            Else

                If colName = "formulationUpdate" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With frm_Formulation_Entry
                            Dim row As DataGridViewRow = datagridformulation.CurrentRow
                            .txtCategory.Text = row.Cells(3).Value
                            .Btnsave.Visible = False
                            .BtnUpdate.Visible = True
                            .ShowDialog()

                        End With
                    End If
                ElseIf colName = "formulationDelete" Then
                    If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                        Try
                            Call connect()

                            Dim row As DataGridViewRow = datagridformulation.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_formulation where formulationID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()
                            Call loader("select * from tbl_formulation", datagridformulation)
                            MsgBox("Sucessfully DELETE", vbInformation, "DELETE")

                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        Finally
                            GC.Collect()

                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub


    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            Dim i As Double
            If Val(txtVat.Text) = i Then
                MsgBox("Invalid", vbCritical, "INVALID")
            Else
                savevat()


            End If
        Catch ex As Exception

        End Try

       

    End Sub


    Sub savevat()

        Try
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("SELECT COUNT(*) FROM tbl_vat", con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Call connect()
                Dim cmd2 As MySqlCommand
                cmd2 = New MySqlCommand("insert into tbl_vat(vat)values(?)", con)

                With cmd2.Parameters
                    .AddWithValue("vat", CDbl(txtVat.Text))
                End With
                cmd2.ExecuteNonQuery()
            Else
                Call connect()
                Dim cmd As New MySqlCommand("update tbl_vat set vat = '" & CDbl(txtVat.Text) & "'", con)
                cmd.ExecuteNonQuery()


            End If
            MsgBox("Sucessfully Saved!", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try



    End Sub

    Private Sub TabPage7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress
        keyprexnum(e, txtVat)

    End Sub

    Private Sub txtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVat.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtDescriptiondis.Text = "" Then
            MsgBox("Please input again for Description", vbCritical, "DESCRIPTION")
            txtDescriptiondis.Focus()
        ElseIf txtDiscount.Text = "" Then
            MsgBox("Please input again for Discount", vbCritical, "DISCOUNT")
            txtDiscount.Focus()
        Else
            If validaterecords("Select description from tbl_discount where description like '" & txtDescriptiondis.Text & "'") = True Then Return
            Call savediscount("insert into tbl_discount (description,discount)values(?,?)")

            txtDescriptiondis.Text = ""
            txtDiscount.Text = ""
            loaderdis()
        End If
   

    End Sub


    Public Sub loaderdis()
        Try
            dgvdiscount.Rows.Clear()
            Call connect()
            Dim ii As Integer = 0
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_discount", con)

            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                With Me

                    ii += 1
                    .dgvdiscount.Rows.Add(ii, dt.Rows(i)(0), dt.Rows(i)(1), dt.Rows(i)(2))

                End With


            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try




    End Sub

    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub dgvdiscount_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdiscount.CellClick
        Try
            Dim colname As String = dgvdiscount.Columns(e.ColumnIndex).Name
            Dim row As DataGridViewRow = dgvdiscount.CurrentRow
            lbldisc.Text = row.Cells(1).Value

            If colname = "UpdateDis" Then
                If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then
                    txtDescriptiondis.Text = row.Cells(2).Value
                    txtDiscount.Text = row.Cells(3).Value
                    btnSave.Enabled = False
                    btnUpdatedis.Enabled = True
                    btnCancel.Enabled = True
                End If

            ElseIf colname = "DeleteDis" Then
                If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("Delete from tbl_discount where discountID = " & row.Cells(1).Value & "", con)
                    cmd.ExecuteNonQuery()
                    loaderdis()
                    MsgBox("Sucessfully Deleted", vbInformation, "DELETE")

                End If
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvdiscount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdiscount.CellContentClick

    End Sub

    Private Sub btnUpdatedis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdatedis.Click
        Try

            Dim row As DataGridViewRow = dgvdiscount.CurrentRow
            Dim sql As String = "Update tbl_discount set description=?,discount=? where discountID = " & lbldisc.Text & " "

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("description", txtDescriptiondis.Text)
                .AddWithValue("discount", txtDiscount.Text)
            End With
            cmd.ExecuteNonQuery()
            loaderdis()
            lbldisc.Text = ""
            MsgBox("Sucessfully Updated", vbInformation, "UPDATED")
            txtDiscount.Text = ""
            txtDescriptiondis.Text = ""
            btnSave.Enabled = True
            btnUpdatedis.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbQuestion + vbYesNo, "CANCEL") = vbYes Then
            btnUpdatedis.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = False
            lbldisc.Text = ""
            txtDescriptiondis.Text = ""
            txtDiscount.Text = ""
        End If
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class