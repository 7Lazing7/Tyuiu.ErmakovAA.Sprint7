using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    public partial class FormStatic : Form
    {
        private List<Country> countries = new List<Country>(); // Список для хранения стран

        public FormStatic()
        {
            InitializeComponent(); // Инициализация компонентов формы
            LoadSampleData(); // Загрузка демонстрационных данных
            PopulateDataGridView(); // Заполнение DataGridView данными
        }

        // Метод для загрузки демонстрационных данных о странах
        private void LoadSampleData()
        {
            countries.Add(new Country { Name = "Россия", Capital = "Москва", Area = 17098242, IsEconomicallyDeveloped = false, Population = 146000000, PredominantNationality = "Русские", Note = "Крупнейшая страна по площади" });
            countries.Add(new Country { Name = "Канада", Capital = "Оттава", Area = 9984670, IsEconomicallyDeveloped = true, Population = 37700000, PredominantNationality = "Канадцы", Note = "Большинство территории покрыто лесом" });
            countries.Add(new Country { Name = "Китай", Capital = "Пекин", Area = 9596960, IsEconomicallyDeveloped = true, Population = 1402000000, PredominantNationality = "Китайцы", Note = "Самая большая по населению страна" });
        }

        // Заполнение DataGridView данными
        private void PopulateDataGridView()
        {
            dataGridViewStat_EAA.DataSource = null;
            dataGridViewStat_EAA.DataSource = countries;
        }

        // Обработчик события для кнопки, строящей диаграмму по площади стран
        private void buttonDiag_EAA_Click(object sender, EventArgs e)
        {
            chartstat_EAA.Series.Clear();
            Series series = new Series("Площадь стран")
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (Country country in countries)
            {
                series.Points.AddXY(country.Name, country.Area);
            }

            chartstat_EAA.Series.Add(series);
        }

        // Обработчик события для вычисления среднего населения
        private void buttonSredOZU_EAA_Click(object sender, EventArgs e)
        {
            if (countries.Count == 0) return;

            double averagePopulation = 0;
            foreach (Country country in countries)
            {
                averagePopulation += country.Population;
            }
            averagePopulation /= countries.Count;
            textBoxSredOZU_EAA.Text = averagePopulation.ToString("N0");
        }

        // Обработчик события для нахождения страны с наибольшим населением
        private void buttonMaxYadra_EAA_Click(object sender, EventArgs e)
        {
            if (countries.Count == 0) return;

            Country mostPopulatedCountry = countries[0];
            foreach (Country country in countries)
            {
                if (country.Population > mostPopulatedCountry.Population)
                {
                    mostPopulatedCountry = country;
                }
            }
            textBoxMaxYadra_EAA.Text = mostPopulatedCountry.Name;
        }
    }

    // Класс Country, содержащий информацию о стране
    public class Country
    {
        public string Name { get; set; } // Название страны
        public string Capital { get; set; } // Столица
        public double Area { get; set; } // Площадь территории
        public bool IsEconomicallyDeveloped { get; set; } // Экономическая развитость
        public int Population { get; set; } // Население
        public string PredominantNationality { get; set; } // Преобладающая национальность
        public string Note { get; set; } // Примечание
    }
}

