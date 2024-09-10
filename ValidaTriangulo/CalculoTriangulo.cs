using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaTriangulo
{
    public static class CalculoTriangulo
    {
        public static bool EhTriangulo(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static string TipoTriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilátero";
            else if (a == b || a == c || b == c)
                return "Isósceles";
            else
                return "Escaleno";
        }

        public static void Executar()
        {
            Console.Write("Digite o primeiro lado do triângulo: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo lado do triângulo: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro lado do triângulo: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (EhTriangulo(lado1, lado2, lado3))
            {
                Console.WriteLine("É um triângulo " + TipoTriangulo(lado1, lado2, lado3));
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }
        }
    }
}