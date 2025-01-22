using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    public partial class FormСountry : System.Windows.Forms.Form
    {
        private List<Country> countries = new List<Country>(); // Список для хранения стран
        public FormСountry()
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




        // Обработчик события для вычисления среднего населения



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
}

