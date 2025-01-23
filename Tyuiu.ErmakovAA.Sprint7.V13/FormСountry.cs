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
            countries.Add(new Country { Страна = "Россия", Столица = "Москва", Площадь = 17098242, Экономика = false, Население = 146000000, Национальность = "Русские" });
            countries.Add(new Country { Страна = "Канада", Столица = "Оттава", Площадь = 9984670, Экономика = true, Население = 37700000, Национальность = "Канадцы" });
            countries.Add(new Country { Страна = "Китай", Столица = "Пекин", Площадь = 9596960, Экономика = false, Население = 1402000000, Национальность = "Китайцы" });
            countries.Add(new Country { Страна = "Япония", Столица = "Токио", Площадь = 377969, Экономика = true, Население = 124342000, Национальность = "Японцы," });
            countries.Add(new Country { Страна = "США", Столица = "Вашингтон", Площадь = 9833517, Экономика = true, Население = 331108434, Национальность = "Американцы" });
            countries.Add(new Country { Страна = "Мексика", Столица = "Мехико", Площадь = 1972550, Экономика = false, Население = 133649565, Национальность = "Мексиканцы" });
            countries.Add(new Country { Страна = "Таиланд", Столица = "Бангкок", Площадь = 513120, Экономика = true, Население = 65969270, Национальность = "Таиландцы" });
            countries.Add(new Country { Страна = "Бразилия", Столица = "Бразилиа", Площадь = 8515, Экономика = false, Население = 220051512, Национальность = "Брази́льцы" });
            countries.Add(new Country { Страна = "ЮАР", Столица = "Претория", Площадь = 1219090, Экономика = false, Население = 60604992, Национальность = "Африканцы" });
            countries.Add(new Country { Страна = "Армения", Столица = "Ереван", Площадь = 29800, Экономика = false, Население = 3039700, Национальность = "Армяне" });

        }


           
            

        // Заполнение DataGridView данными
        private void PopulateDataGridView()
        {
            dataGridViewStat_EAA.DataSource = null;
            dataGridViewStat_EAA.DataSource = countries;
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
       

        private void dataGridViewStat_EAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

