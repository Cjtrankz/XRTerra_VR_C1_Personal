using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeBombExplode : MonoBehaviour
{

    public GameObject smoke;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.relativeVelocity.magnitude);
        if(collision.relativeVelocity.magnitude > 6.2)
        {
            //turn off mesh renderer maybe
            //Debug.Log("explode");
            Instantiate(smoke, transform.position, Quaternion.identity);
        
            
            //delete object
            Destroy(this.gameObject, 5);
        }
    }
}
