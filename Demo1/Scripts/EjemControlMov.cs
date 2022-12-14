using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemControlMov : MonoBehaviour
{
    public float vel;

    // Update is called once per frame
    void Update()
    {

        //Desplazamiento en el eje Z
        if (Input.GetKey(KeyCode.W))
        {
            //Aumentar el eje Z
            this.transform.Translate(0, 0, vel*Time.deltaTime);


        }

        if (Input.GetKey(KeyCode.S))
        {
            //Disminuir el eje Z
            this.transform.Translate(0, 0, -vel * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Aumentar el eje X
            this.transform.Translate(-vel * Time.deltaTime, 0, 0 );
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Disminuir el eje X
            this.transform.Translate(vel * Time.deltaTime, 0, 0);
        }
    }
}
