using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    public GameObject headToShow;
    private MeshRenderer meshHead;
    private Collider colliderHead;
    private bool hasBeenActivated = false;

    private void Start()
    {
        meshHead = headToShow.GetComponent<MeshRenderer>();
        colliderHead = headToShow.GetComponentInParent<Collider>();
    }
    public void ActivateObject()
    {
        
        if (headToShow != null && hasBeenActivated)
        {
            colliderHead.enabled = true;
            meshHead.enabled = true;
        }
        hasBeenActivated = true;


    }

}
