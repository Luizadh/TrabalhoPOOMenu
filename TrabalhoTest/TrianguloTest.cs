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

            // Cenário
            double a = 3;
            double b = 4;
            double c = 5;
            //ação
            bool resultado = CalculoTriangulo.EhTriangulo(a, b, c);  //Valores válidos para o triângulo 

            //verificação
            Assert.IsTrue(resultado);
        }


        [TestMethod]

        public void TestarSeNaoEhTriangulo() //Valores inválidos para o triângulo 
        {
            // Cenário
            double d = 1;
            double e = 5;
            double f = 3;

            // Ação
            bool resultado = CalculoTriangulo.EhTriangulo(d, e, f);

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