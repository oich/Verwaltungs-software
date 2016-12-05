<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Kunden = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Date_heute = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoB_beab = New System.Windows.Forms.ComboBox()
        Me.lb_abteilung = New System.Windows.Forms.ListBox()
        Me.brow_kunde = New System.Windows.Forms.WebBrowser()
        Me.Kundennummer = New System.Windows.Forms.Label()
        Me.But_anlg = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TE_KundenNR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TE_kunde = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TE_AuftragNR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TE_bennenung = New System.Windows.Forms.TextBox()
        Me.TE_kontakt = New System.Windows.Forms.TextBox()
        Me.brow_auftrag = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Einstellungen = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Txt_url_master = New System.Windows.Forms.TextBox()
        Me.Txt_url_main = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TE_SET_1 = New System.Windows.Forms.TextBox()
        Me.DauererVerwaltungauftraegemainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dauerer_Verwaltung_auftraege_main = New Verwaltung.Dauerer_Verwaltung_auftraege_main()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.FolderBrowser_main = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowser_master = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_addurl_main = New System.Windows.Forms.Button()
        Me.btn_addurl_master = New System.Windows.Forms.Button()
        Me.Kunden.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Einstellungen.SuspendLayout()
        CType(Me.DauererVerwaltungauftraegemainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dauerer_Verwaltung_auftraege_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kunden
        '
        Me.Kunden.Controls.Add(Me.TabPage1)
        Me.Kunden.Controls.Add(Me.TabPage2)
        Me.Kunden.Controls.Add(Me.TabPage3)
        Me.Kunden.Controls.Add(Me.Einstellungen)
        Me.Kunden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Kunden.Location = New System.Drawing.Point(0, 0)
        Me.Kunden.Name = "Kunden"
        Me.Kunden.SelectedIndex = 0
        Me.Kunden.Size = New System.Drawing.Size(1904, 1041)
        Me.Kunden.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Date_heute)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CoB_beab)
        Me.TabPage1.Controls.Add(Me.lb_abteilung)
        Me.TabPage1.Controls.Add(Me.brow_kunde)
        Me.TabPage1.Controls.Add(Me.Kundennummer)
        Me.TabPage1.Controls.Add(Me.But_anlg)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TE_KundenNR)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TE_kunde)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TE_AuftragNR)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TE_bennenung)
        Me.TabPage1.Controls.Add(Me.TE_kontakt)
        Me.TabPage1.Controls.Add(Me.brow_auftrag)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1896, 1015)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kunden"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(998, 67)
        Me.DataGridView1.TabIndex = 18
        '
        'Date_heute
        '
        Me.Date_heute.Location = New System.Drawing.Point(722, 28)
        Me.Date_heute.Name = "Date_heute"
        Me.Date_heute.Size = New System.Drawing.Size(200, 20)
        Me.Date_heute.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(445, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Bearbeiter"
        '
        'CoB_beab
        '
        Me.CoB_beab.FormattingEnabled = True
        Me.CoB_beab.Items.AddRange(New Object() {"AE", "AH", "OD"})
        Me.CoB_beab.Location = New System.Drawing.Point(448, 28)
        Me.CoB_beab.Name = "CoB_beab"
        Me.CoB_beab.Size = New System.Drawing.Size(52, 21)
        Me.CoB_beab.TabIndex = 15
        '
        'lb_abteilung
        '
        Me.lb_abteilung.FormattingEnabled = True
        Me.lb_abteilung.Items.AddRange(New Object() {"Lohnfertigung", "Vorrichtungsbau"})
        Me.lb_abteilung.Location = New System.Drawing.Point(3, 5)
        Me.lb_abteilung.Name = "lb_abteilung"
        Me.lb_abteilung.Size = New System.Drawing.Size(120, 43)
        Me.lb_abteilung.TabIndex = 14
        '
        'brow_kunde
        '
        Me.brow_kunde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.brow_kunde.Location = New System.Drawing.Point(5, 127)
        Me.brow_kunde.MinimumSize = New System.Drawing.Size(20, 20)
        Me.brow_kunde.Name = "brow_kunde"
        Me.brow_kunde.Size = New System.Drawing.Size(206, 879)
        Me.brow_kunde.TabIndex = 7
        '
        'Kundennummer
        '
        Me.Kundennummer.AutoSize = True
        Me.Kundennummer.Location = New System.Drawing.Point(130, 3)
        Me.Kundennummer.Name = "Kundennummer"
        Me.Kundennummer.Size = New System.Drawing.Size(81, 13)
        Me.Kundennummer.TabIndex = 9
        Me.Kundennummer.Text = "Kundennummer"
        '
        'But_anlg
        '
        Me.But_anlg.Location = New System.Drawing.Point(928, 28)
        Me.But_anlg.Name = "But_anlg"
        Me.But_anlg.Size = New System.Drawing.Size(75, 23)
        Me.But_anlg.TabIndex = 0
        Me.But_anlg.Text = "Anlegen"
        Me.But_anlg.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(612, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ansprechpartner"
        '
        'TE_KundenNR
        '
        Me.TE_KundenNR.Location = New System.Drawing.Point(129, 28)
        Me.TE_KundenNR.MaxLength = 5
        Me.TE_KundenNR.Name = "TE_KundenNR"
        Me.TE_KundenNR.Size = New System.Drawing.Size(100, 20)
        Me.TE_KundenNR.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(506, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Bennenung"
        '
        'TE_kunde
        '
        Me.TE_kunde.Location = New System.Drawing.Point(235, 28)
        Me.TE_kunde.Name = "TE_kunde"
        Me.TE_kunde.Size = New System.Drawing.Size(100, 20)
        Me.TE_kunde.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Auftragsnummer"
        '
        'TE_AuftragNR
        '
        Me.TE_AuftragNR.Location = New System.Drawing.Point(341, 28)
        Me.TE_AuftragNR.MaxLength = 4
        Me.TE_AuftragNR.Name = "TE_AuftragNR"
        Me.TE_AuftragNR.Size = New System.Drawing.Size(100, 20)
        Me.TE_AuftragNR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kunde"
        '
        'TE_bennenung
        '
        Me.TE_bennenung.Location = New System.Drawing.Point(509, 28)
        Me.TE_bennenung.Name = "TE_bennenung"
        Me.TE_bennenung.Size = New System.Drawing.Size(100, 20)
        Me.TE_bennenung.TabIndex = 4
        '
        'TE_kontakt
        '
        Me.TE_kontakt.Location = New System.Drawing.Point(615, 28)
        Me.TE_kontakt.Name = "TE_kontakt"
        Me.TE_kontakt.Size = New System.Drawing.Size(100, 20)
        Me.TE_kontakt.TabIndex = 5
        '
        'brow_auftrag
        '
        Me.brow_auftrag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.brow_auftrag.Location = New System.Drawing.Point(217, 127)
        Me.brow_auftrag.MinimumSize = New System.Drawing.Size(20, 20)
        Me.brow_auftrag.Name = "brow_auftrag"
        Me.brow_auftrag.Size = New System.Drawing.Size(786, 880)
        Me.brow_auftrag.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1896, 1015)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1896, 1015)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Einstellungen
        '
        Me.Einstellungen.Controls.Add(Me.btn_addurl_master)
        Me.Einstellungen.Controls.Add(Me.btn_addurl_main)
        Me.Einstellungen.Controls.Add(Me.Label17)
        Me.Einstellungen.Controls.Add(Me.Label16)
        Me.Einstellungen.Controls.Add(Me.Label15)
        Me.Einstellungen.Controls.Add(Me.Label14)
        Me.Einstellungen.Controls.Add(Me.Label13)
        Me.Einstellungen.Controls.Add(Me.Label12)
        Me.Einstellungen.Controls.Add(Me.Label11)
        Me.Einstellungen.Controls.Add(Me.Label10)
        Me.Einstellungen.Controls.Add(Me.Label9)
        Me.Einstellungen.Controls.Add(Me.label8)
        Me.Einstellungen.Controls.Add(Me.Label7)
        Me.Einstellungen.Controls.Add(Me.Label6)
        Me.Einstellungen.Controls.Add(Me.TextBox11)
        Me.Einstellungen.Controls.Add(Me.TextBox10)
        Me.Einstellungen.Controls.Add(Me.TextBox9)
        Me.Einstellungen.Controls.Add(Me.TextBox8)
        Me.Einstellungen.Controls.Add(Me.TextBox7)
        Me.Einstellungen.Controls.Add(Me.TextBox6)
        Me.Einstellungen.Controls.Add(Me.TextBox5)
        Me.Einstellungen.Controls.Add(Me.TextBox4)
        Me.Einstellungen.Controls.Add(Me.Txt_url_master)
        Me.Einstellungen.Controls.Add(Me.Txt_url_main)
        Me.Einstellungen.Controls.Add(Me.TextBox1)
        Me.Einstellungen.Controls.Add(Me.TE_SET_1)
        Me.Einstellungen.Location = New System.Drawing.Point(4, 22)
        Me.Einstellungen.Name = "Einstellungen"
        Me.Einstellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.Einstellungen.Size = New System.Drawing.Size(1896, 1015)
        Me.Einstellungen.TabIndex = 3
        Me.Einstellungen.Text = "Einstellungen"
        Me.Einstellungen.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(178, 219)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Txt_url_master
        '
        Me.Txt_url_master.Location = New System.Drawing.Point(178, 192)
        Me.Txt_url_master.Name = "Txt_url_master"
        Me.Txt_url_master.Size = New System.Drawing.Size(213, 20)
        Me.Txt_url_master.TabIndex = 3
        '
        'Txt_url_main
        '
        Me.Txt_url_main.Location = New System.Drawing.Point(178, 166)
        Me.Txt_url_main.Name = "Txt_url_main"
        Me.Txt_url_main.Size = New System.Drawing.Size(213, 20)
        Me.Txt_url_main.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TE_SET_1
        '
        Me.TE_SET_1.Location = New System.Drawing.Point(178, 114)
        Me.TE_SET_1.Name = "TE_SET_1"
        Me.TE_SET_1.Size = New System.Drawing.Size(213, 20)
        Me.TE_SET_1.TabIndex = 0
        '
        'DauererVerwaltungauftraegemainBindingSource
        '
        Me.DauererVerwaltungauftraegemainBindingSource.DataSource = Me.Dauerer_Verwaltung_auftraege_main
        Me.DauererVerwaltungauftraegemainBindingSource.Position = 0
        '
        'Dauerer_Verwaltung_auftraege_main
        '
        Me.Dauerer_Verwaltung_auftraege_main.DataSetName = "Dauerer_Verwaltung_auftraege_main"
        Me.Dauerer_Verwaltung_auftraege_main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(178, 401)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(213, 20)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(178, 375)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(213, 20)
        Me.TextBox6.TabIndex = 6
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(178, 349)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(213, 20)
        Me.TextBox7.TabIndex = 7
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(178, 323)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(213, 20)
        Me.TextBox8.TabIndex = 8
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(178, 297)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(213, 20)
        Me.TextBox9.TabIndex = 9
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(178, 271)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(213, 20)
        Me.TextBox10.TabIndex = 10
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(178, 245)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(213, 20)
        Me.TextBox11.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Benutzer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Passwort"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(63, 166)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(93, 13)
        Me.label8.TabIndex = 14
        Me.label8.Text = "Haupt-Verzeichnis"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Master-Ordner"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(63, 349)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(63, 375)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(63, 401)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Label17"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'btn_addurl_main
        '
        Me.btn_addurl_main.Location = New System.Drawing.Point(398, 166)
        Me.btn_addurl_main.Name = "btn_addurl_main"
        Me.btn_addurl_main.Size = New System.Drawing.Size(33, 23)
        Me.btn_addurl_main.TabIndex = 24
        Me.btn_addurl_main.Text = "..."
        Me.btn_addurl_main.UseVisualStyleBackColor = True
        '
        'btn_addurl_master
        '
        Me.btn_addurl_master.Location = New System.Drawing.Point(398, 192)
        Me.btn_addurl_master.Name = "btn_addurl_master"
        Me.btn_addurl_master.Size = New System.Drawing.Size(33, 23)
        Me.btn_addurl_master.TabIndex = 25
        Me.btn_addurl_master.Text = "..."
        Me.btn_addurl_master.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Kunden)
        Me.Name = "Form1"
        Me.Text = "Verwaltung"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Kunden.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Einstellungen.ResumeLayout(False)
        Me.Einstellungen.PerformLayout()
        CType(Me.DauererVerwaltungauftraegemainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dauerer_Verwaltung_auftraege_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Kunden As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents But_anlg As Button
    Friend WithEvents TE_KundenNR As TextBox
    Friend WithEvents TE_kunde As TextBox
    Friend WithEvents TE_AuftragNR As TextBox
    Friend WithEvents TE_bennenung As TextBox
    Friend WithEvents TE_kontakt As TextBox
    Friend WithEvents brow_auftrag As WebBrowser
    Friend WithEvents Kundennummer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents brow_kunde As WebBrowser
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Einstellungen As TabPage
    Friend WithEvents lb_abteilung As ListBox
    Friend WithEvents CoB_beab As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Date_heute As DateTimePicker
    Friend WithEvents TE_SET_1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Txt_url_master As TextBox
    Friend WithEvents Txt_url_main As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DauererVerwaltungauftraegemainBindingSource As BindingSource
    Friend WithEvents Dauerer_Verwaltung_auftraege_main As Dauerer_Verwaltung_auftraege_main
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btn_addurl_master As Button
    Friend WithEvents btn_addurl_main As Button
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents FolderBrowser_main As FolderBrowserDialog
    Friend WithEvents FolderBrowser_master As FolderBrowserDialog
End Class
