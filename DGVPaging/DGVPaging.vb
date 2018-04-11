Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms




<ToolboxItem(True)>
<ToolboxBitmap(GetType(DataGridView))>
Public Class DGVPaging
#Region "Public Properties"
#Region "Buttons Settings"
    Public Property ButtonFirstText As String
        Get
            Return btnFirst.Text
        End Get
        Set(value As String)
            btnFirst.Text = value
        End Set
    End Property

    Public Property ButtonPreviousText As String
        Get
            Return btnPrevious.Text
        End Get
        Set(value As String)
            btnPrevious.Text = value
        End Set
    End Property

    Public Property ButtonNextText As String
        Get
            Return btnNext.Text
        End Get
        Set(value As String)
            btnNext.Text = value
        End Set
    End Property

    Public Property ButtonLastText As String
        Get
            Return btnLast.Text
        End Get
        Set(value As String)
            btnLast.Text = value
        End Set
    End Property

    Public Property ButtonsWidth As Integer
        Get
            Return btnFirst.Width
        End Get
        Set(value As Integer)
            btnFirst.Width = value
            btnLast.Width = value
            btnNext.Width = value
            btnPrevious.Width = value
        End Set
    End Property

    Public Property ButtonsHeight As Integer
        Get
            Return btnFirst.Height
        End Get
        Set(value As Integer)
            btnFirst.Height = value
            btnLast.Height = value
            btnNext.Height = value
            btnPrevious.Height = value
            lblCounter.Height = value
        End Set
    End Property

    Public Property ButtonsFont As Font
        Get
            Return btnFirst.Font
        End Get
        Set(value As Font)
            btnFirst.Font = value
            btnLast.Font = value
            btnNext.Font = value
            btnPrevious.Font = value
        End Set
    End Property

    Public Property ButtonsBackColor As Color
        Get
            Return btnFirst.BackColor
        End Get
        Set(value As Color)
            btnFirst.BackColor = value
            btnLast.BackColor = value
            btnNext.BackColor = value
            btnPrevious.BackColor = value
        End Set
    End Property

    Public Property ButtonsBorderColor As Color
        Get
            Return btnFirst.FlatAppearance.BorderColor
        End Get
        Set(value As Color)
            btnFirst.FlatAppearance.BorderColor = value
            btnLast.FlatAppearance.BorderColor = value
            btnNext.FlatAppearance.BorderColor = value
            btnPrevious.FlatAppearance.BorderColor = value
        End Set
    End Property

    Public Property ButtonsForeColor As Color
        Get
            Return btnFirst.ForeColor
        End Get
        Set(value As Color)
            btnFirst.ForeColor = value
            btnLast.ForeColor = value
            btnNext.ForeColor = value
            btnPrevious.ForeColor = value
        End Set
    End Property
#End Region

#Region "DataGridView Settings"
    Private _defaultBackDisable As Color = Color.DimGray
    Private _headerBackDisable As Color = Color.FromArgb(&H2A, &H2A, &H2A)
    Private _altBackDisable As Color = Color.Gray
    Private _foreDisable As Color = Color.White

    Private _backgroundColor As Color
    Private _defaultBackColor As Color
    Private _headerBackColor As Color
    Private _selectedBackColor As Color
    Private _altBackColor As Color

    Private _headerForeColor As Color
    Private _defaultForeColor As Color
    Private _altForeColor As Color
    Private _selectedForeColor As Color

    Public Property CellStyleAlternatingRows As DataGridViewCellStyle
        Get
            Return dgv.AlternatingRowsDefaultCellStyle
        End Get
        Set(value As DataGridViewCellStyle)
            dgv.AlternatingRowsDefaultCellStyle = value
        End Set
    End Property

    Public Property CellStyleColumnHeaders As DataGridViewCellStyle
        Get
            Return dgv.ColumnHeadersDefaultCellStyle
        End Get
        Set(value As DataGridViewCellStyle)
            dgv.ColumnHeadersDefaultCellStyle = value
        End Set
    End Property

    Public Property CellStyleDefaultRows As DataGridViewCellStyle
        Get
            Return dgv.DefaultCellStyle
        End Get
        Set(value As DataGridViewCellStyle)
            dgv.DefaultCellStyle = value
        End Set
    End Property

    Public Property CellStyleMultiSelection As Boolean
        Get
            Return dgv.MultiSelect
        End Get
        Set(value As Boolean)
            dgv.MultiSelect = value
        End Set
    End Property

    Public Property CellStyleSelectionMode As DataGridViewSelectionMode
        Get
            Return dgv.SelectionMode
        End Get
        Set(value As DataGridViewSelectionMode)
            dgv.SelectionMode = value
        End Set
    End Property

    Public Property CellStyleAutoSizeColumns As DataGridViewAutoSizeColumnsMode
        Get
            Return dgv.AutoSizeColumnsMode
        End Get
        Set(value As DataGridViewAutoSizeColumnsMode)
            dgv.AutoSizeColumnsMode = value
        End Set
    End Property

    Public Property CellStyleAutoSizeRows As DataGridViewAutoSizeRowsMode
        Get
            Return dgv.AutoSizeRowsMode
        End Get
        Set(value As DataGridViewAutoSizeRowsMode)
            dgv.AutoSizeRowsMode = value
        End Set
    End Property

    Public Property CellStyleColumnHeaderHeightSizeMode As DataGridViewColumnHeadersHeightSizeMode
        Get
            Return dgv.ColumnHeadersHeightSizeMode
        End Get
        Set(value As DataGridViewColumnHeadersHeightSizeMode)
            dgv.ColumnHeadersHeightSizeMode = value
        End Set
    End Property

    Public Property CellStyleColumnHeadersHeight As Integer
        Get
            Return dgv.ColumnHeadersHeight
        End Get
        Set(value As Integer)
            dgv.ColumnHeadersHeight = value
        End Set
    End Property

    Public Property CellStyleEnabledHeadersVisualStyles As Boolean
        Get
            Return dgv.EnableHeadersVisualStyles
        End Get
        Set(value As Boolean)
            dgv.EnableHeadersVisualStyles = value
        End Set
    End Property

    Public Property CellStyleRowsHeight As Integer
        Get
            Return dgv.RowTemplate.Height
        End Get
        Set(value As Integer)
            dgv.RowTemplate.Height = value
        End Set
    End Property

    Public Property CellStyleSelectionBorderWidth As Integer

    Public Property CellStyleSelectionBorderColor As Color

