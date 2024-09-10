using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public class CalculadoraDesc
    {
        public void CalcularEImprimir(double valorAtual, double percentualDesconto)
        {
            double valorDesconto = valorAtual * (percentualDesconto / 100);
            double valorFinal = valorAtual - valorDesconto;

            Console.WriteLine($"Valor atual: {valorAtual:C}");
            Console.WriteLine($"Percentual de desconto: {percentualDesconto}%");
            Console.WriteLine($"Valor do desconto: {valorDesconto:C}");
            Console.WriteLine($"Valor final da mercadoria: {valorFinal:C}");
        }

        public void Executar()
        {
            Console.Write("Digite o valor da mercadoria: ");
            double valorAtual = double.Parse(Console.ReadLine());


            Console.Write("Digite o percentual de desconto: ");
            double percentualDesconto = double.Parse(Console.ReadLine());

            CalcularEImprimir(valorAtual, percentualDesconto);
        }
    }
}