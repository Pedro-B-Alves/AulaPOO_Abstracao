using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;

        protected float valor;

        //Métodos

        public string Cancelar(){
            return "";
        }

        //Obrigatório
        public abstract string Desconto(int valor);
    }
}