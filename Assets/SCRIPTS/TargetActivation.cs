using System.Collections.Generic;
using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    private Collider colliderHead;
    private bool hasBeenActivated = false;
    public List<GameObject> headList;
    public IntReference scoreToGet;

    private void Start()
    {
        scoreToGet.nb = headList.Count/2;
    }
    public void ActivateObject()
    {
        if (gameObject != null && hasBeenActivated)
        {
            foreach(GameObject head in headList)
            {
               head.GetComponent<MeshRenderer>().enabled = true;
               colliderHead = head.GetComponent<Collider>();
               if(colliderHead != null)
                    colliderHead.enabled = true;
            }
        }
        hasBeenActivated = true;
    }

}
