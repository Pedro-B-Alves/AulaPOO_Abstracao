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
          saldo = valor - saldo;
          if(saldo<valor){
            Console.WriteLine($"Você ficou devendo {saldo}");
            
          }else{
            Console.WriteLine("Você ficou com o saldo de "+saldo+" Reais"); 
          }
          
      } 
    }
}