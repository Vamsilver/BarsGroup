/*
    Vasilev Roman 220P,
    SingleLinkedListWithTail<T>,
    06.04.22
 */

using System;


namespace KTITSGeneric
{
    public class SinglyLinkedListWithTail<T>
    {
        private int count = 0;
        public Node<T> Head;
        public Node<T> Tail;

        public int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            string result = "";
            Node<T> current = Head;
            while (current != null)
            {
                result += current.Value + " ";
                current = current.Next;
            }
            return result;
        }

        public void PushFront(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (count != 0)
            {
                newNode.Next = Head;
            }
            else
            {
                Tail = newNode;
            }
            Head = newNode;
            ++count;
        }

        public T PopFront()
        {
            T val = Head.Value;
            Head = Head.Next;
            --count;
            return val;
        }

        public Node<T> Find(T key)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(key))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public Node<T> FindIndex(int index)
        {
            Node<T> current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }

        public void PushBack(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (count != 0)
            {
                Tail.Next = newNode;
            }
            else
            {
                Head = newNode;
            }
            Tail = newNode;
            ++count;
        }

        public T PopBack()
        {
            T val = Tail.Value;

            Node<T> current = Head;
            while (current.Next != Tail)
            {
                current = current.Next;
            }

            Tail = current;
            current.Next = null;
            --count;
            return val;
        }
    }
}