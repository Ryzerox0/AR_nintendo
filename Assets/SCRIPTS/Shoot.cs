using System.Linq.Expressions;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    [SerializeField]
    private GameObject Ball;
    private GameObject currentBall;
    private Rigidbody body;
    public void ShootBall()
    {
        currentBall = Instantiate(Ball, initialPos,Quaternion.identity);
        body = currentBall.GetComponent<Rigidbody>();

        body.AddForce(new Vector3(0, 5, 10), ForceMode.Impulse);
    }
}
