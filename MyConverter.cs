using System;
using System.Diagnostics;

namespace Lab22
{
    public class MyConverter
    {
        object _item;

        public MyConverter() => _item = null;

        public MyConverter(object obj)
        {
            _item = obj;
        }

        public Type Type
        {
            get { return _item.GetType(); }
        }

        public void ShowAll()
        {
            if (_item.GetType() == typeof(Seller))
            {
                Seller tempSeller = (Seller)_item;
                tempSeller.Show();
            }
            else
            {
                Item tempItem = (Item)_item;
                tempItem.Show();
            }
        }

        public void PrintItemByPrice(double price)
        {
            if (_item.GetType() != typeof(Seller))
            {
                Item tempItem = (Item)_item;
                if (tempItem.Price > price)
                    tempItem.Show();
            }
        }

        public bool IsIt(string name)
        {
            if (_item.GetType() != typeof(Seller))
            {
                Item tempItem = (Item)_item;
                if (tempItem.Name == name)
                {
                    ShowAll();
                    return true;
                }
            }
            else
            {
                Seller tempSeller = (Seller)_item;
                if (tempSeller.Name == name)
                {
                    ShowAll();
                    return true;
                }
            }
            return false;
        }
    }
}
