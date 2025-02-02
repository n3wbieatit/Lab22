using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab22
{
    public class MyGenericList<T> : IEnumerable<T>
    {
        private T[] _list;
        private int _count;
        private int _lastIndex;

        public int Count
        {
            get { return _count; }
            private set
            {
                if (value > 0)
                    _count = value;
                else
                    throw new ArgumentOutOfRangeException("Отрицательное или нулевое значение.");
            }
        }

        public MyGenericList() : this(10)
        { }

        public MyGenericList(int capacity)
        {
            Count = capacity;
            _list = new T[Count];
            _lastIndex = -1;
        }

        // Для клонирования
        private MyGenericList(T[] list, int count, int lastIndex)
        {
            _list = list;
            Count = count;
            _lastIndex = lastIndex;
        }

        public void Add(T item)
        {
            if (_lastIndex < Count - 1)
            {
                _list[++_lastIndex] = item;
            }
            else
            {
                T[] tempList = new T[Count * 2];
                Array.Copy(_list, tempList, Count);
                Count *= 2;
                _list = tempList;
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            if (_lastIndex < 0)
                throw new IndexOutOfRangeException("Список пуст.");
            if (Contains(item))
            {
                int num = IndexOf(item);
                if (num >= 0)
                {
                    RemoveAt(num);
                    return true;
                }
            }
            return false;
        }

        private int IndexOf(T item)
        {
            return Array.IndexOf(_list, item, 0, _count);
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
                return;
            Count--;
            if (index < Count)
            {
                Array.Copy(_list, index + 1, _list, index, Count - index);
            }
            _list[Count] = default(T);
        }

        public bool Contains(T item)
        {
            foreach (var element in _list)
            {
                return EqualityComparer<T>.Default.Equals(element, item);
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (_lastIndex == -1)
                return true;
            return false;
        }

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Show()
        {
            if (!IsEmpty())
                foreach (var item in _list)
                {
                    if (item == null)
                        return;
                    MyConverter tempConverter = new MyConverter(item);
                    tempConverter.ShowAll();
                }
        }

        public MyGenericList<T> Clone()
        {
            T[] temp = new T[Count];
            Array.Copy(_list, temp, Count);
            return new MyGenericList<T>(temp, Count, _lastIndex);
        }

        public void SortByName()
        {
            if (!IsEmpty())
            {
                Array.Sort(_list, 0, Count);
            }
        }

        public void FindByName(string name)
        {
            MyConverter tempConverter = null;
            foreach (var item in _list)
            {
                tempConverter = new MyConverter(item);
                if (!tempConverter.IsIt(name))
                    Console.WriteLine("Такого элемента не существует!");
                else
                    break;
            }
        }
    }
}
