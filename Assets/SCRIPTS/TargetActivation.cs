using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    public GameObject headToShow;
    private MeshRenderer meshHead;
    private MeshCollider colliderHead;

    private void Start()
    {
        meshHead = headToShow.GetComponent<MeshRenderer>();
        colliderHead = headToShow.GetComponentInParent<MeshCollider>();
    }
    public void ActivateObject()
    {
        if (headToShow != null)
        {
            colliderHead.enabled = true;
            meshHead.enabled = true;
        }
        

    }

}
