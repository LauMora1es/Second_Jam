using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "MyData", menuName = "Custom/MyData")]
public class MyData : ScriptableObject
{

    //Contar los puntos
    private int puntos = 0;

    public void setPoints(int point)
    {
        this.puntos = point;
    }

    public int getPoint()
    {
        return puntos;
    }

    public void pointAccumulator()
    {
        puntos++;
    }

    public void resetCount()
    {
        puntos = 0;
    }
}
