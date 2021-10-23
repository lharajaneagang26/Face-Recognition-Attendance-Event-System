using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;

namespace Face_Recognition_Attendance_Event_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login check = new Login();
            check.Show();
            Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facedbDataSet.facetbl' table. You can move, or remove it, as needed.
            this.facetblTableAdapter.Fill(this.facedbDataSet.facetbl);
            // TODO: This line of code loads data into the 'registrationDataSet.Table1' table. You can move, or remove it, as needed.
            this.facetblTableAdapter.Fill(this.facedbDataSet.facetbl);
            // TODO: This line of code loads data into the 'student_Registration_formDataSet2.Student_Registration_Form' table. You can move, or remove it, as needed.
            this.facetblTableAdapter.Fill(this.facedbDataSet.facetbl);
            // TODO: This line of code loads data into the 'student_Registration_formDataSet1.Student_Registration_Form' table. You can move, or remove it, as needed.
            this.facetblTableAdapter.Fill(this.facedbDataSet.facetbl);
            // TODO: This line of code loads data into the 'student_Registration_formDataSet.Student_Registration_Form' table. You can move, or remove it, as needed.
            this.facetblTableAdapter.Fill(this.facedbDataSet.facetbl);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            facetblBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == ""
               || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""
               || textBox8.Text == "" || textBox2.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Please input fields first!");
            }
            else
            {
                facetblBindingSource.EndEdit();
                facetblTableAdapter.Update(facedbDataSet.facetbl);
                MessageBox.Show("Successfully Save");
            }

        }

        private void studentRegistrationFormBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.facetblTableAdapter.se
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            facetblBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facetblBindingSource.MovePrevious();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            facetblBindingSource.MoveNext();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            facetblBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            facetblBindingSource.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox8.Text = openFileDialog1.FileName;
        }

        private void searchToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.facetblTableAdapter.Search(this.facedbDataSet.facetbl, student_noToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox8.Text))
            {
                //MessageBox.Show("hallo");
                pictureBox1.Image = Image.FromFile(textBox8.Text);
            }
            if(textBox8.Text == "")
            {
                pictureBox1.Hide();
            }
            else
            {
                pictureBox1.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
