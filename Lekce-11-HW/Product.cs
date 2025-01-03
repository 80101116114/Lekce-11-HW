
using System.Text;

namespace Lekce_11_HW
{

    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Product() { }

        public Product(string name, int price, int quantity) 
        {
            if (price < 0)
            {
                throw new InvalidProductException("Cena nemuze byt zaporna");
            }
        Name = name;
        Price = price;
        Quantity = quantity;
        }
       
        


    }
}
