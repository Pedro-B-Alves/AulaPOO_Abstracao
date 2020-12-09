using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            
            boleto.Desconto(10);

            Cartao cartao = new Cartao();

            cartao.Desconto(0);
        }
    }
}
