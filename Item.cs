using System;

namespace Lab22
{
    public class Item : IInit, IComparable, ICloneable
    {
        #region Поля
        // Название продукта
        protected string _name;
        // Стоимость продукта
        protected double _price;
        // Время создания
        protected DateTime _dateOfCreation;
        // Срок хранения
        protected string _storageLife;
        // Тип продукта
        protected string _typeOfItem;
        // Название отдела магазина
        protected string _shopDep;
        // Количество продукта
        protected static int _count = 0;
        #endregion

        #region Свойства
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price < 0)
                    _price = 0;
                else
                    _price = value;
            }
        }

        public DateTime Date
        {
            get { return _dateOfCreation; }
            set { _dateOfCreation = value; }
        }

        public string StorageLife
        {
            get { return _storageLife; }
            set { _storageLife = value; }
        }

        public string Type
        {
            get { return _typeOfItem; }
            set { _typeOfItem = value; }
        }

        public string ShopDep
        {
            get { return _shopDep; }
            set { _shopDep = value; }
        }

        public virtual int Count
        {
            get { return _count; }
        }
        #endregion

        #region Конструкторы
        public Item()
        {
            _name = "Item";
            _price = 0;
            _dateOfCreation = DateTime.MinValue;
            _storageLife = "null";
            _typeOfItem = "Item";
            _shopDep = "null";
            _count++;
        }

        public Item(string name, double price, DateTime DateOfCreation, string StorLife, string TypeOfItem, string DepShop)
        {
            Name = name;
            Price = price;
            Date = DateOfCreation;
            StorageLife = StorLife;
            Type = TypeOfItem;
            ShopDep = DepShop;
            _count++;
        }
        #endregion

        public virtual void ShowName() => Console.WriteLine($"Название: {Name}");

        public virtual void ShowPrice()
        {
            Console.WriteLine("Цена: {0}руб.", Price);
        }

        public virtual void ShowType()
        {
            Console.WriteLine("Класс: " + Type);
        }

        public virtual object Init()
        {
            Random rnd = new Random();
            Item item = new Item("Item", rnd.Next(0, 10_000), DateTime.MinValue, "null", "Item", "null");
            return item;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Название: {Name}, Цена: {Price}руб., Дата производства: {Date}, " +
                $"Срок хранения: {StorageLife}, Тип продукта: {Type}, Отдел магазина: {ShopDep}");
        }

        public int CompareTo(object o)
        {
            if (o.GetType() == typeof(Seller))
                return String.Compare(this.Name, ((Seller)o).Name);
            return String.Compare(this.Name, ((Item)o).Name);
        }

        public virtual object Clone()
        {
            return new Item(Name, Price, Date, StorageLife, Type, ShopDep);
        }
    }
}
