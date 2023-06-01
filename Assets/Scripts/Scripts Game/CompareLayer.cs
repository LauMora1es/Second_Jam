using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareLayer : MonoBehaviour
{
    public string compareColor;
    public string compareTag;

    
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer(compareColor) && other.gameObject.CompareTag(compareTag))
        {
            other.GetComponent<Collider2D>().isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(compareColor) && other.gameObject.CompareTag(compareTag))
        {
            other.GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