#End Region

#Region "Data Settings"
    Private objDataSource As Object

    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <AttributeProvider("System.ComponentModel.IListSource")> _
    Public Property DataSource As Object
        Get
            Return objDataSource
        End Get
        Set(value As Object)
            If TypeOf value Is DataTable OrElse TypeOf value Is IEnumerable OrElse TypeOf value Is List(Of Object) Then
                objDataSource = value
                dgv.DataSource = ShowData(1)
                Me.FormatGrid()
            End If
        End Set
    End Property

    Public Property ColumnsHeaderText As List(Of String)

    Public Property ColumnsWidth As List(Of Integer)

    Public Property ColumnsVisible As List(Of Boolean)

    Public Property ColumnsFormat As List(Of String)

    Public Property ColumnsAlignment As List(Of DataGridViewContentAlignment)

#End Region

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            dgv.Font = value
        End Set
    End Property

    Public Property FontCounterLabel As Font
        Get
            Return lblCounter.Font
        End Get
        Set(value As Font)
            lblCounter.Font = value
        End Set
    End Property

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            dgv.BackgroundColor = value
            pnlButtons.BackColor = value
        End Set
    End Property

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overloads Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
            dgv.ForeColor = value
        End Set
    End Property

    Private intPageSize As Integer

    Public Property PageSize As Integer
        Get
            Return intPageSize
        End Get
        Set(value As Integer)
            dgv.SuspendLayout()
            dgv.Dock = DockStyle.None
            If value < 0 Then value = 0
            intPageSize = value
            If value > 0 Then
                pnlButtons.Visible = True
            Else
                pnlButtons.Visible = False
            End If
            dgv.Dock = DockStyle.Fill
            dgv.ResumeLayout()
            Me.Invalidate()
        End Set
    End Property

    Private intCurrentPage As Integer

    Public Property CurrentPage As Integer
        Get
            Return intCurrentPage
        End Get
        Set(value As Integer)
            intCurrentPage = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' Class Constructure
    ''' </summary>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.Selectable, True)

        Me.DoubleBuffered = True
        Me.Cursor = Cursors.Hand
        Me.lblCounter.Text = "Page of "
        Me.CellStyleMultiSelection = False
        Me.CellStyleSelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.CellStyleAutoSizeRows = DataGridViewAutoSizeRowsMode.AllCells
        Me.CellStyleSelectionBorderWidth = 4

        MyBase.BackColor = dgv.BackgroundColor
        pnlButtons.BackColor = dgv.BackgroundColor
        MyBase.ForeColor = dgv.ForeColor
        Me.PageSize = 0
        Me.CurrentPage = 1
    End Sub
#Region "Private Events"

    Private Sub DGVPaging_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ColumnsHeaderText = New List(Of String)
        Me.ColumnsAlignment = New List(Of DataGridViewContentAlignment)
        Me.ColumnsFormat = New List(Of String)
        Me.ColumnsVisible = New List(Of Boolean)
        Me.ColumnsWidth = New List(Of Integer)
        dgv.Select()
    End Sub

    Private Sub DGVPaging_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        dgv.SuspendLayout()
        dgv.Dock = DockStyle.None
        dgv.Dock = DockStyle.Fill
        Me.RecalculateColumnsWidth()
        dgv.ResumeLayout(True)
    End Sub

    Private Sub dgv_GotFocus(sender As Object, e As EventArgs) Handles dgv.GotFocus
        Try
            dgv.CurrentCell = dgv.Rows(0).Cells(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pnlButtons_Resize(sender As Object, e As EventArgs) Handles pnlButtons.Resize
        Dim allControlsWidth As Integer = 0
        For Each ctrl As Control In pnlButtons.Controls
            allControlsWidth += ctrl.Margin.Left + ctrl.Margin.Right + ctrl.Width
        Next
        allControlsWidth -= btnFirst.Margin.Left

        If pnlButtons.Width > allControlsWidth Then
            btnFirst.Margin = New Padding(Math.Round((pnlButtons.Width - allControlsWidth) / 2, 0), btnFirst.Margin.Top, btnFirst.Margin.Right, btnFirst.Margin.Bottom)
        End If
    End Sub

    Private Sub _RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv.RowPostPaint
        If dgv.Rows(e.RowIndex).Selected Then
            Using p As New Pen(CellStyleSelectionBorderColor)
                Dim pWidth As Integer = CellStyleSelectionBorderWidth
                p.Width = pWidth

                Dim sWidth As Integer = 0
                For Each c As DataGridViewColumn In dgv.Columns
                    If c.Visible Then
                        sWidth += c.Width
                    End If
                Next

                Dim x As Integer = e.RowBounds.Left + (pWidth / 2)
                Dim y As Integer = e.RowBounds.Top + (pWidth / 2)
                Dim w As Integer = sWidth - pWidth
                Dim h As Integer = e.RowBounds.Height - pWidth

                e.Graphics.DrawRectangle(p, x, y, w, h)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
        SetEnabled(MyBase.Enabled)
    End Sub

    Private Sub _DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv.DataBindingComplete
        Me.SuspendLayout()
        Me.RecalculateColumnsWidth()
        Me.ResumeLayout(True)
    End Sub

    Private Sub ButtonsClick(sender As Object, e As EventArgs) Handles btnFirst.Click, btnLast.Click, btnNext.Click, btnPrevious.Click
        dgv.SuspendLayout()
        dgv.DataSource = Nothing
        Dim intPages As Integer = 0

        Select Case True
            Case TypeOf DataSource Is DataTable
                intPages = Math.Ceiling((DirectCast(DataSource, DataTable).Rows.Count) / PageSize)
            Case TypeOf DataSource Is List(Of Object)
                intPages = Math.Ceiling((DirectCast(DataSource, List(Of Object)).ToDataTable().Rows.Count) / PageSize)
            Case TypeOf DataSource Is IEnumerable
                intPages = Math.Ceiling((DirectCast(DataSource, IEnumerable).ToDataTable().Rows.Count) / PageSize)
        End Select

        Select Case DirectCast(sender, Button).Name
            Case btnFirst.Name
                CurrentPage = 1
            Case btnLast.Name
                If CurrentPage < intPages Then CurrentPage = intPages
            Case btnNext.Name
                If CurrentPage < intPages Then CurrentPage += 1
            Case btnPrevious.Name
                If CurrentPage > 1 Then CurrentPage -= 1
        End Select

        dgv.DataSource = ShowData(CurrentPage)
        Me.FormatGrid()
        dgv.ResumeLayout(True)
        dgv.Select()
    End Sub
#End Region

#Region "Private methods"
    Private Sub FormatGrid()

        If ColumnsAlignment IsNot Nothing And ColumnsAlignment.Count = dgv.Columns.Count Then
            For i = 0 To ColumnsAlignment.Count - 1
                dgv.Columns(i).DefaultCellStyle.Alignment = ColumnsAlignment.Item(i)
            Next
        End If

        If ColumnsFormat IsNot Nothing And ColumnsFormat.Count = dgv.Columns.Count Then
            For i = 0 To ColumnsFormat.Count - 1
                dgv.Columns(i).DefaultCellStyle.Format = ColumnsFormat.Item(i)
            Next
        End If

        If ColumnsHeaderText IsNot Nothing And ColumnsHeaderText.Count = dgv.Columns.Count Then
            For i = 0 To ColumnsHeaderText.Count - 1
                dgv.Columns(i).HeaderText = ColumnsHeaderText.Item(i)
            Next
        End If

        If ColumnsVisible IsNot Nothing And ColumnsVisible.Count = dgv.Columns.Count Then
            For i = 0 To ColumnsVisible.Count - 1
                dgv.Columns(i).Visible = ColumnsVisible.Item(i)
            Next
        End If

        If ColumnsWidth IsNot Nothing And ColumnsWidth.Count = dgv.Columns.Count Then
            For i = 0 To ColumnsWidth.Count - 1
                dgv.Columns(i).Width = ColumnsWidth.Item(i)
            Next
        End If

        Me.RecalculateColumnsWidth()
    End Sub

    Private Sub SetEnabled(enabled As Boolean)
        If Not enabled Then
            _backgroundColor = dgv.BackgroundColor
            _headerBackColor = dgv.ColumnHeadersDefaultCellStyle.BackColor
            _altBackColor = dgv.AlternatingRowsDefaultCellStyle.BackColor
            _selectedBackColor = dgv.DefaultCellStyle.SelectionBackColor
            _defaultBackColor = dgv.DefaultCellStyle.BackColor

            _headerForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor
            _altForeColor = dgv.AlternatingRowsDefaultCellStyle.ForeColor
            _defaultForeColor = dgv.DefaultCellStyle.ForeColor
            _selectedForeColor = dgv.DefaultCellStyle.SelectionForeColor

            dgv.BackgroundColor = _defaultBackDisable
            dgv.DefaultCellStyle.BackColor = _defaultBackDisable
            dgv.DefaultCellStyle.SelectionBackColor = _defaultBackDisable
            dgv.ColumnHeadersDefaultCellStyle.BackColor = _headerBackDisable
            dgv.AlternatingRowsDefaultCellStyle.BackColor = _altBackDisable

            dgv.ForeColor = _foreDisable
            dgv.DefaultCellStyle.ForeColor = _foreDisable
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = _foreDisable
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = _foreDisable
        Else
            dgv.BackgroundColor = _backgroundColor
            dgv.ColumnHeadersDefaultCellStyle.BackColor = _headerBackColor
            dgv.AlternatingRowsDefaultCellStyle.BackColor = _altBackColor
            dgv.DefaultCellStyle.BackColor = _defaultBackColor
            dgv.DefaultCellStyle.SelectionBackColor = _selectedBackColor

            dgv.ForeColor = Color.White
            dgv.DefaultCellStyle.ForeColor = _defaultForeColor
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = _headerForeColor
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = _altForeColor
            dgv.DefaultCellStyle.SelectionForeColor = _selectedForeColor
        End If
    End Sub

    Private Sub RecalculateColumnsWidth()
        If DesignMode Then Exit Sub

        dgv.SuspendLayout()
        Dim w As Double = Me.ClientRectangle.Width

        Dim xWidth As Integer = Me.ClientSize.Width - 5
        If QueryScrollControl.HasVerticalScrollbar(dgv) Then
            xWidth -= SystemInformation.VerticalScrollBarWidth
        End If

        Dim ColsWidth As Integer = 0
        Dim result As Integer

        For Each c As DataGridViewColumn In dgv.Columns
            ColsWidth += c.Width
        Next
        For Each c As DataGridViewColumn In dgv.Columns
            result = CInt((CSng(c.Width) / CSng(ColsWidth)) * CSng(xWidth))
            c.Width = result
        Next
        dgv.Width = CInt(w - (w * 0.3))
        dgv.ResumeLayout()
    End Sub

    Private Function ShowData(ByVal pageNumber As Integer) As DataTable
        Dim dt As New DataTable
        Dim result As New DataTable

        If TypeOf DataSource Is IEnumerable Then
            dt = DirectCast(DataSource, IEnumerable).ToDataTable
        ElseIf TypeOf DataSource Is List(Of Object) Then
            dt = DirectCast(DataSource, List(Of Object)).ToDataTable
        ElseIf TypeOf DataSource Is DataTable Then
            dt = DirectCast(DataSource, DataTable)
        End If

        If PageSize = 0 Then
            Return dt
        End If
        Dim startIndex = PageSize * (pageNumber - 1)
        Dim t = dt.AsEnumerable().Where(Function(s, k) (k >= startIndex AndAlso k < (startIndex + PageSize)))

        For Each column As DataColumn In dt.Columns
            result.Columns.Add(column.ColumnName)
        Next

        For Each item In t
            result.ImportRow(item)
        Next
        lblCounter.Text = String.Format("Page {0} of {1}", pageNumber, Math.Ceiling((dt.Rows.Count / PageSize)))
        Return result
    End Function
#End Region
End Class
