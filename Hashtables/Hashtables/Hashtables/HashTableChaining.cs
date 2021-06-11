using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashtables
{
    public class Person
    {
        public string Name;
        public Person Next;
    }
    public class HashTableChaining
    {
        Person[] arr;
        public HashTableChaining()
        {
            arr = new Person[9];
        }

        public int HashFunction(string s)
        {
            return s.ToCharArray().Sum(m => (int)m) % arr.Length;
        }

        public void Add(Person p)
        {
            int index = HashFunction(p.Name);
            p.Next = arr[index];
            arr[index] = p;
        }

        public void Remove(string name)
        {
            int index = HashFunction(name);
            var c = arr[index];
            Person p = null;
            while (c != null && c.Name != name)
            {
                p = c;
                c = c.Next;
            }
            if (c != null)
            {
                if (p == null)
                {
                    arr[index] = c.Next;
                }
                else
                {
                    p.Next = c.Next;
                }
            }

        }

        public void Print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    var p = arr[i];
                    while (p != null)
                    {
                        Console.WriteLine(p.Name+"==="+i);
                        p = p.Next;
                    }
                }
            }
        }
    }
}
