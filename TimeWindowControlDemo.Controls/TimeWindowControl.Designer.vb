<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeWindowControl
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
        Me.LayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMonday = New System.Windows.Forms.Label()
        Me.lblTuesday = New System.Windows.Forms.Label()
        Me.lblWednesday = New System.Windows.Forms.Label()
        Me.lblThursday = New System.Windows.Forms.Label()
        Me.lblFriday = New System.Windows.Forms.Label()
        Me.lblSaturday = New System.Windows.Forms.Label()
        Me.lblSunday = New System.Windows.Forms.Label()
        Me.TimeWindowRowControl1 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeWindowRowControl2 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeWindowRowControl3 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeWindowRowControl4 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeWindowRowControl5 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeWindowRowControl6 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeWindowRowControl7 = New TimeWindowControlDemo.Controls.TimeWindowRowControl()
        Me.TimeGaugePanel = New TimeWindowControlDemo.Controls.TimeWindowChronologyPanel()
        Me.LayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutPanel
        '
        Me.LayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutPanel.ColumnCount = 2
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.Controls.Add(Me.lblMonday, 0, 1)
        Me.LayoutPanel.Controls.Add(Me.lblTuesday, 0, 2)
        Me.LayoutPanel.Controls.Add(Me.lblWednesday, 0, 3)
        Me.LayoutPanel.Controls.Add(Me.lblThursday, 0, 4)
        Me.LayoutPanel.Controls.Add(Me.lblFriday, 0, 5)
        Me.LayoutPanel.Controls.Add(Me.lblSaturday, 0, 6)
        Me.LayoutPanel.Controls.Add(Me.lblSunday, 0, 7)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl1, 1, 1)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl2, 1, 2)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl3, 1, 3)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl4, 1, 4)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl5, 1, 5)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl6, 1, 6)
        Me.LayoutPanel.Controls.Add(Me.TimeWindowRowControl7, 1, 7)
        Me.LayoutPanel.Controls.Add(Me.TimeGaugePanel, 1, 0)
        Me.LayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.LayoutPanel.Name = "LayoutPanel"
        Me.LayoutPanel.RowCount = 8
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.LayoutPanel.Size = New System.Drawing.Size(887, 447)
        Me.LayoutPanel.TabIndex = 0
        '
        'lblMonday
        '
        Me.lblMonday.AutoSize = True
        Me.lblMonday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonday.Location = New System.Drawing.Point(3, 55)
        Me.lblMonday.Name = "lblMonday"
        Me.lblMonday.Size = New System.Drawing.Size(69, 55)
        Me.lblMonday.TabIndex = 0
        Me.lblMonday.Text = "Monday"
        Me.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTuesday
        '
        Me.lblTuesday.AutoSize = True
        Me.lblTuesday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTuesday.Location = New System.Drawing.Point(3, 110)
        Me.lblTuesday.Name = "lblTuesday"
        Me.lblTuesday.Size = New System.Drawing.Size(69, 55)
        Me.lblTuesday.TabIndex = 1
        Me.lblTuesday.Text = "Tuesday"
        Me.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWednesday
        '
        Me.lblWednesday.AutoSize = True
        Me.lblWednesday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWednesday.Location = New System.Drawing.Point(3, 165)
        Me.lblWednesday.Name = "lblWednesday"
        Me.lblWednesday.Size = New System.Drawing.Size(69, 55)
        Me.lblWednesday.TabIndex = 2
        Me.lblWednesday.Text = "Wednesday"
        Me.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblThursday
        '
        Me.lblThursday.AutoSize = True
        Me.lblThursday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblThursday.Location = New System.Drawing.Point(3, 220)
        Me.lblThursday.Name = "lblThursday"
        Me.lblThursday.Size = New System.Drawing.Size(69, 55)
        Me.lblThursday.TabIndex = 3
        Me.lblThursday.Text = "Thursday"
        Me.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFriday
        '
        Me.lblFriday.AutoSize = True
        Me.lblFriday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFriday.Location = New System.Drawing.Point(3, 275)
        Me.lblFriday.Name = "lblFriday"
        Me.lblFriday.Size = New System.Drawing.Size(69, 55)
        Me.lblFriday.TabIndex = 4
        Me.lblFriday.Text = "Friday"
        Me.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaturday
        '
        Me.lblSaturday.AutoSize = True
        Me.lblSaturday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaturday.Location = New System.Drawing.Point(3, 330)
        Me.lblSaturday.Name = "lblSaturday"
        Me.lblSaturday.Size = New System.Drawing.Size(69, 55)
        Me.lblSaturday.TabIndex = 5
        Me.lblSaturday.Text = "Saturday"
        Me.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSunday
        '
        Me.lblSunday.AutoSize = True
        Me.lblSunday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSunday.Location = New System.Drawing.Point(3, 385)
        Me.lblSunday.Name = "lblSunday"
        Me.lblSunday.Size = New System.Drawing.Size(69, 62)
        Me.lblSunday.TabIndex = 6
        Me.lblSunday.Text = "Sunday"
        Me.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimeWindowRowControl1
        '
        Me.TimeWindowRowControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl1.Location = New System.Drawing.Point(78, 58)
        Me.TimeWindowRowControl1.Name = "TimeWindowRowControl1"
        Me.TimeWindowRowControl1.Size = New System.Drawing.Size(806, 49)
        Me.TimeWindowRowControl1.TabIndex = 7
        '
        'TimeWindowRowControl2
        '
        Me.TimeWindowRowControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl2.Location = New System.Drawing.Point(78, 113)
        Me.TimeWindowRowControl2.Name = "TimeWindowRowControl2"
        Me.TimeWindowRowControl2.Size = New System.Drawing.Size(806, 49)
        Me.TimeWindowRowControl2.TabIndex = 8
        '
        'TimeWindowRowControl3
        '
        Me.TimeWindowRowControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl3.Location = New System.Drawing.Point(78, 168)
        Me.TimeWindowRowControl3.Name = "TimeWindowRowControl3"
        Me.TimeWindowRowControl3.Size = New System.Drawing.Size(806, 49)
        Me.TimeWindowRowControl3.TabIndex = 9
        '
        'TimeWindowRowControl4
        '
        Me.TimeWindowRowControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl4.Location = New System.Drawing.Point(78, 223)
        Me.TimeWindowRowControl4.Name = "TimeWindowRowControl4"
        Me.TimeWindowRowControl4.Size = New System.Drawing.Size(806, 49)
        Me.TimeWindowRowControl4.TabIndex = 10
        '
        'TimeWindowRowControl5
        '
        Me.TimeWindowRowControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl5.Location = New System.Drawing.Point(78, 278)
        Me.TimeWindowRowControl5.Name = "TimeWindowRowControl5"
        Me.TimeWindowRowControl5.Size = New System.Drawing.Size(806, 49)
        Me.TimeWindowRowControl5.TabIndex = 11
        '
        'TimeWindowRowControl6
        '
        Me.TimeWindowRowControl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl6.Location = New System.Drawing.Point(78, 333)
        Me.TimeWindowRowControl6.Name = "TimeWindowRowControl6"
        Me.TimeWindowRowControl6.Size = New System.Drawing.Size(806, 49)
        Me.TimeWindowRowControl6.TabIndex = 12
        '
        'TimeWindowRowControl7
        '
        Me.TimeWindowRowControl7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeWindowRowControl7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeWindowRowControl7.Location = New System.Drawing.Point(78, 388)
        Me.TimeWindowRowControl7.Name = "TimeWindowRowControl7"
        Me.TimeWindowRowControl7.Size = New System.Drawing.Size(806, 56)
        Me.TimeWindowRowControl7.TabIndex = 13
        '
        'TimeGaugePanel
        '
        Me.TimeGaugePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeGaugePanel.Location = New System.Drawing.Point(78, 3)
        Me.TimeGaugePanel.Name = "TimeGaugePanel"
        Me.TimeGaugePanel.Size = New System.Drawing.Size(806, 49)
        Me.TimeGaugePanel.TabIndex = 14
        '
        'TimeWindowControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutPanel)
        Me.Name = "TimeWindowControl"
        Me.Size = New System.Drawing.Size(893, 453)
        Me.LayoutPanel.ResumeLayout(False)
        Me.LayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutPanel As TableLayoutPanel
    Friend WithEvents lblMonday As Label
    Friend WithEvents lblTuesday As Label
    Friend WithEvents lblWednesday As Label
    Friend WithEvents lblThursday As Label
    Friend WithEvents lblFriday As Label
    Friend WithEvents lblSaturday As Label
    Friend WithEvents lblSunday As Label
    Friend WithEvents TimeWindowRowControl1 As TimeWindowRowControl
    Friend WithEvents TimeWindowRowControl2 As TimeWindowRowControl
    Friend WithEvents TimeWindowRowControl3 As TimeWindowRowControl
    Friend WithEvents TimeWindowRowControl4 As TimeWindowRowControl
    Friend WithEvents TimeWindowRowControl5 As TimeWindowRowControl
    Friend WithEvents TimeWindowRowControl6 As TimeWindowRowControl
    Friend WithEvents TimeWindowRowControl7 As TimeWindowRowControl
    Friend WithEvents TimeGaugePanel As TimeWindowChronologyPanel
End Class
