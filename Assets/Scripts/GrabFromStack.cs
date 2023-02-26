using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabFromStack : MonoBehaviour
{
    public GameObject objToSpawn;

    public void Spawn(SelectEnterEventArgs args)
    {
        GameObject spawned = Instantiate(objToSpawn, transform.position, transform.rotation);
        IXRSelectInteractable ixr = spawned.GetComponent<IXRSelectInteractable>();
        
        args.manager.SelectEnter(args.interactorObject, ixr);
    }
}
