using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }
}
