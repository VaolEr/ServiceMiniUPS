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

    public partial class USB_divice_settings_form : Form
    {

        public USB_divice_settings_form()
        {
            InitializeComponent();
            //checkBox_5_battery_module.Checked = Properties.Settings.Default.check_5_cells;
            //Form1 main = this.Owner as Form1;
            //if (main != null)
            if(this.Owner is Form1 main)
            {
                //label_USBstate.Text = main.label_USBstate.Text;
            }

        }

        private void button_conect_Click(object sender, EventArgs e)
        {
            //Form1 main = this.Owner as Form1;
            //if (main != null)
            if (this.Owner is Form1 main)
            {
                //string s = main.textBox1.Text;
                //label_USBstate.Text = main.label_USBstate.Text;
             
               // main.UPS_5_cells_flag = checkBox_5_battery_module.Checked;

                //Properties.Settings.Default.check_5_cells = checkBox_5_battery_module.Checked;
                Properties.Settings.Default.Save();

                main.VID_value = textBox_VID.Text;
                main.PID_value = textBox_PID.Text;

                Close();

            }
        }

        private void checkBox_5_battery_module_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
