using System;
using System.Collections.Generic;


namespace OefClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = new Table[10];

            Random rnd = new Random();

            for( int i = 0; i < 11; i++)
            {
                var w = rnd.Next(50, 201);
                var h = rnd.Next(50, 201);
                var t = new Table(w, h);
                tables[i] = t;
            }

            foreach (var t in tables)
            {
                t.ShowData();
            }
        }
    }
}
