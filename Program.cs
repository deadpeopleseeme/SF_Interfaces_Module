namespace SF_Interfaces_Module
{
     class Program
     {
         static void Main(string[] args)
         {
             Logger log = new Logger();
             Calc calc = new Calc(log);
             Console.WriteLine("Zdravo! Могу посчитать для вас сумму двух чисел\n");

             decimal? num1 = null, num2 = null;
             num1 = calc.GettingNumberFromInput(1);

             if(num1 != null) 
             {
                 num2 = calc.GettingNumberFromInput(2);
             }

             decimal? result = calc.Sum(num1, num2);
             if (result != null)
             {
                 Console.WriteLine($"Результат: {result}");
             }
             else
             {
                 Console.WriteLine("\nНикакого калькулирования для непослушных любителей калькулирования, которые вводят непонятно что вместо чисел :D");
             }
         }
     }
}
