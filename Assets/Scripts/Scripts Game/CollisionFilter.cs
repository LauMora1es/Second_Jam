using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFilter : MonoBehaviour
{
    public string allowedTag; // Etiqueta del objeto permitido para colisionar // BlueWalls

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(allowedTag))
        {
            // Si toca el objeto con la etiqueta (Tag) BlueWalls
            //Debug.Log("Colisión permitida con: " + other.gameObject.name);
            GetComponent<Collider2D>().isTrigger = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si la colision es diferente al objeto con la etiqueta (Tag) BlueWalls
        if (!collision.gameObject.CompareTag(allowedTag))
        {
            GetComponent<Collider2D>().isTrigger = true;
            //Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.collider);
        }
    }
    /*
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(allowedTag))
        {
            Debug.Log("Colisión NO permitida con: " + other.gameObject.name);
            GetComponent<Collider2D>().isTrigger = true;
        }
    }
    */
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer(compareLayer))
        {
            other.GetComponent<Collider2D>().isTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(compareLayer))
        {
            other.GetComponent<Collider2D>().isTrigger = false;
        }
    }
    */
}
