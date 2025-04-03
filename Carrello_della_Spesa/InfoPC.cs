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
    
    
    /* Propriety */
    
    public string Processore { get => processore; set => processore = value; }
    public string Ram { get => ram; set => ram = value; }
    public string Archiviazione { get => archiviazione; set => archiviazione = value; }
    public string Gpu { get => gpu; set => gpu = value; }
    public string SchedaMadre { get => schedaMadre; set => schedaMadre = value; }
    public string Os { get => os; set => os = value; }
    public float Peso { get => peso; set => peso = value; }

    /* Costruttore */
    public InfoPC(string processore, string ram, string archiviazione, string gpu, string schedaMadre, string os,
        float peso)
    {
        Processore = processore;
        Ram = ram;
        Archiviazione = archiviazione;
        Gpu = gpu;
        SchedaMadre = schedaMadre;
        Os = os;
        Peso = peso;
    }
    
    /* Costruttore Copia */
    public InfoPC(InfoPC info)
    {
        Processore = String.Copy(info.Processore);
        Ram = String.Copy(info.Ram);
        Archiviazione = String.Copy(info.Archiviazione);
        Gpu = String.Copy(info.Gpu);
        SchedaMadre = String.Copy(info.SchedaMadre);
        Os = String.Copy(info.Os);
        Peso = info.Peso;
    }

    public override string ToString()
    {
        return $"\tProcessore: {Processore};\n\tRam: {Ram};\n\tArchiviazione: {Archiviazione};\n\t" +
               $"GPU: {Gpu};\n\tScheda Madre: {SchedaMadre};\n\tOS: {Os};\n\tPeso: {Peso}g;";
    }

    public String toJsonString()
    {
        return $"";
    }
}