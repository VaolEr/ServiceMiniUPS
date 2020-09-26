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
    public partial class Set_Temp_Limits_form : Form
    {
        public Set_Temp_Limits_form()
        {
            InitializeComponent();

            label_temp_low_limit.Text = Convert.ToString(Properties.Settings.Default.Cell_Low_Temp) + " C";
            label_temp_mid_limit.Text = Convert.ToString(Properties.Settings.Default.Cell_Mid_Temp) + " C";
            label_temp_high_limit.Text = Convert.ToString(Properties.Settings.Default.Cell_High_Temp) + " C";

            textBox_temp_low_limit.Text = Convert.ToString(Properties.Settings.Default.Cell_Low_Temp);
            textBox_temp_mid_limit.Text = Convert.ToString(Properties.Settings.Default.Cell_Mid_Temp);
            textBox_temp_high_limit.Text = Convert.ToString(Properties.Settings.Default.Cell_High_Temp);
        }

        private void button_accept_temps_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Cell_Low_Temp = Convert.ToInt16(textBox_temp_low_limit.Text);
            Properties.Settings.Default.Cell_Mid_Temp = Convert.ToInt16(textBox_temp_mid_limit.Text);
            Properties.Settings.Default.Cell_High_Temp = Convert.ToInt16(textBox_temp_high_limit.Text);
            this.Close();
        }
    }
}
