Imports System.Drawing.Printing
Imports System.IO

Public Class Form1

    ' Proměnné pro výpočet
    Private a As Double
    Private b As Double
    Private c As Double
    Private d As Double
    Private dolniMez As Double
    Private horniMez As Double
    Private podIntervaly As Integer
    Dim PrintDialog1 As New PrintDialog()
    Dim PrintDocument1 As New Printing.PrintDocument()
    Dim SaveFileDialog1 As New SaveFileDialog()






    ' Funkce pro výpočet hodnoty polynomu
    Private Function Funkce(x As Double) As Double
        Return a * x ^ 3 + b * x ^ 2 + c * x + d
    End Function

    ' Výpočet lichoběžníkového integrálu
    Private Function VypocetIntegralu() As Double
        Dim sirkaPodintervalu As Double = (horniMez - dolniMez) / podIntervaly
        Dim integral As Double = 0

        For i As Integer = 0 To podIntervaly
            Dim x As Double = dolniMez + i * sirkaPodintervalu
            Dim y As Double = Funkce(x)
            If i = 0 Or i = podIntervaly Then
                integral += y / 2
            Else
                integral += y
            End If
        Next

        integral *= sirkaPodintervalu
        Return integral
    End Function



    Private Sub VykreslitGraf()
        Try
            ' Vymazání předchozích sérií a chart area
            Chart1.Series.Clear()
            Chart1.ChartAreas.Clear()

            ' Přidání nové chart area
            Dim chartArea As New DataVisualization.Charting.ChartArea("ChartArea1")
            Chart1.ChartAreas.Add(chartArea)

            ' Přidání nové série
            Dim series As New DataVisualization.Charting.Series("Funkce") With {
            .ChartType = DataVisualization.Charting.SeriesChartType.Line,
            .BorderWidth = 2,
            .Color = Color.Blue
        }

            ' Kontrola platnosti mezí a podintervalů
            If dolniMez >= horniMez Then
                MessageBox.Show("Dolní mez musí být menší než horní mez.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If podIntervaly <= 0 Then
                MessageBox.Show("Počet podintervalů musí být kladné číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Výpočet šířky podintervalu
            Dim sirkaPodintervalu As Double = (horniMez - dolniMez) / podIntervaly

            ' Výpočet bodů grafu
            For x As Double = dolniMez To horniMez Step sirkaPodintervalu
                Dim y As Double = Funkce(x)
                series.Points.AddXY(x, y)
            Next

            ' Přidání série do grafu
            Chart1.Series.Add(series)

            ' Dynamické nastavení rozsahů os
            Dim minY = series.Points.Select(Function(p) p.YValues(0)).Min()
            Dim maxY = series.Points.Select(Function(p) p.YValues(0)).Max()
            With chartArea
                .AxisX.Minimum = dolniMez
                .AxisX.Maximum = horniMez
                .AxisY.Minimum = minY - (Math.Abs(minY) * 0.1) ' Rezerva 10 %
                .AxisY.Maximum = maxY + (Math.Abs(maxY) * 0.1)
            End With
        Catch ex As Exception
            MessageBox.Show($"Chyba při vykreslování grafu: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles pocet_podintervalu.TextChanged

    End Sub

    Private Sub zadej_a_TextChanged(sender As Object, e As EventArgs) Handles zadej_a.TextChanged
        ' Pokusí se převést text z TextBoxu na číslo a uložit ho do proměnné a
        If Double.TryParse(zadej_a.Text, a) Then

        End If
    End Sub

    Private Sub zadej_b_TextChanged(sender As Object, e As EventArgs) Handles zadej_b.TextChanged

        If Double.TryParse(zadej_b.Text, b) Then

        End If

    End Sub

    Private Sub zadej_c_TextChanged(sender As Object, e As EventArgs) Handles zadej_c.TextChanged
        ' Pokusí se převést text z TextBoxu na číslo a uložit ho do proměnné a
        If Double.TryParse(zadej_c.Text, c) Then
            ' Pokud je vstup platné číslo, uloží se do proměnné a

        End If
    End Sub

    Private Sub zadej_d_TextChanged(sender As Object, e As EventArgs) Handles zadej_d.TextChanged
        ' Pokusí se převést text z TextBoxu na číslo a uložit ho do proměnné a
        If Double.TryParse(zadej_d.Text, d) Then
            ' Pokud je vstup platné číslo, uloží se do proměnné a

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

        ' Vykreslení grafu do tiskárny
        Dim bmp As New Bitmap(Chart1.Width, Chart1.Height)
        Chart1.DrawToBitmap(bmp, New Rectangle(0, 0, Chart1.Width, Chart1.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub ulozit_do_souboru_Click(sender As Object, e As EventArgs) Handles ulozit_do_souboru.Click
        Try
            ' Nastavení dialogu pro uložení souboru
            SaveFileDialog1.Filter = "Textové soubory (*.txt)|*.txt"
            SaveFileDialog1.Title = "Uložit výsledky"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(SaveFileDialog1.FileName)
                    writer.WriteLine("Výsledky výpočtu:")
                    writer.WriteLine($"a: {a}")
                    writer.WriteLine($"b: {b}")
                    writer.WriteLine($"c: {c}")
                    writer.WriteLine($"d: {d}")
                    writer.WriteLine($"Dolní mez: {dolniMez}")
                    writer.WriteLine($"Horní mez: {horniMez}")
                    writer.WriteLine($"Počet podintervalů: {podIntervaly}")
                    writer.WriteLine($"Výsledek: {vysledek.Text}")
                End Using
                MessageBox.Show("Výsledky byly úspěšně uloženy.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Chyba při ukládání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub tisk_grafu_Click(sender As Object, e As EventArgs) Handles tisk_grafu.Click
        Try
            ' Kontrola, zda graf obsahuje data
            If Chart1.Series.Count = 0 OrElse Chart1.Series(0).Points.Count = 0 Then
                MessageBox.Show("Graf neobsahuje žádná data k tisku.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Nastavení tiskového dialogu
            PrintDialog1.Document = PrintDocument1
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            MessageBox.Show($"Chyba při tisku grafu: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub tisl_rovnice_krivky_Click(sender As Object, e As EventArgs) Handles tisl_rovnice_krivky.Click

    End Sub

    Private Sub tisk_vysledku_Click(sender As Object, e As EventArgs) Handles tisk_vysledku.Click

    End Sub

    Private Sub horni_mez_TextChanged(sender As Object, e As EventArgs) Handles horni_mez.TextChanged

    End Sub

    Private Sub dolni_mez_TextChanged(sender As Object, e As EventArgs) Handles dolni_mez.TextChanged

    End Sub

    Private Sub zavrit_Click(sender As Object, e As EventArgs) Handles zavrit.Click

        Me.Close()

    End Sub

    Private Sub vypocitat_Click(sender As Object, e As EventArgs) Handles vypocitat.Click
        Try
            ' Načtení hodnot z textových polí
            a = Double.Parse(zadej_a.Text)
            b = Double.Parse(zadej_b.Text)
            c = Double.Parse(zadej_c.Text)
            d = Double.Parse(zadej_d.Text)
            dolniMez = Double.Parse(dolni_mez.Text)
            horniMez = Double.Parse(horni_mez.Text)
            podIntervaly = Integer.Parse(pocet_podintervalu.Text)

            ' Výpočet integrálu
            Dim vysledekIntegralu As Double = VypocetIntegralu()

            ' Zobrazení výsledku
            vysledek.Text = "Výsledek: " & vysledekIntegralu.ToString("F4")

            ' Vykreslení grafu ihned po výpočtu
            VykreslitGraf()
        Catch ex As Exception
            MessageBox.Show("Zadejte správné hodnoty!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

        Chart1.ChartAreas("ChartArea1").AxisX.Minimum = dolniMez
        Chart1.ChartAreas("ChartArea1").AxisX.Maximum = horniMez
        Chart1.ChartAreas("ChartArea1").AxisY.Minimum = -10 ' Nastavte podle potřeby
        Chart1.ChartAreas("ChartArea1").AxisY.Maximum = 10 ' Nastavte podle potřeby

    End Sub

    Private Sub vysledek_Click(sender As Object, e As EventArgs) Handles vysledek.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Vyčištění všech vstupních polí
        zadej_a.Text = ""
        zadej_b.Text = ""
        zadej_c.Text = ""
        zadej_d.Text = ""
        dolni_mez.Text = ""
        horni_mez.Text = ""
        pocet_podintervalu.Text = ""
        vysledek.Text = ""

        ' Vymazání grafu
        Chart1.Series.Clear()

        ' Obnovení grafu (prázdný)
        VykreslitGraf()
    End Sub


End Class
