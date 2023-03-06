using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenThrow : MonoBehaviour
{

    Rigidbody rb;

    //lock x and y rotation upon throw
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0,0,0);
        rb.isKinematic = true;
    }

    public void Throw(int num)
    {
        rb.AddForce(transform.forward*num, ForceMode.Impulse);
        this.transform.Rotate(90,0,0);
    }
}
