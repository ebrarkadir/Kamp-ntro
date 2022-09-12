namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "masa";
            product1.CategoryID = 2;
            product1.UnitPrice = 500;
            product1.UnitInStcok = 3;

            // iki şekilde yazabiliriz. 

            Product product2 = new Product { Id = 2, CategoryID = 5, UnitInStcok = 5, ProductName = "kalem", UnitPrice = 35 };

            //PascalCase   //camelCase isimlendirme kuralları.
            ProductManager productManeger = new ProductManager();
            productManeger.Add(product1);
            Console.WriteLine(product1.ProductName);



            productManeger.Topla2(3, 6);
            //returnu tekrar kullanabiliyoruz.
            int toplamasonucu = productManeger.Topla(3, 6);
            Console.WriteLine(toplamasonucu*2);
            

        }
    }
}