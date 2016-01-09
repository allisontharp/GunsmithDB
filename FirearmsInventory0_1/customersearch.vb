Public Class customersearch
    Public cid

    Private Sub customersearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        allcb.Checked = True
    End Sub


    Private Sub allcb_CheckedChanged(sender As Object, e As EventArgs) Handles allcb.CheckedChanged
        If allcb.Checked Then
            firstnamecb.Checked = True
            lastnamecb.Checked = True
            companycb.Checked = True
            address1cb.Checked = True
            address2cb.Checked = True
            citycb.Checked = True
            statecb.Checked = True
            zipcb.Checked = True
            licensenumcb.Checked = True
        Else
            firstnamecb.Checked = False
            lastnamecb.Checked = False
            companycb.Checked = False
            address1cb.Checked = False
            address2cb.Checked = False
            citycb.Checked = False
            statecb.Checked = False
            zipcb.Checked = False
            licensenumcb.Checked = False
        End If
    End Sub

    Private Sub customerselect_Click(sender As Object, e As EventArgs) Handles customerselect.Click
        ' NEED TO ADD ERROR MESSAGE
        Dim i As Integer

        i = acq_grid.CurrentRow.Index

        cid = acq_grid.Item(0, i).Value


        Form1.SCcustomer_id.Text = acq_grid.Item(0, i).Value
        Form1.SCfname.Text = acq_grid.Item(1, i).Value
        Form1.SClname.Text = acq_grid.Item(2, i).Value

        If acq_grid.Item(3, i).Value IsNot DBNull.Value Then
            Form1.SCcompany.Text = acq_grid.Item(3, i).Value
        End If

        If acq_grid.Item(4, i).Value IsNot DBNull.Value Then
            Form1.SCaddress1.Text = acq_grid.Item(4, i).Value
        End If

        If acq_grid.Item(5, i).Value IsNot DBNull.Value Then
            Form1.SCaddress2.Text = acq_grid.Item(5, i).Value
        End If

        If acq_grid.Item(6, i).Value IsNot DBNull.Value Then
            Form1.SCcity.Text = acq_grid.Item(6, i).Value
        End If

        If acq_grid.Item(7, i).Value IsNot DBNull.Value Then
            Form1.SCstate.Text = acq_grid.Item(7, i).Value
        End If

        If acq_grid.Item(8, i).Value IsNot DBNull.Value Then
            Form1.SCzip.Text = acq_grid.Item(8, i).Value
        End If

        If acq_grid.Item(9, i).Value IsNot DBNull.Value Then
            Form1.SCphonenumber.Text = acq_grid.Item(9, i).Value
        End If

        If acq_grid.Item(10, i).Value IsNot DBNull.Value Then
            Form1.SClicensenum.Text = acq_grid.Item(10, i).Value
        End If




        Form1.Sfname.Text = acq_grid.Item(1, i).Value
        Form1.Slname.Text = acq_grid.Item(2, i).Value

        If acq_grid.Item(3, i).Value IsNot DBNull.Value Then
            Form1.Scname.Text = acq_grid.Item(3, i).Value
        End If

        If acq_grid.Item(4, i).Value IsNot DBNull.Value Then
            Form1.Saddress1.Text = acq_grid.Item(4, i).Value
        End If

        If acq_grid.Item(5, i).Value IsNot DBNull.Value Then
            Form1.Saddress2.Text = acq_grid.Item(5, i).Value
        End If

        If acq_grid.Item(6, i).Value IsNot DBNull.Value Then
            Form1.Scity.Text = acq_grid.Item(6, i).Value
        End If

        If acq_grid.Item(7, i).Value IsNot DBNull.Value Then
            Form1.Sstate.Text = acq_grid.Item(7, i).Value
        End If

        If acq_grid.Item(8, i).Value IsNot DBNull.Value Then
            Form1.Szip.Text = acq_grid.Item(8, i).Value
        End If

        If acq_grid.Item(9, i).Value IsNot DBNull.Value Then
            Form1.Sphone.Text = acq_grid.Item(9, i).Value
        End If

        If acq_grid.Item(10, i).Value IsNot DBNull.Value Then
            Form1.Slicensenum.Text = acq_grid.Item(10, i).Value
        End If

        Me.Close()
    End Sub

    Private Sub filterbtn_Click(sender As Object, e As EventArgs) Handles showbtn.Click
        acq_grid.Columns("FirstName").Visible = firstnamecb.Checked
        acq_grid.Columns("LastName").Visible = lastnamecb.Checked
        acq_grid.Columns("Company").Visible = companycb.Checked
        acq_grid.Columns("address1").Visible = address1cb.Checked
        acq_grid.Columns("address2").Visible = address2cb.Checked
        acq_grid.Columns("city").Visible = citycb.Checked
        acq_grid.Columns("state").Visible = statecb.Checked
        acq_grid.Columns("zip").Visible = zipcb.Checked
        acq_grid.Columns("licensenum").Visible = licensenumcb.Checked

    End Sub

    Private Sub customeredit_Click(sender As Object, e As EventArgs) Handles customeredit.Click
        Dim obj As New customeredit

        Dim i As Integer = acq_grid.CurrentRow.Index



        obj.SCcustomer_id.Text = acq_grid.Item(0, i).Value
        obj.CEfname.Text = acq_grid.Item(1, i).Value
        obj.CElname.Text = acq_grid.Item(2, i).Value
        '  obj.SCcompany.Text = acq_grid.Item(3, i).Value
        obj.SCaddress1.Text = acq_grid.Item(4, i).Value
        '  obj.SCaddress2.Text = acq_grid.Item(5, i).Value
        obj.SCcity.Text = acq_grid.Item(6, i).Value
        obj.SCstate.Text = acq_grid.Item(7, i).Value
        obj.SCzip.Text = acq_grid.Item(8, i).Value
        obj.SCPhonenumber.Text = acq_grid.Item(9, i).Value
        obj.SClicensenum.Text = acq_grid.Item(10, i).Value


        obj.Cfname.Text = acq_grid.Item(1, i).Value
        obj.Clname.Text = acq_grid.Item(2, i).Value
        ' obj.Ccname.Text = acq_grid.Item(3, i).Value
        obj.Caddress1.Text = acq_grid.Item(4, i).Value
        ' obj.Caddress2.Text = acq_grid.Item(5, i).Value
        obj.Ccity.Text = acq_grid.Item(6, i).Value
        obj.Cstate.Text = acq_grid.Item(7, i).Value
        obj.Czip.Text = acq_grid.Item(8, i).Value
        obj.Cphonenumber.Text = acq_grid.Item(9, i).Value
        obj.Clicensenum.Text = acq_grid.Item(10, i).Value

        Me.Close()
        obj.Show()
    End Sub

End Class