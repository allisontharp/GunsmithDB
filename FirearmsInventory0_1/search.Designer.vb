<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Me.allcb = New System.Windows.Forms.CheckBox()
        Me.transdatecb = New System.Windows.Forms.CheckBox()
        Me.serialnumcb = New System.Windows.Forms.CheckBox()
        Me.calibercb = New System.Windows.Forms.CheckBox()
        Me.modelcb = New System.Windows.Forms.CheckBox()
        Me.manufacturercb = New System.Windows.Forms.CheckBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.acq_grid = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acq_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showbtn
        '
        Me.showbtn.Location = New System.Drawing.Point(1067, 369)
        Me.showbtn.Name = "showbtn"
        Me.showbtn.Size = New System.Drawing.Size(108, 32)
        Me.showbtn.TabIndex = 47
        Me.showbtn.Text = "Show"
        Me.showbtn.UseVisualStyleBackColor = True
        '
        'allcb
        '
        Me.allcb.AutoSize = True
        Me.allcb.Location = New System.Drawing.Point(1067, 346)
        Me.allcb.Name = "allcb"
        Me.allcb.Size = New System.Drawing.Size(89, 17)
        Me.allcb.TabIndex = 46
        Me.allcb.Text = "SELECT ALL"
        Me.allcb.UseVisualStyleBackColor = True
        '
        'transdatecb
        '
        Me.transdatecb.AutoSize = True
        Me.transdatecb.Location = New System.Drawing.Point(1067, 323)
        Me.transdatecb.Name = "transdatecb"
        Me.transdatecb.Size = New System.Drawing.Size(108, 17)
        Me.transdatecb.TabIndex = 45
        Me.transdatecb.Text = "Transaction Date"
        Me.transdatecb.UseVisualStyleBackColor = True
        '
        'serialnumcb
        '
        Me.serialnumcb.AutoSize = True
        Me.serialnumcb.Location = New System.Drawing.Point(1067, 300)
        Me.serialnumcb.Name = "serialnumcb"
        Me.serialnumcb.Size = New System.Drawing.Size(92, 17)
        Me.serialnumcb.TabIndex = 44
        Me.serialnumcb.Text = "Serial Number"
        Me.serialnumcb.UseVisualStyleBackColor = True
        '
        'calibercb
        '
        Me.calibercb.AutoSize = True
        Me.calibercb.Location = New System.Drawing.Point(1067, 277)
        Me.calibercb.Name = "calibercb"
        Me.calibercb.Size = New System.Drawing.Size(58, 17)
        Me.calibercb.TabIndex = 43
        Me.calibercb.Text = "Caliber"
        Me.calibercb.UseVisualStyleBackColor = True
        '
        'modelcb
        '
        Me.modelcb.AutoSize = True
        Me.modelcb.Location = New System.Drawing.Point(1067, 254)
        Me.modelcb.Name = "modelcb"
        Me.modelcb.Size = New System.Drawing.Size(55, 17)
        Me.modelcb.TabIndex = 42
        Me.modelcb.Text = "Model"
        Me.modelcb.UseVisualStyleBackColor = True
        '
        'manufacturercb
        '
        Me.manufacturercb.AutoSize = True
        Me.manufacturercb.Location = New System.Drawing.Point(1067, 231)
        Me.manufacturercb.Name = "manufacturercb"
        Me.manufacturercb.Size = New System.Drawing.Size(89, 17)
        Me.manufacturercb.TabIndex = 41
        Me.manufacturercb.Text = "Manufacturer"
        Me.manufacturercb.UseVisualStyleBackColor = True
        '
        'licensenumcb
        '
        Me.licensenumcb.AutoSize = True
        Me.licensenumcb.Location = New System.Drawing.Point(1067, 208)
        Me.licensenumcb.Name = "licensenumcb"
        Me.licensenumcb.Size = New System.Drawing.Size(103, 17)
        Me.licensenumcb.TabIndex = 40
        Me.licensenumcb.Text = "License Number"
        Me.licensenumcb.UseVisualStyleBackColor = True
        '
        'zipcb
        '
        Me.zipcb.AutoSize = True
        Me.zipcb.Location = New System.Drawing.Point(1067, 185)
        Me.zipcb.Name = "zipcb"
        Me.zipcb.Size = New System.Drawing.Size(41, 17)
        Me.zipcb.TabIndex = 39
        Me.zipcb.Text = "Zip"
        Me.zipcb.UseVisualStyleBackColor = True
        '
        'statecb
        '
        Me.statecb.AutoSize = True
        Me.statecb.Location = New System.Drawing.Point(1067, 162)
        Me.statecb.Name = "statecb"
        Me.statecb.Size = New System.Drawing.Size(51, 17)
        Me.statecb.TabIndex = 38
        Me.statecb.Text = "State"
        Me.statecb.UseVisualStyleBackColor = True
        '
        'citycb
        '
        Me.citycb.AutoSize = True
        Me.citycb.Location = New System.Drawing.Point(1067, 139)
        Me.citycb.Name = "citycb"
        Me.citycb.Size = New System.Drawing.Size(43, 17)
        Me.citycb.TabIndex = 37
        Me.citycb.Text = "City"
        Me.citycb.UseVisualStyleBackColor = True
        '
        'address2cb
        '
        Me.address2cb.AutoSize = True
        Me.address2cb.Location = New System.Drawing.Point(1067, 116)
        Me.address2cb.Name = "address2cb"
        Me.address2cb.Size = New System.Drawing.Size(73, 17)
        Me.address2cb.TabIndex = 36
        Me.address2cb.Text = "Address 2"
        Me.address2cb.UseVisualStyleBackColor = True
        '
        'address1cb
        '
        Me.address1cb.AutoSize = True
        Me.address1cb.Location = New System.Drawing.Point(1067, 93)
        Me.address1cb.Name = "address1cb"
        Me.address1cb.Size = New System.Drawing.Size(70, 17)
        Me.address1cb.TabIndex = 35
        Me.address1cb.Text = "Address1"
        Me.address1cb.UseVisualStyleBackColor = True
        '
        'companycb
        '
        Me.companycb.AutoSize = True
        Me.companycb.Location = New System.Drawing.Point(1067, 70)
        Me.companycb.Name = "companycb"
        Me.companycb.Size = New System.Drawing.Size(70, 17)
        Me.companycb.TabIndex = 34
        Me.companycb.Text = "Company"
        Me.companycb.UseVisualStyleBackColor = True
        '
        'lastnamecb
        '
        Me.lastnamecb.AutoSize = True
        Me.lastnamecb.Location = New System.Drawing.Point(1067, 47)
        Me.lastnamecb.Name = "lastnamecb"
        Me.lastnamecb.Size = New System.Drawing.Size(77, 17)
        Me.lastnamecb.TabIndex = 33
        Me.lastnamecb.Text = "Last Name"
        Me.lastnamecb.UseVisualStyleBackColor = True
        '
        'firstnamecb
        '
        Me.firstnamecb.AutoSize = True
        Me.firstnamecb.Location = New System.Drawing.Point(1067, 24)
        Me.firstnamecb.Name = "firstnamecb"
        Me.firstnamecb.Size = New System.Drawing.Size(76, 17)
        Me.firstnamecb.TabIndex = 32
        Me.firstnamecb.Text = "First Name"
        Me.firstnamecb.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1064, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Columns:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Dispositions:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Acquisitions:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 452)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 363)
        Me.DataGridView1.TabIndex = 28
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
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 828)
        Me.Controls.Add(Me.showbtn)
        Me.Controls.Add(Me.allcb)
        Me.Controls.Add(Me.transdatecb)
        Me.Controls.Add(Me.serialnumcb)
        Me.Controls.Add(Me.calibercb)
        Me.Controls.Add(Me.modelcb)
        Me.Controls.Add(Me.manufacturercb)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.acq_grid)
        Me.Name = "search"
        Me.Text = "search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acq_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showbtn As Button
    Friend WithEvents allcb As CheckBox
    Friend WithEvents transdatecb As CheckBox
    Friend WithEvents serialnumcb As CheckBox
    Friend WithEvents calibercb As CheckBox
    Friend WithEvents modelcb As CheckBox
    Friend WithEvents manufacturercb As CheckBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents acq_grid As DataGridView
End Class
