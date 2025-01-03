namespace Lekce_11_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Catalog catalog = new Catalog();

                catalog.AddProduct(new Product("Notebook ", 1500, 1));

                catalog.AddProduct(new Product("Mobil ", 16000, 8));



                List<string> serializedProducts = catalog.SerializeProducts();
                Console.Write("Serializovany list: ");
                foreach (var json in serializedProducts)
                {
                    Console.WriteLine(json);
                }

                string newProductJson = "{\"Name\":\"Tablet\",\"Price\":5000,\"Quantity\":3}"; // divne ze tady u zadani noveho produktu i po zadani zaporne ceny to vyjimka nechytne
                List<string> jsonList = new List<string> { newProductJson};
                catalog.DeserializeProducts(jsonList);


                Console.WriteLine("Deserialized: ");
                foreach (var product in catalog.products)
                {
                    Console.WriteLine(product.Name +"cena: "+  product.Price+" pocet kusu: "+ product.Quantity);
                }


                Console.WriteLine("Vsechny produkty");
                catalog.PrintProducts();
               
            }
            catch (InvalidCastException ex) 
            {
                Console.WriteLine("Necekana chyba jemine ");
            } 
            catch (InvalidProductException ex)
            {
                Console.WriteLine("Chybne zadana cena produktu");
            }
            finally 
            { 
            Console.WriteLine("Tenhle blok kodu je tak moc cool, ze se vzdy spusti");
            }
        }
      
        

    }
}
