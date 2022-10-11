internal class Program
{
    private static void Main(string[] args)
    {
        Utente utente1 = new Utente("1", "Mario", "Rossi", 2010);
        Utente utente2 = new Utente("2", "Luigi", "Verdi", 2011);

        Libro libro1 = new Libro("1", "Il Signore degli Anelli", "bho");


        Console.WriteLine("###ESERCIZIO LIBRI###");
        Console.WriteLine("I nostri utenti sono : " + utente1.denominazione() + " e " + utente2.denominazione());
        Console.WriteLine("Prestiamo il libro al primo utente....");
        libro1.presta(utente1);

        if (libro1.utente.id == utente1.id)
        {
            Console.WriteLine("Il libro è stato prestato a " + utente1.denominazione());
        }
        else
        {
            Console.WriteLine("Il libro è stato prestato a " + utente2.denominazione());
        }

        Console.WriteLine("Verifichiamo se il libro è stato prestato già");
        if (libro1.presta(utente1) == true)
        {
            Console.WriteLine("Il libro è stato già prestato , non puoi averlo");
        }
        else
        {   //Si può anche cancellare 
            libro1.presta(utente2);
        }

        Console.WriteLine("Restituiamo il libro....");
        libro1.restituisci();
        Console.WriteLine("Prestiamo il libro al secondo utente....");
        libro1.presta(utente2);
        Console.WriteLine("Il libro è stato prestato a " + libro1.utente.denominazione());


    }
}