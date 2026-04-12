Imports MySql.Data.MySqlClient
Public Class Frm_Quantity

    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                With Frm_POS
                    .txtBarcode.Focus()
                    .txtBarcode.SelectionStart = 0
                    .txtBarcode.SelectionLength = .txtBarcode.Text.Length

                End With
                Me.Dispose()

        End Select
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress

        Select Case Asc(e.KeyChar)
            Case 13
         
                selectBarcode()
             

                Frm_POS.lblid.Text = ""
                Me.Dispose()

            Case 48 To 57
            Case 8

            Case Else
                e.Handled = True

        End Select

    End Sub


    Public Sub selectbarcode()
        Try
            Call connect()
            Dim com As New MySqlCommand("Select * from vw_product where barcode=?", con)
            com.Parameters.AddWithValue("", Frm_POS.txtBarcode.Text)
            Dim da As New MySqlDataAdapter(com)
            Dim dt As New DataTable
            da.Fill(dt)
            If Val(txtQuantity.Text) > dt.Rows(0)(9) Then
                MsgBox("Insufficient Balance", vbCritical, "INSUFFICIENT")
                Exit Sub
                txtQuantity.Text = ""
                txtQuantity.Text = Focus()
            Else
                savecart()
            End If
            loaderdgvcart()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub loaderdgvcart()
        Try
            Call connect()
            Dim ii As Integer = 0
            Dim totalall As Decimal
            Dim subs As Decimal
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from vw_cart3 where invoice = " & Frm_POS.lblinvoiceNum.Text & " ", con)
            da.Fill(dt)


            Frm_POS.dgvproduct.Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count.ToString - 1 Step +1
                With Frm_POS
                    ii += 1
                    .dgvproduct.Rows.Add(ii, dt.Rows(i)(0).ToString, dt.Rows(i)(1).ToString, dt.Rows(i)(2).ToString, dt.Rows(i)(3).ToString, dt.Rows(i)(4).ToString, dt.Rows(i)(5).ToString, dt.Rows(i)(6).ToString, dt.Rows(i)(7).ToString, CDbl(dt.Rows(i)(8).ToString), CDbl(dt.Rows(i)(9).ToString), dt.Rows(i)(10))
                    totalall += CDbl(dt.Rows(i)(10))
                    subs += CDbl(dt.Rows(i)(10))

                End With

            Next

            With Frm_POS

                .lbltotal.Text = Format(CDbl(totalall), "#,##0.00")
                .lblSub.Text = Format(CDbl(.lbltotal.Text) - CDbl(.lblDisc.Text), "#,##0.00")
                .lblVat.Text = Format(CDbl(.lblSub.Text) * Frm_POS.txtVat.Text, "#,##0.00")
                .lbldue.Text = Format(CDbl(.lblSub.Text) - CDbl(.lblVat.Text), "#,##0.00")
                .lbldisplayotal.Text = Format(CDbl(.lbldue.Text), "#,##0.00")


                If .dgvproduct.RowCount = 0 Then
                    .btnDiscount.Enabled = False
                    .btnSettle.Enabled = False
                Else
                    .btnDiscount.Enabled = True
                    .btnSettle.Enabled = True
                End If


            End With





        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try

    End Sub
   

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged

    End Sub
End Class