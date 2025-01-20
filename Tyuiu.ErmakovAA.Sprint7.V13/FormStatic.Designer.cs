using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ErmakovAA.Sprint7.V13;


namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    partial class FormStatic
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            panelLeft_EAA = new Panel();
            buttonDiag_EAA = new Button();
            buttonMaxYadra_EAA = new Button();
            buttonSredOZU_EAA = new Button();
            chartstat_EAA = new Chart();
            dataGridViewStat_EAA = new DataGridView();
            textBoxSredOZU_EAA = new TextBox();
            textBoxMaxYadra_EAA = new TextBox();
            openFileDialogStat_EAA = new OpenFileDialog();
            panelLeft_EAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartstat_EAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStat_EAA).BeginInit();
            SuspendLayout();
            // 
            // panelLeft_EAA
            // 
            panelLeft_EAA.Controls.Add(buttonDiag_EAA);
            panelLeft_EAA.Controls.Add(buttonMaxYadra_EAA);
            panelLeft_EAA.Controls.Add(buttonSredOZU_EAA);
            panelLeft_EAA.Dock = DockStyle.Bottom;
            panelLeft_EAA.Location = new Point(0, 442);
            panelLeft_EAA.Margin = new Padding(4, 3, 4, 3);
            panelLeft_EAA.Name = "panelLeft_EAA";
            panelLeft_EAA.Size = new Size(632, 77);
            panelLeft_EAA.TabIndex = 0;
            // 
            // buttonDiag_EAA
            // 
            buttonDiag_EAA.BackColor = Color.Gray;
            buttonDiag_EAA.Location = new Point(14, 15);
            buttonDiag_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonDiag_EAA.Name = "buttonDiag_EAA";
            buttonDiag_EAA.Size = new Size(132, 48);
            buttonDiag_EAA.TabIndex = 0;
            buttonDiag_EAA.Text = "Площадь стран";
            buttonDiag_EAA.UseVisualStyleBackColor = false;
            buttonDiag_EAA.Click += buttonDiag_EAA_Click;
            // 
            // buttonMaxYadra_EAA
            // 
            buttonMaxYadra_EAA.BackColor = Color.Gray;
            buttonMaxYadra_EAA.Location = new Point(486, 15);
            buttonMaxYadra_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonMaxYadra_EAA.Name = "buttonMaxYadra_EAA";
            buttonMaxYadra_EAA.Size = new Size(132, 48);
            buttonMaxYadra_EAA.TabIndex = 0;
            buttonMaxYadra_EAA.Text = "Самая населенная страна";
            buttonMaxYadra_EAA.UseVisualStyleBackColor = false;
            buttonMaxYadra_EAA.Click += buttonMaxYadra_EAA_Click;
            // 
            // buttonSredOZU_EAA
            // 
            buttonSredOZU_EAA.BackColor = Color.Gray;
            buttonSredOZU_EAA.Location = new Point(253, 15);
            buttonSredOZU_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonSredOZU_EAA.Name = "buttonSredOZU_EAA";
            buttonSredOZU_EAA.Size = new Size(132, 48);
            buttonSredOZU_EAA.TabIndex = 0;
            buttonSredOZU_EAA.Text = "Среднее население";
            buttonSredOZU_EAA.UseVisualStyleBackColor = false;
            buttonSredOZU_EAA.Click += buttonSredOZU_EAA_Click;
            // 
            // chartstat_EAA
            // 
            chartArea1.Name = "ChartArea1";
            chartstat_EAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartstat_EAA.Legends.Add(legend1);
            chartstat_EAA.Location = new Point(24, 14);
            chartstat_EAA.Margin = new Padding(4, 3, 4, 3);
            chartstat_EAA.Name = "chartstat_EAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartstat_EAA.Series.Add(series1);
            chartstat_EAA.Size = new Size(360, 369);
            chartstat_EAA.TabIndex = 1;
         
            // 
            // dataGridViewStat_EAA
            // 
            dataGridViewStat_EAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStat_EAA.Location = new Point(392, 14);
            dataGridViewStat_EAA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewStat_EAA.Name = "dataGridViewStat_EAA";
            dataGridViewStat_EAA.Size = new Size(226, 142);
            dataGridViewStat_EAA.TabIndex = 2;
            // 
            // textBoxSredOZU_EAA
            // 
            textBoxSredOZU_EAA.Location = new Point(253, 402);
            textBoxSredOZU_EAA.Margin = new Padding(4, 3, 4, 3);
            textBoxSredOZU_EAA.Name = "textBoxSredOZU_EAA";
            textBoxSredOZU_EAA.Size = new Size(131, 23);
            textBoxSredOZU_EAA.TabIndex = 3;
            // 
            // textBoxMaxYadra_EAA
            // 
            textBoxMaxYadra_EAA.Location = new Point(486, 402);
            textBoxMaxYadra_EAA.Margin = new Padding(4, 3, 4, 3);
            textBoxMaxYadra_EAA.Name = "textBoxMaxYadra_EAA";
            textBoxMaxYadra_EAA.Size = new Size(131, 23);
            textBoxMaxYadra_EAA.TabIndex = 3;
            // 
            // openFileDialogStat_EAA
            // 
            openFileDialogStat_EAA.FileName = "openFileDialog1";
            // 
            // FormStatic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(632, 519);
            Controls.Add(textBoxMaxYadra_EAA);
            Controls.Add(textBoxSredOZU_EAA);
            Controls.Add(dataGridViewStat_EAA);
            Controls.Add(chartstat_EAA);
            Controls.Add(panelLeft_EAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormStatic";
            Text = "Статистика";
            panelLeft_EAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartstat_EAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStat_EAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_EAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartstat_EAA;
        private System.Windows.Forms.Button buttonSredOZU_EAA;
        private System.Windows.Forms.DataGridView dataGridViewStat_EAA;
        private System.Windows.Forms.Button buttonDiag_EAA;
        private System.Windows.Forms.Button buttonMaxYadra_EAA;
        private System.Windows.Forms.TextBox textBoxSredOZU_EAA;
        private System.Windows.Forms.TextBox textBoxMaxYadra_EAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogStat_EAA;
    }
}


