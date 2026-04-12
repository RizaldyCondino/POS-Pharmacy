Imports MySql.Data.MySqlClient
Module productMod
    Public Sub saveproduct(ByVal sql As String)
        Try
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("barcode", Frm_product_Entry.txtBarcode.Text)
                .AddWithValue("brandID", Frm_product_Entry.lblidBrand.Text)
                .AddWithValue("genericID", Frm_product_Entry.lblgeneric.Text)
                .AddWithValue("classificationID", Frm_product_Entry.lblclassification.Text)
                .AddWithValue("typeID", Frm_product_Entry.lbltype.Text)
                .AddWithValue("formulationID", Frm_product_Entry.lblformulation.Text)
                .AddWithValue("reorder", Frm_product_Entry.txtReorder.Text)
                .AddWithValue("price", Frm_product_Entry.txtprice.Text)
                .AddWithValue("qty", Frm_product_Entry.txtqnty.Text)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub



    Public Sub keyprex(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal text As TextBox)
        Dim allowed As String = "0123456789/.ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz, -+#@!$%^&*()="""
        If allowed.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If text.Text.Length >= 5000 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub
End Module
