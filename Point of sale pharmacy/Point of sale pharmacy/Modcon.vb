Imports MySql.Data.MySqlClient
Module Modcon
    Public con As MySqlConnection
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable
    Public ii As Integer = 0


    Public Sub connect()
        Try

            con = New MySqlConnection
            con.ConnectionString = "server=localhost;user=root;password=;database=pospharmacy"
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()


        End Try

    End Sub
    Public Sub imp()

    End Sub
    Public Sub getvat()
        Try
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter("Select * from tbl_vat ", con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
            Else
                Frm_maintenance.txtVat.Text = dt.Rows(0)(0)
                Frm_POS.txtVat.Text = dt.Rows(0)(0)
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try


    End Sub



    Public Sub loader(ByVal sql As String, ByVal dgv As DataGridView)
        Try

            Dim da As MySqlDataAdapter
            da = New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        Finally
            GC.Collect()

        End Try


    End Sub


  



    Public Sub Ldailytots()
        'Try
        '    Dim da As MySqlDataAdapter
        '    Dim dt As New DataTable
        '    da = New MySqlDataAdapter(, con)
        '    da.Fill(dt)



        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub

    Function getdata(ByVal sql As String) As Double


        cmd = New MySqlCommand(sql, con)
        getdata = CDbl(cmd.ExecuteScalar)

        Return getdata
    End Function

    Public Sub numberonly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then
            Else

                e.Handled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub




    Public Sub keyprexnum(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal text As TextBox)
        Dim allowed As String = "0123456789."
        If allowed.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If text.Text.Length >= 50 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub


    Public Sub keyprexvat(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal text As TextBox)
        Dim allowed As String = "0123456789."
        If allowed.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If text.Text.Length >= 5 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub


    Public Function validaterecords(ByVal sql As String) As Boolean
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            validaterecords = True
            MsgBox("Warning Duplicate Records", vbCritical, "DUPLICATE RECORDS")
        Else
            validaterecords = False

        End If
    End Function


    Public Sub loadcomb(ByVal sql As String, ByVal dmen As String, ByVal vmen As String, ByVal cb As ComboBox)
        Try

            Call connect()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cb.DataSource = dt
            cb.DisplayMember = dmen
            cb.ValueMember = vmen
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub


    Public Function IS_EMPTY(ByVal stext As Object) As Boolean
        On Error Resume Next
        If stext = "" Then
            IS_EMPTY = True
            MsgBox("Warning:Required missing Fields", vbCritical, "WARNING")
            stext.focus()
            stext.Backcolor = Color.LemonChiffon
        Else
            IS_EMPTY = False
            stext.Backcolor = Color.White
        End If

    End Function

    Public Function IS_EMPTY(ByVal stext As Object, ByVal stext1 As Object) As Boolean
        On Error Resume Next
        If stext = "" Then
            IS_EMPTY = True
            MsgBox("Warning:Required missing Fields", vbCritical, "WARNING")
            stext1.Backcolor = Color.LemonChiffon
            stext1.focus()

        Else
            IS_EMPTY = False
            stext1.Backcolor = Color.White
        End If


    End Function
End Module
