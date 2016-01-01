<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.acq_grid = New System.Windows.Forms.DataGridView()
        Me.selectbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstnamecb = New System.Windows.Forms.CheckBox()
        Me.lastnamecb = New System.Windows.Forms.CheckBox()
        Me.address1cb = New System.Windows.Forms.CheckBox()
        Me.companycb = New System.Windows.Forms.CheckBox()
        Me.citycb = New System.Windows.Forms.CheckBox()
        Me.address2cb = New System.Windows.Forms.CheckBox()
        Me.zipcb = New System.Windows.Forms.CheckBox()
        Me.statecb = New System.Windows.Forms.CheckBox()
        Me.transdatecb = New System.Windows.Forms.CheckBox()
        Me.serialnumcb = New System.Windows.Forms.CheckBox()
        Me.calibercb = New System.Windows.Forms.CheckBox()
        Me.modelcb = New System.Windows.Forms.CheckBox()
        Me.manufacturercb = New System.Windows.Forms.CheckBox()
        Me.licensenumcb = New System.Windows.Forms.CheckBox()
        Me.allcb = New System.Windows.Forms.CheckBox()
        Me.filterbtn = New System.Windows.Forms.Button()
        CType(Me.acq_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'acq_grid
        '
        Me.acq_grid.AllowUserToAddRows = False
        Me.acq_grid.AllowUserToDeleteRows = False
        Me.acq_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.acq_grid.Location = New System.Drawing.Point(12, 25)
        Me.acq_grid.Name = "acq_grid"
        Me.acq_grid.ReadOnly = True
        Me.acq_grid.Size = New System.Drawing.Size(1034, 377)
        Me.acq_grid.TabIndex = 0
        '
        'selectbtn
        '
        Me.selectbtn.Location = New System.Drawing.Point(1257, 3)
        Me.selectbtn.Name = "selectbtn"
        Me.selectbtn.Size = New System.Drawing.Size(152, 67)
        Me.selectbtn.TabIndex = 1
        Me.selectbtn.Text = "Select"
        Me.selectbtn.UseVisualStyleBackColor = True
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(1257, 76)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(152, 67)
        Me.editbtn.TabIndex = 2
        Me.editbtn.Text = "Edit"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 453)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 363)
        Me.DataGridView1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Acquisitions:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 437)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dispositions:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1064, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Columns:"
        '
        'firstnamecb
        '
        Me.firstnamecb.AutoSize = True
        Me.firstnamecb.Location = New System.Drawing.Point(1067, 25)
        Me.firstnamecb.Name = "firstnamecb"
        Me.firstnamecb.Size = New System.Drawing.Size(76, 17)
        Me.firstnamecb.TabIndex = 9
        Me.firstnamecb.Text = "First Name"
        Me.firstnamecb.UseVisualStyleBackColor = True
        '
        'lastnamecb
        '
        Me.lastnamecb.AutoSize = True
        Me.lastnamecb.Location = New System.Drawing.Point(1067, 48)
        Me.lastnamecb.Name = "lastnamecb"
        Me.lastnamecb.Size = New System.Drawing.Size(77, 17)
        Me.lastnamecb.TabIndex = 10
        Me.lastnamecb.Text = "Last Name"
        Me.lastnamecb.UseVisualStyleBackColor = True
        '
        'address1cb
        '
        Me.address1cb.AutoSize = True
        Me.address1cb.Location = New System.Drawing.Point(1067, 94)
        Me.address1cb.Name = "address1cb"
        Me.address1cb.Size = New System.Drawing.Size(70, 17)
        Me.address1cb.TabIndex = 12
        Me.address1cb.Text = "Address1"
        Me.address1cb.UseVisualStyleBackColor = True
        '
        'companycb
        '
        Me.companycb.AutoSize = True
        Me.companycb.Location = New System.Drawing.Point(1067, 71)
        Me.companycb.Name = "companycb"
        Me.companycb.Size = New System.Drawing.Size(70, 17)
        Me.companycb.TabIndex = 11
        Me.companycb.Text = "Company"
        Me.companycb.UseVisualStyleBackColor = True
        '
        'citycb
        '
        Me.citycb.AutoSize = True
        Me.citycb.Location = New System.Drawing.Point(1067, 140)
        Me.citycb.Name = "citycb"
        Me.citycb.Size = New System.Drawing.Size(43, 17)
        Me.citycb.TabIndex = 14
        Me.citycb.Text = "City"
        Me.citycb.UseVisualStyleBackColor = True
        '
        'address2cb
        '
        Me.address2cb.AutoSize = True
        Me.address2cb.Location = New System.Drawing.Point(1067, 117)
        Me.address2cb.Name = "address2cb"
        Me.address2cb.Size = New System.Drawing.Size(73, 17)
        Me.address2cb.TabIndex = 13
        Me.address2cb.Text = "Address 2"
        Me.address2cb.UseVisualStyleBackColor = True
        '
        'zipcb
        '
        Me.zipcb.AutoSize = True
        Me.zipcb.Location = New System.Drawing.Point(1067, 186)
        Me.zipcb.Name = "zipcb"
        Me.zipcb.Size = New System.Drawing.Size(41, 17)
        Me.zipcb.TabIndex = 16
        Me.zipcb.Text = "Zip"
        Me.zipcb.UseVisualStyleBackColor = True
        '
        'statecb
        '
        Me.statecb.AutoSize = True
        Me.statecb.Location = New System.Drawing.Point(1067, 163)
        Me.statecb.Name = "statecb"
        Me.statecb.Size = New System.Drawing.Size(51, 17)
        Me.statecb.TabIndex = 15
        Me.statecb.Text = "State"
        Me.statecb.UseVisualStyleBackColor = True
        '
        'transdatecb
        '
        Me.transdatecb.AutoSize = True
        Me.transdatecb.Location = New System.Drawing.Point(1067, 324)
        Me.transdatecb.Name = "transdatecb"
        Me.transdatecb.Size = New System.Drawing.Size(108, 17)
        Me.transdatecb.TabIndex = 22
        Me.transdatecb.Text = "Transaction Date"
        Me.transdatecb.UseVisualStyleBackColor = True
        '
        'serialnumcb
        '
        Me.serialnumcb.AutoSize = True
        Me.serialnumcb.Location = New System.Drawing.Point(1067, 301)
        Me.serialnumcb.Name = "serialnumcb"
        Me.serialnumcb.Size = New System.Drawing.Size(92, 17)
        Me.serialnumcb.TabIndex = 21
        Me.serialnumcb.Text = "Serial Number"
        Me.serialnumcb.UseVisualStyleBackColor = True
        '
        'calibercb
        '
        Me.calibercb.AutoSize = True
        Me.calibercb.Location = New System.Drawing.Point(1067, 278)
        Me.calibercb.Name = "calibercb"
        Me.calibercb.Size = New System.Drawing.Size(58, 17)
        Me.calibercb.TabIndex = 20
        Me.calibercb.Text = "Caliber"
        Me.calibercb.UseVisualStyleBackColor = True
        '
        'modelcb
        '
        Me.modelcb.AutoSize = True
        Me.modelcb.Location = New System.Drawing.Point(1067, 255)
        Me.modelcb.Name = "modelcb"
        Me.modelcb.Size = New System.Drawing.Size(55, 17)
        Me.modelcb.TabIndex = 19
        Me.modelcb.Text = "Model"
        Me.modelcb.UseVisualStyleBackColor = True
        '
        'manufacturercb
        '
        Me.manufacturercb.AutoSize = True
        Me.manufacturercb.Location = New System.Drawing.Point(1067, 232)
        Me.manufacturercb.Name = "manufacturercb"
        Me.manufacturercb.Size = New System.Drawing.Size(89, 17)
        Me.manufacturercb.TabIndex = 18
        Me.manufacturercb.Text = "Manufacturer"
        Me.manufacturercb.UseVisualStyleBackColor = True
        '
        'licensenumcb
        '
        Me.licensenumcb.AutoSize = True
        Me.licensenumcb.Location = New System.Drawing.Point(1067, 209)
        Me.licensenumcb.Name = "licensenumcb"
        Me.licensenumcb.Size = New System.Drawing.Size(103, 17)
        Me.licensenumcb.TabIndex = 17
        Me.licensenumcb.Text = "License Number"
        Me.licensenumcb.UseVisualStyleBackColor = True
        '
        'allcb
        '
        Me.allcb.AutoSize = True
        Me.allcb.Location = New System.Drawing.Point(1067, 347)
        Me.allcb.Name = "allcb"
        Me.allcb.Size = New System.Drawing.Size(89, 17)
        Me.allcb.TabIndex = 23
        Me.allcb.Text = "SELECT ALL"
        Me.allcb.UseVisualStyleBackColor = True
        '
        'filterbtn
        '
        Me.filterbtn.Location = New System.Drawing.Point(1067, 370)
        Me.filterbtn.Name = "filterbtn"
        Me.filterbtn.Size = New System.Drawing.Size(108, 32)
        Me.filterbtn.TabIndex = 24
        Me.filterbtn.Text = "Filter"
        Me.filterbtn.UseVisualStyleBackColor = True
        '
        'customerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1529, 895)
        Me.Controls.Add(Me.filterbtn)
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
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.selectbtn)
        Me.Controls.Add(Me.acq_grid)
        Me.Name = "customerform"
        Me.Text = "Company Name: Select Customer"
        CType(Me.acq_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents acq_grid As DataGridView
    Friend WithEvents selectbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstnamecb As CheckBox
    Friend WithEvents lastnamecb As CheckBox
    Friend WithEvents address1cb As CheckBox
    Friend WithEvents companycb As CheckBox
    Friend WithEvents citycb As CheckBox
    Friend WithEvents address2cb As CheckBox
    Friend WithEvents zipcb As CheckBox
    Friend WithEvents statecb As CheckBox
    Friend WithEvents transdatecb As CheckBox
    Friend WithEvents serialnumcb As CheckBox
    Friend WithEvents calibercb As CheckBox
    Friend WithEvents modelcb As CheckBox
    Friend WithEvents manufacturercb As CheckBox
    Friend WithEvents licensenumcb As CheckBox
    Friend WithEvents allcb As CheckBox
    Friend WithEvents filterbtn As Button
End Class
