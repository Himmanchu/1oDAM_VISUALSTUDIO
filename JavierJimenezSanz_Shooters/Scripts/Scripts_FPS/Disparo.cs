using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public GameObject efectoOriginal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            DispararConRayo();
        }



        void DispararConRayo()
        {
            RaycastHit resultadoRayo;

            if(Physics.Raycast(this.transform.position,this.transform.forward, out resultadoRayo, 100))
            {
               // Debug.Log(resultadoRayo.transform.name);

                //Creamos efecto partícula
                Instantiate(efectoOriginal, resultadoRayo.point, this.transform.rotation);

            }
            else
            {
                Debug.Log("El rayo no colisiona con nada");
            }

        }
    }
}
