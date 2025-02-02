using System;

namespace Lab22
{
    public class MethodsForExTwo
    {
        public MethodsForExTwo() { }

        public MyGenericList<T> CreateList<T>()
        {
            int choice = MenuCreateList();
            MyGenericList<T> list = new MyGenericList<T>();
            if (choice == 2)
            {
                int capacity = InputCapacityList();
                list = new MyGenericList<T>(capacity);
            }
            else if (choice == 0)
                throw new Exception("Выход из программы");
            return list;
        }

        private int MenuCreateList()
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

        private int InputCapacityList()
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
            Console.WriteLine("2. Удаление элемента из коллекции по индексу,");
            Console.WriteLine("3. Вывод количества элементов определенного вида,");
            Console.WriteLine("4. Печать элементов определенного вида,");
            Console.WriteLine("5. Печать элементов со стоимостью выше указанной,");
            Console.WriteLine("6. Вывод всех элементов коллекции,");
            Console.WriteLine("7. Клонирование коллекции,");
            Console.WriteLine("8. Сортировка коллекции,");
            Console.WriteLine("9. Поиск заданного элемента в коллекции,");
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

        public void AddWithChoice(ref MyGenericList<Item> list)
        {
            PrintAvailableItemClasses();
            int choice = 0;
            while (true)
            {
                Console.Write("\nВведите номер: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            switch (choice)
            {
                case 1:
                    Item item = CreateItem() as Item;
                    list.Add(item);
                    break;
                case 2:
                    Product product = CreateProduct() as Product;
                    list.Add(product);
                    break;
                case 3:
                    Toy toy = CreateToy() as Toy;
                    list.Add(toy);
                    break;
                case 4:
                    MilkProduct milkProduct = CreateMilkProduct() as MilkProduct;
                    list.Add(milkProduct);
                    break;
                default:
                    break;
            }
        }

        public void AddSeller(ref MyGenericList<Seller> list)
        {
            Seller seller = CreateSeller() as Seller;
            list.Add(seller);
        }

        public void PrintAvailableItemClasses()
        {
            Console.WriteLine("\nДоступные классы: ");
            Console.WriteLine("1. Товар (Item);");
            Console.WriteLine("2. Продукт (Product);");
            Console.WriteLine("3. Игрушка (Toy);");
            Console.WriteLine("4. Молочный продукт (MilkProduct);");
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

        public void CountCertainType(MyGenericList<Item> list)
        {
            PrintAvailableItemClasses();
            int choice = 0;
            while (true)
            {
                Console.Write("\nВведите номер: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            Type type = null;
            switch (choice)
            {
                case 1:
                    type = typeof(Item);
                    break;
                case 2:
                    type = typeof(Product);
                    break;
                case 3:
                    type = typeof(Toy);
                    break;
                case 4:
                    type = typeof(MilkProduct);
                    break;
                default:
                    break;
            }
            int count = 0;
            foreach (var item in list)
            {
                if (item.GetType() == type)
                    count++;
            }
            Console.WriteLine("Количество элементов заданного типа: " + count);
        }

        public void CountSellers(MyGenericList<Seller> list)
        {
            Type type = typeof(Seller);
            int count = 0;
            foreach (var seller in list)
            {
                if (type == seller.GetType())
                    count++;
            }
            Console.WriteLine("Количество продавцов: " + count);
        }

        public void PrintCertainType(MyGenericList<Item> list)
        {
            PrintAvailableItemClasses();
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
                default:
                    break;
            }
            foreach (var item in list)
            {
                if (tempConverter.Type == item.GetType())
                    tempConverter.ShowAll();
            }
        }

        public void PrintSellers(MyGenericList<Seller> list)
        {
            MyConverter tempConverter = new MyConverter(new Seller());
            foreach (var item in list)
            {
                if (tempConverter.Type == item.GetType())
                    tempConverter.ShowAll();
            }
        }

        public void PrintItemByPrice<T>(MyGenericList<T> list)
        {
            double price = 0;
            while (true)
            {
                Console.WriteLine("\nВведите цену -> ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            foreach (var item in list)
            {
                MyConverter tempConverter = new MyConverter(item);
                tempConverter.PrintItemByPrice(price);
            }
        }

        public void FindByName<T>(MyGenericList<T> list)
        {
            Console.Write("\nНапишите название искомого элемента -> ");
            string name = Console.ReadLine();
            list.FindByName(name);
        }

        public void RemoveByIndex<T>(ref MyGenericList<T> list)
        {
            int index = -1;
            while (true)
            {
                Console.Write("\nВведите индекс: ");
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < list.Count)
                    break;
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз!");
            }
            list.Remove(list[index]);
        }
    }
}
