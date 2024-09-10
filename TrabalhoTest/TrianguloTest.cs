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
            bool resultado = CalculoTriangulo.EhTriangulo(3, 4, 5);

            //verificação
            Assert.IsTrue(resultado);
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