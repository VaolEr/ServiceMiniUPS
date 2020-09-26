using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMiniUPS
{
    public partial class Form_With_Help_Image : Form
    {
        public Form_With_Help_Image()
        {
            InitializeComponent();
            
        }

        private void MyFormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox_elements_placement.Dispose();
            this.Dispose();
        }
    }
}
