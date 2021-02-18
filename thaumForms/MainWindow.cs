using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace thaumForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Procces proc = new Procces();
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + comboBox1.Text.ToString() + "  " + Convert.ToString(numericUpDown1.Value);
            string text = comboBox1.Text.ToString();
            int z = Convert.ToInt32(numericUpDown1.Value);
            proc.Input(text, z);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            List<string> output = new List<string>();
            string q = comboBox2.Text.ToString();
            output = proc.Calculation(q);
            label3.Text = "Aer: " + output[0];
            label4.Text = "Ignis: " + output[1];
            label5.Text = "Perditio: " + output[2];
            label6.Text = "Terra: " + output[3];
            label7.Text = "Aqua: " + output[4];
            label8.Text = "Ordo: " + output[5];
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Input:";
            label3.Text = "Aer:";
            label4.Text = "Ignis:";
            label5.Text = "Perditio:";
            label6.Text = "Terra:";
            label7.Text = "Aqua:";
            label8.Text = "Ordo:";
            string text = "clear";
            proc.Input(text, 0);
        }
    }
}
