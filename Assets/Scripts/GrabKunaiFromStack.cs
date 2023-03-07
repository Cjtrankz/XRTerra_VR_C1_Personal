using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabKunaiFromStack : MonoBehaviour
{
    public GameObject objToSpawn;
    GameObject spawned;

    public void Spawn(SelectEnterEventArgs args)
    {
        if(spawned!= null)
        {
            Destroy(spawned);
        }
        spawned = Instantiate(objToSpawn, transform.position, transform.rotation);
        IXRSelectInteractable ixr = spawned.GetComponent<IXRSelectInteractable>();
        
        args.manager.SelectEnter(args.interactorObject, ixr);
    }
}
