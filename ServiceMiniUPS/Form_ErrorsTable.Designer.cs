namespace ServiceMiniUPS
{
    partial class Form_ErrorsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ErrorsTable));
            this.dataGrid_ErrorTable = new System.Windows.Forms.DataGridView();
            this.Column_Error_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Error_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ErrorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_ErrorTable
            // 
            this.dataGrid_ErrorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ErrorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Error_Code,
            this.Column_Error_Description});
            this.dataGrid_ErrorTable.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_ErrorTable.Name = "dataGrid_ErrorTable";
            this.dataGrid_ErrorTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ErrorTable.Size = new System.Drawing.Size(443, 416);
            this.dataGrid_ErrorTable.TabIndex = 0;
            // 
            // Column_Error_Code
            // 
            this.Column_Error_Code.Frozen = true;
            this.Column_Error_Code.HeaderText = "Код ошибки";
            this.Column_Error_Code.Name = "Column_Error_Code";
            this.Column_Error_Code.ReadOnly = true;
            this.Column_Error_Code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Error_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Error_Code.Width = 50;
            // 
            // Column_Error_Description
            // 
            this.Column_Error_Description.HeaderText = "Описание ошибки";
            this.Column_Error_Description.Name = "Column_Error_Description";
            this.Column_Error_Description.ReadOnly = true;
            this.Column_Error_Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Error_Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Error_Description.Width = 347;
            // 
            // Form_ErrorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 440);
            this.Controls.Add(this.dataGrid_ErrorTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ErrorsTable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица ошибок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ErrorsTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ErrorTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_ErrorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Error_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Error_Description;
    }
}
