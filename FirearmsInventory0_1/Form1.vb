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


    Private Sub Bn_test_Click(sender As System.Object, e As System.EventArgs) Handles Bn_test.Click
        'Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        '& "User Id=vb;Password=zsxdcf"

        'Dim stm As String = "SELECT name FROM type WHERE type_id = 1;"
        'Dim version As String
        ''Dim conn As MySqlConnection

        'Try
        '    conn = New MySqlConnection(cs)
        '    conn.Open()

        '    Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
        '    version = Convert.ToString(cmd.ExecuteScalar())
        '    TextBox1.Text = version
        '    Console.WriteLine("MySQL version: {0}", version)

        'Catch ex As MySqlException
        '    TextBox1.Text = ex.ToString()
        '    Console.WriteLine("Error: " & ex.ToString())
        'Finally
        '    conn.Close()
        'End Try

        Dim type_id As String = mysqlquery("select type_id from type where name =  '" + Atype.SelectedValue + "';")
        TextBox1.Text = type_id

        If type_id = Nothing Then
            Anotes.Text = "nothing"
        End If
    End Sub

    Private Function mysqlquery(stmt As String)
        'Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        '& "User Id=vb;Password=zsxdcf"
        Try
            conn = New MySqlConnection(constr)
            conn.Open()

            TextBox1.Text = stmt

            Dim cmd As MySqlCommand = New MySqlCommand(stmt, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            While reader.Read
                If IsDBNull(reader) Then
                    Anotes.Text = "its empty"
                    Return ("empty")
                Else
                    Anotes.Text = "it isn't empty " + reader.GetString(0)
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        & "User Id=vb;Password=zsxdcf"

        Dim ins As String = Format(AAcquired.Value, "yyyy-MM-dd")
        Dim stm As String = "INSERT INTO test (test_id, date) VALUES (null, '" + ins + "');"
        Dim version As String
        'Dim conn As MySqlConnection

        Try
            conn = New MySqlConnection(cs)
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            version = Convert.ToString(cmd.ExecuteScalar())
            TextBox1.Text = version
            'Console.WriteLine("MySQL version: {0}", version)

        Catch ex As MySqlException
            TextBox1.Text = ex.ToString()
            'Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub mysqlsubmit(table As String, cols As String, val As String)
        Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        & "User Id=vb;Password=zsxdcf"
        Dim stm As String = "INSERT INTO " + table + " (" + cols + ") VALUES (" + val + ");"
        Anotes.Text = stm

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

    Private Sub BAsubmit_Click(sender As Object, e As EventArgs) Handles Asubmit.Click
        Dim aqc_date As String = AAcquired.ToString
        Dim type_id As String = mysqlquery("select type_id from type where name =  '" + Atype.SelectedValue + "';")
        Dim cal_id As String = mysqlquery("select cal_id from caliber where name = '" + Acaliber.SelectedValue + "';")
        Dim man_id As String = mysqlquery("select man_id from manufacturers where name = '" + Amanufacturers.SelectedValue + "';")
        Dim model_id As String = mysqlquery("select model_id from models where name = '" + Amodel.SelectedValue + "';")
        Dim mancountry_id As String = mysqlquery("select mancountry_id from mancountry where name = '" + Amancountry.SelectedValue + "';")
        Dim cat_id As String = mysqlquery("select cat_id from category where name = '" + Acategory.SelectedValue + "';")
        Dim firstname As String = Afname.Text
        Dim lastname As String = Alname.Text
        Dim cname As String = Acname.Text

        Dim err As Boolean = 0
        Dim errmsg As String = ""

        Aerror.Text = ""

        ' Required
        ' need to check that required things are filled out, vbcr if label, vbcrlf if textobx
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

        If firstname = "" And lastname = "" And cname = "" Then
            errmsg += vbCrLf + "first name and last name or company name"
        ElseIf firstname = "" And lastname.Length() > 0 Then
            errmsg += "first name"
        ElseIf lastname = "" And firstname.Length() > 0 Then
            errmsg += "last name"
        End If




        If errmsg Is String.Empty Then
            mysqlsubmit("gun", "gun_id, type_id, cal_id, man_id, model_id, mancountry_id, serialnum, date_entered, isupdated", "null, '" + type_id + "', '" + cal_id _
               + "', '" + man_id + "', '" + model_id + "', '" + mancountry_id + "', '" + Aserialnum.Text + "', NOW(), 0")

            mysqlsubmit("customer", "customer_id, firstname, lastname, company, address1, address2, city, state, zip, licensenum", "null, '" + firstname + "', '" + lastname + "', '" + cname + "', '', '', '', 'IN', '46168', '1111111111'")


            TextBox11.Text = "submitted"
        Else
            Aerror.Text = "The following need to be completed:  " + errmsg
        End If



        'Not Required
    End Sub

End Class
