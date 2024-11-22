using UnityEngine;

public class SceneLoadTests
{
    private GameObject startButton;

    /*[SetUp]
    public void Setup()
    {
        // Cargar la escena "Start" para realizar la prueba
        SceneManager.LoadScene("Start");
    }

    [UnityTest]
    public IEnumerator StartButtonLoadsMainScene()
    {
        // Esperar a que la escena "Start" esté completamente cargada
        yield return null;

        // Buscar el botón en la escena
        startButton = GameObject.Find("StartButton");
        Assert.IsNotNull(startButton, "El botón 'StartButton' no se encontró en la escena 'Start'.");

        // Simular la interacción con el botón
        startButton.GetComponent<UnityEngine.UI.Button>().onClick.Invoke();

        // Esperar un frame para que se cargue la escena
        yield return null;

        // Verificar que la escena "Main" se ha cargado
        Assert.AreEqual("Main", SceneManager.GetActiveScene().name, "La escena 'Main' no se cargó correctamente.");
    }

    [TearDown]
    public void Teardown()
    {
        // Limpiar cualquier cambio realizado en las pruebas
        if (SceneManager.GetActiveScene().name != "Start")
        {
            SceneManager.LoadScene("Start");
        }
    }*/
}