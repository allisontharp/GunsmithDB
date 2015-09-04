Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    'MySqlCommand It represents a SQL statement to execute against a MySQL Database
    Dim cmd As New MySqlCommand
    'Represents a set of data commands and a database connection that 
    'are used to fill a dataset and update a MySQL database. This class cannot be inherited.
    Dim da As New MySqlDataAdapter

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
        Dim atypeda, acaliberda As New MySqlDataAdapter
        conn.ConnectionString = ("Database=firearms;Data Source=76.74.170.191;" _
        & "User Id=vb;Password=zsxdcf")
        Try
            'we open Connection
            conn.Open()


            'acquisition type
            With cmd
                .Connection = conn
                .CommandText = "SELECT name from type;"
            End With
            'declare dt as new datatable
            Dim dt As New DataTable
            dt.Clear()

            With CBAtype
                da.SelectCommand = cmd
                'it fills the da values into dt
                da.Fill(dt)
                'dt provides the data surce of combobox
                .DataSource = dt
                'specify the what to display
                .DisplayMember = "name"
                'and the value
                .ValueMember = "name"

            End With
            CBAtype.SelectedIndex = -1

            dt.Clear()

            'acquisition caliber
            With cmd
                .Connection = conn
                .CommandText = "SELECT name from caliber;"
            End With

            With CBAcaliber
                da.SelectCommand = cmd
                'it fills the da values into dt
                da.Fill(dt)
                'dt provides the data surce of combobox
                .DataSource = dt
                'specify the what to display
                .DisplayMember = "name"
                'and the value
                .ValueMember = "name"

            End With
            CBAcaliber.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Bn_test_Click(sender As System.Object, e As System.EventArgs) Handles Bn_test.Click
        Dim cs As String = "Database=firearms;Data Source=76.74.170.191;" _
        & "User Id=vb;Password=zsxdcf"

        Dim stm As String = "SELECT name FROM type WHERE type_id = 1;"
        Dim version As String
        'Dim conn As MySqlConnection

        Try
            conn = New MySqlConnection(cs)
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            version = Convert.ToString(cmd.ExecuteScalar())
            TextBox1.Text = version
            Console.WriteLine("MySQL version: {0}", version)

        Catch ex As MySqlException
            TextBox1.Text = ex.ToString()
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

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


End Class
