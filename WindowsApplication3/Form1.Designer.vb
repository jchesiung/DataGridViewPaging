<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DgvPaging1 = New DGVPaging.DGVPaging()
        Me.SuspendLayout()
        '
        'DgvPaging1
        '
        Me.DgvPaging1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvPaging1.ButtonFirstText = "&Pertama"
        Me.DgvPaging1.ButtonLastText = "&Terakhir"
        Me.DgvPaging1.ButtonNextText = "&Lanjut"
        Me.DgvPaging1.ButtonPreviousText = "&Kembali"
        Me.DgvPaging1.ButtonsBackColor = System.Drawing.Color.Maroon
        Me.DgvPaging1.ButtonsBorderColor = System.Drawing.Color.Yellow
        Me.DgvPaging1.ButtonsFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvPaging1.ButtonsForeColor = System.Drawing.Color.Yellow
        Me.DgvPaging1.ButtonsHeight = 32
        Me.DgvPaging1.ButtonsWidth = 80
        Me.DgvPaging1.CellStyleAlternatingRows = DataGridViewCellStyle1
        Me.DgvPaging1.CellStyleAutoSizeColumns = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.DgvPaging1.CellStyleAutoSizeRows = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None
        Me.DgvPaging1.CellStyleColumnHeaderHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPaging1.CellStyleColumnHeaders = DataGridViewCellStyle2
        Me.DgvPaging1.CellStyleColumnHeadersHeight = 36
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPaging1.CellStyleDefaultRows = DataGridViewCellStyle3
        Me.DgvPaging1.CellStyleEnabledHeadersVisualStyles = False
        Me.DgvPaging1.CellStyleMultiSelection = False
        Me.DgvPaging1.CellStyleRowsHeight = 28
        Me.DgvPaging1.CellStyleSelectionBorderColor = System.Drawing.Color.Yellow
        Me.DgvPaging1.CellStyleSelectionBorderWidth = 2
        Me.DgvPaging1.CellStyleSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPaging1.ColumnsAlignment = CType(resources.GetObject("DgvPaging1.ColumnsAlignment"), System.Collections.Generic.List(Of System.Windows.Forms.DataGridViewContentAlignment))
        Me.DgvPaging1.ColumnsFormat = CType(resources.GetObject("DgvPaging1.ColumnsFormat"), System.Collections.Generic.List(Of String))
        Me.DgvPaging1.ColumnsHeaderText = CType(resources.GetObject("DgvPaging1.ColumnsHeaderText"), System.Collections.Generic.List(Of String))
        Me.DgvPaging1.ColumnsVisible = CType(resources.GetObject("DgvPaging1.ColumnsVisible"), System.Collections.Generic.List(Of Boolean))
        Me.DgvPaging1.ColumnsWidth = CType(resources.GetObject("DgvPaging1.ColumnsWidth"), System.Collections.Generic.List(Of Integer))
        Me.DgvPaging1.CurrentPage = 1
        Me.DgvPaging1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DgvPaging1.DataSource = Nothing
        Me.DgvPaging1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPaging1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvPaging1.FontCounterLabel = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvPaging1.ForeColor = System.Drawing.Color.White
        Me.DgvPaging1.Location = New System.Drawing.Point(0, 0)
        Me.DgvPaging1.Margin = New System.Windows.Forms.Padding(0)
        Me.DgvPaging1.Name = "DgvPaging1"
        Me.DgvPaging1.PageSize = 5
        Me.DgvPaging1.Size = New System.Drawing.Size(790, 550)
        Me.DgvPaging1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 550)
        Me.Controls.Add(Me.DgvPaging1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvPaging1 As DGVPaging.DGVPaging
End Class
