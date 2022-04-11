/*
    Vasilev Roman 220P,
    MyQueue<T>,
    06.04.22
 */
using System;

namespace KTITSGeneric
{
    public class MyQueue<T>
    {
        SinglyLinkedListWithTail<T> list;
    
        public MyQueue()
        {
            list = new SinglyLinkedListWithTail<T>();
        }
    
        public bool IsEmpty()
        {
            return list.GetCount() == 0;
        }
    
        public void Push(T value)
        {
            list.PushBack(value);
        }
    
        public T Pop()
        {
            return list.PopBack();
        }
    
        public void Print()
        {
            Console.WriteLine(list.ToString());
        }
    }
}
