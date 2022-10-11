internal class Program
{
    private static void Main(string[] args)
    {
        //variabili di sistema
        List<int> variabili_numeriche = new List<int>();
        variabili_numeriche.Add(1230);
        variabili_numeriche.Add(0823);
        variabili_numeriche.Add(1112);

        //lista di utenti che verranno aggiunti
        List<Utente> utenti = new List<Utente>();

        string newnome = "";
        int newpsw = 0;

        //scelte nei vari switch
        int sceltaswitch = 0;
        int sceltadopologin = 0;
        int sceltadoporegistrazione = 0;

        //Menù
        Console.WriteLine("Cosa vuoi fare?");
        Console.WriteLine("Accesso: 1)");
        Console.WriteLine("Registrazione: 2)");
        Console.WriteLine("Esci (con verifica delle variabili): 3)");
        sceltaswitch = Convert.ToInt32(Console.ReadLine());

        switch (sceltaswitch)
        {
            case 1://loggo
                Console.WriteLine("Inserisci il tuo nome");
                newnome = Console.ReadLine();
                Console.WriteLine("Inserisci la tua password");
                newpsw = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < utenti.Count; i++)
                {
                    if (utenti[i].getNome() == newnome && utenti[i].getPsw() == newpsw)
                    {
                        Console.WriteLine("##Accesso effettuato##");
                        Console.WriteLine("Cosa vuoi fare?");
                        Console.WriteLine("Aggiungi variabili: 1)");
                        Console.WriteLine("Modifica variabili: 2)");
                        Console.WriteLine("elimina variabili: 3)");
                        Console.WriteLine("Stampa variabili: 4)");
                        sceltadopologin = Convert.ToInt32(Console.ReadLine());
                        switch (sceltadopologin)
                        {
                            case 1:
                                Console.WriteLine("Inserisci il valore della variabile");
                                int newvariabile = Convert.ToInt32(Console.ReadLine());
                                variabili_numeriche.Add(newvariabile);
                                break;
                            case 2:
                                Console.WriteLine("Inserisci il valore della variabile da modificare");
                                int variabilemodificare = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Inserisci il nuovo valore della variabile");
                                int nuovovariabile = Convert.ToInt32(Console.ReadLine());
                                variabili_numeriche[variabilemodificare] = nuovovariabile;
                                break;
                            case 3:
                                Console.WriteLine("Inserisci il valore della variabile da eliminare");
                                int variabileeliminare = Convert.ToInt32(Console.ReadLine());
                                if (variabili_numeriche.Count < 1)
                                {
                                    Console.WriteLine("Le variabili non possono essere meno di 1");
                                }
                                else
                                {
                                    variabili_numeriche.RemoveAt(variabileeliminare);
                                }

                                break;
                            case 4:
                                for (int j = 0; j < variabili_numeriche.Count; j++)
                                {
                                    Console.WriteLine(variabili_numeriche[j]);
                                }
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("##Accesso negato##");
                    }
                }


                break;
            case 2://registro
                Console.WriteLine("Inserisci il tuo nome");
                newnome = Console.ReadLine();
                Console.WriteLine("Inserisci la tua password");
                newpsw = Convert.ToInt32(Console.ReadLine());
                utenti.Add(new Utente(newnome, newpsw));
                Console.WriteLine("##Registrazione effettuata##");
                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("Aggiungi variabili 1)");
                Console.WriteLine("Modifica variabili: 2)");
                Console.WriteLine("elimina variabili: 3)");
                Console.WriteLine("Stampa variabili: 4)");
                sceltadoporegistrazione = Convert.ToInt32(Console.ReadLine());
                switch (sceltadoporegistrazione)
                {
                    case 1:
                        Console.WriteLine("Inserisci il valore della variabile");
                        int newvariabile = Convert.ToInt32(Console.ReadLine());
                        variabili_numeriche.Add(newvariabile);
                        break;
                    case 2:
                        Console.WriteLine("Inserisci il valore della variabile da modificare");
                        int variabilemodificare = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci il nuovo valore della variabile");
                        int nuovovariabile = Convert.ToInt32(Console.ReadLine());
                        variabili_numeriche[variabilemodificare] = nuovovariabile;
                        break;
                    case 3:
                        Console.WriteLine("Inserisci il valore della variabile da eliminare");
                        int variabileeliminare = Convert.ToInt32(Console.ReadLine());
                        if (variabili_numeriche.Count < 1)
                        {
                            Console.WriteLine("Le variabili non possono essere meno di 1");
                        }
                        else
                        {
                            variabili_numeriche.RemoveAt(variabileeliminare);
                        }

                        break;
                    case 4:
                        for (int j = 0; j < variabili_numeriche.Count; j++)
                        {
                            Console.WriteLine(variabili_numeriche[j]);
                        }
                        break;
                }
                break;
            case 3://esco
                Console.WriteLine("Verifico se tutte le variabili sono pari...");
                for (int i = 0; i < variabili_numeriche.Count; i++)
                {
                    //verifico se ci sono variabili pari
                    if (variabili_numeriche[i] % 2 == 0)
                    {
                        Console.WriteLine("La variabili sono pari, uscita in corso...");
                    }
                    else
                    {
                        Console.WriteLine("Ci sono variabili dispari, impossibile uscire");
                        for (int j = 0; j < variabili_numeriche.Count; j++)
                        {
                            Console.WriteLine(variabili_numeriche[j]);
                        }
                        Console.WriteLine("Inserisci il valore della variabile da modificare (ricorda che partono da 0");
                        int variabilemodificare = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Stai modificando la variabile numero " + variabili_numeriche[variabilemodificare]);
                        Console.WriteLine("Inserisci il nuovo valore della variabile");
                        int nuovovariabile = Convert.ToInt32(Console.ReadLine());
                        variabili_numeriche[variabilemodificare] = nuovovariabile;
                        Console.WriteLine("La variabile è stata modificata");
                        Console.WriteLine("Nuova variabile: " + nuovovariabile);
                        Console.WriteLine("Lista aggiornata");
                        for (int j = 0; j < variabili_numeriche.Count; j++)
                        {
                            Console.WriteLine(variabili_numeriche[j]);
                        }
                        break;

                    }
                }
                break;
            default://caso limite
                Console.WriteLine("Scelta non valida");
                break;
        }
    }
}