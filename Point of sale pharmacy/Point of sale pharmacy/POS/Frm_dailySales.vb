Imports MySql.Data.MySqlClient
Public Class Frm_dailySales

    Private Sub Frm_dailySales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtmp.Value = Date.Now
        loadDsales()

    End Sub
    Sub loadDsales()
        Try
            Dim pdate As String = dtmp.Value.ToString("yyyy-MM-dd")
            Call connect()
            Dim ii As Integer = 0
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("SELECT * FROM vw_cart3 WHERE cartdate = '" & dtmp.Text & "' And STATUS = 'Sold' ORDER BY invoice", con)
            da.Fill(dt)

            Me.dgvproduct.Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count.ToString - 1 Step +1

                With Me
                    ii += 1
                    .dgvproduct.Rows.Add(ii, dt.Rows(i)(0).ToString, dt.Rows(i)(1).ToString, dt.Rows(i)(2).ToString, dt.Rows(i)(3).ToString, dt.Rows(i)(4).ToString, dt.Rows(i)(5).ToString, dt.Rows(i)(6).ToString, dt.Rows(i)(7).ToString, CDbl(dt.Rows(i)(8).ToString), CDbl(dt.Rows(i)(9).ToString), dt.Rows(i)(10))
                End With

            Next
            lbltotal.Text = Format(getdata("select ifnull(sum(total),0) from vw_cart3 where cartdate = '" & pdate & "' AND status = 'Sold' "), "#,##0.00")
            lbldiscount.Text = Format(getdata("select ifnull(sum(discount),0) from tbl_payment where pdate = '" & pdate & "'"), "#,##0.00")
            lblsubtotal.Text = Format(getdata("select ifnull(sum(subtotal),0) from tbl_payment where pdate = '" & pdate & "'"), "#,##0.00")
            lblvat.Text = Format(getdata("select ifnull(sum(vat),0) from tbl_payment where pdate = '" & pdate & "'"), "#,##0.00")
            lbltotalSales.Text = Format(getdata("select ifnull(sum(amountdue),0) from tbl_payment where pdate = '" & pdate & "'"), "#,##0.00")
            lblsalestotal.Text = Format(getdata("select ifnull(sum(amountdue),0) from tbl_payment where pdate = '" & pdate & "'"), "#,##0.00")
            Me.dgvproduct.Rows.Add(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "TOTAL", CDbl(lbltotal.Text))

        Catch ex As Exception

        End Try




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Close") = vbYes Then
            Me.Dispose()

        End If
    End Sub

    Private Sub dtmp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtmp.ValueChanged
        loadDsales()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsalestotal.Click

    End Sub
End Class