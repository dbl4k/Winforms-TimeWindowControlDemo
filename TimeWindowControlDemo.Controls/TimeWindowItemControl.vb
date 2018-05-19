Public Class TimeWindowItemControl

    '  Public Event MouseDown(sender As Object, e As MouseEventArgs)

    Public Event MouseDownOnBar(sender As Object, e As MouseEventArgs)

    Public Function MouseDown_Handler(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        RaiseEvent MouseDownOnBar(sender, e)
    End Function




End Class
