using System;

namespace lista_clientes
{
    public class DadosCliente
    {
        public string nome;
        public int idade;

        public DadosCliente(string n, int i)
        {   
            nome = n;

            if(i > 0)
            idade = i;
        }
    }
}