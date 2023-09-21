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
        List<Ariketa2> objetuak;
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
                    a.Zenbakia =  int.Parse(textBox1.Text);
                    objetuak.Add(a);
                    textBox1.Clear();
                    label1.Text = "2. zenbakia";
                    i++;
                    break;
                case 1:
                    b.Zenbakia = int.Parse(textBox1.Text);
                    objetuak.Add(b);
                    textBox1.Clear();
                    label1.Text = "3. zenbakia";
                    i++;
                    break;
                case 2:
                    c.Zenbakia = int.Parse(textBox1.Text);
                    objetuak.Add(c);
                    textBox1.Clear();
                    label1.Text = "4. zenbakia";
                    i++;
                    break;
                case 3:
                    d.Zenbakia = int.Parse(textBox1.Text);
                    objetuak.Add(d);
                    textBox1.Clear();
                    label1.Text = "Emaitza";
                    textBox1.Text = "(" + this.a + " + (" + this.b + "x2)" + " + (" + this.c + "x3)" + " + (" + this.d + "x4)/4 = " + Ariketa2.eragiketa(objetuak);
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