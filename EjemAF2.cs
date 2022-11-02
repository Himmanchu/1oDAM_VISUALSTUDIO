using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemAF2 : MonoBehaviour
{

    //Referencia del componente
    public Rigidbody miRigid;

    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        miRigid.AddForce(fuerza*Time.deltaTime, 0, 0, ForceMode.Force);
    }
}
