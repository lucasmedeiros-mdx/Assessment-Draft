using System;

namespace Assessment
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case "FedEx":
                    return CalculateForFedEx(order);

                case "UPS":
                    return CalculateForUPS(order);

                case "Schenker":
                    return CalculateForSchenker(order);

                default:
                    throw new Exception("Unknown carrier");

            }

        }

        double CalculateForSchenker(Order order)
        {
            return order.ProductArea > 100 ? 8d : 3d;
        }

        double CalculateForUPS(Order order)
        {
            return order.ProductArea > 100 ? 6d : 4.25d;
        }

        double CalculateForFedEx(Order order)
        {
            return 5.00d;
        }
    }

    public class Order
    {
        public string ShippingMethod { get; set; }

        public decimal ProductArea { get; set; }
    }
}
