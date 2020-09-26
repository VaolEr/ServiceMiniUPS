namespace ServiceMiniUPS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_V_cell_ball_5 = new System.Windows.Forms.CheckBox();
            this.checkBox_V_cell_ball_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_V_cell_ball_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_V_cell_ball_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_V_cell_ball_3 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_V_cell_5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_V_cell_1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_V_cell_2 = new System.Windows.Forms.TextBox();
            this.textBox_V_cell_4 = new System.Windows.Forms.TextBox();
            this.textBox_V_cell_3 = new System.Windows.Forms.TextBox();
            this.checkBox_calibr = new System.Windows.Forms.CheckBox();
            this.checkBox_charge = new System.Windows.Forms.CheckBox();
            this.checkBox_power_out = new System.Windows.Forms.CheckBox();
            this.checkBox_power_in = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_V_IN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Cur_OUT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Pow_OUT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_get_ups_data = new System.Windows.Forms.Button();
            this.textBox_mah = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_Remaining_time = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_battery_time = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_total_time = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_Batt_34_temperature = new System.Windows.Forms.TextBox();
            this.textBox_Batt_12_temperature = new System.Windows.Forms.TextBox();
            this.groupBox_errors = new System.Windows.Forms.GroupBox();
            this.label_report_id = new System.Windows.Forms.Label();
            this.textBox_error = new System.Windows.Forms.TextBox();
            this.groupBox_USB_device = new System.Windows.Forms.GroupBox();
            this.listBox_info = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip_get_UPS_Data = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_test_M24C08 = new System.Windows.Forms.CheckBox();
            this.checkBox_test_INA226 = new System.Windows.Forms.CheckBox();
            this.checkBox_test_BQ769003 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Batt_45_temperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Batt_23_temperature = new System.Windows.Forms.TextBox();
            this.textProgressBar_SoC = new ProgressBarSample.TextProgressBar();
            this.toolTip_textBox_VID = new System.Windows.Forms.ToolTip(this.components);
            this.toolTiptextBox_PID = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.toolTip_Timer = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Write_to_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.USB_UPS_Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSerialNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.температурныеДиапазоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrosTable_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_I_batt = new System.Windows.Forms.TextBox();
            this.textBox_V_Out_db = new System.Windows.Forms.TextBox();
            this.textBox_V_In_db = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel_Charge_OnOff = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_Debug_Charge_OnOff = new System.Windows.Forms.CheckBox();
            this.label_buttons_pressings_count = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_test_temp_sens_1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_test_temp_sens_2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_test_temp_sens_3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_test_temp_sens_4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label32 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_test_Voltage_Sens_1 = new System.Windows.Forms.TextBox();
            this.textBox_test_Voltage_Sens_5 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_test_Voltage_Sens_2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_test_Voltage_Sens_4 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_test_Voltage_Sens_3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel_BQ769 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel_INA226 = new System.Windows.Forms.Panel();
            this.panel_M24C08 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_DB_charge_On_Off = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_chip_image = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel_timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_TimerGetUPSData_Enable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_errors.SuspendLayout();
            this.groupBox_USB_device.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel_Charge_OnOff.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_BQ769.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel_INA226.SuspendLayout();
            this.panel_M24C08.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DB_charge_On_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chip_image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.textBox_V_cell_5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_V_cell_1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_V_cell_2);
            this.groupBox1.Controls.Add(this.textBox_V_cell_4);
            this.groupBox1.Controls.Add(this.textBox_V_cell_3);
            this.groupBox1.Location = new System.Drawing.Point(6, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 119);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Напряжение ячеек, mV";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_V_cell_ball_5);
            this.groupBox5.Controls.Add(this.checkBox_V_cell_ball_1);
            this.groupBox5.Controls.Add(this.checkBox_V_cell_ball_4);
            this.groupBox5.Controls.Add(this.checkBox_V_cell_ball_2);
            this.groupBox5.Controls.Add(this.checkBox_V_cell_ball_3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(11, 58);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(380, 51);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Балансировка";
            this.toolTip_get_UPS_Data.SetToolTip(this.groupBox5, "Статус балансировочного флага для каждой из ячеек");
            this.groupBox5.UseCompatibleTextRendering = true;
            // 
            // checkBox_V_cell_ball_5
            // 
            this.checkBox_V_cell_ball_5.AutoCheck = false;
            this.checkBox_V_cell_ball_5.AutoSize = true;
            this.checkBox_V_cell_ball_5.Location = new System.Drawing.Point(343, 22);
            this.checkBox_V_cell_ball_5.Name = "checkBox_V_cell_ball_5";
            this.checkBox_V_cell_ball_5.Size = new System.Drawing.Size(39, 17);
            this.checkBox_V_cell_ball_5.TabIndex = 20;
            this.checkBox_V_cell_ball_5.Text = "B5";
            this.checkBox_V_cell_ball_5.UseVisualStyleBackColor = true;
            // 
            // checkBox_V_cell_ball_1
            // 
            this.checkBox_V_cell_ball_1.AutoCheck = false;
            this.checkBox_V_cell_ball_1.AutoSize = true;
            this.checkBox_V_cell_ball_1.Location = new System.Drawing.Point(15, 22);
            this.checkBox_V_cell_ball_1.Name = "checkBox_V_cell_ball_1";
            this.checkBox_V_cell_ball_1.Size = new System.Drawing.Size(39, 17);
            this.checkBox_V_cell_ball_1.TabIndex = 16;
            this.checkBox_V_cell_ball_1.Text = "B1";
            this.checkBox_V_cell_ball_1.UseVisualStyleBackColor = true;
            // 
            // checkBox_V_cell_ball_4
            // 
            this.checkBox_V_cell_ball_4.AutoCheck = false;
            this.checkBox_V_cell_ball_4.AutoSize = true;
            this.checkBox_V_cell_ball_4.Location = new System.Drawing.Point(263, 22);
            this.checkBox_V_cell_ball_4.Name = "checkBox_V_cell_ball_4";
            this.checkBox_V_cell_ball_4.Size = new System.Drawing.Size(39, 17);
            this.checkBox_V_cell_ball_4.TabIndex = 19;
            this.checkBox_V_cell_ball_4.Text = "B4";
            this.checkBox_V_cell_ball_4.UseVisualStyleBackColor = true;
            // 
            // checkBox_V_cell_ball_2
            // 
            this.checkBox_V_cell_ball_2.AutoCheck = false;
            this.checkBox_V_cell_ball_2.AutoSize = true;
            this.checkBox_V_cell_ball_2.Location = new System.Drawing.Point(101, 22);
            this.checkBox_V_cell_ball_2.Name = "checkBox_V_cell_ball_2";
            this.checkBox_V_cell_ball_2.Size = new System.Drawing.Size(39, 17);
            this.checkBox_V_cell_ball_2.TabIndex = 17;
            this.checkBox_V_cell_ball_2.Text = "B2";
            this.checkBox_V_cell_ball_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_V_cell_ball_3
            // 
            this.checkBox_V_cell_ball_3.AutoCheck = false;
            this.checkBox_V_cell_ball_3.AutoSize = true;
            this.checkBox_V_cell_ball_3.Location = new System.Drawing.Point(181, 22);
            this.checkBox_V_cell_ball_3.Name = "checkBox_V_cell_ball_3";
            this.checkBox_V_cell_ball_3.Size = new System.Drawing.Size(39, 17);
            this.checkBox_V_cell_ball_3.TabIndex = 18;
            this.checkBox_V_cell_ball_3.Text = "B3";
            this.checkBox_V_cell_ball_3.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(350, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(33, 13);
            this.label27.TabIndex = 30;
            this.label27.Text = "Cell 5";
            // 
            // textBox_V_cell_5
            // 
            this.textBox_V_cell_5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_V_cell_5.Location = new System.Drawing.Point(341, 32);
            this.textBox_V_cell_5.Name = "textBox_V_cell_5";
            this.textBox_V_cell_5.ReadOnly = true;
            this.textBox_V_cell_5.ShortcutsEnabled = false;
            this.textBox_V_cell_5.Size = new System.Drawing.Size(50, 20);
            this.textBox_V_cell_5.TabIndex = 29;
            this.textBox_V_cell_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_V_cell_5, "Напряжение на ячейке 5");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cell 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cell 1";
            // 
            // textBox_V_cell_1
            // 
            this.textBox_V_cell_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_V_cell_1.Location = new System.Drawing.Point(11, 32);
            this.textBox_V_cell_1.Name = "textBox_V_cell_1";
            this.textBox_V_cell_1.ReadOnly = true;
            this.textBox_V_cell_1.ShortcutsEnabled = false;
            this.textBox_V_cell_1.Size = new System.Drawing.Size(50, 20);
            this.textBox_V_cell_1.TabIndex = 0;
            this.textBox_V_cell_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_V_cell_1, "Напряжение на ячейке 1");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cell 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cell 2";
            // 
            // textBox_V_cell_2
            // 
            this.textBox_V_cell_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_V_cell_2.Location = new System.Drawing.Point(95, 32);
            this.textBox_V_cell_2.Name = "textBox_V_cell_2";
            this.textBox_V_cell_2.ReadOnly = true;
            this.textBox_V_cell_2.ShortcutsEnabled = false;
            this.textBox_V_cell_2.Size = new System.Drawing.Size(50, 20);
            this.textBox_V_cell_2.TabIndex = 1;
            this.textBox_V_cell_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_V_cell_2, "Напряжение на ячейке 2");
            // 
            // textBox_V_cell_4
            // 
            this.textBox_V_cell_4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_V_cell_4.Location = new System.Drawing.Point(261, 32);
            this.textBox_V_cell_4.Name = "textBox_V_cell_4";
            this.textBox_V_cell_4.ReadOnly = true;
            this.textBox_V_cell_4.ShortcutsEnabled = false;
            this.textBox_V_cell_4.Size = new System.Drawing.Size(50, 20);
            this.textBox_V_cell_4.TabIndex = 3;
            this.textBox_V_cell_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_V_cell_4, "Напряжение на ячейке 4");
            // 
            // textBox_V_cell_3
            // 
            this.textBox_V_cell_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_V_cell_3.Location = new System.Drawing.Point(176, 32);
            this.textBox_V_cell_3.Name = "textBox_V_cell_3";
            this.textBox_V_cell_3.ReadOnly = true;
            this.textBox_V_cell_3.ShortcutsEnabled = false;
            this.textBox_V_cell_3.Size = new System.Drawing.Size(50, 20);
            this.textBox_V_cell_3.TabIndex = 2;
            this.textBox_V_cell_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_V_cell_3, "Напряжение на ячейке 3");
            // 
            // checkBox_calibr
            // 
            this.checkBox_calibr.AutoCheck = false;
            this.checkBox_calibr.AutoSize = true;
            this.checkBox_calibr.Location = new System.Drawing.Point(204, 19);
            this.checkBox_calibr.Name = "checkBox_calibr";
            this.checkBox_calibr.Size = new System.Drawing.Size(87, 17);
            this.checkBox_calibr.TabIndex = 3;
            this.checkBox_calibr.Text = "Калибровка";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_calibr, "Флаг, свидетельствующий о процессе калибровки в данный момент");
            this.checkBox_calibr.UseVisualStyleBackColor = true;
            // 
            // checkBox_charge
            // 
            this.checkBox_charge.AutoCheck = false;
            this.checkBox_charge.AutoSize = true;
            this.checkBox_charge.Location = new System.Drawing.Point(294, 19);
            this.checkBox_charge.Name = "checkBox_charge";
            this.checkBox_charge.Size = new System.Drawing.Size(101, 17);
            this.checkBox_charge.TabIndex = 2;
            this.checkBox_charge.Text = "Заряд батареи";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_charge, "Флаг, свидетельсвующий о зарядке в данный момент");
            this.checkBox_charge.UseVisualStyleBackColor = true;
            // 
            // checkBox_power_out
            // 
            this.checkBox_power_out.AutoCheck = false;
            this.checkBox_power_out.AutoSize = true;
            this.checkBox_power_out.Location = new System.Drawing.Point(6, 19);
            this.checkBox_power_out.Name = "checkBox_power_out";
            this.checkBox_power_out.Size = new System.Drawing.Size(83, 17);
            this.checkBox_power_out.TabIndex = 1;
            this.checkBox_power_out.Text = "Выход UPS";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_power_out, "Флаг наличия выходного напряжения от UPS");
            this.checkBox_power_out.UseVisualStyleBackColor = true;
            // 
            // checkBox_power_in
            // 
            this.checkBox_power_in.AutoCheck = false;
            this.checkBox_power_in.AutoSize = true;
            this.checkBox_power_in.Location = new System.Drawing.Point(89, 19);
            this.checkBox_power_in.Name = "checkBox_power_in";
            this.checkBox_power_in.Size = new System.Drawing.Size(115, 17);
            this.checkBox_power_in.TabIndex = 0;
            this.checkBox_power_in.Text = "Внешнее питание";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_power_in, "Флаг наличия входной сети");
            this.checkBox_power_in.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Выходная мощность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Выходной ток";
            // 
            // textBox_V_IN
            // 
            this.textBox_V_IN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_V_IN.Location = new System.Drawing.Point(126, 46);
            this.textBox_V_IN.Name = "textBox_V_IN";
            this.textBox_V_IN.ReadOnly = true;
            this.textBox_V_IN.ShortcutsEnabled = false;
            this.textBox_V_IN.Size = new System.Drawing.Size(50, 20);
            this.textBox_V_IN.TabIndex = 9;
            this.textBox_V_IN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_V_IN, "Текущее значение входного напряжения");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Входное напряжение";
            // 
            // textBox_Cur_OUT
            // 
            this.textBox_Cur_OUT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Cur_OUT.Location = new System.Drawing.Point(126, 72);
            this.textBox_Cur_OUT.Name = "textBox_Cur_OUT";
            this.textBox_Cur_OUT.ReadOnly = true;
            this.textBox_Cur_OUT.ShortcutsEnabled = false;
            this.textBox_Cur_OUT.Size = new System.Drawing.Size(50, 20);
            this.textBox_Cur_OUT.TabIndex = 10;
            this.textBox_Cur_OUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_Cur_OUT, "Текущее значение выходного тока");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Заряд UPS";
            // 
            // textBox_Pow_OUT
            // 
            this.textBox_Pow_OUT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Pow_OUT.Location = new System.Drawing.Point(126, 98);
            this.textBox_Pow_OUT.Name = "textBox_Pow_OUT";
            this.textBox_Pow_OUT.ReadOnly = true;
            this.textBox_Pow_OUT.ShortcutsEnabled = false;
            this.textBox_Pow_OUT.Size = new System.Drawing.Size(50, 20);
            this.textBox_Pow_OUT.TabIndex = 11;
            this.textBox_Pow_OUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_get_UPS_Data.SetToolTip(this.textBox_Pow_OUT, "Текущее значение выходной мощности");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_calibr);
            this.groupBox2.Controls.Add(this.checkBox_charge);
            this.groupBox2.Controls.Add(this.checkBox_power_out);
            this.groupBox2.Controls.Add(this.checkBox_power_in);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 45);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статус устройства";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Емкость UPS (mA/h)";
            // 
            // button_get_ups_data
            // 
            this.button_get_ups_data.Enabled = false;
            this.button_get_ups_data.Location = new System.Drawing.Point(316, 11);
            this.button_get_ups_data.Name = "button_get_ups_data";
            this.button_get_ups_data.Size = new System.Drawing.Size(90, 30);
            this.button_get_ups_data.TabIndex = 6;
            this.button_get_ups_data.Text = "Get UPS Data";
            this.toolTip_get_UPS_Data.SetToolTip(this.button_get_ups_data, "Кнопка получения статистики использования UPS");
            this.button_get_ups_data.UseVisualStyleBackColor = true;
            this.button_get_ups_data.Click += new System.EventHandler(this.button_get_ups_data_Click);
            // 
            // textBox_mah
            // 
            this.textBox_mah.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_mah.Location = new System.Drawing.Point(203, 97);
            this.textBox_mah.Name = "textBox_mah";
            this.textBox_mah.ReadOnly = true;
            this.textBox_mah.ShortcutsEnabled = false;
            this.textBox_mah.Size = new System.Drawing.Size(70, 20);
            this.textBox_mah.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textBox_Remaining_time);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBox_battery_time);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox_mah);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox_total_time);
            this.groupBox3.Location = new System.Drawing.Point(3, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 147);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статистика";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Оставшееся время работы (мин)";
            // 
            // textBox_Remaining_time
            // 
            this.textBox_Remaining_time.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Remaining_time.Location = new System.Drawing.Point(203, 71);
            this.textBox_Remaining_time.Name = "textBox_Remaining_time";
            this.textBox_Remaining_time.ReadOnly = true;
            this.textBox_Remaining_time.ShortcutsEnabled = false;
            this.textBox_Remaining_time.Size = new System.Drawing.Size(70, 20);
            this.textBox_Remaining_time.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Время работы от батарей";
            // 
            // textBox_battery_time
            // 
            this.textBox_battery_time.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_battery_time.Location = new System.Drawing.Point(203, 45);
            this.textBox_battery_time.Name = "textBox_battery_time";
            this.textBox_battery_time.ReadOnly = true;
            this.textBox_battery_time.ShortcutsEnabled = false;
            this.textBox_battery_time.Size = new System.Drawing.Size(70, 20);
            this.textBox_battery_time.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Общее время работы ББП";
            // 
            // textBox_total_time
            // 
            this.textBox_total_time.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_total_time.Location = new System.Drawing.Point(203, 19);
            this.textBox_total_time.Name = "textBox_total_time";
            this.textBox_total_time.ReadOnly = true;
            this.textBox_total_time.ShortcutsEnabled = false;
            this.textBox_total_time.Size = new System.Drawing.Size(70, 20);
            this.textBox_total_time.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Температура 1,2";
            // 
            // textBox_Batt_34_temperature
            // 
            this.textBox_Batt_34_temperature.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Batt_34_temperature.Location = new System.Drawing.Point(103, 72);
            this.textBox_Batt_34_temperature.Name = "textBox_Batt_34_temperature";
            this.textBox_Batt_34_temperature.ReadOnly = true;
            this.textBox_Batt_34_temperature.ShortcutsEnabled = false;
            this.textBox_Batt_34_temperature.Size = new System.Drawing.Size(70, 20);
            this.textBox_Batt_34_temperature.TabIndex = 29;
            this.textBox_Batt_34_temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Batt_12_temperature
            // 
            this.textBox_Batt_12_temperature.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Batt_12_temperature.Location = new System.Drawing.Point(103, 20);
            this.textBox_Batt_12_temperature.Multiline = true;
            this.textBox_Batt_12_temperature.Name = "textBox_Batt_12_temperature";
            this.textBox_Batt_12_temperature.ReadOnly = true;
            this.textBox_Batt_12_temperature.ShortcutsEnabled = false;
            this.textBox_Batt_12_temperature.Size = new System.Drawing.Size(70, 20);
            this.textBox_Batt_12_temperature.TabIndex = 28;
            this.textBox_Batt_12_temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_errors
            // 
            this.groupBox_errors.Controls.Add(this.checkBox_TimerGetUPSData_Enable);
            this.groupBox_errors.Controls.Add(this.label_report_id);
            this.groupBox_errors.Controls.Add(this.button_get_ups_data);
            this.groupBox_errors.Controls.Add(this.textBox_error);
            this.groupBox_errors.Location = new System.Drawing.Point(2, 389);
            this.groupBox_errors.Name = "groupBox_errors";
            this.groupBox_errors.Size = new System.Drawing.Size(423, 111);
            this.groupBox_errors.TabIndex = 22;
            this.groupBox_errors.TabStop = false;
            this.groupBox_errors.Text = "Лог сообщения";
            // 
            // label_report_id
            // 
            this.label_report_id.AutoSize = true;
            this.label_report_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_report_id.Location = new System.Drawing.Point(4, 18);
            this.label_report_id.Name = "label_report_id";
            this.label_report_id.Size = new System.Drawing.Size(164, 15);
            this.label_report_id.TabIndex = 33;
            this.label_report_id.Text = "Report ID сообщения - 0 x XX";
            this.toolTip_get_UPS_Data.SetToolTip(this.label_report_id, "Report ID текущего сообщения от ББП");
            // 
            // textBox_error
            // 
            this.textBox_error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_error.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_error.Location = new System.Drawing.Point(4, 44);
            this.textBox_error.Multiline = true;
            this.textBox_error.Name = "textBox_error";
            this.textBox_error.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_error.Size = new System.Drawing.Size(419, 62);
            this.textBox_error.TabIndex = 32;
            this.textBox_error.TabStop = false;
            // 
            // groupBox_USB_device
            // 
            this.groupBox_USB_device.Controls.Add(this.listBox_info);
            this.groupBox_USB_device.Location = new System.Drawing.Point(3, 6);
            this.groupBox_USB_device.Name = "groupBox_USB_device";
            this.groupBox_USB_device.Size = new System.Drawing.Size(409, 155);
            this.groupBox_USB_device.TabIndex = 23;
            this.groupBox_USB_device.TabStop = false;
            this.groupBox_USB_device.Text = "Информация об устройстве";
            // 
            // listBox_info
            // 
            this.listBox_info.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_info.FormattingEnabled = true;
            this.listBox_info.ItemHeight = 17;
            this.listBox_info.Location = new System.Drawing.Point(12, 19);
            this.listBox_info.Name = "listBox_info";
            this.listBox_info.Size = new System.Drawing.Size(382, 106);
            this.listBox_info.TabIndex = 8;
            this.toolTip_get_UPS_Data.SetToolTip(this.listBox_info, "Общая информация о подключённом устройстве");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // checkBox_test_M24C08
            // 
            this.checkBox_test_M24C08.AutoCheck = false;
            this.checkBox_test_M24C08.AutoSize = true;
            this.checkBox_test_M24C08.Cursor = System.Windows.Forms.Cursors.Help;
            this.checkBox_test_M24C08.Location = new System.Drawing.Point(27, 121);
            this.checkBox_test_M24C08.Name = "checkBox_test_M24C08";
            this.checkBox_test_M24C08.Size = new System.Drawing.Size(66, 17);
            this.checkBox_test_M24C08.TabIndex = 2;
            this.checkBox_test_M24C08.Text = "M24C08";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_test_M24C08, "Нажмите правую кнопку мыши для \r\nотображения элемента на плате");
            this.checkBox_test_M24C08.UseVisualStyleBackColor = true;
            this.checkBox_test_M24C08.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkBox_test_M24C08_MouseRightClick);
            // 
            // checkBox_test_INA226
            // 
            this.checkBox_test_INA226.AutoCheck = false;
            this.checkBox_test_INA226.AutoSize = true;
            this.checkBox_test_INA226.Cursor = System.Windows.Forms.Cursors.Help;
            this.checkBox_test_INA226.Location = new System.Drawing.Point(141, 121);
            this.checkBox_test_INA226.Name = "checkBox_test_INA226";
            this.checkBox_test_INA226.Size = new System.Drawing.Size(62, 17);
            this.checkBox_test_INA226.TabIndex = 1;
            this.checkBox_test_INA226.Text = "INA226";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_test_INA226, "Нажмите правую кнопку мыши для \r\nотображения элемента на плате");
            this.checkBox_test_INA226.UseVisualStyleBackColor = true;
            this.checkBox_test_INA226.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkBox_test_INA226_MouseRightClick);
            // 
            // checkBox_test_BQ769003
            // 
            this.checkBox_test_BQ769003.AutoCheck = false;
            this.checkBox_test_BQ769003.AutoSize = true;
            this.checkBox_test_BQ769003.Cursor = System.Windows.Forms.Cursors.Help;
            this.checkBox_test_BQ769003.Location = new System.Drawing.Point(15, 121);
            this.checkBox_test_BQ769003.Name = "checkBox_test_BQ769003";
            this.checkBox_test_BQ769003.Size = new System.Drawing.Size(83, 17);
            this.checkBox_test_BQ769003.TabIndex = 0;
            this.checkBox_test_BQ769003.Text = "BQ7692003";
            this.toolTip_get_UPS_Data.SetToolTip(this.checkBox_test_BQ769003, "Нажмите правую кнопку мыши для \r\nотображения элемента на плате");
            this.checkBox_test_BQ769003.UseVisualStyleBackColor = true;
            this.checkBox_test_BQ769003.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkBox_test_BQ769003_MouseRightClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.textBox_Batt_45_temperature);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.textBox_Batt_23_temperature);
            this.groupBox6.Controls.Add(this.textBox_Batt_12_temperature);
            this.groupBox6.Controls.Add(this.textBox_Batt_34_temperature);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Location = new System.Drawing.Point(216, 182);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 128);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Температуры ячеек, С";
            this.toolTip_get_UPS_Data.SetToolTip(this.groupBox6, "Значение темпеатуры между элементами питания");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Температура 4,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Температура 3,4";
            // 
            // textBox_Batt_45_temperature
            // 
            this.textBox_Batt_45_temperature.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Batt_45_temperature.Location = new System.Drawing.Point(103, 98);
            this.textBox_Batt_45_temperature.Name = "textBox_Batt_45_temperature";
            this.textBox_Batt_45_temperature.ReadOnly = true;
            this.textBox_Batt_45_temperature.ShortcutsEnabled = false;
            this.textBox_Batt_45_temperature.Size = new System.Drawing.Size(70, 20);
            this.textBox_Batt_45_temperature.TabIndex = 33;
            this.textBox_Batt_45_temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Температура 2,3";
            // 
            // textBox_Batt_23_temperature
            // 
            this.textBox_Batt_23_temperature.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Batt_23_temperature.Location = new System.Drawing.Point(103, 46);
            this.textBox_Batt_23_temperature.Name = "textBox_Batt_23_temperature";
            this.textBox_Batt_23_temperature.ReadOnly = true;
            this.textBox_Batt_23_temperature.ShortcutsEnabled = false;
            this.textBox_Batt_23_temperature.Size = new System.Drawing.Size(70, 20);
            this.textBox_Batt_23_temperature.TabIndex = 32;
            this.textBox_Batt_23_temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textProgressBar_SoC
            // 
            this.textProgressBar_SoC.Cursor = System.Windows.Forms.Cursors.Help;
            this.textProgressBar_SoC.CustomText = "";
            this.textProgressBar_SoC.Location = new System.Drawing.Point(126, 16);
            this.textProgressBar_SoC.Name = "textProgressBar_SoC";
            this.textProgressBar_SoC.ProgressColor = System.Drawing.Color.LimeGreen;
            this.textProgressBar_SoC.Size = new System.Drawing.Size(69, 23);
            this.textProgressBar_SoC.TabIndex = 33;
            this.textProgressBar_SoC.TextColor = System.Drawing.Color.Black;
            this.textProgressBar_SoC.TextFont = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolTip_get_UPS_Data.SetToolTip(this.textProgressBar_SoC, "Текущий заряд ББП в процентном эквиваленте");
            this.textProgressBar_SoC.VisualMode = ProgressBarSample.ProgressBarDisplayMode.Percentage;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textProgressBar_SoC);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox_V_IN);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox_Cur_OUT);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox_Pow_OUT);
            this.groupBox4.Location = new System.Drawing.Point(6, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 128);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Общая информация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "W";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "mA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(177, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "mV";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_timer});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(429, 22);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.очиститьToolStripMenuItem,
            this.Write_to_File_ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // Write_to_File_ToolStripMenuItem
            // 
            this.Write_to_File_ToolStripMenuItem.Name = "Write_to_File_ToolStripMenuItem";
            this.Write_to_File_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Write_to_File_ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Write_to_File_ToolStripMenuItem.Text = "Запись в файл";
            this.Write_to_File_ToolStripMenuItem.Click += new System.EventHandler(this.Write_to_File_ToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.USB_UPS_Settings_ToolStripMenuItem,
            this.setSerialNumberToolStripMenuItem,
            this.температурныеДиапазоныToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // USB_UPS_Settings_ToolStripMenuItem
            // 
            this.USB_UPS_Settings_ToolStripMenuItem.Name = "USB_UPS_Settings_ToolStripMenuItem";
            this.USB_UPS_Settings_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.USB_UPS_Settings_ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.USB_UPS_Settings_ToolStripMenuItem.Text = "Параметры USB UPS";
            this.USB_UPS_Settings_ToolStripMenuItem.Click += new System.EventHandler(this.USB_UPS_Settings_ToolStripMenuItem_Click);
            // 
            // setSerialNumberToolStripMenuItem
            // 
            this.setSerialNumberToolStripMenuItem.Name = "setSerialNumberToolStripMenuItem";
            this.setSerialNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.setSerialNumberToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.setSerialNumberToolStripMenuItem.Text = "Set serial number";
            this.setSerialNumberToolStripMenuItem.Click += new System.EventHandler(this.setSerialNumberToolStripMenuItem_Click);
            // 
            // температурныеДиапазоныToolStripMenuItem
            // 
            this.температурныеДиапазоныToolStripMenuItem.Name = "температурныеДиапазоныToolStripMenuItem";
            this.температурныеДиапазоныToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.температурныеДиапазоныToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.температурныеДиапазоныToolStripMenuItem.Text = "Temp limits";
            this.температурныеДиапазоныToolStripMenuItem.Click += new System.EventHandler(this.TempLimitsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErrosTable_toolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ErrosTable_toolStripMenuItem
            // 
            this.ErrosTable_toolStripMenuItem.Name = "ErrosTable_toolStripMenuItem";
            this.ErrosTable_toolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ErrosTable_toolStripMenuItem.Text = "Таблица ошибок";
            this.ErrosTable_toolStripMenuItem.Click += new System.EventHandler(this.ErrosTable_toolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(423, 363);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cостояние ББП";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox_USB_device);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(415, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика ББП";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(415, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Режим отладки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panel1);
            this.groupBox10.Controls.Add(this.panel_Charge_OnOff);
            this.groupBox10.Controls.Add(this.label_buttons_pressings_count);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Location = new System.Drawing.Point(241, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(171, 154);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Отладочные флаги";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel7);
            this.panel1.Location = new System.Drawing.Point(6, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 75);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.99371F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.00629F));
            this.tableLayoutPanel7.Controls.Add(this.textBox_I_batt, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.textBox_V_Out_db, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox_V_In_db, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label34, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label35, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(159, 75);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // textBox_I_batt
            // 
            this.textBox_I_batt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_I_batt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_I_batt.Location = new System.Drawing.Point(64, 53);
            this.textBox_I_batt.Name = "textBox_I_batt";
            this.textBox_I_batt.ReadOnly = true;
            this.textBox_I_batt.ShortcutsEnabled = false;
            this.textBox_I_batt.Size = new System.Drawing.Size(92, 20);
            this.textBox_I_batt.TabIndex = 34;
            this.textBox_I_batt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_V_Out_db
            // 
            this.textBox_V_Out_db.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_V_Out_db.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_V_Out_db.Location = new System.Drawing.Point(64, 28);
            this.textBox_V_Out_db.Name = "textBox_V_Out_db";
            this.textBox_V_Out_db.ReadOnly = true;
            this.textBox_V_Out_db.ShortcutsEnabled = false;
            this.textBox_V_Out_db.Size = new System.Drawing.Size(92, 20);
            this.textBox_V_Out_db.TabIndex = 33;
            this.textBox_V_Out_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_V_In_db
            // 
            this.textBox_V_In_db.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_V_In_db.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_V_In_db.Location = new System.Drawing.Point(64, 3);
            this.textBox_V_In_db.Name = "textBox_V_In_db";
            this.textBox_V_In_db.ReadOnly = true;
            this.textBox_V_In_db.ShortcutsEnabled = false;
            this.textBox_V_In_db.Size = new System.Drawing.Size(92, 20);
            this.textBox_V_In_db.TabIndex = 33;
            this.textBox_V_In_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 25);
            this.label31.TabIndex = 0;
            this.label31.Text = "V In, mV";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Location = new System.Drawing.Point(3, 25);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 25);
            this.label34.TabIndex = 1;
            this.label34.Text = "V Out, mV";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(3, 50);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(55, 25);
            this.label35.TabIndex = 2;
            this.label35.Text = "I Batt, mA";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Charge_OnOff
            // 
            this.panel_Charge_OnOff.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_Charge_OnOff.Controls.Add(this.tableLayoutPanel6);
            this.panel_Charge_OnOff.Location = new System.Drawing.Point(6, 45);
            this.panel_Charge_OnOff.Name = "panel_Charge_OnOff";
            this.panel_Charge_OnOff.Size = new System.Drawing.Size(159, 25);
            this.panel_Charge_OnOff.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.08805F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.91195F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBox_DB_charge_On_Off, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_Debug_Charge_OnOff, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(159, 25);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // checkBox_Debug_Charge_OnOff
            // 
            this.checkBox_Debug_Charge_OnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Debug_Charge_OnOff.AutoCheck = false;
            this.checkBox_Debug_Charge_OnOff.AutoSize = true;
            this.checkBox_Debug_Charge_OnOff.Location = new System.Drawing.Point(3, 3);
            this.checkBox_Debug_Charge_OnOff.Name = "checkBox_Debug_Charge_OnOff";
            this.checkBox_Debug_Charge_OnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_Debug_Charge_OnOff.Size = new System.Drawing.Size(80, 19);
            this.checkBox_Debug_Charge_OnOff.TabIndex = 0;
            this.checkBox_Debug_Charge_OnOff.Text = "Charge ON";
            this.checkBox_Debug_Charge_OnOff.UseVisualStyleBackColor = true;
            // 
            // label_buttons_pressings_count
            // 
            this.label_buttons_pressings_count.AutoSize = true;
            this.label_buttons_pressings_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_buttons_pressings_count.Location = new System.Drawing.Point(123, 17);
            this.label_buttons_pressings_count.Name = "label_buttons_pressings_count";
            this.label_buttons_pressings_count.Size = new System.Drawing.Size(24, 25);
            this.label_buttons_pressings_count.TabIndex = 2;
            this.label_buttons_pressings_count.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 26);
            this.label30.TabIndex = 1;
            this.label30.Text = "Число нажатий \r\nна кнопку:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel1);
            this.groupBox9.Controls.Add(this.checkBox_test_BQ769003);
            this.groupBox9.Controls.Add(this.panel_BQ769);
            this.groupBox9.Location = new System.Drawing.Point(3, 156);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(409, 177);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Этап 2 - Проверка зарядного устройства";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(112, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 152);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(148, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.4031F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5969F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(139, 146);
            this.tableLayoutPanel4.TabIndex = 34;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Location = new System.Drawing.Point(3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 18);
            this.label33.TabIndex = 34;
            this.label33.Text = "Температура, C";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.08271F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.91729F));
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBox_test_temp_sens_1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox_test_temp_sens_2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox_test_temp_sens_3, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox_test_temp_sens_4, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(133, 122);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 32);
            this.label20.TabIndex = 36;
            this.label20.Text = "Д.т. 4";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_temp_sens_1
            // 
            this.textBox_test_temp_sens_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_temp_sens_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_test_temp_sens_1.Location = new System.Drawing.Point(47, 3);
            this.textBox_test_temp_sens_1.Multiline = true;
            this.textBox_test_temp_sens_1.Name = "textBox_test_temp_sens_1";
            this.textBox_test_temp_sens_1.ReadOnly = true;
            this.textBox_test_temp_sens_1.ShortcutsEnabled = false;
            this.textBox_test_temp_sens_1.Size = new System.Drawing.Size(83, 24);
            this.textBox_test_temp_sens_1.TabIndex = 29;
            this.textBox_test_temp_sens_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 30);
            this.label17.TabIndex = 35;
            this.label17.Text = "Д.т. 3";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_temp_sens_2
            // 
            this.textBox_test_temp_sens_2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_temp_sens_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_test_temp_sens_2.Location = new System.Drawing.Point(47, 33);
            this.textBox_test_temp_sens_2.Multiline = true;
            this.textBox_test_temp_sens_2.Name = "textBox_test_temp_sens_2";
            this.textBox_test_temp_sens_2.ReadOnly = true;
            this.textBox_test_temp_sens_2.ShortcutsEnabled = false;
            this.textBox_test_temp_sens_2.Size = new System.Drawing.Size(83, 24);
            this.textBox_test_temp_sens_2.TabIndex = 30;
            this.textBox_test_temp_sens_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Д.т. 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_temp_sens_3
            // 
            this.textBox_test_temp_sens_3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_temp_sens_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_test_temp_sens_3.Location = new System.Drawing.Point(47, 63);
            this.textBox_test_temp_sens_3.Multiline = true;
            this.textBox_test_temp_sens_3.Name = "textBox_test_temp_sens_3";
            this.textBox_test_temp_sens_3.ReadOnly = true;
            this.textBox_test_temp_sens_3.ShortcutsEnabled = false;
            this.textBox_test_temp_sens_3.Size = new System.Drawing.Size(83, 24);
            this.textBox_test_temp_sens_3.TabIndex = 31;
            this.textBox_test_temp_sens_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Д.т. 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_temp_sens_4
            // 
            this.textBox_test_temp_sens_4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_temp_sens_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_test_temp_sens_4.Location = new System.Drawing.Point(47, 93);
            this.textBox_test_temp_sens_4.Multiline = true;
            this.textBox_test_temp_sens_4.Name = "textBox_test_temp_sens_4";
            this.textBox_test_temp_sens_4.ReadOnly = true;
            this.textBox_test_temp_sens_4.ShortcutsEnabled = false;
            this.textBox_test_temp_sens_4.Size = new System.Drawing.Size(83, 26);
            this.textBox_test_temp_sens_4.TabIndex = 32;
            this.textBox_test_temp_sens_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label32, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.4031F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5969F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(139, 146);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Location = new System.Drawing.Point(3, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(133, 18);
            this.label32.TabIndex = 34;
            this.label32.Text = "Напряжение ячеек, mV";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.84962F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.15038F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_test_Voltage_Sens_1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_test_Voltage_Sens_5, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_test_Voltage_Sens_2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_test_Voltage_Sens_4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label25, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox_test_Voltage_Sens_3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label28, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 122);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_test_Voltage_Sens_1
            // 
            this.textBox_test_Voltage_Sens_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_test_Voltage_Sens_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_Voltage_Sens_1.Location = new System.Drawing.Point(55, 3);
            this.textBox_test_Voltage_Sens_1.Name = "textBox_test_Voltage_Sens_1";
            this.textBox_test_Voltage_Sens_1.ReadOnly = true;
            this.textBox_test_Voltage_Sens_1.ShortcutsEnabled = false;
            this.textBox_test_Voltage_Sens_1.Size = new System.Drawing.Size(75, 20);
            this.textBox_test_Voltage_Sens_1.TabIndex = 31;
            this.textBox_test_Voltage_Sens_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_test_Voltage_Sens_5
            // 
            this.textBox_test_Voltage_Sens_5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_Voltage_Sens_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_test_Voltage_Sens_5.Location = new System.Drawing.Point(55, 100);
            this.textBox_test_Voltage_Sens_5.Name = "textBox_test_Voltage_Sens_5";
            this.textBox_test_Voltage_Sens_5.ReadOnly = true;
            this.textBox_test_Voltage_Sens_5.ShortcutsEnabled = false;
            this.textBox_test_Voltage_Sens_5.Size = new System.Drawing.Size(75, 20);
            this.textBox_test_Voltage_Sens_5.TabIndex = 39;
            this.textBox_test_Voltage_Sens_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(3, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 25);
            this.label24.TabIndex = 40;
            this.label24.Text = "Cell 5";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 24);
            this.label26.TabIndex = 35;
            this.label26.Text = "Cell 1";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_Voltage_Sens_2
            // 
            this.textBox_test_Voltage_Sens_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_test_Voltage_Sens_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_test_Voltage_Sens_2.Location = new System.Drawing.Point(55, 27);
            this.textBox_test_Voltage_Sens_2.Name = "textBox_test_Voltage_Sens_2";
            this.textBox_test_Voltage_Sens_2.ReadOnly = true;
            this.textBox_test_Voltage_Sens_2.ShortcutsEnabled = false;
            this.textBox_test_Voltage_Sens_2.Size = new System.Drawing.Size(75, 20);
            this.textBox_test_Voltage_Sens_2.TabIndex = 32;
            this.textBox_test_Voltage_Sens_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(3, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 24);
            this.label29.TabIndex = 36;
            this.label29.Text = "Cell 2";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_Voltage_Sens_4
            // 
            this.textBox_test_Voltage_Sens_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_test_Voltage_Sens_4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_test_Voltage_Sens_4.Location = new System.Drawing.Point(55, 76);
            this.textBox_test_Voltage_Sens_4.Name = "textBox_test_Voltage_Sens_4";
            this.textBox_test_Voltage_Sens_4.ReadOnly = true;
            this.textBox_test_Voltage_Sens_4.ShortcutsEnabled = false;
            this.textBox_test_Voltage_Sens_4.Size = new System.Drawing.Size(75, 20);
            this.textBox_test_Voltage_Sens_4.TabIndex = 34;
            this.textBox_test_Voltage_Sens_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(3, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 24);
            this.label25.TabIndex = 38;
            this.label25.Text = "Cell 4";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_test_Voltage_Sens_3
            // 
            this.textBox_test_Voltage_Sens_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_test_Voltage_Sens_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_test_Voltage_Sens_3.Location = new System.Drawing.Point(55, 51);
            this.textBox_test_Voltage_Sens_3.Name = "textBox_test_Voltage_Sens_3";
            this.textBox_test_Voltage_Sens_3.ReadOnly = true;
            this.textBox_test_Voltage_Sens_3.ShortcutsEnabled = false;
            this.textBox_test_Voltage_Sens_3.Size = new System.Drawing.Size(75, 20);
            this.textBox_test_Voltage_Sens_3.TabIndex = 33;
            this.textBox_test_Voltage_Sens_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(3, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 25);
            this.label28.TabIndex = 37;
            this.label28.Text = "Cell 3";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_BQ769
            // 
            this.panel_BQ769.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_BQ769.Controls.Add(this.pictureBox2);
            this.panel_BQ769.Location = new System.Drawing.Point(6, 19);
            this.panel_BQ769.Name = "panel_BQ769";
            this.panel_BQ769.Size = new System.Drawing.Size(100, 100);
            this.panel_BQ769.TabIndex = 41;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel_INA226);
            this.groupBox7.Controls.Add(this.panel_M24C08);
            this.groupBox7.Controls.Add(this.checkBox_test_M24C08);
            this.groupBox7.Controls.Add(this.checkBox_test_INA226);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox7.Location = new System.Drawing.Point(6, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(230, 154);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Этап 1 - Проверка микросхем";
            // 
            // panel_INA226
            // 
            this.panel_INA226.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_INA226.Controls.Add(this.pictureBox1);
            this.panel_INA226.Location = new System.Drawing.Point(121, 19);
            this.panel_INA226.Name = "panel_INA226";
            this.panel_INA226.Size = new System.Drawing.Size(100, 100);
            this.panel_INA226.TabIndex = 6;
            // 
            // panel_M24C08
            // 
            this.panel_M24C08.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_M24C08.Controls.Add(this.pictureBox_chip_image);
            this.panel_M24C08.Location = new System.Drawing.Point(9, 19);
            this.panel_M24C08.Name = "panel_M24C08";
            this.panel_M24C08.Size = new System.Drawing.Size(100, 100);
            this.panel_M24C08.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "operat_info_icon.png");
            this.imageList1.Images.SetKeyName(1, "statistic_icon.png");
            this.imageList1.Images.SetKeyName(2, "otladka_icon.png");
            // 
            // pictureBox_DB_charge_On_Off
            // 
            this.pictureBox_DB_charge_On_Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox_DB_charge_On_Off.Image = global::ServiceMiniUPS.Properties.Resources.Charge_Off;
            this.pictureBox_DB_charge_On_Off.Location = new System.Drawing.Point(107, 3);
            this.pictureBox_DB_charge_On_Off.Name = "pictureBox_DB_charge_On_Off";
            this.pictureBox_DB_charge_On_Off.Size = new System.Drawing.Size(30, 19);
            this.pictureBox_DB_charge_On_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_DB_charge_On_Off.TabIndex = 1;
            this.pictureBox_DB_charge_On_Off.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::ServiceMiniUPS.Properties.Resources.BQ;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ServiceMiniUPS.Properties.Resources.INA226;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // pictureBox_chip_image
            // 
            this.pictureBox_chip_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_chip_image.Image = global::ServiceMiniUPS.Properties.Resources.M24C08;
            this.pictureBox_chip_image.Location = new System.Drawing.Point(5, 5);
            this.pictureBox_chip_image.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_chip_image.Name = "pictureBox_chip_image";
            this.pictureBox_chip_image.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_chip_image.TabIndex = 4;
            this.pictureBox_chip_image.TabStop = false;
            this.pictureBox_chip_image.WaitOnLoad = true;
            // 
            // toolStripStatusLabel_timer
            // 
            this.toolStripStatusLabel_timer.Image = global::ServiceMiniUPS.Properties.Resources.Timer35x35;
            this.toolStripStatusLabel_timer.Name = "toolStripStatusLabel_timer";
            this.toolStripStatusLabel_timer.Size = new System.Drawing.Size(16, 16);
            // 
            // checkBox_TimerGetUPSData_Enable
            // 
            this.checkBox_TimerGetUPSData_Enable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox_TimerGetUPSData_Enable.Image = global::ServiceMiniUPS.Properties.Resources.Timer25x25;
            this.checkBox_TimerGetUPSData_Enable.Location = new System.Drawing.Point(274, 9);
            this.checkBox_TimerGetUPSData_Enable.Name = "checkBox_TimerGetUPSData_Enable";
            this.checkBox_TimerGetUPSData_Enable.Size = new System.Drawing.Size(42, 35);
            this.checkBox_TimerGetUPSData_Enable.TabIndex = 5;
            this.checkBox_TimerGetUPSData_Enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_Timer.SetToolTip(this.checkBox_TimerGetUPSData_Enable, "Активирует чтение данных с интервалом 1с.");
            this.checkBox_TimerGetUPSData_Enable.UseVisualStyleBackColor = true;
            this.checkBox_TimerGetUPSData_Enable.CheckedChanged += new System.EventHandler(this.button_get_ups_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(429, 521);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_errors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceMiniUPS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_errors.ResumeLayout(false);
            this.groupBox_errors.PerformLayout();
            this.groupBox_USB_device.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel_Charge_OnOff.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel_BQ769.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel_INA226.ResumeLayout(false);
            this.panel_M24C08.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DB_charge_On_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chip_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_calibr;
        private System.Windows.Forms.CheckBox checkBox_V_cell_ball_4;
        private System.Windows.Forms.CheckBox checkBox_charge;
        private System.Windows.Forms.CheckBox checkBox_V_cell_ball_3;
        private System.Windows.Forms.CheckBox checkBox_power_out;
        private System.Windows.Forms.CheckBox checkBox_V_cell_ball_2;
        private System.Windows.Forms.CheckBox checkBox_power_in;
        private System.Windows.Forms.CheckBox checkBox_V_cell_ball_1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_V_IN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Cur_OUT;
        private System.Windows.Forms.TextBox textBox_V_cell_4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_V_cell_3;
        private System.Windows.Forms.TextBox textBox_Pow_OUT;
        private System.Windows.Forms.TextBox textBox_V_cell_2;
        private System.Windows.Forms.TextBox textBox_V_cell_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_get_ups_data;
        private System.Windows.Forms.TextBox textBox_mah;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_battery_time;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_total_time;
        private System.Windows.Forms.GroupBox groupBox_errors;
        private System.Windows.Forms.GroupBox groupBox_USB_device;
        private System.Windows.Forms.ListBox listBox_info;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip_get_UPS_Data;
        private System.Windows.Forms.ToolTip toolTip_textBox_VID;
        private System.Windows.Forms.ToolTip toolTiptextBox_PID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolTip toolTip_Timer;
        private System.Windows.Forms.CheckBox checkBox_TimerGetUPSData_Enable;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_Batt_34_temperature;
        private System.Windows.Forms.TextBox textBox_Batt_12_temperature;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_Remaining_time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Write_to_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem USB_UPS_Settings_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_V_cell_5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_V_cell_ball_5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Batt_23_temperature;
        private System.Windows.Forms.TextBox textBox_Batt_45_temperature;
        //private ProgressBarSample.TextProgressBar textProgressBar_SoC;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem setSerialNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_timer;
        private System.Windows.Forms.ToolStripMenuItem температурныеДиапазоныToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox_test_M24C08;
        private System.Windows.Forms.CheckBox checkBox_test_INA226;
        private System.Windows.Forms.CheckBox checkBox_test_BQ769003;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_test_temp_sens_4;
        private System.Windows.Forms.TextBox textBox_test_temp_sens_3;
        private System.Windows.Forms.TextBox textBox_test_temp_sens_2;
        private System.Windows.Forms.TextBox textBox_test_temp_sens_1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_test_Voltage_Sens_5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_test_Voltage_Sens_1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox_test_Voltage_Sens_2;
        private System.Windows.Forms.TextBox textBox_test_Voltage_Sens_4;
        private System.Windows.Forms.TextBox textBox_test_Voltage_Sens_3;
        private System.Windows.Forms.TextBox textBox_error;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_report_id;
        private ProgressBarSample.TextProgressBar textProgressBar_SoC;
        private System.Windows.Forms.ToolStripMenuItem ErrosTable_toolStripMenuItem;
        private System.Windows.Forms.Panel panel_M24C08;
        private System.Windows.Forms.PictureBox pictureBox_chip_image;
        private System.Windows.Forms.Panel panel_INA226;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label_buttons_pressings_count;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox_Debug_Charge_OnOff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel_BQ769;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel_Charge_OnOff;
        private System.Windows.Forms.PictureBox pictureBox_DB_charge_On_Off;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox textBox_I_batt;
        private System.Windows.Forms.TextBox textBox_V_Out_db;
        private System.Windows.Forms.TextBox textBox_V_In_db;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

