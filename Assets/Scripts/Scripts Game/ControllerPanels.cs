using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanels : MonoBehaviour
{
    public GameObject panelControls;
    public GameObject PanelOptions;
    public GameObject Panelpause;
    public GameObject Panel_1;
    public GameObject Panel_2;
    public GameObject Panel_3;

    void Update()
    {
        if (panelControls.activeInHierarchy || PanelOptions.activeInHierarchy || Panelpause.activeInHierarchy
            || Panel_1.activeInHierarchy || Panel_2.activeInHierarchy || Panel_3.activeInHierarchy) // Validar que el panel de pausa esta activado
        {
            Time.timeScale = 0f; // Pausar el tiempo de juego
        }
        else
        {
            Time.timeScale = 1f; // Reanudar el tiempo del juego
        }
    }
}
