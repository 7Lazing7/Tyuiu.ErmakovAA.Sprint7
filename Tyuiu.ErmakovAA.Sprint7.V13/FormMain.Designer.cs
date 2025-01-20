using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ErmakovAA.Sprint7.V13.Lib;
namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    partial class FormMain
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormMain));
            buttonSave_EAA = new Button();
            buttonSortData_EAA = new Button();
            buttonFirma_EAA = new Button();
            buttonSortAlp_EAA = new Button();
            buttonStat_EAA = new Button();
            buttonInfoMe_EAA = new Button();
            groupBoxData_EAA = new GroupBox();
            dataGridViewIn_EAA = new DataGridView();
            buttonAdd_EAA = new Button();
            groupBoxSearch_EAA = new GroupBox();
            textBoxFind_EAA = new TextBox();
            saveFileDialog_EAA = new SaveFileDialog();
            toolTip_EAA = new ToolTip(components);
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItemProgramm_EAA = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            buttonSearch_SBI = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ToolStripMenuExit_EAA = new ToolStripMenuItem();
            ToolStripMenuItemFile_EAA = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            groupBoxData_EAA.SuspendLayout();
            ((ISupportInitialize)dataGridViewIn_EAA).BeginInit();
            groupBoxSearch_EAA.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave_EAA
            // 
            buttonSave_EAA.BackColor = Color.LightGray;
            buttonSave_EAA.Cursor = Cursors.Hand;
            buttonSave_EAA.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_EAA.Image = (Image)resources.GetObject("buttonSave_EAA.Image");
            buttonSave_EAA.Location = new Point(86, 17);
            buttonSave_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonSave_EAA.Name = "buttonSave_EAA";
            buttonSave_EAA.Size = new Size(61, 61);
            buttonSave_EAA.TabIndex = 5;
            toolTip_EAA.SetToolTip(buttonSave_EAA, "Сохранение в формате CSV");
            buttonSave_EAA.UseVisualStyleBackColor = false;
            buttonSave_EAA.Click += buttonSave_EAA_Click;
            // 
            // buttonSortData_EAA
            // 
            buttonSortData_EAA.BackColor = Color.Gray;
            buttonSortData_EAA.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSortData_EAA.Location = new Point(13, 236);
            buttonSortData_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonSortData_EAA.Name = "buttonSortData_EAA";
            buttonSortData_EAA.Size = new Size(127, 47);
            buttonSortData_EAA.TabIndex = 7;
            buttonSortData_EAA.Text = " Отсортировать\r\nпо году выпуска";
            buttonSortData_EAA.UseVisualStyleBackColor = false;
            buttonSortData_EAA.Click += buttonSortData_EAA_Click;
            // 
            // buttonFirma_EAA
            // 
            buttonFirma_EAA.BackColor = Color.LightGray;
            buttonFirma_EAA.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFirma_EAA.Location = new Point(13, 342);
            buttonFirma_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonFirma_EAA.Name = "buttonFirma_EAA";
            buttonFirma_EAA.Size = new Size(127, 61);
            buttonFirma_EAA.TabIndex = 5;
            buttonFirma_EAA.Text = "Существующие фирмы";
            buttonFirma_EAA.UseVisualStyleBackColor = false;
            buttonFirma_EAA.Click += buttonFirma_EAA_Click;
            // 
            // buttonSortAlp_EAA
            // 
            buttonSortAlp_EAA.BackColor = Color.Gray;
            buttonSortAlp_EAA.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSortAlp_EAA.ForeColor = SystemColors.ControlText;
            buttonSortAlp_EAA.Location = new Point(13, 289);
            buttonSortAlp_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonSortAlp_EAA.Name = "buttonSortAlp_EAA";
            buttonSortAlp_EAA.Size = new Size(127, 47);
            buttonSortAlp_EAA.TabIndex = 6;
            buttonSortAlp_EAA.Text = "Отсортировать\r\n по алфавиту";
            buttonSortAlp_EAA.UseVisualStyleBackColor = false;
            buttonSortAlp_EAA.Click += buttonSortAlp_EAA_Click;
            // 
            // buttonStat_EAA
            // 
            buttonStat_EAA.BackColor = Color.LightGray;
            buttonStat_EAA.Cursor = Cursors.Hand;
            buttonStat_EAA.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStat_EAA.Image = (Image)resources.GetObject("buttonStat_EAA.Image");
            buttonStat_EAA.Location = new Point(161, 17);
            buttonStat_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonStat_EAA.Name = "buttonStat_EAA";
            buttonStat_EAA.Size = new Size(61, 61);
            buttonStat_EAA.TabIndex = 5;
            buttonStat_EAA.UseVisualStyleBackColor = false;
            buttonStat_EAA.Click += buttonStat_EAA_Click;
            // 
            // buttonInfoMe_EAA
            // 
            buttonInfoMe_EAA.Anchor = AnchorStyles.None;
            buttonInfoMe_EAA.BackColor = Color.Gainsboro;
            buttonInfoMe_EAA.Cursor = Cursors.Hand;
            buttonInfoMe_EAA.ForeColor = Color.Transparent;
            buttonInfoMe_EAA.Image = (Image)resources.GetObject("buttonInfoMe_EAA.Image");
            buttonInfoMe_EAA.ImageAlign = ContentAlignment.BottomCenter;
            buttonInfoMe_EAA.Location = new Point(181, 12);
            buttonInfoMe_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonInfoMe_EAA.Name = "buttonInfoMe_EAA";
            buttonInfoMe_EAA.Size = new Size(42, 41);
            buttonInfoMe_EAA.TabIndex = 2;
            buttonInfoMe_EAA.TextAlign = ContentAlignment.BottomCenter;
            buttonInfoMe_EAA.UseMnemonic = false;
            buttonInfoMe_EAA.UseVisualStyleBackColor = false;
            buttonInfoMe_EAA.Click += buttonHelp_SBI_Click;
            // 
            // groupBoxData_EAA
            // 
            groupBoxData_EAA.Controls.Add(dataGridViewIn_EAA);
            groupBoxData_EAA.Location = new Point(266, 40);
            groupBoxData_EAA.Margin = new Padding(4, 3, 4, 3);
            groupBoxData_EAA.Name = "groupBoxData_EAA";
            groupBoxData_EAA.Padding = new Padding(4, 3, 4, 3);
            groupBoxData_EAA.Size = new Size(668, 467);
            groupBoxData_EAA.TabIndex = 3;
            groupBoxData_EAA.TabStop = false;
            groupBoxData_EAA.Text = "Вводимые данные:";
            // 
            // dataGridViewIn_EAA
            // 
            dataGridViewIn_EAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_EAA.Location = new Point(8, 22);
            dataGridViewIn_EAA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewIn_EAA.Name = "dataGridViewIn_EAA";
            dataGridViewIn_EAA.Size = new Size(652, 430);
            dataGridViewIn_EAA.TabIndex = 0;
            // 
            // buttonAdd_EAA
            // 
            buttonAdd_EAA.BackColor = Color.LightGray;
            buttonAdd_EAA.Cursor = Cursors.Hand;
            buttonAdd_EAA.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd_EAA.Location = new Point(10, 16);
            buttonAdd_EAA.Margin = new Padding(4, 3, 4, 3);
            buttonAdd_EAA.Name = "buttonAdd_EAA";
            buttonAdd_EAA.Size = new Size(61, 61);
            buttonAdd_EAA.TabIndex = 4;
            buttonAdd_EAA.UseVisualStyleBackColor = false;
            buttonAdd_EAA.Click += buttonAdd_EAA_Click;
            // 
            // groupBoxSearch_EAA
            // 
            groupBoxSearch_EAA.Controls.Add(textBoxFind_EAA);
            groupBoxSearch_EAA.Controls.Add(buttonInfoMe_EAA);
            groupBoxSearch_EAA.Location = new Point(13, 40);
            groupBoxSearch_EAA.Margin = new Padding(4, 3, 4, 3);
            groupBoxSearch_EAA.Name = "groupBoxSearch_EAA";
            groupBoxSearch_EAA.Padding = new Padding(4, 3, 4, 3);
            groupBoxSearch_EAA.Size = new Size(233, 59);
            groupBoxSearch_EAA.TabIndex = 4;
            groupBoxSearch_EAA.TabStop = false;
            groupBoxSearch_EAA.Text = "Поиск по названию";
            groupBoxSearch_EAA.Enter += groupBoxSearch_EAA_Enter;
            // 
            // textBoxFind_EAA
            // 
            textBoxFind_EAA.Location = new Point(0, 24);
            textBoxFind_EAA.Margin = new Padding(4, 3, 4, 3);
            textBoxFind_EAA.Name = "textBoxFind_EAA";
            textBoxFind_EAA.Size = new Size(164, 23);
            textBoxFind_EAA.TabIndex = 0;
            textBoxFind_EAA.TextChanged += textBoxFind_EAA_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAdd_EAA);
            groupBox1.Controls.Add(buttonSave_EAA);
            groupBox1.Controls.Add(buttonStat_EAA);
            groupBox1.Location = new Point(13, 105);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(233, 83);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Файл";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemProgramm_EAA, ToolStripMenuItemFile_EAA });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemProgramm_EAA
            // 
            ToolStripMenuItemProgramm_EAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, buttonSearch_SBI, toolStripSeparator2, ToolStripMenuExit_EAA });
            ToolStripMenuItemProgramm_EAA.Name = "ToolStripMenuItemProgramm_EAA";
            ToolStripMenuItemProgramm_EAA.Size = new Size(84, 20);
            ToolStripMenuItemProgramm_EAA.Text = "Программа";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "О программе";
            toolStripMenuItem2.Click += buttonInfoMe_EAA_Click;
            // 
            // buttonSearch_SBI
            // 
            buttonSearch_SBI.Name = "buttonSearch_SBI";
            buttonSearch_SBI.Size = new Size(180, 22);
            buttonSearch_SBI.Text = "Руководство";
            buttonSearch_SBI.Click += buttonHelp_SBI_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // ToolStripMenuExit_EAA
            // 
            ToolStripMenuExit_EAA.Name = "ToolStripMenuExit_EAA";
            ToolStripMenuExit_EAA.Size = new Size(180, 22);
            ToolStripMenuExit_EAA.Text = "Выход";
            ToolStripMenuExit_EAA.Click += ToolStripMenuExit_EAA_Click;
            // 
            // ToolStripMenuItemFile_EAA
            // 
            ToolStripMenuItemFile_EAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10 });
            ToolStripMenuItemFile_EAA.Name = "ToolStripMenuItemFile_EAA";
            ToolStripMenuItemFile_EAA.Size = new Size(48, 20);
            ToolStripMenuItemFile_EAA.Text = "Файл";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(198, 22);
            toolStripMenuItem5.Text = "Открыть новый файл";
            toolStripMenuItem5.Click += buttonAdd_EAA_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(198, 22);
            toolStripMenuItem8.Text = "Сохранить как";
            toolStripMenuItem8.Click += buttonSave_EAA_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(198, 22);
            toolStripMenuItem9.Text = "Открыть новое окно";
            toolStripMenuItem9.Click += buttonFirma_EAA_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Enabled = false;
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(198, 22);
            toolStripMenuItem10.Text = "Открыть данный файл";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonFirma_EAA);
            Controls.Add(buttonSortData_EAA);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(buttonSortAlp_EAA);
            Controls.Add(groupBoxSearch_EAA);
            Controls.Add(groupBoxData_EAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 13 | Ермаков А.А.";
            Load += FormMain_Load;
            groupBoxData_EAA.ResumeLayout(false);
            ((ISupportInitialize)dataGridViewIn_EAA).EndInit();
            groupBoxSearch_EAA.ResumeLayout(false);
            groupBoxSearch_EAA.PerformLayout();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSave_EAA;
        private System.Windows.Forms.Button buttonInfoMe_EAA;
        private System.Windows.Forms.GroupBox groupBoxData_EAA;
        private System.Windows.Forms.DataGridView dataGridViewIn_EAA;
        private System.Windows.Forms.Button buttonAdd_EAA;
        private System.Windows.Forms.GroupBox groupBoxSearch_EAA;
        private System.Windows.Forms.TextBox textBoxFind_EAA;
        private System.Windows.Forms.Button buttonStat_EAA;
        private System.Windows.Forms.Button buttonSortData_EAA;
        private System.Windows.Forms.Button buttonSortAlp_EAA;
        private System.Windows.Forms.Button buttonFirma_EAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_EAA;
        private System.Windows.Forms.ToolTip toolTip_EAA;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItemProgramm_EAA;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ToolStripMenuExit_EAA;
        private ToolStripMenuItem ToolStripMenuItemFile_EAA;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem buttonSearch_SBI;
    }
}