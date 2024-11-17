<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.zadej_a = New System.Windows.Forms.TextBox()
        Me.zadej_c = New System.Windows.Forms.TextBox()
        Me.zadej_b = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.zadej_d = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.horni_mez = New System.Windows.Forms.TextBox()
        Me.dolni_mez = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pocet_podintervalu = New System.Windows.Forms.TextBox()
        Me.ulozit_do_souboru = New System.Windows.Forms.Button()
        Me.tisk_grafu = New System.Windows.Forms.Button()
        Me.tisl_rovnice_krivky = New System.Windows.Forms.Button()
        Me.tisk_vysledku = New System.Windows.Forms.Button()
        Me.zavrit = New System.Windows.Forms.Button()
        Me.vypocitat = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.vysledek = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'zadej_a
        '
        Me.zadej_a.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.zadej_a.Location = New System.Drawing.Point(87, 360)
        Me.zadej_a.Name = "zadej_a"
        Me.zadej_a.Size = New System.Drawing.Size(100, 20)
        Me.zadej_a.TabIndex = 1
        '
        'zadej_c
        '
        Me.zadej_c.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.zadej_c.Location = New System.Drawing.Point(87, 488)
        Me.zadej_c.Name = "zadej_c"
        Me.zadej_c.Size = New System.Drawing.Size(100, 20)
        Me.zadej_c.TabIndex = 2
        '
        'zadej_b
        '
        Me.zadej_b.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.zadej_b.Location = New System.Drawing.Point(87, 423)
        Me.zadej_b.Name = "zadej_b"
        Me.zadej_b.Size = New System.Drawing.Size(100, 20)
        Me.zadej_b.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(85, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "x³"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(211, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "x²"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(336, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "x"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(46, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 39)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(171, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 39)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "b"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(297, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 39)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "c"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(131, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 39)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "+"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(257, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 39)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "+"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(372, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 39)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "+"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label10.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(412, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 39)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "d"
        '
        'zadej_d
        '
        Me.zadej_d.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.zadej_d.Location = New System.Drawing.Point(87, 551)
        Me.zadej_d.Name = "zadej_d"
        Me.zadej_d.Size = New System.Drawing.Size(100, 20)
        Me.zadej_d.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.PaleGreen
        Me.Label11.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(48, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 39)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "a"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.PaleGreen
        Me.Label12.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(48, 404)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 39)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "b"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.PaleGreen
        Me.Label13.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(48, 470)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 39)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "c"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.PaleGreen
        Me.Label14.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(47, 533)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 39)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "d"
        '
        'horni_mez
        '
        Me.horni_mez.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.horni_mez.Location = New System.Drawing.Point(317, 648)
        Me.horni_mez.Name = "horni_mez"
        Me.horni_mez.Size = New System.Drawing.Size(100, 20)
        Me.horni_mez.TabIndex = 19
        '
        'dolni_mez
        '
        Me.dolni_mez.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.dolni_mez.Location = New System.Drawing.Point(317, 697)
        Me.dolni_mez.Name = "dolni_mez"
        Me.dolni_mez.Size = New System.Drawing.Size(100, 20)
        Me.dolni_mez.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.PaleGreen
        Me.Label15.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(37, 630)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 39)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Horní mez:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.PaleGreen
        Me.Label16.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(40, 679)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 39)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Dolní mez:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.PictureBox1.Location = New System.Drawing.Point(28, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 260)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox2.Location = New System.Drawing.Point(28, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(700, 61)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(24, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(218, 23)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Zadejte koeficienty funkce"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.PaleGreen
        Me.PictureBox3.Location = New System.Drawing.Point(28, 612)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(447, 187)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.PaleGreen
        Me.Label18.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(40, 728)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(272, 39)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Počet podintervalů:"
        '
        'pocet_podintervalu
        '
        Me.pocet_podintervalu.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pocet_podintervalu.Location = New System.Drawing.Point(318, 746)
        Me.pocet_podintervalu.Name = "pocet_podintervalu"
        Me.pocet_podintervalu.Size = New System.Drawing.Size(100, 20)
        Me.pocet_podintervalu.TabIndex = 28
        '
        'ulozit_do_souboru
        '
        Me.ulozit_do_souboru.BackColor = System.Drawing.Color.LemonChiffon
        Me.ulozit_do_souboru.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ulozit_do_souboru.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ulozit_do_souboru.Location = New System.Drawing.Point(1115, 70)
        Me.ulozit_do_souboru.Name = "ulozit_do_souboru"
        Me.ulozit_do_souboru.Size = New System.Drawing.Size(294, 52)
        Me.ulozit_do_souboru.TabIndex = 29
        Me.ulozit_do_souboru.Text = "Uložit do souboru"
        Me.ulozit_do_souboru.UseVisualStyleBackColor = False
        '
        'tisk_grafu
        '
        Me.tisk_grafu.BackColor = System.Drawing.Color.LemonChiffon
        Me.tisk_grafu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tisk_grafu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tisk_grafu.Location = New System.Drawing.Point(1115, 130)
        Me.tisk_grafu.Name = "tisk_grafu"
        Me.tisk_grafu.Size = New System.Drawing.Size(294, 52)
        Me.tisk_grafu.TabIndex = 30
        Me.tisk_grafu.Text = "Tisk grafu"
        Me.tisk_grafu.UseVisualStyleBackColor = False
        '
        'tisl_rovnice_krivky
        '
        Me.tisl_rovnice_krivky.BackColor = System.Drawing.Color.LemonChiffon
        Me.tisl_rovnice_krivky.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tisl_rovnice_krivky.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tisl_rovnice_krivky.Location = New System.Drawing.Point(1115, 189)
        Me.tisl_rovnice_krivky.Name = "tisl_rovnice_krivky"
        Me.tisl_rovnice_krivky.Size = New System.Drawing.Size(294, 52)
        Me.tisl_rovnice_krivky.TabIndex = 31
        Me.tisl_rovnice_krivky.Text = "Tisk rovnice křivky"
        Me.tisl_rovnice_krivky.UseVisualStyleBackColor = False
        '
        'tisk_vysledku
        '
        Me.tisk_vysledku.BackColor = System.Drawing.Color.LemonChiffon
        Me.tisk_vysledku.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tisk_vysledku.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tisk_vysledku.Location = New System.Drawing.Point(1115, 247)
        Me.tisk_vysledku.Name = "tisk_vysledku"
        Me.tisk_vysledku.Size = New System.Drawing.Size(294, 52)
        Me.tisk_vysledku.TabIndex = 32
        Me.tisk_vysledku.Text = "Tisk výsledku"
        Me.tisk_vysledku.UseVisualStyleBackColor = False
        '
        'zavrit
        '
        Me.zavrit.BackColor = System.Drawing.Color.LightSalmon
        Me.zavrit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.zavrit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.zavrit.Location = New System.Drawing.Point(1230, 784)
        Me.zavrit.Name = "zavrit"
        Me.zavrit.Size = New System.Drawing.Size(179, 52)
        Me.zavrit.TabIndex = 33
        Me.zavrit.Text = "Zavřít"
        Me.zavrit.UseVisualStyleBackColor = False
        '
        'vypocitat
        '
        Me.vypocitat.BackColor = System.Drawing.Color.LemonChiffon
        Me.vypocitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.vypocitat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vypocitat.Location = New System.Drawing.Point(1115, 12)
        Me.vypocitat.Name = "vypocitat"
        Me.vypocitat.Size = New System.Drawing.Size(294, 52)
        Me.vypocitat.TabIndex = 34
        Me.vypocitat.Text = "Vypočítat"
        Me.vypocitat.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(499, 333)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(910, 424)
        Me.Chart1.TabIndex = 35
        Me.Chart1.Text = "Chart1"
        '
        'vysledek
        '
        Me.vysledek.AutoSize = True
        Me.vysledek.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.vysledek.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vysledek.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.vysledek.Location = New System.Drawing.Point(492, 39)
        Me.vysledek.Name = "vysledek"
        Me.vysledek.Size = New System.Drawing.Size(34, 39)
        Me.vysledek.TabIndex = 36
        Me.vysledek.Text = "?"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label19.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(452, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 39)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "="
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(206, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 42)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Smazat hodnoty"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 848)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.vysledek)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.vypocitat)
        Me.Controls.Add(Me.zavrit)
        Me.Controls.Add(Me.tisk_vysledku)
        Me.Controls.Add(Me.tisl_rovnice_krivky)
        Me.Controls.Add(Me.tisk_grafu)
        Me.Controls.Add(Me.ulozit_do_souboru)
        Me.Controls.Add(Me.pocet_podintervalu)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dolni_mez)
        Me.Controls.Add(Me.horni_mez)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.zadej_d)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.zadej_b)
        Me.Controls.Add(Me.zadej_c)
        Me.Controls.Add(Me.zadej_a)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Form1"
        Me.Text = "Výpočet určitého integrálu, Šmejkal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zadej_a As TextBox
    Friend WithEvents zadej_c As TextBox
    Friend WithEvents zadej_b As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents zadej_d As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents horni_mez As TextBox
    Friend WithEvents dolni_mez As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents pocet_podintervalu As TextBox
    Friend WithEvents ulozit_do_souboru As Button
    Friend WithEvents tisk_grafu As Button
    Friend WithEvents tisl_rovnice_krivky As Button
    Friend WithEvents tisk_vysledku As Button
    Friend WithEvents zavrit As Button
    Friend WithEvents vypocitat As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents vysledek As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
End Class
