using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Classes_Lesson6
{
    public class Computer
    {
        public string model;
        public float price;
        public int numOfProccs;
        public float screenSize;
        public bool isTurnOn;

        public void TellMeThePrice()
        {
            Console.WriteLine($"price = {price}.");
        }

        public void TellMeTheScreeenSize()
        {
            Console.WriteLine($"screen Size = {screenSize}.");
        }

        public void TurnOn()
        {
            isTurnOn = true;
            Console.WriteLine("the computer is turn-on");
        }

        public void TurnOff()
        {
            isTurnOn = false;
            Console.WriteLine("the computer is turn-off");
        }

        public void AddProccessor()
        {
            numOfProccs++;
            price += 150;
        }


        public override string ToString()
        {
            return $"model: {model}. price: {price}. number Of Proccessors: {numOfProccs}. screen Size: {screenSize}. is Turn On : {isTurnOn}";
        }
    }
}
