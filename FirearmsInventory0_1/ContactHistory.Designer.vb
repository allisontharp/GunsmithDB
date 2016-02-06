<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactHistory
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
        Me.search_contact_history = New System.Windows.Forms.DataGridView()
        CType(Me.search_contact_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'search_contact_history
        '
        Me.search_contact_history.AllowUserToAddRows = False
        Me.search_contact_history.AllowUserToDeleteRows = False
        Me.search_contact_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.search_contact_history.Location = New System.Drawing.Point(12, 12)
        Me.search_contact_history.Name = "search_contact_history"
        Me.search_contact_history.ReadOnly = True
        Me.search_contact_history.Size = New System.Drawing.Size(1259, 250)
        Me.search_contact_history.TabIndex = 197
        '
        'ContactHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 276)
        Me.Controls.Add(Me.search_contact_history)
        Me.Name = "ContactHistory"
        Me.Text = "Contact History"
        CType(Me.search_contact_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents search_contact_history As DataGridView
End Class
