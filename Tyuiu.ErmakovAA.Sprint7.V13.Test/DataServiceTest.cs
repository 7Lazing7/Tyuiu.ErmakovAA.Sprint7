using Tyuiu.ErmakovAA.Sprint7.V13.Lib;
namespace Tyuiu.ErmakovAA.Sprint7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidParse()
        {
            DataService dataService = new DataService();

            List<string[]> routes = dataService.ParseRouteItems(@"test.csv");
            List<string[]> routesWait = new List<string[]>
            {
                {new string[]{"1","Энтузиастов|Детский сад №62|Центр русской культуры|Домостроителей|Губкина|Элеваторная|Гилёвская|Барабинская|Областная ГИБДД|Одесская|Травматология|Сквер Гимназистов|Родильный дом №2|Школа №37|Фабричная|Холодильная|Максима Горького|Сквер им. Немцова|пл. Центральная|Первомайская|Смоленская|Сквер Семёна Пацко|Налоговая инспекция|Ипподром|Президентское кадетское училище|Таврическая|Школа №73","Автобус","10:30 | 10:33 | 09:57 | 09:57 | 10:00 | 10:02 | 10:03 | 10:05 | 10:08 | 10:10 | 10:12 | 10:15 | 10:17 | 10:18 | 10:21 | 10:23 | 1 | 4 | 6 | 8 | 10 | 13 | 14 | 16 | 17 | 18 | 10:19" } },
                {new string[]{"62","Школа №63|Восточный микрорайон|Монтажников|Сквер Тружеников Тыла|Управа Восточного округа","Маршрутка/Автобус","10|10|15|17|20","true"} }
            };
            CollectionAssert.Equals(routes, routesWait);
        }
    }
}