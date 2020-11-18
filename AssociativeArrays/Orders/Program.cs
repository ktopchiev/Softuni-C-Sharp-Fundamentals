using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            while (true)
            {
               var inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
               Dictionary<double, int> priceAndQuantity = new Dictionary<double, int>();
               
               if (inputArr[0] == "buy")
               {
                   foreach (var stock in products.Keys)
                   {
                       var stockKeyValue = products[stock];
                       
                       foreach (var qKey in stockKeyValue.Keys)
                       {
                           Console.WriteLine($"{stock} -> {qKey * stockKeyValue[qKey]:f2}");
                       }
                   }
                   break;
               }
               
               string product = inputArr[0];
               double price = double.Parse(inputArr[1]);
               int quantity = int.Parse(inputArr[2]);
               
               if (products.ContainsKey(product))
               {
                   var productPriceAndQuantity = products[product];
                   var productPrice = productPriceAndQuantity.FirstOrDefault().Key;
                   
                   productPriceAndQuantity[productPrice] += quantity;
                   
                   if (productPrice != price)
                   {
                       ReplaceKey(productPriceAndQuantity, productPrice, price);
                   }
               }
               else
               {
                    
                   priceAndQuantity.Add(price, quantity);
                   products.Add(product, priceAndQuantity);   
               }
            }
        }
        
        private static void ReplaceKey<TKey, TValue>(IDictionary<TKey, TValue> dic, TKey fromKey, TKey toKey)
        {
            TValue value = dic[fromKey];
            dic.Remove(fromKey);
            dic[toKey] = value;
        }
    }
}