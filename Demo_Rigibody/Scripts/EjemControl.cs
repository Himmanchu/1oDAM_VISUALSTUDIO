using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemControl : MonoBehaviour
{

    public Rigidbody miRigid;

    public float vel;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        EjecutarMovimientos();

    }

        //Creamos un método para no sobrecargar el Update
    void EjecutarMovimientos()
    {
        //Chequear los inputs de dirección
        if (Input.GetKey(KeyCode.A))
        {
            miRigid.velocity = new Vector3(-vel, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            miRigid.velocity = new Vector3(vel, 0, 0);

        }
        if (Input.GetKey(KeyCode.W))
        {
            miRigid.velocity = new Vector3(0, 0, vel);

        }
        if (Input.GetKey(KeyCode.S))
        {
            miRigid.velocity = new Vector3(0, 0, -vel);

        }

    }
}
