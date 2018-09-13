using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Triangle
    {
        private ColorSide[] triangle = new ColorSide[3];

        Triangle(ColorSide[] sides)
        {
            for(int i = 0; i < sides.Length; i++)
            {
                triangle[i] = sides[i];
            }
        }

        public void print()
        {
            for (int i = 0; i < this.triangle.Length; i++)
            {
                Console.Write(this.triangle[i].getColor().getColor() + " ");
                Console.WriteLine(this.triangle[i].getLength());
            }
        }

        static void Main(string[] args)
        {
            ColorSide one = new ColorSide(new Color("yellow"), 1);
            ColorSide two = new ColorSide(new Color("yellow"), 1);
            ColorSide three = new ColorSide(new Color("red"), 1);
            ColorSide[] triangle = { one, two, three };
            Triangle onetwothree = new Triangle(triangle);
            onetwothree.print();
            Console.ReadKey();
        }

    }
}
