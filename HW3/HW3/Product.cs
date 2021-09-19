using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Product
    {

        public Product(double productLength, double productWidth, double productWeight)       //konstruktors
        {
            Length = productLength;
            Width = productWidth;
            Weight = productWeight;
        }

        public double Length { get; }   //field

        public double Width { get; }   //field

        public double Weight { get; }   //field

        public string Create()             //method
        {
            string createProduct = "Jauns produkts ir izveidots.";
            return createProduct;
        }
        public string Show(double productLength, double productWidth, double productWeight)               //method
        {
            string showProduct = "Izveidotās preces parametri ir: " + productLength 
                                                              + "cm, " + productWidth 
                                                              + "cm, " + productWeight 
                                                              + "kg.";
            return showProduct;
        }
    }
}
