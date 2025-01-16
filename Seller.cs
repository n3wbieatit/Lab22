using System;

namespace Lab22
{
    public class Seller : IInit, IComparable
    {
        #region Поля

        private string _name;
        private int _age;
        private string _itemName;

        #endregion

        #region Конструкторы

        public Seller()
        {
            _name = "Tom";
            _age = 18;
            _itemName = new Item().Name;
        }

        public Seller(string name, int age, string itemName)
        {
            _name = name;
            _age = age;
            _itemName = itemName;
        }

        #endregion

        #region Свойства

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else
                    Console.WriteLine("ERROR");
            }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        #endregion

        public object Init()
        {
            Random rnd = new Random();
            Seller p = new Seller("Bob", rnd.Next(1, 100), new Item().Name);
            return p;
        }

        public void Show()
        {
            Console.WriteLine("Name: {0} \t Age: {1} \t Item: {2}", _name, _age, _itemName);
        }

        public int CompareTo(object obj)
        {
            try
            {
                Seller person = obj as Seller;
                return String.Compare(this.Name, person.Name);
            }
            catch (Exception)
            {
                Item item = obj as Item;
                return String.Compare(this.Name, item.Name);
            }
        }

        // Метод глубокого копирования
        public object Clone()
        {
            return new Seller(Name, Age, new Item().Name);
        }
    }
}
