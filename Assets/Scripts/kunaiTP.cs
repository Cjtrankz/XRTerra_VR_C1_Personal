using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunaiTP : MonoBehaviour
{   
    public GameObject body;
    public GameObject kunai;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("clap");
        if(col.gameObject.tag == "hands")
        {
            kunai = GameObject.Find("Kunai(Clone)");
            if(kunai != null)
            {
                body.transform.position = new Vector3(kunai.transform.position.x, body.transform.position.y, kunai.transform.position.z);
                Destroy(kunai, 2);
            }
        }
    }

}
