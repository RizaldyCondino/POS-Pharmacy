Imports MySql.Data.MySqlClient
Public Class Frm_Types_Entry

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            Call connect()

            Dim row As DataGridViewRow = Frm_maintenance.datagridtype.CurrentRow
            Dim cmd As New MySqlCommand("UPDATE tbl_type set type=? where typeID=" & row.Cells(2).Value & "", con)

            With cmd.Parameters
                .AddWithValue("type", Me.txtCategory.Text)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Sucessfully Updated", vbInformation, "UPDATE")
            Call loader("select * from tbl_type", Frm_maintenance.datagridtype)
            Me.Dispose()

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
        da = New MySqlDataAdapter("Select * from tbl_type where type = '" & txtCategory.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            MsgBox("Type already Exist", vbCritical, "RECORD")

            redundant = True
        Else
            redundant = False

        End If


    End Function


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbQuestion + vbYesNo, "CANCEL") = vbYes Then
            Me.Dispose()

        End If
    End Sub

    Private Sub Btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Call connect()
        If IS_EMPTY(txtCategory) = True Then Return
        If redundant() = True Then


        Else

            If MsgBox("Are you sure you want to save this record?", vbQuestion + vbYesNo, "SAVED") = vbYes Then
                Call saveType("insert into tbl_type(type)values(?)")
                MsgBox("Sucessfully Saved!", vbInformation)
                Call loader("select * from tbl_type", Frm_maintenance.datagridtype)
                Me.Dispose()
            End If
        End If



    End Sub
End Class