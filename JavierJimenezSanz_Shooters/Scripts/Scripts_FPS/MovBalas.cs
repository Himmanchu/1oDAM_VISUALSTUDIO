using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBalas : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(this.transform.forward, Space.World);
    }
}
