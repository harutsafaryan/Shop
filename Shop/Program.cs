using Shop.Repository;
using Shop.Services;
using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            OrderRepository orderRepository = new OrderRepository();

            Product book = new Product() { _name = "book", _price = 800 };
            Product pen = new Product() { _name = "pen", _price = 70 };
            Product notebook = new Product() { _name = "notebook", _price = 150 };
            Product calculator = new Product() { _name = "calculator", _price = 2000 };
            Product chair = new Product() { _name = "chair", _price = 3000 };
            Product table = new Product() { _name = "table", _price = 5000 };
            Product picture = new Product() { _name = "picture", _price = 25000 };
            Product watch = new Product() { _name = "watch", _price = 9000 };
            Product paper = new Product() { _name = "paper", _price = 10 };

            Order stationary = new Order() { _name = "stationary", _date = DateTime.Now, 
                _products = new List<Product>() { book, pen, notebook, calculator, paper} };
            Order inventory = new Order() { _name = "home", _date = DateTime.Now, 
                _products = new List<Product>() { chair, table, picture, watch} };


            productRepository.Add(book);

            ProductService productService = new ProductService(productRepository);
            OrderService orderService = new OrderService(orderRepository);

            productRepository.Add(book);
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

            Console.WriteLine($"Total product number in the repository is: {orderService.ToatlProductCount()}");

            Console.WriteLine($"Total price for stationary is: {orderService.GetOrderPrice(stationary._id)} " +
                $"total count is: {orderService.GetProductCount(stationary._id)}");

            Console.WriteLine($"Total price for inventory is: {orderService.GetOrderPrice(inventory._id)} " +
                $"total count is: {orderService.GetProductCount(inventory._id)}");

            Console.WriteLine();
        }
    }
}
