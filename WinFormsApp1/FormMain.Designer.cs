using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_SBI = new MenuStrip();
            ToolStripMenuItemProgramm_SBI = new ToolStripMenuItem();
            ToolStripMenuAbout_SBI = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuExit_SBI = new ToolStripMenuItem();
            ToolStripMenuItemFile_SBI = new ToolStripMenuItem();
            ToolStripMenuOpenNewFileTool_SBI = new ToolStripMenuItem();
            ToolStripMenuOpenNewFile_SBI = new ToolStripMenuItem();
            ToolStripMenuImages_SBI = new ToolStripMenuItem();
            ToolStripMenuSaveFile_SBI = new ToolStripMenuItem();
            ToolStripMenuRefresh_SBI = new ToolStripMenuItem();
            ToolStripMenuOpenFile_SBI = new ToolStripMenuItem();
            tableLayoutPanel_SBI = new TableLayoutPanel();
            panelControl_SBI = new Panel();
            groupBoxEdit_SBI = new GroupBox();
            labelRowFocusIndex_SBI = new Label();
            buttonSetFeature_SBI = new Button();
            buttonOpenRoute_SBI = new Button();
            groupBox1 = new GroupBox();
            buttonHelpImages_SBI = new Button();
            buttonHelp_SBI = new Button();
            groupBoxFile_SBI = new GroupBox();
            buttonUpdateFile_SBI = new Button();
            buttonSaveFile_SBI = new Button();
            buttonOpenFile_SBI = new Button();
            groupBoxSearch_SBI = new GroupBox();
            buttonSearch_SBI = new Button();
            textBoxSearch_SBI = new TextBox();
            tabControlRoutes_SBI = new TabControl();
            tabPageRoutes = new TabPage();
            dataGridViewRoutes_SBI = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnStart = new DataGridViewTextBoxColumn();
            ColumnEnd = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            tabPageFeatures = new TabPage();
            dataGridViewFeatures_SBI = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            toolTip_SBI = new ToolTip(components);
            openFileDialog_SBI = new OpenFileDialog();
            saveFileDialog_SBI = new SaveFileDialog();
            menuStrip_SBI.SuspendLayout();
            tableLayoutPanel_SBI.SuspendLayout();
            panelControl_SBI.SuspendLayout();
            groupBoxEdit_SBI.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxFile_SBI.SuspendLayout();
            groupBoxSearch_SBI.SuspendLayout();
            tabControlRoutes_SBI.SuspendLayout();
            tabPageRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_SBI).BeginInit();
            tabPageFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_SBI).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_SBI
            // 
            menuStrip_SBI.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemProgramm_SBI, ToolStripMenuItemFile_SBI });
            menuStrip_SBI.Location = new Point(0, 0);
            menuStrip_SBI.Name = "menuStrip_SBI";
            menuStrip_SBI.RenderMode = ToolStripRenderMode.System;
            menuStrip_SBI.Size = new Size(800, 24);
            menuStrip_SBI.TabIndex = 0;
            menuStrip_SBI.Text = "menuStrip1";
            // 
            // ToolStripMenuItemProgramm_SBI
            // 
            ToolStripMenuItemProgramm_SBI.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuAbout_SBI, toolStripSeparator1, ToolStripMenuExit_SBI });
            ToolStripMenuItemProgramm_SBI.Name = "ToolStripMenuItemProgramm_SBI";
            ToolStripMenuItemProgramm_SBI.Size = new Size(84, 20);
            ToolStripMenuItemProgramm_SBI.Text = "Программа";
            // 
            // ToolStripMenuAbout_SBI
            // 
            ToolStripMenuAbout_SBI.Name = "ToolStripMenuAbout_SBI";
            ToolStripMenuAbout_SBI.Size = new Size(149, 22);
            ToolStripMenuAbout_SBI.Text = "О программе";
            ToolStripMenuAbout_SBI.Click += ToolStripMenuAbout_SBI_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(146, 6);
            // 
            // ToolStripMenuExit_SBI
            // 
            ToolStripMenuExit_SBI.Name = "ToolStripMenuExit_SBI";
            ToolStripMenuExit_SBI.Size = new Size(149, 22);
            ToolStripMenuExit_SBI.Text = "Выход";
            ToolStripMenuExit_SBI.Click += ToolStripMenuExit_SBI_Click;
            // 
            // ToolStripMenuItemFile_SBI
            // 
            ToolStripMenuItemFile_SBI.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFileTool_SBI, ToolStripMenuSaveFile_SBI, ToolStripMenuRefresh_SBI, ToolStripMenuOpenFile_SBI });
            ToolStripMenuItemFile_SBI.Name = "ToolStripMenuItemFile_SBI";
            ToolStripMenuItemFile_SBI.Size = new Size(48, 20);
            ToolStripMenuItemFile_SBI.Text = "Файл";
            // 
            // ToolStripMenuOpenNewFileTool_SBI
            // 
            ToolStripMenuOpenNewFileTool_SBI.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFile_SBI, ToolStripMenuImages_SBI });
            ToolStripMenuOpenNewFileTool_SBI.Name = "ToolStripMenuOpenNewFileTool_SBI";
            ToolStripMenuOpenNewFileTool_SBI.Size = new Size(198, 22);
            ToolStripMenuOpenNewFileTool_SBI.Text = "Открыть новый файл";
            ToolStripMenuOpenNewFileTool_SBI.Click += buttonOpenFile_SBI_Click;
            // 
            // ToolStripMenuOpenNewFile_SBI
            // 
            ToolStripMenuOpenNewFile_SBI.Name = "ToolStripMenuOpenNewFile_SBI";
            ToolStripMenuOpenNewFile_SBI.Size = new Size(258, 22);
            ToolStripMenuOpenNewFile_SBI.Text = "Открыть файл машрутов";
            ToolStripMenuOpenNewFile_SBI.Click += buttonOpenFile_SBI_Click;
            // 
            // ToolStripMenuImages_SBI
            // 
            ToolStripMenuImages_SBI.Name = "ToolStripMenuImages_SBI";
            ToolStripMenuImages_SBI.Size = new Size(258, 22);
            ToolStripMenuImages_SBI.Text = "Выбрать папку с изображениями";
            ToolStripMenuImages_SBI.Click += ToolStripMenuImages_SBI_Click;
            // 
            // ToolStripMenuSaveFile_SBI
            // 
            ToolStripMenuSaveFile_SBI.Enabled = false;
            ToolStripMenuSaveFile_SBI.Name = "ToolStripMenuSaveFile_SBI";
            ToolStripMenuSaveFile_SBI.Size = new Size(198, 22);
            ToolStripMenuSaveFile_SBI.Text = "Сохранить как";
            ToolStripMenuSaveFile_SBI.Click += buttonSaveFile_SBI_Click;
            // 
            // ToolStripMenuRefresh_SBI
            // 
            ToolStripMenuRefresh_SBI.Enabled = false;
            ToolStripMenuRefresh_SBI.Name = "ToolStripMenuRefresh_SBI";
            ToolStripMenuRefresh_SBI.Size = new Size(198, 22);
            ToolStripMenuRefresh_SBI.Text = "Обновить";
            ToolStripMenuRefresh_SBI.Click += buttonUpdateFile_SBI_Click;
            // 
            // ToolStripMenuOpenFile_SBI
            // 
            ToolStripMenuOpenFile_SBI.Enabled = false;
            ToolStripMenuOpenFile_SBI.Name = "ToolStripMenuOpenFile_SBI";
            ToolStripMenuOpenFile_SBI.Size = new Size(198, 22);
            ToolStripMenuOpenFile_SBI.Text = "Открыть данный файл";
            ToolStripMenuOpenFile_SBI.Click += ToolStripMenuOpenFile_SBI_Click;
            // 
            // tableLayoutPanel_SBI
            // 
            tableLayoutPanel_SBI.ColumnCount = 2;
            tableLayoutPanel_SBI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_SBI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_SBI.Controls.Add(panelControl_SBI, 0, 0);
            tableLayoutPanel_SBI.Controls.Add(tabControlRoutes_SBI, 1, 0);
            tableLayoutPanel_SBI.Dock = DockStyle.Fill;
            tableLayoutPanel_SBI.Location = new Point(0, 24);
            tableLayoutPanel_SBI.Name = "tableLayoutPanel_SBI";
            tableLayoutPanel_SBI.Padding = new Padding(5);
            tableLayoutPanel_SBI.RowCount = 1;
            tableLayoutPanel_SBI.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_SBI.Size = new Size(800, 426);
            tableLayoutPanel_SBI.TabIndex = 1;
            // 
            // panelControl_SBI
            // 
            panelControl_SBI.Controls.Add(groupBoxEdit_SBI);
            panelControl_SBI.Controls.Add(groupBox1);
            panelControl_SBI.Controls.Add(groupBoxFile_SBI);
            panelControl_SBI.Controls.Add(groupBoxSearch_SBI);
            panelControl_SBI.Dock = DockStyle.Fill;
            panelControl_SBI.Location = new Point(8, 8);
            panelControl_SBI.Name = "panelControl_SBI";
            panelControl_SBI.Padding = new Padding(5, 0, 5, 5);
            panelControl_SBI.Size = new Size(231, 410);
            panelControl_SBI.TabIndex = 1;
            // 
            // groupBoxEdit_SBI
            // 
            groupBoxEdit_SBI.Controls.Add(labelRowFocusIndex_SBI);
            groupBoxEdit_SBI.Controls.Add(buttonSetFeature_SBI);
            groupBoxEdit_SBI.Controls.Add(buttonOpenRoute_SBI);
            groupBoxEdit_SBI.Location = new Point(8, 146);
            groupBoxEdit_SBI.Name = "groupBoxEdit_SBI";
            groupBoxEdit_SBI.Size = new Size(218, 91);
            groupBoxEdit_SBI.TabIndex = 4;
            groupBoxEdit_SBI.TabStop = false;
            groupBoxEdit_SBI.Text = "Работа с маршрутами";
            // 
            // labelRowFocusIndex_SBI
            // 
            labelRowFocusIndex_SBI.AutoSize = true;
            labelRowFocusIndex_SBI.Location = new Point(166, 37);
            labelRowFocusIndex_SBI.Name = "labelRowFocusIndex_SBI";
            labelRowFocusIndex_SBI.Size = new Size(0, 25);
            labelRowFocusIndex_SBI.TabIndex = 4;
            labelRowFocusIndex_SBI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSetFeature_SBI
            // 
            buttonSetFeature_SBI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSetFeature_SBI.Enabled = false;
            buttonSetFeature_SBI.Location = new Point(74, 20);
            buttonSetFeature_SBI.Name = "buttonSetFeature_SBI";
            buttonSetFeature_SBI.Size = new Size(65, 65);
            buttonSetFeature_SBI.TabIndex = 3;
            toolTip_SBI.SetToolTip(buttonSetFeature_SBI, "Добавить маршрут в избранное");
            buttonSetFeature_SBI.UseVisualStyleBackColor = true;
            buttonSetFeature_SBI.Click += buttonSetFeature_SBI_Click;
            buttonSetFeature_SBI.MouseEnter += buttonSetFeature_SBI_MouseEnter;
            // 
            // buttonOpenRoute_SBI
            // 
            
            buttonOpenRoute_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenRoute_SBI.Enabled = false;
            buttonOpenRoute_SBI.Location = new Point(3, 20);
            buttonOpenRoute_SBI.Name = "buttonOpenRoute_SBI";
            buttonOpenRoute_SBI.Size = new Size(65, 65);
            buttonOpenRoute_SBI.TabIndex = 3;
            toolTip_SBI.SetToolTip(buttonOpenRoute_SBI, "Посмотреть карту маршрута");
            buttonOpenRoute_SBI.UseVisualStyleBackColor = true;
            buttonOpenRoute_SBI.Click += buttonOpenRoute_SBI_Click;
            buttonOpenRoute_SBI.MouseEnter += buttonOpenRoute_SBI_MouseEnter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonHelpImages_SBI);
            groupBox1.Controls.Add(buttonHelp_SBI);
            groupBox1.Location = new Point(5, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 87);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Руководство";
            // 
            // buttonHelpImages_SBI
            // 
           
            buttonHelpImages_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonHelpImages_SBI.Location = new Point(118, 16);
            buttonHelpImages_SBI.Name = "buttonHelpImages_SBI";
            buttonHelpImages_SBI.Size = new Size(65, 65);
            buttonHelpImages_SBI.TabIndex = 4;
            toolTip_SBI.SetToolTip(buttonHelpImages_SBI, "Как сделать отображение фото остановок\r\n");
            buttonHelpImages_SBI.UseVisualStyleBackColor = true;
            buttonHelpImages_SBI.Click += buttonHelpImages_SBI_Click;
            buttonHelpImages_SBI.MouseEnter += buttonHelpImages_SBI_MouseEnter;
            // 
            // buttonHelp_SBI
            // 
            
            buttonHelp_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_SBI.Location = new Point(38, 16);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(65, 65);
            buttonHelp_SBI.TabIndex = 3;
            toolTip_SBI.SetToolTip(buttonHelp_SBI, "Как создать свой файл маршрутов");
            buttonHelp_SBI.UseVisualStyleBackColor = true;
            buttonHelp_SBI.Click += buttonHelp_SBI_Click;
            buttonHelp_SBI.MouseEnter += buttonHelp_SBI_MouseEnter;
            // 
            // groupBoxFile_SBI
            // 
            groupBoxFile_SBI.Controls.Add(buttonUpdateFile_SBI);
            groupBoxFile_SBI.Controls.Add(buttonSaveFile_SBI);
            groupBoxFile_SBI.Controls.Add(buttonOpenFile_SBI);
            groupBoxFile_SBI.Dock = DockStyle.Top;
            groupBoxFile_SBI.Location = new Point(5, 53);
            groupBoxFile_SBI.Name = "groupBoxFile_SBI";
            groupBoxFile_SBI.Size = new Size(221, 87);
            groupBoxFile_SBI.TabIndex = 1;
            groupBoxFile_SBI.TabStop = false;
            groupBoxFile_SBI.Text = "Файл";
            // 
            // buttonUpdateFile_SBI
            // 
            
            buttonUpdateFile_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonUpdateFile_SBI.Enabled = false;
            buttonUpdateFile_SBI.Location = new Point(148, 16);
            buttonUpdateFile_SBI.Name = "buttonUpdateFile_SBI";
            buttonUpdateFile_SBI.Size = new Size(65, 65);
            buttonUpdateFile_SBI.TabIndex = 2;
            toolTip_SBI.SetToolTip(buttonUpdateFile_SBI, "Обновить содержимое файла");
            buttonUpdateFile_SBI.UseVisualStyleBackColor = true;
            buttonUpdateFile_SBI.Click += buttonUpdateFile_SBI_Click;
            buttonUpdateFile_SBI.MouseEnter += buttonUpdateFile_SBI_MouseEnter;
            // 
            // buttonSaveFile_SBI
            // 
            
            buttonSaveFile_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_SBI.Enabled = false;
            buttonSaveFile_SBI.Location = new Point(77, 16);
            buttonSaveFile_SBI.Name = "buttonSaveFile_SBI";
            buttonSaveFile_SBI.Size = new Size(65, 65);
            buttonSaveFile_SBI.TabIndex = 1;
            toolTip_SBI.SetToolTip(buttonSaveFile_SBI, "Сохранить файл");
            buttonSaveFile_SBI.UseVisualStyleBackColor = true;
            buttonSaveFile_SBI.Click += buttonSaveFile_SBI_Click;
            buttonSaveFile_SBI.MouseEnter += buttonSaveFile_SBI_MouseEnter;
            // 
            // buttonOpenFile_SBI
            // 
            
            buttonOpenFile_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_SBI.Location = new Point(6, 16);
            buttonOpenFile_SBI.Name = "buttonOpenFile_SBI";
            buttonOpenFile_SBI.Size = new Size(65, 65);
            buttonOpenFile_SBI.TabIndex = 0;
            toolTip_SBI.SetToolTip(buttonOpenFile_SBI, "Открыть файл маршрутов (.csv)");
            buttonOpenFile_SBI.UseVisualStyleBackColor = true;
            buttonOpenFile_SBI.Click += buttonOpenFile_SBI_Click;
            buttonOpenFile_SBI.MouseEnter += buttonOpenFile_SBI_MouseEnter;
            // 
            // groupBoxSearch_SBI
            // 
            groupBoxSearch_SBI.Controls.Add(buttonSearch_SBI);
            groupBoxSearch_SBI.Controls.Add(textBoxSearch_SBI);
            groupBoxSearch_SBI.Dock = DockStyle.Top;
            groupBoxSearch_SBI.Location = new Point(5, 0);
            groupBoxSearch_SBI.Name = "groupBoxSearch_SBI";
            groupBoxSearch_SBI.Size = new Size(221, 53);
            groupBoxSearch_SBI.TabIndex = 0;
            groupBoxSearch_SBI.TabStop = false;
            groupBoxSearch_SBI.Text = "Поиск";
            // 
            // buttonSearch_SBI
            // 
            
            buttonSearch_SBI.Location = new Point(175, 11);
            buttonSearch_SBI.Name = "buttonSearch_SBI";
            buttonSearch_SBI.Size = new Size(40, 38);
            buttonSearch_SBI.TabIndex = 4;
            toolTip_SBI.SetToolTip(buttonSearch_SBI, "Выполнить поиск");
            buttonSearch_SBI.UseVisualStyleBackColor = true;
            buttonSearch_SBI.Click += buttonSearch_SBI_Click;
            // 
            // textBoxSearch_SBI
            // 
            textBoxSearch_SBI.Location = new Point(6, 24);
            textBoxSearch_SBI.Name = "textBoxSearch_SBI";
            textBoxSearch_SBI.Size = new Size(163, 23);
            textBoxSearch_SBI.TabIndex = 3;
            toolTip_SBI.SetToolTip(textBoxSearch_SBI, "Введите номер маршрута");
            textBoxSearch_SBI.MouseEnter += textBoxSearch_SBI_MouseEnter;
            // 
            // tabControlRoutes_SBI
            // 
            tabControlRoutes_SBI.Controls.Add(tabPageRoutes);
            tabControlRoutes_SBI.Controls.Add(tabPageFeatures);
            tabControlRoutes_SBI.Dock = DockStyle.Fill;
            tabControlRoutes_SBI.Location = new Point(245, 8);
            tabControlRoutes_SBI.Name = "tabControlRoutes_SBI";
            tabControlRoutes_SBI.SelectedIndex = 0;
            tabControlRoutes_SBI.Size = new Size(547, 410);
            tabControlRoutes_SBI.TabIndex = 2;
            tabControlRoutes_SBI.Selected += tabControlRoutes_SBI_Selected;
            // 
            // tabPageRoutes
            // 
            tabPageRoutes.Controls.Add(dataGridViewRoutes_SBI);
            tabPageRoutes.Location = new Point(4, 24);
            tabPageRoutes.Name = "tabPageRoutes";
            tabPageRoutes.Padding = new Padding(3);
            tabPageRoutes.Size = new Size(539, 382);
            tabPageRoutes.TabIndex = 0;
            tabPageRoutes.Text = "Список маршрутов";
            tabPageRoutes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoutes_SBI
            // 
            dataGridViewRoutes_SBI.AllowUserToAddRows = false;
            dataGridViewRoutes_SBI.AllowUserToDeleteRows = false;
            dataGridViewRoutes_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_SBI.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnStart, ColumnEnd, ColumnType });
            dataGridViewRoutes_SBI.Dock = DockStyle.Fill;
            dataGridViewRoutes_SBI.Location = new Point(3, 3);
            dataGridViewRoutes_SBI.Name = "dataGridViewRoutes_SBI";
            dataGridViewRoutes_SBI.ReadOnly = true;
            dataGridViewRoutes_SBI.RowHeadersVisible = false;
            dataGridViewRoutes_SBI.Size = new Size(533, 376);
            dataGridViewRoutes_SBI.TabIndex = 0;
            dataGridViewRoutes_SBI.CellContentClick += dataGridViewRoutes_SBI_CellClick;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "№";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.ToolTipText = "Номер маршрута";
            ColumnNumber.Width = 30;
            // 
            // ColumnStart
            // 
            ColumnStart.HeaderText = "Начальная остановка";
            ColumnStart.Name = "ColumnStart";
            ColumnStart.ReadOnly = true;
            ColumnStart.ToolTipText = "Первая остановка";
            ColumnStart.Width = 200;
            // 
            // ColumnEnd
            // 
            ColumnEnd.HeaderText = "Конечная остановка";
            ColumnEnd.Name = "ColumnEnd";
            ColumnEnd.ReadOnly = true;
            ColumnEnd.ToolTipText = "Последняя остановка";
            ColumnEnd.Width = 200;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Тип";
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            ColumnType.ToolTipText = "Вид транспорта";
            // 
            // tabPageFeatures
            // 
            tabPageFeatures.Controls.Add(dataGridViewFeatures_SBI);
            tabPageFeatures.Location = new Point(4, 24);
            tabPageFeatures.Name = "tabPageFeatures";
            tabPageFeatures.Padding = new Padding(3);
            tabPageFeatures.Size = new Size(539, 382);
            tabPageFeatures.TabIndex = 1;
            tabPageFeatures.Text = "Избранные";
            tabPageFeatures.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFeatures_SBI
            // 
            dataGridViewFeatures_SBI.AllowUserToAddRows = false;
            dataGridViewFeatures_SBI.AllowUserToDeleteRows = false;
            dataGridViewFeatures_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeatures_SBI.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewFeatures_SBI.Dock = DockStyle.Fill;
            dataGridViewFeatures_SBI.Location = new Point(3, 3);
            dataGridViewFeatures_SBI.MinimumSize = new Size(533, 376);
            dataGridViewFeatures_SBI.Name = "dataGridViewFeatures_SBI";
            dataGridViewFeatures_SBI.ReadOnly = true;
            dataGridViewFeatures_SBI.RowHeadersVisible = false;
            dataGridViewFeatures_SBI.Size = new Size(533, 376);
            dataGridViewFeatures_SBI.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "№";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.ToolTipText = "Номер маршрута";
            dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Начальная остановка";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.ToolTipText = "Первая остановка";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Конечная остановка";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.ToolTipText = "Последняя остановка";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Тип";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.ToolTipText = "Вид транспорта";
            // 
            // toolTip_SBI
            // 
            toolTip_SBI.IsBalloon = true;
            toolTip_SBI.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_SBI
            // 
            openFileDialog_SBI.FileName = "Routes.csv";
            // 
            // saveFileDialog_SBI
            // 
            saveFileDialog_SBI.FileName = "file.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel_SBI);
            Controls.Add(menuStrip_SBI);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip_SBI;
            MinimumSize = new Size(820, 493);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Транспортные маршруты";
            Load += FormMain_Load;
            menuStrip_SBI.ResumeLayout(false);
            menuStrip_SBI.PerformLayout();
            tableLayoutPanel_SBI.ResumeLayout(false);
            panelControl_SBI.ResumeLayout(false);
            groupBoxEdit_SBI.ResumeLayout(false);
            groupBoxEdit_SBI.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBoxFile_SBI.ResumeLayout(false);
            groupBoxSearch_SBI.ResumeLayout(false);
            groupBoxSearch_SBI.PerformLayout();
            tabControlRoutes_SBI.ResumeLayout(false);
            tabPageRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_SBI).EndInit();
            tabPageFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_SBI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_SBI;
        private ToolStripMenuItem ToolStripMenuItemProgramm_SBI;
        private ToolStripMenuItem ToolStripMenuAbout_SBI;
        private ToolStripMenuItem ToolStripMenuItemFile_SBI;
        private TableLayoutPanel tableLayoutPanel_SBI;
        private Panel panelControl_SBI;
        private TabControl tabControlRoutes_SBI;
        private TabPage tabPageRoutes;
        private TabPage tabPageFeatures;
        private DataGridView dataGridViewRoutes_SBI;
        private GroupBox groupBoxSearch_SBI;
        private Button buttonSearch_SBI;
        private TextBox textBoxSearch_SBI;
        private ToolTip toolTip_SBI;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnStart;
        private DataGridViewTextBoxColumn ColumnEnd;
        private DataGridViewTextBoxColumn ColumnType;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolStripMenuExit_SBI;
        private GroupBox groupBoxFile_SBI;
        private Button buttonUpdateFile_SBI;
        private Button buttonSaveFile_SBI;
        private Button buttonOpenFile_SBI;
        private GroupBox groupBox1;
        private Button buttonHelp_SBI;
        private ToolStripMenuItem ToolStripMenuOpenNewFileTool_SBI;
        private ToolStripMenuItem ToolStripMenuSaveFile_SBI;
        private ToolStripMenuItem ToolStripMenuRefresh_SBI;
        private ToolStripMenuItem ToolStripMenuOpenFile_SBI;
        private GroupBox groupBoxEdit_SBI;
        private Button buttonSetFeature_SBI;
        private Button buttonOpenRoute_SBI;
        private Button buttonHelpImages_SBI;
        private OpenFileDialog openFileDialog_SBI;
        private DataGridView dataGridViewFeatures_SBI;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private SaveFileDialog saveFileDialog_SBI;
        private Label labelRowFocusIndex_SBI;
        private ToolStripMenuItem ToolStripMenuOpenNewFile_SBI;
        private ToolStripMenuItem ToolStripMenuImages_SBI;
    }
}