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
            components = new System.ComponentModel.Container();
            groupBoxSearch_EAA = new GroupBox();
            dataGridViewStat_EAA = new DataGridView();
            openFileDialogStat_EAA = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            поискToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStat_EAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxSearch_EAA
            // 
            groupBoxSearch_EAA.Location = new Point(13, 40);
            groupBoxSearch_EAA.Margin = new Padding(4, 3, 4, 3);
            groupBoxSearch_EAA.Name = "groupBoxSearch_EAA";
            groupBoxSearch_EAA.Padding = new Padding(4, 3, 4, 3);
            groupBoxSearch_EAA.Size = new Size(233, 59);
            groupBoxSearch_EAA.TabIndex = 4;
            groupBoxSearch_EAA.TabStop = false;
            // 
            // dataGridViewStat_EAA
            // 
            dataGridViewStat_EAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStat_EAA.Location = new Point(0, 2);
            dataGridViewStat_EAA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewStat_EAA.Name = "dataGridViewStat_EAA";
            dataGridViewStat_EAA.RowHeadersVisible = false;
            dataGridViewStat_EAA.Size = new Size(595, 290);
            dataGridViewStat_EAA.TabIndex = 2;
            dataGridViewStat_EAA.CellContentClick += dataGridViewStat_EAA_CellContentClick;
            // 
            // openFileDialogStat_EAA
            // 
            openFileDialogStat_EAA.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(32, 19);
            // 
            // FormСountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(595, 293);
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
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSearch_EAA;
    }
}