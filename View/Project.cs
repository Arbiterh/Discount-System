using System;
using System.Collections.Generic;
using System.IO;
using BusinessLogic;
using Newtonsoft.Json;

namespace View
{
    /// <summary>
    /// Класс, хранящий все списки данных и пути сохранения, а так же методы сериализации
    /// </summary>
    public static class Project
    {
        /// <summary>
        /// Список скидок
        /// </summary>
        public static List<IDiscount> DiscountList = new List<IDiscount>();
        /// <summary>
        /// Список всех возможных товаров
        /// </summary>
        public static List<Product> PriceList = new List<Product>();
        /// <summary>
        /// Список товаров для покупки
        /// </summary>
        public static List<Product> ProductList = new List<Product>();

        /// <summary>
        /// Стандартный путь расположения списка скидок
        /// </summary>
        public static string DiscountListFilePath = @"C:\DS_data\DiscountList\DiscountList.dss";
        /// <summary>
        /// Стандартный путь расположения списка всех возможных товаров
        /// </summary>
        public static string PriceListFilePath = @"C:\DS_data\PriceList\PriceList.dss";
        /// <summary>
        /// Стандартный путь расположения списка товаров для покупки
        /// </summary>
        public static string ProductListFilePath = @"C:\DS_data\ProductList\ProductList.dss";

        /// <summary>
        /// Суммарная цена товаров в корзине с учётом скидки
        /// </summary>
        public static double ResultPrice = 0;
        /// <summary>
        /// Найденная в списке скидка для рассчета cуммарной цены товаров в корзине
        /// </summary>
        public static IDiscount Discount;
        /// <summary>
        /// Изначальная точка генерации случайного числа, предназначена для тестирования
        /// </summary>
        public static readonly Random Rnd = new Random();

        public static bool OkButtonEnabledDiscountForm = false;
        public static bool AddButtonEnabledProductForm = false;

        /// <summary>
        /// Метод, сохраняющий список по указанному пути в виде строки
        /// </summary>
        /// <typeparam name="T">Ссылка</typeparam>
        /// <param name="container">Контейнер для сохранения</param>
        /// <param name="filePath">Путь сохранения</param>
        public static void Serialize<T>(ref T container, string filePath)
        {
            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            using (var sw = new StreamWriter(filePath))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, container, typeof(T));
                }
            }
        }
        /// <summary>
        /// Метод, загружающий список в контейнер по указанному пути в виде строки
        /// </summary>
        /// <typeparam name="T">Ссылка</typeparam>
        /// <param name="container">Контейнер для загрузки</param>
        /// <param name="filePath">Путь загрузки</param>
        public static void Deserialize<T>(ref T container, string filePath)
        {
            try
            {
                if (container == null)
                {
                    throw new ArgumentNullException(nameof(container));
                }
                container = JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented,
                });
            }
            catch (FileNotFoundException)
            {
            }
        }
    }
}
