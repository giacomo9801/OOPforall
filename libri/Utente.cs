internal class Utente
{
    public String id = "";
    public String nome = "";
    public String cognome = "";
    public int annoIscrizione = 0;

    public Utente(String id, String nome, String cognome, int annoIscrizione)
    {
        this.id = id;
        this.nome = nome;
        this.cognome = cognome;
        this.annoIscrizione = annoIscrizione;
    }
    public String denominazione()
    {
        return nome + " " + cognome;
    }


}