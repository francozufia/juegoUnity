using UnityEngine;

public class SpawnAleatorio : MonoBehaviour
{

    public Transform xMin;
    public Transform xMax;
    public Transform yMin;
    public Transform ymax;

    public GameObject[] gemas;

    public float tiempoSpawn = 0.5f;
    public float repetirSpawn = 2;

    void Start()
    {
        InvokeRepeating("spawnGemas", tiempoSpawn, repetirSpawn);
    }

    public void spawnGemas()
    {
        Vector3 posicionSpawn = new Vector3(0, 0, 0);

        posicionSpawn = new Vector3(Random.Range(xMin.position.x, xMax.position.x), Random.Range(yMin.position.y, ymax.position.y), 0);  //la posicon de spawn va a darse por los transforms de los gameobject de posicion creados

        GameObject gema = Instantiate(gemas[Random.Range(0, gemas.Length)], posicionSpawn, gameObject.transform.rotation);   //genera cualquier tipo de gemas
    }
}
