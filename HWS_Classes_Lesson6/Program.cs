using System;

namespace HWS_Classes_Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Computer 

            Computer c1 = new Computer()
            {
                model = "Dell",
                price = 3700,
                screenSize = 15.7f,
                isTurnOn = true,
                numOfProccs = 16
            };
            Computer[] ccs = { c1, c1, c1, c1 };

            string s = "abc";
            Console.WriteLine(s.ToString());

            Console.WriteLine();
            //Console.WriteLine(c1);
            //Console.WriteLine(c1.ToString());
            //string res = c1.ToString();
            //Console.WriteLine(res);

            #endregion

            #region Table

            //way 1: with parameterless ctor
            Table t1 = new Table();
            t1.woodType = "alon";
            t1.color = "black";
            t1.numOfLegs = 3;

            //way 2: full Ctor
            Table t2 = new Table(woodType: "alon", color: "white",numOfLegs: 2);

            //way 3: obj initilizer
            Table t3 = new Table
            {
                color = "red",
                numOfLegs = 5,
                woodType = "alon"
            };

            //with equal(=) operator
            Table t4 = t2;
            #endregion

            #region Rectangle

            Rectangle r = new Rectangle(13, 15);

            #endregion
        }

    }
}
