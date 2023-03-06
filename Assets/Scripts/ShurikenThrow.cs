using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenThrow : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    //lock x and y rotation upon throw
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0,0,0);
        rb.isKinematic = true;
        anim.enabled = false;
    }

    public void Throw(int num)
    {
        rb.AddForce(transform.forward*num, ForceMode.Impulse);
        this.transform.Rotate(90,0,0);
    }
}
