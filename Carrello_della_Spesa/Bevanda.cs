namespace Carrello_della_Spesa
{
    public class Bevanda: Alimento
    {
        //attributi
        private bool alcolico;
        private int gradazioneAlcolica;




        //properties
        public bool Alcolico
        {
            get => this.alcolico;
            set => this.alcolico = value;
        }
        public int GradazioneAlcolica
        {
            get => this.gradazioneAlcolica;
            set
            {
                if (!alcolico)
                {
                    this.gradazioneAlcolica = 0;
                    return;
                }

                while (value < 0 || value > 100)
                    value = Convert.ToInt32(
                        Input.input("Il valore della gradazione alcolica non e' corretto, inserirlo di nuovo: ", ""));
                
                this.gradazioneAlcolica = value;
            }
        }
        
        
        
        
        //costruttore
        //utilizzato per creare i modelli degli oggetti da aggiungere al carrello
        public Bevanda(String nome, int codiceSeriale, float prezzo, ValoriNutrizionali valoriNutrizionali, bool alcolico, int gradazioneAlcolica)
            : base(nome, codiceSeriale, prezzo, valoriNutrizionali)
        {
            Alcolico = alcolico;
            GradazioneAlcolica = gradazioneAlcolica;

            if (alcolico)
            {
                this.valoriNutrizionali.CalorieTotali = GradazioneAlcolica * 7;
                this.valoriNutrizionali.EnergiaPerCentoGrammi = (this.valoriNutrizionali.CalorieTotali / this.valoriNutrizionali.PesoInGrammi) * 100;
            }
        }
        
        
        //costruttore copia
        //utilizzato per creare gli oggetti da aggiungere al carrello
        public Bevanda(Bevanda bevanda) : base(bevanda)
        {
            Alcolico = bevanda.Alcolico;
            GradazioneAlcolica = bevanda.GradazioneAlcolica;
            valoriNutrizionali.CalorieTotali = bevanda.valoriNutrizionali.CalorieTotali;
            valoriNutrizionali.EnergiaPerCentoGrammi = bevanda.valoriNutrizionali.CalorieTotali;
        }
        
        
        //metodi
        public override string ToString()
        {
            return $"Nome: {Nome};\n" +
                   $"Codice seriale: {CodiceSeriale};\n" +
                   $"Prezzo: {Prezzo:F2}€;\n" +
                   $"Bevanda alcolica: " + ((alcolico) ? $"Si' {gradazioneAlcolica}%\n" : "No\n") +
                   "Valori nutrizionali:\n" +
                   $"{valoriNutrizionali.ToString()}";
        }


        public override String toJsonString()
        {
            return "";
        }

        public override string getTipo()
        {
            return "Bevanda";
        }
    }
}