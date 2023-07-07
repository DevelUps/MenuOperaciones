using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOperaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado =0M;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.Write("Escoge una opcion:  ");

                // Pedimos una opcion
                opcion = Convert.ToInt16(Console.ReadLine());
            }
            while ((opcion<1) || (opcion >4));
            Console.Write("Ingresa el primer numero:  ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el Segundo numero:  ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // hacemos la operacion segun la operacion con un switch

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no valido ");
                    }
                    break;
            }
           
            Console.WriteLine("El resultado es{}:  ", resultado);
        }
    }
}
