Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Using conn As New SqlConnection("SERVER = localhost; Database = dbResto; Trusted_Connection=True;")
            conn.Open()

            Using cmd As New SqlCommand("SELECT u.*, p.profileName FROM _sysUsers u INNER JOIN _sysProfiles P ON u.idProfile = p.id", conn)
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        Dim headerText() As String = {"Kode", "Nama Pengguna", "Kata Sandi", "Nama Lengkap", "idProfile", "Diblok", "Profil"}
        Dim colVisible() As Boolean = {False, True, True, True, False, False, True}
        Dim colAlign() As DataGridViewContentAlignment = {DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter}
        Dim colWidth() As Integer = {0, 100, 100, 200, 0, 0, 100}
        DgvPaging1.ColumnsHeaderText.AddRange(headerText)
        DgvPaging1.ColumnsAlignment.AddRange(colAlign)
        DgvPaging1.ColumnsVisible.AddRange(colVisible)
        DgvPaging1.ColumnsWidth.AddRange(colWidth)
        DgvPaging1.DataSource = dt
    End Sub
End Class
