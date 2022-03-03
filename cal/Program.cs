using System;

namespace cal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                double result, a, b;

                try
                {
                    Console.WriteLine("ILK REQEMI YAZIN");
                    a = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("IKINCI REQEMI YAZIN");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR!! HERIF VE YAXUD BAWQA BIR SIMVOLDAN ISTIFADE ETMEYIN > Enter <  DUYMESINI BASIN TEKRAR DENEYIN");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("secim edin '+' '-' '*' '/'");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine("= " + result);
                        break;


                    case "-":
                        result = a - b;
                        Console.WriteLine("= " + result);
                        break;


                    case "*":
                        result = a * b;
                        Console.WriteLine("= " + result);
                        break;

                    case "/":
                        result = a / b;
                        if (b == 0)
                        {
                            Console.WriteLine("SIFIRA BOLMEK OLMAZ!!!");
                        }
                        else
                        {
                            Console.WriteLine("= " + a / b);
                        }

                        break;

                    default:

                        Console.WriteLine("bele bir  emeliyyat sistemi yoxdur");

                        break;
                }
                Console.WriteLine("< Enter > Duymesini basaraq yenide istifade ede bilersiniz..");

                Console.ReadLine();

            }
        }
    }
}
