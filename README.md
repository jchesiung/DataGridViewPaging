# DataGridViewPaging
VB.Net Custom Control DataGridView with Paging

Berhubung control DataGridViewnya (demikian juga dgn Buttons) saya enkapsulasi di dalam user control, maka property property dari DataGridViewnya sendiri "tertutup" dari luar. Oleh sebab itu, saya menyediakan beberapa custom Property yang menjadi "penghubung" ke property DataGridView.

CellStyleAlternatingRows ini berhubungan dengan property AlternatingRowsDefaultCellStyle, yaitu mengatur tampilan Row genap, misalnya warna BackColor, ForeColor, Font, dll.

CellStyleAutoSizeColumns dan CellStyleAutoSizeRows ini berhubungan dengan property AutoSizeColumnsMode dan AutoSizeRowsMode yang mengatur Width/Height dari Columns/Rows secara otomatis atau tidak.

CellStyleColumnHeaderHeightSizeMode ini berhubungan dengan property ColumnHeadersHeightSizeMode yang pilihannya bisa berupa DisableResizing, EnableResizing atau AutoSize untuk header Columns.

CellStyleColumnHeaders berhubungan dengan property ColumnHeadersDefaultCellStyle yang mengatur tampilan header columns.

CellStyleColumnHeadersHeight berhubungan dengan property ColumnHeadersHeight yang mengatur tinggi header columns.

CellStyleEnabledHeadersVisualStyles berhubungan dengan property EnableHeadersVisualStyles, bila kita hendak mengkostum tampilan Header Columns, maka property ini wajib diset menjadi FALSE.

CellStyleDefaultRows berhubungan dengan property DefaultCellStyle yang mengatur tampilan cell secara keseluruhan seperti BackColor, ForeColor, SelectedBackColor, SelectedForeColor, Font, dll.

CellStyleMultiSelection berhubungan dengan property MultiSelect yang menentukan apakah membolehkan memilih lebih dari satu row atau tidak.

CellStyleRowsHeight berhubungan dengan property RowTemplate.Height yang mengatur tinggi Row secara default.

CellStyleSelectionMode berhubungan dengan property SelectionMode yang mengatur cara pemilihan seperti CellSelect, FullRowSelect, FullColumnSelect, dll.

CellStyleSelectionBorderColor merupakan property tambahan yang menentukan warna bingkai Selection yang akan dipakai berbarengan dengan property CellStyleSelectionBorderWidth dalam event DataGridView OnPaint.

CellStyleSelectionBorderWidth merupakan property tambahan yang menentukan lebar bingkai yang akan digambar di sekeliling Selection.

Untuk property yang berhubungan dengan Buttons:
Catatan kaki: Buttons disini menggunakan Control Button dengan settingan property FlatStyle = Flat, sehingga tampilan Buttonnya datar dan memiliki Bingkai.

ButtonFirstText berhubungan dengan property btnFirst.Text, yang mengatur Text dari tombol btnFirst.

ButtonLastText berhubungan dengan property btnLast.Text yang mengatur Text dari tombol btnLast.

ButtonNextText berhubungan dengan property btnNext.Text yang mengatur Text dari tombol btnNext.

ButtonPreviousText berhubungan dengan property btnPrevious.Text yang mengatur Text dari tombol btnPrevious.

ButtonsBackColor berhubungan dengan property BackColor dari semua Buttons.

ButtonsBorderColor berhubungan dengan property FlatAppearance.BorderColor dari semua Buttons untuk memberikan warna bingkai pada Buttons.

ButtonsFont berhubungan dengan property Font dari semua Buttons yang mengatur jenis dan bentuk tulisan.

ButtonsForeColor berhubungan dengan property ForeColor dari semua Buttons yang mengatur warna latar depan (tulisan).

ButtonsHeight dan ButtonsWidth berhubungan dengan property Height dan Width dari semua Buttons yang mengatur tinggi dan lebar Button.

DataSource sendiri adalah propety mandiri yang bertipe Object, untuk menampung object sumber data untuk DataGridView.

Untuk saat ini sumber data yang dapat diterima haruslah bertipe DataTable, List (of Object) dan IEnumerable.

Berikut ini adalah property yang bersifat optional, bisa dipakai tetapi tidak wajib, karena berfungsi untuk mengatur tampilan columns DataGridView.

ColumnsAlignment berhubungan dengan property Columns(i).DefaultCellStyle.Alignment dari DataGridView yang mengatur posisi text pada column tersebut apakah rata kanan, tengah, atau kiri.

ColumnsFormat berhubungan dengan property Columns(i).DefaultCellStyle.Format dari DataGridView yang mengatur format string dari column tersebut, misalkan untuk format DateTime.

ColumnsHeaderText berhubungan dengan property Columns(i).HeaderText dari DataGridView yang mengatur Text di header column. Ini dipakai bila kita tidak ingin menggunakan default Field Name dari DataSource.

ColumnsVisible berhubungan dengan property Columns(i).Visible dari DataGridView yang mengatur visibilitas masing masing columns. Ini dipakai bila tidak semua Fields dari DataSource ingin kita tampilkan.

ColumnsWidth berhubungan dengan property Columns(i).Width dari DataGridView bila kita ingin mengatur lebar masing masing column. Untuk bisa menggunakan property ini, maka property CellStyleAutoSizeColumns wajib diset menjadi None.

untuk property umum lainnya:

BackColor untuk mengatur BackgroundColor pada DataGridView dan BackColor pada control ini dan pnlButtons.

CurrentPage untuk mencatat nomor halaman terkini.

Font untuk mengatur jenis Font dari control dan DataGridView.

FontCounterLabel untuk mengatur jenis Font dari control lblCounter yang menampilkan "Page n Of m".

ForeColor untuk mengatur ForeColor control dan DataGridView.

PageSize untuk mengatur jumlah Row per Page yang mana bila terisi dengan 0 (nol), maka Buttons akan disembunyikan.
