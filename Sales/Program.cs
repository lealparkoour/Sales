using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "cellphones";
            p1.Price= 120000;

            Product p2 = new Product();
            p2.Name = "headphones";
            p2.Price = 150000;

            Product p3 = new Product();
            p3.Name = "case for cell phone";
            p3.Price = 180000;

            SalesMan_Seller s1 = new SalesMan_Seller();
            s1.Name = "Andres";
            s1.Age = 25;
            

            SalesMan_Seller s2 = new SalesMan_Seller();
            s2.Name = "Milena";
            s2.Age = 21;

            SalesMan_Seller s3 = new SalesMan_Seller();
            s3.Name = "lina";
            s3.Age = 20;


            Sale sale = new Sale();
            sale.SalesMan = s1;
            sale.Product = p1;
            sale.Comments = "without discount";

            Sale sale1 = new Sale();
            sale1.SalesMan = s2;
            sale1.Product = p2;
            sale1.Comments = "without discount";

            Sale sale2 = new Sale();
            sale2.SalesMan = s3;
            sale2.Product = p3;
            sale2.Comments = "without discount";



            double Total = sale.Product.Price + sale1.Product.Price + sale2.Product.Price;




            System.Console.WriteLine("Sales total amount: " + Total);

            System.Console.WriteLine("sales made by:\n" + sale.SalesMan.Name + "\n" + sale1.SalesMan.Name + "\n" + sale2.SalesMan.Name);

        }

    }
}
