using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Mensagem
{
    internal class Mensagem
    {
        public string TextoMensagem;


        public void exibirMensage()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
