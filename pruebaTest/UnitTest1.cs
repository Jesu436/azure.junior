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

         
        
        Assert.AreEqual(resultadoEsperado,resultado);
    }
    
    [TestMethod]
    public void Resta_menos5_menos_mas2_y_da_menos7()
    {
         Calculadora calculadora = new Calculadora();
        var numero1 = -5;
        var numero2 = 2;
        var resultadoEsperado = -7;
        

        var resultado = calculadora.resta(numero1, numero2);

         
        
        Assert.AreEqual(resultadoEsperado,resultado);
    }
     
     [TestMethod]
    



   
    }


