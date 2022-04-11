/*
    Vasilev Roman 220P,
    DynamicArray<T>,
    06.04.22
 */
using System;

namespace KTITSGeneric
{
    class DynamicArray<T>
    {
        T[] array;
        int logicalSize;

        public DynamicArray(int newLogicalSize)
        {
            logicalSize = newLogicalSize;
            array = new T[10];
        }

        public void Print()
        {
            for (var i = 0; i < logicalSize; ++i)
            {
                if (i == logicalSize - 1)
                {
                    Console.Write($"{array[i]} ");
                    break;
                }
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }

        private void IncreaseLengthOfArray()
        {
            T[] newArray = new T[logicalSize * 2];
            Array.Copy(array, newArray, logicalSize);
            array = newArray;
        }

        public void Insert(T value, int index)
        {
            if (array.Length == logicalSize)
            {
                IncreaseLengthOfArray();
            }

            for (int i = logicalSize; i >= index; --i)
            {
                array[i + 1] = array[i];
            }

            array[index] = value;
            logicalSize++;
        }

        public void PushBack(T value)
        {
            if (array.Length == logicalSize)
            {
                IncreaseLengthOfArray();
            }

            array[logicalSize] = value;
            logicalSize++;
        }

        public T Delete(int index)
        {
            T value = array[index];

            for (int i = index; i < logicalSize - 1; ++i)
            {
                array[i] = array[i + 1];
            }

            logicalSize--;

            return value;
        }

        public T PopBack()
        {
            T value = array[logicalSize];
            Delete(logicalSize);
            
            return value;
        }

        public int GetLength()
        {
            return logicalSize;
        }
    }
}