using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Carrello_della_Spesa
{
    public abstract class Prodotto
    {
        //attributi
        protected String nome;
        protected int codiceSeriale;
        protected float prezzo;
        private static readonly String[] nomiProdotti = {
            "Mela",
            "Banana",
            "Spaghetti",
            "Acqua",
            "Birra",
            "Vodka",
            "Acer Nitro 5",
            "MSI Katana GF66",
            "Asus ROG Strix G15",
            "Samsung Odyssey G7",
            "LG UltraGear 32GP850",
            "ASUS ROG Swift PG259QN"
        };
        private static List<int> codiciProdotti = new List<int>();





        
        //properties
        public String Nome
        {
            get => this.nome;
            set
            {
                bool nome_valido = false;


                while (!nome_valido)
                {
                    foreach (String nome in nomiProdotti)
                    {
                        if (value == nome)
                        {
                            nome_valido = true;
                            break;
                        }
                    }

                    if (!nome_valido)
                        value = Input.input("Il nome del prodotto non e' valido, inserirlo di nuovo: ", "");
                }
                
                this.nome = value;
            }
        }
        public int CodiceSeriale
        {
            get => this.codiceSeriale;
            set
            {
                while (value.ToString().Length != 8 || codiceGiaEsistente(value))
                    value = Convert.ToInt32(Input.input("Il codice seriale inserito non e' valido, inserirlo di nuovo: ", ""));
                
                this.codiceSeriale = value;
            }
        }
        public float Prezzo
        {
            get => this.prezzo;
            set
            {
                while (value < 0.1f || value > 2000f)
                    value = float.Parse(Input.input("Il prezzo inserito non e' valido, inserirlo di nuovo: ", ""));
                
                this.prezzo = value;
            }
        }
        
        
        
        
        
        
        
        //costruttore
        //per la creazione dei modelli dei prodotti
        protected Prodotto(String nome, int codiceSeriale, float prezzo)
        {
            Nome = nome;   
            CodiceSeriale = codiceSeriale;
            Prezzo = prezzo;
            
            codiciProdotti.Add(CodiceSeriale);
        }

        //costruttore copia
        //per l'inserimento dei modelli dei prodotti nel carrello
        protected Prodotto(Prodotto prodotto)
        {
            //non vengono usate le properties perché copia i modelli degli oggetti creati con valori già validi
            nome = String.Copy(prodotto.Nome);
            codiceSeriale = prodotto.CodiceSeriale;
            prezzo = prodotto.Prezzo;
        }

        
        //metodi
        private bool codiceGiaEsistente(int valore)
        {
            foreach (int codice in codiciProdotti)
            {
                if(valore == codice) return true;
            }
            
            return false;
        }
        public abstract String toJsonString();
        public abstract override string ToString();

        public String formatoScontrino()
        {
            return $"{CodiceSeriale,-10}{Nome,-30}{Prezzo:F2}€";
        }

        public abstract string getTipo();
    }
}