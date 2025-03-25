namespace Carrello_della_Spesa;

public class InfoPC
{
    /* attributi */
    private string processore;
    private string ram;
    private string archiviazione;
    private string gpu;
    private string schedaMadre;
    private string os;
    private float peso;
    
    /* metodi */
    
    /* Costruttore */
    public InfoPC(string processore, string ram, string archiviazione, string gpu, string schedaMadre, string os,
        float peso)
    {
        
    }
    
    /* Costruttore Copia */
    public InfoPC(InfoPC info)
    {
        
    }
    
    /* Propriety */
    
    public string Processore { get => processore; set => processore = value; }
    public string Ram { get => ram; set => ram = value; }
    public string Archiviazione { get => archiviazione; set => archiviazione = value; }
    public string Gpu { get => gpu; set => gpu = value; }
    public string SchedaMadre { get => schedaMadre; set => schedaMadre = value; }
    public string Os { get => os; set => os = value; }
    public float Peso { get => peso; set => peso = value; }
    
}