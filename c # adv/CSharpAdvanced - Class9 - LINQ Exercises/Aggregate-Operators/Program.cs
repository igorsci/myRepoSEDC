using System.Collections.Generic;
using DataFromXml;
using System.Linq;

namespace Aggregate_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Find all orders with 'VINET' Customer ID and print information for Count and Freight

            var ordersWithVinet = orders.Where(o => o.CustomerID == "VINET").ToList();


            System.Console.WriteLine("there are  " + ordersWithVinet.Count() + "orders with cID VINET");
            foreach (var order in ordersWithVinet)
            {
                
                System.Console.WriteLine("freight" + order.Freight);
            }
            //Print the count of all orders per different Customer ID
            var result = orders.GroupBy(o => o.CustomerID).Select(o=> new { Id = o.Key, Count = o.Count() }).ToList();

            //Print the count and total Freight of all orders with 'VINET' Customer ID

            System.Console.WriteLine("there are  " + ordersWithVinet.Count() + "orders with cID VINET");

            double totalFright=0.0;
            foreach (var order in ordersWithVinet)
            {
                
                totalFright  += order.Freight.GetValueOrDefault();
                
            }
            System.Console.WriteLine("total fright" + totalFright);
            // znaci sekogas koristi go getvalueordefault koga rabotish so nulable variable



            //Print the order with 'VINET' Customer ID identified by the minimal Freight 


            var minOrder = orders.Where(o => o.CustomerID.Equals("VINET")).Select(o => new { Name = o.CustomerID, Freight = o.Freight })
                                    .Min(o => o.Freight).Value;
            System.Console.WriteLine(minOrder);

            //foreach (var order in ordersWithVinet)
            //{
            //    var minFri = ordersWithVinet[0].GetValueOrDefault();
            //   if ( minFri < order.Freight.GetValueOrDefault())
            //    {

            //    }

            //}
            //System.Console.WriteLine("min fright" + minFri);

            //Print all orders per different Ship Country identified by the maximum Freight 

            var ordersByCoun = orders.GroupBy(o => o.ShipCountry)
                              .Select(o => new { Customer = o.Key, MaxFright = o.Max(p => p.Freight)});

            foreach (var item in ordersByCoun)
            {
                System.Console.WriteLine(item.Customer + "" + item.MaxFright);
            }

            //Print the average Freight (with two decimals) for all orders

            var ordersByCounandmax = orders.GroupBy(o => o.ShipCountry)
                              .Select(o => new { Customer = o.Key, Avera = o.Average(p => p.Freight) });

            foreach (var item in ordersByCounandmax)
            {
                System.Console.WriteLine(item.Customer + "" + item.Avera);
            }

            System.Console.ReadLine();
        }
    }
}