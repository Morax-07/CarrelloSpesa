namespace Carrello_della_Spesa;

public class Schermo : Elettronico
{
    /* attributi */
    private float pollici;
    private string tipoLed;
    
    /* property */
    public float Pollici
    {
        get => pollici;
        set
        {
            while (value < 0)
                value = Convert.ToInt32(
                    Input.input("Il valore dei pollici inserito non e' valido, inserirlo di nuovo: ", ""));
            
            this.pollici = value;
        }
    }
    public string TipoLed { get => tipoLed; set => tipoLed = value; }
    
    /* costruttore */

    public Schermo(String nome, int codiceSeriale, float prezzo, float consumo, string tipoAlimentazione, List<string> pericoli, float pollici, string tipoLed) 
        : base(nome, codiceSeriale, prezzo, consumo, tipoAlimentazione, pericoli)
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

    public override string ToString()
    {
        String schermoToString = $"Nome: {Nome};\n" +
                                 $"Codice seriale: {CodiceSeriale};\n" +
                                 $"Prezzo: {Prezzo:F2}€;\n" +
                                 $"Consumo: {Consumo}kWh;\n" +
                                 $"Tipo di alimentazione: {TipoAlimentazione};\n" +
                                 $"Pericoli: ";
        
        for (int i = 0; i < pericoli.Count; i++) 
            schermoToString += (i != pericoli.Count - 1) ? $"{pericoli[i]}, " : $"{pericoli[i]};\n";
        
        schermoToString += $"Pollici: {Pollici}in;\nTipo di LED: {TipoLed};";
        
        
        return schermoToString;
    }

    public override String toJsonString()
    {
        return $"";
    }

    public override string getTipo()
    {
        return "Schermo";
    }
}