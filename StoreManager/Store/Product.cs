using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{

    public class Product
    {
        public string Media {get; set;}
        public int Quantity {get; set;}
        public string productName {get; set;} 
        public double Price {get; set;}
        public int artNr {get; set;}


        public Product()
        {
            Media = "";
            Quantity = 0;
            productName = "";
            Price = 0;
            artNr = 0;
        }
    }
}
