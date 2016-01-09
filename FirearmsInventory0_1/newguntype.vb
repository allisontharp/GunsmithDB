Imports MySql.Data.MySqlClient

Public Class newguntype
    Public conn As New MySqlConnection
    Public constr As String = "database=firearms;data source=76.74.170.191;" _
        & "user id=vb;password=zsxdcf"

    Private Sub newguntyppeform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conn = New MySqlConnection
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub guntypesubmit_Click(sender As Object, e As EventArgs) Handles guntypesubmit.Click
        'TODO pop up to make sure user wants to add gun type
        Dim query As String = "INSERT INTO "
        Dim changes As String = "Add:" + vbCrLf + guntextbox.Text

        If gunlabel.Text = "Manufacturer:" Then
            query += "manufacturers VALUES (NULL, @name)"
            changes += " to manufacturers?"
        ElseIf gunlabel.Text = "Manufacturer Country:" Then
            query += "mancountry VALUES (NULL, @name)"
            changes += " to manufacturer country?"
        ElseIf gunlabel.Text = "Caliber:" Then
            query += "caliber VALUES (NULL, @name)"
            changes += " to calibers?"
        ElseIf gunlabel.Text = "Model:" Then
            query += "models VALUES (NULL, @manufacturer, @name)"

        End If


        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@name", guntextbox.Text)

        If gunlabel.Text = "Model:" Then
            Dim query2 As String = "SELECT man_id FROM manufacturers WHERE name = @manufacturer"
            Dim cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@manufacturer", Amanufacturers.SelectedValue)
            Dim reader As MySqlDataReader = cmd2.ExecuteReader()
            changes += " by " + Amanufacturers.SelectedValue + " to models?"
            While reader.Read()
                Dim man_id As String = reader.GetString(0)
                cmd.Parameters.AddWithValue("@manufacturer", man_id)
            End While

            reader.Close()
        End If

        changes += vbCrLf + vbCrLf + "Continue?"
        Dim response = MsgBox(changes, vbYesNo)
        If response = vbYes Then
            Try
                cmd.ExecuteNonQuery()

                Me.Close()
                MsgBox("submitted")

            Catch ex As MySqlException
                MsgBox(ex.ToString())
            Finally
                conn.Close()
            End Try
        End If



    End Sub
End Class