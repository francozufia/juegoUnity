using UnityEngine;

public class JugadorAnim : MonoBehaviour
{
    Animator animator; //referencia al animador
    Jugador jugador;   //referencia al jugador

    void Start()
    {
        animator = GetComponent<Animator>();
        jugador = GetComponent<Jugador>();
    }


    void Update()
    {
        animator.SetBool("caminando", jugador.moviendo);
    }

    public void saltando()  //maneja el transicion del salto
    {
        animator.SetTrigger("Jump");
    }
}
