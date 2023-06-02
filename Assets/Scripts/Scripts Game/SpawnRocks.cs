using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour
{
    public GameObject rockPrefab;
    public float spawnInterval = 0.2f;
    public float rockLifetime = 60f;

    private float timer = 0f;
    private bool startSpawning = false;

    private void Update()
    {
        if (!startSpawning)
        {
            timer += Time.deltaTime;
            if (timer >= 1f)
            {
                startSpawning = true;
                timer = 0f;
            }
        }
        else
        {
            timer += Time.deltaTime;

            if (timer >= spawnInterval)
            {
                SpawnRock();
                timer = 0f;
            }
        }
    }

    private void SpawnRock()
    {
        // Generar coordenadas aleatorias para el spawn de la roca
        float spawnX = Random.Range(-2.16f, 1.52f); // 3.5f; Rango en el eje X
        float spawnY = 1.15f; //-6.3f; //Altura desde donde caerá la roca

        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

        // Instanciar la roca
        GameObject rock = Instantiate(rockPrefab, spawnPosition, Quaternion.identity);

        // Destruir la roca después de cierto tiempo
        Destroy(rock, rockLifetime);
    }
}
