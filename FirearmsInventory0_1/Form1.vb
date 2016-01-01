Imports MySql.Data.MySqlClient

' should check which tab is selected for acquisition/disposition
Public Class Form1
    Dim conn As New MySqlConnection
    'MySqlCommand It represents a SQL statement to execute against a MySQL Database
    Dim cmd As New MySqlCommand
    'Represents a set of data commands and a database connection that 
    'are used to fill a dataset and update a MySQL database. This class cannot be inherited.
    Dim da As New MySqlDataAdapter

    Dim constr As String = "database=firearms;data source=76.74.170.191;" _
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

        AAcquired.Value = DateTime.Now
        Atransdate.Value = DateTime.Now
        Adeadline.Value = DateTime.Now

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

    Private Sub Asubmit_Click(sender As Object, e As EventArgs) Handles Asubmit.Click
        Dim aqc_date As String = AAcquired.ToString
        Dim type_id As String = mysqlquery("select type_id from type where name =  '" + Atype.SelectedValue + "';")
        Dim cal_id As String = mysqlquery("select cal_id from caliber where name = '" + Acaliber.SelectedValue + "';")
        Dim man_id As String = mysqlquery("select man_id from manufacturers where name = '" + Amanufacturers.SelectedValue + "';")
        Dim model_id As String = mysqlquery("select model_id from models where name = '" + Amodel.SelectedValue + "';")
        Dim mancountry_id As String = mysqlquery("select mancountry_id from mancountry where name = '" + Amancountry.SelectedValue + "';")
        Dim cat_id As String = mysqlquery("select cat_id from category where name = '" + Acategory.SelectedValue + "';")

        Dim errmsg As String = ""


        ' Required
        ' need to check that required things are filled out, vbcr if label, vbcrlf if textobx
        If SCcustomer_id.Text = "cid" Then
            errmsg += vbCrLf + "Select Customer"
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

        If cat_id Is Nothing Then
            errmsg += vbCrLf + "category"
        End If

        'If firstname = "" And lastname = "" And cname = "" Then
        '    errmsg += vbCrLf + "first name and last name or company name"
        'ElseIf firstname = "" And lastname.Length() > 0 Then
        '    errmsg += "first name"
        'ElseIf lastname = "" And firstname.Length() > 0 Then
        '    errmsg += "last name"
        'End If




        If errmsg Is String.Empty Then
            conn.Open()
            Dim query As String = "INSERT INTO gun (gun_id, type_id, cal_id, man_id, model_id, mancountry_id, serialnum, date_entered, year, cat_id, deadline, isupdated, note) VALUES 
                (NULL, @type_id, @cal_id, @man_id, @model_id, @mancountry_id, @serialnum, NOW(), @year, @cat_id, @deadline, @isupdated, @note)"
            Dim cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@type_id", type_id)
            cmd.Parameters.AddWithValue("@cal_id", cal_id)
            cmd.Parameters.AddWithValue("@man_id", man_id)
            cmd.Parameters.AddWithValue("@model_id", model_id)
            cmd.Parameters.AddWithValue("@mancountry_id", mancountry_id)
            cmd.Parameters.AddWithValue("@serialnum", Aserialnum.Text)

            cmd.Parameters.AddWithValue("@cat_id", cat_id)
            cmd.Parameters.AddWithValue("@deadline", Adeadline.Text)
            cmd.Parameters.AddWithValue("@isupdated", "0")
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
        'Dim query As String = "SELECT * FROM customer WHERE"
        'Dim obj As New customerform
        'Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        'Dim ds As New DataSet()
        'Dim check As Boolean = False


        'If Not Sfname.Text = "" Then
        '    If Not check Then
        '        query += " firstname LIKE @firstname"
        '    Else
        '        query += " AND firstname LIKE @firstname"
        '    End If
        '    check = True
        'End If

        'If Not Slname.Text = "" Then
        '    If Not check Then
        '        query += " lastname LIKE @lastname"
        '    Else
        '        query += " AND lastname LIKE @lastname"
        '    End If
        '    check = True
        'End If

        'If Not Scname.Text = "" Then
        '    If Not check Then
        '        query += " company LIKE @company"
        '    Else
        '        query += " AND company LIKE @company"
        '    End If
        '    check = True
        'End If

        'If Not Saddress1.Text = "" Then
        '    If Not check Then
        '        query += " address1 LIKE @address1"
        '    Else
        '        query += " AND address1 LIKE @address1"
        '    End If
        '    check = True
        'End If

        'If Not Saddress2.Text = "" Then
        '    If Not check Then
        '        query += " address2 LIKE @address2"
        '    Else
        '        query += " AND address2 LIKE @address2"
        '    End If
        '    check = True
        'End If

        'If Not Scity.Text = "" Then
        '    If Not check Then
        '        query += " city LIKE @city"
        '    Else
        '        query += " AND city LIKE @city"
        '    End If
        '    check = True
        'End If

        'If Not Sstate.Text = "" Then
        '    If Not check Then
        '        query += " state LIKE @state"
        '    Else
        '        query += " AND state LIKE @state"
        '    End If
        '    check = True
        'End If

        'If Not Szip.Text = "" Then
        '    If Not check Then
        '        query += " zip LIKE @zip"
        '    Else
        '        query += " AND zip LIKE @zip"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If





        'If Not Scat.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If

        'If Not Slicensenum.Text = "" Then
        '    If Not check Then
        '        query += " licensenum LIKE @licensenum"
        '    Else
        '        query += " AND licensenum LIKE @licensenum"
        '    End If
        '    check = True
        'End If



        'adap = New MySqlDataAdapter(query, conn)

        'If Not Sfname.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@firstname", Sfname.Text)
        'End If

        'If Not Slname.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@lastname", Slname.Text)
        'End If

        'If Not Scname.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@company", Scname.Text)
        'End If

        'If Not Saddress1.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@address1", Saddress1.Text)
        'End If

        'If Not Saddress2.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@address2", Saddress2.Text)
        'End If

        'If Not Scity.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@city", Scity.Text)
        'End If

        'If Not Sstate.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@state", Sstate.Text)
        'End If

        'If Not Szip.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@zip", Szip.Text)
        'End If

        'If Not Slicensenum.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@licensenum", Slicensenum.Text)
        'End If

        'If Not Scat.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@scat", Scat.Text)
        'End If

        'If Not Stype.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@stype", Stype.Text)
        'End If

        'If Not Scaliber.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@scaliber", Scaliber.Text)
        'End If

        'If Not Smanufacturer.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@smanufacturer", Smanufacturer.Text)
        'End If

        'If Not Smodel.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@smodel", Smodel.Text)
        'End If

        'If Not Smancountry.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@smancountry", Smancountry.Text)
        'End If

        'If Not Syear.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@syear", Syear.Text)
        'End If

        'If Not Spurchase_price.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@spurchase_price", Spurchase_price.Text)
        'End If

        'If Not Sserialnum.Text = "" Then
        '    adap.SelectCommand.Parameters.AddWithValue("@sserialnum", Sserialnum.Text)
        'End If


        ''testbox.Text = query

        'Try
        '    adap.Fill(ds)

        '    obj.acq_grid.DataSource = ds.Tables(0)
        '    ds = Nothing
        '    da = Nothing
        '    conn.Close()
        '    conn.Dispose()

        '    obj.Show()

        'Catch ex As MySqlException
        '    'testbox.Text = ex.ToString()
        'Finally
        '    conn.Close()
        'End Try









        Dim query As String = "SELECT customer.customer_id, customer.firstname AS FirstName, customer.lastname AS LastName, customer.company AS Company, customer.address1,
                                customer.address2, customer.city, customer.state, customer.zip, customer.licensenum, 
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
        Dim obj As New customerform
        Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        Dim check As Boolean = False


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
            adap.SelectCommand.Parameters.AddWithValue("@firstname", Sfname.Text)
        End If

        If Not Slname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@lastname", Slname.Text)
        End If

        If Not Scname.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@company", Scname.Text)
        End If

        If Not Saddress1.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address1", Saddress1.Text)
        End If

        If Not Saddress2.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@address2", Saddress2.Text)
        End If

        If Not Scity.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@city", Scity.Text)
        End If

        If Not Sstate.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@state", Sstate.Text)
        End If

        If Not Szip.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@zip", Szip.Text)
        End If

        If Not Slicensenum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@licensenum", Slicensenum.Text)
        End If

        If Not Scat.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scat", Scat.Text)
        End If

        If Not Stype.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@stype", Stype.Text)
        End If

        If Not Scaliber.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@scaliber", Scaliber.Text)
        End If

        If Not Smanufacturer.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smanufacturer", Smanufacturer.Text)
        End If

        If Not Smodel.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smodel", Smodel.Text)
        End If

        If Not Smancountry.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@smancountry", Smancountry.Text)
        End If

        If Not Syear.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@syear", Syear.Text)
        End If

        If Not Spurchase_price.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@spurchase_price", Spurchase_price.Text)
        End If

        If Not Sserialnum.Text = "" Then
            adap.SelectCommand.Parameters.AddWithValue("@sserialnum", Sserialnum.Text)
        End If


        '   testbox.Text = query

        Try
            adap.Fill(ds)

            obj.acq_grid.DataSource = ds.Tables(0)
            ds = Nothing
            da = Nothing
            obj.acq_grid.Columns("customer_id").Visible = False
            conn.Close()
            conn.Dispose()

            obj.Show()

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
        Scat.Text = ""
        Stype.Text = ""
        Scaliber.Text = ""
        Smanufacturer.Text = ""
        Smodel.Text = ""
        Smancountry.Text = ""
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
    End Sub

    Private Sub Aclear_Click(sender As Object, e As EventArgs) Handles Aclear.Click
        AAcquired.Value = DateTime.Now
        Atransdate.Value = DateTime.Now
        Adeadline.Value = DateTime.Now

        Acategory.Text = ""
        Atype.Text = ""
        Acaliber.Text = ""
        Amanufacturers.Text = ""
        Amodel.Text = ""
        Anotes.Text = ""
        Amancountry.Text = ""
        Ayear.Text = ""
        APrice.Text = ""
        Aserialnum.Text = ""


    End Sub
End Class
