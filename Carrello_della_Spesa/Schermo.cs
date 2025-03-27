namespace Carrello_della_Spesa;

public class Schermo : Elettronico
{
    /* attributi */
    private float pollici;
    private string tipoLed;
    
    /* property */ 
    public float Pollici { get => pollici; set => pollici = value; }
    public string TipoLed { get => tipoLed; set => tipoLed = value; }
    
    /* costruttore */

    public Schermo(float consumo, string tipoAlimentazione, List<string> pericoli, float pollici, string tipoLed) : base( consumo, tipoAlimentazione, pericoli)
    {
        Pollici = pollici;
        TipoLed = tipoLed;
    }

    /* costruttore copia */
    public Schermo(Schermo schermo) : base (schermo)
    {
        Pollici = schermo.Pollici;
        TipoLed = schermo.TipoLed;
    }
}