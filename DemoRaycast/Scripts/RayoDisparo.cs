using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoDisparo : MonoBehaviour
{
    //Referencia del objeto a clonar
    public GameObject flare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Disparar
            DispararConRayo();

        }
        
    }

    void DispararConRayo()
    {

        RaycastHit resultRayo;

            if (Physics.Raycast(this.transform.position, this.transform.forward, out resultRayo, 100))
            {
                Debug.Log(resultRayo.transform.name);

            //Sacamos efecto partícula
            Instantiate(flare, resultRayo.point, this.transform.rotation);

            //Destruir objeto entrando a través del .transform o .collider
            if (resultRayo.transform.tag == "Enemy")
            {
                Destroy(resultRayo.transform.gameObject);
            }
        }
            else
            {
                Debug.Log("El rayo no colisiona");
            }
        }

}
