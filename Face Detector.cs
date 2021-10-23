using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Face_Recognition_Attendance_Event_System
{
    public partial class Face_Detector : UserControl
    {
        public Face_Detector()
        {
            InitializeComponent();
        }
        FaceRec faceRec = new FaceRec();
        private void Face_Detector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBox1, pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(textBox1.Text);
            MessageBox.Show("Save Success");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
            faceRec.getPersonName(textBox1);
        }
    }
}
