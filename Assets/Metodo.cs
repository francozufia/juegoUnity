using UnityEngine;
using UnityEngine.SceneManagement;

public class Metodo : MonoBehaviour
{
    public void jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //carga la escena del juego
    }

    public void salir()
    {
        Application.Quit();
    }
}
