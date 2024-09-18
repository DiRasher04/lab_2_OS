using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace lab_2_OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            { 
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                label1.Text = ofd.FileName;
            }
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(ofd.FileName);
            process.Start();
        }
    }
}
