namespace Carrello_della_Spesa
{
    public class ValoriNutrizionali
    {
        /* attributi */
        private float proteine;
        private float carboidrati;
        private float grassi;
        private float calorieTotali;
        private float energiaPerCentoGrammi;
        private float pesoInGrammi;

    
        /* property */
        public float Proteine
        {
            get => proteine;
            set
            {
                while(value < 0 || value > 100)
                    value = Convert.ToInt32(Input.input("Il valore delle proteine inserito non è valido, inserirlo di nuovo: ", ""));
                
                this.proteine = value;
            }
        }
        public float Carboidrati 
        { 
            get => carboidrati;
            set
            {
                while(value < 0 || value > 100)
                    value = Convert.ToInt32(Input.input("Il valore delle proteine inserito non è valido, inserirlo di nuovo: ", ""));
                
                this.carboidrati = value;
            } 
        }
        public float Grassi
        {
            get => grassi; 
            set
            { 
                while(value < 0 || value > 100)
                    value = Convert.ToInt32(Input.input("Il valore delle proteine inserito non è valido, inserirlo di nuovo: ", ""));
                
                this.grassi = value;
            }
        }
        public float CalorieTotali
        {
            get => calorieTotali;
            set
            {
                while (value < 0 || value > 2500)
                    value = Convert.ToInt32(Input.input(
                        "Il valore delle calorie totali inserito non è corretto, inserirlo di nuovo: ", ""));
                
                this.calorieTotali = value;
            }
        }
        public float EnergiaPerCentoGrammi
        {
            get => energiaPerCentoGrammi;
            set
            {
                while(value < 0 || value > 700) 
                    value = Convert.ToInt32(Input.input("Il valore inserito dell'energia per 100g non e' valido, inserirlo di nuovo: ", ""));
                
                this.energiaPerCentoGrammi = value;
            }
        }
        public float PesoInGrammi
        {
            get => this.pesoInGrammi;
            set
            {
                while(value < 0 || value > 2000)
                    value = Convert.ToInt32(Input.input("Il valore del peso in grammi inserito non e' valido, inserirlo di nuovo: ", ""));
                
                this.pesoInGrammi = value;
            }
        }

    
        /* costruttore */
        public ValoriNutrizionali(float proteine, float carboidrati, float grassi, float calorieTotali,
            float energiaPerCentoGrammi, float pesoInGrammi)
        {
            Proteine = proteine;
            Carboidrati = carboidrati;
            Grassi = grassi;
            CalorieTotali = calorieTotali;
            EnergiaPerCentoGrammi = energiaPerCentoGrammi;
            PesoInGrammi = pesoInGrammi;
        }
    
        /* costruttore copia */
        public ValoriNutrizionali(ValoriNutrizionali valori)
        {
            Proteine = valori.Proteine;
            Carboidrati = valori.Carboidrati;
            Grassi = valori.Grassi;
            CalorieTotali = valori.CalorieTotali;
            EnergiaPerCentoGrammi = valori.EnergiaPerCentoGrammi;
            PesoInGrammi = valori.PesoInGrammi;
        }


        public override string ToString()
        {
            return
                $"Proteine: {Proteine};\nCarboidrati: {Carboidrati};\nGrassi: {Grassi};" +
                $"\nCalorie totali: {CalorieTotali}cal;\nEnergia per 100g: {EnergiaPerCentoGrammi};" +
                $"\nPeso in grammi: {PesoInGrammi};";
        }

        public String toJsonString()
        {
            return "\"Proteine\"";
        }
    }   
}