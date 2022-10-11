internal class Libro
{
    public String id = "";
    public String titolo = "";
    public String autore = "";
    public Utente utente = new Utente("", "", "", 0);


    public Libro(String id, String titolo, String autore)
    {
        this.id = id;
        this.titolo = titolo;
        this.autore = autore;

    }
    public String denominazione()
    {
        return titolo + " " + autore;
    }

    public bool presta(Utente utente)
    {
        this.utente = utente;
        return true;
    }

    public bool restituisci()
    {
        this.utente = new Utente("", "", "", 0);
        return true;
    }

}