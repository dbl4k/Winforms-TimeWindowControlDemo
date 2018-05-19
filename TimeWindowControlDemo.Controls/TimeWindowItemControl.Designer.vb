<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeWindowItemControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RightHandle = New System.Windows.Forms.Panel()
        Me.LeftHandle = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'RightHandle
        '
        Me.RightHandle.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RightHandle.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightHandle.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightHandle.Location = New System.Drawing.Point(1407, 0)
        Me.RightHandle.Name = "RightHandle"
        Me.RightHandle.Size = New System.Drawing.Size(5, 373)
        Me.RightHandle.TabIndex = 0
        '
        'LeftHandle
        '
        Me.LeftHandle.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LeftHandle.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.LeftHandle.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftHandle.Location = New System.Drawing.Point(0, 0)
        Me.LeftHandle.Name = "LeftHandle"
        Me.LeftHandle.Size = New System.Drawing.Size(5, 373)
        Me.LeftHandle.TabIndex = 1
        '
        'TimeWindowItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Controls.Add(Me.LeftHandle)
        Me.Controls.Add(Me.RightHandle)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Name = "TimeWindowItemControl"
        Me.Size = New System.Drawing.Size(1412, 373)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RightHandle As Panel
    Friend WithEvents LeftHandle As Panel
End Class
