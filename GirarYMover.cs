using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarYMover : MonoBehaviour
{

    public Vector3 velRotacion;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(velRotacion);
        this.transform.Translate(0.01f, 0, 0, Space.World);
    }
}
