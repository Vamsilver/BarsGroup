/*
    Vasilev Roman 220P,
    MyStack<T>,
    06.04.22
 */

using System;

namespace KTITSGeneric
{
    public class MyStack<T>
    {
        SinglyLinkedList<T> list;

        public MyStack()
        {
            list = new SinglyLinkedList<T>();
        }

        public bool IsEmpty()
        {
            return list.GetCount() == 0;
        }

        public void Push(T value)
        {
            list.PushFront(value); 
        }

        public T Pop()
        {
            return list.PopFront();
        }

        public void Print()
        {
            Console.WriteLine(list.ToString());
        }
    }
}
