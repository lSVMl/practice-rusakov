using System;

namespace practice_2._2__sort_string_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] sa = s.Split(" "); // чтобы разделить строку слова и поместить их в массив

            Array.Sort(sa); // метод для сортировки массива слов

            s = string.Join(" ", sa);
            Console.WriteLine(s);
        }
    }
}