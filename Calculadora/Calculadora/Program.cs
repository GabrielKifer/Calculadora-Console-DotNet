using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Program
    {
        static void Main(string[] args)
        {
            bool fecharAplicativo = false;

            while (!fecharAplicativo)
            {
                Menu menu = new Menu();
                menu.DesenharMenu();

                try
                {
                    int operacaoSelecionada = Convert.ToInt32(Console.ReadLine());
                    if (operacaoSelecionada == 0)
                    {
                        System.Environment.Exit(0);
                    }

                    Console.Write("Digite um número e pressione ENTER: ");
                    double valorInput1 = double.Parse(Console.ReadLine().Replace(".", ","));

                    Console.Write("Digite um outro número e pressione ENTER: ");
                    double valorInput2 = double.Parse(Console.ReadLine().Replace(".", ","));

                    OperacoesMatematicas operacao = new OperacoesMatematicas(operacaoSelecionada, valorInput1, valorInput2);

                    Console.Write("Resultado: " + operacao.Resultado);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nErro: " + ex.Message + "\nVerifique os valores informados e tente novamente.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("\nErro: " + ex.Message + " Não é possível dividir por zero.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();


                Console.WriteLine("\nAplicação finalizada! Pressione qualquer tecla para voltar ao menu de seleção ou 'N' para encerrar a aplicação.");
                string selecao = Console.ReadLine();
                if (selecao.ToUpper() == "N")
                {
                    fecharAplicativo = true;
                }
            }
        }
    }
}