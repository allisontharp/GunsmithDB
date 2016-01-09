<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customeredit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.customer_group = New System.Windows.Forms.GroupBox()
        Me.SCcustomer_id = New System.Windows.Forms.Label()
        Me.SClicensenum = New System.Windows.Forms.Label()
        Me.SCzip = New System.Windows.Forms.Label()
        Me.SCstate = New System.Windows.Forms.Label()
        Me.SCcity = New System.Windows.Forms.Label()
        Me.SCaddress2 = New System.Windows.Forms.Label()
        Me.SCaddress1 = New System.Windows.Forms.Label()
        Me.SCcompany = New System.Windows.Forms.Label()
        Me.CElname = New System.Windows.Forms.Label()
        Me.CEfname = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Cstate = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Czip = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Ccity = New System.Windows.Forms.TextBox()
        Me.Caddress2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Caddress1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Clicensenum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ccname = New System.Windows.Forms.TextBox()
        Me.Clname = New System.Windows.Forms.TextBox()
        Me.Cfname = New System.Windows.Forms.TextBox()
        Me.CEsubmit = New System.Windows.Forms.Button()
        Me.SCPhonenumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cphonenumber = New System.Windows.Forms.TextBox()
        Me.customer_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'customer_group
        '
        Me.customer_group.Controls.Add(Me.SCPhonenumber)
        Me.customer_group.Controls.Add(Me.Label2)
        Me.customer_group.Controls.Add(Me.SCcustomer_id)
        Me.customer_group.Controls.Add(Me.SClicensenum)
        Me.customer_group.Controls.Add(Me.SCzip)
        Me.customer_group.Controls.Add(Me.SCstate)
        Me.customer_group.Controls.Add(Me.SCcity)
        Me.customer_group.Controls.Add(Me.SCaddress2)
        Me.customer_group.Controls.Add(Me.SCaddress1)
        Me.customer_group.Controls.Add(Me.SCcompany)
        Me.customer_group.Controls.Add(Me.CElname)
        Me.customer_group.Controls.Add(Me.CEfname)
        Me.customer_group.Controls.Add(Me.Label22)
        Me.customer_group.Controls.Add(Me.Label23)
        Me.customer_group.Controls.Add(Me.Label29)
        Me.customer_group.Controls.Add(Me.Label24)
        Me.customer_group.Controls.Add(Me.Label28)
        Me.customer_group.Controls.Add(Me.Label25)
        Me.customer_group.Controls.Add(Me.Label27)
        Me.customer_group.Controls.Add(Me.Label26)
        Me.customer_group.Location = New System.Drawing.Point(281, 12)
        Me.customer_group.Name = "customer_group"
        Me.customer_group.Size = New System.Drawing.Size(337, 195)
        Me.customer_group.TabIndex = 8
        Me.customer_group.TabStop = False
        Me.customer_group.Text = "Selected Customer:"
        '
        'SCcustomer_id
        '
        Me.SCcustomer_id.AutoSize = True
        Me.SCcustomer_id.Location = New System.Drawing.Point(304, 8)
        Me.SCcustomer_id.Name = "SCcustomer_id"
        Me.SCcustomer_id.Size = New System.Drawing.Size(21, 13)
        Me.SCcustomer_id.TabIndex = 117
        Me.SCcustomer_id.Text = "cid"
        Me.SCcustomer_id.Visible = False
        '
        'SClicensenum
        '
        Me.SClicensenum.AutoSize = True
        Me.SClicensenum.Location = New System.Drawing.Point(12, 168)
        Me.SClicensenum.Name = "SClicensenum"
        Me.SClicensenum.Size = New System.Drawing.Size(27, 13)
        Me.SClicensenum.TabIndex = 116
        Me.SClicensenum.Text = "N/A"
        '
        'SCzip
        '
        Me.SCzip.AutoSize = True
        Me.SCzip.Location = New System.Drawing.Point(196, 134)
        Me.SCzip.Name = "SCzip"
        Me.SCzip.Size = New System.Drawing.Size(27, 13)
        Me.SCzip.TabIndex = 115
        Me.SCzip.Text = "N/A"
        '
        'SCstate
        '
        Me.SCstate.AutoSize = True
        Me.SCstate.Location = New System.Drawing.Point(134, 133)
        Me.SCstate.Name = "SCstate"
        Me.SCstate.Size = New System.Drawing.Size(27, 13)
        Me.SCstate.TabIndex = 114
        Me.SCstate.Text = "N/A"
        '
        'SCcity
        '
        Me.SCcity.AutoSize = True
        Me.SCcity.Location = New System.Drawing.Point(12, 131)
        Me.SCcity.Name = "SCcity"
        Me.SCcity.Size = New System.Drawing.Size(27, 13)
        Me.SCcity.TabIndex = 113
        Me.SCcity.Text = "N/A"
        '
        'SCaddress2
        '
        Me.SCaddress2.AutoSize = True
        Me.SCaddress2.Location = New System.Drawing.Point(12, 93)
        Me.SCaddress2.Name = "SCaddress2"
        Me.SCaddress2.Size = New System.Drawing.Size(27, 13)
        Me.SCaddress2.TabIndex = 112
        Me.SCaddress2.Text = "N/A"
        '
        'SCaddress1
        '
        Me.SCaddress1.AutoSize = True
        Me.SCaddress1.Location = New System.Drawing.Point(12, 78)
        Me.SCaddress1.Name = "SCaddress1"
        Me.SCaddress1.Size = New System.Drawing.Size(27, 13)
        Me.SCaddress1.TabIndex = 111
        Me.SCaddress1.Text = "N/A"
        '
        'SCcompany
        '
        Me.SCcompany.AutoSize = True
        Me.SCcompany.Location = New System.Drawing.Point(201, 33)
        Me.SCcompany.Name = "SCcompany"
        Me.SCcompany.Size = New System.Drawing.Size(27, 13)
        Me.SCcompany.TabIndex = 110
        Me.SCcompany.Text = "N/A"
        '
        'CElname
        '
        Me.CElname.AutoSize = True
        Me.CElname.Location = New System.Drawing.Point(107, 34)
        Me.CElname.Name = "CElname"
        Me.CElname.Size = New System.Drawing.Size(27, 13)
        Me.CElname.TabIndex = 109
        Me.CElname.Text = "N/A"
        '
        'CEfname
        '
        Me.CEfname.AutoSize = True
        Me.CEfname.Location = New System.Drawing.Point(12, 34)
        Me.CEfname.Name = "CEfname"
        Me.CEfname.Size = New System.Drawing.Size(27, 13)
        Me.CEfname.TabIndex = 8
        Me.CEfname.Text = "N/A"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(196, 116)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 108
        Me.Label22.Text = "Zip:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(134, 115)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 107
        Me.Label23.Text = "State:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 19)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 101
        Me.Label29.Text = "First Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(11, 115)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "City:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(103, 19)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 13)
        Me.Label28.TabIndex = 102
        Me.Label28.Text = "Last Name:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 61)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 13)
        Me.Label25.TabIndex = 105
        Me.Label25.Text = "Address:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(196, 19)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(98, 13)
        Me.Label27.TabIndex = 103
        Me.Label27.Text = "Company Name:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label26.Location = New System.Drawing.Point(12, 155)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(102, 13)
        Me.Label26.TabIndex = 104
        Me.Label26.Text = "License Number:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(196, 148)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 118
        Me.Label13.Text = "Zip:"
        '
        'Cstate
        '
        Me.Cstate.FormattingEnabled = True
        Me.Cstate.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "MD", "MA", "MI", "MN", "MS", "MO", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.Cstate.Location = New System.Drawing.Point(136, 162)
        Me.Cstate.Name = "Cstate"
        Me.Cstate.Size = New System.Drawing.Size(58, 21)
        Me.Cstate.TabIndex = 108
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(134, 147)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "State:"
        '
        'Czip
        '
        Me.Czip.Location = New System.Drawing.Point(199, 163)
        Me.Czip.Margin = New System.Windows.Forms.Padding(2)
        Me.Czip.Name = "Czip"
        Me.Czip.Size = New System.Drawing.Size(57, 20)
        Me.Czip.TabIndex = 109
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 147)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "City:"
        '
        'Ccity
        '
        Me.Ccity.Location = New System.Drawing.Point(14, 163)
        Me.Ccity.Margin = New System.Windows.Forms.Padding(2)
        Me.Ccity.Name = "Ccity"
        Me.Ccity.Size = New System.Drawing.Size(120, 20)
        Me.Ccity.TabIndex = 107
        '
        'Caddress2
        '
        Me.Caddress2.Location = New System.Drawing.Point(14, 123)
        Me.Caddress2.Margin = New System.Windows.Forms.Padding(2)
        Me.Caddress2.Name = "Caddress2"
        Me.Caddress2.Size = New System.Drawing.Size(242, 20)
        Me.Caddress2.TabIndex = 106
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 86)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Address:"
        '
        'Caddress1
        '
        Me.Caddress1.Location = New System.Drawing.Point(14, 101)
        Me.Caddress1.Margin = New System.Windows.Forms.Padding(2)
        Me.Caddress1.Name = "Caddress1"
        Me.Caddress1.Size = New System.Drawing.Size(242, 20)
        Me.Caddress1.TabIndex = 105
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Location = New System.Drawing.Point(12, 187)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 13)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "License Number:"
        '
        'Clicensenum
        '
        Me.Clicensenum.Location = New System.Drawing.Point(15, 202)
        Me.Clicensenum.Margin = New System.Windows.Forms.Padding(2)
        Me.Clicensenum.Name = "Clicensenum"
        Me.Clicensenum.Size = New System.Drawing.Size(119, 20)
        Me.Clicensenum.TabIndex = 110
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Company Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Last Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "First Name:"
        '
        'Ccname
        '
        Me.Ccname.Location = New System.Drawing.Point(14, 64)
        Me.Ccname.Margin = New System.Windows.Forms.Padding(2)
        Me.Ccname.Name = "Ccname"
        Me.Ccname.Size = New System.Drawing.Size(242, 20)
        Me.Ccname.TabIndex = 104
        '
        'Clname
        '
        Me.Clname.Location = New System.Drawing.Point(136, 27)
        Me.Clname.Margin = New System.Windows.Forms.Padding(2)
        Me.Clname.Name = "Clname"
        Me.Clname.Size = New System.Drawing.Size(119, 20)
        Me.Clname.TabIndex = 103
        '
        'Cfname
        '
        Me.Cfname.Location = New System.Drawing.Point(14, 27)
        Me.Cfname.Margin = New System.Windows.Forms.Padding(2)
        Me.Cfname.Name = "Cfname"
        Me.Cfname.Size = New System.Drawing.Size(120, 20)
        Me.Cfname.TabIndex = 101
        '
        'CEsubmit
        '
        Me.CEsubmit.Location = New System.Drawing.Point(15, 227)
        Me.CEsubmit.Name = "CEsubmit"
        Me.CEsubmit.Size = New System.Drawing.Size(239, 49)
        Me.CEsubmit.TabIndex = 120
        Me.CEsubmit.Text = "Submit"
        Me.CEsubmit.UseVisualStyleBackColor = True
        '
        'SCPhonenumber
        '
        Me.SCPhonenumber.AutoSize = True
        Me.SCPhonenumber.Location = New System.Drawing.Point(154, 168)
        Me.SCPhonenumber.Name = "SCPhonenumber"
        Me.SCPhonenumber.Size = New System.Drawing.Size(27, 13)
        Me.SCPhonenumber.TabIndex = 119
        Me.SCPhonenumber.Text = "N/A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(154, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Phone Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(135, 187)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Phone Number:"
        '
        'Cphonenumber
        '
        Me.Cphonenumber.Location = New System.Drawing.Point(138, 202)
        Me.Cphonenumber.Margin = New System.Windows.Forms.Padding(2)
        Me.Cphonenumber.Name = "Cphonenumber"
        Me.Cphonenumber.Size = New System.Drawing.Size(119, 20)
        Me.Cphonenumber.TabIndex = 121
        '
        'customeredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 285)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cphonenumber)
        Me.Controls.Add(Me.CEsubmit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Cstate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Czip)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Ccity)
        Me.Controls.Add(Me.Caddress2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Caddress1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Clicensenum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Ccname)
        Me.Controls.Add(Me.Clname)
        Me.Controls.Add(Me.Cfname)
        Me.Controls.Add(Me.customer_group)
        Me.Name = "customeredit"
        Me.Text = "customeredit"
        Me.customer_group.ResumeLayout(False)
        Me.customer_group.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customer_group As GroupBox
    Friend WithEvents SCcustomer_id As Label
    Friend WithEvents SClicensenum As Label
    Friend WithEvents SCzip As Label
    Friend WithEvents SCstate As Label
    Friend WithEvents SCcity As Label
    Friend WithEvents SCaddress2 As Label
    Friend WithEvents SCaddress1 As Label
    Friend WithEvents SCcompany As Label
    Friend WithEvents CElname As Label
    Friend WithEvents CEfname As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Cstate As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Czip As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Ccity As TextBox
    Friend WithEvents Caddress2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Caddress1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Clicensenum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Ccname As TextBox
    Friend WithEvents Clname As TextBox
    Friend WithEvents Cfname As TextBox
    Friend WithEvents CEsubmit As Button
    Friend WithEvents SCPhonenumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cphonenumber As TextBox
End Class
