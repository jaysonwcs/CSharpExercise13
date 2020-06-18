using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_13.Entities
{
    class Item
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
