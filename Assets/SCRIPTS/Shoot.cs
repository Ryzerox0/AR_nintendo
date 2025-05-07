using System.Linq.Expressions;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Camera ARcamera;
    private Vector3 initialPos;
    [SerializeField]
    private GameObject Ball;
    private GameObject currentBall;
    private Rigidbody body;
    public void ShootBall()
    {
        initialPos = ARcamera.transform.position;
        currentBall = Instantiate(Ball, initialPos,Quaternion.identity);
        body = currentBall.GetComponent<Rigidbody>();
        currentBall.transform.localRotation = ARcamera.transform.localRotation;

        body.AddForce(currentBall.transform.forward*3, ForceMode.Impulse);
    }
}