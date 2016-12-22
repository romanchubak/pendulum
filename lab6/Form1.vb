Public Class Form1

    Dim Graph1 As Graphics
    Dim brush3 As New SolidBrush(Color.Red)
    Dim x As Integer, y As Integer, r, l As Integer
    Dim x_senter, y_senter As Integer
    Dim t As Integer
    Dim rr, g, b As Integer
    Dim gradus, radian As Double

    Dim N As Integer = 0


    Private Sub initialize()    'отже ця штука ініціалізує все в початкові умови
        rr = 1 'це глобальна змінна кольору червоний
        g = 1 'це глобальна змінна кольору зелений
        b = 1   ' це глобальна змінна кольору голубий
        Graph1 = Me.CreateGraphics() ' ініціалізація графіка там де можна малювати
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10) 'малюємо точку зверху до якої кріпиться нитка
        t = 0 ' функція коливань маятника залежить від т тому ми його глобально оголошуємо і кажем що на початку він дорівнює 0
        gradus = TrackBar1.Value ' це змінна градус кута початкового від горизонтальної уявної прямої
        radian = gradus * (Math.PI / 180) 'переводимо кут в радіани
        l = 150 ' довжина нитки
        r = TrackBar2.Value * 5 + 10 'це радіус того обєкта який коливається
        x_senter = 210 ' координати того центра на якому прикріплена нитка
        y_senter = 25
        x = x_senter + l * Math.Cos(radian) 'вираховуємо координати положення обєкта маятника
        y = y_senter + l * Math.Sin(radian)
        'нище малюємо нитку, від ценрів віднімаємо аби поставити кінці нитки в ценри кіл
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        'малюємо коло маятника заповнюючи його кольором нашим початковим тобто чорним і також зміщаємо його через особливість малювання еліпса в вб
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(rr, g, b)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'кнопка старт ініціалізує і запускає тік в таймері
        initialize()
        Timer1.Enabled = True

    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'кнопка стоп зупиняє тік
        Timer1.Enabled = False
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        'повзунок для червоного кольору перемальовує все аналогічно ініціалізації
        rr = TrackBar3.Value
        Graph1.Clear(Color.White)
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10)
        gradus = TrackBar1.Value
        radian = gradus * (Math.PI / 180)
        r = TrackBar2.Value * 5 + 10
        x = x_senter + l * Math.Cos(radian)
        y = y_senter + l * Math.Sin(radian)
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(rr, g, b)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        'повзунок для зеленого кольору перемальовує все аналогічно ініціалізації
        g = TrackBar4.Value
        Graph1.Clear(Color.White)
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10)
        gradus = TrackBar1.Value
        radian = gradus * (Math.PI / 180)
        r = TrackBar2.Value * 5 + 10
        x = x_senter + l * Math.Cos(radian)
        y = y_senter + l * Math.Sin(radian)
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(rr, g, b)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)
    End Sub
    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        'повзунок для голубого кольору перемальовує все аналогічно ініціалізації
        b = TrackBar5.Value
        Graph1.Clear(Color.White)
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10)
        gradus = TrackBar1.Value
        radian = gradus * (Math.PI / 180)
        r = TrackBar2.Value * 5 + 10
        x = x_senter + l * Math.Cos(radian)
        y = y_senter + l * Math.Sin(radian)
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(rr, g, b)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)
    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        'повзунок для зміни розміру обєкта перемальовує все аналогічно ініціалізації
        initialize()
        Graph1.Clear(Color.White)
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10)
        gradus = TrackBar1.Value
        radian = gradus * (Math.PI / 180)
        r = TrackBar2.Value * 5 + 10
        x = x_senter + l * Math.Cos(radian)
        y = y_senter + l * Math.Sin(radian)
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(rr, g, b)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'повзунок для зміни початкового кута перемальовує все аналогічно ініціалізації
        initialize()
        Graph1.Clear(Color.White)
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10)
        gradus = TrackBar1.Value
        r = TrackBar2.Value * 5 + 10
        radian = gradus * (Math.PI / 180)
        x = x_senter + l * Math.Cos(radian)
        y = y_senter + l * Math.Sin(radian)
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(rr, g, b)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)


    End Sub
    ' ця вункція яка каже де обєкт який коливається в певний момент часу бере в себе час і початковий кут
    Public Function angel(t As Integer, ang As Integer)
        'це повністю правильна з точки зору фізики функція 
        '        це поч кут в радіанах     е в степені -0.01 це коф затухання помн на час і понж на корінь прискор земне на довжину нитки
        Return ((90 - ang) * (Math.PI / 180)) * Math.Pow(Math.E, 0 - 0.01 * t) * Math.Cos(Math.Sqrt(9.8 / l) * t)
    End Function

    'ну і це тік який робить анімацію все перемальовує
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Graph1.Clear(Color.White)   'затераємо все білим
        Graph1.FillEllipse(New SolidBrush(Color.Black), 200, 15, 10, 10) 'точка опори зверху

        Dim a As Double
        'та функція розрахунку вертає кут в радіанах його не потрібно міняти для косінуса
        a = angel(t, gradus)
        t += 1 'збільшуємо наш час
        x = x_senter + l * Math.Sin(a) 'перемальовуємо обєкт коливання і дальше все як вже було пояснено
        y = y_senter + l * Math.Cos(a)
        Graph1.DrawLine(New Pen(Color.Black), x_senter - 5, y_senter - 5, Convert.ToInt32(x), Convert.ToInt32(y))
        Graph1.FillEllipse(New SolidBrush(Color.FromArgb(TrackBar3.Value, TrackBar4.Value, TrackBar5.Value)), Convert.ToInt32(x - r / 2), Convert.ToInt32(y - r / 2), r, r)

    End Sub


    End Class
