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
            String computerToString = $"Nome: {Nome};\n" +
                                      $"Codice seriale: {CodiceSeriale};\n" +
                                      $"Prezzo: {Prezzo:F2}€\n" +
                                      $"Consumo: {Consumo}kWh\n" +
                                      $"Tipo di alimentazione: {TipoAlimentazione};\n" +
                                      $"Pericoli: ";

            for (int i = 0; i < pericoli.Count; i++) 
                computerToString += (i != pericoli.Count - 1) ? $"{pericoli[i]}, " : $"{pericoli[i]};\n";
            
            computerToString += $"Specifiche computer:\n{info.ToString()}";
            
            
            
            return computerToString;
        }

        public override String toJsonString()
        {
            return $"";
        }

        public override string getTipo()
        {
            return "Computer";
        }
    }
}