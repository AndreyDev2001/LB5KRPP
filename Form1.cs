namespace LB5KRPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение введенных данных
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                double r1 = double.Parse(txtR1.Text);
                double r2 = double.Parse(txtR2.Text);

                // Проверка, чтобы r1 было меньше или равно r2
                if (r1 > r2)
                {
                    MessageBox.Show("Радиус первой окружности не может быть больше радиуса второй.");
                    return;
                }

                // Вычисление расстояния от точки (x, y) до центра (0, 0)
                double distance = Math.Sqrt(x * x + y * y);

                // Логика проверки
                if (distance < r1)
                {
                     MessageBox.Show("Да (Внутри первой окружности)"); // Точка внутри первой окружности
                }
                else if (distance == r1)
                {
                    MessageBox.Show("На границе первой окружности"); // Точка на границе первой окружности
                }
                else if (distance < r2)
                {
                     MessageBox.Show("Нет (Внутри второй окружности, но вне первой окружности)"); // Точка внутри второй окружности, но вне первой
                }
                else if (distance == r2)
                {
                    MessageBox.Show("На границе второй окружности"); // Точка на границе второй окружности
                }
                else
                {
                     MessageBox.Show("Нет (Вне второй окружности)"); // Точка вне второй окружности
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
