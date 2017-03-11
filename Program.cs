using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[5];
            product[0] = new Product(01, "Rau muong", "Day la 1 loai rau xanh", 20.5, 110, Convert.ToDateTime("2/3/2014"));
            product[1] = new Product(02, "Rau toi", "Day la 1 loai rau xanh", 22.2, 65, Convert.ToDateTime("2/3/2014"));
            product[2] = new Product(03, "Cai ngot", "Day la 1 loai rau xanh", 30.8, 0, Convert.ToDateTime("2/3/2014"));

            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] != null)
                    if (product[i].isEmpty() == false)
                    {
                        //product[i].Print();
                    }
            }
            ///////
            Console.WriteLine("Nhap n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Nhap lan luot cac so nguyen : ");
            for(int i=0;i<n;i++) { numbers[i] = Convert.ToInt32(Console.ReadLine()); }
            Console.WriteLine("Danh sach so chan : ");
            Array.ForEach(numbers,x => { if(x%2 == 0) Console.WriteLine(x); });
            Console.WriteLine("Danh sach so le : ");
            Array.ForEach(numbers, x => { if (x%2 != 0) Console.WriteLine(x); });
        }

        
    }

}
