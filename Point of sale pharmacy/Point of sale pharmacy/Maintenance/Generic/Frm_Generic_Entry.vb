Imports MySql.Data.MySqlClient
Public Class Frm_Generic_Entry

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try

            Call connect()
            If txtCategory.Text = "" Then
                MsgBox("Fill Up Generic First!", vbCritical, "Generic")
                txtCategory.Focus()
            Else
                If redundant() = True Then
                Else
                    If MsgBox("Are you sure you want to save this record?", vbQuestion + vbYesNo, "SAVED") = vbYes Then
                        Call savegeneric("insert into tbl_generic(generic)values(?)")
                        MsgBox("Sucessfully Saved!", vbInformation)
                        Call loader("select * from tbl_generic", Frm_maintenance.datagridgeneric)
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
        da = New MySqlDataAdapter("Select * from tbl_generic where generic = '" & txtCategory.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count = 1 Then

            MsgBox("Generic Name Already Exist", vbExclamation, "Redundant")
            redundant = True
        Else
            redundant = False
        End If

    End Function
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            Call connect()

            Dim row As DataGridViewRow = Frm_maintenance.datagridgeneric.CurrentRow
            Dim cmd As New MySqlCommand("UPDATE tbl_generic set generic=? where genericID=" & row.Cells(2).Value & "", con)

            With cmd.Parameters
                .AddWithValue("classification", Me.txtCategory.Text)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Sucessfully Updated", vbInformation, "UPDATE")
            Call loader("select * from tbl_generic", Frm_maintenance.datagridgeneric)
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally

            GC.Collect()

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbYesNo + vbQuestion, "Cancel") = vbYes Then
            Me.Dispose()

        End If
    End Sub
End Class