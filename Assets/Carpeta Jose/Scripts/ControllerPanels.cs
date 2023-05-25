using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanels : MonoBehaviour
{
    public GameObject panelMain;
    public GameObject panelControls;
    public GameObject panelCredits;
    public GameObject PanelOptions;
    public GameObject Panelpause;


    void Update()
    {
        if (panelMain.activeInHierarchy || panelControls.activeInHierarchy || panelCredits.activeInHierarchy
        || PanelOptions.activeInHierarchy || Panelpause.activeInHierarchy) // Validar que el panel de pausa esta activado
        {
            Time.timeScale = 0f; // Pausar el tiempo de juego
        }
        else
        {
            Time.timeScale = 1f; // Reanudar el tiempo del juego
        }
    }
}
