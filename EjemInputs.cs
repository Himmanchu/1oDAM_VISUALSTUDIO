using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemInputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(  Input.GetKey(KeyCode.A) );

        //Debug.Log(    Input.GetButton("Jump"));

        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("Se EMPIEZA a pulsar");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Se pulsa el bot?n");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Se TERMINA de pulsar");
        }

    }
}
