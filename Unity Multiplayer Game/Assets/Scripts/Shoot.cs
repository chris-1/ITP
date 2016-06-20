using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public string key;
    public Rigidbody bullet;

    public float speed = 40;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(key))
        {
            Rigidbody instantiatedProjectile = Instantiate(bullet,
                                                           transform.position,
                                                           transform.rotation)
                as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        }
    }
}
