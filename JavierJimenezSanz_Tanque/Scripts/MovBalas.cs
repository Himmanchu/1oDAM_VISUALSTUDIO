using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBalas : MonoBehaviour
{

    public float vel;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, vel * Time.deltaTime);


    }
}
