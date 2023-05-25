using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerColor : MonoBehaviour
{
    public List<string> Colors = new List<string>();

    private float startDelay = 4;
    private float repeatRate = 4;
    private string nameColor;
    private int indexColor = 0;
    public GameObject plataforma1;
    public GameObject plataforma2;
    public GameObject plataforma3;
    public GameObject plataforma4;
    private GameObject instantiatedPrefab2;


    private Renderer rend;


    private void Start()
    {
        rend = GetComponent<Renderer>();

        Colors.Add("blue");
        Colors.Add("red");
        Colors.Add("yellow");
        Colors.Add("purple");
        Colors.Add("orange");

        InvokeRepeating("changeColor", startDelay, repeatRate);

        instantiatedPrefab2 = Instantiate(plataforma1, plataforma1.transform.position, plataforma1.transform.rotation);
    }

    void changeColor()
    {
        
        nameColor = Colors[indexColor];
        Color newColor;

        if (ColorUtility.TryParseHtmlString(nameColor, out newColor))
        {
            rend.material.color = newColor;

            switch (indexColor)
            {
                case 0:
                    plataforma1.SetActive(false);
                    break;
                case 1:
                    plataforma2.SetActive(false);
                    break;
                case 2:
                    plataforma3.SetActive(false);
                    break;
                case 3:
                    plataforma4.SetActive(false);
                    break;
            }
        }

        indexColor = (indexColor + 1) % Colors.Count;
    }
}
