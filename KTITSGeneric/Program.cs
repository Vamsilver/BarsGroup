using System;

namespace KTITSGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check DynArray
            Console.WriteLine("DynArray");
            DynamicArray<double> dynArray = new DynamicArray<double>(1);
            dynArray.Insert(5.1, 0);
            dynArray.Insert(4.2, 1);
            dynArray.Insert(3.3, 2);
            dynArray.Insert(2.4, 3);
            dynArray.PushBack(5.4);                //5,1, 4,2, 3,3, 2,4, 0, 5,4
            dynArray.Print();
            dynArray.PopBack();
            dynArray.Insert(1.5, 4);      //5,1, 4,2, 3,3, 2,4, 1,5, 0
            dynArray.Print();
            //Check DynArray
            
            Console.Write("\n\n");
            
            //Check SinglyLinkedListWithTail
            Console.WriteLine("SinglyLinkedListWithTail");
            SinglyLinkedListWithTail<string> listWithTail = new SinglyLinkedListWithTail<string>();
            listWithTail.PushFront("Im");
            listWithTail.PushFront("Hi");
            listWithTail.PushBack("Roma");
            Console.WriteLine(listWithTail.ToString()); //Hi Im Roma
            Console.WriteLine(listWithTail.FindIndex(2).Value); //Roma
            listWithTail.PopFront();
            Console.WriteLine(listWithTail.ToString()); //Im Roma
            listWithTail.PopBack();
            Console.WriteLine(listWithTail.ToString()); //Im
            //Check SinglyLinkedListWithTail
            
            Console.Write("\n\n");
            
            //Check MyQueue
            Console.WriteLine("MyQueue");
            MyQueue<float> myQueue = new MyQueue<float>();
            Console.WriteLine(myQueue.IsEmpty()); //True
            myQueue.Push(4.5f);
            myQueue.Push(5.6f);
            myQueue.Print(); //4,5 5,6
            myQueue.Pop();
            myQueue.Print(); //4,5
            //Check MyQueue
            
            Console.Write("\n\n");
            
            //Check MyStack
            Console.WriteLine("MyStack");
            MyStack<char> myStack = new MyStack<char>();
            Console.WriteLine(myStack.IsEmpty()); //True
            myStack.Push('q');
            myStack.Push('u');
            myStack.Print(); //u q
            myStack.Pop();
            myStack.Print(); //q
            myStack.Pop(); //empty
            //Check MyStack
        }
    }
}