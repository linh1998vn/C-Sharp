using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Product
    {
        public string productId;
        public string name;
        public float price;

        public Product(string productId, string name, float price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
        }
        public Product()
        {
            this.productId = "Id default";
            this.name = "name default";
            this.price = 0;
        }

        public void NhapTT()
        {
            Console.WriteLine("Nhap thong tin san pham");
            Console.Write("Nhap product ID: ");
            this.productId = Console.ReadLine();

            Console.Write("Nhap product Name: ");
            this.productId = Console.ReadLine();

            Console.Write("Nhap product Price: ");
            try
            {
                this.price = float.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                this.price = 0;
            }
        }

        public string HienThi()
        {
            return $"Id: {this.productId}  |  Name: {this.name}  \t|  Price: ${this.price}";
        }

    }
}