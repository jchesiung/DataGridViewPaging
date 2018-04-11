Imports System.Collections
Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices

Module extensions
    ''' <summary>
    ''' Convert List(Of T) to DataTable
    ''' </summary>
    ''' <typeparam name="T">Object</typeparam>
    ''' <param name="list">List(Of T)</param>
    ''' <returns>DataTable</returns>
    <Extension>
    Public Function ToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim dt As New DataTable
        Dim fields() As FieldInfo = GetType(T).GetFields()

        For Each field As FieldInfo In fields
            dt.Columns.Add(field.Name, field.FieldType)
        Next
        For Each item As T In list
            Dim row As DataRow = dt.NewRow
            For Each field As FieldInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

    ''' <summary>
    ''' Convert IEnumerable to DataTable
    ''' </summary>
    ''' <param name="list">List of IEnumerable</param>
    ''' <returns>DataTable</returns>
    <Extension>
    Public Function ToDataTable(ByVal list As IEnumerable) As DataTable
        Dim dt As New DataTable

        Try
            Dim ppi As System.Reflection.PropertyInfo() = Nothing
            If list IsNot Nothing Then
                For Each itm In list
                    If ppi Is Nothing Then
                        ppi = DirectCast(itm.[GetType](), System.Type).GetProperties()
                        For Each pi As System.Reflection.PropertyInfo In ppi
                            Dim colType As System.Type = pi.PropertyType
                            If (colType.IsGenericType) AndAlso
                               (colType.GetGenericTypeDefinition() Is GetType(System.Nullable(Of ))) Then colType = colType.GetGenericArguments()(0)
                            dt.Columns.Add(New System.Data.DataColumn(pi.Name, colType))
                        Next
                    End If
                    Dim dr As System.Data.DataRow = dt.NewRow
                    For Each pi As System.Reflection.PropertyInfo In ppi
                        dr(pi.Name) = If(pi.GetValue(itm, Nothing) Is Nothing, DBNull.Value, pi.GetValue(itm, Nothing))
                    Next
                    dt.Rows.Add(dr)
                Next
                For Each c As System.Data.DataColumn In dt.Columns
                    c.ColumnName = c.ColumnName.Replace("_", " ")
                Next
            End If
        Catch ex As Exception
        End Try
        Return dt
    End Function
End Module
