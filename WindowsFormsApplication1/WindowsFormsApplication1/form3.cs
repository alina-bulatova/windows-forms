using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Example action when label1 is clicked
            MessageBox.Show("Label 1 clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example action when button1 is clicked
            // You could add registration logic here
            MessageBox.Show("Button 1 clicked! Registration logic can go here.");
        }
    }
}
