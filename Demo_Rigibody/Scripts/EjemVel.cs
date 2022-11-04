using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemVel : MonoBehaviour
{
    //Variable publica - Referencia del componente
    public Rigidbody miRigid;

    // Start is called before the first frame update
    void Start()
    {
        miRigid.velocity = new Vector3(1, 0, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
