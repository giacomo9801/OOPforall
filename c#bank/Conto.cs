internal class Conto
{
    double euro = 0;//moneta
    double saldo = 0;//saldo

    public Conto(double euro, double saldo)
    {
        this.euro = euro;
        this.saldo = saldo;
    }


    public void versamento(double euro)
    {
        saldo += euro;
    }
    public void prelievo(double euro)
    {
        saldo -= euro;
    }

    public void saldoattuale()
    {
        Console.WriteLine("Il saldo attuale è: " + saldo);
    }

}