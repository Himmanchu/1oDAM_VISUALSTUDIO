using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    
    public float vel;

    
    // Update is called once per frame
    void Update()
    {
        //Rotación en el eje Y
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, vel * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, -vel * Time.deltaTime, 0, Space.Self);
        }

    }
}
