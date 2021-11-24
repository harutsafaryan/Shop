using Shop.Repository;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            OrderRepository orderRepository = new OrderRepository();

            Product book = new Product() { Name = "book", Price = 800 };
            Product pen = new Product() { Name = "pen", Price = 70 };
            Product notebook = new Product() { Name = "notebook", Price = 150 };
            Product calculator = new Product() { Name = "calculator", Price = 2000 };
            Product chair = new Product() { Name = "chair", Price = 3000 };
            Product table = new Product() { Name = "table", Price = 5000 };
            Product picture = new Product() { Name = "picture", Price = 25000 };
            Product watch = new Product() { Name = "watch", Price = 9000 };
            Product paper = new Product() { Name = "paper", Price = 10 };

            Order stationary = new Order() { Name = "stationary", OrderDate = DateTime.Now, 
                Products = new List<Product>() { book, pen, notebook, calculator, paper} };
            Order inventory = new Order() { Name = "home", OrderDate = DateTime.Now, 
                Products = new List<Product>() { chair, table, picture, watch} };



            ProductService productService = new ProductService(productRepository);
            OrderService orderService = new OrderService(orderRepository);

            productService.Add(pen);

            productService.Add(book);
            productService.Add(pen);
            productService.Add(notebook);
            productService.Add(calculator);
            productService.Add(chair);
            productService.Add(table);
            productService.Add(picture);
            productService.Add(watch);
            productService.Add(paper);

            orderService.Add(stationary);
            orderService.Add(inventory);

            var productCount = orderService.GetAll().Sum(x => x.Products.Count);

            //int sum = 0;
            //foreach (var order in orders)
            //{
            //    sum += order.Products.Count;
            //}

            var order = orderService.Get(stationary.Id);
            //decimal orderPrice = 0;
            //foreach (var item in order.Products)
            //{
            //    orderPrice += item.Price;
            //}

            decimal orderPrice = order.Products.Sum(x => x.Price);

            int orderProductsCount = order.Products.Count;

            var inventoryOrder = orderService.Get(inventory.Id);
            decimal inventoryOrderPrice = inventoryOrder.Products.Sum(x => x.Price);
            int inventoryOrderCount = inventoryOrder.Products.Count;

            Console.WriteLine($"Total product number in the repository is: {productCount}");

            Console.WriteLine($"Total price for stationary is: {orderPrice} " +
                $"total count is: {orderProductsCount}");

            Console.WriteLine($"Total price for inventory is: {inventoryOrderPrice} " +
                $"total count is: {inventoryOrderCount}");

            Console.WriteLine();
        }
    }
}
