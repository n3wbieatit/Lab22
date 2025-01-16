using System;

namespace Lab22
{
    public class Product : Item
    {
        private new static int _count = 0;

        public override int Count
        {
            get { return _count; }
        }

        #region Конструкторы
        public Product() : base()
        {
            _name = "Product";
            _typeOfItem = "Product";
            _shopDep = "null";
            _count++;
        }

        public Product(string name, double price, DateTime DateOfCreation, string StorLife, string DepShop)
        {
            Name = name;
            Price = price;
            Date = DateOfCreation;
            StorageLife = StorLife;
            Type = "Product";
            ShopDep = DepShop;
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
            Product pr = new Product();
            pr.Price = item.Price;
            pr.Date = item.Date;
            return pr;
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
