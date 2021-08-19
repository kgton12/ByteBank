using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario LoremYpsum = new Diretor("213"); // polimorfismo
            //CalcularBonificacao();
            //UsarSistema();

            try
            {
                ContaCorrente conta = new ContaCorrente(514, 5640);

            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Aconteceu um erro!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Aconteceu um erro!");
            }

           // Metodo();

            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }
        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

            Console.WriteLine("Não é possível fazer uma divisão por 0!");
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(Exception erro)
            {
                throw;//throw devolve o erro para o fluxo
            }

            
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("111.111.111-11");
            pedro.Nome = "Pedro";

            Auxiliar igor = new Auxiliar("111.111.111-11");
            igor.Nome = "Igor";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(igor);
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor Rodrigo = new Diretor("123.123.123-01");

            Rodrigo.Nome = "Rodrigo";
            Rodrigo.Senha = "123";
        }
    }
}
