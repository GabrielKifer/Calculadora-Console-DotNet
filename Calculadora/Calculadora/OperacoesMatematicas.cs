using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class OperacoesMatematicas
    {
        public double Resultado { get; }

        public OperacoesMatematicas(int operacao, double valor1, double valor2)
        {

            switch (operacao)
            {
                case 1:
                    Resultado = Somar(valor1, valor2);
                    break;
                case 2:
                    Resultado = Subtrair(valor1, valor2);
                    break;
                case 3:
                    Resultado = Multiplicar(valor1, valor2);
                    break;
                case 4:
                    Resultado = Dividir(valor1, valor2);
                    break;

                default:
                    Console.WriteLine("Você não selecionou uma opção válida do menu. Tente novamente!");
                    break;
            }
        }


        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                throw new DivideByZeroException();
            }

            return valor1 / valor2;
        }
    }
}
