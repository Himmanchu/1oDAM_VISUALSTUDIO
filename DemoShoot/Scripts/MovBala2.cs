using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala2 : MonoBehaviour
{

    public float vel;

    
    // Update is called once per frame
    void Update()
    {
        //Mover el objeto con translate y sus vectores

        this.transform.Translate(this.transform.right, Space.World);

    }
}
