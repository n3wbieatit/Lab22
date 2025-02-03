using System;
using System.Collections.Generic;

namespace Lab22
{
    public class TestCollections
    {
        public LinkedList<string> lListToysStrings;
        public LinkedList<Toy> lListToys;
        public Dictionary<Item, Toy> dictToys;
        public Dictionary<string, Toy> dictToysStrings;

        public TestCollections()
        {
            lListToysStrings = new LinkedList<string>();
            lListToys = new LinkedList<Toy>();
            dictToys = new Dictionary<Item, Toy>();
            dictToysStrings = new Dictionary<string, Toy>();

            for (int i = 1; i <= 1000; i++)
            {
                Item item = new Item();
                Toy toy = new Toy();

                toy.Name = $"ListToyString_{i}";
                lListToysStrings.AddLast(toy.ToString() + $"_{i}");

                toy.Name = $"ListToy_{i}";
                lListToys.AddLast((Toy)toy.Clone());

                toy.Name = $"DictToy_{i}";
                item.Name = $"DictItem_{i}";
                dictToys.Add((Item)item.Clone(), (Toy)toy.Clone());

                toy.Name = $"DictStringToy_{i}";
                dictToysStrings.Add(item.Clone().ToString() + $"Dict_{i}", (Toy)toy.Clone());
            }
        }

        public void ShowStringList()
        {
            foreach (var item in lListToysStrings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void ShowList()
        {
            foreach (Toy item in lListToys)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void ShowStringDict()
        {
            foreach (var item in dictToys)
            {
                Console.WriteLine(item.Key.Name + " " + item.Value.Name);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void ShowDict()
        {
            foreach (var item in dictToysStrings)
            {
                Console.WriteLine(item.Key + " " + item.Value.Name);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void InputInList(Toy toy, int choice)
        {
            if (choice == 1)
                lListToysStrings.AddLast(toy.ToString());
            else if (choice == 2)
                lListToys.AddLast(toy);
        }

        public void InputInDict(Item item, Toy toy, int choice)
        {
            if (choice == 1)
                dictToys.Add(item, toy);
            else if (choice == 2)
                dictToysStrings.Add(item.ToString(), toy);
        }
    }
}
