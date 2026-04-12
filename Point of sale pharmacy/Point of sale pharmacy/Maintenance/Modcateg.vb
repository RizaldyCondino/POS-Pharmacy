Imports MySql.Data.MySqlClient
Module Modcateg
    Public Sub savecateg(ByVal sql As String)
        Try

            Call connect()
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("category", Frm_Classification_Entry.txtCategory.Text)

            End With

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try

    End Sub

    Public Sub savebrand(ByVal sql As String)
        Try
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("brand", frm_brand_Entry.txtCategory.Text)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try


    End Sub

    Public Sub savegeneric(ByVal sql As String)
        Try
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("generic", Frm_Generic_Entry.txtCategory.Text)

            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            GC.Collect()

        End Try
    End Sub

    Public Sub saveType(ByVal sql As String)
        Try
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("type", Frm_Types_Entry.txtCategory.Text)

            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try

    End Sub
    Public Sub saveformulation(ByVal sql As String)
        Try
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("formulation", frm_Formulation_Entry.txtCategory.Text)

            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub


    Public Sub savediscount(ByVal sql As String)
        Try
            Call connect()
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("Description", Frm_maintenance.txtDescriptiondis.Text)
                .AddWithValue("discount", Frm_maintenance.txtDiscount.Text)

            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub
End Module
