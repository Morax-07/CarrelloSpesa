namespace Carrello_della_Spesa
{
    public static class Modelli
    {
        public enum Stato
        {
            menu
        };
        
        public static readonly List<Prodotto> modelliProdotti = new List<Prodotto>()
        {
            new Cibo(
                "Mela",
                81290144,
                0.2f,
                new ValoriNutrizionali(0, 0.1f, 0.1f, 200),
                DateOnly.FromDateTime(DateTime.Now.AddMonths(1))
            ),
            new Cibo(
                "Banana",
                67192033,
                1,
                new ValoriNutrizionali(0.1f, 0.3f, 0.2f, 200f),
                DateOnly.FromDateTime(DateTime.Now.AddMonths(1))
            ),
            new Cibo(
                "Spaghetti",
                69104888,
                1.5f,
                new ValoriNutrizionali(0, 5, 0.4f, 750),
                DateOnly.FromDateTime(DateTime.Now.AddYears(2))
            ),
            new Bevanda(
                "Acqua",
                12289164,
                0.7f,
                new ValoriNutrizionali(0, 0, 0, 1000),
                false,
                0
            ),
            new Bevanda(
                "Birra",
                54926618,
                1.5f,
                new ValoriNutrizionali(0.3f, 2.9f, 0, 1000),
                true,
                5
            ),
            new Bevanda( 
                "Vodka",
                10225782,
                8.7f,
                new ValoriNutrizionali(0, 0, 0, 1000),
                true,
                45
            ),
            new Computer(
                "Acer Nitro 5",
                23645100,
                999,
                0.1f,
                "Presa Italiana",
                new List<string>() {"Esplosivo", "Incendiario"},
                new InfoPC("Intel i7 11th gen", "16GB", "1TB", "Nvidia GTX 3050", "Acer", "Debian GNU/Linux 12 (bookworm) x86_64", 2f)
            ),
            new Computer(
                "MSI Katana GF66",
                46378890,
                1199,
                0.12f,
                "Presa Europea",
                new List<string>() {"Esplosivo", "Incendiario"},
                new InfoPC("Intel i7 12th gen", "32GB", "2TB", "Nvidia RTX 3060", "MSI", "Windows 11 Pro", 2.2f)
            ),
            new Computer(
                "Asus ROG Strix G15",
                19283376,
                1399,
                0.15f,
                "Presa Italiana",
                new List<string>() {"Esplosivo", "Incendiario"},
                new InfoPC("AMD Ryzen 9 6900HX", "16GB", "1TB SSD", "AMD Radeon RX 6800M", "Asus", "Windows 10", 2.4f)
            ),
            new Schermo(
                "Samsung Odyssey G7",
                34678901,
                699.99f,
                0.08f,
                "Presa Italiana",
                new List<string>() {"Radiazioni", "Surriscaldamento"},
                27f,
                "QLED"
            ),
            new Schermo(
                "LG UltraGear 32GP850",
                83920183,
                499.99f,
                0.07f,
                "Presa Europea",
                new List<string>() {"Incendiario", "Surriscaldamento"},
                32f,
                "Nano IPS"
            ),
            new Schermo(
                "ASUS ROG Swift PG259QN",
                90102234,
                599.99f,
                0.09f,
                "Presa Italiana",
                new List<string>() {"Esplosivo", "Incendiario"},
                24.5f,
                "Fast IPS"
            ),
        };
    }   
}