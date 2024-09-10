
using CalculaDesconto;
using ValidaTriangulo;
namespace Menu
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("0) Sair");
                Console.WriteLine("1) Calcular Desconto");
                Console.WriteLine("2) Validar Triângulo");
                Console.WriteLine("Escolha uma das opções acima: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // metodo não estático: Para chama-lo é preciso a criação de uma instância da classe.
                        var calculadora = new CalculadoraDesc();
                        calculadora.Executar();
                        break;
                    case 2:
                        // metodo estático: 
                        CalculoTriangulo.Executar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }
    }
}