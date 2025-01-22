using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    partial class FormСountry
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Очистка ресурсов
            }
            base.Dispose(disposing); // Вызываем базовый метод Dispose
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewStat_EAA = new DataGridView();
            openFileDialogStat_EAA = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStat_EAA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStat_EAA
            // 
            dataGridViewStat_EAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStat_EAA.Location = new Point(-1, 0);
            dataGridViewStat_EAA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewStat_EAA.Name = "dataGridViewStat_EAA";
            dataGridViewStat_EAA.RowHeadersVisible = false;
            dataGridViewStat_EAA.Size = new Size(594, 520);
            dataGridViewStat_EAA.TabIndex = 2;
            // 
            // openFileDialogStat_EAA
            // 
            openFileDialogStat_EAA.FileName = "openFileDialog1";
            // 
            // FormСountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(595, 519);
            Controls.Add(dataGridViewStat_EAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormСountry";
            Text = "Страны";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStat_EAA).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStat_EAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogStat_EAA;
    }
}