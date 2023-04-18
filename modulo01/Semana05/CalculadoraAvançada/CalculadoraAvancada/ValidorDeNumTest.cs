using CalculadoraAvancada.Calculadora;

namespace CalculadoraAvancadaTest
{
    internal class ValidorDeNumTest
    {
        public class ValidadorDeNumerosTest
        {
            [Fact]
            public void TesteEhNumeroPrimo()
            {
                bool resultado = ValidorDeNum.EhNumeroPrimo(17);

                Assert.True(resultado);
            }

            [Fact]
            public void TesteParOuImpar()
            {
                string resultado = ValidorDeNum.ParOuImpar(17);

                string esperado = "Impar";

                Assert.Equal(esperado, resultado);
            }

            [Fact]
            public void TesteEhDivisivelPor()
            {
                bool resultado = ValidorDeNum.EhDivisivelPor(15, 5);

                Assert.True(resultado);
            }
        }
    }
}
}
