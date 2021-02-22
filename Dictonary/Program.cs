using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(1284, "Mehmet Ali");
            students.Add(1263, "Metin");
            students.Add(1168, "Alp");
            students.Add(1657, "Recep Ali");

            students.ToList();


        }
    }
}
