using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemRotaRb : MonoBehaviour
{

    public Rigidbody miRigid;

    // Start is called before the first frame update
    void Start()
    {
        miRigid.angularVelocity = new Vector3(0, 10, 0);


    }

    // Update is called once per frame
    void Update()
    {
        miRigid.AddTorque(0, 50 * Time.deltaTime, 0, ForceMode.Force);


    }
}
