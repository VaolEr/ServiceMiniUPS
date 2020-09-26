namespace ServiceMiniUPS
{
    partial class Form_With_Help_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_With_Help_Image));
            this.pictureBox_elements_placement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_elements_placement)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_elements_placement
            // 
            this.pictureBox_elements_placement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_elements_placement.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_elements_placement.Name = "pictureBox_elements_placement";
            this.pictureBox_elements_placement.Size = new System.Drawing.Size(539, 430);
            this.pictureBox_elements_placement.TabIndex = 0;
            this.pictureBox_elements_placement.TabStop = false;
            this.pictureBox_elements_placement.WaitOnLoad = true;
            // 
            // Form_With_Help_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(540, 431);
            this.Controls.Add(this.pictureBox_elements_placement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_With_Help_Image";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_With_Help_Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_elements_placement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_elements_placement;
    }
}