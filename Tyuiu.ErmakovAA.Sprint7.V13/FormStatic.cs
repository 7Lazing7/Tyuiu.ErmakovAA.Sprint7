using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    public partial class FormStatic : System.Windows.Forms.Form
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
            countries.Add(new Country { Страна = "Россия", Столица = "Москва", Площадь = 17098242, Экономика = false, Население = 146000000, Национальность = "Русские" });
            countries.Add(new Country { Страна = "Таиланд", Столица = "Бангкок", Площадь = 513120, Экономика = true, Население = 65969270, Национальность = "Таиландцы" });
            countries.Add(new Country { Страна = "Канада", Столица = "Оттава", Площадь = 9984670, Экономика = true, Население = 37700000, Национальность = "Канадцы" });
            countries.Add(new Country { Страна = "Армения", Столица = "Ереван", Площадь = 29800, Экономика = false, Население = 3039700, Национальность = "Армяне" });
            countries.Add(new Country { Страна = "Китай", Столица = "Пекин", Площадь = 9596960, Экономика = false, Население = 1402000000, Национальность = "Китайцы" });
            countries.Add(new Country { Страна = "Япония", Столица = "Токио", Площадь = 377969, Экономика = true, Население = 124342000, Национальность = "Японцы," });
            countries.Add(new Country { Страна = "США", Столица = "Вашингтон", Площадь = 9833517, Экономика = true, Население = 331108434, Национальность = "Американцы" });
            countries.Add(new Country { Страна = "Мексика", Столица = "Мехико", Площадь = 1972550, Экономика = false, Население = 133649565, Национальность = "Мексиканцы" });
            countries.Add(new Country { Страна = "ЮАР", Столица = "Претория", Площадь = 1219090, Экономика = false, Население = 60604992, Национальность = "Африканцы" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
            countries.Add(new Country { Страна = "", Столица = "", Национальность = "" });
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
                point.SetValueXY(country.Страна, country.Площадь);
                point.Label = ""; // Убираем метки с именами стран
                point.LegendText = country.Страна;
                series.Points.Add(point);
                chartstat_EAA.Legends[0].Enabled = false;

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
                averagePopulation += country.Население;
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
                if (country.Население > mostPopulatedCountry.Население)
                {
                    mostPopulatedCountry = country;
                }
            }
            textBoxMaxYadra_EAA.Text = mostPopulatedCountry.Страна;
        }

        private void chartstat_EAA_Click(object sender, EventArgs e)
        {
            if (countries.Count == 0) return;

            double averagePopulation = 0;
            foreach (Country country in countries)
            {
                averagePopulation += country.Население;
            }
            averagePopulation /= countries.Count;
            textBoxSredOZU_EAA.Text = averagePopulation.ToString("N0");

        }
    }

    // Класс Country, содержащий информацию о стране
    public class Country
    {
        public string Страна { get; set; } // Название страны
        public string Столица { get; set; } // Столица
        public double Площадь { get; set; } // Площадь территории
        public bool Экономика { get; set; } // Экономическая развитость
        public int Население { get; set; } // Население
        public string Национальность { get; set; } // Преобладающая национальность

    }
}

