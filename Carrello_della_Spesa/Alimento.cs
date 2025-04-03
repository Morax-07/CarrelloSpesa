namespace Carrello_della_Spesa
{
    public abstract class Alimento: Prodotto
    {
        protected ValoriNutrizionali valoriNutrizionali;
        
        



        
        //costruttore
        //utilizzato per la creazione dei modelli degli oggetti
        protected Alimento(String nome, int codiceSeriale, float prezzo, ValoriNutrizionali valoriNutrizionali)
            : base(nome, codiceSeriale, prezzo)
        {
            this.valoriNutrizionali = valoriNutrizionali;
        }

        //costruttore copia
        //utilizzato per la creazione degli oggetti aggiunti al carrello
        protected Alimento(Alimento alimento) : base(alimento)
        {
            valoriNutrizionali = new ValoriNutrizionali(alimento.valoriNutrizionali);
        }
        
        
        
        //metodi
        public abstract override String toJsonString();
        public abstract override string ToString();
        public abstract override string getTipo();
    }
}