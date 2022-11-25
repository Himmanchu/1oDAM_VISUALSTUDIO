using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemy : MonoBehaviour
{

    public Animator miAnim;
    public GameObject EnemyDead;

    public float vel = 1;

    //Dirección en la que se va a mover. Por defecto derecha
    public Vector3 dir = Vector3.right;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(dir * vel * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.tag == "Bala") || (other.gameObject.tag == "Player"))
        {
            //Generamos nuevos Enemigos muertos que se queden en escena unos segundos sin afectar al player
            Destroy(this.gameObject);
            GameObject newEnemyDead= (GameObject)Instantiate(EnemyDead, this.transform.position, this.transform.rotation);
            Destroy(newEnemyDead, 2);

        }
    }


}
