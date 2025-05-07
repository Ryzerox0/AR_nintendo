using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Head")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        Debug.Log("COLLISION");
    }
}
