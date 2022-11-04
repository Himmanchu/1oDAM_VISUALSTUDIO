using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemAF : MonoBehaviour
{

    //Referencia del componente
    public Rigidbody miRigid;

    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        miRigid.AddForce(fuerza, 0, 0, ForceMode.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
