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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfoMe_EAA_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void textBoxFind_EAA_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxFind_EAA.Text.ToLower(); //чувствительность к регистру

            foreach (DataGridViewRow row in dataGridViewIn_EAA.Rows)
            {
                if (row.IsNewRow) continue; // проверка добавленных строк

                bool found = false;

                for (int j = 0; j < dataGridViewIn_EAA.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found; // видимость\невидимость строк
            }
        }

        //метод чтения данных из файла
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }

        private void LoadDataIntoDataGridView(string filePath)
        {
            // загружаем данные из файла с помощью метода LoadFromFileData
            string[,] dataArray = LoadFromFileData(filePath);

            // очищаем DataGridView перед загрузкой новых данных
            dataGridViewIn_EAA.Rows.Clear();
            dataGridViewIn_EAA.Columns.Clear();

            // добавляем столбцы в DataGridView
            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewIn_EAA.Columns.Add("", dataArray[0, i]);
            }

            // добавляем строки с данными из CSV файла
            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewIn_EAA.Rows.Add(rowData.ToArray());
            }
        }

        private void buttonAdd_EAA_Click(object sender, EventArgs e)
        {
            // получаем путь к файлу с помощью окна
            OpenFileDialog openFileDialog_EAA = new OpenFileDialog();
            openFileDialog_EAA.Filter = "csv Files|*.csv";              // фильтр для отображения только csv файлов
            if (openFileDialog_EAA.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_EAA.FileName;
                LoadDataIntoDataGridView(filePath);   // загружаем данные в DataGridView с помощью метода LoadDataIntoDataGridView
            }
            buttonSortData_EAA.Enabled = true;
            buttonSave_EAA.Enabled = true;
            buttonStat_EAA.Enabled = true;
            buttonSortAlp_EAA.Enabled = true;
        }

        private void buttonFirma_EAA_Click(object sender, EventArgs e)
        {
            FormMain formfirms = new FormMain();
            formfirms.ShowDialog();
        }

        private void buttonSortAlp_EAA_Click(object sender, EventArgs e)
        {
            dataGridViewIn_EAA.Sort(dataGridViewIn_EAA.Columns[0], ListSortDirection.Ascending); //сортировка названий
        }

        private void buttonSortData_EAA_Click(object sender, EventArgs e)
        {
            dataGridViewIn_EAA.Sort(dataGridViewIn_EAA.Columns[6], ListSortDirection.Ascending); //сортировка по году
        }

        private void buttonSave_EAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_EAA.FileName = "OutPutIVM.csv";
            saveFileDialog_EAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_EAA.ShowDialog();

            string path = saveFileDialog_EAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewIn_EAA.RowCount;
            int columns = dataGridViewIn_EAA.ColumnCount;

            string str = "Название,Фирма,Процессор,Количество ядер,Объем ОЗУ (ГБ),Диагональ,Дата выпуска\n";
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewIn_EAA.Rows[i].Cells[j].Value + ",";
                    }
                    else
                    {
                        str = str + dataGridViewIn_EAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes) //открытие файла
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonStat_EAA_Click(object sender, EventArgs e)
        {
            FormStatic formstat = new FormStatic();
            formstat.ShowDialog();
        }

        private void groupBoxSearch_EAA_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuExit_EAA_Click(object sender, EventArgs e)
        {
            Close();
        }
   
    
    }
}