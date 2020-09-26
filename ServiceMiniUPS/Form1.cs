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
using static ProgressBarSample.TextProgressBar;
using System.Windows.Forms.VisualStyles;

namespace ServiceMiniUPS
{
    public partial class Form1 : Form
    {
        #region Объявление переменных
        Thread _thread;

        public String VID_value = "04D8";//"F056";
        public String PID_value = "D004";//"0023";
        public  bool UPS_5_cells_flag = false;

        public String DeviceInfoString = "VID - ХХХХ | PID - ХХХХ | N cells | Состояние устройства: ";
        public String DeviceInfoStatus = "Unknown";

        private Form_ErrorsTable Form_ErrorsTable = new Form_ErrorsTable();
        #endregion
        public Form1()
        {      
            InitializeComponent();
            
            #region Первоначальная пользовательская инициализация элементов интерфейса
            очиститьToolStripMenuItem.Enabled = false;
            очиститьToolStripMenuItem.ToolTipText = "Отсутствуют входящие данные";

            setSerialNumberToolStripMenuItem.Enabled = false;

            checkBox_TimerGetUPSData_Enable.Enabled = false;

            toolStripStatusLabel_timer.Visible = false;
            #endregion

            AddOwnedForm(Form_ErrorsTable);
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AbortThread(); // закрытие потока

            MyUsbDevice = null;
            
            // Free usb resources
            UsbDevice.Exit();
        }
        #region Обработчики нажатия кнопок StripMenu
        //------------------------------------------------------------------------------------------------------------------//
        //--------------------              Обработчики нажатия кнопок StripMenu            --------------------------------//
        //------------------------------------------------------------------------------------------------------------------//
                #region Меню Файл
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //connect the device by VID & PID from textBox_VID and textBox_PID
            listBox_info.Items.Clear();
            //listBox_info.Items.Add("VID - " + VID_value + "   |   PID - " + PID_value);


            FindUsbDeviceByVidPid(VID_value, PID_value);    // connect the usb device to program function

            
            setSerialNumberToolStripMenuItem.Enabled = true;

            if (MyUsbDevice != null)
            {
                button_get_ups_data.Enabled = true;
                checkBox_TimerGetUPSData_Enable.Enabled = true;
            }

            DeviceInfoString = "VID - " + VID_value + " | PID - " + PID_value + " | N cells | Состояние устройства: ";
            toolStripStatusLabel1.Text = DeviceInfoString;
            toolStripStatusLabel2.Text = DeviceInfoStatus;

            if (DeviceInfoStatus.Equals("Device not found"))
            {
                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.BackColor = Color.WhiteSmoke;
                setSerialNumberToolStripMenuItem.Enabled = false;
            }
            if (DeviceInfoStatus.Equals("Connected Full")) toolStripStatusLabel2.BackColor = Color.Green;

        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button_get_ups_data.Enabled = false;
            checkBox_TimerGetUPSData_Enable.Checked = false;
            checkBox_TimerGetUPSData_Enable.Enabled = false;

            // disconect the USB device
            if (MyUsbDevice != null)
            {
                if (MyUsbDevice.Close())
                {
                    MyUsbDevice = null;

                    DeviceInfoStatus = "Disconnected";

                    DeviceInfoString = "VID - " + VID_value + " | PID - " + PID_value + " | N cells | Состояние устройства: ";
                    toolStripStatusLabel1.Text = DeviceInfoString;

                    toolStripStatusLabel2.Text = DeviceInfoStatus;
                    toolStripStatusLabel2.ForeColor = Color.Black;
                    toolStripStatusLabel2.BackColor = Color.WhiteSmoke;

                    listBox_info.Items[0] = "Device disconnected";

                    очиститьToolStripMenuItem.Enabled = true;
                    очиститьToolStripMenuItem.ToolTipText = "";
                    setSerialNumberToolStripMenuItem.Enabled = false;
                }
            }
            UsbDevice.Exit();
            if (_thread != null)
                AbortThread();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //---------------  Common fields  ------------------------//
            textBox_error.Text = " ";
            label_report_id.Text = "Report ID сообщения - 0 x XX";
            toolStripStatusLabel2.BackColor = Color.WhiteSmoke;
            toolStripStatusLabel_timer.Visible = false;
            //--------------------------------------------------------//
            //---------------  Service mode fields p1  ---------------//
            //--------------------------------------------------------//
            checkBox_power_out.Checked = false;
            checkBox_power_in.Checked = false;
            checkBox_calibr.Checked = false;
            checkBox_charge.Checked = false;

            textBox_V_cell_1.Clear();
            textBox_V_cell_2.Clear();
            textBox_V_cell_3.Clear();
            textBox_V_cell_4.Clear();
            textBox_V_cell_5.Clear();

            checkBox_V_cell_ball_1.Checked = false;
            checkBox_V_cell_ball_2.Checked = false;
            checkBox_V_cell_ball_3.Checked = false;
            checkBox_V_cell_ball_4.Checked = false;
            checkBox_V_cell_ball_5.Checked = false;

            textProgressBar_SoC.Value = 0;

            textBox_V_IN.Clear();
            textBox_Cur_OUT.Clear();
            textBox_Pow_OUT.Clear();

            textBox_Batt_12_temperature.Clear(); textBox_Batt_12_temperature.BackColor = SystemColors.Control;
            textBox_Batt_23_temperature.Clear(); textBox_Batt_23_temperature.BackColor = SystemColors.Control;
            textBox_Batt_34_temperature.Clear(); textBox_Batt_34_temperature.BackColor = SystemColors.Control;
            textBox_Batt_45_temperature.Clear(); textBox_Batt_45_temperature.BackColor = SystemColors.Control;
            //--------------------------------------------------------//
            //---------------  Service mode fields p2  ---------------//
            //--------------------------------------------------------//
            listBox_info.Items.Clear();

            textBox_total_time.Clear();
            textBox_battery_time.Clear();
            textBox_Remaining_time.Clear();
            textBox_mah.Clear();
            //--------------------------------------------------------//
            //-----------------  Debug mode fields p3-----------------//
            //--------------------------------------------------------//
            checkBox_test_BQ769003.Checked = false;
            checkBox_test_INA226.Checked = false;
            checkBox_test_M24C08.Checked = false;

            textBox_test_Voltage_Sens_1.Clear();
            textBox_test_Voltage_Sens_2.Clear();
            textBox_test_Voltage_Sens_3.Clear();
            textBox_test_Voltage_Sens_4.Clear();
            textBox_test_Voltage_Sens_5.Clear();

