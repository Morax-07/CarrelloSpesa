namespace Carrello_della_Spesa
{
    public static class Input
    {
        public static string? input(String testo, String endl = "\n")
        {
            Console.Write(testo + endl);
            return Console.ReadLine();
        }
    }
}