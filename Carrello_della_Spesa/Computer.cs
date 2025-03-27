namespace Carrello_della_Spesa;

public class Computer : Elettronico
{
    /* attributi */
    private InfoPC info;
    
    /* propriety */
    public InfoPC Info { get => info; set => info = value; }
    
    /* costruttore */
    public Computer(float consumo, string tipoAlimentazione, List<string> pericoli, InfoPC info) : base(consumo, tipoAlimentazione, pericoli)
    {
        Info = info;
    }
   
    /* costruttore copia */
    public Computer(Computer computer) : base(computer)
    {
        Info = computer.Info;
    }
}