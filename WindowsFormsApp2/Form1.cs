using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"C:\Users\leras\Desktop\1542784826_1.jpg");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"C:\Users\leras\Desktop\priroda-gora.jpg");
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"C:\Users\leras\Desktop\1544861778_1.jpg");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"C:\Users\leras\Desktop\upload-shutterstock_109674992-pic905v-895x505-10385.jpg");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"C:\Users\leras\Desktop\1902w-3.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = comboBox1.Text;  
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Font = new Font("Mistral", 11, FontStyle.Regular);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_SizeChanged(sender, e);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = Size.Height;
            numericUpDown2.Value = Size.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            this.Font = new Font("Times New Roman", 9, FontStyle.Regular);
    }

    private void Arial_CheckedChanged(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 9, FontStyle.Regular);
        }

        private void Sent_CheckedChanged(object sender, EventArgs e)
        {
            this.Font = new Font("Ms Sant Serif", 8, FontStyle.Regular);
        }

        private void Form1_ResizeBegin(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Form.ResizeBegin event.");
        }
    }

    
}
