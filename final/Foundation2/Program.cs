using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to our online store!");

        while (true)
        {
            Console.WriteLine("\nEnter 1 to create a new order or any other key to exit:");
            string input = Console.ReadLine();

            if (input != "1") break;

            Console.WriteLine("\nEnter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter your street address:");
            string street = Console.ReadLine();

            Console.WriteLine("\nEnter your city:");
            string city = Console.ReadLine();

            Console.WriteLine("\nEnter your state/province:");
            string state = Console.ReadLine();

            Console.WriteLine("\nEnter your country:");
            string country = Console.ReadLine();

            Address address = new Address(street, city, state, country);
            Customer customer = new Customer(name, address);
            Order order = new Order(customer);

            while (true)
            {
                Console.WriteLine("\nEnter 1 to add a product or any other key to checkout:");
                input = Console.ReadLine();

                if (input != "1") break;

                Console.WriteLine("\nEnter product name:");
                string productName = Console.ReadLine();

                Console.WriteLine("\nEnter product ID:");
                int productId = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter product price:");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter product quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productId, price, quantity);
                order.AddProduct(product);
            }

            Console.WriteLine("\nThank you for your order!");
            Console.WriteLine("Total Price: $" + order.GetTotalPrice());
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
        }
    }
}
