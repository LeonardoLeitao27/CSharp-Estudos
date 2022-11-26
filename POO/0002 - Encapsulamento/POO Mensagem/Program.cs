using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Mensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Olá Mundo!";

            msg1.exibirMensage();

            Console.ReadKey();

        }
    }
}
