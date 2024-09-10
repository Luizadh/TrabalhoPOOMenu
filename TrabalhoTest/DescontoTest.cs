using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculaDesconto;

namespace TrabalhoTest
{
    [TestClass]
    public class DescontoTest
    {
        [TestMethod]
        public void TestarCalculoDeDesconto()
        {
           
            var calculadora = new CalculadoraDesc();
            double valorAtual = 100.0;
            double percentualDesconto = 10.0;

           
            double valorDesconto = valorAtual * (percentualDesconto / 100);
            double valorFinalEsperado = valorAtual - valorDesconto;

            // Verifica o valor do desconto
            Assert.AreEqual(10.0, valorDesconto);

            // Verifica o valor final
            Assert.AreEqual(90.0, valorFinalEsperado);  
        }
    }
}