using UnityEngine;

public class Villano : MonoBehaviour
{
    public Transform target;
    public float velocidad;


    void Update()
    {
        if (target == null)  //si no se selecciona como objetivo el juagdor por error no se mueve el enemigo
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, velocidad * Time.deltaTime);
    }
}
