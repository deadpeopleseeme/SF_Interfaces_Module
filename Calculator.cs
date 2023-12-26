using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SF_Interfaces_Module
{
    //юзер может вводить числа любого типа, но мы юзаем decimal из-за максимальной точности. по крайней мере, тип числа в задаче не уточнялся :)
    internal interface ISumm
    {
        decimal? Sum(decimal? num1, decimal? num2);
    }
    internal class Calc: ISumm
    {
        
        public decimal? Sum(decimal? num1, decimal? num2)
        {
            return num1 + num2;
        }

        public decimal? GettingNumberFromInput(int whichNumber)
        {
            Console.WriteLine($"Введите число номер {whichNumber}: ");
            string userInput = Console.ReadLine().Replace(".", ",");

            bool isOk = decimal.TryParse(userInput, out decimal result);
            CalcLogger.DisplayCalcInfo(isOk);
            if (isOk)
            {   
                return result;
            }
            else 
            {
                return null; 
            }
        }

        Logger CalcLogger { get; }

        public Calc(Logger logger)
        {
            CalcLogger = logger;
        }
    }
}
