using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlayerWins : MonoBehaviour
{
    public GameObject winCanvas;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winCanvas.SetActive(true);
        }
    }
}
