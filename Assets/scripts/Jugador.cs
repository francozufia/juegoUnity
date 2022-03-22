using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    Rigidbody2D rb;   //referencia del rigidbody
    SpriteRenderer spriteRenderer; //refernecia para poder voltear el personaje
    JugadorAnim jugador;

    private AudioSource sonidoSalto;


    public float velocidadMovimiento;
    public float fuerzaSalto;
    public bool moviendo;
    public int puntaje;
    public Text textoPuntaje;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        jugador = GetComponent<JugadorAnim>();
        sonidoSalto = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = "Puntaje: " + puntaje;     //le pasa al canvas el puntaje

        moviendo = Input.GetAxisRaw("Horizontal") != 0;

        spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;  //si toca flecha para atras se voltea el personaje


        if (Input.GetKeyDown(KeyCode.Space) && ComprobarPiso.estaEnPiso)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            jugador.saltando();
            sonidoSalto.Play();
        }
    }


    private void FixedUpdate()      //se interactuan con las fisicas de unity 
    {
        Vector2 newVelocity;
        newVelocity.x = Input.GetAxisRaw("Horizontal") * velocidadMovimiento;
        newVelocity.y = rb.velocity.y;

        rb.velocity = newVelocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gema")   //si el jugador toca una gema se suma el puntaje y se destruye la gema
        {
            puntaje++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "gemaRoja")
        {
            puntaje = puntaje + 2;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "gemaVerde")
        {
            puntaje = puntaje + 5;
            Destroy(collision.gameObject);
        }
    }
}

