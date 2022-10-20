namespace Encapsulamento;

public class Conta
{
    private decimal saldo;

    public decimal Saldo
    {
        get => saldo;
        set
        {
            if (value < 0)
                throw new ArgumentException("O saldo deve ser maior que zero");

            saldo = value;                    
        }
    }
}
