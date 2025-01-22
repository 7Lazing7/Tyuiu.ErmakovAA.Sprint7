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
            countries.Add(new Country { Name = "Россия", Capital = "Москва", Area = 17098242, Economicall = false, Population = 146000000, Nationality = "Русские" });
            countries.Add(new Country { Name = "Канада", Capital = "Оттава", Area = 9984670, Economicall = true, Population = 37700000, Nationality = "Канадцы" });
            countries.Add(new Country { Name = "Китай", Capital = "Пекин", Area = 9596960, Economicall = true, Population = 1402000000, Nationality = "Китайцы" });
            countries.Add(new Country { Name = "Япония", Capital = "Токио", Area = 377969, Economicall = true, Population = 124342000, Nationality = "Японцы," });
            countries.Add(new Country { Name = "США", Capital = "Вашингтон", Area = 9833517, Economicall = true, Population = 331108434, Nationality = "Американцы" });
            countries.Add(new Country { Name = "Мексика", Capital = "Мехико", Area = 1972550, Economicall = true, Population = 133649565, Nationality = "Мексиканцы" });
            countries.Add(new Country { Name = "Таиланд", Capital = "Бангкок", Area = 513120, Economicall = true, Population = 65969270, Nationality = "Таиландцы" });
           
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
                DataPoint point = new DataPoint();
                point.SetValueXY(country.Name, country.Area);
                point.Label = ""; // Убираем метки с именами стран
                point.LegendText = country.Name;
                series.Points.Add(point);
                chartstat_EAA.Legends[0].Enabled = true;
               
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

        private void chartstat_EAA_Click(object sender, EventArgs e)
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
    }

    // Класс Country, содержащий информацию о стране
    public class Country
    {
        public string Name { get; set; } // Название страны
        public string Capital { get; set; } // Столица
        public double Area { get; set; } // Площадь территории
        public bool Economicall { get; set; } // Экономическая развитость
        public int Population { get; set; } // Население
        public string Nationality { get; set; } // Преобладающая национальность
      
    }
}

