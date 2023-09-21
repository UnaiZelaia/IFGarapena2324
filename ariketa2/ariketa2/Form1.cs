using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms.VisualStyles;

namespace ariketa2
{
    public partial class Form1 : Form
    {
        int i = 0;
        Eragiketa eragiketa = new Eragiketa();
        Ariketa2 a = new Ariketa2();
        Ariketa2 b = new Ariketa2();
        Ariketa2 c = new Ariketa2();
        Ariketa2 d = new Ariketa2();
        List<Ariketa2> objetuak = new List<Ariketa2>();
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
                    a.Zenbakia =  float.Parse(textBox1.Text);
                    objetuak.Add(a);
                    textBox1.Clear();
                    label1.Text = "2. zenbakia";
                    i++;
                    break;
                case 1:
                    b.Zenbakia = float.Parse(textBox1.Text);
                    objetuak.Add(b);
                    textBox1.Clear();
                    label1.Text = "3. zenbakia";
                    i++;
                    break;
                case 2:
                    c.Zenbakia = float.Parse(textBox1.Text);
                    objetuak.Add(c);
                    textBox1.Clear();
                    label1.Text = "4. zenbakia";
                    i++;
                    break;
                case 3:
                    d.Zenbakia = float.Parse(textBox1.Text);
                    objetuak.Add(d);
                    textBox1.Clear();
                    label1.Text = "Emaitza";
                    textBox1.Text = "(" + a.Zenbakia + " + (" + b.Zenbakia + "x2)" + " + (" + c.Zenbakia + "x3)" + " + (" + d.Zenbakia + "x4)/4 = " + Ariketa2.eragiketa(objetuak);
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