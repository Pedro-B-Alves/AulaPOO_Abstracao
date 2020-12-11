using System;

namespace AulaPOO_Abstracao.classes
{
    public class Debito : Cartao
    {
      private float saldo = 600;
      public float Saldo{
        get{return saldo;}
      }
      protected int parcelas;

      public void Pagar(float valor){
          if(valor<=saldo){
            saldo = saldo - valor;
            Console.WriteLine($"Data de emissão - {Data}");
            Console.WriteLine($"Data de Vencimento - {Data.AddDays(10)}");
            Console.WriteLine("Você ficou com o saldo de "+saldo+" Reais"); 
            
          }else{
            Console.WriteLine("Você não tem dinheiro suficiente para concluir a compra");
            
          }
          
      } 
    }
}