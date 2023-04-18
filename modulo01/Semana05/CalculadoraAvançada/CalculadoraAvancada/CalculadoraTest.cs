using CalculadoraAvancada.Calculadora;

namespace CalculadoraAvancadaTest
{
    public class CalculadoraTest
    {
        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(5, 5)]

        public void TestarSoma(int num1, int num2)
        {
            //receber o resultado
            int result = Calculadora.Somar(num1, num2);

            //resultado a ser esperado
            int esperado = 10;

            //executa a compara��o
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(5, 5.5)]
        public void TestarSomaDouble(double num1, double num2)
        {
            double result = Calculadora.Somar(num1, num2);
            double esperado = 10.5;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(5.5, 5.5)]
        public void TestarSomaFloat(float num1, float num2)
        {
            float result = Calculadora.Somar(num1, num2);
            float esperado = 11;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(5.5, 5.1, 10.6)]
        public void TestarSomaDecimal(decimal num1, decimal num2, decimal esperado)
        {
            decimal result = Calculadora.Somar(num1, num2);
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(10000000, 500000000)]
        public void TestarSomaLong(long num1, long num2)
        {
            long result = Calculadora.Somar(num1, num2);
            long esperado = 510000000;
            Assert.Equal(esperado, result);
        }
        // ----- /\ Soma /\ --------

        // ----- \/ Subtra��o \/ -----

        [Theory]
        [Trait("Categoria", "Subtra��o")]
        [InlineData(5, 5)]
        public void TestarSubtracaoInt(int num1, int num2)
        {
            int result = Calculadora.Subtracao(num1, num2);
            int esperado = 10;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Subtra��o")]
        [InlineData(5, 5.5)]
        public void TestarSubtracaoDouble(double num1, double num2)
        {
            double result = Calculadora.Subtracao(num1, num2);
            double esperado = 10.5;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Subtra��o")]
        [InlineData(5.5, 5.5)]
        public void TestarSubtracaoFloat(float num1, float num2)
        {
            float result = Calculadora.Subtracao(num1, num2);
            float esperado = 11;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Subtra��o")]
        [InlineData(5.5, 5.1, 10.6)]
        public void TestarSubtracaoDecimal(decimal num1, decimal num2, decimal esperado)
        {
            decimal result = Calculadora.Subtracao(num1, num2);
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Subtra��o")]
        [InlineData(10000000, 500000000)]
        public void TestarSubtracaoLong(long num1, long num2)
        {
            long result = Calculadora.Subtracao(num1, num2);
            long esperado = 510000000;
            Assert.Equal(esperado, result);
        }
        // ----- /\ Subtra��o /\ --------

        // -----\/ Multiplica��o \/ --------
        [Theory]
        [Trait("Categoria", "Multiplica��o")]
        [InlineData(5, 5)]
        public void TestarMultiplicacaoInt(int num1, int num2)
        {
            int result = Calculadora.Multiplicacao(num1, num2);
            int esperado = 10;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Multiplica��o")]
        [InlineData(5, 5.5)]
        public void TestarMultiplicacaoDouble(double num1, double num2)
        {
            double result = Calculadora.Multiplicacao(num1, num2);
            double esperado = 10.5;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Multiplica��o")]
        [InlineData(5.5, 5.5)]
        public void TestarMultiplicacaoFloat(float num1, float num2)
        {
            float result = Calculadora.Multiplicacao(num1, num2);
            float esperado = 11;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Multiplica��o")]
        [InlineData(5.5, 5.1, 10.6)]
        public void TestarMultiplicacaoDecimal(decimal num1, decimal num2, decimal esperado)
        {
            decimal result = Calculadora.Multiplicacao(num1, num2);
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Multiplica��o")]
        [InlineData(10000000, 500000000)]
        public void TestarMultiplicacaoLong(long num1, long num2)
        {
            long result = Calculadora.Multiplicacao(num1, num2);
            long esperado = 510000000;
            Assert.Equal(esperado, result);
        }
        // ----- /\ Multiplica��o /\ --------

        // -----\/ Divis�o \/ --------
        [Theory]
        [Trait("Categoria", "Divis�o")]
        [InlineData(5, 5)]
        public void TestarDivisaoInt(int num1, int num2)
        {
            int result = Calculadora.Divisao(num1, num2);
            int esperado = 10;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Divis�o")]
        [InlineData(5, 5.5)]
        public void TestarDivisaoDouble(double num1, double num2)
        {
            double result = Calculadora.Divisao(num1, num2);
            double esperado = 10.5;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Divis�o")]
        [InlineData(5.5, 5.5)]
        public void TestarDivisaoFloat(float num1, float num2)
        {
            float result = Calculadora.Divisao(num1, num2);
            float esperado = 11;
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", " ")]
        [InlineData(5.5, 5.1, 10.6)]
        public void TestarDivisaoDecimal(decimal num1, decimal num2, decimal esperado)
        {
            decimal result = Calculadora.Divisao(num1, num2);
            Assert.Equal(esperado, result);
        }
        [Theory]
        [Trait("Categoria", "Divis�o")]
        [InlineData(10000000, 500000000)]
        public void TestarDivisaoLong(long num1, long num2)
        {
            long result = Calculadora.Divisao(num1, num2);
            long esperado = 510000000;
            Assert.Equal(esperado, result);
        }
        // ----- /\ Divis�o /\ --------
    }
}


