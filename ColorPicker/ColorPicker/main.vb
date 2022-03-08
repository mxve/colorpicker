Imports System.Runtime.InteropServices

Public Class main
#Region "DllImport"
    <DllImport("gdi32.dll")>
    Private Shared Function GetPixel(hdc As IntPtr, nXPos As Integer, nYPos As Integer) As UInteger
    End Function

    <DllImport("user32.dll")>
    Private Shared Function GetDC(hwnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ReleaseDC(hwnd As IntPtr, hdc As IntPtr) As Integer
    End Function
#End Region

    Private Function GetPixelColor(location As Point) As Color
        Dim hdc = GetDC(IntPtr.Zero)
        Dim pixel = GetPixel(hdc, location.X, location.Y)
        ReleaseDC(IntPtr.Zero, hdc)
        Dim color As Color = Color.FromArgb(pixel And &HFF,
                                            CInt(pixel And &HFF00) >> 8,
                                            CInt(pixel And &HFF0000) >> 16)
        Return color
    End Function

    Private MouseHook As New InputHelper.Hooks.MouseHook
    Private WithEvents mouseLock As New Form With {
        .FormBorderStyle = FormBorderStyle.None,
        .TransparencyKey = Color.Yellow,
        .BackColor = Color.Yellow,
        .TopMost = True,
        .ShowInTaskbar = False,
        .Cursor = Cursors.Cross
    }
    Private colorPreview As New Form With {
            .FormBorderStyle = FormBorderStyle.None,
            .TopMost = True
    }
    Private cursorPos As New Point(0, 0)

    Private Sub updateFormLocations(loc As Point)
        mouseLock.Location = New Point(loc.X - 64, loc.Y - 64)
        colorPreview.Location = New Point(loc.X + 12, loc.Y + 12)
    End Sub

    Private Sub MouseHook_MouseMove(sender As Object, e As InputHelper.EventArgs.MouseHookEventArgs)
        cursorPos = e.Location
        updateFormLocations(e.Location)
    End Sub

    Private Sub pickColor()
        AddHandler MouseHook.MouseMove, AddressOf MouseHook_MouseMove

        mouseLock.Show()
        colorPreview.Show()

        mouseLock.Size = New Point(128, 128)
        colorPreview.Size = New Point(16, 16)

        updateFormLocations(Cursor.Position)
        previewUpdater.Start()
    End Sub

    Private Sub showResult(clr As Color)
        Dim res As New result(clr)
        res.Show()
        Activate()
        res.Location = New Point(Location.X + 212, Location.Y)
        res.Activate()
    End Sub

    Private Sub mouseLock_Click(sender As Object, e As EventArgs) Handles mouseLock.Click
        RemoveHandler MouseHook.MouseMove, AddressOf MouseHook_MouseMove
        Dim color = GetPixelColor(cursorPos)

        previewUpdater.Stop()
        colorPreview.Hide()
        mouseLock.Hide()

        If history.Items.Count = 20 Then
            history.Items.RemoveAt(history.Items.Count - 1)
        End If
        history.Items.Insert(0, color)

        showResult(color)
    End Sub

    Private Sub previewUpdater_Tick(sender As Object, e As EventArgs) Handles previewUpdater.Tick
        colorPreview.BackColor = GetPixelColor(cursorPos)
    End Sub

    Private Sub history_Doubleclick(sender As Object, e As EventArgs) Handles history.DoubleClick
        showResult(history.SelectedItem)
    End Sub

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click
        pickColor()
    End Sub

    Private Sub history_DrawItem(sender As System.Object, e As DrawItemEventArgs) Handles history.DrawItem
        If e.Index < 0 Then Return
        e = New DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, history.Items(e.Index))
        e.DrawBackground()

        If Not (e.State And DrawItemState.Selected) <> DrawItemState.Selected Then
            Dim text As String = String.Format("{0}, {1}, {2}", history.Items(e.Index).r, history.Items(e.Index).g, history.Items(e.Index).b)

            e.Graphics.DrawString(text, e.Font, Brushes.White, New PointF(e.Bounds.X, e.Bounds.Y))
        End If

        e.DrawFocusRectangle()
    End Sub
End Class