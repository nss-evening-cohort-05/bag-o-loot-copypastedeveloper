using System;

namespace BagOLoot.Actions
{
    public class RevokeToy
    {
        public static void DoAction(SantasToyBag bag, SantasNiceList book)
        {
            var kid = KidsMenu.Show(book);

            var toys = bag.GetToysForChild(kid).ToArray();
            foreach (var toy in toys)
            {
                Console.WriteLine($"{Array.IndexOf(toys, toy) + 1}. {toy.name}");
            }
            Console.Write("> ");
            var toyChoice = Console.ReadLine();
            var chosenToy = toys[int.Parse(toyChoice) - 1];

            bag.RevokeToy(chosenToy);
        }
    }
}