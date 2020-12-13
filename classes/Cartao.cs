using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;
        
        public string InformacaoCartao(){
            Console.WriteLine("Digite a bandeira do cartão");
            bandeira = Console.ReadLine();
            Console.WriteLine("Digite o número do cartão");
            numero = Console.ReadLine();
            Console.WriteLine("Digite o titular do cartão");
            titular = Console.ReadLine();
            Console.WriteLine("Digite o cvv do cartão");
            cvv = Console.ReadLine();
            return "Infomações Registradas";
        }
        public string SalvarCartao(){
            Console.WriteLine("Deseja salvar o cartão s/n");
            string salvar = Console.ReadLine();
            if(salvar == "s"){
                return "Cartão Salvo";
            }else{
                return "O cartão não foi Salvo";
            }
            
        }
        public override string Desconto(float valor)
        {
            return "";
        }
    }
}