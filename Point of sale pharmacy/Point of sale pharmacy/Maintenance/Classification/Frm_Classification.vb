Imports MySql.Data.MySqlClient
Public Class Frm_Classification
    Dim _category As String
    Dim _id As Integer
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Frm_Category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
        Call loader("select * from tbl_classification", datagridcateg)

    End Sub
    Private Sub datagridcateg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridcateg.CellClick

        Try
            Dim colName As String = datagridcateg.Columns(e.ColumnIndex).Name
            If datagridcateg.RowCount = 0 Then
            Else

                If colName = "Column3" Then
                    If MsgBox("Are you sure you want to Update this record?", vbQuestion + vbYesNo, "UPDATE") = vbYes Then

                        With Frm_Classification_Entry
                            Dim row As DataGridViewRow = datagridcateg.CurrentRow
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

                            Dim row As DataGridViewRow = datagridcateg.CurrentRow
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("DELETE FROM tbl_classification where classifID = " & row.Cells(2).Value & "", con)
                            cmd.ExecuteNonQuery()
                            Call loader("select * from tbl_classification", datagridcateg)
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

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        With Frm_Classification_Entry

            .Btnsave.Enabled = True
            .BtnUpdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub datagridcateg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridcateg.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class