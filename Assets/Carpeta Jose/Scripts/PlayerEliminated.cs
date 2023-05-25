using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEliminated : MonoBehaviour
{
    /*
    El método IsVisibleFromCamera utiliza la función GeometryUtility.CalculateFrustumPlanes 
    para obtener los planos de frustum de la cámara y luego verifica si los límites del objeto 
    están dentro de esos planos utilizando GeometryUtility.TestPlanesAABB. 
    Si los límites del objeto están fuera de los planos del frustum de la cámara, 
    se considera que el objeto está completamente fuera de la vista de la cámara.
     */

    private Camera cammain;

    public GameObject elinimatedCanvas;
    
    private void Start()
    {
        cammain = Camera.main;
    }
    private void Update()
    {
        if (!IsVisibleFromCamera())
        {
            Destroy(gameObject);
            elinimatedCanvas.SetActive(true);
        }
    }
    private bool IsVisibleFromCamera()
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cammain);
        Bounds bounds = GetComponent<Renderer>().bounds;

        if (GeometryUtility.TestPlanesAABB(planes, bounds))
        {
            return true;
        }
        return false;
    }


}
