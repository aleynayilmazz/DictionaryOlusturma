using System;

namespace DictionaryOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> products = new MyDictionary<string>();//instance oluşturulur.
            products.Add("Ayakkabı");//ürün eklenir
            products.Add("Çanta");
            products.Add("Parfüm");
            products.Add("Kazak");
            //eklenen ürünleri listeleme
            foreach (var product in products.Products)
            {
                Console.WriteLine(product);
            }

            
        }
    }

}
