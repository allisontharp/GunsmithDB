Imports MySql.Data.MySqlClient

Public Class newguntype
    Public conn As New MySqlConnection
    Public constr = Form1.constr

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
        ''TODO have dropdown select the new type added



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

        Try
            conn.Close()
        Catch ex As Exception
        End Try

        Try
            conn = New MySqlConnection
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

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



                If gunlabel.Text = "Manufacturer:" Then
                    Form1.cbfill("SELECT name FROM manufacturers", "manufacturers", "name", Form1.Amanufacturers)
                    Form1.Amanufacturers.SelectedValue = guntextbox.Text
                ElseIf gunlabel.Text = "Manufacturer Country:" Then
                    Form1.cbfill("SELECT name FROM mancountry", "mancountry", "name", Form1.Amancountry)
                    Form1.Amancountry.SelectedValue = guntextbox.Text
                ElseIf gunlabel.Text = "Caliber:" Then
                    Form1.cbfill("SELECT name FROM caliber", "caliber", "name", Form1.Acaliber)
                    Form1.Acaliber.SelectedValue = guntextbox.Text
                ElseIf gunlabel.Text = "Model:" Then
                    Form1.cbfill("SELECT name FROM manufacturers", "mancountry", "name", Form1.Amanufacturers)
                    Form1.Amanufacturers.SelectedValue = Amanufacturers.SelectedValue

                    Form1.cbfill("SELECT name FROM models WHERE man_id = '" + Amanufacturers.SelectedValue + "';", "models", "name", Form1.Amodel)
                    Form1.Amodel.SelectedValue = guntextbox.Text

                End If



                Me.Close()
                MsgBox("Submitted")

            Catch ex As MySqlException
                MsgBox(ex.ToString())
            Finally
                conn.Close()
            End Try
        End If



    End Sub
End Class