﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> _customers = new();
        private List<MenuItem> _menu = new();

        public void AddCustomer(Customer customer)
        {
            this._customers.Add(customer);
        }

        public void AddMenuItem(MenuItem item)
        {
            this._menu.Add(item);
        }

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public MenuItem GetMenuItem(int index)
        {
            if (index >= _menu.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _menu[index];
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");

            foreach (MenuItem item in _menu)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Toral: {order.GetTotal()}");
                foreach(MenuItem item in order.Items)
                {
                    Console.WriteLine($"  {item}");
                }
            }
        }
    }
}
