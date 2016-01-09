<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customersearch
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
        Me.showbtn = New System.Windows.Forms.Button()
        Me.licensenumcb = New System.Windows.Forms.CheckBox()
        Me.zipcb = New System.Windows.Forms.CheckBox()
        Me.statecb = New System.Windows.Forms.CheckBox()
        Me.citycb = New System.Windows.Forms.CheckBox()
        Me.address2cb = New System.Windows.Forms.CheckBox()
        Me.address1cb = New System.Windows.Forms.CheckBox()
        Me.companycb = New System.Windows.Forms.CheckBox()
        Me.lastnamecb = New System.Windows.Forms.CheckBox()
        Me.firstnamecb = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.acq_grid = New System.Windows.Forms.DataGridView()
        Me.customeredit = New System.Windows.Forms.Button()
        Me.customerselect = New System.Windows.Forms.Button()
        Me.allcb = New System.Windows.Forms.CheckBox()
        CType(Me.acq_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showbtn
        '
        Me.showbtn.Location = New System.Drawing.Point(1064, 256)
        Me.showbtn.Name = "showbtn"
        Me.showbtn.Size = New System.Drawing.Size(108, 32)
        Me.showbtn.TabIndex = 47
        Me.showbtn.Text = "Show"
        Me.showbtn.UseVisualStyleBackColor = True
        '
        'licensenumcb
        '
        Me.licensenumcb.AutoSize = True
        Me.licensenumcb.Location = New System.Drawing.Point(1064, 207)
        Me.licensenumcb.Name = "licensenumcb"
        Me.licensenumcb.Size = New System.Drawing.Size(103, 17)
        Me.licensenumcb.TabIndex = 40
        Me.licensenumcb.Text = "License Number"
        Me.licensenumcb.UseVisualStyleBackColor = True
        '
        'zipcb
        '
        Me.zipcb.AutoSize = True
        Me.zipcb.Location = New System.Drawing.Point(1064, 184)
        Me.zipcb.Name = "zipcb"
        Me.zipcb.Size = New System.Drawing.Size(41, 17)
        Me.zipcb.TabIndex = 39
        Me.zipcb.Text = "Zip"
        Me.zipcb.UseVisualStyleBackColor = True
        '
        'statecb
        '
        Me.statecb.AutoSize = True
        Me.statecb.Location = New System.Drawing.Point(1064, 161)
        Me.statecb.Name = "statecb"
        Me.statecb.Size = New System.Drawing.Size(51, 17)
        Me.statecb.TabIndex = 38
        Me.statecb.Text = "State"
        Me.statecb.UseVisualStyleBackColor = True
        '
        'citycb
        '
        Me.citycb.AutoSize = True
        Me.citycb.Location = New System.Drawing.Point(1064, 138)
        Me.citycb.Name = "citycb"
        Me.citycb.Size = New System.Drawing.Size(43, 17)
        Me.citycb.TabIndex = 37
        Me.citycb.Text = "City"
        Me.citycb.UseVisualStyleBackColor = True
        '
        'address2cb
        '
        Me.address2cb.AutoSize = True
        Me.address2cb.Location = New System.Drawing.Point(1064, 115)
        Me.address2cb.Name = "address2cb"
        Me.address2cb.Size = New System.Drawing.Size(73, 17)
        Me.address2cb.TabIndex = 36
        Me.address2cb.Text = "Address 2"
        Me.address2cb.UseVisualStyleBackColor = True
        '
        'address1cb
        '
        Me.address1cb.AutoSize = True
        Me.address1cb.Location = New System.Drawing.Point(1064, 92)
        Me.address1cb.Name = "address1cb"
        Me.address1cb.Size = New System.Drawing.Size(70, 17)
        Me.address1cb.TabIndex = 35
        Me.address1cb.Text = "Address1"
        Me.address1cb.UseVisualStyleBackColor = True
        '
        'companycb
        '
        Me.companycb.AutoSize = True
        Me.companycb.Location = New System.Drawing.Point(1064, 69)
        Me.companycb.Name = "companycb"
        Me.companycb.Size = New System.Drawing.Size(70, 17)
        Me.companycb.TabIndex = 34
        Me.companycb.Text = "Company"
        Me.companycb.UseVisualStyleBackColor = True
        '
        'lastnamecb
        '
        Me.lastnamecb.AutoSize = True
        Me.lastnamecb.Location = New System.Drawing.Point(1064, 46)
        Me.lastnamecb.Name = "lastnamecb"
        Me.lastnamecb.Size = New System.Drawing.Size(77, 17)
        Me.lastnamecb.TabIndex = 33
        Me.lastnamecb.Text = "Last Name"
        Me.lastnamecb.UseVisualStyleBackColor = True
        '
        'firstnamecb
        '
        Me.firstnamecb.AutoSize = True
        Me.firstnamecb.Location = New System.Drawing.Point(1064, 23)
        Me.firstnamecb.Name = "firstnamecb"
        Me.firstnamecb.Size = New System.Drawing.Size(76, 17)
        Me.firstnamecb.TabIndex = 32
        Me.firstnamecb.Text = "First Name"
        Me.firstnamecb.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1061, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Columns:"
        '
        'acq_grid
        '
        Me.acq_grid.AllowUserToAddRows = False
        Me.acq_grid.AllowUserToDeleteRows = False
        Me.acq_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.acq_grid.Location = New System.Drawing.Point(12, 24)
        Me.acq_grid.Name = "acq_grid"
        Me.acq_grid.ReadOnly = True
        Me.acq_grid.Size = New System.Drawing.Size(1034, 377)
        Me.acq_grid.TabIndex = 25
        '
        'customeredit
        '
        Me.customeredit.Location = New System.Drawing.Point(1064, 369)
        Me.customeredit.Name = "customeredit"
        Me.customeredit.Size = New System.Drawing.Size(108, 32)
        Me.customeredit.TabIndex = 48
        Me.customeredit.Text = "Edit"
        Me.customeredit.UseVisualStyleBackColor = True
        '
        'customerselect
        '
        Me.customerselect.Location = New System.Drawing.Point(1064, 331)
        Me.customerselect.Name = "customerselect"
        Me.customerselect.Size = New System.Drawing.Size(108, 32)
        Me.customerselect.TabIndex = 49
        Me.customerselect.Text = "Select"
        Me.customerselect.UseVisualStyleBackColor = True
        '
        'allcb
        '
        Me.allcb.AutoSize = True
        Me.allcb.Location = New System.Drawing.Point(1064, 230)
        Me.allcb.Name = "allcb"
        Me.allcb.Size = New System.Drawing.Size(89, 17)
        Me.allcb.TabIndex = 50
        Me.allcb.Text = "SELECT ALL"
        Me.allcb.UseVisualStyleBackColor = True
        '
        'customersearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 412)
        Me.Controls.Add(Me.allcb)
        Me.Controls.Add(Me.customerselect)
        Me.Controls.Add(Me.customeredit)
        Me.Controls.Add(Me.showbtn)
        Me.Controls.Add(Me.licensenumcb)
        Me.Controls.Add(Me.zipcb)
        Me.Controls.Add(Me.statecb)
        Me.Controls.Add(Me.citycb)
        Me.Controls.Add(Me.address2cb)
        Me.Controls.Add(Me.address1cb)
        Me.Controls.Add(Me.companycb)
        Me.Controls.Add(Me.lastnamecb)
        Me.Controls.Add(Me.firstnamecb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.acq_grid)
        Me.Name = "customersearch"
        Me.Text = "customersearch"
        CType(Me.acq_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showbtn As Button
    Friend WithEvents licensenumcb As CheckBox
    Friend WithEvents zipcb As CheckBox
    Friend WithEvents statecb As CheckBox
    Friend WithEvents citycb As CheckBox
    Friend WithEvents address2cb As CheckBox
    Friend WithEvents address1cb As CheckBox
    Friend WithEvents companycb As CheckBox
    Friend WithEvents lastnamecb As CheckBox
    Friend WithEvents firstnamecb As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents acq_grid As DataGridView
    Friend WithEvents customeredit As Button
    Friend WithEvents customerselect As Button
    Friend WithEvents allcb As CheckBox
End Class
