namespace Carrello_della_Spesa
{
    static class Supermercato
    {
        public static void Main(String[] args)
        {
            List<Prodotto> prodotti = new List<Prodotto>();
            
            prodotti.Add(new Cibo("Mela",
                12345826, 
                3f, 
                new ValoriNutrizionali(0.3f, 0.5f, 0.1f, 75f, 18f, 4.16f),
                new DateOnly(2025, 4, 19)
            ));
            
            prodotti.Add(new Cibo("Banana",
                18930018, 
                2f, 
                new ValoriNutrizionali(0.3f, 0.2f, 0.2f, 120f, 21f, 5.71f),
                new DateOnly(2025, 4, 29)
            ));
            
            prodotti.Add(new Bevanda(
                "Acqua",
                19302977,
                1f,
                new ValoriNutrizionali(0, 0, 0, 0, 0, 500),
                false,
                0
            ));
            
            prodotti.Add(new Bevanda(
                "Birra",
                92837121,
                2f,
                new ValoriNutrizionali(0, 3, 0, 100, 20, 500),
                true,
                22
            ));
            
            
            
            foreach(Prodotto prodotto in prodotti) Console.WriteLine(prodotto.formatoScontrino());
        }
    }
}