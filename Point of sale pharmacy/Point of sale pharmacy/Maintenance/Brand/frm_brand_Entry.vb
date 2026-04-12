Imports MySql.Data.MySqlClient
Public Class frm_brand_Entry

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try

            Call connect()
            If txtCategory.Text = "" Then
                MsgBox("Fill Up Brand Name First!", vbCritical, "BRAND")
                txtCategory.Focus()
            Else
                If redundant() = True Then
                Else

                    If MsgBox("Are you sure you want to save this record?", vbQuestion + vbYesNo, "SAVED") = vbYes Then
                        Call savebrand("insert into tbl_brand(brand)values(?)")
                        MsgBox("Sucessfully Saved!", vbInformation)
                        Call loader("select * from tbl_brand", Frm_maintenance.datagridBrand)
                        Me.Dispose()
                    End If
                End If
              
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally

            GC.Collect()

        End Try
    End Sub
    Private Function redundant() As Boolean
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        da = New MySqlDataAdapter("Select * from tbl_brand where brand = '" & txtCategory.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count = 1 Then

            MsgBox("Brand Already Exist", vbExclamation, "Redundant")
            redundant = True
        Else
            redundant = False
        End If

    End Function

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            Call connect()

            Dim row As DataGridViewRow = Frm_maintenance.datagridBrand.CurrentRow
            Dim cmd As New MySqlCommand("UPDATE tbl_brand set brand=? where brandID=" & row.Cells(2).Value & "", con)

            With cmd.Parameters
                .AddWithValue("brand", Me.txtCategory.Text)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Sucessfully Updated", vbInformation, "UPDATE")
            Call loader("select * from tbl_brand", Frm_maintenance.datagridBrand)
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally

            GC.Collect()

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbQuestion + vbYesNo, "CANCEL") = vbYes Then
            Me.Dispose()

        End If
    End Sub
End Class