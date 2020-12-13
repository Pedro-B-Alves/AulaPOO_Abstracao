using System;

namespace AulaPOO_Abstracao.classes
{
    public class CartaoCredito : Credito
    {
        public float AumentarLimite(float aumentarLimite){
            Limite = Limite + aumentarLimite;
            return Limite;
        }
        public void DataCompra(){
            Data = DateTime.Now;
            Console.WriteLine($"Data de emissão - {Data}");
            Console.WriteLine($"Data de Vencimento - {Data.AddDays(10)}");
        }
    }
}