using System;
using System.Collections.Generic;
using System.Text;

namespace ExercPolimorfismoHeranca.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManafacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manafacturedDate) : base(name, price)
        {
            ManafacturedDate = manafacturedDate;
        }

        public override string PriceTag()
        {
            //Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
            return  Name + "(used) $" + base.PriceTag() + "(Manufacute date: " + ManafacturedDate.ToString("ddMMyyy");
        }
    }
}
