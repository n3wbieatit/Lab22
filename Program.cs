using System;

namespace Lab22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Доступные части программы:");
            Console.WriteLine("1. Первая часть;");
            Console.WriteLine("2. Вторая часть;");
            Console.WriteLine("0. Выход.");
            while (true)
            {
                Console.Write("\nВведите номер -> ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 2)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            switch (choice)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    choice = ChoosePart();
                    if (choice == 1)
                        Exercise2WithoutSeller();
                    else if (choice == 2)
                        Exercise2WithSeller();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Завершение работы");
        }

        static void Exercise1()
        {
            MethodsForExOne methodsOne = new MethodsForExOne();
            Console.WriteLine("Программа запущена!\n");
            MyStack stack = new MyStack();
            try
            {
                stack = methodsOne.CreateStack();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            while (true)
            {
                int choice = methodsOne.MainMenu();
                if (choice == 0)
                    break;
                switch (choice)
                {
                    case 1:
                        methodsOne.PushWithChoice(ref stack);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        methodsOne.CountCertainType(stack);
                        break;
                    case 4:
                        methodsOne.PrintCertainType(stack);
                        break;
                    case 5:
                        methodsOne.PrintItemByPrice(stack);
                        break;
                    case 6:
                        stack.Show();
                        break;
                    case 7:
                        MyStack cloneStack = stack.Clone() as MyStack;
                        Console.WriteLine("Проверка: " +
                            "1. Вывод элементов оригинального стека,\n" +
                            "2. Вывод элементов копии,\n" +
                            "3. Удаление элемента копии и вывод,\n" +
                            "4. Повторный вывод элементов оригинального стека\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вывод элементов оригинального стека:");
                        stack.Show();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вывод элементов копии с последующим удалением:");
                        cloneStack.Show();
                        cloneStack.Pop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вывод элементов оригинального стека:");
                        stack.Show();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вывод элементов копии:");
                        cloneStack.Show();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 8:
                        Console.WriteLine("Стек до сортировки:");
                        stack.Show();
                        Console.WriteLine("Стек после сортировки:");
                        stack.SortByName();
                        stack.Show();
                        break;
                    case 9:
                        methodsOne.FindByName(stack);
                        break;
                    case 10:
                        methodsOne.PrintAvailableClasses();
                        break;
                    default:
                        break;
                }
            }
        }

        static int ChoosePart()
        {
            int choice = 0;
            Console.WriteLine("Доступные подчасти:");
            Console.WriteLine("1. С товарами;");
            Console.WriteLine("2. С продавцами;");
            Console.WriteLine("0. Выход.");
            while (true)
            {
                Console.Write("\nВведите номер -> ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 2)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            return choice;
        }

        static void Exercise2WithoutSeller()
        {
            MethodsForExTwo methodsTwo = new MethodsForExTwo();
            Console.WriteLine("Программа запущена!\n");
            MyGenericList<Item> list = new MyGenericList<Item>();
            try
            {
                list = methodsTwo.CreateList<Item>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            while (true)
            {
                int choice = methodsTwo.MainMenu();
                if (choice == 0)
                    break;
                switch (choice)
                {
                    case 1:
                        methodsTwo.AddWithChoice(ref list);
                        break;
                    case 2:
                        methodsTwo.RemoveByIndex(ref list);
                        break;
                    case 3:
                        methodsTwo.CountCertainType(list);
                        break;
                    case 4:
                        methodsTwo.PrintCertainType(list);
                        break;
                    case 5:
                        methodsTwo.PrintItemByPrice(list);
                        break;
                    case 6:
                        list.Show();
                        break;
                    case 7:
                        MyGenericList<Item> cloneList = list.Clone() as MyGenericList<Item>;
                        Console.WriteLine("Проверка: " +
                            "1. Вывод элементов оригинального списка,\n" +
                            "2. Вывод элементов копии,\n" +
                            "3. Удаление элемента копии и вывод,\n" +
                            "4. Повторный вывод элементов оригинального списка\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вывод элементов оригинального списка:");
                        list.Show();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вывод элементов копии с последующим удалением:");
                        cloneList.Show();
                        cloneList.RemoveAt(cloneList.Count);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вывод элементов оригинального списка:");
                        list.Show();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вывод элементов копии:");
                        cloneList.Show();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 8:
                        Console.WriteLine("Список до сортировки:");
                        list.Show();
                        Console.WriteLine("Список после сортировки:");
                        list.SortByName();
                        list.Show();
                        break;
                    case 9:
                        methodsTwo.FindByName(list);
                        break;
                    default:
                        break;
                }
            }
        }

        static void Exercise2WithSeller()
        {
            MethodsForExTwo methodsTwo = new MethodsForExTwo();
            Console.WriteLine("Программа запущена!\n");
            MyGenericList<Seller> list = new MyGenericList<Seller>();
            try
            {
                list = methodsTwo.CreateList<Seller>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            while (true)
            {
                int choice = methodsTwo.MainMenu();
                if (choice == 0)
                    break;
                switch (choice)
                {
                    case 1:
                        methodsTwo.AddSeller(ref list);
                        break;
                    case 2:
                        methodsTwo.RemoveByIndex(ref list);
                        break;
                    case 3:
                        methodsTwo.CountSellers(list);
                        break;
                    case 4:
                        methodsTwo.PrintSellers(list);
                        break;
                    case 5:
                        methodsTwo.PrintItemByPrice(list);
                        break;
                    case 6:
                        list.Show();
                        break;
                    case 7:
                        MyGenericList<Seller> cloneList = list.Clone() as MyGenericList<Seller>;
                        Console.WriteLine("Проверка: " +
                            "1. Вывод элементов оригинального списка,\n" +
                            "2. Вывод элементов копии,\n" +
                            "3. Удаление элемента копии и вывод,\n" +
                            "4. Повторный вывод элементов оригинального списка\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вывод элементов оригинального списка:");
                        list.Show();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вывод элементов копии с последующим удалением:");
                        cloneList.Show();
                        cloneList.RemoveAt(cloneList.Count);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вывод элементов оригинального списка:");
                        list.Show();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вывод элементов копии:");
                        cloneList.Show();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 8:
                        Console.WriteLine("Список до сортировки:");
                        list.Show();
                        Console.WriteLine("Список после сортировки:");
                        list.SortByName();
                        list.Show();
                        break;
                    case 9:
                        methodsTwo.FindByName(list);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
