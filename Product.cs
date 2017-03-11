using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi1
{
    class Product
    {
        private int ProductID;
        private string ProductName;
        private string Description;
        private double Price;
        private int Stock;
        private DateTime PublicDate;
        //Constructor khởi tạo
        public Product(int ID,string name,string desc,double price,int stock,DateTime pubdate)
        {
            this.ProductID = ID;
            this.ProductName = name;
            this.Description = desc;
            this.Price = price;
            this.Stock = stock;
            this.PublicDate = pubdate;
        }

        public bool isEmpty()
        {
            if (Stock <= 0)
                return true;
            else
                return false;
        }

        public void Print()
        {
            Console.WriteLine("--- "+"ProductID: "+ProductID+" --- \n");
            Console.WriteLine("- " + "Name: "+ProductName+"\n"+
                                "- " + "Description: "+Description+"\n"+
                                "- " + "Price: "+Price+"\n"+
                                "- " + "Stock: "+Stock+"\n"+
                                "- " + "Public Date: "+PublicDate+"\n"+
                                "\n"
                );
        }
    }
}
