using System.Collections.Generic;
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
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadCountriesIntoDataGridView();


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



        private void buttonSortAlp_EAA_Click(object sender, EventArgs e)
        {
            dataGridViewIn_EAA.Sort(dataGridViewIn_EAA.Columns[0], ListSortDirection.Ascending); //сортировка названий
        }

        public class NumericComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                // Приведение данных из ячеек к строке
                string value1 = ((DataGridViewRow)x).Cells[0].Value?.ToString();
                string value2 = ((DataGridViewRow)y).Cells[0].Value?.ToString();

                // Попытка преобразования строки в число
                if (int.TryParse(value1, out int num1) && int.TryParse(value2, out int num2))
                {
                    return num1.CompareTo(num2);
                }

                // Если одно из значений не число, сортировать как строки
                return string.Compare(value1, value2);
            }
        }



        private void buttonSortData_EAA_Click(object sender, EventArgs e)
        {
            // Указываем индекс столбца, исходя из данных (в данном примере 3)
            dataGridViewIn_EAA.Sort(new CustomColumnSorter(4));
        }

        private void buttonS_EAA_Click(object sender, EventArgs e)
        {
            // Указываем индекс столбца, исходя из данных (в данном примере 2)
            dataGridViewIn_EAA.Sort(new CustomColumnSorter(2));
        }

        public class CustomColumnSorter : System.Collections.IComparer
        {
            private int columnIndex;

            public CustomColumnSorter(int columnIndex)
            {
                this.columnIndex = columnIndex;
            }

            public int Compare(object x, object y)
            {
                string value1 = ((DataGridViewRow)x).Cells[columnIndex].Value?.ToString();
                string value2 = ((DataGridViewRow)y).Cells[columnIndex].Value?.ToString();

                if (int.TryParse(value1, out int num1) && int.TryParse(value2, out int num2))
                {
                    return num1.CompareTo(num2);
                }

                return string.Compare(value1, value2);
            }
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

            string str = "Страна, Столица, Площадь, Экономика, Население, Национальность\n";
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
        private void buttonHelp_SBI_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
        private void buttonСountry_EAA_Click(object sender, EventArgs e)
        {
            FormСountry formСountry = new FormСountry();
            formСountry.ShowDialog();
        }

        private void buttonStat_EAA_Click(object sender, EventArgs e)
        {
            FormStatic formstat = new FormStatic();
            formstat.ShowDialog();
        }
        private void buttonNew_EAA_Click(object sender, EventArgs e)
        {
            FormMain formstat = new FormMain();
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

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewIn_EAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public class Country
        {
            public string Name { get; set; }
            public string Capital { get; set; }
            public double Area { get; set; }
            public bool Economicall { get; set; }
            public int Population { get; set; }
            public string Nationality { get; set; }
        }

        private List<Country> countries = new List<Country>
        {
             new Country { Name = "Россия", Capital = "Москва", Area = 17098242, Economicall = false, Population = 146000000, Nationality = "Русские" },
             new Country { Name = "Канада", Capital = "Оттава", Area = 9984670, Economicall = true, Population = 37700000, Nationality = "Канадцы" },
             new Country { Name = "Китай", Capital = "Пекин", Area = 9596960, Economicall = true, Population = 1402000000, Nationality = "Китайцы" },
             new Country { Name = "Япония", Capital = "Токио", Area = 377969, Economicall = true, Population = 124342000, Nationality = "Японцы" },
             new Country { Name = "США", Capital = "Вашингтон", Area = 9833517, Economicall = true, Population = 331108434, Nationality = "Американцы" },
             new Country { Name = "Мексика", Capital = "Мехико", Area = 1972550, Economicall = true, Population = 133649565, Nationality = "Мексиканцы" },
             new Country { Name = "Таиланд", Capital = "Бангкок", Area = 513120, Economicall = true, Population = 65969270, Nationality = "Таиландцы" },
             new Country { Name = "Бразилия", Capital = "Бразилиа", Area = 8515, Economicall = true, Population = 220051512, Nationality = "Брази́льцы" },
             new Country { Name = "ЮАР", Capital = "Претория", Area = 1219090, Economicall = true, Population = 60604992, Nationality = "Африканцы" },
             new Country { Name = "Армения", Capital = "Ереван", Area = 29800, Economicall = true, Population = 3039700, Nationality = "Армяне" },
             

        };
       

        private void LoadCountriesIntoDataGridView()
        {
            dataGridViewIn_EAA.Rows.Clear();
            dataGridViewIn_EAA.Columns.Clear();

            dataGridViewIn_EAA.Columns.Add("Name", "Страна");
            dataGridViewIn_EAA.Columns.Add("Capital", "Столица");
            dataGridViewIn_EAA.Columns.Add("Area", "Площадь");
            dataGridViewIn_EAA.Columns.Add("Economicall", "Экономика");
            dataGridViewIn_EAA.Columns.Add("Population", "Население");
            var nationalityColumn = dataGridViewIn_EAA.Columns.Add("Nationality", "Национальность");

            // Установите ширину столбца "Национальность" равной 130
            dataGridViewIn_EAA.Columns["Nationality"].Width = 130;
            dataGridViewIn_EAA.Columns["Capital"].Width = 110;
            dataGridViewIn_EAA.Columns["Population"].Width = 110;
            dataGridViewIn_EAA.Columns["Area"].Width = 110;
            foreach (var country in countries)
            {
                dataGridViewIn_EAA.Rows.Add(country.Name, country.Capital, country.Area, country.Economicall, country.Population, country.Nationality);
            }
        }

      

    }
}