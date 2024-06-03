namespace Calculadora;

public class Calculadora
{
    private List<string> listaHistorico;
    public int Somar(int val1, int val2)
    {
        int result = (val1 + val2);
        Historico($"{val1} + {val2} = {result}");
        return result;
    }
    
    public int Subtrair(int val1, int val2)
    {
        int result = (val1 - val2);
        Historico($"{val1} - {val2} = {result}");
        return result;
    }
    
    public int Multiplicar(int val1, int val2)
    {
        int result = (val1 * val2);
        Historico($"{val1} * {val2} = {result}");
        return result;
    }
    
    public int Dividir(int val1, int val2)
    {
        int result = (val1 / val2);
        Historico($"{val1} / {val2} = {result}");
        Console.WriteLine(result + "Result");
        return result;
    }

    public List<string> Historico(string? operacao = null)
    {
        if(operacao != null)
            listaHistorico.Insert(0, operacao);
        
        if(listaHistorico.Count > 3)
            listaHistorico.RemoveRange(3, listaHistorico.Count);
        
        return listaHistorico;
    }
    
}