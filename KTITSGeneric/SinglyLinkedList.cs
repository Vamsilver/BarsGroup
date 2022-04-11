/*
    Vasilev Roman 220P,
    SingleLinkedList-SingleLinkedList,
    23.03.22
 */

using System;


namespace KTITSGeneric
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T value)
        {
            Value = value;
        }
    }

    public class SinglyLinkedList<T>
    {
        private int count = 0;
        public Node<T> Head;

        public int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            string result = "";
            var current = Head;
            while (current != null)
            {
                result += current.Value + " ";
                current = current.Next;
            }
            return result;
        }

        public void PushFront(T value)
        {
            var newNode = new Node<T>(value);
            if (count != 0)
            {
                newNode.Next = Head;
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
            var current = Head;
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
            var current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }
    }
}