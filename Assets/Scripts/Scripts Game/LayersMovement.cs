using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayersMovement : MonoBehaviour
{
    public float initialSpeed = 2f;
    public float speedIncrement = 0.2f;
    public float increaseInterval = 15f;

    private float elapsedTime;
    private float speed;

    private void Start()
    {
        speed = initialSpeed;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= increaseInterval)
        {
            speed += speedIncrement;
            elapsedTime = 0f;
        }

        GameObject[] capasObjects = GameObject.FindGameObjectsWithTag("Layers");

        foreach (GameObject capasObject in capasObjects)
        {
            Vector3 newPosition = capasObject.transform.position;
            newPosition.y -= speed * Time.deltaTime;
            capasObject.transform.position = newPosition;
        }
    }
}
