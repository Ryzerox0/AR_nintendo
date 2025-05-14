using System.Threading.Tasks;
using UnityEngine;

public class DetachChildren : MonoBehaviour
{
    private Vector3 childPos;
    private bool hasBeenSeen = false;

    public async void DetachChild(GameObject child)
    {

        if (!hasBeenSeen)
        {
            await Task.Delay(2000);
            childPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f, gameObject.transform.position.z);
            gameObject.transform.DetachChildren();
            child.transform.position = childPos;
        }
        hasBeenSeen = true;
        

    }
}
