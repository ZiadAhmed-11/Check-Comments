using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoML2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelInput modelInput = new ModelInput();
            modelInput.Col0 = textBox1.Text;

            ModelOutput modelOutput = Consumpe.Predict(modelInput);
            if(modelOutput.PredictedLabel==0)
            {
                textBox2.Text = "Bad Comment";
            }
            else
                textBox2.Text = "Good Comment";
            /*            textBox2.Text= modelOutput.PredictedLabel.ToString();
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Bad Comment")
            {
                textBox2.ForeColor = Color.Red;
            }
            else
                textBox2.ForeColor= Color.Green;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
