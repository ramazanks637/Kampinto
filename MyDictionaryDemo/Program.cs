using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Fatih");
            Console.WriteLine(isimler.Length);

            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
