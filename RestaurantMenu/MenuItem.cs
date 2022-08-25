using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            this.IsNew = isNew;
        }

        public void PrintMenuItem(MenuItem item)
        {
            Console.WriteLine($"{item.Description} is a {item.Category} and costs ${item.Price}.");

            if (item.IsNew)
            {
                Console.WriteLine("This item is new!");
            }
            
        }

        public override bool Equals(object comparedItem)
        {
            if (comparedItem == null || comparedItem.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem item = comparedItem as MenuItem;
            return item.Description == Description;
        }
    }
}
