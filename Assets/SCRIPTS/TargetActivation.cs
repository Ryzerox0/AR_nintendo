using System.Collections.Generic;
using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    private Collider colliderHead;
    private MeshRenderer meshRend;
    private bool hasBeenActivated = false;
    public List<GameObject> headList;
    public IntReference scoreToGet;

    private void Start()
    {
        scoreToGet.nb = headList.Count/2;
    }
    public void ActivateObject()
    {
        if (hasBeenActivated)
        {
            foreach (GameObject head in headList)
            {
                if (head != null)
                {
                    meshRend = head.GetComponent<MeshRenderer>();
                    colliderHead = head.GetComponent<Collider>();
                    meshRend.enabled = true;
                    if (colliderHead != null)
                        colliderHead.enabled = true;
                }

            }
        }
        hasBeenActivated = true;
    }

}
