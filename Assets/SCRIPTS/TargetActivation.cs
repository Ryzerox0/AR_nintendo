using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    public GameObject objetAAfficher;
    private MeshRenderer meshHead;

    
    public void ActiverObjet()
    {
        meshHead = objetAAfficher.GetComponent<MeshRenderer>();
        meshHead.enabled = true;
        
    }
}
