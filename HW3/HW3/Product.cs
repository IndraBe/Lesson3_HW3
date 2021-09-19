using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Product
    {

        public Product(double productLength, double productWidth, int productWeight)       //konstruktors
        {
            Length = productLength;
            Width = productWidth;
            Weight = productWeight;
        }

        public double Length { get; }   //field

        public double Width { get; }   //field

        public double Weight { get; }   //field

        public string Create()                  //method
        {
            string createProduct = "Jauns produkts ir izveidots.";
            return createProduct;
        }

        //public string Show()               //method
        //{
        //    string showProduct = "Product length" ;
        //    return showProduct;
        //}
    }
}
