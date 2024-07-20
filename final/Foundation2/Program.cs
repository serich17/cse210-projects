using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order("John Doe", "654 E st.", "New York City", "New York", "USA");
        order1.AddProduct("Laptop", "123456", 450.99, 1);
        order1.AddProduct("Flash drive", "564456", 9.35, 4);
        orders.Add(order1);

        Order order2 = new Order("Mary Jane", "2456780 N.E. Blv.", "Vancouver", "British Columbia", "Canada");
        order2.AddProduct("Purse", "658945", 19.99, 1);
        order2.AddProduct("Mints", "546578", 3.35, 4);
        order2.AddProduct("Watch", "785165", 40.68, 1);
        orders.Add(order2);


        foreach (Order order in orders) {
            order.DisplayAll();
        }

    }
}