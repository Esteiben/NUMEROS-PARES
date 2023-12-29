// Solicitar desde teclado el ingreso de un número entero N, verificar cuantos dígitos pares tiene N. Ejemplo: N=34569, N tiene 2 dígitos pares (4,6).
using System;
using System.Diagnostics.CodeAnalysis;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, a = 10, n = 0, c = 1, d = 0, d1 = 0;
            int[] par = new int[10];
            do
            {
                Console.Write("Ingrese cuantas cifras tiene su numero (Maximo 10): ");
                v = int.Parse(Console.ReadLine());
                if (v <= 0)
                {
                    Console.WriteLine("Debe ingresar un numero positivo mayor a 0.");
                }

            } while (v <= 0);

            do
            {
                Console.Write("Ingrese un numero entero: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Debe ingresar un numero positivo mayor a 0.");
                }
            } while (n <= 0);

            if (v == 1)
            {
                if (n % 2 == 0)

                {
                    Console.WriteLine("{0} es par.", n);
                }
            }
            else
            {
                if (v == 2)
                {
                    for (int i = 0; i < v; i++)
                    {
                        d = n / a;
                        d1 = n - (n / a) * a;
                        if (d % 2 == 0)
                        {

                            par[c - 1] = d;
                            c = c + 1;
                        }
                        n = d1;
                        a = a / 10;
                    }

                    Console.WriteLine("El numero tiene {0} cifras pares:", c-1);
                    for (int k = 0; k < c - 1; k++)
                    {
                        Console.WriteLine(par[k]);
                    }
                }
            }

            if (v > 2)
            {
                for (int j = 0;j < v - 2;j++)
                {
                    a = a * 10;
                }     
                
                for (int i = 0; i < v; i++)
                {
                    d = n / a;
                    d1 = n - (n / a) * a;
                    if (d % 2 == 0)
                    {
                        
                        par[c-1] = d;
                        c = c + 1;
                    }
                    n = d1;
                    a = a / 10;
                }

                Console.WriteLine("El numero tiene {0} cifras pares:",c-1);
                for (int k = 0;k < c-1 ;k++)
                {
                    Console.WriteLine(par[k]);    
                }
            }
        }
    }
}
