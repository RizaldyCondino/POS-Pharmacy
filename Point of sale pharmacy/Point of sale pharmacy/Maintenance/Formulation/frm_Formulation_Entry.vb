Imports MySql.Data.MySqlClient
Public Class frm_Formulation_Entry

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            Call connect()

            Dim row As DataGridViewRow = Frm_maintenance.datagridformulation.CurrentRow
            Dim cmd As New MySqlCommand("UPDATE tbl_formulation set formulation=? wher formulationID=" & row.Cells(2).Value & "", con)

            With cmd.Parameters
                .AddWithValue("formulation", Me.txtCategory.Text)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Sucessfully Updated", vbInformation, "UPDATE")
            Call loader("select * from tbl_formulation", Frm_maintenance.datagridformulation)
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
        da = New MySqlDataAdapter("Select * from tbl_formulation where formulation = '" & txtCategory.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count = 1 Then

            MsgBox("Formulation Name Already Exist", vbExclamation, "Redundant")
            redundant = True
        Else
            redundant = False
        End If

    End Function

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try

            Call connect()
            If txtCategory.Text = "" Then
                MsgBox("Fill Up Formulation First!", vbCritical, "Generic")
                txtCategory.Focus()
            Else
                If redundant() = True Then
                Else
                    If MsgBox("Are you sure you want to save this record?", vbQuestion + vbYesNo, "SAVED") = vbYes Then
                        Call saveformulation("insert into tbl_formulation(formulation)values(?)")
                        MsgBox("Sucessfully Saved!", vbInformation)
                        Call loader("select * from tbl_formulation", Frm_maintenance.datagridformulation)
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbYesNo + vbQuestion, "Cancel") = vbYes Then
            Me.Dispose()

        End If
    End Sub
End Class