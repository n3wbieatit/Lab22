using System;

namespace Lab22
{
    public class MyStack : ICloneable
    {
        private object[] _stack;
        private int _size;
        private object _top;
        private int _topIndex;

        private int Size
        {
            get { return _size; }
            set
            {
                if (value > 0)
                    _size = value;
                else
                    throw new ArgumentOutOfRangeException("Отрицательное или нулевое значение.");
            }
        }

        public MyStack() : this(10)
        { }

        public MyStack(int capacity)
        {
            Size = capacity;
            _stack = new object[Size];
            _top = null;
            _topIndex = -1;
        }

        // Для клонирования
        private MyStack(object[] stack, int size, object top, int topIndex)
        {
            _stack = stack;
            Size = size;
            _top = top;
            _topIndex = topIndex;
            Size = size;
        }

        public void Push(object item)
        {
            if (_topIndex < Size - 1)
            {
                _stack[++_topIndex] = item;
                _top = item;
            }
            else
            {
                object[] tempStack = new object[Size * 2];
                Array.Copy(_stack, tempStack, Size);
                Size *= 2;
                _stack = tempStack;
                Push(item);
            }
        }

        public object Peek()
        {
            if (_topIndex < 0)
                throw new IndexOutOfRangeException("Стек пуст.");
            return _top;
        }

        public object Pop()
        {
            if (_topIndex < 0)
                throw new IndexOutOfRangeException("Стек пуст.");
            object Temp = _top;
            _stack[_topIndex--] = null;
            if (_topIndex == -1)
                _top = null;
            else
                _top = _stack[_topIndex];
            return Temp;
        }

        public bool IsEmpty()
        {
            if (_topIndex == -1)
                return true;
            return false;
        }

        public void Show()
        {
            if (!IsEmpty())
                foreach (var item in _stack)
                {
                    if (item == null)
                        return;
                    MyConverter tempConverter = new MyConverter(item);
                    tempConverter.ShowAll();
                }
        }

        public object Clone()
        {
            object[] temp = new object[Size];
            Array.Copy(_stack, temp, Size);
            return new MyStack(temp, _size, _top, _topIndex);
        }

        public void SortByName()
        {
            if (!IsEmpty())
            {
                Array.Sort(_stack, 0, _topIndex + 1);
                _top = _stack[_topIndex];
            }
        }

        public void FindByName(string name)
        {
            MyStack tempStack = Clone() as MyStack;
            MyConverter tempConverter = null;
            while (!tempStack.IsEmpty())
            {
                tempConverter = new MyConverter(tempStack.Pop());
                if (!tempConverter.IsIt(name))
                    Console.WriteLine("Такого элемента не существует!");
                else
                    break;
            }
        }
    }
}
