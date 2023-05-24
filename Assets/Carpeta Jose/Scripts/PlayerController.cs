using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    //Mover al jugador
    private Vector2 direccion;
    public float speed = 6;

    //Hacer saltar al jugador
    private float fuerzaSalto = 6f;
    private bool puedeSaltar;

    //Contar los puntos
    private int puntos = 0;

    //Para mostrar los puntos en el canvas
    public TextMeshProUGUI puntosText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Mover al jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        direccion = new Vector2(x, y);
        rb.velocity = new Vector2(direccion.x * speed, rb.velocity.y);

        //Hacer saltar al jugador
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.Space)) && puedeSaltar)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
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
            Destroy(other.gameObject);
            puntos++;
            puntosText.text = "Score: " + puntos.ToString();
        }
    }
}
