using System;
using System.Windows.Forms;

namespace airlineReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Destination: " + comboBox1.Text + " to " + comboBox2.Text);
            listBox1.Items.Add("Depart: " + dateTimePicker1.Text);
            listBox1.Items.Add("Passanger Fullname: " + textBox1.Text);
            listBox1.Items.Add("Turkish Identification Number: " + maskedTextBox1.Text);
            listBox1.Items.Add("Phone Number: " + maskedTextBox2.Text);
            MessageBox.Show("Your reservation has been received. Have a nice day.");


        }


        private void button2_Click(object sender, EventArgs e)
        {
            string degistir;

            degistir = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = degistir;
        }
    }
}
