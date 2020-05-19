using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmosHttpRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ssurl = txtURL.Text;
            string ssvalue = txtValue.Text;
            RestClient client = new RestClient(ssurl);
            if (comboBox1.SelectedIndex == 0)
            {
                string result1 = client.HttpPost(ssurl, ssvalue);
                 Console.WriteLine(result1);
                 label3.Text = result1;              
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string asss = ssurl + ssvalue;
                string result1 = client.DoWebRequestByGet(asss);
                Console.WriteLine(result1);
                label3.Text = result1;
            }
        }
    }
}
