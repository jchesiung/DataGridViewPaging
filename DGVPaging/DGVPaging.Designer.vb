<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVPaging
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.AutoSize = True
        Me.pnlButtons.Controls.Add(Me.btnFirst)
        Me.pnlButtons.Controls.Add(Me.btnPrevious)
        Me.pnlButtons.Controls.Add(Me.lblCounter)
        Me.pnlButtons.Controls.Add(Me.btnNext)
        Me.pnlButtons.Controls.Add(Me.btnLast)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 324)
        Me.pnlButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(560, 45)
        Me.pnlButtons.TabIndex = 0
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.DarkOrange
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(10, 5)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(10, 5, 10, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(80, 37)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Location = New System.Drawing.Point(100, 5)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(0, 5, 10, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(80, 37)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'lblCounter
        '
        Me.lblCounter.BackColor = System.Drawing.Color.DarkGreen
        Me.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCounter.Location = New System.Drawing.Point(190, 6)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(150, 32)
        Me.lblCounter.TabIndex = 2
        Me.lblCounter.Text = "Label1"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DarkOrange
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(350, 5)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(10, 5, 10, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(80, 37)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(440, 5)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(0, 5, 10, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(80, 37)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "&Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.ColumnHeadersHeight = 28
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowCellToolTips = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(560, 324)
        Me.dgv.StandardTab = True
        Me.dgv.TabIndex = 1
        '
        'DGVPaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlButtons)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "DGVPaging"
        Me.Size = New System.Drawing.Size(560, 369)
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlButtons As FlowLayoutPanel
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblCounter As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents dgv As DataGridView
End Class
