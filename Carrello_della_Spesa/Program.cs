using Microsoft.CSharp.RuntimeBinder;

namespace Carrello_della_Spesa
{
    static class Supermercato 
    {
        private static Modelli.Stato stato = Modelli.Stato.menu;
        private static Carrello carrello = new Carrello();

        private static string menuComandi()
        {
            string menu = "COMANDI\n";
            int indiceComando = 0;

            menu += $"{++indiceComando + ".",-3} {"Inserisci nuovo prodotto",-35}{++indiceComando + ".",-3} {"Rimuovi prodotto",-35}{++indiceComando + ".",-3} {"Stampa carrello",-35}" +
                    $"{++indiceComando + ".",-3} {"Stampa scontrino",-35}\n{"0.",-3} {"Esci",-35}";
            
            menu += "\n\n";
            return menu;
        }


        private static string menuAggiuntaProdotto()
        {
            string menu = "AGGIUNTA PRODOTTO";
            for (int i = 0; i < Modelli.modelliProdotti.Count; i++)
            {
                if(i % 3 == 0)  menu += "\n";
                menu += $"{i + 1 + ".",-3} {Modelli.modelliProdotti[i].Nome,-25}";
            }
            
            menu += $"\n{"0.",-3} Torna a menu comandi";
            menu += "\n\n";
            
            return menu;
        }
        
        
        
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(menuComandi());
                int comando = Convert.ToInt32(Input.input("Inserisci il comando da eseguire:\n>> ", ""));
                bool ritornoAlMenu = false;
                int iterazioni = 0;

                
                
                
                switch (comando)
                {
                    //esci
                    case 0:
                    {
                        Console.Clear();
                        
                        
                        if (Input.input("Vuoi uscire? (S / N)\n>> ", "") == "S")
                            return;
                        else
                            break;
                    }
                    
                    //aggiunge un prodotto
                    case 1:
                    {
                        Console.Clear();
                        Console.Write(menuAggiuntaProdotto());

                        iterazioni = 0;
                        int indiceProdottoDaInserire = 0;
                        int quantita = 0;


                        do
                        {
                            if (iterazioni == 0)
                                indiceProdottoDaInserire = Convert.ToInt32(Input.input("Inserisci il numero del prodotto da inserire:\n>> ", "")) - 1;
                            else
                                indiceProdottoDaInserire = Convert.ToInt32(Input.input("Il valore inserito non e' valido, inserirlo di nuovo:\n>> ", "")) - 1;
                            
                            if (indiceProdottoDaInserire <= -1) ritornoAlMenu = true;

                            
                            
                            iterazioni++;
                        } while (indiceProdottoDaInserire >= Modelli.modelliProdotti.Count && !ritornoAlMenu);

                        if(ritornoAlMenu) break;
                        iterazioni = 0;

                        do
                        {
                            if (iterazioni == 0)
                                quantita = Convert.ToInt32(Input.input(
                                    $"Inserisci la quantita' di {Modelli.modelliProdotti[indiceProdottoDaInserire].Nome} da inserire:\n>> ",
                                    ""));
                            else
                                quantita = Convert.ToInt32(
                                    Input.input("La quantita' inserita non e' valida, inserirla di nuovo:\n>> ", ""));
                            
                            if (quantita <= 0) ritornoAlMenu = true;


                            iterazioni++;
                        } while (quantita <= 0 && !ritornoAlMenu);
                        
                        if (ritornoAlMenu) break;
                        iterazioni = 0;
                        
                        
                        for (int i = 0; i < quantita; i++)
                            carrello.aggiungiProdotto(Modelli.modelliProdotti[indiceProdottoDaInserire]);


                        Console.WriteLine("Il prodotto e' stato inserito correttamente!");
                        Console.ReadKey();
                        break;
                    }
                    
                    //rimuove un prodotto
                    case 2:
                    {
                        Console.Clear();

                        if (carrello.getNumeroElementi() == 0)
                        {
                            Console.WriteLine("Non sono presenti elementi nel carrello!");
                            Console.ReadKey();
                            break;
                        }
                        
                        Console.Write(carrello.getElementi() + $"{"0.",-3} Torna a menu comandi\n\n\n");



                        
                        int indiceProdottoDaRimuovere = 0;
                        
                        
                        do
                        {
                            if (iterazioni == 0)
                                indiceProdottoDaRimuovere =
                                    Convert.ToInt32(Input.input("Inserisci il numero del prodotto da rimuovere:\n>> ", "")) - 1;
                            else
                                indiceProdottoDaRimuovere = Convert.ToInt32(Input.input("Il valore inserito non e' valido, inserirlo di nuovo:\n>> ", "")) - 1;
                            
                            if (indiceProdottoDaRimuovere <= -1) ritornoAlMenu = true;
                            
                            
                            iterazioni++;
                        } while(indiceProdottoDaRimuovere >= carrello.getNumeroElementi() && !ritornoAlMenu);


                        if (ritornoAlMenu) break;
                        iterazioni = 0;
                        
                        String risultato = carrello.rimuoviProdotto(indiceProdottoDaRimuovere);
                        Console.WriteLine(risultato);
                        Console.ReadKey();
                        break;
                    }
                    
                    //stampa carrello
                    case 3:
                    {
                        Console.Clear();
                        
                        
                        
                        Console.Write(carrello.ToString());



                        Console.ReadLine();
                        break;
                    }
                    
                    //stampa scontrino
                    case 4:
                    {
                        Console.Clear();

                        
                        
                        Console.Write(carrello.formatoScontrino());
                        
                        

                        Console.ReadKey();
                        break;
                    }
                    
                    
                    //altri casi
                    default:
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Opzione non consentita!\n");
                        
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}