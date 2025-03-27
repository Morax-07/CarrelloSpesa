namespace Carrello_della_Spesa;

public class Elettronico
{
    /* attributi */
   
    protected float consumo;
    protected string tipoAlimentazione;  
    protected List<string> pericoli;
    protected static DateOnly dataCorrente = DateOnly.FromDateTime(DateTime.Now);
    protected DateOnly fineGaranzia;
    protected List<string> tipiDiAlimentazioneAccettati = new List<string>{"Batterie AA", "Batterie AAA", "Batterie 9V", "Presa Italiana", "Presa Europea"};

    // protected List<string> tipiDiPericoloAccettati = new List<string> { "Esplosivo", "Incendiario", "Corrosivo", "Pericolo Ambientale" };
    
    /* propriety */
    public static DateOnly DataCorrente { get => dataCorrente; }
    public DateOnly FineGaranzia { get => fineGaranzia; set => fineGaranzia = value; }

     public float Consumo
     {
         get => consumo;
         set
         {
             while (value < 0)
             {
                 Console.WriteLine("Il prodotto non può consumare una quantità di energia negativa o nulla");
                 Console.WriteLine("Inserisci il consumo dell'elettrodomestico: ");
                 value = Convert.ToInt32(Console.ReadLine());
             }

             consumo = value;
         }
         
     }

     public string TipoAlimentazione
     {
         get => tipoAlimentazione;
         set
         {
             foreach (string tipo in tipiDiAlimentazioneAccettati)
             {
                 if (tipo == value)
                     tipoAlimentazione = value;
             }
         }
     }
    public List<string> Pericoli { get => pericoli; set => pericoli = value; }
    
    /* costruttore */
    public Elettronico(float consumo, string tipoAlimentazione, List<string> pericoli)
    {
        FineGaranzia = dataCorrente.AddYears(2);
        Consumo = consumo;
        TipoAlimentazione = tipoAlimentazione;
        Pericoli = pericoli;
    }
    
    /* costruttore copia */
    public Elettronico(Elettronico elettronico)
    {
        FineGaranzia = elettronico.FineGaranzia;
        Consumo = elettronico.Consumo;
        TipoAlimentazione = elettronico.TipoAlimentazione;
        Pericoli = elettronico.Pericoli;
    }

}
   


    