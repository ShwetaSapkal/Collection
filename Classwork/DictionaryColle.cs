using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class DictionaryColle
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(91,"India");

            foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }

            Dictionary<int, Product> list = new Dictionary<int, Product>();
            list.Add(1, new Product { Id=1,Name = "mouse", Price = 899 });

            foreach (KeyValuePair<int, Product> item in list)
            {
                Console.WriteLine($"{item.Key}{item.Value.Name}{item.Value.Price}");
            }
        }
    }
}
