using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaTriangulo;

namespace TrabalhoTest
{
    [TestClass]
    public class TrianguloTest
    {
        [TestMethod]
        public void TestarSeEhTriangulo()
        {
            //ação
            bool resultado = CalculoTriangulo.EhTriangulo(3, 4, 5);  //Valores válidos para o triângulo 

            //verificação
            Assert.IsTrue(resultado);
        }


        [TestMethod]

        public void TestarSeNaoEhTriangulo() //Valores inválidos para o triângulo 
        {
            // Cenário
            double a = 1;
            double b = 5;
            double c = 3;

            // Ação
            bool resultado = CalculoTriangulo.EhTriangulo(a, b, c);

            // Verificação
            Assert.IsFalse(resultado);
        }


        [TestMethod]
        public void TestarTipoTrianguloEquilatero()
        {
            // ação
            string tipo = CalculoTriangulo.TipoTriangulo(3, 3, 3);

            //verificação
            Assert.AreEqual("Equilátero", tipo);
        }

        [TestMethod]
        public void TestarTipoTrianguloIsosceles()
        {
            //ação
            string tipo = CalculoTriangulo.TipoTriangulo(3, 3, 2);

            //verificação
            Assert.AreEqual("Isósceles", tipo);
        }

        [TestMethod]
        public void TestarTipoTrianguloEscaleno()
        {
            //ação
            string tipo = CalculoTriangulo.TipoTriangulo(3, 4, 5);

            //verificação
            Assert.AreEqual("Escaleno", tipo);
        }
    }
}