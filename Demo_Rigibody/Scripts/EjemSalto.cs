using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemSalto : MonoBehaviour
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
        //Chequeamos el botón

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //A saltar
            miRigid.velocity = new Vector3(0, vel, 0);


        }



    }
}
