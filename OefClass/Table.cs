using System;
using System.Collections.Generic;
using System.Text;

namespace OefClass
{
    class Table
    {
        private int height;
        private int width;

        public Table(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void ShowData()
        {
            Console.WriteLine("De hoogte is {0} cm en de breedte is {1} cm !", height, width);
        }
    }
}
