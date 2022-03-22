using UnityEngine;
using UnityEngine.SceneManagement;
public class MatarPersonaje : MonoBehaviour
{
    Collider2D colision;
    private AudioSource perder;

    void Start()
    {
        colision = GetComponent<Collider2D>();
        perder = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();  //encuentra todos los audios del juego

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            foreach (AudioSource sonido in audios)   //recorre todos los audios
            {
                perder.Play();
                sonido.Pause();
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);  //carga la escena del menu
        }
    }
}
