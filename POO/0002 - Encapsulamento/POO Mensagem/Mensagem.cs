using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Mensagem
{
    internal class Mensagem
    {
        private string TextoMensagem;

        //Exibir a classe TextoMensagem do objeto mensagem.
        public void exibirMensage()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        //Método de acesso
        //Retornar o valor privado
        public string getTextoMensagem()
        {
            return this.TextoMensagem;
        }

        //Método de acesso
        //Alterar o valor privado
        public void setTextoMensagem(String valor)
        {
            this.TextoMensagem = valor;
        }

    }
}
