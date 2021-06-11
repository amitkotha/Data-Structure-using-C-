using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Hashtables
{
  public class HashTable
    {

        string[] arr;
        public HashTable()
        {
            arr = new string[9];
        }

        public void Add(string s)
        {
            int index = HashFunction(s);
            
            for(int i = 0; i < arr.Length; i++)
            {
                int newIndex = (i + index) % arr.Length;
                if (arr[newIndex] == null)
                {
                    arr[newIndex] = s;
                    return;
                }
            }
          Console.WriteLine("This is already booked");
           
        }
        public void Remove(string s)
        {
            int index = HashFunction(s);
            for (int i = 0; i < arr.Length; i++)
            {
                int newIndex = (i + index) % arr.Length;
                if (arr[newIndex] != null&&arr[newIndex]==s)
                {
                    arr[index] = null;
                    return;
                }
            }
        }
        public void Print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine(arr[i]);
                    Debug.WriteLine($"Index is {i} and value is {arr[i]}. The Hash function is {HashFunction(arr[i])}");
                }
            }
        }
        public int HashFunction(string s)
        {
           return s.ToCharArray().Sum(m => (int)m)%arr.Length;
        }

    }
}
