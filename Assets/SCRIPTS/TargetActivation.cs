using UnityEngine;

public class TargetActivation : MonoBehaviour
{
    public GameObject objetAAfficher;
    private MeshRenderer meshHead;

    
    public void ActiverObjet()
    {
        if (objetAAfficher != null)
        {
            meshHead = objetAAfficher.GetComponent<MeshRenderer>();
            meshHead.enabled = true;
        }
        

    }

}
