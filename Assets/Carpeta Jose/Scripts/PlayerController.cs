using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class PlayerController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particulas;

    //Contar los puntos
    private int puntos = 0;

    private AudioSource sonidoJugador;

    public AudioClip sonidoSalto;
    public AudioClip sonidoOro;


    private Rigidbody2D rb;
    private Animator Animator;

    //Mover al jugador
    private Vector2 direccion;
    public float speed = 5f;

    //Hacer saltar al jugador
    public float fuerzaSalto = 4f;
    private bool puedeSaltar;

    //Traer los puntos de myData
    private MyData myData;

    //Para mostrar los puntos en el canvas
    public TextMeshProUGUI puntosText;
    public TextMeshProUGUI puntosFinalGO;
    public TextMeshProUGUI puntosFinalWin;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        sonidoJugador = GetComponent<AudioSource>();
    }
    void Update()
    {
        //Mover al jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //darse la vuelta a la izquierda
        if (x < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (x > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        //le dice al animator cuando cambiar de estado running/jumping
        Animator.SetBool("running", x != 0.0f);
        Animator.SetBool("jumping", y != 0.0f);


        direccion = new Vector2(x, y);
        rb.velocity = new Vector2(direccion.x * speed, rb.velocity.y);
        

        //Hacer saltar al jugador
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.Space)) && puedeSaltar)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            sonidoJugador.PlayOneShot(sonidoSalto, 1.0f);
            particulas.Play();
        }
    }
    //Si esta tocando algun objeto, podrá saltar
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            puedeSaltar = true;
        }
    }
    //Si NO esta tocando algun objeto, no podrá saltar
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            puedeSaltar = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (other.gameObject.CompareTag("CollectableOre"))
        {
            Destroy(other.gameObject);
            puntos++;
            Debug.Log("Puntos: " + puntos);
        }
        */
        //Para el canvas Score:
        if (other.gameObject.CompareTag("CollectableOre"))
        {
            sonidoJugador.PlayOneShot(sonidoOro, 6.0f);
            Destroy(other.gameObject);
            puntos++;
            puntosText.text = puntos.ToString();
            puntosFinalGO.text = puntos.ToString();
            puntosFinalWin.text = puntos.ToString();
        }
    }

    public int getPoints()
    {
        return puntos;
    }
}
