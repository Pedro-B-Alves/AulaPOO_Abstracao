using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public override string Desconto(float valor)
        {
            Console.WriteLine("Você receberá 12% de desconto");
            valor = valor-(valor*0.12f);
            codigoDeBarras = "123456";
            Data = DateTime.Now;
            Console.WriteLine($"Data registrada - {Data}");
            Console.WriteLine($"Código de barras feito - {codigoDeBarras}");
            return "Voce terá que pagar "+valor+" Reais.";
            

        }

        public void Registrar(){
            Console.WriteLine("Registrado");
        }
    }
}