Imports MySql.Data.MySqlClient
Public Class frm_discount

    Private Sub cmbDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDiscount.KeyPress

    End Sub

    Private Sub cmbDiscount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDiscount.SelectedIndexChanged
        loaddiscount()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Dispose()

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        If MsgBox("Are you sure you want to select this discount?", vbQuestion + vbYesNo, "SELECT") = vbYes Then
            Frm_POS.lblDisc.Text = Format(CDbl(lblDiscount.Text) * CDbl(lbldtotal.Text), "#,##0.00 ")
            Frm_Quantity.loaderdgvcart()
            Me.Dispose()

        End If


    End Sub

    Private Sub frm_discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
        Call loadcomb("Select * from tbl_discount ", "description", "discountID", cmbDiscount)


    End Sub


    Public Sub loaddiscount()
        Try
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_discount where discountID = " & cmbDiscount.SelectedValue & "", con)
            da.Fill(dt)
            lblDiscount.Text = dt.Rows(0)(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btnsave_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Btnsave.ControlAdded

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class