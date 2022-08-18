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
    }
}
