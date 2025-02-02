using System;

namespace Lab22
{
    public class MethodsForExOne
    {
        public MethodsForExOne() { }
        public MyStack CreateStack()
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

        private int MenuCreateStack()
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

        private int InputCapacityMyStack()
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

        public int MainMenu()
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

        public void PushWithChoice(ref MyStack stack)
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

        public void PrintAvailableClasses()
        {
            Console.WriteLine("\nДоступные классы: ");
            Console.WriteLine("1. Товар (Item);");
            Console.WriteLine("2. Продукт (Product);");
            Console.WriteLine("3. Игрушка (Toy);");
            Console.WriteLine("4. Молочный продукт (MilkProduct);");
            Console.WriteLine("5. Продавец (Seller)");
        }

        private Item CreateItem()
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

        private Product CreateProduct()
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

        private Toy CreateToy()
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

        private MilkProduct CreateMilkProduct()
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

        private Seller CreateSeller()
        {
            int choice = MenuCreateNewObject();
            Seller seller = new Seller();
            if (choice == 2)
            {
                Console.WriteLine("\nСоздание продаваемого объекта:");
                Item item = CreateItem();
                Console.Write("\nВведите имя: "); seller.Name = Console.ReadLine();
                Console.Write("\nВведите возраст: "); seller.Age = int.Parse(Console.ReadLine());
                seller.Item = item;
            }
            return seller;
        }

        private int MenuCreateNewObject()
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

        private void Input(out string name, out string StorageLife, out double price,
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

        public void CountCertainType(MyStack stack)
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
            MyStack temp = (MyStack)stack.Clone();
            while (!temp.IsEmpty())
            {
                var item = temp.Pop();
                if (item.ToString() == type)
                    count++;
            }
            Console.WriteLine("Количество элементов заданного типа: " + count);
        }

        public void PrintCertainType(MyStack stack)
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
            MyStack temp = (MyStack)stack.Clone();
            while (!temp.IsEmpty())
            {
                if (tempConverter.Type == temp.Pop().GetType())
                    tempConverter.ShowAll();
            }
        }

        public void PrintItemByPrice(MyStack stack)
        {
            MyStack temp = (MyStack)stack.Clone();
            double price = 0;
            while (true)
            {
                Console.WriteLine("\nВведите цену -> ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            while (!temp.IsEmpty())
            {
                MyConverter tempConverter = new MyConverter(temp.Pop());
                tempConverter.PrintItemByPrice(price);
            }
        }

        public void FindByName(MyStack stack)
        {
            Console.Write("\nНапишите название искомого элемента -> ");
            string name = Console.ReadLine();
            stack.FindByName(name);
        }
    }
}
