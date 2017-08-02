using System;
using System.Collections.Generic;
using System.Linq;
using BagOLoot.Actions;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            SantasNiceList book = new SantasNiceList();
            SantasToyBag bag = new SantasToyBag();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.Show();
                var createChildAction = new CreateChild();
                switch (choice)
                {
                    // Menu option 1: creating children
                    case 1:
                        CreateChild.DoAction(book);
                        break;

                    // Menu option 2: add toy
                    case 2:
                        AddToy.DoAction(bag, book);
                        break;

                    // Menu option 2: add toy
                    case 3:
                        RevokeToy.DoAction(bag, book);
                        break;
                }
            } while (choice <= 6);
        }
    }
}
