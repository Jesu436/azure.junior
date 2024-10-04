namespace prueba;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void Suma_5_3y_da_8()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = 5;
        var numero2 = 3;
        var resultadoEsperado = 8;

        var resultado = calculadora.suma(numero1, numero2);
        var resultado2 = calculadora.resta(numero1, numero2);
        
        Assert.AreEqual(resultadoEsperado,resultado);
    }

} 