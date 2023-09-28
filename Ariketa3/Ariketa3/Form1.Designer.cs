namespace Ariketa3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            kontaktua = new RadioButton();
            bezeroa = new RadioButton();
            langilea = new RadioButton();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Nan:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kat1", "Kat2", "Kat3", "Kat4" });
            comboBox1.Location = new Point(11, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 2;
            // 
            // kontaktua
            // 
            kontaktua.AutoSize = true;
            kontaktua.Location = new Point(23, 44);
            kontaktua.Name = "kontaktua";
            kontaktua.Size = new Size(79, 19);
            kontaktua.TabIndex = 3;
            kontaktua.TabStop = true;
            kontaktua.Text = "Kontaktua";
            kontaktua.UseVisualStyleBackColor = true;
            // 
            // bezeroa
            // 
            bezeroa.AutoSize = true;
            bezeroa.Location = new Point(23, 82);
            bezeroa.Name = "bezeroa";
            bezeroa.Size = new Size(66, 19);
            bezeroa.TabIndex = 4;
            bezeroa.TabStop = true;
            bezeroa.Text = "Bezeroa";
            bezeroa.UseVisualStyleBackColor = true;
            // 
            // langilea
            // 
            langilea.AutoSize = true;
            langilea.Location = new Point(23, 119);
            langilea.Name = "langilea";
            langilea.Size = new Size(69, 19);
            langilea.TabIndex = 5;
            langilea.TabStop = true;
            langilea.Text = "Langilea";
            langilea.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 67);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Izena:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Abizena:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(74, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 23);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 120);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kontaktua);
            groupBox1.Controls.Add(bezeroa);
            groupBox1.Controls.Add(langilea);
            groupBox1.Location = new Point(534, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 153);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mota";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 109);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Kategoria";
            // 
            // button1
            // 
            button1.Location = new Point(212, 404);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 15;
            button1.Text = "Gorde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(406, 404);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 16;
            button2.Text = "Irten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(60, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(316, 23);
            textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 127);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(364, 23);
            textBox6.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 67);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 4;
            label6.Text = "Soldata";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 109);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 5;
            label7.Text = "Segurtasun soziala";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(346, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 188);
            panel1.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 10);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 20;
            label9.Text = "Langilea";
            label9.Click += label9_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(43, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 188);
            panel2.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 10);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 19;
            label8.Text = "Bezeroa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kontaktuak gehitu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private RadioButton kontaktua;
        private RadioButton bezeroa;
        private RadioButton langilea;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Label label8;
    }
}