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
                Console.WriteLine("\n1) Inserimento completo nominativo");
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
                        Console.WriteLine("\ninserimento nominativo completo:");
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

                    case 2:
                        Console.WriteLine("\nelenco di tutti i nominativi inseriti:\n");
                        
                        for(int j=0; j<i ; j++)
                        {
                            Console.WriteLine($"nome: {nome[j]}");
                            Console.WriteLine($"cognome: {cognome[j]}");
                            Console.WriteLine($"email: {email[j]}");
                            Console.WriteLine($"nickname: {nickname[j]}");
                            Console.WriteLine($"eta: {eta[j]}");
                            Console.WriteLine($"simpatia: {simpatia[j]}\n");
                        } 
                        break;

                     case 3:
                        Console.WriteLine("\nricerca nominativo in base la nickname:");
                        Console.WriteLine("\ninserisci il nickname:");
                        string ricercaNickname = Console.ReadLine();
                        for(int t=0; t<i; t++ ) 
                        {
                            if (ricercaNickname == nickname[t])
                            {
                                Console.WriteLine($"\nnome: {nome[t]}");
                                Console.WriteLine($"cognome: {cognome[t]}");
                                Console.WriteLine($"email: {email[t]}");
                                Console.WriteLine($"nickname: {nickname[t]}");
                                Console.WriteLine($"eta: {eta[t]}");
                                Console.WriteLine($"simpatia: {simpatia[t]}\n");
                            }

                        }
                        break;
                }
            }
        }
    }
}

