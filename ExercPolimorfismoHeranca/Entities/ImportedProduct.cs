using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercPolimorfismoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFree { get; set; }
        private double _totalPrice = 0.0;
        
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFree) :base(name, price)
        {
            CustomFree = customFree;
        }

        public override string PriceTag()
        {                       
            return Name + "$" + TotalPrice() + "(Customs fee: $" + CustomFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomFree;
        }

    }
}
