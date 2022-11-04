using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemRayo1 : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        LanzarRayo();
    }

    void LanzarRayo()
    {
        //Variable para guardar el resultado/información del "choque" del rayo
        RaycastHit resultRay;

        if (Physics.Raycast(this.transform.position, this.transform.forward, out resultRay, 20))
        {

            //Estamos seguros de que el rayo SI ha colisionado con algo
            Debug.Log(resultRay.collider); //Ref del componente del objeto colisionado con el rayo
            Debug.Log(resultRay.point);
            Debug.Log(resultRay.transform.position);  //Ref del componente del objeto colisionado con el rayo
            Debug.Log(resultRay.transform.tag);
            Debug.Log(resultRay.transform.name);

        }

        else
        {
            Debug.Log("El rayo no dio con nada");
        }
    }
}
