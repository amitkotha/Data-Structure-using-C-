using System;

namespace Hashtables
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HashTable hashFunction = new HashTable();
            hashFunction.Add("Amit");
            hashFunction.Add("Tom");
            hashFunction.Add("Matt");
            hashFunction.Add("Brat");
            hashFunction.Add("Kris");
            hashFunction.Add("Ana");
            hashFunction.Add("Dana");
            hashFunction.Add("Mana");
            hashFunction.Print();


            HashTableChaining hashTableChaining = new HashTableChaining();
            hashTableChaining.Add(new Person { Name = "Amit" });
            hashTableChaining.Add(new Person { Name = "Tom" });
            hashTableChaining.Add(new Person { Name = "Matt" });
            hashTableChaining.Add(new Person { Name = "Brat" });
            hashTableChaining.Add(new Person { Name = "Kris" });
            hashTableChaining.Add(new Person { Name = "Ana" });
            hashTableChaining.Add(new Person { Name = "Dana" });
            hashTableChaining.Add(new Person { Name = "Mana" });

            hashTableChaining.Print();
            Console.Read();
        }
    }
}
