Imports MySql.Data.MySqlClient
Public Class Frm_Stock_in



 


    Sub loaderprod()
        Try

            Dim ii As Integer
            dgvDesc.Rows.Clear()
            Call connect()
            'Call loader("Select prodID,brand,generic,classification,type,formulation from vw_product ", dgvDesc)
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from vw_product where " & cmbselect.Text & " like '" & txtSearch.Text & "%' and isActive = 0 limit 50", con)
            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                ii += 1
                dgvDesc.Rows.Add(ii, dt.Rows(i)(0).ToString, dt.Rows(i)(1).ToString & "|" & Space(2) & dt.Rows(i)(2).ToString & "|" & Space(2) & dt.Rows(i)(3).ToString & "|" & Space(2) & dt.Rows(i)(4).ToString & "|" & Space(2) & dt.Rows(i)(5).ToString & "|" & Space(2) & dt.Rows(i)(6).ToString & "|" & Space(2) & dt.Rows(i)(7).ToString & "|" & Space(2) & dt.Rows(i)(8).ToString & "|" & Space(2) & dt.Rows(i)(9).ToString & "|" & Space(2))
            Next



        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbselect_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cmbselect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo, "CLOSE") = vbYes Then
            Try
                Call connect()
                Dim da As MySqlDataAdapter
                Dim dt As New DataTable
                da = New MySqlDataAdapter("SELECT * FROM tbl_product where isActive = 1 ", con)
                da.Fill(dt)

                For row As Integer = 0 To dt.Rows.Count - 1 Step +1
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("Update tbl_product set isActive = 0 where prodID =" & dt.Rows(row)(0) & "", con)
                    cmd.ExecuteNonQuery()
                Next
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()

            End Try
        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'loaderprod()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If dgvproduct.RowCount = 0 Then
                MsgBox("Create Record First", vbCritical, "CREATE")
            ElseIf redundant() = True Then

            Else
                

                For i As Integer = 0 To dgvproduct.RowCount.ToString - 1 Step +1
                    If dgvproduct.Rows(i).Cells(8).Value = String.Empty Then
                        MsgBox("Missing Quantity", vbCritical)
                        Return
                    End If

                Next
                Call savestock("insert into tbl_stock(refno,receiveby,prodID,qty,sdate)values(?,?,?,?,?)")
                updateprod()
                Call loader("Select * from vw_product ", frm_Product.dgvproduct)
                MsgBox("Sucessfully Saved Stock!", vbInformation, "STOCK")
            End If

        Catch ex As Exception

        End Try

    End Sub

   
    Public Function redundant() As Boolean
        Try
            For i As Integer = 0 To dgvproduct.RowCount.ToString - 1 Step +1
                Dim da As MySqlDataAdapter
                Dim dt As New DataTable
                da = New MySqlDataAdapter("Select * from tbl_stock where refno = '" & txtreference.Text & "' and receiveby = '" & txtreceiveby.Text & "' and prodID = '" & dgvproduct.Rows(i).Cells(1).Value & "'", con)
                da.Fill(dt)

                If dt.Rows.Count = 1 Then
                    redundant = True
                    MsgBox("Already stock", vbInformation, "ALREADY")
                Else
                    redundant = False

                End If
            Next
        Catch ex As Exception

        End Try

    End Function

    Private Sub dgvproduct_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellClick
        'Dim colname As String = dgvproduct.Columns(e.ColumnIndex).Name
        'If colname = "Colremove" Then
        '    If MsgBox("Are you Sure you want to remove this record?", vbQuestion + vbYesNo) = vbYes Then
        '        Dim row As DataGridViewRow = dgvproduct.CurrentRow

        '        dgvproduct.Rows.RemoveAt(row.Index.ToString)



        '    End If


        'End If



    End Sub
    Private Sub dgvproduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellContentClick
     
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblStockrecieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStockrecieve.Click

    End Sub

   
    Private Sub lblStockrecieve_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStockrecieve.TextChanged
    

    End Sub

    Private Sub dgvproduct_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellValueChanged
        Try


            Dim stock As Double
            For i As Integer = 0 To dgvproduct.Rows.Count - 1 Step +1

                If dgvproduct.Rows(i).Cells(8).Value.ToString <> String.Empty Then stock += CDbl(dgvproduct.Rows(i).Cells(8).Value.ToString)
          
            Next
            lblStockrecieve.Text = stock
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtreference_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreference.KeyPress
        Call numberonly(e)

    End Sub

    Private Sub txtreference_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreference.TextChanged

    End Sub

    Private Sub txtreceiveby_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreceiveby.KeyPress
        keyprex(e, txtreceiveby)
    End Sub

    Private Sub txtreceiveby_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreceiveby.TextChanged

    End Sub

    Private Sub Panel9_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub dgvDesc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDesc.CellContentClick
        Try
            Dim data As String = dgvDesc.Rows(e.RowIndex).Cells(2).Value.ToString
            Dim arr() As String = data.Split("|")
            Dim colName As String = dgvDesc.Columns(e.ColumnIndex).Name
            If colName = "See" Then
                If txtreference.Text = "" Then
                    MsgBox("Fill up Reference Number First", vbCritical, "REFERENCE No.")
                    txtreference.Focus()
                ElseIf txtreceiveby.Text = "" Then
                    MsgBox("Fill up Receive By First", vbCritical, "RECEIVE BY")
                    txtreceiveby.Focus()
                Else
                    If MsgBox("Barcode : " & arr(0).ToString & vbCr &
                              "Brand : " & arr(1).ToString & vbCr &
                                "Generic : " & arr(2).ToString & vbCr &
                                "Classification : " & arr(3).ToString & vbCr &
                                "Type : " & arr(4).ToString & vbCr &
                                "Formulation : " & arr(5).ToString & vbCr,
                           vbInformation + vbYesNo, "Please Confirm") = vbYes Then
                        dgvproduct.Rows.Add(dgvproduct.Rows.Count + 1, dgvDesc.Rows(e.RowIndex).Cells(1).Value.ToString, arr(0).ToString, arr(1).ToString, arr(2).ToString, arr(3).ToString, arr(4).ToString, arr(5).ToString)
                        Call connect()
                        Dim row2 As DataGridViewRow = dgvDesc.CurrentRow
                        Dim cmd As New MySqlCommand("Update tbl_product set isActive = 1 where prodID = " & row2.Cells(1).Value & "", con)
                        cmd.ExecuteNonQuery()
                        loaderprod()

                        'If dgvproduct.RowCount = 0 Then
                        '    dgvproduct.Rows.Add(dgvproduct.Rows.Count + 1, dgvDesc.Rows(e.RowIndex).Cells(1).Value.ToString, arr(0).ToString, arr(1).ToString, arr(2).ToString, arr(3).ToString, arr(4).ToString, arr(5).ToString)
                        'Else
                        '    Dim row As DataGridViewRow = dgvproduct.CurrentRow
                        '    Dim row2 As DataGridViewRow = dgvDesc.CurrentRow
                        '    'For i As Integer = 0 To row.Cells(1).Value - 1 Step +1
                        '    If row.Cells(1).Value = row2.Cells(1).Value Then
                        '        MsgBox("Already Have Record", vbCritical, "RECORD")
                        '    Else
                        '        dgvproduct.Rows.Add(dgvproduct.Rows.Count + 1, dgvDesc.Rows(e.RowIndex).Cells(1).Value.ToString, arr(0).ToString, arr(1).ToString, arr(2).ToString, arr(3).ToString, arr(4).ToString, arr(5).ToString)
                        '    End If

                        'Next


                    End If

                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        loaderprod()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call loader("Select * from"
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        If dtmp.Value > dtmp2.Value Then
            MsgBox("Invalid Date!", vbCritical, "DATE")
        Else
            Call connect()
            Call loader("SELECT * FROM vw_stock WHERE sdate BETWEEN '" & dtmp.Text & "' AND '" & dtmp2.Text & "' ", dgvstock)
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo, "CLOSE") = vbYes Then
            Try
                Call connect()
                Dim da As MySqlDataAdapter
                Dim dt As New DataTable
                da = New MySqlDataAdapter("SELECT * FROM tbl_product where isActive = 1 ", con)
                da.Fill(dt)

                For row As Integer = 0 To dt.Rows.Count - 1 Step +1
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("Update tbl_product set isActive = 0 where prodID =" & dt.Rows(row)(0) & "", con)
                    cmd.ExecuteNonQuery()
                Next
                dgvproduct.Rows.Clear()
                loaderprod()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()

            End Try
        End If

    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class