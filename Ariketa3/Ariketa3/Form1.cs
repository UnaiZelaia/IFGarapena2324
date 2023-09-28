namespace Ariketa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Devuelve el nombre del radio button seleccionado en el groupbox1
            var mota = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;

            if (mota != null)
            {
                switch (mota)
                {
                    case "kontaktua":
                        Kontaktua k = new Kontaktua();

                        k.Nan = textBox1.Text;
                        k.izena = textBox2.Text;
                        k.abizena = textBox3.Text;
                        k.email = textBox4.Text;

                        MessageBox.Show(k.gorde() + "\n" + k.ToString);

                        break;

                    case "bezeroa":
                        Bezeroa b = new Bezeroa();

                        b.Nan = textBox1.Text;
                        b.izena = textBox2.Text;
                        b.abizena = textBox3.Text;
                        b.email = textBox4.Text;
                        b.kategoria = comboBox1.Text;

                        MessageBox.Show(b.gorde() + "\n" + b.ToString);
                        break;

                    case "langilea":
                        Langile l = new Langile();

                        l.Nan = textBox1.Text;
                        l.izena = textBox2.Text;
                        l.abizena = textBox3.Text;
                        l.email = textBox4.Text;
                        l.soldata = float.Parse(textBox5.Text);
                        l.SSZenb = textBox6.Text;

                        MessageBox.Show(l.gorde() + "\n" + l.ToString);

                        break;
                }
            }
            else
            {
                MessageBox.Show("Ez duzu kontaktu mota aukeratu");
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}