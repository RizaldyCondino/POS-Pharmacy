Imports MySql.Data.MySqlClient
Public Class Frm_POS

    Private Sub Frm_POS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        lblid.Text = ""
        Call connect()

        invoicess()
        getvat()
        btnDiscount.Enabled = False
        btnSettle.Enabled = False
        If lblinvoiceNum.Text = "00000000000" Then
            btnProd.Enabled = False
        Else
            btnProd.Enabled = True

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewtransac.Click
        'invoicenum()



        invoicess()
        Frm_Quantity.loaderdgvcart()
        dgvproduct.Rows.Clear()
     

    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        numberonly(e)

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If lblinvoiceNum.Text = "00000000000" Then
            MsgBox("Add New transaction First ", vbCritical, "INVOICE")
            Me.txtBarcode.Text = ""
        Else
            loadprodbarcode()
        End If


    End Sub

    Public Sub loadprodbarcode()
        Try
            Call connect()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("SELECT * FROM tbl_product WHERE barcode = " & Val(txtBarcode.Text).ToString & "", con)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then

                lbltotal.Text = CDbl(dt.Rows(0)(8).ToString)
                lblid.Text = dt.Rows(0)(0).ToString
                Frm_Quantity.ShowDialog()


            End If
            Return
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub invoicess()
        Try
            Call connect()
            Dim adate As String = Now.ToString("yyyyMMdd")
            Dim dtt As String = "000"

            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("SELECT cartID,invoice  FROM tbl_cart WHERE invoice like '%" & adate & "%' ORDER BY cartID DESC LIMIT 1", con)
            'ORDER BY cartID DESC LIMIT 1
            da.Fill(dt)

            Select Case dt.Rows.Count
                Case Is = Nothing
                    lblinvoiceNum.Text = adate & "001"
                Case Else
                    lblinvoiceNum.Text = dt.Rows(0)(1) + 1

            End Select


            btnProd.Enabled = True
            'Dim invoice As String = adate & dtt & count
            'lblinvoiceNum.Text = invoice

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproduct_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellClick


    End Sub

    Private Sub dgvproduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellContentClick

        Dim colName As String = dgvproduct.Columns(e.ColumnIndex).Name
        If dgvproduct.RowCount = 0 Then
        Else
            If colName = "columDelUpd" Then
                If MsgBox("Are you sure you want to Delete this Remove?", vbQuestion + vbYesNo, "Remove") = vbYes Then

                    Dim row As DataGridViewRow = dgvproduct.CurrentRow
                    Dim cmd As MySqlCommand
                 

                    cmd = New MySqlCommand("Delete from tbl_cart where cartID = " & row.Cells(1).Value & "", con)
                    cmd.ExecuteNonQuery()
                    dgvproduct.Rows.Clear()
                    Frm_Quantity.loaderdgvcart()

                End If
            End If
        End If

    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    'lbldate.Text = Now.ToLongDateString
    '    'lblTime.Text = Now.ToString("hh:mm:ss tt")

    'End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
       
    End Sub

    Private Sub btnClose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnClose.KeyDown
        Select e.KeyCode
            Case Keys.Escape
                If MsgBox("Are you sure you want to Close?", vbQuestion + vbYesNo, "CLOSE") = vbYes Then
                    Me.Dispose()
                End If
           
        End Select
        'e.Handled = True

    End Sub


    Private Sub btnSettle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSettle.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                frm_settle.ShowDialog()





        End Select
    End Sub

    Private Sub btnDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiscount.Click

    End Sub

    Private Sub btnDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnDiscount.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                frm_discount.lbldtotal.Text = CDbl(Me.lbldisplayotal.Text)
                frm_discount.lblDiscount.Text = "0.00"
                frm_discount.ShowDialog()

        End Select
    End Sub

    Private Sub BtnDailySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDailySales.Click

    End Sub

    Private Sub BtnDailySales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnDailySales.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F5
                    Frm_dailySales.ShowDialog()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSub.Click

    End Sub

    Private Sub lbldue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldue.Click

    End Sub
End Class