using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superprofAssignment
{
    public class Ingredient
    {

        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UOM { get; set; }
        public double Scale { get; set; }

        public Ingredient(string name,double quantity,string uom) {
        
            Name = name;
            Quantity = quantity;
            UOM = uom;
            Scale = 1;
        }


    }
}
