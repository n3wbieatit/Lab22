using System;

namespace Lab22
{
    public class MilkProduct : Item
    {
        private new static int _count = 0;

        public override int Count
        {
            get { return _count; }
        }

        #region Конструкторы
        public MilkProduct() : base()
        {
            _name = "MilkProduct";
            _typeOfItem = "MilkProduct";
            _shopDep = "Молочный отдел";
            _count++;
        }

        public MilkProduct(string name, double price, DateTime DateOfCreation, string StorLife)
        {
            Name = name;
            Price = price;
            Date = DateOfCreation;
            StorageLife = StorLife;
            Type = "MilkProduct";
            ShopDep = "Молочный отдел";
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
            MilkProduct mp = new MilkProduct();
            mp.Price = item.Price;
            mp.Date = item.Date;
            return mp;
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
