Imports MySql.Data.MySqlClient
Public Class Frm_records

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo, "CLOSE") = vbYes Then

            main.pnldisp.Enabled = True
            main.toltop.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub BtnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGO.Click
        Try
            Call connect()
            If cmbselect.Text = "Barcode" Then
                loader("select * from vw_product where qty > 0 AND barcode like '" & txtSearch.Text & "%' ", dgvstock)


            ElseIf cmbselect.Text = "Brand" Then
                loader("select * from vw_product where qty > 0 AND brand like '" & txtSearch.Text & "%' ", dgvstock)
            ElseIf cmbselect.Text = "Generic" Then
                loader("select * from vw_product where qty > 0 AND  generic like '" & txtSearch.Text & "%' ", dgvstock)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvstock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCritstocks.SelectedIndexChanged
        Try
            'Call connect()
            'If cmbselect.Text = "Barcode" Then
            '    loader("select * from vw_product where qty > 0 AND barcode like '" & cmbCritstocks.Text & "%' ", dgvcritstock)
            'ElseIf cmbselect.Text = "Brand" Then
            '    loader("select * from vw_product where qty > 0 AND brand like '" & cmbCritstocks.Text & "%' ", dgvcritstock)
            'ElseIf cmbselect.Text = "Generic" Then
            '    loader("select * from vw_product where qty > 0 AND  generic like '" & cmbCritstocks.Text & "%' ", dgvcritstock)
            'End If'
            Call connect()

            If cmbCritstocks.Text = "Under Stocks" Then
                loader("select * from vw_product where ( qty <= reorder and qty > 0 ) ", dgvcritstock)
            Else
                loader("select * from vw_product where qty <= reorder and qty = 0 ", dgvcritstock)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If dtmp1.Value > dtmp2.Value Then
            MsgBox("Invalid Date", vbExclamation)
        Else
            Call connect()
            Call loader("Select * FROM tbl_payment WHERE pdate BETWEEN  = '" & dtmp1.Text & "' AND  '" & dtmp2.Text & "'", dgvsalesinvent)
        End If

    End Sub
End Class