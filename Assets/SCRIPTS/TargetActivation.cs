using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    private MeshRenderer meshHead;
    private MeshRenderer meshHelix;
    private Collider colliderHead;
    private bool hasBeenActivated = false;

    private void Start()
    {
        meshHead = gameObject.GetComponent<MeshRenderer>();
        meshHelix = gameObject.GetComponentInChildren<MeshRenderer>();
        colliderHead = gameObject.GetComponent<Collider>();
    }
    public void ActivateObject()
    {
        
        if (gameObject != null && hasBeenActivated)
        {
            colliderHead.enabled = true;
            meshHead.enabled = true;
            meshHelix.enabled = true;
        }
        hasBeenActivated = true;


    }

}
