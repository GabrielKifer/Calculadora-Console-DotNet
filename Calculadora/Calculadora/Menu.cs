using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Menu
    {
        public void DesenharMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("*                       Calculadora                       *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("       Selecione uma opção do menu e pressione ENTER       ");
            Console.WriteLine();
            Console.WriteLine("1 - Somar 2 - Subtrair 3 - Multiplicar 4 - Dividir 0 - Sair");
            Console.WriteLine();
            Console.Write("Sua opção? ");
        }
    }
}
