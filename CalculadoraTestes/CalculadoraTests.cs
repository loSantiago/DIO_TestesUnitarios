namespace CalculadoraTestes;

public class CalculadoraTests
{
    private Calculadora.Calculadora calc;
    
    public CalculadoraTests()
    {
        calc = new Calculadora.Calculadora();
    }
    
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(8, 1, 9)]
    public void TesteSomar(int val1, int val2, int result)
    {
        int resultCalc = calc.Somar(val1, val2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Theory]
    [InlineData(5, 1, 4)]
    [InlineData(10, 8, 2)]
    public void TesteSubtrair(int val1, int val2, int result)
    {
        int resultCalc = calc.Subtrair(val1, val2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Theory]
    [InlineData(5, 1, 5)]
    [InlineData(10, 8, 80)]
    public void TesteMultiplicar(int val1, int val2, int result)
    {
        int resultCalc = calc.Multiplicar(val1, val2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Theory]
    [InlineData(5, 1, 5)]
    [InlineData(10, 8, 1)]
    public void TesteDividir(int val1, int val2, int result)
    {
        int resultCalc = calc.Dividir(val1, val2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Fact]
    public void DivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
            );
    }

    [Fact]
    public void TestarHistoricoOperações()
    {
        calc.Dividir(5, 2);
        calc.Dividir(5, 2);
        calc.Dividir(5, 2);
        calc.Dividir(5, 2);
        calc.Dividir(5, 2);
        
        Assert.NotEmpty(calc.Historico());
        Assert.Equal(3, calc.Historico().Count);
    }
}