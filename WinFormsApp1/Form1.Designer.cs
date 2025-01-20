

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AutoScaleMode AutoScaleMode { get; private set; }
        public Size ClientSize { get; private set; }
        public string Text { get; private set; }

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
            this.groupBoxCountryInfo = new GroupBox();
            this.dataGridViewCountryInfo = new DataGridView();
            this.groupBoxCountryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewCountryInfo).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCountryInfo
            // 
            this.groupBoxCountryInfo.Controls.Add(this.dataGridViewCountryInfo);
            this.groupBoxCountryInfo.Location = new Point(12, 12);
            this.groupBoxCountryInfo.Name = "groupBoxCountryInfo";
            this.groupBoxCountryInfo.Size = new Size(760, 337);
            this.groupBoxCountryInfo.TabIndex = 0;
            this.groupBoxCountryInfo.TabStop = false;
            this.groupBoxCountryInfo.Text = "Информация о стране";
            // 
            // dataGridViewCountryInfo
            // 
            this.dataGridViewCountryInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountryInfo.Dock = DockStyle.Fill;
            this.dataGridViewCountryInfo.Location = new Point(3, 19);
            this.dataGridViewCountryInfo.Name = "dataGridViewCountryInfo";
            this.dataGridViewCountryInfo.Size = new Size(754, 315);
            this.dataGridViewCountryInfo.TabIndex = 0;
            this.dataGridViewCountryInfo.CellContentClick += this.dataGridViewCountryInfo_CellContentClick;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            this.Controls.Add(this.groupBoxCountryInfo);
            this.Name = "Form1";
            Text = "Информация о странах";
            this.Load += this.Form1_Load;
            this.groupBoxCountryInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewCountryInfo).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}