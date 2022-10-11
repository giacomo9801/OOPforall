internal class Program
{
    private static void Main(string[] args)
    {
        double saldo_attuale = 500;
        double euro = 0;
        int scelta = 0;
        Conto conto = new Conto(euro, saldo_attuale);

        Console.WriteLine("Benvenuto in C# Bank!" + Environment.NewLine + "Il tuo saldo attuale è: " + saldo_attuale);
        Console.WriteLine("Premi 1 per depositare, 2 per prelevare, 3 per uscire");
        scelta = Convert.ToInt32(Console.ReadLine());
        switch (scelta)
        {
            case 1:
                Console.WriteLine("Quanto vuoi depositare?");
                euro = Convert.ToDouble(Console.ReadLine());
                conto.versamento(euro);
                Console.WriteLine("Il tuo saldo attuale è: ");
                conto.saldoattuale();
                Environment.Exit(0);
                break;
            case 2:
                Console.WriteLine("Quanto vuoi prelevare?");
                euro = Convert.ToDouble(Console.ReadLine());
                conto.prelievo(euro);
                Console.WriteLine("Il tuo saldo attuale è: ");
                conto.saldoattuale();
                Environment.Exit(0);
                break;
            case 3:
                Console.WriteLine("Grazie per aver usato C# Bank!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Scelta non valida!");
                Environment.Exit(0);
                break;
        }

    }
}