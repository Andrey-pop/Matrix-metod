namespace Matrix_metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 3;
            double[,] a = new double[n, n];// створення масиву для коефіцієнтів СЛАУ
            double[] b = new double[n]; // масив для вільних коефіцієнтів
            // Введення масиву коефіцієнтів рівняння
            a[0, 0] = Convert.ToDouble(textBox1.Text);
            a[0, 1] = Convert.ToDouble(textBox2.Text);
            a[0, 2] = Convert.ToDouble(textBox3.Text);
            a[1, 0] = Convert.ToDouble(textBox4.Text);
            a[1, 1] = Convert.ToDouble(textBox5.Text);
            a[1, 2] = Convert.ToDouble(textBox6.Text);
            a[2, 0] = Convert.ToDouble(textBox7.Text);
            a[2, 1] = Convert.ToDouble(textBox8.Text);
            a[2, 2] = Convert.ToDouble(textBox9.Text);
            // Введення масиву вільних коефіцієнтів 
            b[0] = Convert.ToDouble(textBox10.Text);
            b[1] = Convert.ToDouble(textBox11.Text);
            b[2] = Convert.ToDouble(textBox12.Text);
            // Реалізація алгоритму метода Гаусса
            Matrix Method1 = new Matrix(a, b);
            Method1.Solve();
            richTextBox1.Text = "X = " + Method1.x[0] + "\nY = " + Method1.x[1] + "\nZ = " + Method1.x[2];
            textBox13.Text = Method1.C[0,0].ToString();
            textBox14.Text = Method1.C[0, 1].ToString();
            textBox15.Text = Method1.C[0, 2].ToString();
            textBox16.Text = Method1.C[1, 0].ToString();
            textBox17.Text = Method1.C[1, 1].ToString();
            textBox18.Text = Method1.C[1, 2].ToString();
            textBox19.Text = Method1.C[2, 0].ToString();
            textBox20.Text = Method1.C[2, 1].ToString();
            textBox21.Text = Method1.C[2, 2].ToString();


        }
    }
}