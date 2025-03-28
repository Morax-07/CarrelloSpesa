namespace Carrello_della_Spesa
{
    public class Computer : Elettronico
    {
        /* attributi */
        private InfoPC info;
    
        /* propriety */
        public InfoPC Info { get => info; set => info = value; }
    
        /* costruttore */
        public Computer(String nome, int codiceSeriale, float prezzo, float consumo, string tipoAlimentazione, List<string> pericoli, InfoPC info) 
            : base(nome, codiceSeriale, prezzo, consumo, tipoAlimentazione, pericoli)
        {
            Info = info;
        }
   
        /* costruttore copia */
        public Computer(Computer computer) : base(computer)
        {
            Info = computer.Info;
        }

        public override string ToString()
        {
            return $"";
        }

        public override String toJsonString()
        {
            return $"";
        }
    }
}