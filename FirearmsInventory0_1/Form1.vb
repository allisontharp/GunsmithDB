Imports MySql.Data.MySqlClient

' should check which tab is selected for acquisition/disposition
Public Class Form1
    Public conn As New MySqlConnection
    'MySqlCommand It represents a SQL statement to execute against a MySQL Database
    Dim cmd As New MySqlCommand
    'Represents a set of data commands and a database connection that 
    'are used to fill a dataset and update a MySQL database. This class cannot be inherited.
    Dim da As New MySqlDataAdapter

    Public constr As String = "database=firearms;data source=76.74.170.191;" _
        & "user id=vb;password=zsxdcf"
    Public customer_id As String




    'Public Sub connect()
    '    Dim DatabaseName As String = "firearms"
    '    Dim server As String = "76.74.170.191"
    '    Dim userName As String = "vb"
    '    Dim password As String = "zsxdcf"
    '    If Not conn Is Nothing Then conn.Close()
    '    conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
    '    Try
    '        conn.Open()

    '        'MsgBox("Connected")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conn.Close()
    'End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim constr As String = "database=firearms;data source=76.74.170.191;" _
        '& "user id=vb;password=zsxdcf"
        Try
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        cbfill("SELECT name FROM type", "type", "name", Atype)
        cbfill("SELECT name FROM caliber", "caliber", "name", Acaliber)
        cbfill("SELECT name FROM category", "category", "name", Acategory)
        cbfill("SELECT name FROM manufacturers", "manufacturers", "name", Amanufacturers)
        cbfill("SELECT name FROM mancountry", "mancountry", "name", Amancountry)

        cbfill("SELECT name FROM type", "type", "name", Stype)
        cbfill("SELECT name FROM caliber", "caliber", "name", Scaliber)
        cbfill("SELECT name FROM category", "category", "name", Scat)
        cbfill("SELECT name FROM manufacturers", "manufacturers", "name", Smanufacturer)
        cbfill("SELECT name FROM mancountry", "mancountry", "name", Smancountry)

        cbfill("SELECT name FROM type", "type", "name", Dtype)
        cbfill("SELECT name FROM caliber", "caliber", "name", Dcaliber)
        cbfill("SELECT name FROM category", "category", "name", Dcategory)
        cbfill("SELECT name FROM manufacturers", "manufacturers", "name", Dmanufacturer)
        cbfill("SELECT name FROM mancountry", "mancountry", "name", Dmancountry)

        AAcquired.Value = DateTime.Now
        Atransdate.Value = DateTime.Now
        Adeadline.Value = DateTime.Now

        adeadline_no.Checked = True
        Adeadline.Visible = False

        scustomer_group.Visible = False

        allcb.Checked = True



    End Sub

    Public Sub cbfill(sStmt As String, table As String, row As String, combobox As ComboBox)
        Dim cmd As New MySqlCommand(sStmt, conn)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable(table)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            combobox.DataSource = dt
            combobox.DisplayMember = row 'What is displayed
            combobox.ValueMember = row 'The ID of the row
        End If



        combobox.SelectedIndex = -1
    End Sub



    Private Function mysqlquery(stmt As String)
        'Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        '& "User Id=vb;Password=zsxdcf"
        Try
            conn = New MySqlConnection(constr)
            conn.Open()

            'testbox.Text = stmt

            Dim cmd As MySqlCommand = New MySqlCommand(stmt, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            While reader.Read
                If IsDBNull(reader) Then
                    ' Anotes.Text = "its empty"
                    Return ("empty")
                Else
                    ' Anotes.Text = "it isn't empty " + reader.GetString(0)
                    Return reader.GetString(0)
                End If
            End While


        Catch ex As MySqlException
            TextBox1.Text = ex.ToString()
            Console.WriteLine("Error: " & ex.ToString())
            Return ex.ToString()
        Finally
            conn.Close()
        End Try
    End Function



    Public Sub mysqlsubmit(table As String, cols As String, val As String)
        Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        & "User Id=vb;Password=zsxdcf"
        Dim stm As String = "INSERT INTO " + table + " (" + cols + ") VALUES (" + val + ");"
        'testbox.Text = stm

        Try
            conn = New MySqlConnection(cs)
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            cmd.ExecuteScalar()


        Catch ex As MySqlException
            TextBox1.Text = ex.ToString()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CBAmanufacturers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Amanufacturers.SelectedIndexChanged
        Dim manufacturer As String
        'need to clear models when this changes
        Amodel.Text = String.Empty


        If Amanufacturers.SelectedIndex > 0 Then
            manufacturer = mysqlquery("SELECT man_id FROM manufacturers WHERE name = '" + Amanufacturers.SelectedValue + "';")

            cbfill("SELECT name FROM models WHERE man_id = '" + manufacturer + "';", "models", "name", Amodel)
        End If
    End Sub

    Private Sub Smanufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Smanufacturer.SelectedIndexChanged
        Dim manufacturer As String
        'need to clear models when this changes
        Amodel.Text = String.Empty


        If Smanufacturer.SelectedIndex > 0 Then
            manufacturer = mysqlquery("SELECT man_id FROM manufacturers WHERE name = '" + Smanufacturer.SelectedValue + "';")

            cbfill("SELECT name FROM models WHERE man_id = '" + manufacturer + "';", "models", "name", Smodel)
        End If
    End Sub

    Private Sub Caddbtn_Click(sender As Object, e As EventArgs) Handles Caddbtn.Click

        Dim errmsg As String = ""


        'If ACcompany.Text = "" Then
        '    If ACfname.Text = "" And AClname.Text = "" Then
        '        errmsg += vbCrLf + "Name"
        '    End If
        'End If

        'If Not ACfname.Text = "" Then
        '    If AClname.Text = "" Then
        '        errmsg += vbCrLf + "Last Name"
        '    End If
        'Else
        '    If Not AClname.Text = "" Then
        '        errmsg += vbCrLf + "First Name"
        '    End If
        'End If


        'If ACaddress1.Text = "" Then
        '    errmsg += vbCrLf + "Address"
        'End If

        'If ACcity.Text = "" Then
        '    errmsg += vbCrLf + "City"
        'End If

        'If ACstate.Text = "" Then
        '    errmsg += vbCrLf + "State"
        'End If

        'If ACzip.Text = "" Then
        '    errmsg += vbCrLf + "Zip"
        'End If

        'If AClicensenum.Text = "" Then
        '    errmsg += vbCrLf + "License Number"
        'End If


        If errmsg Is String.Empty Then
            conn.Open()
            ' search for the customer first
            Dim query As String = "SELECT firstname, lastname, address1, city, state, zip, licensenum, phone_number FROM customer WHERE licensenum like @licensenum"
            Dim cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@licensenum", AClicensenum.Text)




            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' duplicate license number
                MsgBox("Name was already found!", MsgBoxStyle.OkCancel)
                Aerror.Text = reader.GetString(0)


            Else
                'license number not found
                reader.Close()

                Aerror.Text = "license number not found"

                query = "SELECT firstname, lastname, address1, city, state, zip, licensenum, phone_number FROM customer WHERE firstname like @firstname AND lastname like @lastname"
                cmd = New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@firstname", ACfname.Text)
                cmd.Parameters.AddWithValue("@lastname", AClname.Text)


                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    'name found

                    ' change from msgbox to a box with buttons: edit customer, cancel
                    MsgBox("Customer already exists in the database.  Check the license number." + vbCrLf + vbCrLf + reader.GetString(0) + " " + reader.GetString(1) + vbCrLf + reader.GetString(2) + vbCrLf + reader.GetString(3) + ", " + reader.GetString(4) _
                           , MsgBoxStyle.YesNo)

                Else
                    'name not found, check address
                    reader.Close()

                    Aerror.Text = "license number not found, name not found"

                    query = "SELECT firstname, lastname, address1, city, state, zip, licensenum FROM customer WHERE address1 like @address1 AND city like @city AND state like @state AND zip LIKE @zip"
                    cmd = New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@address1", ACaddress1.Text)
                    cmd.Parameters.AddWithValue("@city", ACcity.Text)
                    cmd.Parameters.AddWithValue("@state", ACstate.Text)
                    cmd.Parameters.AddWithValue("@zip", ACzip.Text)

                    reader = cmd.ExecuteReader()

                    If reader.Read() Then
                        'address found
                        MsgBox("Customer already exists in the database with that license number and address.  Check the name and license number." + vbCrLf + vbCrLf + reader.GetString(0) + " " + reader.GetString(1) + vbCrLf + reader.GetString(2) + vbCrLf + reader.GetString(3) + ", " + reader.GetString(4) _
                           , MsgBoxStyle.YesNo)

                    Else
                        ' new customer!
                        reader.Close()

                        '!!!!! need to check somewhere before this to see if it was a customer or if it was a first/last name and do the appropriate things !!!!
                        query = "INSERT INTO customer (customer_id, firstname, lastname, address1, city, state, zip, phone_number, licensenum) VALUES 
                                (NULL, @firstname, @lastname, @address1, @city, @state, @zip, @phone_number, @licensenum)"
                        cmd = New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@firstname", ACfname.Text)
                        cmd.Parameters.AddWithValue("@lastname", AClname.Text)
                        cmd.Parameters.AddWithValue("@address1", ACaddress1.Text)
                        cmd.Parameters.AddWithValue("@city", ACcity.Text)
                        cmd.Parameters.AddWithValue("@state", ACstate.Text)
                        cmd.Parameters.AddWithValue("@zip", ACzip.Text)
                        cmd.Parameters.AddWithValue("@licensenum", AClicensenum.Text)
                        cmd.Parameters.AddWithValue("@phone_number", ACphone.Text)

                        Aerror.Text = query
                        cmd.ExecuteNonQuery()

                        conn.Close()

                        Aerror.Text = "submitted New customer"

                    End If


                End If


            End If

            reader.Close()
        Else
                Aerror.Text = "The following need To be completed:    " + errmsg
        End If
    End Sub

    Private Sub Asubmit_Click(sender As Object, e As EventArgs) Handles Asubmit.Click
        Dim aqc_date As String = AAcquired.ToString
        Dim type_id As String = mysqlquery("select type_id from type where name =  '" + Atype.SelectedValue + "';")
        Dim cal_id As String = mysqlquery("select cal_id from caliber where name = '" + Acaliber.SelectedValue + "';")
        Dim man_id As String = mysqlquery("select man_id from manufacturers where name = '" + Amanufacturers.SelectedValue + "';")
        Dim model_id As String = mysqlquery("select model_id from models where name = '" + Amodel.SelectedValue + "';")
        Dim mancountry_id As String = mysqlquery("select mancountry_id from mancountry where name = '" + Amancountry.SelectedValue + "';")
        Dim cat_id As String = mysqlquery("select cat_id from category where name = '" + Acategory.SelectedValue + "';")

        Dim errmsg As String = ""


        ' check that required things are filled out, vbcr if label, vbcrlf if textobx
        If SCcustomer_id.Text = "cid" Then
            errmsg += vbCrLf + "Select Customer"
        End If

        If cat_id Is Nothing Then
            errmsg += vbCrLf + "category"
        End If

        If type_id Is Nothing Then
            errmsg += vbCrLf + "type"
        End If

        If cal_id Is Nothing Then
            errmsg += vbCrLf + "caliber"
        End If

        If man_id Is Nothing Then
            errmsg += vbCrLf + "manufacturer"
        End If

        If model_id Is Nothing Then
            errmsg += vbCrLf + "model"
        End If

        If mancountry_id Is Nothing Then
            errmsg += vbCrLf + "manufacturer country"
        End If


        If Aserialnum.Text = "" Then
            errmsg += vbCrLf + "serial number"
        End If



        If SCfname.Text = "" And SClname.Text = "" And SCcompany.Text = "" Then
            errmsg += vbCrLf + "first name and last name or company name"
        ElseIf SCfname.Text = "" And Not SClname.Text = "" Then
            errmsg += "first name"
        ElseIf SClname.Text = "" And Not SCfname.Text = "" Then
            errmsg += "last name"
        End If




        If errmsg Is String.Empty Then
            conn.Open()
            'Dim query As String = "INSERT INTO gun (gun_id, type_id, cal_id, man_id, model_id, mancountry_id, serialnum, date_entered, year, cat_id, deadline, note) VALUES 
            '   (NULL, @type_id, @cal_id, @man_id, @model_id, @mancountry_id, @serialnum, NOW(), @year, @cat_id, @deadline, @note)"
            Dim query As String = "INSERT INTO gun (gun_id, type_id, cal_id, man_id, model_id, mancountry_id, serialnum, date_entered, cat_id"

            If Not Ayear.Text = "" Then
                query += ", year"
            End If

            If adeadline_yes.Checked Then
                query += ", deadline"
            End If

            If Not Anotes.Text = "" Then
                query += ", note"
            End If

            query += ") VALUES (NULL, @type_id, @cal_id, @man_id, @model_id, @mancountry_id, @serialnum, NOW(), @cat_id"

            If Not Ayear.Text = "" Then
                query += ", @year"
            End If

            If adeadline_yes.Checked Then
                query += ", @deadline"
            End If

            If Not Anotes.Text = "" Then
                query += ", @note"
            End If

            query += ")"

            testbox.Text = query
            Dim cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@type_id", type_id)
            cmd.Parameters.AddWithValue("@cal_id", cal_id)
            cmd.Parameters.AddWithValue("@man_id", man_id)
            cmd.Parameters.AddWithValue("@model_id", model_id)
            cmd.Parameters.AddWithValue("@mancountry_id", mancountry_id)
            cmd.Parameters.AddWithValue("@serialnum", Aserialnum.Text)
            cmd.Parameters.AddWithValue("@cat_id", cat_id)
            cmd.Parameters.AddWithValue("@deadline", Adeadline.Value)
            cmd.Parameters.AddWithValue("@note", Anotes.Text)
            cmd.Parameters.AddWithValue("@year", Ayear.Text)

            cmd.ExecuteNonQuery()

            query = "Select LAST_INSERT_ID()"
            cmd = New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim gun_id As String

            While reader.Read()
                gun_id = reader.GetString(0)
            End While

            reader.Close()

            testbox.Text = gun_id

            query = "INSERT INTO acquisition (acq_id, acq_date, customer_id, gun_id, transaction_date, date_entered) VALUES
                        (NULL, @acq_date, @customer_id, @gun_id, @transaction_date, NOW())"

            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@acq_date", AAcquired.Value)
            cmd.Parameters.AddWithValue("@customer_id", SCcustomer_id.Text)
            cmd.Parameters.AddWithValue("@gun_id", gun_id)
            cmd.Parameters.AddWithValue("@transaction_date", Atransdate.Value)

            cmd.ExecuteNonQuery()



            conn.Close()

            Aerror.Text = "submitted"
        Else
            Aerror.Text = "The following need to be completed:  " + errmsg
        End If




    End Sub

    Private Sub Csearch_Click(sender As Object, e As EventArgs) Handles Ssearch.Click
        'Dim query As String = "SELECT customer.customer_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
        '                        customer.address2, customer.city, customer.state, customer.zip, customer.licensenum, customer.phone_number,
        '                        manufacturers.name AS Manufacturer, models.name AS Model, caliber.name AS Caliber, gun.serialnum AS SerialNumber, 
        '                        acquisition.transaction_date FROM gun 
        '                        LEFT JOIN acquisition 
        '                                INNER JOIN customer ON acquisition.customer_id = customer.customer_id  
        '                        ON gun.gun_id = acquisition.gun_id 
        '                        LEFT JOIN manufacturers ON gun.man_id = manufacturers.man_id 
        '                        LEFT JOIN models ON gun.model_id = models.model_id 
        '                        LEFT JOIN category ON gun.cat_id = category.cat_id
        '                        LEFT JOIN type ON gun.type_id = type.type_id
        '                        LEFT JOIN mancountry ON gun.mancountry_id = mancountry.mancountry_id
        '                        LEFT JOIN caliber ON gun.cal_id = caliber.cal_id WHERE "

        Dim query As String = "SELECT customer.customer_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
                                customer.address2, customer.city, customer.state, customer.zip, customer.licensenum, customer.phone_number,
                                manufacturers.name AS Manufacturer, models.name AS Model, caliber.name AS Caliber, gun.serialnum AS SerialNumber, 
                                acquisition.transaction_date FROM gun 
                                LEFT JOIN acquisition 
                                        INNER JOIN customer ON acquisition.customer_id = customer.customer_id  
                                ON gun.gun_id = acquisition.gun_id  
                                LEFT JOIN disposition ON gun.gun_id = disposition.gun_id 
                                LEFT JOIN manufacturers ON gun.man_id = manufacturers.man_id 
                                LEFT JOIN models ON gun.model_id = models.model_id 
                                LEFT JOIN category ON gun.cat_id = category.cat_id
                                LEFT JOIN type ON gun.type_id = type.type_id
                                LEFT JOIN mancountry ON gun.mancountry_id = mancountry.mancountry_id
                                LEFT JOIN caliber ON gun.cal_id = caliber.cal_id 
                                WHERE disposition.gun_id IS NULL 
                                "
        'Dim obj As New search
        Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        Dim check As Boolean = True


        If Not Sfname.Text = "" Then
            If Not check Then
                query += " firstname LIKE @firstname"
            Else
                query += " AND firstname LIKE @firstname"
            End If
            check = True
        End If

        If Not Slname.Text = "" Then
            If Not check Then
                query += " lastname LIKE @lastname"
            Else
                query += " AND lastname LIKE @lastname"
            End If
            check = True
        End If

        If Not Scname.Text = "" Then
            If Not check Then
                query += " company LIKE @company"
            Else
                query += " AND company LIKE @company"
            End If
            check = True
        End If

        If Not Saddress1.Text = "" Then
            If Not check Then
                query += " address1 LIKE @address1"
            Else
                query += " AND address1 LIKE @address1"
            End If
            check = True
        End If

        If Not Saddress2.Text = "" Then
            If Not check Then
                query += " address2 LIKE @address2"
            Else
                query += " AND address2 LIKE @address2"
            End If
            check = True
        End If

        If Not Scity.Text = "" Then
            If Not check Then
                query += " city LIKE @city"
            Else
                query += " AND city LIKE @city"
            End If
            check = True
        End If

        If Not Sstate.Text = "" Then
            If Not check Then
                query += " state LIKE @state"
            Else
                query += " AND state LIKE @state"
            End If
            check = True
        End If

        If Not Szip.Text = "" Then
            If Not check Then
                query += " zip LIKE @zip"
            Else
                query += " AND zip LIKE @zip"
            End If
            check = True
        End If

        If Not Slicensenum.Text = "" Then
            If Not check Then
                query += " licensenum LIKE @licensenum"
            Else
                query += " AND licensenum LIKE @licensenum"
            End If
            check = True
        End If

        If Not Sphone.Text = "" Then
            If Not check Then
                query += " phone_number LIKE @phone_number"
            Else
                query += " AND phone_number LIKE @phone_number"
            End If
            check = True
        End If

        If Not Scat.Text = "" Then
            If Not check Then
                query += " category.name LIKE @scat"
            Else
                query += " AND category.name LIKE @scat"
            End If
            check = True
        End If

        If Not Stype.Text = "" Then
            If Not check Then
                query += " type.name LIKE @stype"
            Else
                query += " AND type.name LIKE @stype"
            End If
            check = True
        End If

        If Not Scaliber.Text = "" Then
            If Not check Then
                query += " caliber.name LIKE @scaliber"
            Else
                query += " AND caliber.name LIKE @scaliber"
            End If
            check = True
        End If

        If Not Smanufacturer.Text = "" Then
            If Not check Then
                query += " manufacturers.name LIKE @smanufacturer"
            Else
                query += " AND manufacturers.name LIKE @smanufacturer"
            End If
            check = True
        End If

        If Not Smodel.Text = "" Then
            If Not check Then
                query += " models.name LIKE @smodel"
            Else
                query += " AND models.name LIKE @smodel"
            End If
            check = True
        End If

        If Not Smancountry.Text = "" Then
            If Not check Then
                query += " mancountry.name LIKE @smancountry"
            Else
                query += " AND mancountry.name LIKE @smancountry"
            End If
            check = True
        End If

        If Not Syear.Text = "" Then
            If Not check Then
                query += " gun.year LIKE @syear"
            Else
                query += " AND gun.year LIKE @syear"
            End If
            check = True
        End If

        If Not Spurchase_price.Text = "" Then
            If Not check Then
                query += " acquisition.purchase_price LIKE @spurchase_price"
            Else
                query += " AND acquisition.purchase_price LIKE @spurchase_price"
            End If
            check = True
        End If

        If Not Sserialnum.Text = "" Then
            If Not check Then
                query += " gun.serialnum LIKE @sserialnum"
            Else
                query += " AND gun.serialnum LIKE @sserialnum"
            End If
            check = True
        End If





        adap = New MySqlDataAdapter(query, conn)

        If Not Sfname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@firstname", "%" + Sfname.Text + "%")
        End If

        If Not Slname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@lastname", "%" + Slname.Text + "%")
        End If

        If Not Scname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@company", "%" + Scname.Text + "%")
        End If

        If Not Saddress1.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address1", "%" + Saddress1.Text + "%")
        End If

        If Not Saddress2.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address2", "%" + Saddress2.Text + "%")
        End If

        If Not Scity.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@city", "%" + Scity.Text + "%")
        End If

        If Not Sstate.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@state", "%" + Sstate.Text + "%")
        End If

        If Not Szip.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@zip", "%" + Szip.Text + "%")
        End If

        If Not Slicensenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@licensenum", "%" + Slicensenum.Text + "%")
        End If

        If Not Sphone.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@phone_number", "%" + Sphone.Text + "%")
        End If

        If Not Scat.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scat", "%" + Scat.Text + "%")
        End If

        If Not Stype.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@stype", "%" + Stype.Text + "%")
        End If

        If Not Scaliber.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scaliber", "%" + Scaliber.Text + "%")
        End If

        If Not Smanufacturer.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smanufacturer", "%" + Smanufacturer.Text + "%")
        End If

        If Not Smodel.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smodel", "%" + Smodel.Text + "%")
        End If

        If Not Smancountry.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smancountry", "%" + Smancountry.Text + "%")
        End If

        If Not Syear.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@syear", "%" + Syear.Text + "%")
        End If

        If Not Spurchase_price.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@spurchase_price", "%" + Spurchase_price.Text + "%")
        End If

        If Not Sserialnum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@sserialnum", "%" + Sserialnum.Text + "%")
        End If


        '   testbox.Text = query

        Try
            adap.Fill(ds)

            'obj.acq_grid.DataSource = ds.Tables(0)
            acq_grid.DataSource = ds.Tables(0)
            ds = Nothing
            da = Nothing
            'obj.acq_grid.Columns("customer_id").Visible = False
            acq_grid.Columns("customer_id").Visible = False
            conn.Close()
            conn.Dispose()

            'obj.Show()

        Catch ex As MySqlException
            'testbox.Text = ex.ToString()
        Finally
            ' conn.Close()
        End Try

        adap = New MySqlDataAdapter(query, conn)
        ds = New DataSet()

        query = "SELECT customer.customer_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
                        customer.address2, customer.city, customer.state, customer.zip, customer.licensenum, customer.phone_number,
                        manufacturers.name AS Manufacturer, models.name AS Model, caliber.name AS Caliber, gun.serialnum AS SerialNumber, 
                        disposition.transaction_date FROM gun 
                        LEFT JOIN disposition 
                                INNER JOIN customer ON disposition.customer_id = customer.customer_id  
                        ON gun.gun_id = disposition.gun_id  
                        LEFT JOIN manufacturers ON gun.man_id = manufacturers.man_id 
                        LEFT JOIN models ON gun.model_id = models.model_id 
                        LEFT JOIN category ON gun.cat_id = category.cat_id
                        LEFT JOIN type ON gun.type_id = type.type_id
                        LEFT JOIN mancountry ON gun.mancountry_id = mancountry.mancountry_id
                        LEFT JOIN caliber ON gun.cal_id = caliber.cal_id 
                        WHERE 
                        "
        check = False


        If Not Sfname.Text = "" Then
            If Not check Then
                query += " firstname LIKE @firstname"
            Else
                query += " AND firstname LIKE @firstname"
            End If
            check = True
        End If

        If Not Slname.Text = "" Then
            If Not check Then
                query += " lastname LIKE @lastname"
            Else
                query += " AND lastname LIKE @lastname"
            End If
            check = True
        End If

        If Not Scname.Text = "" Then
            If Not check Then
                query += " company LIKE @company"
            Else
                query += " AND company LIKE @company"
            End If
            check = True
        End If

        If Not Saddress1.Text = "" Then
            If Not check Then
                query += " address1 LIKE @address1"
            Else
                query += " AND address1 LIKE @address1"
            End If
            check = True
        End If

        If Not Saddress2.Text = "" Then
            If Not check Then
                query += " address2 LIKE @address2"
            Else
                query += " AND address2 LIKE @address2"
            End If
            check = True
        End If

        If Not Scity.Text = "" Then
            If Not check Then
                query += " city LIKE @city"
            Else
                query += " AND city LIKE @city"
            End If
            check = True
        End If

        If Not Sstate.Text = "" Then
            If Not check Then
                query += " state LIKE @state"
            Else
                query += " AND state LIKE @state"
            End If
            check = True
        End If

        If Not Szip.Text = "" Then
            If Not check Then
                query += " zip LIKE @zip"
            Else
                query += " AND zip LIKE @zip"
            End If
            check = True
        End If

        If Not Slicensenum.Text = "" Then
            If Not check Then
                query += " licensenum LIKE @licensenum"
            Else
                query += " AND licensenum LIKE @licensenum"
            End If
            check = True
        End If

        If Not Sphone.Text = "" Then
            If Not check Then
                query += " phone_number LIKE @phone_number"
            Else
                query += " AND phone_number LIKE @phone_number"
            End If
            check = True
        End If

        If Not Scat.Text = "" Then
            If Not check Then
                query += " category.name LIKE @scat"
            Else
                query += " AND category.name LIKE @scat"
            End If
            check = True
        End If

        If Not Stype.Text = "" Then
            If Not check Then
                query += " type.name LIKE @stype"
            Else
                query += " AND type.name LIKE @stype"
            End If
            check = True
        End If

        If Not Scaliber.Text = "" Then
            If Not check Then
                query += " caliber.name LIKE @scaliber"
            Else
                query += " AND caliber.name LIKE @scaliber"
            End If
            check = True
        End If

        If Not Smanufacturer.Text = "" Then
            If Not check Then
                query += " manufacturers.name LIKE @smanufacturer"
            Else
                query += " AND manufacturers.name LIKE @smanufacturer"
            End If
            check = True
        End If

        If Not Smodel.Text = "" Then
            If Not check Then
                query += " models.name LIKE @smodel"
            Else
                query += " AND models.name LIKE @smodel"
            End If
            check = True
        End If

        If Not Smancountry.Text = "" Then
            If Not check Then
                query += " mancountry.name LIKE @smancountry"
            Else
                query += " AND mancountry.name LIKE @smancountry"
            End If
            check = True
        End If

        If Not Syear.Text = "" Then
            If Not check Then
                query += " gun.year LIKE @syear"
            Else
                query += " AND gun.year LIKE @syear"
            End If
            check = True
        End If

        If Not Spurchase_price.Text = "" Then
            If Not check Then
                query += " acquisition.purchase_price LIKE @spurchase_price"
            Else
                query += " AND acquisition.purchase_price LIKE @spurchase_price"
            End If
            check = True
        End If

        If Not Sserialnum.Text = "" Then
            If Not check Then
                query += " gun.serialnum LIKE @sserialnum"
            Else
                query += " AND gun.serialnum LIKE @sserialnum"
            End If
            check = True
        End If





        adap = New MySqlDataAdapter(query, conn)

        If Not Sfname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@firstname", "%" + Sfname.Text + "%")
        End If

        If Not Slname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@lastname", "%" + Slname.Text + "%")
        End If

        If Not Scname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@company", "%" + Scname.Text + "%")
        End If

        If Not Saddress1.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address1", "%" + Saddress1.Text + "%")
        End If

        If Not Saddress2.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address2", "%" + Saddress2.Text + "%")
        End If

        If Not Scity.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@city", "%" + Scity.Text + "%")
        End If

        If Not Sstate.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@state", "%" + Sstate.Text + "%")
        End If

        If Not Szip.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@zip", "%" + Szip.Text + "%")
        End If

        If Not Slicensenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@licensenum", "%" + Slicensenum.Text + "%")
        End If

        If Not Sphone.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@phone_number", "%" + Sphone.Text + "%")
        End If

        If Not Scat.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scat", "%" + Scat.Text + "%")
        End If

        If Not Stype.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@stype", "%" + Stype.Text + "%")
        End If

        If Not Scaliber.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scaliber", "%" + Scaliber.Text + "%")
        End If

        If Not Smanufacturer.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smanufacturer", "%" + Smanufacturer.Text + "%")
        End If

        If Not Smodel.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smodel", "%" + Smodel.Text + "%")
        End If

        If Not Smancountry.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smancountry", "%" + Smancountry.Text + "%")
        End If

        If Not Syear.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@syear", "%" + Syear.Text + "%")
        End If

        If Not Spurchase_price.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@spurchase_price", "%" + Spurchase_price.Text + "%")
        End If

        If Not Sserialnum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@sserialnum", "%" + Sserialnum.Text + "%")
        End If


        '   testbox.Text = query

        Try
            adap.Fill(ds)

            'obj.acq_grid.DataSource = ds.Tables(0)
            dis_grid.DataSource = ds.Tables(0)
            ds = Nothing
            da = Nothing
            'obj.acq_grid.Columns("customer_id").Visible = False
            dis_grid.Columns("customer_id").Visible = False
            conn.Close()
            conn.Dispose()

            'obj.Show()

        Catch ex As MySqlException
            'testbox.Text = ex.ToString()
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub Sclear_Click(sender As Object, e As EventArgs) Handles Sclear.Click
        Sfname.Text = ""
        Slname.Text = ""
        Scname.Text = ""
        Saddress1.Text = ""
        Saddress2.Text = ""
        Scity.Text = ""
        Sstate.Text = ""
        Szip.Text = ""
        Slicensenum.Text = ""
        Sphone.Text = ""
        Scat.SelectedIndex = -1
        Stype.SelectedIndex = -1
        Scaliber.SelectedIndex = -1
        Smanufacturer.SelectedIndex = -1
        Smodel.SelectedIndex = -1
        Smancountry.SelectedIndex = -1
        Syear.Text = ""
        Spurchase_price.Text = ""
        Sserialnum.Text = ""

        SCfname.Text = "N/A"
        SClname.Text = "N/A"
        SCcompany.Text = "N/A"
        SCcustomer_id.Text = "N/A"
        SCaddress1.Text = "N/A"
        SCaddress2.Text = "N/A"
        SCcity.Text = "N/A"
        SCstate.Text = "N/A"
        SCzip.Text = "N/A"
        SClicensenum.Text = "N/A"
        SCphonenumber.Text = "N/A"

    End Sub

    Private Sub Aclear_Click(sender As Object, e As EventArgs) Handles Aclear.Click
        AAcquired.Value = DateTime.Now
        Atransdate.Value = DateTime.Now
        Adeadline.Value = DateTime.Now

        adeadline_no.Checked = True

        Aerror.Text = ""

        Acategory.SelectedIndex = -1
        Atype.SelectedIndex = -1
        Acaliber.SelectedIndex = -1
        Amanufacturers.SelectedIndex = -1
        Amodel.SelectedIndex = -1
        Anotes.Text = ""
        Amancountry.SelectedIndex = -1
        Ayear.Text = ""
        APrice.Text = ""
        Aserialnum.Text = ""

        ACfname.Text = ""
        AClname.Text = ""
        ACcompany.Text = ""
        ACaddress1.Text = ""
        ACaddress2.Text = ""
        ACcity.Text = ""
        ACstate.Text = ""
        ACzip.Text = ""
        AClicensenum.Text = ""
        ACphone.Text = ""

        SCfname.Text = "N/A"
        SClname.Text = "N/A"
        SCcompany.Text = "N/A"
        SCcustomer_id.Text = "N/A"
        SCaddress1.Text = "N/A"
        SCaddress2.Text = "N/A"
        SCcity.Text = "N/A"
        SCstate.Text = "N/A"
        SCzip.Text = "N/A"
        SClicensenum.Text = "N/A"
        SCphonenumber.Text = "N/A"


    End Sub

    Private Sub Acustomer_Click(sender As Object, e As EventArgs)
        scustomer_group.Visible = True
    End Sub

    Private Sub TabPage1_Leave(sender As Object, e As EventArgs)
        scustomer_group.Visible = False
    End Sub

    Private Sub Csearchbtn_Click(sender As Object, e As EventArgs) Handles Csearchbtn.Click
        Dim query As String = "SELECT customer.customer_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
                                customer.address2, customer.city, customer.state, customer.zip, customer.phone_number AS phone, customer.licensenum FROM customer WHERE "
        Dim obj As New customersearch
        Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        Dim check As Boolean = False


        If Not ACfname.Text = "" Then
            If Not check Then
                query += " firstname LIKE @firstname"
            Else
                query += " And firstname Like @firstname"
            End If
            check = True
        End If

        If Not AClname.Text = "" Then
            If Not check Then
                query += " lastname Like @lastname"
            Else
                query += " And lastname Like @lastname"
            End If
            check = True
        End If

        If Not ACcompany.Text = "" Then
            If Not check Then
                query += " company Like @company"
            Else
                query += " And company Like @company"
            End If
            check = True
        End If

        If Not ACaddress1.Text = "" Then
            If Not check Then
                query += " address1 Like @address1"
            Else
                query += " And address1 Like @address1"
            End If
            check = True
        End If

        If Not ACaddress2.Text = "" Then
            If Not check Then
                query += " address2 Like @address2"
            Else
                query += " And address2 Like @address2"
            End If
            check = True
        End If

        If Not ACcity.Text = "" Then
            If Not check Then
                query += " city Like @city"
            Else
                query += " And city Like @city"
            End If
            check = True
        End If

        If Not ACstate.Text = "" Then
            If Not check Then
                query += " state Like @state"
            Else
                query += " And state Like @state"
            End If
            check = True
        End If

        If Not ACzip.Text = "" Then
            If Not check Then
                query += " zip Like @zip"
            Else
                query += " And zip Like @zip"
            End If
            check = True
        End If

        If Not AClicensenum.Text = "" Then
            If Not check Then
                query += " licensenum Like @licensenum"
            Else
                query += " And licensenum Like @licensenum"
            End If
            check = True
        End If

        If Not ACphone.Text = "" Then
            If Not check Then
                query += " phone_number Like @phone_number"
            Else
                query += " And phone_number Like @phone_number"
            End If
            check = True
        End If

        adap = New MySqlDataAdapter(query, conn)

        If Not ACfname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@firstname", "%" + ACfname.Text + "%")
        End If

        If Not AClname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@lastname", "%" + AClname.Text + "%")
        End If

        If Not ACcompany.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@company", "%" + ACcompany.Text + "%")
        End If

        If Not ACaddress1.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address1", "%" + ACaddress1.Text + "%")
        End If

        If Not ACaddress2.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address2", "%" + ACaddress2.Text + "%")
        End If

        If Not ACcity.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@city", "%" + ACcity.Text + "%")
        End If

        If Not ACstate.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@state", "%" + ACstate.Text + "%")
        End If

        If Not ACzip.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@zip", "%" + ACzip.Text + "%")
        End If

        If Not AClicensenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@licensenum", "%" + AClicensenum.Text + "%")
        End If

        If Not ACphone.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@phone_number", "%" + ACphone.Text + "%")
        End If


        testbox.Text = query

        Try
            adap.Fill(ds)

            ' obj.acq_grid.DataSource = ds.Tables(0)
            csearch_grid.DataSource = ds.Tables(0)
            ds = Nothing
            da = Nothing
            ' obj.acq_grid.Columns("customer_id").Visible = False
            csearch_grid.Columns("customer_id").Visible = False
            conn.Close()
            conn.Dispose()

            ' obj.Show()

        Catch ex As MySqlException
            ' testbox.Text = ex.ToString()
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        scustomer_group.Visible = False
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        scustomer_group.Visible = False
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        scustomer_group.Visible = True
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
        acq_grid.Columns("Manufacturer").Visible = manufacturercb.Checked

        acq_grid.Columns("Model").Visible = modelcb.Checked
        acq_grid.Columns("Caliber").Visible = calibercb.Checked
        acq_grid.Columns("SerialNumber").Visible = serialnumcb.Checked
        acq_grid.Columns("transaction_date").Visible = transdatecb.Checked
    End Sub

    Private Sub Dsearchbtn_Click(sender As Object, e As EventArgs)
        Dim query As String = "SELECT customer.customer_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
                                customer.address2, customer.city, customer.state, customer.zip, customer.licensenum, customer.phone_number,
                                manufacturers.name AS Manufacturer, models.name AS Model, caliber.name AS Caliber, gun.serialnum AS SerialNumber, 
                                acquisition.transaction_date FROM gun 
                                LEFT JOIN acquisition 
                                        INNER JOIN customer ON acquisition.customer_id = customer.customer_id  
                                ON gun.gun_id = acquisition.gun_id 
                                LEFT JOIN manufacturers ON gun.man_id = manufacturers.man_id 
                                LEFT JOIN models ON gun.model_id = models.model_id 
                                LEFT JOIN category ON gun.cat_id = category.cat_id
                                LEFT JOIN type ON gun.type_id = type.type_id
                                LEFT JOIN mancountry ON gun.mancountry_id = mancountry.mancountry_id
                                LEFT JOIN caliber ON gun.cal_id = caliber.cal_id WHERE "

        Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        Dim check As Boolean = False


        If Not Dfname.Text = "" Then
            If Not check Then
                query += " firstname LIKE @firstname"
            Else
                query += " AND firstname LIKE @firstname"
            End If
            check = True
        End If

        If Not Dlname.Text = "" Then
            If Not check Then
                query += " lastname LIKE @lastname"
            Else
                query += " AND lastname LIKE @lastname"
            End If
            check = True
        End If

        If Not Dcompany.Text = "" Then
            If Not check Then
                query += " company LIKE @company"
            Else
                query += " AND company LIKE @company"
            End If
            check = True
        End If

        If Not Daddress1.Text = "" Then
            If Not check Then
                query += " address1 LIKE @address1"
            Else
                query += " AND address1 LIKE @address1"
            End If
            check = True
        End If

        If Not Daddress2.Text = "" Then
            If Not check Then
                query += " address2 LIKE @address2"
            Else
                query += " AND address2 LIKE @address2"
            End If
            check = True
        End If

        If Not Dcity.Text = "" Then
            If Not check Then
                query += " city LIKE @city"
            Else
                query += " AND city LIKE @city"
            End If
            check = True
        End If

        If Not Dstate.Text = "" Then
            If Not check Then
                query += " state LIKE @state"
            Else
                query += " AND state LIKE @state"
            End If
            check = True
        End If

        If Not Dzip.Text = "" Then
            If Not check Then
                query += " zip LIKE @zip"
            Else
                query += " AND zip LIKE @zip"
            End If
            check = True
        End If

        If Not Dlicensenum.Text = "" Then
            If Not check Then
                query += " licensenum LIKE @licensenum"
            Else
                query += " AND licensenum LIKE @licensenum"
            End If
            check = True
        End If

        If Not Dphonenum.Text = "" Then
            If Not check Then
                query += " phone_number LIKE @phone_number"
            Else
                query += " AND phone_number LIKE @phone_number"
            End If
            check = True
        End If

        If Not Dcategory.Text = "" Then
            If Not check Then
                query += " category.name LIKE @scat"
            Else
                query += " AND category.name LIKE @scat"
            End If
            check = True
        End If

        If Not Dtype.Text = "" Then
            If Not check Then
                query += " type.name LIKE @stype"
            Else
                query += " AND type.name LIKE @stype"
            End If
            check = True
        End If

        If Not Dcaliber.Text = "" Then
            If Not check Then
                query += " caliber.name LIKE @scaliber"
            Else
                query += " AND caliber.name LIKE @scaliber"
            End If
            check = True
        End If

        If Not Dmanufacturer.Text = "" Then
            If Not check Then
                query += " manufacturers.name LIKE @smanufacturer"
            Else
                query += " AND manufacturers.name LIKE @smanufacturer"
            End If
            check = True
        End If

        If Not Dmodel.Text = "" Then
            If Not check Then
                query += " models.name LIKE @smodel"
            Else
                query += " AND models.name LIKE @smodel"
            End If
            check = True
        End If

        If Not Dmancountry.Text = "" Then
            If Not check Then
                query += " mancountry.name LIKE @smancountry"
            Else
                query += " AND mancountry.name LIKE @smancountry"
            End If
            check = True
        End If

        If Not Dyear.Text = "" Then
            If Not check Then
                query += " gun.year LIKE @syear"
            Else
                query += " AND gun.year LIKE @syear"
            End If
            check = True
        End If

        If Not Dpurchase_price.Text = "" Then
            If Not check Then
                query += " acquisition.purchase_price LIKE @spurchase_price"
            Else
                query += " AND acquisition.purchase_price LIKE @spurchase_price"
            End If
            check = True
        End If

        If Not Dserialnum.Text = "" Then
            If Not check Then
                query += " gun.serialnum LIKE @sserialnum"
            Else
                query += " AND gun.serialnum LIKE @sserialnum"
            End If
            check = True
        End If





        adap = New MySqlDataAdapter(query, conn)

        If Not Dfname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@firstname", "%" + Dfname.Text + "%")
        End If

        If Not Dlname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@lastname", "%" + Dlname.Text + "%")
        End If

        If Not Dcompany.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@company", "%" + Dcompany.Text + "%")
        End If

        If Not Daddress1.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address1", "%" + Daddress1.Text + "%")
        End If

        If Not Daddress2.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address2", "%" + Daddress2.Text + "%")
        End If

        If Not Dcity.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@city", "%" + Dcity.Text + "%")
        End If

        If Not Dstate.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@state", "%" + Dstate.Text + "%")
        End If

        If Not Dzip.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@zip", "%" + Dzip.Text + "%")
        End If

        If Not Dlicensenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@licensenum", "%" + Dlicensenum.Text + "%")
        End If

        If Not Dphonenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@phone_number", "%" + Dphonenum.Text + "%")
        End If

        If Not Dcategory.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scat", "%" + Dcategory.Text + "%")
        End If

        If Not Dtype.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@stype", "%" + Dtype.Text + "%")
        End If

        If Not Dcaliber.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scaliber", "%" + Dcaliber.Text + "%")
        End If

        If Not Dmanufacturer.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smanufacturer", "%" + Dmanufacturer.Text + "%")
        End If

        If Not Dmodel.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smodel", "%" + Dmodel.Text + "%")
        End If

        If Not Dmancountry.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smancountry", "%" + Dmancountry.Text + "%")
        End If

        If Not Dyear.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@syear", "%" + Dyear.Text + "%")
        End If

        If Not Dpurchase_price.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@spurchase_price", "%" + Dpurchase_price.Text + "%")
        End If

        If Not Dserialnum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@sserialnum", "%" + Dserialnum.Text + "%")
        End If


        '   testbox.Text = query

        Try
            adap.Fill(ds)

            dsearch_grid.DataSource = ds.Tables(0)
            ds = Nothing
            da = Nothing
            dsearch_grid.Columns("customer_id").Visible = False
            conn.Close()
            conn.Dispose()

        Catch ex As MySqlException
            'testbox.Text = ex.ToString()
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub csearch_grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles csearch_grid.CellDoubleClick
        SelectCustomerAcqFunction()
    End Sub

    Private Sub csearch_grid_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles csearch_grid.CellMouseDown
        If (e.Button = MouseButtons.Right) Then

            AcqStrip.Show(MousePosition.X, MousePosition.Y)

        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        SelectCustomerAcqFunction()
    End Sub

    Private Sub SelectCustomerAcqFunction()
        Dim i As Integer

        i = csearch_grid.CurrentRow.Index

        Dim cid As String = csearch_grid.Item(0, i).Value


        SCcustomer_id.Text = csearch_grid.Item(0, i).Value
        SCfname.Text = csearch_grid.Item(1, i).Value
        SClname.Text = csearch_grid.Item(2, i).Value

        If csearch_grid.Item(3, i).Value IsNot DBNull.Value Then
            SCcompany.Text = csearch_grid.Item(3, i).Value
        End If

        If csearch_grid.Item(4, i).Value IsNot DBNull.Value Then
            SCaddress1.Text = csearch_grid.Item(4, i).Value
        End If

        If csearch_grid.Item(5, i).Value IsNot DBNull.Value Then
            SCaddress2.Text = csearch_grid.Item(5, i).Value
        End If

        If csearch_grid.Item(6, i).Value IsNot DBNull.Value Then
            SCcity.Text = csearch_grid.Item(6, i).Value
        End If

        If csearch_grid.Item(7, i).Value IsNot DBNull.Value Then
            SCstate.Text = csearch_grid.Item(7, i).Value
        End If

        If csearch_grid.Item(8, i).Value IsNot DBNull.Value Then
            SCzip.Text = csearch_grid.Item(8, i).Value
        End If

        If csearch_grid.Item(9, i).Value IsNot DBNull.Value Then
            SCphonenumber.Text = csearch_grid.Item(9, i).Value
        End If

        If csearch_grid.Item(10, i).Value IsNot DBNull.Value Then
            SClicensenum.Text = csearch_grid.Item(10, i).Value
        End If




        Sfname.Text = csearch_grid.Item(1, i).Value
        Slname.Text = csearch_grid.Item(2, i).Value

        If csearch_grid.Item(3, i).Value IsNot DBNull.Value Then
            Scname.Text = csearch_grid.Item(3, i).Value
        End If

        If csearch_grid.Item(4, i).Value IsNot DBNull.Value Then
            Saddress1.Text = csearch_grid.Item(4, i).Value
        End If

        If csearch_grid.Item(5, i).Value IsNot DBNull.Value Then
            Saddress2.Text = csearch_grid.Item(5, i).Value
        End If

        If csearch_grid.Item(6, i).Value IsNot DBNull.Value Then
            Scity.Text = csearch_grid.Item(6, i).Value
        End If

        If csearch_grid.Item(7, i).Value IsNot DBNull.Value Then
            Sstate.Text = csearch_grid.Item(7, i).Value
        End If

        If csearch_grid.Item(8, i).Value IsNot DBNull.Value Then
            Szip.Text = csearch_grid.Item(8, i).Value
        End If

        If csearch_grid.Item(9, i).Value IsNot DBNull.Value Then
            Sphone.Text = csearch_grid.Item(9, i).Value
        End If

        If csearch_grid.Item(10, i).Value IsNot DBNull.Value Then
            Slicensenum.Text = csearch_grid.Item(10, i).Value
        End If
    End Sub

    Private Sub EditCustomerFunction()
        Dim obj As New customeredit

        Dim i As Integer = csearch_grid.CurrentRow.Index



        obj.SCcustomer_id.Text = csearch_grid.Item(0, i).Value

        If csearch_grid.Item(1, i).Value IsNot DBNull.Value Then
            obj.CEfname.Text = csearch_grid.Item(1, i).Value
        End If

        If csearch_grid.Item(2, i).Value IsNot DBNull.Value Then
            obj.CElname.Text = csearch_grid.Item(2, i).Value
        End If

        If csearch_grid.Item(3, i).Value IsNot DBNull.Value Then
            obj.SCcompany.Text = csearch_grid.Item(3, i).Value
        End If

        If csearch_grid.Item(4, i).Value IsNot DBNull.Value Then
            obj.SCaddress1.Text = csearch_grid.Item(4, i).Value
        End If

        If csearch_grid.Item(5, i).Value IsNot DBNull.Value Then
            obj.SCaddress2.Text = csearch_grid.Item(5, i).Value
        End If

        If csearch_grid.Item(6, i).Value IsNot DBNull.Value Then
            obj.SCcity.Text = csearch_grid.Item(6, i).Value
        End If

        If csearch_grid.Item(7, i).Value IsNot DBNull.Value Then
            obj.SCstate.Text = csearch_grid.Item(7, i).Value
        End If

        If csearch_grid.Item(8, i).Value IsNot DBNull.Value Then
            obj.SCzip.Text = csearch_grid.Item(8, i).Value
        End If

        If csearch_grid.Item(9, i).Value IsNot DBNull.Value Then
            obj.SCPhonenumber.Text = csearch_grid.Item(9, i).Value
        End If

        If csearch_grid.Item(10, i).Value IsNot DBNull.Value Then
            obj.SClicensenum.Text = csearch_grid.Item(10, i).Value
        End If




        obj.Cfname.Text = csearch_grid.Item(1, i).Value

        If csearch_grid.Item(2, i).Value IsNot DBNull.Value Then
            obj.Clname.Text = csearch_grid.Item(2, i).Value
        End If

        If csearch_grid.Item(3, i).Value IsNot DBNull.Value Then
            obj.Ccname.Text = csearch_grid.Item(3, i).Value
        End If

        If csearch_grid.Item(4, i).Value IsNot DBNull.Value Then
            obj.Caddress1.Text = csearch_grid.Item(4, i).Value
        End If

        If csearch_grid.Item(5, i).Value IsNot DBNull.Value Then
            obj.Caddress2.Text = csearch_grid.Item(5, i).Value
        End If

        If csearch_grid.Item(6, i).Value IsNot DBNull.Value Then
            obj.Ccity.Text = csearch_grid.Item(6, i).Value
        End If

        If csearch_grid.Item(7, i).Value IsNot DBNull.Value Then
            obj.Cstate.Text = csearch_grid.Item(7, i).Value
        End If

        If csearch_grid.Item(8, i).Value IsNot DBNull.Value Then
            obj.Czip.Text = csearch_grid.Item(8, i).Value
        End If

        If csearch_grid.Item(9, i).Value IsNot DBNull.Value Then
            obj.Cphonenumber.Text = csearch_grid.Item(9, i).Value
        End If

        If csearch_grid.Item(10, i).Value IsNot DBNull.Value Then
            obj.Clicensenum.Text = csearch_grid.Item(10, i).Value
        End If


        obj.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        EditCustomerFunction()
    End Sub

    Private Sub adeadline_yes_CheckedChanged(sender As Object, e As EventArgs) Handles adeadline_yes.CheckedChanged
        adeadline_no.Checked = Not adeadline_yes.Checked

        If adeadline_yes.Checked Then
            Adeadline.Visible = True
        Else
            Adeadline.Visible = False
        End If
    End Sub

    Private Sub Amanufacturers_TextChanged(sender As Object, e As EventArgs) Handles Amanufacturers.TextChanged
        Dim query As String = "INSERT INTO manufacturers (man_id, name) VALUES (NULL, @name)"
        Dim cmd = New MySqlCommand(query, conn)

        ' check to make sure new manufacturer isn't in the db


        'cmd.Parameters.AddWithValue("@name", Amanufacturers.Text)
        'cmd.ExecuteNonQuery()



    End Sub

    Private Sub Dsearchbtn_Click_1(sender As Object, e As EventArgs) Handles Dsearchbtn.Click
        'select acquisitions of guns that haven't had disposition

        Dim query As String = "SELECT customer.customer_id, gun.gun_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
                                customer.address2, customer.city, customer.state, customer.zip, customer.licensenum, customer.phone_number,
                                manufacturers.name AS Manufacturer, models.name AS Model, caliber.name AS Caliber, gun.serialnum AS SerialNumber, 
                                acquisition.transaction_date FROM gun 
                                LEFT JOIN acquisition 
                                        INNER JOIN customer ON acquisition.customer_id = customer.customer_id  
                                ON gun.gun_id = acquisition.gun_id  
                                LEFT JOIN disposition ON gun.gun_id = disposition.gun_id 
                                LEFT JOIN manufacturers ON gun.man_id = manufacturers.man_id 
                                LEFT JOIN models ON gun.model_id = models.model_id 
                                LEFT JOIN category ON gun.cat_id = category.cat_id
                                LEFT JOIN type ON gun.type_id = type.type_id
                                LEFT JOIN mancountry ON gun.mancountry_id = mancountry.mancountry_id
                                LEFT JOIN caliber ON gun.cal_id = caliber.cal_id 
                                WHERE disposition.gun_id IS NULL 
                                "


        Dim obj As New search
        Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        Dim check As Boolean = True


        If Not Dfname.Text = "" Then
            If Not check Then
                query += " firstname LIKE @firstname"
            Else
                query += " AND firstname LIKE @firstname"
            End If
            check = True
        End If

        If Not Dlname.Text = "" Then
            If Not check Then
                query += " lastname LIKE @lastname"
            Else
                query += " AND lastname LIKE @lastname"
            End If
            check = True
        End If

        If Not Dcompany.Text = "" Then
            If Not check Then
                query += " company LIKE @company"
            Else
                query += " AND company LIKE @company"
            End If
            check = True
        End If

        If Not Daddress1.Text = "" Then
            If Not check Then
                query += " address1 LIKE @address1"
            Else
                query += " AND address1 LIKE @address1"
            End If
            check = True
        End If

        If Not Daddress2.Text = "" Then
            If Not check Then
                query += " address2 LIKE @address2"
            Else
                query += " AND address2 LIKE @address2"
            End If
            check = True
        End If

        If Not Dcity.Text = "" Then
            If Not check Then
                query += " city LIKE @city"
            Else
                query += " AND city LIKE @city"
            End If
            check = True
        End If

        If Not Dstate.Text = "" Then
            If Not check Then
                query += " state LIKE @state"
            Else
                query += " AND state LIKE @state"
            End If
            check = True
        End If

        If Not Dzip.Text = "" Then
            If Not check Then
                query += " zip LIKE @zip"
            Else
                query += " AND zip LIKE @zip"
            End If
            check = True
        End If

        If Not Dlicensenum.Text = "" Then
            If Not check Then
                query += " licensenum LIKE @licensenum"
            Else
                query += " AND licensenum LIKE @licensenum"
            End If
            check = True
        End If

        If Not Dphonenum.Text = "" Then
            If Not check Then
                query += " phone_number LIKE @phone_number"
            Else
                query += " AND phone_number LIKE @phone_number"
            End If
            check = True
        End If

        If Not Dcategory.Text = "" Then
            If Not check Then
                query += " category.name LIKE @scat"
            Else
                query += " AND category.name LIKE @scat"
            End If
            check = True
        End If

        If Not Dtype.Text = "" Then
            If Not check Then
                query += " type.name LIKE @stype"
            Else
                query += " AND type.name LIKE @stype"
            End If
            check = True
        End If

        If Not Dcaliber.Text = "" Then
            If Not check Then
                query += " caliber.name LIKE @scaliber"
            Else
                query += " AND caliber.name LIKE @scaliber"
            End If
            check = True
        End If

        If Not Dmanufacturer.Text = "" Then
            If Not check Then
                query += " manufacturers.name LIKE @smanufacturer"
            Else
                query += " AND manufacturers.name LIKE @smanufacturer"
            End If
            check = True
        End If

        If Not Dmodel.Text = "" Then
            If Not check Then
                query += " models.name LIKE @smodel"
            Else
                query += " AND models.name LIKE @smodel"
            End If
            check = True
        End If

        If Not Dmancountry.Text = "" Then
            If Not check Then
                query += " mancountry.name LIKE @smancountry"
            Else
                query += " AND mancountry.name LIKE @smancountry"
            End If
            check = True
        End If

        If Not Dyear.Text = "" Then
            If Not check Then
                query += " gun.year LIKE @syear"
            Else
                query += " AND gun.year LIKE @syear"
            End If
            check = True
        End If

        If Not Dpurchase_price.Text = "" Then
            If Not check Then
                query += " acquisition.purchase_price LIKE @spurchase_price"
            Else
                query += " AND acquisition.purchase_price LIKE @spurchase_price"
            End If
            check = True
        End If

        If Not Dserialnum.Text = "" Then
            If Not check Then
                query += " gun.serialnum LIKE @sserialnum"
            Else
                query += " AND gun.serialnum LIKE @sserialnum"
            End If
            check = True
        End If





        adap = New MySqlDataAdapter(query, conn)

        If Not Dfname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@firstname", "%" + Dfname.Text + "%")
        End If

        If Not Dlname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@lastname", "%" + Dlname.Text + "%")
        End If

        If Not Dcompany.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@company", "%" + Dcompany.Text + "%")
        End If

        If Not Daddress1.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address1", "%" + Daddress1.Text + "%")
        End If

        If Not Daddress2.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address2", "%" + Daddress2.Text + "%")
        End If

        If Not Dcity.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@city", "%" + Dcity.Text + "%")
        End If

        If Not Dstate.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@state", "%" + Dstate.Text + "%")
        End If

        If Not Dzip.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@zip", "%" + Dzip.Text + "%")
        End If

        If Not Dlicensenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@licensenum", "%" + Dlicensenum.Text + "%")
        End If

        If Not Dphonenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@phone_number", "%" + Dphonenum.Text + "%")
        End If

        If Not Dcategory.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scat", "%" + Dcategory.Text + "%")
        End If

        If Not Dtype.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@stype", "%" + Dtype.Text + "%")
        End If

        If Not Dcaliber.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scaliber", "%" + Dcaliber.Text + "%")
        End If

        If Not Dmanufacturer.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smanufacturer", "%" + Dmanufacturer.Text + "%")
        End If

        If Not Dmodel.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smodel", "%" + Dmodel.Text + "%")
        End If

        If Not Dmancountry.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smancountry", "%" + Dmancountry.Text + "%")
        End If

        If Not Dyear.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@syear", "%" + Dyear.Text + "%")
        End If

        If Not Dpurchase_price.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@spurchase_price", "%" + Dpurchase_price.Text + "%")
        End If

        If Not Dserialnum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@sserialnum", "%" + Dserialnum.Text + "%")
        End If


        Try
            adap.Fill(ds)

            dsearch_grid.DataSource = ds.Tables(0)
            ds = Nothing
            da = Nothing
            dsearch_grid.Columns("customer_id").Visible = False
            dsearch_grid.Columns("gun_id").Visible = False
            conn.Close()
            conn.Dispose()

        Catch ex As MySqlException
            'testbox.Text = ex.ToString()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Dclearbtn.Click
        Dfname.Text = ""
        Dlname.Text = ""
        Dcompany.Text = ""
        Daddress1.Text = ""
        Daddress2.Text = ""
        Dcity.Text = ""
        Dstate.Text = ""
        Dzip.Text = ""
        Dlicensenum.Text = ""
        Dphonenum.Text = ""

        Dcategory.SelectedIndex = -1
        Dtype.SelectedIndex = -1
        Dcaliber.SelectedIndex = -1
        Dmanufacturer.SelectedIndex = -1
        Dmodel.SelectedIndex = -1
        Dyear.Text = ""
        Dpurchase_price.Text = ""
        Dserialnum.Text = ""

        DSCfname.Text = "N/A"
        DSClicensenum.Text = "N/A"
        DSCcompany.Text = "N/A"
        DSCaddress1.Text = "N/A"
        DSCaddress2.Text = "N/A"
        DSCcity.Text = "N/A"
        DSCstate.Text = "N/A"
        DSCzip.Text = "N/A"
        DSClicensenum.Text = "N/A"
        DSCphone.Text = "N/A"

        DSGmanufacturer.Text = "N/A"
        DSGmodel.Text = "N/A"
        DSGserialnum.Text = "N/A"

    End Sub

    Private Sub SelectAcquisitionDisp()
        Dim i As Integer

        i = dsearch_grid.CurrentRow.Index

        Dim cid As String = dsearch_grid.Item(0, i).Value


        SCcustomer_id.Text = dsearch_grid.Item(0, i).Value
        gunid.Text = dsearch_grid.Item(1, i).Value
        DSCfname.Text = dsearch_grid.Item(2, i).Value
        DSClname.Text = dsearch_grid.Item(3, i).Value


        If dsearch_grid.Item(4, i).Value IsNot DBNull.Value Then
            DSCcompany.Text = dsearch_grid.Item(4, i).Value
        End If

        If dsearch_grid.Item(5, i).Value IsNot DBNull.Value Then
            DSCaddress1.Text = dsearch_grid.Item(5, i).Value
        End If

        If dsearch_grid.Item(6, i).Value IsNot DBNull.Value Then
            DSCaddress2.Text = dsearch_grid.Item(6, i).Value
        End If

        If dsearch_grid.Item(7, i).Value IsNot DBNull.Value Then
            DSCcity.Text = dsearch_grid.Item(7, i).Value
        End If

        If dsearch_grid.Item(8, i).Value IsNot DBNull.Value Then
            DSCstate.Text = dsearch_grid.Item(8, i).Value
        End If

        If dsearch_grid.Item(9, i).Value IsNot DBNull.Value Then
            DSCzip.Text = dsearch_grid.Item(9, i).Value
        End If

        If dsearch_grid.Item(10, i).Value IsNot DBNull.Value Then
            DSCphone.Text = dsearch_grid.Item(10, i).Value
        End If

        If dsearch_grid.Item(11, i).Value IsNot DBNull.Value Then
            DSClicensenum.Text = dsearch_grid.Item(11, i).Value
        End If

        If dsearch_grid.Item(12, i).Value IsNot DBNull.Value Then
            DSGmanufacturer.Text = dsearch_grid.Item(12, i).Value
        End If

        If dsearch_grid.Item(13, i).Value IsNot DBNull.Value Then
            DSGmodel.Text = dsearch_grid.Item(13, i).Value
        End If

        If dsearch_grid.Item(14, i).Value IsNot DBNull.Value Then
            DSGserialnum.Text = dsearch_grid.Item(14, i).Value
        End If


    End Sub

    Private Sub dsearch_grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dsearch_grid.CellDoubleClick
        SelectAcquisitionDisp()
    End Sub

    Private Sub dsearch_grid_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dsearch_grid.CellMouseDown
        If (e.Button = MouseButtons.Right) Then

            DispStrip.Show(MousePosition.X, MousePosition.Y)

        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        SelectAcquisitionDisp()
    End Sub

    Private Sub Dsubmit_Click(sender As Object, e As EventArgs) Handles Dsubmit.Click
        ' first check to make sure everything is entered

        conn.Open()

        Dim query As String = "INSERT INTO disposition (dis_id, gun_id, customer_id, dis_date, transaction_date, date_entered"

        If Not Dcode.Text = "" Then
            query += ", code"
        End If

        query += ") VALUES (NULL, @gun_id, @customer_id, NOW(), @transaction_date, NOW()"

        If Not Dcode.Text = "" Then
            query += ", @code"
        End If

        query += ")"
        Dim cmd As New MySqlCommand(query, conn)

        derror.Text = query

        cmd.Parameters.AddWithValue("@gun_id", gunid.Text)
        cmd.Parameters.AddWithValue("@customer_id", SCcustomer_id.Text)
        cmd.Parameters.AddWithValue("@transaction_date", dtransdate.Value)

        cmd.ExecuteNonQuery()

        derror.Text = "submitted"
    End Sub

    Private Sub changecustomerbtn_Click(sender As Object, e As EventArgs) Handles changecustomerbtn.Click
        Dim obj As New changecustomerform

        obj.Show()
    End Sub
End Class
