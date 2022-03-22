using UnityEngine;

public class ComprobarPiso : MonoBehaviour
{
    public static bool estaEnPiso;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
    }
}
