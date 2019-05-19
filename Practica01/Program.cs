using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibnVal = -1;
            while (fibnVal < 0){
                Console.WriteLine("Ingresa el numero de fibonacci a mostrar (numero tiene que se mayor igual 0): ");
                fibnVal = Convert.ToInt32(Console.ReadLine());
            }
            fibn(fibnVal);
            Console.WriteLine("\nPresiona tecla para continuar....");
            Console.ReadLine();

            Console.WriteLine("Ingresa el texto para contar el numero de caracteres y numeros");
            stringTest(Console.ReadLine());
            Console.WriteLine("Presiona tecla para continuar....");
            Console.ReadLine();

        }


        static void fibn(int n)
        {
            int f1 = 0, f2 = 1, i;
            if (n < 1)
                return;

            for (i = 1; i <= n; i++){
                Console.Write(f2 + "  ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
        }


        static void stringTest(String word)
        {
            int characters=0;
            int numbers = 0;
            foreach (char c in word){
                if (c >= '0' && c <= '9')
                    ++numbers;
                else
                    ++characters;
            }
            Console.WriteLine("La palabra: " + word + " contine " + characters + " caracteres y " + numbers + " numeros");
        }

    }
}
