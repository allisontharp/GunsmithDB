<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newguntype
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
        Me.gunlabel = New System.Windows.Forms.Label()
        Me.guntextbox = New System.Windows.Forms.TextBox()
        Me.guntypesubmit = New System.Windows.Forms.Button()
        Me.manufacturerlabel = New System.Windows.Forms.Label()
        Me.Amanufacturers = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'gunlabel
        '
        Me.gunlabel.AutoSize = True
        Me.gunlabel.Location = New System.Drawing.Point(8, 28)
        Me.gunlabel.Name = "gunlabel"
        Me.gunlabel.Size = New System.Drawing.Size(112, 13)
        Me.gunlabel.TabIndex = 0
        Me.gunlabel.Text = "Manufacturer Country:"
        '
        'guntextbox
        '
        Me.guntextbox.Location = New System.Drawing.Point(124, 25)
        Me.guntextbox.Name = "guntextbox"
        Me.guntextbox.Size = New System.Drawing.Size(125, 20)
        Me.guntextbox.TabIndex = 1
        '
        'guntypesubmit
        '
        Me.guntypesubmit.Location = New System.Drawing.Point(255, 23)
        Me.guntypesubmit.Name = "guntypesubmit"
        Me.guntypesubmit.Size = New System.Drawing.Size(110, 55)
        Me.guntypesubmit.TabIndex = 2
        Me.guntypesubmit.Text = "Submit"
        Me.guntypesubmit.UseVisualStyleBackColor = True
        '
        'manufacturerlabel
        '
        Me.manufacturerlabel.AutoSize = True
        Me.manufacturerlabel.Location = New System.Drawing.Point(8, 60)
        Me.manufacturerlabel.Name = "manufacturerlabel"
        Me.manufacturerlabel.Size = New System.Drawing.Size(73, 13)
        Me.manufacturerlabel.TabIndex = 3
        Me.manufacturerlabel.Text = "Manufacturer:"
        Me.manufacturerlabel.Visible = False
        '
        'Amanufacturers
        '
        Me.Amanufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Amanufacturers.FormattingEnabled = True
        Me.Amanufacturers.Location = New System.Drawing.Point(124, 57)
        Me.Amanufacturers.Margin = New System.Windows.Forms.Padding(2)
        Me.Amanufacturers.Name = "Amanufacturers"
        Me.Amanufacturers.Size = New System.Drawing.Size(125, 21)
        Me.Amanufacturers.TabIndex = 5
        Me.Amanufacturers.Visible = False
        '
        'newguntype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 90)
        Me.Controls.Add(Me.Amanufacturers)
        Me.Controls.Add(Me.manufacturerlabel)
        Me.Controls.Add(Me.guntypesubmit)
        Me.Controls.Add(Me.guntextbox)
        Me.Controls.Add(Me.gunlabel)
        Me.Name = "newguntype"
        Me.Text = "Add Gun Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gunlabel As Label
    Friend WithEvents guntextbox As TextBox
    Friend WithEvents guntypesubmit As Button
    Friend WithEvents manufacturerlabel As Label
    Friend WithEvents Amanufacturers As ComboBox
End Class
