namespace prueba;

[TestClass]
public class FizzBuzzTest
{
    [TestMethod]
    public void Fizz_multiplo_3()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 3;
        var resultadoEsperado = true;
        var resultado = fizzBuzz.multiplo3(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Fizz_No_multiplo_3()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 8;
        var resultadoEsperado = false;
        var resultado = fizzBuzz.multiplo3(numero);
        Assert.AreEqual(resultadoEsperado, resultado);

    }

    [TestMethod]
    public void Buzz_multiplo_5()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 5;
        var resultadoEsperado = true;
        var resultado = fizzBuzz.multiplo5(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    public void Buzz_No_multiplo_5()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 7;
        var resultadoEsperado = false;
        var resultado = fizzBuzz.multiplo5(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void FizzBuzz_Multiplo_3_5()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 15;
        var resultadoEsperado = true;
        var resultado = fizzBuzz.multiplo35(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Print_Fizz()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 3;
        var resultadoEsperado = "Fizz";
        var resultado = fizzBuzz.printFizzBuzz(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Print_Buzz()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 5;
        var resultadoEsperado = "Buzz";
        var resultado = fizzBuzz.printFizzBuzz(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Print_FizzBuzz()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 15;
        var resultadoEsperado = "FizzBuzz";
        var resultado = fizzBuzz.printFizzBuzz(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Print_Numero()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        var numero = 7;
        var resultadoEsperado = $"{numero}";
        var resultado = fizzBuzz.printFizzBuzz(numero);
        Assert.AreEqual(resultadoEsperado, resultado);
    }

}