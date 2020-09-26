using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using System.Collections.ObjectModel;
using System.Threading;
using System.IO;
using System.Globalization;


namespace ServiceMiniUPS
{
    public partial class Form_Set_Serial_Number : Form
    {
        

        String Year = Convert.ToString(DateTime.Today.Year-2000);
        String Month = Convert.ToString(DateTime.Today.Month);
        String YearMonthPart = null;

        bool first_time_5_digits_typed_flag = false;
        bool first_time_focused_flag = false;

        public Form_Set_Serial_Number()
        {
            InitializeComponent();

            label_sending_error.Text = "Введите 5 цифр.";
            label_sending_error.ForeColor = Color.Black;

            if (Convert.ToInt32(Month) < 10) YearMonthPart = Year + "0" + Month;
            else YearMonthPart = Year + Month;
            textBox_SN_date.Text = YearMonthPart;
            textBox_SN_date.ReadOnly = true;

            this.KeyUp += new KeyEventHandler(OKP);
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void button_set_serial_number_Click(object sender, EventArgs e)
        {
            if (textBox_SN_num.Text.Length == 5)
            {
                String full_serialNumber_count = null;
                full_serialNumber_count = textBox_SN_date.Text + textBox_SN_num.Text;
                Form1.SendSerialNumberToUSB(full_serialNumber_count);
            }
            else
            {
                label_sending_error.Text = "Введите номер из 5 цифр!";
                label_sending_error.ForeColor = Color.Red;
            }
        }

        private void FormClosingOpacity(object sender, FormClosingEventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(60);
                this.Opacity = this.Opacity - 0.1;
            }
        }

        private void textBox_SN_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 )
            {
                e.Handled = true;
            }
            
        }

        private void textBox_SN_num_MouseDown(object sender, MouseEventArgs e)
        {
            if (!first_time_focused_flag)
            {
                textBox_SN_num.Clear();
                button_set_serial_number.Enabled = true;
                first_time_focused_flag = true;
            }
        }

        private void textBox_SN_num_TextChanged(object sender, EventArgs e)
        {
            if (first_time_5_digits_typed_flag && textBox_SN_num.Text.Length != 5)
            {
                label_sending_error.Text = "Введите номер из 5 цифр!";
                label_sending_error.ForeColor = Color.Red;
            }
            if (textBox_SN_num.Text.Length == 5)
            {
                label_sending_error.Text = "Формат номера корректен!";
                label_sending_error.ForeColor = Color.Green;
                first_time_5_digits_typed_flag = true;
            }
        }
    }
}
