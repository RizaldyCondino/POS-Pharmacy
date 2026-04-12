Imports MySql.Data.MySqlClient
Public Class frm_Product

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo, "CLOSE") = vbYes Then

            main.pnldisp.Visible = True
            main.toltop.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With Frm_product_Entry
            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvproduct_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellClick
        Try
            Dim colName As String = dgvproduct.Columns(e.ColumnIndex).Name
            If dgvproduct.RowCount = 0 Then
            Else

                If colName = "prodUpdate" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With Frm_product_Entry
                            Dim row As DataGridViewRow = dgvproduct.CurrentRow
                            .txtBarcode.Text = row.Cells(3).Value
                            .txtBrandName.Text = row.Cells(4).Value
                            .txtGeneric.Text = row.Cells(5).Value
                            .txtClassificationName.Text = row.Cells(6).Value
                            .txtType.Text = row.Cells(7).Value
                            .txtFormulation.Text = row.Cells(8).Value
                            .txtReorder.Text = row.Cells(9).Value
                            .txtprice.Text = row.Cells(10).Value
                            .txtqnty.Text = row.Cells(11).Value

                            .Btnsave.Visible = False
                            .BtnUpdate.Visible = True
                            .ShowDialog()

                        End With
                    End If
                ElseIf colName = "prodDelete" Then
                    If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo, "DELETE") = vbYes Then
                        Try
                            Call connect()

                            Dim row As DataGridViewRow = dgvproduct.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_product where prodID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()

                            Call loader("Select * from vw_product ", Me.dgvproduct)
                            Me.number()
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

    Private Sub datagridformulation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellContentClick

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Sub number()
        Try
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_product", con)
            da.Fill(dt)

            Dim count As Integer = dt.Rows.Count

            lblcounts.Text = "Record Count " & "( " & count & " )"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frm_Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()

        Call loader("Select * from vw_product ", dgvproduct)
        number()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_Stock_in.dtmp2.Value = Date.Now
        Frm_Stock_in.dtmp.Value = Date.Now
        Frm_Stock_in.dtmpstock.Value = Date.Now

        Frm_Stock_in.ShowDialog()
    End Sub

    Private Sub lblcounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcounts.Click

    End Sub
End Class