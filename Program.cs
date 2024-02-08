namespace AS2324.SpadiniLorenzo.Rubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            string[] nome = new string[100];
            string[] cognome = new string[100];
            string[] email = new string[100];
            string[] nickname = new string[100];
            int[] eta = new int[100];
            int[] simpatia = new int[100];

            for (int i = 0; i<100 ; i++)
            {
                Console.WriteLine("1) Inserimento completo nominativo");
                Console.WriteLine("2) Elenco dei nominativi inseriti");
                Console.WriteLine("3) Ricerca del nominativo in base al nickname");
                Console.WriteLine("9) Esci");
                Console.WriteLine("\nInserisci la tua scelta:");
                scelta = int.Parse(Console.ReadLine());

                if (scelta == 9)
                   break;

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("inserimento nominativo completo:");
                        Console.WriteLine("inserisci il tuo nome (obbligatorio):");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("inserisci il tuo cognome (obbligatorio):");
                        cognome[i] = Console.ReadLine();
                        Console.WriteLine("inserisci la email (facoltativo):");
                        email[i] = Console.ReadLine();
                        Console.WriteLine("inserisci il tuo nickname (obbligatorio)");
                        nickname[i] = Console.ReadLine();
                        Console.WriteLine("inserisci la tua età (facoltativo):");
                        eta[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("inserisci la tua simpatia (facoltativo):");
                        simpatia[i] = int.Parse(Console.ReadLine());
                        break;

                    
                }
            }


        }



    }
}

