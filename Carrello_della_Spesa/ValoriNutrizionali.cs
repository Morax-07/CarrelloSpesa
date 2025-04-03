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
            set => calorieTotali = value;
        }
        public float EnergiaPerCentoGrammi
        {
            get => energiaPerCentoGrammi;
            set => energiaPerCentoGrammi = value;
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
        public ValoriNutrizionali(float proteine, float carboidrati, float grassi, float pesoInGrammi)
        {
            Proteine = proteine;
            Carboidrati = carboidrati;
            Grassi = grassi;
            PesoInGrammi = pesoInGrammi;
            
            this.calorieTotali = (this.carboidrati * 4) + (this.proteine * 4) + (this.grassi * 9);
            this.energiaPerCentoGrammi = (this.calorieTotali / this.pesoInGrammi) * 100;
        }
    
        /* costruttore copia */
        public ValoriNutrizionali(ValoriNutrizionali valori)
        {
            Proteine = valori.Proteine;
            Carboidrati = valori.Carboidrati;
            Grassi = valori.Grassi;
            calorieTotali = valori.CalorieTotali;
            energiaPerCentoGrammi = valori.EnergiaPerCentoGrammi;
            PesoInGrammi = valori.PesoInGrammi;
        }


        public override string ToString()
        {
            return
                $"\tProteine: {Proteine}g;\n\tCarboidrati: {Carboidrati}g;\n\tGrassi: {Grassi}g;" +
                $"\n\tCalorie totali: {CalorieTotali}cal;\n\tEnergia per 100g: {EnergiaPerCentoGrammi}cal;" +
                $"\n\tPeso in grammi: {PesoInGrammi}g;";
        }

        public String toJsonString()
        {
            return "";
        }
    }
}