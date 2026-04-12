Imports MySql.Data.MySqlClient
Module Modstock
    Public Sub savestock(ByVal sql As String)
        Dim cmd As MySqlCommand
        Try

            For i As Integer = 0 To Frm_Stock_in.dgvproduct.Rows.Count.ToString - 1 Step +1
                'Dim i As Integer = Frm_Stock_in.dgvproduct.RowCount.ToString

                cmd = New MySqlCommand(sql, con)

                With cmd

                    .Parameters.AddWithValue("@refno", Frm_Stock_in.txtreference.Text)
                    .Parameters.AddWithValue("@receiveby", Frm_Stock_in.txtreceiveby.Text)
                    .Parameters.AddWithValue("@prodID", Frm_Stock_in.dgvproduct.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@qty", Frm_Stock_in.dgvproduct.Rows(i).Cells(8).Value)
                    .Parameters.AddWithValue("@sdate", Frm_Stock_in.dtmpstock.Value)
                    .ExecuteNonQuery()
                End With

            Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()

            End Try

    End Sub


    Public Sub updateprod()
        Try
            For i As Integer = 0 To Frm_Stock_in.dgvproduct.Rows.Count.ToString - 1 Step +1
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("Update tbl_product set qty = qty + " & CInt(Frm_Stock_in.dgvproduct.Rows(i).Cells(8).Value) & " where prodID = " & CInt(Frm_Stock_in.dgvproduct.Rows(i).Cells(1).Value) & " ", con)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception

        End Try

    End Sub
End Module
