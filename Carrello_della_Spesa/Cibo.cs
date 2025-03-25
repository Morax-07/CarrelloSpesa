namespace Carrello_della_Spesa
{
    public class Cibo: Alimento
    {
        //attributi
        private DateOnly dataScadenza;
        
        
        
        //properties
        public DateOnly DataScadenza
        {
            get => dataScadenza;
            set
            {
                DateOnly oggi = DateOnly.FromDateTime(DateTime.Now);


                while (value == oggi)
                {
                    Console.WriteLine("La data di scadenza non può essere uguale a quella di oggi, inserirla di nuovo: ");
                    value = new DateOnly(
                        Convert.ToInt32(Input.input("Inserire l'anno: ", "")),
                        Convert.ToInt32(Input.input("Inserire il mese: ", "")),
                        Convert.ToInt32(Input.input("Inserire il giorno: ", ""))
                    );
                }
            }
        }
        
        
        
        
        //costruttore
        //utilizzato per la creazione dei modelli degli oggetti
        public Cibo(String nome, int codiceSeriale, float prezzo, ValoriNutrizionali valoriNutrizionali,
            DateOnly dataScadenza)
            : base(nome, codiceSeriale, prezzo, valoriNutrizionali)
        {
            this.dataScadenza = dataScadenza;
        }
        
        //costruttore copia
        //utilizzato per la creazione degli oggetti da aggiungere al carrello
        public Cibo(Cibo cibo) : base(cibo)
        {
            this.dataScadenza = new DateOnly(cibo.dataScadenza.Year, cibo.dataScadenza.Month, cibo.dataScadenza.Month);
        }


        public override String toJsonString()
        {
            return $"";
        }
    }
}