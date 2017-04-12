﻿using System;
using System.Collections.Generic;
using System.IO;
using BusinessLogic;
using Newtonsoft.Json;

namespace View
{
    public static class Project
    {
        public static List<IDiscount> DiscountList = new List<IDiscount>();
        public static List<Product> PriceList = new List<Product>();
        public static List<Product> ProductList = new List<Product>();

        public static string DiscountListFilePath = @"C:\DS_data\DiscountList\DiscountList.dss";
        public static string PriceListFilePath = @"C:\DS_data\PriceList\PriceList.dss";
        public static string ProductListFilePath = @"C:\DS_data\ProductList\ProductList.dss";

        public static double ResultPrice = 0;
        
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
