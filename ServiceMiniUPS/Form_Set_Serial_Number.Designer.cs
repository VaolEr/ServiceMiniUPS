namespace ServiceMiniUPS
{
    partial class Form_Set_Serial_Number
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_set_serial_number = new System.Windows.Forms.Button();
            this.textBox_SN_num = new System.Windows.Forms.TextBox();
            this.textBox_SN_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_sending_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_set_serial_number
            // 
            this.button_set_serial_number.Enabled = false;
            this.button_set_serial_number.Font = new System.Drawing.Font("GOST type B", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_set_serial_number.Location = new System.Drawing.Point(119, 114);
            this.button_set_serial_number.Name = "button_set_serial_number";
            this.button_set_serial_number.Size = new System.Drawing.Size(118, 31);
            this.button_set_serial_number.TabIndex = 0;
            this.button_set_serial_number.Text = "Обновить номер";
            this.button_set_serial_number.UseVisualStyleBackColor = true;
            this.button_set_serial_number.Click += new System.EventHandler(this.button_set_serial_number_Click);
            // 
            // textBox_SN_num
            // 
            this.textBox_SN_num.Font = new System.Drawing.Font("ISOCPEUR", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SN_num.Location = new System.Drawing.Point(147, 72);
            this.textBox_SN_num.MaxLength = 5;
            this.textBox_SN_num.Name = "textBox_SN_num";
            this.textBox_SN_num.Size = new System.Drawing.Size(90, 23);
            this.textBox_SN_num.TabIndex = 2;
            this.textBox_SN_num.TabStop = false;
            this.textBox_SN_num.Text = "Номер изделия";
            this.textBox_SN_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_SN_num, "Формат номера - 5 цифр!");
            this.textBox_SN_num.TextChanged += new System.EventHandler(this.textBox_SN_num_TextChanged);
            this.textBox_SN_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SN_num_KeyPress);
            this.textBox_SN_num.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_SN_num_MouseDown);
            // 
            // textBox_SN_date
            // 
            this.textBox_SN_date.Font = new System.Drawing.Font("ISOCPEUR", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SN_date.Location = new System.Drawing.Point(12, 72);
            this.textBox_SN_date.Name = "textBox_SN_date";
            this.textBox_SN_date.Size = new System.Drawing.Size(90, 23);
            this.textBox_SN_date.TabIndex = 3;
            this.textBox_SN_date.TabStop = false;
            this.textBox_SN_date.Text = "XXXX";
            this.textBox_SN_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ISOCPEUR", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Font = new System.Drawing.Font("GOST type B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SN.Location = new System.Drawing.Point(12, 25);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.ReadOnly = true;
            this.textBox_SN.Size = new System.Drawing.Size(225, 22);
            this.textBox_SN.TabIndex = 5;
            this.textBox_SN.TabStop = false;
            this.textBox_SN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_sending_error
            // 
            this.label_sending_error.AutoSize = true;
            this.label_sending_error.Font = new System.Drawing.Font("GOST type B", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sending_error.Location = new System.Drawing.Point(82, 98);
            this.label_sending_error.Name = "label_sending_error";
            this.label_sending_error.Size = new System.Drawing.Size(151, 13);
            this.label_sending_error.TabIndex = 6;
            this.label_sending_error.Text = "Формат номера корректен!";
            this.label_sending_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текущий серийный номер изделия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Новый серийный номер";
            // 
            // Form_Set_Serial_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 152);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_sending_error);
            this.Controls.Add(this.textBox_SN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SN_date);
            this.Controls.Add(this.textBox_SN_num);
            this.Controls.Add(this.button_set_serial_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Set_Serial_Number";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device serial number ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingOpacity);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_set_serial_number;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_SN;
        public System.Windows.Forms.TextBox textBox_SN_num;
        public System.Windows.Forms.TextBox textBox_SN_date;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_sending_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}