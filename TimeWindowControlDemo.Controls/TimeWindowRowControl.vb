Imports TimeWindowControlDemo.Controls

Public Class TimeWindowRowControl
    Private ReadOnly _items As New List(Of TimeWindowItemControl)

    Private _isPainting As Boolean = False
    Private _paintItem As TimeWindowItemControl = Nothing
    Private _paintItemStartX As Integer = -1

    Private _snapFactor As Integer = 25

    Private _minimumItemSize As Integer = 25

    Public Event TimelinePositionChanged(sender As Object, e As MouseEventArgs)

    Private Sub TimeWindowRowControl_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If Not _isPainting AndAlso Not MouseIsOverExistingItem(e.X) Then
            _isPainting = True

            _paintItemStartX = e.X

            _paintItem = New TimeWindowItemControl() _
                With {
                    .Visible = False,
                    .Top = 0,
                    .Height = Me.Height,
                    .Anchor = AnchorStyles.Top + AnchorStyles.Bottom
                }

            '    AddHandler _paintItem.RightHandleMouseDown, Item_RightHandleMouseDown(sender, e)
            AddHandler _paintItem.MouseDownOnBar, Item_MouseDown(sender, e)

            Me.Controls.Add(_paintItem)
            _items.Add(_paintItem)
        End If
    End Sub

    Private Function MouseIsOverExistingItem(mouseX As Integer) As Boolean
        Return GetItemsUnderMouse(mouseX).Count() > 1
    End Function

    Private Function GetItemsUnderMouse(mouseX As Integer) As IEnumerable(Of TimeWindowItemControl)
        Return _items.Where(Function(n) IsBetween(mouseX, n.Left, n.Right))
    End Function

    Private Sub TimeWindowRowControl_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        RaiseEvent TimelinePositionChanged(sender, e)

        If _isPainting Then
            If _paintItemStartX <> e.X Then
                _paintItem.Visible = True
                _paintItem.Left = GetNearestSnapValue(GetSmallest(_paintItemStartX, e.X))
                _paintItem.Width = GetNearestSnapValue(GetLargest(_paintItemStartX, e.X) - GetSmallest(_paintItemStartX, e.X))
            End If
        End If
    End Sub

    Private Sub TimeWindowRowControl_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If _isPainting Then
            _isPainting = False

            If OverlapsExisting(_paintItem) OrElse
               IsLessThanMinimumSize(_paintItem) Then

                _items.Remove(_paintItem)
                _paintItem.Visible = False
            End If

            _paintItem = Nothing
        End If
    End Sub

    Private Function OverlapsExisting(item As TimeWindowItemControl) As Boolean
        Return _items.Where(Function(n) Not n.Equals(item) AndAlso
                                 (isBetween(item.Left, n.Left, n.Right) OrElse
                                  isBetween(item.Right, n.Left, n.Right) OrElse
                                  isOverlaying(item.Left, item.Right, n.Left, n.Right))
                     ).Count > 0
    End Function

    Private Function IsBetween(value As Integer, lowerBound As Integer, upperBound As Integer) As Boolean
        Return (value > lowerBound AndAlso value < upperBound)
    End Function

    Private Shared Function IsOverlaying(lowerValue As Integer, upperValue As Integer, lowerBound As Integer, upperBound As Integer) As Boolean
        Return (lowerValue < lowerBound AndAlso upperValue > upperBound)
    End Function

    Private Function GetNearestSnapValue(value As Integer) As Integer
        Return Math.Round(value / _snapFactor) * _snapFactor
    End Function

    Private Function IsLessThanMinimumSize(item As TimeWindowItemControl) As Boolean
        Return item.Width < _minimumItemSize
    End Function

    Private Function GetLargest(value1 As Integer, value2 As Integer) As Integer
        Return If(value1 > value2, value1, value2)
    End Function

    Private Function GetSmallest(value1 As Integer, value2 As Integer) As Integer
        Return If(value1 < value2, value1, value2)
    End Function

    'Private Function Item_RightHandleMouseDown(sender As Object, e As MouseEventArgs) As TimeWindowItemControl.RightHandleMouseDownEventHandler
    '    If Not _isPainting Then
    '        Debug.WriteLine("mouse down on " & DirectCast(sender, TimeWindowItemControl).Name)
    '    End If

    '    Return Nothing
    'End Function

    Public Function Item_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            _items.Remove(sender)
            sender.Visible = False
        End If

        Return Nothing
    End Function

End Class
