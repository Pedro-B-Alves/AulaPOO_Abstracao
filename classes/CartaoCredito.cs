using System;

namespace AulaPOO_Abstracao.classes
{
    public class CartaoCredito : Credito
    {
        public float AumentarLimite(float aumentarLimite){
            Limite = Limite + aumentarLimite;
            return Limite;
        }
        public override void Pagar(float valorPagar){
            valor = valor - valorPagar;
            if (valor <= 0)
            {
               Console.WriteLine("Valor Pago.");
            }else{
                Console.WriteLine("Você está devendo "+valor+" Reais.");
            }
            
        }
    }
}