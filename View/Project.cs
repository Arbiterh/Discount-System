using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using BusinessLogic;

namespace View
{
    public class Project
    {
        //public static void Serialize(object obj, string _filePath)
        //{
        //    var writer = new System.Xml.Serialization.XmlSerializer(typeof(object));
        //    using (var file = System.IO.File.Create(_filePath))
        //    {
        //        writer.Serialize(file, obj);
        //        file.Close();
        //    }


            public static void Serialize(List<Product> list , string filePath)
            { 
                var serializer = new XmlSerializer(typeof(List<Product>)); 
                var writer = new StreamWriter(filePath);
                serializer.Serialize(writer, list);
                writer.Close();
            }

        public static void Serialize(List<IDiscount> list, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<IDiscount>));
            var writer = new StreamWriter(filePath);
            serializer.Serialize(writer, list);
            writer.Close();
        }

        public static void Deserialize(List<Product> list, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Product>));  
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate); 
            if (fileStream.Length != 0)
                list = (List<Product>) serializer.Deserialize(fileStream);
        }

        public static void Deserialize(List<IDiscount> list, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<IDiscount>));
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
            if (fileStream.Length != 0)
                list = (List<IDiscount>)serializer.Deserialize(fileStream);
        }
    }
}