            textBox_test_temp_sens_1.Clear();
            textBox_test_temp_sens_2.Clear();
            textBox_test_temp_sens_3.Clear();
            textBox_test_temp_sens_4.Clear();
            //--------------------------------------------------------//
        }

        private void Write_to_File_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            String currentDate = localDate.ToString();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    //Byte[] info = new UTF8Encoding(true).GetBytes("Информация об устройстве");
                    //fs.Write(info, 0, info.Length);
                    //fs.Close();

                    using (StreamWriter sw = new StreamWriter((System.IO.FileStream)saveFileDialog1.OpenFile()))
                    {
                        sw.WriteLine("Информация об устройстве");
                        sw.WriteLine(currentDate);
                        for (int i = 1; i < 4; i++)
                        {
                            sw.WriteLine(listBox_info.Items[i]);
                        }
                        sw.WriteLine("//-------------------------------------------//");
                        sw.WriteLine("Напряжение ячейки 1 = " + textBox_V_cell_1.Text + " (mV)");
                        sw.WriteLine("Напряжение ячейки 2 = " + textBox_V_cell_2.Text + " (mV)");
                        sw.WriteLine("Напряжение ячейки 3 = " + textBox_V_cell_3.Text + " (mV)");
                        sw.WriteLine("Напряжение ячейки 4 = " + textBox_V_cell_4.Text + " (mV)");
                        if(UPS_5_cells_flag) sw.WriteLine("Напряжение ячейки 5 = " + textBox_V_cell_5.Text + " (mV)");
                        sw.WriteLine("//-------------------------------------------//");
                        sw.WriteLine("Входное напряжение = " + textBox_V_IN.Text + " (mV)");
                        sw.WriteLine("Выходной ток = " + textBox_Cur_OUT.Text + " mA");
                        sw.WriteLine("Суммарное время работы от батареи = " + textBox_battery_time.Text + " DD.HH.MM");
                        sw.WriteLine("Суммарная ёмкость UPS = " + textBox_mah.Text + " ma/h");
                        sw.WriteLine("Выходная мощность = " + textBox_Pow_OUT.Text + " W");
                        sw.WriteLine("Заряд UPS " +  textProgressBar_SoC.Value + " %");
                        sw.WriteLine("Полное время работы UPS = " + textBox_total_time.Text + " DD.HH.MM");
                        sw.WriteLine("Температура пары ячеек 1,2 = " + textBox_Batt_12_temperature.Text + " С");
                        sw.WriteLine("Температура пары ячеек 2,3 = " + textBox_Batt_23_temperature.Text + " С");
                        sw.WriteLine("Температура пары ячеек 3,4 = " + textBox_Batt_34_temperature.Text + " С");
                        if (UPS_5_cells_flag) sw.WriteLine("Температура пары ячеек 4,5 = " + textBox_Batt_45_temperature.Text + " С");
                        sw.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                textBox_error.Text += textBox_error.Text + Environment.NewLine + "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;
            }
        }
        #endregion

                #region Меню Настройки
        private void USB_UPS_Settings_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (USB_divice_settings_form f = new USB_divice_settings_form())
            {
                f.Owner = this;
                f.label_USBstate.Text = DeviceInfoStatus;
                f.ShowDialog();

                DeviceInfoString = "VID - " + VID_value + " | PID - " + PID_value + " | N cells | Состояние устройства: ";
                toolStripStatusLabel1.Text = DeviceInfoString;

                toolStripStatusLabel2.Text = DeviceInfoStatus;
                toolStripStatusLabel2.ForeColor = Color.Black;
            }
        }

        private void setSerialNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_Set_Serial_Number f = new Form_Set_Serial_Number())
            {
                f.Owner = this;
                f.textBox_SN.Clear();
                f.textBox_SN.Text = MyUsbDevice.Info.SerialString;
                f.ShowDialog();
            }
        }

        private void TempLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Temp_Limits_form f = new Set_Temp_Limits_form();
            f.Owner = this;
            f.ShowDialog();
        }
        #endregion

                #region Меню О программе
        private void ErrosTable_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ErrorsTable.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_About f = new Form_About())
            {
                f.ShowDialog();
            }
        }
                #endregion

        #endregion

        #region Обработчики нажатия кнопок на форме и таймер
        //------------------------------------------------------------------------------------------------------------------//
        //--------------------              Обработчики нажатия кнопок на форме             --------------------------------//
        //------------------------------------------------------------------------------------------------------------------//
        private void button_get_ups_data_Click(object sender, EventArgs e)
        {
            textBox_V_cell_1.Clear();
            textBox_V_cell_2.Clear();
            textBox_V_cell_3.Clear();
            textBox_V_cell_4.Clear();
            textBox_V_cell_5.Clear();

            checkBox_V_cell_ball_1.Checked = false;
            checkBox_V_cell_ball_2.Checked = false;
            checkBox_V_cell_ball_3.Checked = false;
            checkBox_V_cell_ball_4.Checked = false;
            checkBox_V_cell_ball_5.Checked = false;

            checkBox_power_in.Checked = false;
            checkBox_power_out.Checked = false;
            checkBox_charge.Checked = false;
            checkBox_calibr.Checked = false;

            textBox_V_IN.Clear();
            textBox_total_time.Clear();

            textBox_Pow_OUT.Clear();
            textBox_mah.Clear();
            textBox_Cur_OUT.Clear();
            textBox_battery_time.Clear();
            textBox_Remaining_time.Clear();

            textBox_Batt_12_temperature.Clear(); textBox_Batt_12_temperature.BackColor = SystemColors.Control;
            textBox_Batt_23_temperature.Clear(); textBox_Batt_23_temperature.BackColor = SystemColors.Control;
            textBox_Batt_34_temperature.Clear(); textBox_Batt_34_temperature.BackColor = SystemColors.Control;
            textBox_Batt_45_temperature.Clear(); textBox_Batt_45_temperature.BackColor = SystemColors.Control;

            textProgressBar_SoC.Value = 0;


            if (checkBox_TimerGetUPSData_Enable.Checked == true && MyUsbDevice != null)
            {
                timer1.Interval = 1000; //опрос с интервалом 1с
                timer1.Enabled = true;
                setSerialNumberToolStripMenuItem.Enabled = false;
                очиститьToolStripMenuItem.Enabled = false;
                очиститьToolStripMenuItem.ToolTipText = "Для очистки отключите чтение данных по таймеру";
            }

            if (checkBox_TimerGetUPSData_Enable.Checked == false && MyUsbDevice != null)
            {
                timer1.Enabled = false;
                setSerialNumberToolStripMenuItem.Enabled = true;
                очиститьToolStripMenuItem.Enabled = true;
                очиститьToolStripMenuItem.ToolTipText = "";

                toolStripStatusLabel_timer.Visible = false;

                //System.Threading.Thread.Sleep(500);
                //get data from USB by Report ID in new thread by GetDataFromUSBbyReportId function
                _thread = new Thread(GetUPSDataFromUSBbyReportId);
                _thread.IsBackground = true;            // set the thread is background
                _thread.Start();                        // Start the thread
            }


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //button_get_ups_data_Click(sender, e);
            _thread = new Thread(GetUPSDataFromUSBbyReportId);
            _thread.IsBackground = true;            // set the thread is background
            _thread.Start();                        // Start the thread

            toolStripStatusLabel_timer.Visible = !toolStripStatusLabel_timer.Visible;
        }
        #endregion

        #region Функции для работы с USB портом
        //-----------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        //--------------------                  Функции для работы с USB                    -------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        static ErrorCode ec = ErrorCode.None;
        public static UsbDevice MyUsbDevice;

        void FindUsbDeviceByVidPid(string vidStr, string pidStr)
        {
            // find your USB HID device by VID PID function
            var vidInt = Convert.ToInt32(vidStr, 16);
            var pidInt = Convert.ToInt32(pidStr, 16);
            try
            {
                var myUsbFinder = new UsbDeviceFinder(vidInt, pidInt);
                MyUsbDevice = UsbDevice.OpenUsbDevice(myUsbFinder);
                
                if (MyUsbDevice != null)
                {
                    //Indicate about the device connection
                    DeviceInfoStatus = "Connected";

                    //Out the device info to the listBox_info
                    listBox_info.Invoke(new Action(() => listBox_info.Items.Add("Serial number : " + MyUsbDevice.Info.SerialString)));
                    listBox_info.Invoke(new Action(() => listBox_info.Items.Add("Product name  : " + MyUsbDevice.Info.ProductString)));
                    listBox_info.Invoke(new Action(() => listBox_info.Items.Add("Manufacturer  : " + MyUsbDevice.Info.ManufacturerString)));                  
                    //listBox_info.Items.Add("Manufacturer: " + MyUsbDevice.Info.ManufacturerString);
                    //listBox_info.Items.Add("Product: " + MyUsbDevice.Info.ProductString);
                    //listBox_info.Items.Add("Serial: " + MyUsbDevice.Info.SerialString);


                    // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                    // it exposes an IUsbDevice interface. If not (WinUSB) the 
                    // 'wholeUsbDevice' variable will be null indicating this is 
                    // an interface of a device; it does not require or support 
                    // configuration and interface selection.
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;

                    if (wholeUsbDevice != null)
                    {
                        DeviceInfoStatus = "Connected Full";
                    }
                    //toolStripStatusLabel2.ForeColor = Color.White;
                    this.BeginInvoke((Action)(() => toolStripStatusLabel2.ForeColor = Color.White));
                }
                else
                {
                    DeviceInfoStatus = "Device not found";

                    //toolStripStatusLabel2.Text = DeviceInfoStatus;
                    //toolStripStatusLabel2.ForeColor = Color.Red;

                    this.BeginInvoke((Action)(() => toolStripStatusLabel2.Text = DeviceInfoStatus));
                    this.BeginInvoke((Action)(() => toolStripStatusLabel2.BackColor = Color.WhiteSmoke));
                    this.BeginInvoke((Action)(() => toolStripStatusLabel2.ForeColor = Color.Red));

                    listBox_info.Invoke(new Action(() => listBox_info.Items.Clear()));
                    listBox_info.Invoke(new Action(() => listBox_info.Items.Add("No info, because device was not red")));
                    //listBox_info.Items.Clear();
                    //listBox_info.Items.Add("No info, because device was not red");
                }
            }
            catch (Exception ex)
            {
                textBox_error.Invoke(new Action(() => textBox_error.Text += textBox_error.Text + Environment.NewLine + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message)); // is this condition true ? yes : no
            }
            finally
            {

            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------//
        private int first_message_flag = 0;                                         // flag for upgrade the number of cells info

        void GetUPSDataFromUSBbyReportId()
        {
            // get the data by Report ID function
            try
            {
                var CountOfBytes = 2;
                var ReportID_work  = 161; //0xA1
                var ReportID_debug = 219; //0xDB

                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;

                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);
                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                        // open read endpoint 1.

                        UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01, 8, LibUsbDotNet.Main.EndpointType.Interrupt);

                        byte[] readBuffer = new byte[1024];
                        int i = 0;

                        textBox_error.Invoke(new Action(() => textBox_error.Text = "Ошибок нет"));
                        textBox_error.ForeColor = Color.Black;

                        while (i < CountOfBytes)
                        {
                            int bytesRead = 0;

                            // If the device hasn't sent data in the last 5 seconds,
                            // a timeout error (ec = IoTimedOut) will occur. 
                            ec = reader.Read(readBuffer, 5000, out bytesRead);

                            if (bytesRead == 0) throw new Exception(string.Format("{0}:No more bytes!", ec));

                            // fill the fields in the normal work mode of MiniUPS board
                            label_report_id.Invoke(new Action(() => label_report_id.Text = "Report ID сообщения - 0 x " + Convert.ToString(readBuffer[0], 16).ToUpper()));
                            if (readBuffer[0] == ReportID_work)
                            {
                                i++;
                                // forming the output string
                                String red_bytes = null;
                                for (int j = 0; j < bytesRead; j++)
                                {
                                    red_bytes = red_bytes + readBuffer[j] + " ";
                                }

                                if (!textBox_V_cell_1.Text.Equals(Convert.ToString(Build_the_count(readBuffer[2], readBuffer[1]))))
                                {
                                    textBox_V_cell_1.Invoke(new Action(() => textBox_V_cell_1.Text = Convert.ToString(Build_the_count(readBuffer[2], readBuffer[1]))));
                                    if(Build_the_count(readBuffer[2], readBuffer[1])>=4250) textBox_V_cell_1.Invoke(new Action(() => textBox_V_cell_1.BackColor = Color.Red));
                                    else textBox_V_cell_1.Invoke(new Action(() => textBox_V_cell_1.BackColor = SystemColors.Control));
                                }

                                textBox_V_cell_2.Invoke(new Action(() => textBox_V_cell_2.Text = Convert.ToString(Build_the_count(readBuffer[4], readBuffer[3]))));
                                if (Build_the_count(readBuffer[4], readBuffer[3]) >= 4250) textBox_V_cell_2.Invoke(new Action(() => textBox_V_cell_2.BackColor = Color.Red));
                                else textBox_V_cell_2.Invoke(new Action(() => textBox_V_cell_2.BackColor = SystemColors.Control));

                                textBox_V_cell_3.Invoke(new Action(() => textBox_V_cell_3.Text = Convert.ToString(Build_the_count(readBuffer[6], readBuffer[5]))));
                                if (Build_the_count(readBuffer[6], readBuffer[5]) >= 4250) textBox_V_cell_3.Invoke(new Action(() => textBox_V_cell_3.BackColor = Color.Red));
                                else textBox_V_cell_3.Invoke(new Action(() => textBox_V_cell_3.BackColor = SystemColors.Control));

                                textBox_V_cell_4.Invoke(new Action(() => textBox_V_cell_4.Text = Convert.ToString(Build_the_count(readBuffer[8], readBuffer[7]))));
                                if (Build_the_count(readBuffer[8], readBuffer[7]) >= 4250) textBox_V_cell_4.Invoke(new Action(() => textBox_V_cell_4.BackColor = Color.Red));
                                else textBox_V_cell_4.Invoke(new Action(() => textBox_V_cell_4.BackColor = SystemColors.Control));

                                textBox_V_cell_5.Invoke(new Action(() => textBox_V_cell_5.Text = Convert.ToString(Build_the_count(readBuffer[10], readBuffer[9]))));
                                if (Build_the_count(readBuffer[10], readBuffer[9]) >= 4250) textBox_V_cell_5.Invoke(new Action(() => textBox_V_cell_5.BackColor = Color.Red));
                                else textBox_V_cell_5.Invoke(new Action(() => textBox_V_cell_5.BackColor = SystemColors.Control));

                                if ((readBuffer[11] & 2) == 2)
                                {
                                    checkBox_V_cell_ball_1.Invoke(new Action(() => checkBox_V_cell_ball_1.Checked = true));
                                }
                                else
                                {
                                    checkBox_V_cell_ball_1.Invoke(new Action(() => checkBox_V_cell_ball_1.Checked = false));
                                }
                                if ((readBuffer[11] & 4) == 4)
                                {
                                    checkBox_V_cell_ball_2.Invoke(new Action(() => checkBox_V_cell_ball_2.Checked = true));
                                }
                                else
                                {
                                    checkBox_V_cell_ball_2.Invoke(new Action(() => checkBox_V_cell_ball_2.Checked = false));
                                }
                                if ((readBuffer[11] & 8) == 8)
                                {
                                    checkBox_V_cell_ball_3.Invoke(new Action(() => checkBox_V_cell_ball_3.Checked = true));
                                }
                                else
                                {
                                    checkBox_V_cell_ball_3.Invoke(new Action(() => checkBox_V_cell_ball_3.Checked = false));
                                }
                                if ((readBuffer[11] & 16) == 16)
                                {
                                    checkBox_V_cell_ball_4.Invoke(new Action(() => checkBox_V_cell_ball_4.Checked = true));
                                }
                                else
                                {
                                    checkBox_V_cell_ball_4.Invoke(new Action(() => checkBox_V_cell_ball_4.Checked = false));
                                }
                                if ((readBuffer[11] & 32) == 32)
                                {
                                    checkBox_V_cell_ball_5.Invoke(new Action(() => checkBox_V_cell_ball_5.Checked = true));
                                }
                                else
                                {
                                    checkBox_V_cell_ball_5.Invoke(new Action(() => checkBox_V_cell_ball_5.Checked = false));
                                }

                                if ((readBuffer[12] & 1) == 1)
                                {
                                    checkBox_power_in.Invoke(new Action(() => checkBox_power_in.Checked = true));
                                }
                                else
                                {
                                    checkBox_power_in.Invoke(new Action(() => checkBox_power_in.Checked = false));
                                }
                                if ((readBuffer[12] & 2) == 2)
                                {
                                    checkBox_power_out.Invoke(new Action(() => checkBox_power_out.Checked = true));
                                }
                                else
                                {
                                   checkBox_power_out.Invoke(new Action(() => checkBox_power_out.Checked = false));
                                }
                                if ((readBuffer[12] & 4) == 4)
                                {
                                    checkBox_charge.Invoke(new Action(() => checkBox_charge.Checked = true));
                                }
                                else
                                {
                                    checkBox_charge.Invoke(new Action(() => checkBox_charge.Checked = false));
                                }
                                if ((readBuffer[12] & 8) == 8)
                                {
                                    checkBox_calibr.Invoke(new Action(() => checkBox_calibr.Checked = true));
                                }
                                else
                                {
                                    checkBox_calibr.Invoke(new Action(() => checkBox_calibr.Checked = false));
                                }
                                
                                if ((readBuffer[12] & 128) == 128)
                                {
                                    DeviceInfoString = "VID - " + VID_value + " | PID - " + PID_value + " | 5 cells | Состояние устройства: ";

                                    toolStripStatusLabel1.Text = DeviceInfoString;
                                    toolStripStatusLabel2.Text = DeviceInfoStatus;

                                    //textBox_V_cell_5.Enabled = true;
                                    textBox_V_cell_5.Invoke(new Action(() => textBox_V_cell_5.Enabled = true));

                                    //textBox_Batt_23_temperature.Enabled = true;
                                    textBox_Batt_23_temperature.Invoke(new Action(() => textBox_Batt_23_temperature.Enabled = true));

                                    //textBox_Batt_45_temperature.Enabled = true;
                                    textBox_Batt_45_temperature.Invoke(new Action(() => textBox_Batt_45_temperature.Enabled = true));

                                    //checkBox_V_cell_ball_5.Enabled = true;
                                    checkBox_V_cell_ball_5.Invoke(new Action(() => checkBox_V_cell_ball_5.Enabled = true));

                                    if (i == 1 && first_message_flag == 0) listBox_info.Invoke(new Action(() => listBox_info.Items.Add("Количество элементов питания - 5")));
                                    first_message_flag = 1;
                                }
                                else if((readBuffer[12] & 128) != 128)
                                {
                                    DeviceInfoString = "VID - " + VID_value + " | PID - " + PID_value + " | 4 cells | Состояние устройства: ";

                                    toolStripStatusLabel1.Text = DeviceInfoString;
                                    toolStripStatusLabel2.Text = DeviceInfoStatus;

                                    //textBox_V_cell_5.Enabled = false;
                                    textBox_V_cell_5.Invoke(new Action(() => textBox_V_cell_5.Enabled = false));

                                   // textBox_Batt_23_temperature.Enabled = false;
                                    textBox_Batt_23_temperature.Invoke(new Action(() => textBox_Batt_23_temperature.Enabled = false));

                                    //textBox_Batt_45_temperature.Enabled = false;
                                    textBox_Batt_45_temperature.Invoke(new Action(() => textBox_Batt_45_temperature.Enabled = false));

                                    //checkBox_V_cell_ball_5.Enabled = false;
                                    checkBox_V_cell_ball_5.Invoke(new Action(() => checkBox_V_cell_ball_5.Enabled = false));

                                    if (i == 1 && first_message_flag == 0) listBox_info.Invoke(new Action(() => listBox_info.Items.Add("Количество элементов питания - 4")));
                                    first_message_flag = 1;
                                }

                                textProgressBar_SoC.Invoke(new Action(() => textProgressBar_SoC.Value = readBuffer[13]));

                                textBox_V_IN.Invoke(new Action(() => textBox_V_IN.Text = Convert.ToString(Build_the_count(readBuffer[15], readBuffer[14]))));
                                textBox_Cur_OUT.Invoke(new Action(() => textBox_Cur_OUT.Text = Convert.ToString(Build_the_count(readBuffer[17], readBuffer[16]))));
                                textBox_Pow_OUT.Invoke(new Action(() => textBox_Pow_OUT.Text = Convert.ToString(readBuffer[18])));

                                textBox_mah.Invoke(new Action(() => textBox_mah.Text = Convert.ToString(Build_the_count(readBuffer[20], readBuffer[19]))));

                                textBox_total_time.Invoke(new Action(() => textBox_total_time.Text = Convert.ToString(Build_the_count(readBuffer[22], readBuffer[21])) + ":" + Convert.ToString(readBuffer[23]) + ":" + Convert.ToString(readBuffer[24])));
                                textBox_battery_time.Invoke(new Action(() => textBox_battery_time.Text = Convert.ToString(Build_the_count(readBuffer[26], readBuffer[25])) + ":" + Convert.ToString(readBuffer[27]) + ":" + Convert.ToString(readBuffer[28])));

                                textBox_Remaining_time.Invoke(new Action(() => textBox_Remaining_time.Text = Convert.ToString(Build_the_count(readBuffer[34], readBuffer[33]) / 60)));

                                textBox_Batt_12_temperature.Invoke(new Action(() => textBox_Batt_12_temperature.Text = Convert.ToString(readBuffer[29])));
                                if (Convert.ToInt16(textBox_Batt_12_temperature.Text) >= Properties.Settings.Default.Cell_Mid_Temp) textBox_Batt_12_temperature.Invoke(new Action(() => textBox_Batt_12_temperature.BackColor = Color.Yellow));
                                if (Convert.ToInt16(textBox_Batt_12_temperature.Text) >= Properties.Settings.Default.Cell_High_Temp) textBox_Batt_12_temperature.Invoke(new Action(() => textBox_Batt_12_temperature.BackColor = Color.Red));
                                else if(Convert.ToInt16(textBox_Batt_12_temperature.Text) < Properties.Settings.Default.Cell_Low_Temp) textBox_Batt_12_temperature.Invoke(new Action(() => textBox_Batt_12_temperature.BackColor = SystemColors.Control));

                                textBox_Batt_23_temperature.Invoke(new Action(() => textBox_Batt_23_temperature.Text = Convert.ToString(readBuffer[30])));
                                if (Convert.ToInt16(textBox_Batt_23_temperature.Text) >= Properties.Settings.Default.Cell_Mid_Temp) textBox_Batt_23_temperature.Invoke(new Action(() => textBox_Batt_23_temperature.BackColor = Color.Yellow));
                                if (Convert.ToInt16(textBox_Batt_23_temperature.Text) >= Properties.Settings.Default.Cell_High_Temp) textBox_Batt_23_temperature.Invoke(new Action(() => textBox_Batt_23_temperature.BackColor = Color.Red));
                                else if (Convert.ToInt16(textBox_Batt_23_temperature.Text) < Properties.Settings.Default.Cell_Low_Temp) textBox_Batt_23_temperature.Invoke(new Action(() => textBox_Batt_23_temperature.BackColor = SystemColors.Control));

                                textBox_Batt_34_temperature.Invoke(new Action(() => textBox_Batt_34_temperature.Text = Convert.ToString(readBuffer[31])));
                                if (Convert.ToInt16(textBox_Batt_34_temperature.Text) >= Properties.Settings.Default.Cell_Mid_Temp) textBox_Batt_34_temperature.Invoke(new Action(() => textBox_Batt_34_temperature.BackColor = Color.Yellow));
                                if (Convert.ToInt16(textBox_Batt_34_temperature.Text) >= Properties.Settings.Default.Cell_High_Temp) textBox_Batt_34_temperature.Invoke(new Action(() => textBox_Batt_34_temperature.BackColor = Color.Red));
                                else if (Convert.ToInt16(textBox_Batt_34_temperature.Text) < Properties.Settings.Default.Cell_Low_Temp) textBox_Batt_34_temperature.Invoke(new Action(() => textBox_Batt_34_temperature.BackColor = SystemColors.Control)); 

                                textBox_Batt_45_temperature.Invoke(new Action(() => textBox_Batt_45_temperature.Text = Convert.ToString(readBuffer[32])));
                                if (Convert.ToInt16(textBox_Batt_45_temperature.Text) >= Properties.Settings.Default.Cell_Mid_Temp) textBox_Batt_45_temperature.Invoke(new Action(() => textBox_Batt_45_temperature.BackColor = Color.Yellow));
                                if (Convert.ToInt16(textBox_Batt_45_temperature.Text) >= Properties.Settings.Default.Cell_High_Temp) textBox_Batt_45_temperature.Invoke(new Action(() => textBox_Batt_45_temperature.BackColor = Color.Red));
                                else if (Convert.ToInt16(textBox_Batt_45_temperature.Text) < Properties.Settings.Default.Cell_Low_Temp) textBox_Batt_45_temperature.Invoke(new Action(() => textBox_Batt_45_temperature.BackColor = SystemColors.Control));

                            }
                            
                            // fill the fields in the DEBUG mode of MiniUPS board
                            if (readBuffer[0] == ReportID_debug)
                            {
                                tabControl1.Invoke(new Action(() => tabControl1.SelectedIndex = 2));
                                i++;
                                // forming the output string
                                String red_bytes = null;
                                for (int j = 0; j < bytesRead; j++)
                                {
                                    red_bytes = red_bytes + readBuffer[j] + " ";
                                }

                                if ((readBuffer[1] & 1) == 1)
                                {
                                    checkBox_test_BQ769003.Invoke(new Action(() => checkBox_test_BQ769003.Enabled = true));
                                    checkBox_test_BQ769003.Invoke(new Action(() => checkBox_test_BQ769003.Checked = true));
                                    panel_BQ769.Invoke(new Action(() => panel_BQ769.BackColor = Color.Green));
                                }
                                else
                                {
                                    checkBox_test_BQ769003.Invoke(new Action(() => checkBox_test_BQ769003.Enabled = false));
                                    checkBox_test_BQ769003.Invoke(new Action(() => checkBox_test_BQ769003.Checked = false));
                                    if ((readBuffer[1] == 0)) panel_BQ769.Invoke(new Action(() => panel_BQ769.BackColor = Color.FloralWhite));
                                    if ((readBuffer[1] & 2) == 2) panel_BQ769.Invoke(new Action(() => panel_BQ769.BackColor = Color.Red));
                                }

                                if ((readBuffer[2] & 1) == 1)
                                {
                                    checkBox_test_INA226.Invoke(new Action(() => checkBox_test_INA226.Enabled = true));
                                    checkBox_test_INA226.Invoke(new Action(() => checkBox_test_INA226.Checked = true));
                                    panel_INA226.Invoke(new Action(() => panel_INA226.BackColor = Color.Green));
                                }
                                else
                                {
                                    checkBox_test_INA226.Invoke(new Action(() => checkBox_test_INA226.Enabled = false));
                                    checkBox_test_INA226.Invoke(new Action(() => checkBox_test_INA226.Checked = false));
                                    if ((readBuffer[2] == 0)) panel_INA226.Invoke(new Action(() => panel_INA226.BackColor = Color.FloralWhite));
                                    if ((readBuffer[2] & 2) == 2) panel_INA226.Invoke(new Action(() => panel_INA226.BackColor = Color.Red));
                                }

                                if ((readBuffer[3] & 1) == 1)
                                {
                                    checkBox_test_M24C08.Invoke(new Action(() => checkBox_test_M24C08.Enabled = true));
                                    checkBox_test_M24C08.Invoke(new Action(() => checkBox_test_M24C08.Checked = true));
                                    panel_M24C08.Invoke(new Action(() => panel_M24C08.BackColor = Color.Green));
                                }
                                else
                                {
                                    checkBox_test_M24C08.Invoke(new Action(() => checkBox_test_M24C08.Enabled = false));
                                    checkBox_test_M24C08.Invoke(new Action(() => checkBox_test_M24C08.Checked = false));
                                    if ((readBuffer[3] == 0)) panel_M24C08.Invoke(new Action(() => panel_M24C08.BackColor = Color.FloralWhite));
                                    if((readBuffer[3] & 2) == 2) panel_M24C08.Invoke(new Action(() => panel_M24C08.BackColor = Color.Red));
                                }

                                if ((readBuffer[18] & 1) == 1)
                                {
                                    panel_Charge_OnOff.Invoke(new Action(() => panel_Charge_OnOff.BackColor = Color.Green));
                                    checkBox_Debug_Charge_OnOff.Invoke(new Action(() => checkBox_Debug_Charge_OnOff.Enabled = true));
                                    checkBox_Debug_Charge_OnOff.Invoke(new Action(() => checkBox_Debug_Charge_OnOff.Checked = true));

                                    pictureBox_DB_charge_On_Off.Invoke(new Action(() => pictureBox_DB_charge_On_Off.Image = Properties.Resources.Charge_On));
                                }
                                else
                                {
                                    panel_Charge_OnOff.Invoke(new Action(() => panel_Charge_OnOff.BackColor = Color.FloralWhite));
                                    checkBox_Debug_Charge_OnOff.Invoke(new Action(() => checkBox_Debug_Charge_OnOff.Enabled = false));
                                    checkBox_Debug_Charge_OnOff.Invoke(new Action(() => checkBox_Debug_Charge_OnOff.Checked = false));

                                    pictureBox_DB_charge_On_Off.Invoke(new Action(() => pictureBox_DB_charge_On_Off.Image = Properties.Resources.Charge_Off));
                                }

                                int buttons_count = readBuffer[19] & 0xff;
                                label_buttons_pressings_count.Invoke(new Action(() => label_buttons_pressings_count.Text = Convert.ToString(buttons_count)));
                                

                                textBox_test_Voltage_Sens_1.Invoke(new Action(() => textBox_test_Voltage_Sens_1.Text = Convert.ToString(Build_the_count(readBuffer[5], readBuffer[4]))));
                                textBox_test_Voltage_Sens_2.Invoke(new Action(() => textBox_test_Voltage_Sens_2.Text = Convert.ToString(Build_the_count(readBuffer[7], readBuffer[6]))));
                                textBox_test_Voltage_Sens_3.Invoke(new Action(() => textBox_test_Voltage_Sens_3.Text = Convert.ToString(Build_the_count(readBuffer[9], readBuffer[8]))));
                                textBox_test_Voltage_Sens_4.Invoke(new Action(() => textBox_test_Voltage_Sens_4.Text = Convert.ToString(Build_the_count(readBuffer[11], readBuffer[10]))));
                                textBox_test_Voltage_Sens_5.Invoke(new Action(() => textBox_test_Voltage_Sens_5.Text = Convert.ToString(Build_the_count(readBuffer[13], readBuffer[12]))));

                                //textBox_test_Voltage_Sens_1.Invoke(new Action(() => textBox_test_Voltage_Sens_1.Text = Convert.ToString(readBuffer[4])));
                                //textBox_test_Voltage_Sens_2.Invoke(new Action(() => textBox_test_Voltage_Sens_2.Text = Convert.ToString(readBuffer[5])));
                                //textBox_test_Voltage_Sens_3.Invoke(new Action(() => textBox_test_Voltage_Sens_3.Text = Convert.ToString(readBuffer[6])));
                                //textBox_test_Voltage_Sens_4.Invoke(new Action(() => textBox_test_Voltage_Sens_4.Text = Convert.ToString(readBuffer[7])));
                                //textBox_test_Voltage_Sens_5.Invoke(new Action(() => textBox_test_Voltage_Sens_5.Text = Convert.ToString(readBuffer[8])));

                                textBox_test_temp_sens_1.Invoke(new Action(() => textBox_test_temp_sens_1.Text = Convert.ToString(readBuffer[14])));
                                textBox_test_temp_sens_2.Invoke(new Action(() => textBox_test_temp_sens_2.Text = Convert.ToString(readBuffer[15])));
                                textBox_test_temp_sens_3.Invoke(new Action(() => textBox_test_temp_sens_3.Text = Convert.ToString(readBuffer[16])));
                                textBox_test_temp_sens_4.Invoke(new Action(() => textBox_test_temp_sens_4.Text = Convert.ToString(readBuffer[17])));

                                textBox_V_In_db.Invoke(new Action(() => textBox_V_In_db.Text = Convert.ToString(Build_the_count(readBuffer[21], readBuffer[20]))));
                                textBox_V_Out_db.Invoke(new Action(() => textBox_V_Out_db.Text = Convert.ToString(Build_the_count(readBuffer[23], readBuffer[22]))));
                                textBox_I_batt.Invoke(new Action(() => textBox_I_batt.Text = Convert.ToString(Build_the_count(readBuffer[25], readBuffer[24]))));
                            }
                        }
                        if (i >= CountOfBytes)
                        {
                            i = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                textBox_error.Invoke(new Action(() => textBox_error.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message));
                textBox_error.ForeColor = Color.Red;
                if (ex.Message.ToString().Equals("Win32Error:No more bytes!"))
                {
                    timer1.Enabled = false;
                    checkBox_TimerGetUPSData_Enable.Invoke(new Action(() => checkBox_TimerGetUPSData_Enable.Checked = false));
                    checkBox_TimerGetUPSData_Enable.Invoke(new Action(() => checkBox_TimerGetUPSData_Enable.Enabled = false));

                    FindUsbDeviceByVidPid(VID_value, PID_value);
                }
            }
            AbortThread();
        }
        //-------------------------------------------------------------------------------------------------------------------------------//
        void GetUPSDataFromUSBbyReportId_notThread()
        {
            // get the data by Report ID function
            try
            {
                var CountOfBytes = 2;
                var ReportID = 161; //0xA1
                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);
                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                        // open read endpoint 1.

                        UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01, 8, LibUsbDotNet.Main.EndpointType.Interrupt);
                        byte[] readBuffer = new byte[1024];
                        int i = 0;

                        //label_er.Text = "Ошибок нет";
                        //label_er.ForeColor = Color.Black;
                        textBox_error.Text = "Ошибок нет";
                        textBox_error.ForeColor = Color.Black;

                        while (i < CountOfBytes)
                        {

                            int bytesRead = 0;

                            // If the device hasn't sent data in the last 5 seconds,
                            // a timeout error (ec = IoTimedOut) will occur. 
                            ec = reader.Read(readBuffer, 5000, out bytesRead);

                            if (bytesRead == 0) throw new Exception(string.Format("{0}:No more bytes!", ec));

                            if (readBuffer[0] == ReportID)
                            {
                                i++;

                                // forming the output string
                                String red_bytes = null;
                                for (int j = 0; j < bytesRead; j++)
                                {
                                    red_bytes = red_bytes + readBuffer[j] + " ";
                                }

                                textBox_V_cell_1.Text = Convert.ToString(Build_the_count(readBuffer[2], readBuffer[1]));
                                textBox_V_cell_2.Text = Convert.ToString(Build_the_count(readBuffer[4], readBuffer[3]));
                                textBox_V_cell_3.Text = Convert.ToString(Build_the_count(readBuffer[6], readBuffer[5]));
                                textBox_V_cell_4.Text = Convert.ToString(Build_the_count(readBuffer[8], readBuffer[7]));

                                if ((readBuffer[9] & 1) == 1)
                                {
                                    checkBox_power_in.Checked = true;
                                }
                                else
                                {
                                    checkBox_power_in.Checked = false;
                                }
                                if ((readBuffer[9] & 2) == 2)
                                {
                                    checkBox_power_out.Checked = true;
                                }
                                else
                                {
                                    checkBox_power_out.Checked = false;
                                }
                                if ((readBuffer[9] & 4) == 4)
                                {
                                    checkBox_charge.Checked = true;
                                }
                                else
                                {
                                    checkBox_charge.Checked = false;
                                }
                                if ((readBuffer[9] & 8) == 8)
                                {
                                    checkBox_calibr.Checked = true;
                                }
                                else
                                {
                                    checkBox_calibr.Checked = false;
                                }
                                if ((readBuffer[9] & 16) == 16)
                                {
                                    checkBox_V_cell_ball_1.Checked = true;
                                }
                                else
                                {
                                    checkBox_V_cell_ball_1.Checked = false;
                                }
                                if ((readBuffer[9] & 32) == 32)
                                {
                                    checkBox_V_cell_ball_2.Checked = true;
                                }
                                else
                                {
                                    checkBox_V_cell_ball_2.Checked = false;
                                }
                                if ((readBuffer[9] & 64) == 64)
                                {
                                    checkBox_V_cell_ball_3.Checked = true;
                                }
                                else
                                {
                                    checkBox_V_cell_ball_3.Checked = false;
                                }
                                if ((readBuffer[9] & 128) == 128)
                                {
                                    checkBox_V_cell_ball_4.Checked = true;
                                }
                                else
                                {
                                    checkBox_V_cell_ball_4.Checked = false;
                                }

                                //textBox_SoC.Text = Convert.ToString(readBuffer[10]);
                                textBox_V_IN.Text = Convert.ToString(Build_the_count(readBuffer[12], readBuffer[11]));
                                textBox_Cur_OUT.Text = Convert.ToString(Build_the_count(readBuffer[14], readBuffer[13]));
                                textBox_Pow_OUT.Text = Convert.ToString(readBuffer[15]);

                                textBox_mah.Text = Convert.ToString(Build_the_count(readBuffer[17], readBuffer[16]));

                                textBox_total_time.Text = Convert.ToString(Build_the_count(readBuffer[19], readBuffer[18]));
                                textBox_battery_time.Text = Convert.ToString(readBuffer[20] + Build_the_count(readBuffer[22], readBuffer[21]));

                            }

                        }
                        if (i >= CountOfBytes)
                        {
                            i = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //label_er.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;
                //label_er.ForeColor = Color.Red;
                textBox_error.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;
                textBox_error.ForeColor = Color.Red;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------//
        void SendDataToUSB()
        {
            // send data to USB HID device by Report ID 
            try
            {
                var ReportID_OUT = 0xA2;
                byte[] writeBuffer = new byte[8];
                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);

                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                    }

                    // open write endpoint 1.
                    UsbEndpointWriter writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01, LibUsbDotNet.Main.EndpointType.Interrupt);
                    int bytesWritten;
                    writeBuffer[0] = Convert.ToByte(ReportID_OUT);
                    ec = writer.Write(writeBuffer, 2000, out bytesWritten);
                    //textBox_written_bytes.Invoke(new Action(() => textBox_written_bytes.Text = Convert.ToString(bytesWritten)));
                    if (ec != ErrorCode.None) throw new Exception(UsbDevice.LastErrorString);
                }
            }
            catch (Exception ex)
            {
               // label_er.Invoke(new Action(() => label_er.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message));
               // label_er.ForeColor = Color.Red;
                textBox_error.Invoke(new Action(() => textBox_error.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message));
                textBox_error.ForeColor = Color.Red;
            }
        }
        void SendDataToUSBbyReportID(int ReportID_OUT)
        {
            // send data to USB HID device by Report ID 
            try
            {
                //var ReportID_OUT = 0xA2;
                byte[] writeBuffer = new byte[8];
                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);

                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                    }

                    // open write endpoint 1.
                    UsbEndpointWriter writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01, LibUsbDotNet.Main.EndpointType.Interrupt);
                    int bytesWritten;
                    writeBuffer[0] = Convert.ToByte(ReportID_OUT);
                    ec = writer.Write(writeBuffer, 2000, out bytesWritten);
                    //textBox_written_bytes.Invoke(new Action(() => textBox_written_bytes.Text = Convert.ToString(bytesWritten)));
                    if (ec != ErrorCode.None) throw new Exception(UsbDevice.LastErrorString);
                }
            }
            catch (Exception ex)
            {
               // label_er.Invoke(new Action(() => label_er.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message));
               // label_er.ForeColor = Color.Red;
                textBox_error.Invoke(new Action(() => textBox_error.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message));
                textBox_error.ForeColor = Color.Red;
            }
        }

        public static void SendSerialNumberToUSB(String serial_number)
        {
            // send data to USB HID device by Report ID 
            try
            {
                var ReportID_OUT = 0xCC; //204
                byte[] writeBuffer = new byte[10];

                for (int i = 0; i< serial_number.Length; i++)
                {
                    writeBuffer[i + 1] = Convert.ToByte(serial_number[i]);
                }

                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);

                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                    }

                    // open write endpoint 1.
                    UsbEndpointWriter writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01, LibUsbDotNet.Main.EndpointType.Interrupt);
                    int bytesWritten;
                    writeBuffer[0] = Convert.ToByte(ReportID_OUT);
                    ec = writer.Write(writeBuffer, 2000, out bytesWritten);
                    //textBox_written_bytes.Invoke(new Action(() => textBox_written_bytes.Text = Convert.ToString(bytesWritten)));
                    if (ec != ErrorCode.None) throw new Exception(UsbDevice.LastErrorString);
                }
            }
            catch (Exception ex)
            {
                var textBox_error = new TextBox();
                //textBox_error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                //textBox_error.Cursor = System.Windows.Forms.Cursors.Arrow;
                //textBox_error.Location = new System.Drawing.Point(3, 16);
                //textBox_error.Multiline = true;
                //textBox_error.Name = "textBox_error";
                //textBox_error.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                //textBox_error.Size = new System.Drawing.Size(419, 35);
                //textBox_error.TabIndex = 32;
                //textBox_error.TabStop = false;

                textBox_error.Invoke(new Action(() => textBox_error.Text = "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message));
                textBox_error.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Функции для корректной работы с Threads
        //-----------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        //--------------------                  Функции для работы с Threads                -------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        void AbortThread()
        {
            _thread.Abort(); // Остановить поток 
        }

        private void AddToListBox(string text)
        {
            if (InvokeRequired)
                Invoke((Action<string>)AddToListBox, text);
            else
                listBox_info.Items.Add(text);
        }

        private void AddToListBox(ListBox listBox, string text)
        {
            if (InvokeRequired)
                Invoke((Action<string>)AddToListBox, text);
            else
                listBox.Items.Add(text);
        }

        private void AddToListBoxByID(ListBox listBox, string text, int i)
        {
            if (InvokeRequired)
                Invoke((Action<string>)AddToListBox, text);
            else
                listBox.Items[i] = text;
        }

        private void ListBoxClear(string text)
        {
            if (InvokeRequired)
                Invoke((Action<string>)AddToListBox, text);
            else
                listBox_info.Items.Clear();
        }

        private void ListBoxClear(ListBox listBox, string text)
        {
            if (InvokeRequired)
                Invoke((Action<string>)ListBoxClear, text);
            else
                listBox.Items.Clear();
        }



        private int Build_the_count(byte LOW, byte HIGH)
        {
            int count = 0;
            count = (LOW & 0xff) | ((HIGH & 0xff) << 8);
            return count;
        }
        #endregion

        #region Отображение изображения с положением копонента на печатной плате
        //-----------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        //--------------------         Вывод расположения проверяемого компонента на ПП     -------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------//
        private void checkBox_test_BQ769003_MouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                using (Form_With_Help_Image f = new Form_With_Help_Image())
                {
                    f.Owner = this;
                    f.Text = "Расположение элемента BQ7692003";
                    f.pictureBox_elements_placement.Image = Properties.Resources.Element_1_position;
                    f.pictureBox_elements_placement.Height = f.pictureBox_elements_placement.Image.Height;
                    f.Height = f.pictureBox_elements_placement.Image.Height + 30;
                    f.pictureBox_elements_placement.Width = f.pictureBox_elements_placement.Image.Width;
                    f.Width = f.pictureBox_elements_placement.Image.Width + 15;
                    f.ShowDialog();
                }
            }
        }

        private void checkBox_test_INA226_MouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                using (Form_With_Help_Image f = new Form_With_Help_Image())
                {
                    f.Owner = this;
                    f.Text = "Расположение элемента INA226";
                    f.pictureBox_elements_placement.Image = Properties.Resources.Element_2_position;
                    f.pictureBox_elements_placement.Height = f.pictureBox_elements_placement.Image.Height;
                    f.Height = f.pictureBox_elements_placement.Image.Height + 30;
                    f.pictureBox_elements_placement.Width = f.pictureBox_elements_placement.Image.Width;
                    f.Width = f.pictureBox_elements_placement.Image.Width + 15;
                    f.ShowDialog();
                }
            }
        }

        private void checkBox_test_M24C08_MouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                using (Form_With_Help_Image f = new Form_With_Help_Image())
                {
                    f.Owner = this;
                    f.Text = "Расположение элемента M24C08";
                    f.pictureBox_elements_placement.Image = Properties.Resources.Element_3_position;
                    f.pictureBox_elements_placement.Height = f.pictureBox_elements_placement.Image.Height;
                    f.Height = f.pictureBox_elements_placement.Image.Height + 30;
                    f.pictureBox_elements_placement.Width = f.pictureBox_elements_placement.Image.Width;
                    f.Width = f.pictureBox_elements_placement.Image.Width + 15;
                    f.ShowDialog();
                }
                
            }
        }

        void change_chip_panel_color(Panel panel, Color color)
        {
            if(panel.GetHashCode() == panel_M24C08.GetHashCode()) panel.BackColor = color;
        }
        //-----------------------------------------------------------------------------------------------------------------//
        #endregion
    }
}
