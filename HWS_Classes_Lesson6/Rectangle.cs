using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Classes_Lesson6
{
    internal class Rectangle
    {
        public double scope;
        public double area;
        //public double height;
        //public double width;
        public Rectangle(double height, double width)
        {
            //this.height = height;
            //this.width = width;
            scope = CalcScope(height, width);
            CalcArea(height, width);
        }

        private double CalcArea(double height, double width)
        {
            //Console.WriteLine($"area = {height * width}");
            return height * width;
        }

        private double CalcScope(double height, double width)
        {
            return (height + width) * 2;
        }

        public override string ToString()
        {
            return $"Area:{area}. Scope: {scope}";
        }

        //public override string ToString()
        //{
        //    return $"Area:{CalcArea()}. Scope: {CalcScope()}";
        //}
    }
}
