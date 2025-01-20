using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using ClassLibrary1;
namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public string? openFilePath;

        public List<string[]>? items;

        int rows;
        const int COLUMNS = 5;

        int rowFocusIndex;

        DataService dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();

            saveFileDialog_SBI.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                buttonOpenFile_SBI.Focus();
            }));

            dataGridViewRoutes_SBI.RowCount = 14;
            dataGridViewFeatures_SBI.RowCount = 14;
        }



        private void ToolStripMenuExit_SBI_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonOpenFile_SBI_Click(object sender, EventArgs e)
        {
            openFileDialog_SBI.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            openFileDialog_SBI.ShowDialog();
            if (File.Exists(openFileDialog_SBI.FileName))
            {
                openFilePath = openFileDialog_SBI.FileName;


                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Length < 4 || !int.TryParse(items[i][0], out _))
                    {
                        MessageBox.Show("Íåâåðíûå äàííûå â ôàéëå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                SetItemsToGrid(items);

                for (int i = 0; i < rows; i++)
                {
                    if (items[i].Count() == 5)
                    {
                        try
                        {
                            if (Convert.ToBoolean(items[i][4])) AddRowToFeature(i);
                        }
                        catch
                        {
                            MessageBox.Show("Íåâåðíûå äàííûå â ôàéëå (îïöèÿ \"Èçáðàííîå\n íå ÿâëÿåòñÿ bool çíà÷åíèåì)", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                buttonSaveFile_SBI.Enabled = true;
                buttonUpdateFile_SBI.Enabled = true;

                ToolStripMenuOpenNewFileTool_SBI.Enabled = true;
                ToolStripMenuOpenFile_SBI.Enabled = true;
                ToolStripMenuRefresh_SBI.Enabled = true;
                ToolStripMenuSaveFile_SBI.Enabled = true;
            }

        }

        private void SetItemsToGrid(List<string[]> items)
        {
            rows = items.Count;

            dataGridViewRoutes_SBI.RowCount = rows;
            dataGridViewRoutes_SBI.ColumnCount = COLUMNS - 1;

            dataGridViewFeatures_SBI.RowCount = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] routes = items[i][1].Split('|');
                dataGridViewRoutes_SBI.Rows[i].Cells[0].Value = items[i][0];
                dataGridViewRoutes_SBI.Rows[i].Cells[1].Value = routes[0];
                dataGridViewRoutes_SBI.Rows[i].Cells[2].Value = routes[^1];
                dataGridViewRoutes_SBI.Rows[i].Cells[3].Value = items[i][2];
            }
        }

        private void buttonSaveFile_SBI_Click(object sender, EventArgs e)
        {
            saveFileDialog_SBI.FileName = "file.csv";
            saveFileDialog_SBI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SBI.ShowDialog();

            string path = saveFileDialog_SBI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < COLUMNS - 1; j++)
                {
                    if (j != COLUMNS - 1)
                    {
                        str += dataGridViewRoutes_SBI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewRoutes_SBI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonUpdateFile_SBI_Click(object sender, EventArgs e)
        {

            SetItemsToGrid(items);
        }

        private void buttonSetFeature_SBI_Click(object sender, EventArgs e)
        {
            if (dataGridViewFeatures_SBI.RowCount != 0)
            {
                for (int i = 0; i < dataGridViewFeatures_SBI.RowCount; i++)
                {
                    if ((string)dataGridViewFeatures_SBI.Rows[i].Cells[0].Value == items[rowFocusIndex][0]) return;
                }
            }

            AddRowToFeature(rowFocusIndex);

            buttonSetFeature_SBI.Enabled = false;
        }
        private void AddRowToFeature(int index)
        {
            int indexRow = dataGridViewFeatures_SBI.RowCount;
            dataGridViewFeatures_SBI.RowCount += 1;
            dataGridViewFeatures_SBI.Rows[indexRow].Cells[0].Value = dataGridViewRoutes_SBI.Rows[index].Cells[0].Value;
            dataGridViewFeatures_SBI.Rows[indexRow].Cells[1].Value = dataGridViewRoutes_SBI.Rows[index].Cells[1].Value;
            dataGridViewFeatures_SBI.Rows[indexRow].Cells[2].Value = dataGridViewRoutes_SBI.Rows[index].Cells[2].Value;
            dataGridViewFeatures_SBI.Rows[indexRow].Cells[3].Value = dataGridViewRoutes_SBI.Rows[index].Cells[3].Value;
        }

        private void dataGridViewRoutes_SBI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowFocusIndex = e.RowIndex;

                buttonSetFeature_SBI.Enabled = true;
                buttonOpenRoute_SBI.Enabled = true;

                labelRowFocusIndex_SBI.Text = rowFocusIndex.ToString();
            }
        }

        private void tabControlRoutes_SBI_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlRoutes_SBI.SelectedIndex == 0)
            {
                dataGridViewRoutes_SBI.Sort(dataGridViewRoutes_SBI.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else dataGridViewFeatures_SBI.Sort(dataGridViewFeatures_SBI.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void buttonSearch_SBI_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSearch_SBI.Text, out int number))
            {
                DataGridView dataGrid = tabControlRoutes_SBI.SelectedIndex == 0 ? dataGridViewRoutes_SBI : dataGridViewFeatures_SBI;
                List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[0].Value == null || Convert.ToInt32(row.Cells[0].Value) != number)
                    {
                        rowsToRemove.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rowsToRemove)
                {
                    dataGrid.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ToolStripMenuOpenFile_SBI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = openFilePath;
            txt.Start();
        }



        private DataGridView GetCurrentDataGridView()
        {
            if (tabControlRoutes_SBI.SelectedIndex == 0) return dataGridViewRoutes_SBI;
            else return dataGridViewFeatures_SBI;
        }
        private void ToolStripMenuImages_SBI_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {

            }
        }



        #region MouseEnterTips
        private void buttonOpenFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Îòêðûòèå";
        }

        private void buttonSaveFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Ýêñïîðò";
        }

        private void buttonUpdateFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Îáíîâèòü";
        }

        private void buttonHelp_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Ðóêîâîäñòâî";
        }

        private void textBoxSearch_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Ïîèñê";
        }

        private void buttonOpenRoute_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Îòêðûòü";
        }

        private void buttonSetFeature_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Èçáðàííîå";
        }
        private void buttonHelpImages_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Ðóêîâîäñòâî";
        }
        #endregion

        private void ToolStripMenuItemProgramm_SBI_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemFile_SBI_Click(object sender, EventArgs e)
        {

        }
    }
}
