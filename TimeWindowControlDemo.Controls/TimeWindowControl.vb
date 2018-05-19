Public Class TimeWindowControl

    Private _mousePos As New Point
    Private _mousePosTime As Date = Today.Date

    Public Property StartTime As DateTime = Today.Date
    Public Property EndTime As DateTime = Today.Date.AddDays(1).AddMilliseconds(-1)

    Private Sub TimeGaugePanel_Paint(sender As Object, e As PaintEventArgs) Handles TimeGaugePanel.Paint
        Dim blackpen As Pen = New Pen(Color.FromArgb(255, 0, 0, 0))
        Dim bluepen As Pen = New Pen(Color.FromArgb(255, 25, 25, 255))


        Dim totalHours = GetDuration(StartTime, EndTime).TotalHours
        For i As Integer = 0 To totalHours
            Dim point_time = (StartTime.AddHours(i))
            Dim xpos = GetPositionFromTime(point_time, 0, sender.width)
            e.Graphics.DrawLine(blackpen, xpos, 35, xpos, Me.Height)
            e.Graphics.DrawString(point_time.ToString("HH:mm"), SystemFonts.DefaultFont, Brushes.Black, New PointF(xpos - 10, 20))
        Next

        ' draw current mouse position line + label
        e.Graphics.DrawLine(bluepen, _mousePos.X, 0, _mousePos.X, Me.Height)
        e.Graphics.DrawString(_mousePosTime.ToString("HH:mm"), SystemFonts.DefaultFont, Brushes.MidnightBlue, New PointF(_mousePos.X + 10, 0))

        blackpen.Dispose()
        bluepen.Dispose()
    End Sub

    Private Sub TimeWindowRowControl1_TimelinePositionChanged(sender As Object, e As MouseEventArgs) Handles TimeWindowRowControl7.TimelinePositionChanged,
                                                                                                             TimeWindowRowControl6.TimelinePositionChanged,
                                                                                                             TimeWindowRowControl5.TimelinePositionChanged,
                                                                                                             TimeWindowRowControl4.TimelinePositionChanged,
                                                                                                             TimeWindowRowControl3.TimelinePositionChanged,
                                                                                                             TimeWindowRowControl2.TimelinePositionChanged,
                                                                                                             TimeWindowRowControl1.TimelinePositionChanged
        _mousePos.X = e.X
        _mousePos.Y = e.Y
        _mousePosTime = GetMousePositionTime(sender, e.X)

        TimeGaugePanel.Invalidate()
    End Sub

    Private Function GetMousePositionTime(control As TimeWindowRowControl, mouseX As Integer) As Date
        Dim transposedSeconds As Integer = GetDuration(StartTime, EndTime).TotalSeconds / control.Width * mouseX
        Return StartTime.AddSeconds(transposedSeconds)
    End Function

    Private Function GetPositionFromTime(value As DateTime, lowerBound As Integer, upperBound As Integer) As Integer
        Dim totalWidth = upperBound - lowerBound
        Return totalWidth / (GetDuration(StartTime, EndTime).TotalSeconds) * (value - StartTime).TotalSeconds
    End Function

    Private Function GetDuration(startTime As Date, endTime As Date) As TimeSpan
        Return endTime - startTime
    End Function

    Private Function TimeGaugePanel_OnResize(sender As Object, e As EventArgs) Handles TimeGaugePanel.Resize
        sender.Invalidate()

        Return Nothing
    End Function

End Class
