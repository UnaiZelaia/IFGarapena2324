using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms.VisualStyles;

namespace ariketa2
{
    public partial class Form1 : Form
    {
        int i = 0;
        Eragiketa eragiketa = new Eragiketa();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    eragiketa.a = int.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = "2. zenbakia";
                    i++;
                    break;
                case 1:
                    eragiketa.b = int.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = "3. zenbakia";
                    i++;
                    break;
                case 2:
                    eragiketa.c = int.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = "4. zenbakia";
                    i++;
                    break;
                case 3:
                    eragiketa.d = int.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = "Emaitza";
                    textBox1.Text = eragiketa.eragiketaEgin();
                    i = 0;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "1. zenbakia";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}