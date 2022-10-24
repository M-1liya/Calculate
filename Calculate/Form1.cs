//using controllerCalc;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuPlus_Click(object sender, EventArgs e)
        {
            txtOperat.Text = " + ";
            string value1Str = value1.Text;
            string value2Str = value2.Text;

            if (CorrectValue(value1Str, out double val1) && CorrectValue(value2Str, out double val2))
                txtAnswer.Text = $"=  {val1 + val2}";
            else
                MessageBox.Show("������� �� ���������� ������", "������!");

        }

        private void toolStripMenuMinus_Click(object sender, EventArgs e)
        {
            txtOperat.Text = " - ";
            string value1Str = value1.Text;
            string value2Str = value2.Text;

            if (CorrectValue(value1Str, out double val1) && CorrectValue(value2Str, out double val2))
                txtAnswer.Text = $"=  {val1 - val2}";
            else
                MessageBox.Show("������� �� ���������� ������", "������!");
        }

        private void toolStripMenuMultiply_Click(object sender, EventArgs e)
        {
            txtOperat.Text = " * ";
            string value1Str = value1.Text;
            string value2Str = value2.Text;

            if (CorrectValue(value1Str, out double val1) && CorrectValue(value2Str, out double val2))
                txtAnswer.Text = $"=  {val1 * val2}";
            else
                MessageBox.Show("������� �� ���������� ������", "������!");
        }

        private void toolStripMenuDivision_Click(object sender, EventArgs e)
        {
            txtOperat.Text = " : ";
            string value1Str = value1.Text;
            string value2Str = value2.Text;

            if (CorrectValue(value1Str, out double val1) && CorrectValue(value2Str, out double val2))
            {
                txtAnswer.Text = $"=  {val1 / val2}";
                if (val1 == val2 && val1 == 0)
                    txtAnswer.Text = "= NaN";
            }
            else
                MessageBox.Show("������� �� ���������� ������", "������!");
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            value1.Text = "";
            value2.Text = "";

        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
            txtOperat.Text = "";
            value1.Text = "";
            value2.Text = "";
        }

        bool CorrectValue(string str, out double value)
        {
            str = str.Replace(".", ",");
            str = str.Replace(" ", "");


            return double.TryParse(str, out  value);

        }
    }
}