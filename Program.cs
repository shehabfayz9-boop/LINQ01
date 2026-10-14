using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;
using System.Numerics;

namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1:Get all products from the "Seafood" category. Print each product's name and price.

            var products =Source.ProductList.Where(p => p.Category == "Seafood");
            

            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            }




            //Q2:Get a list of only the product names from ProductList. Print each name.
            
            var productNames = Source.ProductList.Select(p => p.ProductName);

            foreach (var name in productNames)
            {
                Console.WriteLine($"Product Name: {name}");
            }


            //Q3:Sort all products by UnitPrice (ascending). Print each product's name and price.
            var Products = Source.ProductList.Where(p => p.UnitPrice>0)
                .OrderByDescending(p => p.UnitPrice);


            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            }


            //Q4: Get all products where UnitPrice is between 10 and 30

            var Productsbetween10and30 = Source.ProductList.Where( p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var product in Productsbetween10and30)
            {
                Console.WriteLine(Productsbetween10and30);

            }


            //Q5:Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
            var productsInStockAndCondiments = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            foreach (var product in productsInStockAndCondiments)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            }


            //Q6:Create a new anonymous type with three properties:

            var product01 = new {  Name = "laptop", price = 6000, StockStatus = "Available if UnitsInStock > 0, otherwise Out of Stock" };
            Console.WriteLine(product01.ToString());
             


            //Q7:Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.
            var productsWithPosition = Source.ProductList.Select((p, i) => new { Position = i + 1, ProductName = p.ProductName });
            foreach (var item in productsWithPosition)
            {
                Console.WriteLine($"{item.Position}. {item.ProductName}");


            }


            //8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            var sortedProducts = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);


            //Q9Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            var beverages = Source.ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);
            foreach (var product in beverages)
            {
                Console.WriteLine($"Product: {product.ProductName}, Stock: {product.UnitsInStock}");
            }


            //Q10:Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.

            
        }
    }
}
