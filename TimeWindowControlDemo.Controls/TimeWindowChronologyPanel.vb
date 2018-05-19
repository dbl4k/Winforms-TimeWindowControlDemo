Public Class TimeWindowChronologyPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(
            ControlStyles.UserPaint Xor
            ControlStyles.AllPaintingInWmPaint Xor
            ControlStyles.OptimizedDoubleBuffer,
            True)

    End Sub

End Class
