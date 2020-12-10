using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;

        public DateTime Data{
            get{return data;}
            set{data = value;}
        }
        protected float valor = 900;
        public float Valor{
            get{return valor;}
            set{valor = value;}
        }

        //Métodos

        public string Cancelar(){
            return "Compra Cancelada";
        }

        //Obrigatório
        public abstract string Desconto(float valor);
    }
}