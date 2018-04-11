Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class QueryScrollControl

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    Private Const GWL_STYLE As Short = (-16)

    Public Shared Function HasHorizontalScrollbar(ByVal ctrl As Control) As Boolean

        Const WS_HSCROLL As Integer = &H100000

        Return CBool(GetWindowLong(ctrl.Handle, GWL_STYLE) And WS_HSCROLL)
    End Function

    Public Shared Function HasVerticalScrollbar(ByVal ctrl As Control) As Boolean

        Const WS_VSCROLL As Integer = &H200000

        Return CBool(GetWindowLong(ctrl.Handle, GWL_STYLE) And WS_VSCROLL)
    End Function

End Class