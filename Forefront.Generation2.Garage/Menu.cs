using System;
using System.Collections.Generic;

namespace Forefront.Generation2.Garage
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();

            AddMenuItemToMenuWithDescription("Build parking lots", "By enter number of parking lots");
            AddMenuItemToMenuWithoutDescription("Park a new car");
            AddMenuItemToMenuWithoutDescription("Show me the garage layout");
            AddMenuItemToMenuWithoutDescription("Exit");
        }

        private void AddMenuItemToMenuWithDescription(string title, string description)
        {
            MenuItem menuItem = new MenuItem(title);
            menuItem.Description = description;

            MenuItems.Add(menuItem);
        }

        private void AddMenuItemToMenuWithoutDescription(string title)
        {
            MenuItem menuItem = new MenuItem(title);
            menuItem.Title = title;

            MenuItems.Add(menuItem);
        }

        public int ShowMenuToTheUserAndReturnSelectedIndex()
        {
            Console.WriteLine();

            int menuPosition = 1;

            foreach (MenuItem menuItem in MenuItems)
            {
                WriteMenuItemToUser(menuPosition, menuItem);
                menuPosition++;
            }

            var userSelection = GetInputAndShowResultToUser();
            return userSelection;
        }

        private static int GetInputAndShowResultToUser()
        {
            Console.Write("Select menu item: ");
            string userSelectionInput = Console.ReadLine();
            var userSelection = Convert.ToInt32(userSelectionInput);
            Console.WriteLine("You have selected number {0}", userSelection);
            return userSelection;
        }

        private static void WriteMenuItemToUser(int menuPosition, MenuItem menuItem)
        {
            Console.WriteLine("\t{0}:\t{1}", menuPosition, menuItem.Title);
            if(!String.IsNullOrEmpty(menuItem.Description))
                Console.WriteLine("\t\t({0})", menuItem.Description);
            Console.WriteLine();
        }
    }
}