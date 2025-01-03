
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Lekce_11_HW
{
    internal class Catalog
    {
        public List<Product> products = new List<Product>();
        public Catalog()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        { products.Add(product); }
       
        public List<string> SerializeProducts()
        {
            var jsonList = new List<string>();
            foreach (var product in products)
            {
                string json = JsonSerializer.Serialize(product);
                jsonList.Add(json);
            }
            return jsonList;

        }
        public void DeserializeProducts(List<string> jsonList)
        {
            foreach (var json in jsonList)
            {
                try
                {
                    var product = JsonSerializer.Deserialize<Product>(json);
                    if (product.Price == 0)
                    {
                       throw new InvalidProductException("Cena nemuze byt zaporna");
                    }
                    products.Add(product);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine("Neco se pokazilo pri deserializaci");
                }
                catch (InvalidProductException ex)
                {
                    Console.WriteLine($"Cena nemuze byt zaporna: {ex.Message}");
                }

            }

        }
        public void PrintProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Nazev: {product.Name}, cena: {product.Price}, pocet: {product.Quantity}");// trochu jiny zapis nez pres "  " + "   " 
            }
        }
    }
}
