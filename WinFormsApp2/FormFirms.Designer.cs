namespace WinFormsApp2
{
    partial class FormFirms
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
            dataGridViewFirms_KIG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirms_KIG).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFirms_KIG
            // 
            dataGridViewFirms_KIG.BackgroundColor = SystemColors.Control;
            dataGridViewFirms_KIG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFirms_KIG.Location = new Point(14, 14);
            dataGridViewFirms_KIG.Margin = new Padding(4, 3, 4, 3);
            dataGridViewFirms_KIG.Name = "dataGridViewFirms_KIG";
            dataGridViewFirms_KIG.Size = new Size(710, 398);
            dataGridViewFirms_KIG.TabIndex = 0;
           
            // 
            // FormFirms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 426);
            Controls.Add(dataGridViewFirms_KIG);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormFirms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Существующие фирмы";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirms_KIG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFirms_KIG;
    }
}