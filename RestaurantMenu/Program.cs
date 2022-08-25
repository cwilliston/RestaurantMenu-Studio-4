using System;
namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem bread = new MenuItem(24.96, "Bread", "Baked Goods", true);
            MenuItem redWine = new MenuItem(16.66, "Red Wine", "Alcohol", false);
            MenuItem croissant = new MenuItem(12.22, "Croissant", "Baked Goods", true);

            List<MenuItem> menu = new List<MenuItem>();
            menu.Add(bread);
            menu.Add(redWine);
            menu.Add(croissant);

            Menu specialMenu = new Menu(menu, DateTime.Now );




            specialMenu.PrintMenu();
            

        }
    }

}