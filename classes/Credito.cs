using System;

namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        protected int parcelas;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

        public void Pagar(float valor){
            bool opcao = true;
            string opcao1;
            bool opcao2 = true;
            if (valor>limite)
            {
                Console.WriteLine("O seu limite não suporta uma compra desse valor");
                return;
            }else{
                do
                {
                    Console.WriteLine("Você quer parcelar a compra? s/n");
                    opcao1 = Console.ReadLine();
                    if (opcao1 == "s")
                    {
                        do
                        {
                            Console.WriteLine("Em quantas parcelas você quer pagar?");
                            Console.WriteLine("Juros de 5% em até 6 parcelas");
                            Console.WriteLine("Juros de 8% em 7 até 12 parcelas");
                            Console.WriteLine("Não é possível mais de 12 parcelas");
                            parcelas = int.Parse(Console.ReadLine());
                            if (parcelas<=6)
                            {
                            valor = valor+(valor*0.05f);
                            Console.WriteLine($"Você terá que pagar um total de {valor} Reais.");
                            Console.WriteLine($"Você pagará em cada parcelas um total de {valor/parcelas} Reais.");
                            opcao = false;
                            }else if(parcelas>=7 && parcelas<=12){
                            valor = valor+(valor*0.08f);
                            Console.WriteLine($"Você terá que pagar um total de {valor} Reais.");
                            Console.WriteLine($"Você pagará em cada parcela um total de {valor/parcelas} Reais.");
                            opcao = false;
                            }else{
                                Console.WriteLine("Digite um número valido");
                            }
                        } while (opcao != false);
                        opcao2 = false;
                    }else if(opcao1 == "n"){
                        Console.WriteLine($"Você terá que pagar um total de {valor} Reais.");
                        opcao2 = false;
                    }
                } while (opcao2 != false);
                
                
            }
            

        }
    }
}