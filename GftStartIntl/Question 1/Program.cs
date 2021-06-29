using System;
using System.Collections.Generic;

namespace Question_1
{
    class Program
    {
        private static List<Product> _products = new List<Product>();
        private static Checkout _checkout = new Checkout();
        static void Main(string[] args)
        {
           
            SetUpSampleData();
            PrintProductsData();
        }

        private static  void SetUpSampleData()
        {
            _products.Add(new Product{Name = "Banana", Value = 0.99, Type = 2, Quantity = 3});
            _products.Add(new Product{Name = "Energético", Value = 5.49, Type = 3 ,Quantity = 7 });
            _products.Add(new Product{Name = "Arroz", Value = 20.00, Type = 1, Quantity = 1 });
            _products.Add(new Product{Name = "Chocolate", Value = 4.50, Type = 1, Quantity = 12 });
            _products.Add(new Product{Name = "Leite", Value = 3.73, Type = 3, Quantity = 5 });
            _products.Add(new Product{Name = "Abacaxi", Value = 2.40, Type = 2, Quantity = 1 });
          
        }

        private static void PrintProductsData()
        {
            double _totalCost;
            foreach (var product in _products)
            {
                 _totalCost = _checkout.ComputeFinalValue(product, product.Quantity);
                Console.WriteLine($@" {product.Quantity} {product.Name}   R${Math.Round(_totalCost, 2)}");

            }
        }
    }
}
