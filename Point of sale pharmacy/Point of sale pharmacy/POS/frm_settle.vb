Imports MySql.Data.MySqlClient
Public Class frm_settle

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If Me.txtCash.Text = String.Empty Or Frm_Quantity.txtQuantity.Text = "0.00" Then Return
                    If CDbl(txtCash.Text) < CDbl(lbldue.Text) Then
                        MsgBox("Insufficient", vbCritical, " ")
                    Else
                        If MsgBox("Are you sure you want to Save this Payment?", vbQuestion + vbYesNo, "PAYMENT") = vbYes Then
                            Call connect()
                            savepayment()
                            Frm_Quantity.loaderdgvcart()
                            'Call savepayment("insert into tbl_payment (invoice,subtotal,vat,discount,amountdue,pdate,user)values(?,?,?,?,?,?,?)")
                            minustock()
                            txtCash.Text = "0.00"
                            lblchange.Text = "0.00"
                            lbldue.Text = "0.00"
                            With Frm_POS
                                .invoicess()
                                .dgvproduct.Rows.Clear()
                                .lbltotal.Text = "0.00"
                                .lblDisc.Text = "0.00"
                                .lbldue.Text = "0.00"
                                .lblVat.Text = "0.00"
                                .lblSub.Text = "0.00"
                                .lbldisplayotal.Text = "0.00"
                                .lbltotal.Text = "0.00"
                                .btnDiscount.Enabled = False
                                .btnSettle.Enabled = False
                            End With

                            Me.Dispose()
                        End If
                    End If

                Case Keys.Escape
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress

        keyprexnum(e, txtCash)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        Try
            If txtCash.Text = String.Empty Or Frm_Quantity.txtQuantity.Text = "0.00" Then Return
            Dim change As Double = CDbl(txtCash.Text) - CDbl(lbldue.Text)
            If change < 0 Then
                lblchange.Text = "0.00"
            Else
                lblchange.Text = Format(change, "#,##0.00")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_settle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldue.Text = Frm_POS.lbldue.Text
        txtCash.Focus()
    End Sub



End Class