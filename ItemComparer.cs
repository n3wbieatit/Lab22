using System;
using System.Collections;

namespace Lab22
{
    public class ItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Item temp1 = x as Item;
            Item temp2 = y as Item;

            if (temp1.Price < temp2.Price)
                return -1;
            else if (temp1.Price == temp2.Price)
                return 0;
            else
                return 1;
        }
    }
}
