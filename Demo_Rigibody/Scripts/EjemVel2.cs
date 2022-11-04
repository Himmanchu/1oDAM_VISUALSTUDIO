using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemVel2 : MonoBehaviour
{

    //Variable publica - Referencia del componente
    public Rigidbody miRigid;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        miRigid.velocity = new Vector3(1, 0, 0);
    }
}
