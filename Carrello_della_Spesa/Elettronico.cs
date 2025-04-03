namespace Carrello_della_Spesa
{
     public abstract class Elettronico: Prodotto
    {
        /* attributi */
        protected float consumo;
        protected String tipoAlimentazione;  
        protected List<string> pericoli = new List<string>();
        protected DateOnly fineGaranzia;
        private static readonly String[] tipiDiAlimentazioneAccettati =
        {
            "Batterie AA", 
            "Batterie AAA", 
            "Batterie 9V", 
            "Presa Italiana", 
            "Presa Europea"
        };
        private readonly static String[] tipiDiPericoloAccettati =
        {
            "Esplosivo", 
            "Incendiario", 
            "Corrosivo", 
            "Pericolo Ambientale",
            "Radiazioni",
            "Surriscaldamento"
        };

        
        
        /* propriety */
        public DateOnly FineGaranzia { get => fineGaranzia; set => fineGaranzia = value; }
        public float Consumo
         {
             get => consumo;
             set
             {
                 while (value < 0)
                     value = Convert.ToInt32(Input.input(
                         "Il prodotto non può consumare una quantità di energia negativa o nulla, Inserisci il consumo dell'elettrodomestico: ",
                         ""
                    ));
                 
                 consumo = value;
             }
             
         }
        public string TipoAlimentazione
         {
             get => tipoAlimentazione;
             set
             {
                 bool tipoAlimentazioneCorretto = false;

                 while (!tipoAlimentazioneCorretto)
                 {
                     foreach (string tipo in tipiDiAlimentazioneAccettati)
                     {
                         if (value == tipo)
                         {
                             this.tipoAlimentazione = value;
                             tipoAlimentazioneCorretto = true;
                         }
                     }
                     
                     if (!tipoAlimentazioneCorretto)
                         value = Input.input("Il tipo di alimentazione inserito non e' consentito, inserirlo di nuovo: ", "");
                 }
             }
         }
        public List<string> Pericoli
        {
            get => pericoli;
            set
            {
                foreach (string valore in value)
                {
                    foreach (string pericolo in tipiDiPericoloAccettati)
                    {
                        if (valore == pericolo) this.pericoli.Add(String.Copy(valore));
                    }
                } 
            }
        }
        
        
        
        
        /* costruttore */
        protected Elettronico(String nome, int codiceSeriale, float prezzo, float consumo, string tipoAlimentazione, List<string> pericoli)
            : base(nome, codiceSeriale, prezzo)
        {
            FineGaranzia = DateOnly.FromDateTime(DateTime.Now).AddYears(2);
            Consumo = consumo;
            TipoAlimentazione = tipoAlimentazione;
            Pericoli = pericoli;
        }
        
        /* costruttore copia */
        protected Elettronico(Elettronico elettronico): base(elettronico)
        {
            FineGaranzia = new DateOnly(elettronico.fineGaranzia.Year, elettronico.FineGaranzia.Month, elettronico.FineGaranzia.Day);
            Consumo = elettronico.Consumo;
            TipoAlimentazione = String.Copy(elettronico.TipoAlimentazione);
            
            
            List<string> pericoli = new List<string>();
            foreach (string pericolo in elettronico.Pericoli) pericoli.Add(String.Copy(pericolo));
            Pericoli = pericoli;
        }
        
        
        public abstract override string ToString();
        public abstract override String toJsonString();
        public abstract override string getTipo();
    }
}