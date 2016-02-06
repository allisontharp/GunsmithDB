Imports MySql.Data.MySqlClient

Public Class customeredit
    Public conn

    Public constr = Form1.constr

    Private Sub customeredit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conn = New MySqlConnection
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub CEsubmit_Click(sender As Object, e As EventArgs) Handles CEsubmit.Click
        Dim query As String = "UPDATE customer SET"
        Dim check As Boolean = False
        Dim change As String = "Changes:" + vbCrLf

        If Not Cfname.Text = CEfname.Text Then
            If Not check Then
                query += " firstname = @firstname"
            Else
                query += " ,firstname = @firstname"
            End If
            check = True
            change += vbCrLf + "First name from " + CEfname.Text + " to " + Cfname.Text
        End If


        If Not Clname.Text = CElname.Text Then
            If Not check Then
                query += " lastname = @lastname"
            Else
                query += " ,lastname = @lastname"
            End If
            check = True
            change += vbCrLf + "Last name from " + CElname.Text + " to " + Clname.Text
        End If


        If Not Ccname.Text = SCcompany.Text And Not Ccname.Text = "" Then
            If Not check Then
                query += " company = @company"
            Else
                query += " ,company = @company"
            End If
            check = True
            change += vbCrLf + "Company from " + SCcompany.Text + " to " + Ccname.Text
        End If


        If Not Caddress1.Text = SCaddress1.Text Then
            If Not check Then
                query += " address1 = @address1"
            Else
                query += " ,address1 = @address1"
            End If
            check = True
            change += vbCrLf + "Address line 1 from " + SCaddress1.Text + " to " + Caddress1.Text
        End If

        If Not Caddress2.Text = SCaddress2.Text And Not Caddress2.Text = "" Then
            If Not check Then
                query += " address2 = @address2"
            Else
                query += " .address2 = @address2"
            End If
            check = True
            change += vbCrLf + "Address line 2 from " + SCaddress2.Text + " to " + Caddress2.Text
        End If


        If Not Ccity.Text = SCcity.Text Then
            If Not check Then
                query += " city = @city"
            Else
                query += " ,city = @city"
            End If
            check = True
            change += vbCrLf + "City from " + SCcity.Text + " to " + Ccity.Text
        End If


        If Not Cstate.Text = SCstate.Text Then
            If Not check Then
                query += " state = @state"
            Else
                query += " ,state = @state"
            End If
            check = True
            change += vbCrLf + "State from " + SCstate.Text + " to " + Cstate.Text
        End If

        If Not Czip.Text = SCzip.Text Then
            If Not check Then
                query += " zip = @zip"
            Else
                query += " ,zip = @zip"
            End If
            check = True
            change += vbCrLf + "Zipcode from " + SCzip.Text + " to " + Czip.Text
        End If

        If Not Clicensenum.Text = SClicensenum.Text Then
            If Not check Then
                query += " licensenum = @licensenum"
            Else
                query += " ,licensenum = @licensenum"
            End If
            check = True
            change += vbCrLf + "License number from " + SClicensenum.Text + " To " + Clicensenum.Text
        End If

        If Not Cphonenumber.Text = SCPhonenumber.Text Then
            If Not check Then
                query += " phone_number = @phone"
            Else
                query += " ,phone_number = @phone"
            End If
            check = True
            change += vbCrLf + "Phone number from " + SCPhonenumber.Text + " To " + Cphonenumber.Text
        End If


        query += " WHERE customer_id = @cid"


        Dim cmd = New MySqlCommand(query, conn)

        If Not Cfname.Text = CEfname.Text Then
            cmd.Parameters.AddWithValue("@firstname", Cfname.Text)
        End If

        If Not Clname.Text = SClicensenum.Text Then
            cmd.Parameters.AddWithValue("@lastname", Clname.Text)
        End If

        If Not Ccname.Text = SCcompany.Text Then
            cmd.Parameters.AddWithValue("@company", Ccname.Text)
        End If

        If Not Caddress1.Text = SCaddress1.Text Then
            cmd.Parameters.AddWithValue("@address1", Caddress1.Text)
        End If

        If Not Caddress2.Text = SCaddress2.Text Then
            cmd.Parameters.AddWithValue("@address2", Caddress2.Text)
        End If

        If Not Ccity.Text = SCcity.Text Then
            cmd.Parameters.AddWithValue("@city", Ccity.Text)
        End If

        If Not Cstate.Text = SCstate.Text Then
            cmd.Parameters.AddWithValue("@state", Cstate.Text)
        End If

        If Not Czip.Text = SCzip.Text Then
            cmd.Parameters.AddWithValue("@zip", Czip.Text)
        End If

        If Not Clicensenum.Text = SClicensenum.Text Then
            cmd.Parameters.AddWithValue("@licesenum", Clicensenum.Text)
        End If

        If Not Cphonenumber.Text = SCPhonenumber.Text Then
            cmd.Parameters.AddWithValue("@phone", Cphonenumber.Text)
        End If

        cmd.Parameters.AddWithValue("@cid", SCcustomer_id.Text)


        change += vbCrLf + vbCrLf + "Continue?"
        Dim response = MsgBox(change, vbYesNo)
        ' pop up box with changes to review before submitting
        If response = vbYes Then
            cmd.ExecuteNonQuery()

            conn.Close()

            MsgBox("Submitted")
            Form1.Csearchbtn.PerformClick()
            Me.Close()
        End If
    End Sub
End Class