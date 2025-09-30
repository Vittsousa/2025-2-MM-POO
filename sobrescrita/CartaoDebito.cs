public class CartaoDebito : Cartao
{
    public virtual void Debitar(decimal valor)
    {
        Console.WriteLine("Chamando classe base");
        base.Debitar(valor);

        Console.WriteLine("Valor debitado no cartão de débito: " + valor);
        
    }
}