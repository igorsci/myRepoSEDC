using System;
using System.Collections.Generic;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>(); 

        public Module() { }
        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part); 
        }

        public double GetPrice()
        {
            double price = 0;
            // TODO: Implement the GetPrice() method for the Modules
            foreach (var item in _parts)
            {
                price += item.Price * item.Quantity;
            }
            return price;
        }

        public void  SetDiscount(double discount)
        {
            // TODO: Implement the SetDiscount() method for the Modules
            /*
             * The percentage is a number in the range [0,100]. 5% == 0.05, 10% == 0.1
             * The method should set the Discount property to values between [0.00, 1.00]
             */
            if (discount < 0 )
            {
                Discount = 0;
                
            }
            else if (discount > 100)
            {
                Discount = 0;
            }
            else
            {
                Discount = discount / 100;
            }

            
        }

        public double GetPriceWithDiscount()
        { 
            return GetPrice() * (1 - Discount);
        }
    }
}
