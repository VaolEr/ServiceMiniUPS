namespace ServiceMiniUPS
{
    partial class Set_Temp_Limits_form
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
            this.button_accept_temps = new System.Windows.Forms.Button();
            this.textBox_temp_low_limit = new System.Windows.Forms.TextBox();
            this.textBox_temp_mid_limit = new System.Windows.Forms.TextBox();
            this.textBox_temp_high_limit = new System.Windows.Forms.TextBox();
            this.label_temp_low_limit = new System.Windows.Forms.Label();
            this.label_temp_mid_limit = new System.Windows.Forms.Label();
            this.label_temp_high_limit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_accept_temps
            // 
            this.button_accept_temps.Location = new System.Drawing.Point(167, 87);
            this.button_accept_temps.Name = "button_accept_temps";
            this.button_accept_temps.Size = new System.Drawing.Size(75, 23);
            this.button_accept_temps.TabIndex = 0;
            this.button_accept_temps.Text = "Accept";
            this.button_accept_temps.UseVisualStyleBackColor = true;
            this.button_accept_temps.Click += new System.EventHandler(this.button_accept_temps_Click);
            // 
            // textBox_temp_low_limit
            // 
            this.textBox_temp_low_limit.Location = new System.Drawing.Point(21, 50);
            this.textBox_temp_low_limit.Name = "textBox_temp_low_limit";
            this.textBox_temp_low_limit.Size = new System.Drawing.Size(50, 20);
            this.textBox_temp_low_limit.TabIndex = 1;
            this.textBox_temp_low_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_temp_mid_limit
            // 
            this.textBox_temp_mid_limit.BackColor = System.Drawing.Color.Yellow;
            this.textBox_temp_mid_limit.Location = new System.Drawing.Point(102, 50);
            this.textBox_temp_mid_limit.Name = "textBox_temp_mid_limit";
            this.textBox_temp_mid_limit.Size = new System.Drawing.Size(50, 20);
            this.textBox_temp_mid_limit.TabIndex = 2;
            this.textBox_temp_mid_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_temp_high_limit
            // 
            this.textBox_temp_high_limit.BackColor = System.Drawing.Color.Red;
            this.textBox_temp_high_limit.Location = new System.Drawing.Point(192, 50);
            this.textBox_temp_high_limit.Name = "textBox_temp_high_limit";
            this.textBox_temp_high_limit.Size = new System.Drawing.Size(50, 20);
            this.textBox_temp_high_limit.TabIndex = 3;
            this.textBox_temp_high_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_temp_low_limit
            // 
            this.label_temp_low_limit.AutoSize = true;
            this.label_temp_low_limit.Location = new System.Drawing.Point(27, 22);
            this.label_temp_low_limit.Name = "label_temp_low_limit";
            this.label_temp_low_limit.Size = new System.Drawing.Size(35, 13);
            this.label_temp_low_limit.TabIndex = 4;
            this.label_temp_low_limit.Text = "label1";
            // 
            // label_temp_mid_limit
            // 
            this.label_temp_mid_limit.AutoSize = true;
            this.label_temp_mid_limit.Location = new System.Drawing.Point(108, 22);
            this.label_temp_mid_limit.Name = "label_temp_mid_limit";
            this.label_temp_mid_limit.Size = new System.Drawing.Size(35, 13);
            this.label_temp_mid_limit.TabIndex = 5;
            this.label_temp_mid_limit.Text = "label2";
            // 
            // label_temp_high_limit
            // 
            this.label_temp_high_limit.AutoSize = true;
            this.label_temp_high_limit.Location = new System.Drawing.Point(198, 22);
            this.label_temp_high_limit.Name = "label_temp_high_limit";
            this.label_temp_high_limit.Size = new System.Drawing.Size(35, 13);
            this.label_temp_high_limit.TabIndex = 6;
            this.label_temp_high_limit.Text = "label3";
            // 
            // Set_Temp_Limits_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 122);
            this.Controls.Add(this.label_temp_high_limit);
            this.Controls.Add(this.label_temp_mid_limit);
            this.Controls.Add(this.label_temp_low_limit);
            this.Controls.Add(this.textBox_temp_high_limit);
            this.Controls.Add(this.textBox_temp_mid_limit);
            this.Controls.Add(this.textBox_temp_low_limit);
            this.Controls.Add(this.button_accept_temps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Set_Temp_Limits_form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp Limits Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_accept_temps;
        private System.Windows.Forms.TextBox textBox_temp_low_limit;
        private System.Windows.Forms.TextBox textBox_temp_mid_limit;
        private System.Windows.Forms.TextBox textBox_temp_high_limit;
        private System.Windows.Forms.Label label_temp_low_limit;
        private System.Windows.Forms.Label label_temp_mid_limit;
        private System.Windows.Forms.Label label_temp_high_limit;
    }
}