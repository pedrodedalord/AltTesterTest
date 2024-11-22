using NUnit.Framework;
using UnityEngine;

public class BasicTest
{
    [Test]
    public void BasicAdditionTest()
    {
        int result = 2 + 2;
        int expected = 4;
        Assert.AreEqual(expected, result, "Incorrecto. El resultado esperado es 2"); 
        if (expected != result) {return;}
        Debug.Log("Correcto. Resultado esperado");
    }
}