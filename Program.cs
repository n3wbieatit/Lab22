using System;

namespace Lab22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа запущена!\n");
            MyStack stack = new MyStack();
            try
            {
                stack = CreateStack();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            while (true)
            {
                int choice = MainMenu();
                if (choice == 0)
                    break;
                switch (choice)
                {
                    case 1:
                        PushWithChoice(ref stack);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        CountCertainType(stack);
                        break;
                    case 4:
                        PrintCertainType(stack);
                        break;
                    case 5:
                        PrintItemByPrice(stack);
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
                        FindByName(stack);
                        break;
                    case 10:
                        PrintAvailableClasses();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Завершение работы");
        }

        static MyStack CreateStack()
        {
            int choice = MenuCreateStack();
            MyStack stack = new MyStack();
            if (choice == 2)
            {
                int capacity = InputCapacityMyStack();
                stack = new MyStack(capacity);
            }
            else if (choice == 0)
                throw new Exception("Выход из программы");
            return stack;
        }

        static int MenuCreateStack()
        {
            int choice = 0;
            Console.WriteLine("Способы создания коллекции:");
            Console.WriteLine("1. По умолчанию,");
            Console.WriteLine("2. С заданием первоначального размера,");
            Console.WriteLine("0. Выход из программы.\n");
            while (true)
            {
                Console.Write("Введите значение -> ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0 || choice > 2)
                        throw new Exception("Выход за допустимые границы. Попробуйте снова");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return choice;
        }

        static int InputCapacityMyStack()
        {
            int capacity = 0;
            while (true)
            {
                Console.Write("Введите размер коллекции -> ");
                try
                {
                    capacity = Convert.ToInt32(Console.ReadLine());
                    if (capacity < 0)
                        throw new Exception("Выход за допустимые границы. Попробуйте снова");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return capacity;
        }

        static int MainMenu()
        {
            int choice = 0;
            Console.WriteLine("\nДоступные операции:");
            Console.WriteLine("1. Добавление элемента в коллекцию,");
            Console.WriteLine("2. Удаление последнего элемента из коллекции,");
            Console.WriteLine("3. Вывод количества элементов определенного вида,");
            Console.WriteLine("4. Печать элементов определенного вида,");
            Console.WriteLine("5. Печать элементов со стоимостью выше указанной,");
            Console.WriteLine("6. Вывод всех элементов коллекции,");
            Console.WriteLine("7. Клонирование коллекции,");
            Console.WriteLine("8. Сортировка коллекции,");
            Console.WriteLine("9. Поиск заданного элемента в коллекции,");
            Console.WriteLine("10. Список классов,");
            Console.WriteLine("0. Выход из программы.");
            while (true)
            {
                Console.Write("Введите значение -> ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0 || choice > 10)
                        throw new Exception("Выход за допустимые границы. Попробуйте снова");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return choice;
        }

        static void PushWithChoice(ref MyStack stack)
        {
            PrintAvailableClasses();
            int choice = 0;
            while (true)
            {
                Console.Write("\nВведите номер: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            switch (choice)
            {
                case 1:
                    Item item = CreateItem() as Item;
                    stack.Push(item);
                    break;
                case 2:
                    Product product = CreateProduct() as Product;
                    stack.Push(product);
                    break;
                case 3:
                    Toy toy = CreateToy() as Toy;
                    stack.Push(toy);
                    break;
                case 4:
                    MilkProduct milkProduct = CreateMilkProduct() as MilkProduct;
                    stack.Push(milkProduct);
                    break;
                case 5:
                    Seller seller = CreateSeller() as Seller;
                    stack.Push(seller);
                    break;
                default:
                    break;
            }
        }

        static void PrintAvailableClasses()
        {
            Console.WriteLine("\nДоступные классы: ");
            Console.WriteLine("1. Товар (Item);");
            Console.WriteLine("2. Продукт (Product);");
            Console.WriteLine("3. Игрушка (Toy);");
            Console.WriteLine("4. Молочный продукт (MilkProduct);");
            Console.WriteLine("5. Продавец (Seller)");
        }

        static Item CreateItem()
        {
            int choice = MenuCreateNewObject();
            Item item = new Item();
            if (choice == 2)
            {
                string name, StorageLife, TypeOfItem, DepShop;
                double price;
                DateTime DateOfCreation;
                Input(out name, out StorageLife, out price, out DateOfCreation);
                Console.Write("Введите тип товара: ");
                TypeOfItem = Console.ReadLine();
                Console.Write("Введите отдел магазина: ");
                DepShop = Console.ReadLine();
                item.Name = name;
                item.Price = price;
                item.Date = DateOfCreation;
                item.StorageLife = StorageLife;
                item.Type = TypeOfItem;
                item.ShopDep = DepShop;
            }
            return item;
        }

        static Product CreateProduct()
        {
            int choice = MenuCreateNewObject();
            Product product = new Product();
            if (choice == 2)
            {
                string name, StorageLife, TypeOfItem, DepShop;
                double price;
                DateTime DateOfCreation;
                Input(out name, out StorageLife, out price, out DateOfCreation);
                Console.Write("Введите тип товара: ");
                TypeOfItem = Console.ReadLine();
                Console.Write("Введите отдел магазина: ");
                DepShop = Console.ReadLine();
                product.Name = name;
                product.Price = price;
                product.Date = DateOfCreation;
                product.StorageLife = StorageLife;
                product.Type = TypeOfItem;
                product.ShopDep = DepShop;
            }
            return product;
        }

        static Toy CreateToy()
        {
            int choice = MenuCreateNewObject();
            Toy toy = new Toy();
            if (choice == 2)
            {
                string name, StorageLife, TypeOfItem, DepShop;
                double price;
                DateTime DateOfCreation;
                Input(out name, out StorageLife, out price, out DateOfCreation);
                Console.Write("Введите тип товара: ");
                TypeOfItem = Console.ReadLine();
                Console.Write("Введите отдел магазина: ");
                DepShop = Console.ReadLine();
                toy.Name = name;
                toy.Price = price;
                toy.Date = DateOfCreation;
                toy.StorageLife = StorageLife;
                toy.Type = TypeOfItem;
                toy.ShopDep = DepShop;
            }
            return toy;
        }

        static MilkProduct CreateMilkProduct()
        {
            int choice = MenuCreateNewObject();
            MilkProduct milkProduct = new MilkProduct();
            if (choice == 2)
            {
                string name, StorageLife, TypeOfItem, DepShop;
                double price;
                DateTime DateOfCreation;
                Input(out name, out StorageLife, out price, out DateOfCreation);
                Console.Write("Введите тип товара: ");
                TypeOfItem = Console.ReadLine();
                Console.Write("Введите отдел магазина: ");
                DepShop = Console.ReadLine();
                milkProduct.Name = name;
                milkProduct.Price = price;
                milkProduct.Date = DateOfCreation;
                milkProduct.StorageLife = StorageLife;
                milkProduct.Type = TypeOfItem;
                milkProduct.ShopDep = DepShop;
            }
            return milkProduct;
        }

        static Seller CreateSeller()
        {
            int choice = MenuCreateNewObject();
            Seller seller = new Seller();
            if (choice == 2)
            {
                Console.WriteLine("\nСоздание продаваемого объекта:");
                Item item = CreateItem();
                Console.Write("\nВведите имя: "); seller.Name = Console.ReadLine();
                Console.Write("\nВведите возраст: "); seller.Age = int.Parse(Console.ReadLine());
                seller.ItemName = item.Name;
            }
            return seller;
        }

        static int MenuCreateNewObject()
        {
            int choice = 0;
            Console.WriteLine("Способы создания объекта:");
            Console.WriteLine("1. По умолчанию,");
            Console.WriteLine("2. С заданием собственных значений");
            while (true)
            {
                Console.Write("Введите значение -> ");
                if (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
                    break;
                Console.WriteLine("Данной операции непредставлено. Попробуйте еще раз!");
            }
            return choice;
        }

        static void Input(out string name, out string StorageLife, out double price,
            out DateTime DateOfCreation)
        {
            Console.Write("Введите название товара: ");
            name = Console.ReadLine();
            while (true)
            {
                Console.Write("Введите цену: ");
                if (double.TryParse(Console.ReadLine(), out price))
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте снова!\n");
            }
            while (true)
            {
                Console.Write("Введите дату создания (в формате гггг-мм-дд): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateOfCreation))
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте снова!\n");
            }

            Console.Write("Введите срок хранения: ");
            StorageLife = Console.ReadLine();
        }

        static void CountCertainType(MyStack stack)
        {
            PrintAvailableClasses();
            int choice = 0;
            while (true)
            {
                Console.Write("\nВведите номер: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            string type = "Lab22.";
            switch (choice)
            {
                case 1:
                    type += "Item";
                    break;
                case 2:
                    type += "Product";
                    break;
                case 3:
                    type += "Toy";
                    break;
                case 4:
                    type += "MilkProduct";
                    break;
                case 5:
                    type += "Seller";
                    break;
                default:
                    break;
            }
            int count = 0;
            while (!stack.IsEmpty())
            {
                var item = stack.Pop();
                if (item.ToString() == type)
                    count++;
            }
            Console.WriteLine("Количество элементов заданного типа: " + count);
        }

        static void PrintCertainType(MyStack stack)
        {
            PrintAvailableClasses();
            int choice = 0;
            while (true)
            {
                Console.Write("\nВведите номер: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            MyConverter tempConverter = new MyConverter();
            switch (choice)
            {
                case 1:
                    tempConverter = new MyConverter(new Item());
                    break;
                case 2:
                    tempConverter = new MyConverter(new Product());
                    break;
                case 3:
                    tempConverter = new MyConverter(new Toy());
                    break;
                case 4:
                    tempConverter = new MyConverter(new MilkProduct());
                    break;
                case 5:
                    tempConverter = new MyConverter(new Seller());
                    break;
                default:
                    break;
            }
            while (!stack.IsEmpty())
            {
                if (tempConverter.Type == stack.Pop().GetType())
                    tempConverter.ShowAll();
            }
        }

        static void PrintItemByPrice(MyStack stack)
        {
            double price = 0;
            while (true)
            {
                Console.WriteLine("\nВведите цену -> ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            while (!stack.IsEmpty())
            {
                MyConverter tempConverter = new MyConverter(stack.Pop());
                tempConverter.PrintItemByPrice(price);
            }
        }

        static void FindByName(MyStack stack)
        {
            Console.Write("\nНапишите название искомого элемента -> ");
            string name = Console.ReadLine();
            stack.FindByName(name);
        }
    }
}
