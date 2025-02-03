using System;
using System.Diagnostics;
using System.Linq;

namespace Lab22
{
    public class MethodsForExThree
    {
        public static void SearchInLinkedLinkStringMethod(TestCollections testCollections)
        {
            Console.WriteLine("Поиск в списке:");
            Stopwatch clock = new Stopwatch();
            // Первый элемент
            clock.Start();
            foreach (var item in testCollections.lListToysStrings)
            {
                string toy = item;
                if (toy == "Lab22.Toy_1")           // 00:00:00.0016910
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            bool find_l1 = testCollections.lListToysStrings.Contains(new Toy().ToString() + $"_{1}");
            Console.WriteLine("Нашли элемент: find_l1=" + find_l1);

            // Средний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.lListToysStrings)
            {
                string toy = item;
                if (toy == "Lab22.Toy_500")         // 00:00:00.0001997
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            find_l1 = testCollections.lListToysStrings.Contains(new Toy().ToString() + $"_{500}");
            Console.WriteLine("Нашли элемент: find_l1=" + find_l1);

            // Последний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.lListToysStrings)
            {
                string toy = item;
                if (toy == "Lab22.Toy_1000")            // 00:00:00.0001725
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            find_l1 = testCollections.lListToysStrings.Contains(new Toy().ToString() + $"_{1000}");
            Console.WriteLine("Нашли элемент: find_l1=" + find_l1);

            // Не существующий элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.lListToysStrings)
            {
                string toy = item;
                if (toy == "Lab22.Toy_0")               // 00:00:00.0000193
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            find_l1 = testCollections.lListToysStrings.Contains(new Toy().ToString() + $"_{0}");
            Console.WriteLine("Не найден элемент: find_l1=" + find_l1);
        }

        public static void SearchInLinkedLinkMethod(TestCollections testCollections)
        {
            Console.WriteLine("Поиск в списке:");
            Stopwatch clock = new Stopwatch();
            // Первый элемент
            clock.Start();
            foreach (var item in testCollections.lListToys)
            {
                Toy toy = new Toy(item.Name, item.Price, item.Date, item.StorageLife);
                if (toy.Name == "ListToy_1")           // 00:00:00.0008355
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            bool find_l2 = testCollections.lListToys.Contains(testCollections.lListToys.First.Value);
            Console.WriteLine("Нашли элемент: find_l2=" + find_l2);

            // Средний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.lListToys)
            {
                Toy toy = new Toy(item.Name, item.Price, item.Date, item.StorageLife);
                if (toy.Name == "ListToy_500")         // 00:00:00.0001933
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            Toy toy1 = testCollections.lListToys.Where(t => t.Name == "ListToy_500").First();
            find_l2 = testCollections.lListToys.Contains(toy1);
            Console.WriteLine("Нашли элемент: find_l2=" + find_l2);

            // Последний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.lListToys)
            {
                Toy toy = new Toy(item.Name, item.Price, item.Date, item.StorageLife);
                if (toy.Name == "ListToy_1000")            // 00:00:00.0003157
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            find_l2 = testCollections.lListToys.Contains(testCollections.lListToys.Last.Value);
            Console.WriteLine("Нашли элемент: find_l2=" + find_l2);

            // Не существующий элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.lListToys)
            {
                Toy toy = new Toy(item.Name, item.Price, item.Date, item.StorageLife);
                if (toy.Name == "ListToy_0")               // 00:00:00.0001453
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            Toy toy2 = new Toy();
            toy2.Name = "ListToy_0";
            find_l2 = testCollections.lListToys.Contains(toy2);
            Console.WriteLine("Не найден элемент: find_l2=" + find_l2);
        }

        public static void SearchInDictStringMethod(TestCollections testCollections)
        {
            Console.WriteLine("Поиск в библиотеке:");
            Stopwatch clock = new Stopwatch();
            // Первый элемент
            clock.Start();
            foreach (var item in testCollections.dictToysStrings)
            {
                string key = item.Key;
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictStringToy_1" && key == "Lab22.ItemDict_1")           // 00:00:00.0001397
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            bool find_d1 = testCollections.dictToysStrings.ContainsKey(new Item().ToString() + "Dict_1")
                && testCollections.dictToysStrings.ContainsValue(testCollections.dictToysStrings.First().Value);
            Console.WriteLine("Нашли элемент: find_d1=" + find_d1);

            // Средний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.dictToysStrings)
            {
                string key = item.Key;
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictStringToy_500" && key == "Lab22.ItemDict_500")           // 00:00:00.0001970
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            Toy toy1 = testCollections.dictToysStrings.Where(k => k.Key == "Lab22.ItemDict_500").First().Value;
            find_d1 = testCollections.dictToysStrings.ContainsKey(new Item().ToString() + "Dict_500")
                && testCollections.dictToysStrings.ContainsValue(toy1);
            Console.WriteLine("Нашли элемент: find_d1=" + find_d1);

            // Последний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.dictToysStrings)
            {
                string key = item.Key;
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictStringToy_1000" && key == "Lab22.ItemDict_1000")           // 00:00:00.0004715
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            find_d1 = testCollections.dictToysStrings.ContainsKey(new Item().ToString() + "Dict_1000")
                && testCollections.dictToysStrings.ContainsValue(testCollections.dictToysStrings.Last().Value);
            Console.WriteLine("Нашли элемент: find_d1=" + find_d1);

            // Не существующий элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.dictToysStrings)
            {
                string key = item.Key;
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictStringToy_0" && key == "Lab22.ItemDict_0")           // 00:00:00.0003158
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            toy1.Name = "DictStringToy_0";
            find_d1 = testCollections.dictToysStrings.ContainsKey(new Item().ToString() + "Dict_0")
                && testCollections.dictToysStrings.ContainsValue(toy1);
            Console.WriteLine("Не найден элемент: find_d1=" + find_d1);
        }

        public static void SearchInDictMethod(TestCollections testCollections)
        {
            Console.WriteLine("Поиск в библиотеке:");
            Stopwatch clock = new Stopwatch();
            // Первый элемент
            clock.Start();
            foreach (var item in testCollections.dictToys)
            {
                Item key = (Item)item.Key.Clone();
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictToy_1" && key.Name == "Lab22.ItemDict_1")           // 00:00:00.0004534
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);

            bool find_d2 = testCollections.dictToys.ContainsKey(testCollections.dictToys.First().Key)
                && testCollections.dictToys.ContainsValue(testCollections.dictToys.First().Value);
            Console.WriteLine("Нашли элемент: find_d2=" + find_d2);

            // Средний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.dictToys)
            {
                Item key = (Item)item.Value.Clone();
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictToy_500" && key.Name == "DictItem_500")           // 00:00:00.0003634
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            Toy toy1 = testCollections.dictToys.Where(k => k.Key.Name == "DictItem_500").First().Value;
            find_d2 = testCollections.dictToys.ContainsKey(testCollections.dictToys.Where(k => k.Key.Name == "DictItem_500").First().Key)
                && testCollections.dictToys.ContainsValue(toy1);
            Console.WriteLine("Нашли элемент: find_d2=" + find_d2);

            // Последний элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.dictToys)
            {
                Item key = (Item)item.Value.Clone();
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictToy_1000" && key.Name == "DictItem_1000")           // 00:00:00.0003519
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            find_d2 = testCollections.dictToys.ContainsKey(testCollections.dictToys.Last().Key)
                && testCollections.dictToys.ContainsValue(testCollections.dictToys.Last().Value);
            Console.WriteLine("Нашли элемент: find_d2=" + find_d2);

            // Не существующий элемент
            clock.Reset();
            clock.Start();
            foreach (var item in testCollections.dictToys)
            {
                Item key = (Item)item.Value.Clone();
                Toy toy = (Toy)item.Value.Clone();
                if (toy.Name == "DictToy_0" && key.Name == "DictItem_0")           // 00:00:00.0002965
                {
                    Console.Write("Found\n");
                    break;
                }
            }
            clock.Stop();
            Console.WriteLine("Затраченное время: " + clock.Elapsed);
            toy1.Name = "DictToy_0";
            Item item1 = new Item();
            item1.Name = "DictItem_0";
            find_d2 = testCollections.dictToys.ContainsKey(item1)
                && testCollections.dictToys.ContainsValue(toy1);
            Console.WriteLine("Не найден элемент: find_d2=" + find_d2);
        }
    }
}
