using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanels : MonoBehaviour
{
    public GameObject panelControls;
    public GameObject PanelOptions;
    public GameObject Panelpause;


    void Update()
    {
        if (panelControls.activeInHierarchy || PanelOptions.activeInHierarchy || Panelpause.activeInHierarchy) // Validar que el panel de pausa esta activado
        {
            Time.timeScale = 0f; // Pausar el tiempo de juego
        }
        else
        {
            Time.timeScale = 1f; // Reanudar el tiempo del juego
        }
    }
}
