Public Class searchform
    Public cid As String

    Private Sub customerform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        allcb.Checked = True
    End Sub

    Private Sub selectbtn_Click(sender As Object, e As EventArgs) Handles selectbtn.Click
        ' NEED TO ADD ERROR MESSAGE
        Dim i As Integer

        i = acq_grid.CurrentRow.Index

        cid = acq_grid.Item(0, i).Value


        Form1.SCcustomer_id.Text = acq_grid.Item(0, i).Value
        Form1.SCfname.Text = acq_grid.Item(1, i).Value
        Form1.SClname.Text = acq_grid.Item(2, i).Value
        Form1.SCcompany.Text = acq_grid.Item(3, i).Value
        Form1.SCaddress1.Text = acq_grid.Item(4, i).Value
        Form1.SCaddress2.Text = acq_grid.Item(5, i).Value
        Form1.SCcity.Text = acq_grid.Item(6, i).Value
        Form1.SCstate.Text = acq_grid.Item(7, i).Value
        Form1.SCzip.Text = acq_grid.Item(8, i).Value
        Form1.SClicensenum.Text = acq_grid.Item(9, i).Value


        Form1.Sfname.Text = acq_grid.Item(1, i).Value
        Form1.Slname.Text = acq_grid.Item(2, i).Value
        Form1.Scname.Text = acq_grid.Item(3, i).Value
        Form1.Saddress1.Text = acq_grid.Item(4, i).Value
        Form1.Saddress2.Text = acq_grid.Item(5, i).Value
        Form1.Scity.Text = acq_grid.Item(6, i).Value
        Form1.Sstate.Text = acq_grid.Item(7, i).Value
        Form1.Szip.Text = acq_grid.Item(8, i).Value
        Form1.Slicensenum.Text = acq_grid.Item(9, i).Value

        Me.Close()

    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Dim i As Integer
        Dim obj As New customeredit


        i = acq_grid.CurrentRow.Index



        obj.SCcustomer_id.Text = acq_grid.Item(0, i).Value
        obj.CEfname.Text = acq_grid.Item(1, i).Value
        obj.CElname.Text = acq_grid.Item(2, i).Value
        obj.SCcompany.Text = acq_grid.Item(3, i).Value
        obj.SCaddress1.Text = acq_grid.Item(4, i).Value
        obj.SCaddress2.Text = acq_grid.Item(5, i).Value
        obj.SCcity.Text = acq_grid.Item(6, i).Value
        obj.SCstate.Text = acq_grid.Item(7, i).Value
        obj.SCzip.Text = acq_grid.Item(8, i).Value
        obj.SClicensenum.Text = acq_grid.Item(9, i).Value

        obj.Cfname.Text = acq_grid.Item(1, i).Value
        obj.Clname.Text = acq_grid.Item(2, i).Value
        obj.Ccname.Text = acq_grid.Item(3, i).Value
        obj.Caddress1.Text = acq_grid.Item(4, i).Value
        obj.Caddress2.Text = acq_grid.Item(5, i).Value
        obj.Ccity.Text = acq_grid.Item(6, i).Value
        obj.Cstate.Text = acq_grid.Item(7, i).Value
        obj.Czip.Text = acq_grid.Item(8, i).Value
        obj.Clicensenum.Text = acq_grid.Item(9, i).Value

        Me.Close()
        obj.Show()
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
            manufacturercb.Checked = True
            modelcb.Checked = True
            calibercb.Checked = True
            serialnumcb.Checked = True
            transdatecb.Checked = True
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
            manufacturercb.Checked = False
            modelcb.Checked = False
            calibercb.Checked = False
            serialnumcb.Checked = False
            transdatecb.Checked = False
        End If


    End Sub

    Private Sub filterbtn_Click(sender As Object, e As EventArgs) Handles filterbtn.Click
        acq_grid.Columns("FirstName").Visible = firstnamecb.Checked
        acq_grid.Columns("LastName").Visible = lastnamecb.Checked
        acq_grid.Columns("Company").Visible = companycb.Checked
        acq_grid.Columns("address1").Visible = address1cb.Checked
        acq_grid.Columns("address2").Visible = address2cb.Checked
        acq_grid.Columns("city").Visible = citycb.Checked
        acq_grid.Columns("state").Visible = statecb.Checked
        acq_grid.Columns("zip").Visible = zipcb.Checked
        acq_grid.Columns("licensenum").Visible = licensenumcb.Checked
        acq_grid.Columns("Manufacturer").Visible = manufacturercb.Checked

        acq_grid.Columns("Model").Visible = modelcb.Checked
        acq_grid.Columns("Caliber").Visible = calibercb.Checked
        acq_grid.Columns("SerialNumber").Visible = serialnumcb.Checked
        acq_grid.Columns("transaction_date").Visible = transdatecb.Checked
    End Sub

End Class