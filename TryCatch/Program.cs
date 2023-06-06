
using System.Security.Cryptography;

try
{
    Console.Write("Informe o primeiro valor: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o segundo valor: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int d = a / b;
    Console.WriteLine($"O resultado é {d}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"Não é permitido divisão por zero! {ex.Message}");
}
catch(InvalidCastException ex)
{
    Console.WriteLine($"Conversãp de string para letra não é permitida! {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu um erro {ex.Message}");
}
finally
{       
    Console.WriteLine("Aqui passa de qualquer forma!");
}