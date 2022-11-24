using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMata : MonoBehaviour
{

    public Animator miAnim;


    private void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.tag == "Suelo") || (other.gameObject.tag == "Enemy"))
        {
            Destroy(this.gameObject);

        }
    }
}
