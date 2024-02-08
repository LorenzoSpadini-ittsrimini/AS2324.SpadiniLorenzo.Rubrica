namespace AS2324.SpadiniLorenzo.Rubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            
            do
            {
                Console.WriteLine("1) Inserimento completo nominativo");
                Console.WriteLine("2) Elenco dei nominativi inseriti");
                Console.WriteLine("3) Ricerca del nominativo in base al nickname");
                Console.WriteLine("9) Esci");
                Console.WriteLine("\nInserisci la tua scelta:");
                scelta = int.Parse(Console.ReadLine());
            } while (scelta != 9);


        }

        
    }
}
