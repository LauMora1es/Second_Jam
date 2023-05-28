using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlayerWins : MonoBehaviour
{
    public GameObject winCanvas01;
    public GameObject winCanvas02;
    public GameObject winCanvas03;
    private PlayerController points;

    private void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            points = GetComponent<PlayerController>();

            if (points.getPoints() <= 5)
            {
                winCanvas01.SetActive(true);
            }
            else if (points.getPoints() > 5 && points.getPoints() <= 12)
            {
                winCanvas02.SetActive(true);
            }
            else if (points.getPoints() > 12 && points.getPoints() <= 16)
            {
                winCanvas03.SetActive(true);
            }

        }
    }
}
