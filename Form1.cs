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
                // ������ ��������� ������
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                double r1 = double.Parse(txtR1.Text);
                double r2 = double.Parse(txtR2.Text);

                // ��������, ����� r1 ���� ������ ��� ����� r2
                if (r1 > r2)
                {
                    MessageBox.Show("������ ������ ���������� �� ����� ���� ������ ������� ������.");
                    return;
                }

                // ���������� ���������� �� ����� (x, y) �� ������ (0, 0)
                double distance = Math.Sqrt(x * x + y * y);

                // ������ ��������
                if (distance < r1)
                {
                     MessageBox.Show("�� (������ ������ ����������)"); // ����� ������ ������ ����������
                }
                else if (distance == r1)
                {
                    MessageBox.Show("�� ������� ������ ����������"); // ����� �� ������� ������ ����������
                }
                else if (distance < r2)
                {
                     MessageBox.Show("��� (������ ������ ����������, �� ��� ������ ����������)"); // ����� ������ ������ ����������, �� ��� ������
                }
                else if (distance == r2)
                {
                    MessageBox.Show("�� ������� ������ ����������"); // ����� �� ������� ������ ����������
                }
                else
                {
                     MessageBox.Show("��� (��� ������ ����������)"); // ����� ��� ������ ����������
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }
    }
}
