internal class Utente {
    String nome="";
    int psw=0;
    public Utente(String nome, int psw) {
        this.nome=nome;
        this.psw=psw;
    }
    public String getNome() {
        return nome;
    }
    public int getPsw() {
        return psw;
    }
    public void setNome(String nome) {
        this.nome=nome;
    }
    public void setPsw(int psw) {
        this.psw=psw;
    }
    
}