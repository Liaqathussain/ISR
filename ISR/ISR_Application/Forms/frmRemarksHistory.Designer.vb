<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemarksHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemarksHistory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GVRemarksList = New System.Windows.Forms.DataGridView()
        CType(Me.GVRemarksList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Incident Remarks"
        '
        'GVRemarksList
        '
        Me.GVRemarksList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GVRemarksList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GVRemarksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.GVRemarksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVRemarksList.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GVRemarksList.Location = New System.Drawing.Point(28, 44)
        Me.GVRemarksList.Name = "GVRemarksList"
        Me.GVRemarksList.Size = New System.Drawing.Size(592, 159)
        Me.GVRemarksList.TabIndex = 2
        '
        'frmRemarksHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(649, 226)
        Me.Controls.Add(Me.GVRemarksList)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemarksHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remarks History"
        CType(Me.GVRemarksList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GVRemarksList As System.Windows.Forms.DataGridView
End Class
