using System;

namespace Lab22
{
    public class Toy : Item
    {
        private new static int _count = 0;

        public override int Count
        {
            get { return _count; }
        }

        #region Конструкторы
        public Toy() : base()
        {
            _name = "Toy";
            _typeOfItem = "Toy";
            _shopDep = "Игрушечный отдел";
            _count++;
        }

        public Toy(string name, double price, DateTime DateOfCreation, string StorLife)
        {
            Name = name;
            Price = price;
            Date = DateOfCreation;
            StorageLife = StorageLife;
            Type = "Toy";
            ShopDep = "Игрушечный отдел";
            _count++;
        }
        #endregion

        public override void ShowName()
        {
            base.ShowName();
        }

        public override void ShowPrice()
        {
            base.ShowPrice();
        }

        public override void ShowType()
        {
            base.ShowType();
        }

        public override object Init()
        {
            Item item = (Item)base.Init();
            Toy toy = new Toy();
            toy.Price = item.Price;
            toy.Date = item.Date;
            return toy;
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
