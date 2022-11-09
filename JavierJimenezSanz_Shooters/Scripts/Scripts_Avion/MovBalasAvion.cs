using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBalasAvion : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       
            this.transform.Translate(this.transform.forward, Space.World);
        }
    }
