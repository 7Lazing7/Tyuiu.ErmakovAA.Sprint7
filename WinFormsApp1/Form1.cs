using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private GroupBox groupBoxCountryInfo;
    private DataGridView dataGridViewCountryInfo;

    public Form1()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        groupBoxCountryInfo = new GroupBox();
        dataGridViewCountryInfo = new DataGridView();
        groupBoxCountryInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewCountryInfo).BeginInit();
        SuspendLayout();
        // 
        // groupBoxCountryInfo
        // 
        groupBoxCountryInfo.Controls.Add(dataGridViewCountryInfo);
        groupBoxCountryInfo.Location = new Point(12, 12);
        groupBoxCountryInfo.Name = "groupBoxCountryInfo";
        groupBoxCountryInfo.Size = new Size(760, 337);
        groupBoxCountryInfo.TabIndex = 0;
        groupBoxCountryInfo.TabStop = false;
        groupBoxCountryInfo.Text = "Информация о стране";
        // 
        // dataGridViewCountryInfo
        // 
        dataGridViewCountryInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCountryInfo.Dock = DockStyle.Fill;
        dataGridViewCountryInfo.Location = new Point(3, 19);
        dataGridViewCountryInfo.Name = "dataGridViewCountryInfo";
        dataGridViewCountryInfo.Size = new Size(754, 315);
        dataGridViewCountryInfo.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 361);
        Controls.Add(groupBoxCountryInfo);
        Name = "Form1";
        Text = "Информация о странах";
        Load += Form1_Load;
        groupBoxCountryInfo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewCountryInfo).EndInit();
        ResumeLayout(false);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Задаем колонки для DataGridView
        dataGridViewCountryInfo.Columns.Add("CountryName", "Название страны");
        dataGridViewCountryInfo.Columns.Add("Capital", "Столица");
        dataGridViewCountryInfo.Columns.Add("Area", "Площадь территории");
        dataGridViewCountryInfo.Columns.Add("DevelopedEconomy", "Развита в экономическом отношении");
        dataGridViewCountryInfo.Columns.Add("Population", "Количество населения");
        dataGridViewCountryInfo.Columns.Add("DominantNationality", "Преобладающая национальность");
        dataGridViewCountryInfo.Columns.Add("Notes", "Примечание");

        // Пример добавления строки данных
        dataGridViewCountryInfo.Rows.Add("Россия", "Москва", "17 098 242 км²", "Да", "146 миллионов", "Русские", "Евразийская страна");
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }

    private void dataGridViewCountryInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
