using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Recognition_Attendance_Event_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "pass")
            {

                Form3 check = new Form3();
                check.Show();
                Hide();

            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form4 check = new Form4();
                check.Show();
                Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Use Name and Passwod Empty");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 check = new Form2();
            check.Show();
            Hide();

        }
    }
}
