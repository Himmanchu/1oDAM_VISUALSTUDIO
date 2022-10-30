using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{
    public float vel;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(vel * Time.deltaTime, 0, 0);
    }
}
