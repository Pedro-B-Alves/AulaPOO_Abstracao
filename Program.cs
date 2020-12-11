using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Cartao cartao = new Cartao();
            CartaoCredito visa = new CartaoCredito();
            Credito credito = new Credito();
            Debito debito = new Debito();
            Console.WriteLine("Você tem que pagar as suas compras na loja");
            Console.WriteLine("Quanto deu o total das compras?");
            boleto.Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Deseja cancelar a compra s/n");
            string cancelando = Console.ReadLine();
            if (cancelando == "s")
            {
                boleto.Cancelar();
                return;
            }
            
            bool opcao = true;
            bool opcao5 = true;
            do
            {

                Console.WriteLine("Deseja pagar de que maneira [b]-boleto [c]-Cartão");
                string opcao2 = Console.ReadLine();
                switch (opcao2)
                {
                    case "b":
                        Console.WriteLine("Deseja registrar a compra s/n");
                        string opcao3 = Console.ReadLine();
                        if (opcao3 == "s")
                        {
                            boleto.Registrar();
                        }
                        Console.WriteLine(boleto.Desconto(boleto.Valor));
                        opcao = false;
                        return;
                    case "c":
                        opcao = false;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida");
                        break;
                }
            } while (opcao != false);
            do
            {
                Console.WriteLine("Deseja pagar de que maneira [c]-Cartão de Crédito [d]-Cartão de Débito");
                string opcao4 = Console.ReadLine();
                switch (opcao4)
                {
                    case "c":
                        cartao.InformacaoCartao();
                        Console.WriteLine(cartao.SalvarCartao());
                        Console.WriteLine("Deseja aumentar o limite s/n");
                        string aumentarLimite = Console.ReadLine();
                        if (aumentarLimite == "s")
                        {
                            Console.WriteLine("Você aumentou o seu limite em + 300");
                            visa.AumentarLimite(300);
                        }
                        credito.Pagar(boleto.Valor);
                        if (boleto.Valor>credito.Limite){
                            return;
                        }
                        visa.Pagar(900);
                        opcao5 = false;
                        break;
                    case "d":
                        Console.WriteLine(cartao.InformacaoCartao());
                        Console.WriteLine(cartao.SalvarCartao());
                        Console.WriteLine("Deseja ver o seu saldo s/n");
                        string verSaldo = Console.ReadLine();
                        if (verSaldo == "s")
                        {
                            Console.WriteLine("O seu saldo é de "+debito.Saldo+" Reais."); 
                        }
                        debito.Pagar(boleto.Valor);
                        opcao5 = false;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida");
                        break;
                }
                
            } while (opcao5 != false);
        }
    }
}
