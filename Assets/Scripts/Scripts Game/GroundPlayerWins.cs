using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlayerWins : MonoBehaviour
{
    public GameObject winCanvas01;
    public GameObject winCanvas02;
    public GameObject winCanvas03;
    private PlayerController points;

    public GameObject cameraControllerObject;
    private CameraController cameraController;

    private void Start()
    {
        cameraController = cameraControllerObject.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            points = FindObjectOfType<PlayerController>();
            cameraController.speed = 0f;
            Debug.Log(points.getPoints());
            if (points.getPoints() <= 9)
            {
                winCanvas01.SetActive(true);
            }
            else if (points.getPoints() > 10 && points.getPoints() <= 13)
            {
                winCanvas02.SetActive(true);
                Debug.Log("Si llegó");
            }
            else if (points.getPoints() > 16 /* && points.getPoints() <= 16 */)
            {
                winCanvas03.SetActive(true);
            }
        }
    }
}
