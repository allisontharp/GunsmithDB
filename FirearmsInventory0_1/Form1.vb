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

        cbfill("SELECT name FROM type", "type", "name", CBAtype)
        cbfill("SELECT name FROM caliber", "caliber", "name", CBAcaliber)
        cbfill("SELECT name FROM category", "category", "name", CBAcategory)
        cbfill("SELECT name FROM manufacturers", "manufacturers", "name", CBAmanufacturers)
        cbfill("SELECT name FROM mancountry", "mancountry", "name", CBAmancountry)


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

        Dim type_id As String = mysqlquery("select type_id from type where name =  '" + CBAtype.SelectedValue + "';")
        TextBox1.Text = type_id

        If type_id = Nothing Then
            CBAnotes.Text = "nothing"
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
                    CBAnotes.Text = "its empty"
                    Return ("empty")
                Else
                    CBAnotes.Text = "it isn't empty " + reader.GetString(0)
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

        Dim ins As String = Format(DateAcqDpdwn.Value, "yyyy-MM-dd")
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
        CBAnotes.Text = stm

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

    Private Sub CBAmanufacturers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAmanufacturers.SelectedIndexChanged
        Dim manufacturer As String
        'need to clear models when this changes
        CBAmodel.Text = String.Empty


        If CBAmanufacturers.SelectedIndex > 0 Then
            manufacturer = mysqlquery("SELECT man_id FROM manufacturers WHERE name = '" + CBAmanufacturers.SelectedValue + "';")

            cbfill("SELECT name FROM models WHERE man_id = '" + manufacturer + "';", "models", "name", CBAmodel)
        End If
    End Sub

    Private Sub BAsubmit_Click(sender As Object, e As EventArgs) Handles BAsubmit.Click
        Dim type_id As String = mysqlquery("select type_id from type where name =  '" + CBAtype.SelectedValue + "';")
        Dim cal_id As String = mysqlquery("select cal_id from caliber where name = '" + CBAcaliber.SelectedValue + "';")
        Dim man_id As String = mysqlquery("select man_id from manufacturers where name = '" + CBAmanufacturers.SelectedValue + "';")
        Dim model_id As String = mysqlquery("select model_id from models where name = '" + CBAmodel.SelectedValue + "';")
        Dim mancountry_id As String = mysqlquery("select mancountry_id from mancountry where name = '" + CBAmancountry.SelectedValue + "';")
        Dim cat_id As String = mysqlquery("select cat_id from category where name = '" + CBAcategory.SelectedValue + "';")
        Dim trans_firstname As String = CBAfname.Text
        Dim trans_lastname As String = CBAlname.Text

        Dim errmsg As String = ""



        ' Required
        ' need to check that required things are filled out, vbcr if label, vbcrlf if textobx
        If type_id Is Nothing Then
            errmsg += vbCrLf + "Type"
        End If

        If cal_id Is Nothing Then
            errmsg += vbCrLf + "Caliber"
        End If

        If man_id Is Nothing Then
            errmsg += vbCrLf + "Manufacturer"
        End If

        If model_id Is Nothing Then
            errmsg += vbCrLf + "Model"
        End If

        If mancountry_id Is Nothing Then
            errmsg += vbCrLf + "Manufacturer Country"
        End If

        If cat_id Is Nothing Then
            errmsg += vbCrLf + "Category"
        End If

        If trans_firstname = "" Then
            errmsg += vbCrLf + "First Name"
        End If

        If trans_lastname = "" Then
            errmsg += vbCr + "Last Name"
        End If




        If errmsg Is Nothing Then
            mysqlsubmit("gun", "gun_id, type_id, cal_id, man_id, model_id, mancountry_id, serialnum, date_entered, isupdated", "null, '" + type_id + "', '" + cal_id _
                + "', '" + man_id + "', '" + model_id + "', '" + mancountry_id + "', '" + CBAserialnum.Text + "', NOW(), 0")
        Else
            TBAerror.Text = "The following need to be completed: " + errmsg
        End If



        'Not Required
    End Sub

End Class
