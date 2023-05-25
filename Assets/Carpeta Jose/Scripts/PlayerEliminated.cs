using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEliminated : MonoBehaviour
{
    /*
    El m�todo IsVisibleFromCamera utiliza la funci�n GeometryUtility.CalculateFrustumPlanes 
    para obtener los planos de frustum de la c�mara y luego verifica si los l�mites del objeto 
    est�n dentro de esos planos utilizando GeometryUtility.TestPlanesAABB. 
    Si los l�mites del objeto est�n fuera de los planos del frustum de la c�mara, 
    se considera que el objeto est� completamente fuera de la vista de la c�mara.
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
