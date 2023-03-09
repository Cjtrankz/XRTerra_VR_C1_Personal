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

    void FixedUpdate()
    {
        rb.AddForce(transform.forward*2500, ForceMode.Force);
    }

    void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0,0,0);
        rb.isKinematic = true;
        //anim.ResetTrigger("ShurikenSpin");
    }

    public void Throw(int num)
    {
        rb.AddForce(transform.forward*num, ForceMode.Force);
        //this.transform.Rotate(90,0,0);
        //anim.Play("ShurikenSpin");
    }
}
