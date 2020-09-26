namespace ServiceMiniUPS
{
    partial class USB_divice_settings_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USB_divice_settings_form));
            this.textBox_VID = new System.Windows.Forms.TextBox();
            this.textBox_PID = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_PID = new System.Windows.Forms.Label();
            this.label_VID = new System.Windows.Forms.Label();
            this.label_description_state = new System.Windows.Forms.Label();
            this.label_USBstate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_VID
            // 
            this.textBox_VID.Location = new System.Drawing.Point(43, 23);
            this.textBox_VID.Name = "textBox_VID";
            this.textBox_VID.Size = new System.Drawing.Size(55, 20);
            this.textBox_VID.TabIndex = 0;
            this.textBox_VID.Text = "F056";
            // 
            // textBox_PID
            // 
            this.textBox_PID.Location = new System.Drawing.Point(164, 23);
            this.textBox_PID.Name = "textBox_PID";
            this.textBox_PID.Size = new System.Drawing.Size(55, 20);
            this.textBox_PID.TabIndex = 1;
            this.textBox_PID.Text = "0023";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(83, 51);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 2;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_conect_Click);
            // 
            // label_PID
            // 
            this.label_PID.AutoSize = true;
            this.label_PID.Location = new System.Drawing.Point(133, 26);
            this.label_PID.Name = "label_PID";
            this.label_PID.Size = new System.Drawing.Size(25, 13);
            this.label_PID.TabIndex = 6;
            this.label_PID.Text = "PID";
            // 
            // label_VID
            // 
            this.label_VID.AutoSize = true;
            this.label_VID.Location = new System.Drawing.Point(12, 26);
            this.label_VID.Name = "label_VID";
            this.label_VID.Size = new System.Drawing.Size(25, 13);
            this.label_VID.TabIndex = 7;
            this.label_VID.Text = "VID";
            // 
            // label_description_state
            // 
            this.label_description_state.AutoSize = true;
            this.label_description_state.Location = new System.Drawing.Point(12, 77);
            this.label_description_state.Name = "label_description_state";
            this.label_description_state.Size = new System.Drawing.Size(124, 13);
            this.label_description_state.TabIndex = 1;
            this.label_description_state.Text = "Состояние устройства:";
            // 
            // label_USBstate
            // 
            this.label_USBstate.AutoSize = true;
            this.label_USBstate.Location = new System.Drawing.Point(133, 77);
            this.label_USBstate.Name = "label_USBstate";
            this.label_USBstate.Size = new System.Drawing.Size(86, 13);
            this.label_USBstate.TabIndex = 2;
            this.label_USBstate.Text = "НЕ подключено";
            // 
            // USB_divice_settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 100);
            this.Controls.Add(this.label_VID);
            this.Controls.Add(this.label_PID);
            this.Controls.Add(this.textBox_PID);
            this.Controls.Add(this.textBox_VID);
            this.Controls.Add(this.label_description_state);
            this.Controls.Add(this.label_USBstate);
            this.Controls.Add(this.button_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "USB_divice_settings_form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device VID/PID settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_VID;
        private System.Windows.Forms.TextBox textBox_PID;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_PID;
        private System.Windows.Forms.Label label_VID;
        private System.Windows.Forms.Label label_description_state;
        public System.Windows.Forms.Label label_USBstate;
    }
}