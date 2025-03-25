namespace Carrello_della_Spesa;

public class ValoriNutrizionali
{
    /* attributi */
    private float proteine;
    private float carboidrati;
    private float grassi;
    private float calorieTotali;
    private float energiaPerCentoGrammi;
    
    /* property */
    public float Proteine { get => proteine; set => proteine = value; }
    public float Carboidrati { get => carboidrati; set => carboidrati = value; }
    public float Grassi { get => grassi; set => grassi = value; }
    public float CalorieTotali { get => calorieTotali; set => calorieTotali = value; }
    public float EnergiaPerCentoGrammi { get => energiaPerCentoGrammi; set => energiaPerCentoGrammi = value; }
    
    /* costruttore */

    public ValoriNutrizionali(float proteine, float carboidrati, float grassi, float calorieTotali,
        float energiaPerCentoGrammi)
    {
        Proteine = proteine;
        Carboidrati = carboidrati;
        Grassi = grassi;
        CalorieTotali = calorieTotali;
        EnergiaPerCentoGrammi = energiaPerCentoGrammi;
    }
    
    /* costruttore copia */

    public ValoriNutrizionali(ValoriNutrizionali valori)
    {
        Proteine = valori.Proteine;
        Carboidrati = valori.Carboidrati;
        Grassi = valori.Grassi;
        CalorieTotali = valori.CalorieTotali;
        EnergiaPerCentoGrammi = valori.EnergiaPerCentoGrammi;
    }
    
}