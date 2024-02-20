using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("1) Inserimento completo nominativo");
                Console.WriteLine("2) Elenco dei nominativi inseriti");
                Console.WriteLine("3) Ricerca del nominativo in base al nickname");
                Console.WriteLine("4) Ricerca di tutti i nomi in base al nome con ricerca case insentive");
                Console.WriteLine("5) Ricerca di tutti i cognomi che iniziano per a prescindere da come è scritto ");
                Console.WriteLine("6) Ricerca di tutti i cognomi che contengono il dato ricercato a prescindere da come è scritto");
                Console.WriteLine("9) Esci");
                Console.WriteLine("\nInserisci la tua scelta:");
                scelta = int.Parse(Console.ReadLine());

                if (scelta == 9)
                    break;

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("\ninserimento nominativo completo:\n");
                        Console.WriteLine("inserisci il tuo nome (obbligatorio):");
                        nome[i] = Console.ReadLine();
                        while (string.IsNullOrEmpty(nome[i]))
                        {
                            Console.WriteLine("nome non valido inserirlo nuovamente:");
                            nome[i] = Console.ReadLine();
                        }
                        Console.WriteLine("inserisci il tuo cognome (obbligatorio):");
                        cognome[i] = Console.ReadLine();
                        while (string.IsNullOrEmpty(cognome[i]))
                        {
                            Console.WriteLine("cognome non valido inserirlo nuovamente:");
                            cognome[i] = Console.ReadLine();
                        }
                        Console.WriteLine("inserisci la email (facoltativo):");
                        email[i] = Console.ReadLine();
                        Console.WriteLine("inserisci il tuo nickname (obbligatorio)");
                        nickname[i] = Console.ReadLine();
                        while (string.IsNullOrEmpty(nickname[i]))
                        {
                            Console.WriteLine("nickname non valido inserirlo nuovamente:");
                            nickname[i] = Console.ReadLine();
                        }
                        Console.WriteLine("inserisci la tua età (facoltativo):");
                        eta[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine("inserisci la tua simpatia (facoltativo compreso tra 1 e 5):");
                        simpatia[i] = int.Parse(Console.ReadLine());
                        while (simpatia[i] < 1 || simpatia[i] > 5)
                        {
                            Console.WriteLine("valore per la simpatia inserito non valido, inserirlo nuovamente");
                            simpatia[i] = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nelenco di tutti i nominativi inseriti:\n");

                        for (int j = 0; j < i; j++)
                        {
                            Console.WriteLine($"nominativo {j + 1}:");
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
                        for (int t = 0; t < i; t++)
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

                    case 4:
                        Console.WriteLine("Inserisci il nome che vuoi ricercare (case insensitive):");
                        string nomeRicerca = Console.ReadLine();
                        bool trovato = false;
                        foreach (string nomeCorrente in nome)
                        {
                            if (nomeCorrente != null && nomeRicerca.ToUpper() == nomeCorrente.ToUpper())
                            {
                                Console.WriteLine($"Nome: {nomeCorrente}");
                                trovato = true;
                            }
                        }
                        if (!trovato) Console.WriteLine("Nome non trovato.");
                        break;

                    case 5:
                        Console.WriteLine("Ricerca di tutti i cognomi che iniziano con 'a' (case insensitive):");
                        for (int t = 0; t < i; t++)
                        {
                            if (cognome[t].ToUpper().StartsWith("A"))
                            {
                                Console.WriteLine($"Cognome: {cognome[t]}");
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Inserisci parte del cognome che vuoi cercare (case insensitive):");
                        string parteCognome = Console.ReadLine();
                        for (int t = 0; t < i; t++)
                        {
                            if (cognome[t].ToUpper().Contains(parteCognome.ToUpper()))
                            {
                                Console.WriteLine($"Cognome: {cognome[t]}");
                            }
                        }
                        break;
                }
            }
        }
    }
}

