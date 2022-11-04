using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EjemDelta2 : MonoBehaviour
{
    float num1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        num1 = num1 + Time.deltaTime;
        Debug.Log(num1);
    }
}
