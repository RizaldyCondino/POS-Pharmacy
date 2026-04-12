Imports MySql.Data.MySqlClient
Module modPos
    Public Sub savecart()
        Try
            If Frm_Quantity.txtQuantity.Text = String.Empty Or Frm_Quantity.txtQuantity.Text = "0" Then Return
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_cart where invoice = " & Frm_POS.lblinvoiceNum.Text & " AND prodID = " & Frm_POS.lblid.Text & "", con)
            da.Fill(dt)
            If dt.Rows.Count = Nothing Then
                save()
                Exit Sub
            ElseIf dt.Rows.Count > 0 Then
                cmd = New MySqlCommand("UPDATE tbl_cart SET  qty = qty + " & Frm_Quantity.txtQuantity.Text & ",total = price * qty where prodID = " & Frm_POS.lblid.Text & " AND invoice = " & Frm_POS.lblinvoiceNum.Text & "", con)
                cmd.ExecuteNonQuery()
                Dim da2 As MySqlDataAdapter
                Dim dt2 As New DataTable
                da2 = New MySqlDataAdapter("SELECT p.prodID,c.invoice,p.qty FROM vw_product p JOIN tbl_cart c ON p.prodID = c.prodID  where p.prodID = " & Frm_POS.lblid.Text & " AND invoice = " & Frm_POS.lblinvoiceNum.Text & "", con)
                da2.Fill(dt2)
                Dim daa As MySqlDataAdapter
                Dim dtt As New DataTable
                daa = New MySqlDataAdapter("Select * from view_cart where invoice = " & Frm_POS.lblinvoiceNum.Text & " AND prodID = " & Frm_POS.lblid.Text & "", con)
                daa.Fill(dtt)
                If dtt.Rows.Count = Nothing Then
                    Exit Sub
                ElseIf Val(Frm_Quantity.txtQuantity.Text) > dt2.Rows(0)(1) Then
                    MsgBox("Insufficient Balance", vbCritical, "INSUFFICIENT")
                    Frm_Quantity.txtQuantity.Text = ""
                    Frm_Quantity.txtQuantity.Focus()
                    Exit Sub
                Else
                    For i As Integer = 0 To Frm_POS.dgvproduct.RowCount - 1 Step +1
                        If Frm_POS.dgvproduct.Item(2, i).Value = dt2.Rows(0)(0) Then
                            Dim quantity As Integer = Frm_POS.dgvproduct.Item(10, i).Value
                            Dim newstock As Integer = quantity - dt2.Rows(0)(2)
                            Dim news As Integer = -newstock
                            If Frm_Quantity.txtQuantity.Text > news Then
                                MsgBox("Insufficient Stocks the remaining stocks is " & news & "", MsgBoxStyle.Exclamation, "Pharmacy POS")
                                Frm_Quantity.txtQuantity.Text = ""
                                Frm_Quantity.txtQuantity.Focus()
                                Exit Sub
                            End If
                        End If
                    Next
                    'cmd = New MySqlCommand("UPDATE tbl_cart SET  qty = qty + " & Frm_Quantity.txtQuantity.Text & ",total = price * qty where prodID = " & Frm_POS.lblid.Text & " AND invoice = " & Frm_POS.lblinvoiceNum.Text & "", con)
                    'cmd.ExecuteNonQuery()
                    Exit Sub
                End If
            End If
            Frm_POS.txtBarcode.Focus()
            Frm_POS.txtBarcode.SelectionStart = 0
            Frm_POS.txtBarcode.SelectionLength = Frm_POS.txtBarcode.Text.Length
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub
    Public Sub save()
        Try
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("insert into tbl_cart(invoice,prodID,price,qty,cartdate,user,status)values(?,?,?,?,?,?,?)", con)
            With cmd
                .Parameters.AddWithValue("invoice", Frm_POS.lblinvoiceNum.Text)
                .Parameters.AddWithValue("prodID", Frm_POS.lblid.Text)
                .Parameters.AddWithValue("price", CDbl(Frm_POS.lbltotal.Text))
                .Parameters.AddWithValue("qty", Frm_Quantity.txtQuantity.Text)
                .Parameters.AddWithValue("cartdate", Date.Now)
                .Parameters.AddWithValue("user", "Rizaldy O. Condino")
                .Parameters.AddWithValue("status", "Pending")
                .ExecuteNonQuery()
            End With
            cmd = New MySqlCommand("Update tbl_cart set total = qty * price where invoice = " & Frm_POS.lblinvoiceNum.Text & "", con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub savepayment()
        Try
            Dim sql As String = "insert into tbl_payment(invoice,subtotal,vat,discount,amountdue,pdate,user)values(@invoice,@subtotal,@vat,@discount,@amountdue,@pdate,@user)"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("@invoice", Frm_POS.lblinvoiceNum.Text)

                .AddWithValue("@subtotal", CDec(Frm_POS.lblSub.Text))

                .AddWithValue("@vat", CDec(Frm_POS.lblVat.Text))

                .AddWithValue("@discount", CDec(Frm_POS.lblDisc.Text))

                .AddWithValue("@amountdue", CDec(Frm_POS.lbldue.Text))


                .AddWithValue("@pdate", Date.Now)
                .AddWithValue("@user", "Rizaldy O Condino")
                'invoice, subtotal, vat, discount, amountdue, pdate, user
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Payment has been Sucessfully Saved!", vbInformation, "Sucess")
            'minustock()
            'Frm_Quantity.loaderdgvcart()
            Frm_POS.txtBarcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub




    Public Sub minustock()

        Try
            For i As Integer = 0 To Frm_POS.dgvproduct.RowCount - 1 Step +1


                With Frm_POS


                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("update tbl_product set qty = qty - " & +.dgvproduct.Rows(i).Cells(10).Value & " where prodID = " & .dgvproduct.Rows(i).Cells(2).Value & "", con)

                    cmd.ExecuteNonQuery()
                    cmd = New MySqlCommand("update tbl_cart set status = 'Sold' where cartID =  " & .dgvproduct.Rows(i).Cells(1).Value & "", con)
                    cmd.ExecuteNonQuery()

                End With
            Next
        Catch ex As Exception

        End Try

    End Sub
End Module
