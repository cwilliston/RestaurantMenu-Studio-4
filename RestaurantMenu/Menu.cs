using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {
       public List<MenuItem> MenuItems { get; set; }
        public DateTime Updated { get; set; }
        public Menu(List<MenuItem> menuItems, DateTime updated)
        {
            MenuItems = menuItems;
            Updated = updated;
        }

        public void AddItem (MenuItem item)
        {
            MenuItems.Add(item);
        }

        public void RemoveItem (MenuItem item)
        {
            MenuItems.Remove(item);
        }
        public void PrintMenu()
        {
            foreach(MenuItem item in MenuItems)
            {
                Console.WriteLine($"{item.Description} is a {item.Category} and costs ${item.Price}.");
            }
        }

            //public void PrintMenu (List<MenuItem> menu)
            //{
            //    foreach (MenuItem item in menu)
            //    {
            //        Console.WriteLine($"{item.Description} is a {item.Category} and costs ${item.Price}.");
            //    }
            //}
        }
}
