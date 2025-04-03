using System.Net.Sockets;

namespace Carrello_della_Spesa
{
    public class Carrello
    {
        private List<Prodotto> prodotti;
        private float spesaTotale;






        public Carrello()
        {
            prodotti = new List<Prodotto>();
            spesaTotale = 0;
        }
        
        
        
        
        //operator overloading 
        //accede al singolo prodotto attraverso l'operatore []
        public string this[int indiceProdotto]
        {
            get
            {
                try
                {
                    return prodotti[indiceProdotto].ToString();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    return $"Non e' stato possibile accedere all'elemento ad indice {indiceProdotto}:\n" + e.Message;
                }
            }
        }

        //aggiunge un prodotto in fondo al carrello
        public void aggiungiProdotto(Prodotto prodotto)
        {
            switch (prodotto.getTipo())
            {
                case "Cibo":
                    prodotti.Add(new Cibo((Cibo)prodotto));
                    break;
                        
                case "Bevanda":
                    prodotti.Add(new Bevanda((Bevanda)prodotto));
                    break;
                        
                case "Computer":
                    prodotti.Add(new Computer((Computer)prodotto));
                    break;
                        
                case "Schermo":
                    prodotti.Add(new Schermo((Schermo)prodotto));
                    break;
                        
                default:
                    break;
            }
            
            spesaTotale += prodotto.Prezzo;
        }

        //rimuove un prodotto dal carrello
        public string rimuoviProdotto(int indiceProdotto)
        {
            try
            {
                prodotti.RemoveAt(indiceProdotto);
                return "Prodotto rimosso con successo!";
            }
            catch (ArgumentOutOfRangeException e)
            {
                return "C'e' stato un errore durante la rimozione del prodotto:\n" + e.Message;
            }
        }

        //ritorna il ToString() di ogni prodotto
        public override string ToString()
        {
            if (prodotti.Count == 0) return "Non sono presenti prodotti nel carrello!";
            
            
            string infoProdotti = $"INFO PRODOTTI\nNumero di prodotti nel carrello: {prodotti.Count}";
            
            foreach(Prodotto prodotto in prodotti)
                infoProdotti += prodotto.ToString() + "\n\n";
            
            return infoProdotti;
        }
        
        //ritorna tutti gli elementi (in forma breve con numero (indice + 1) e nome)
        public string getElementi()
        {
            string elementi = "";

            for (int i = 0; i < prodotti.Count; i++)
                elementi += $"{i + 1 + ".",-3} {prodotti[i].Nome}\n";
            
            return elementi;
        }

        //ritorna il numero di elementi del carrello
        public int getNumeroElementi()
        {
            return prodotti.Count;
        }
        
        //ritorna il carrello sottoforma di scontrino
        public string formatoScontrino()
        {
            if(prodotti.Count == 0) return "Non sono presenti prodotti!";
            
            
            
            string scontrino = "";
            
            foreach(Prodotto prodotto in prodotti) scontrino += prodotto.formatoScontrino() + "\n";
            
            scontrino += $"\n{"Spesa Totale:",-40}{spesaTotale:F2}€\n";
            
            
            return scontrino;
        }
    }   
}