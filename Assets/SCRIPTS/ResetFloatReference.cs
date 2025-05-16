using UnityEngine;

public class ResetFloatReference : MonoBehaviour
{
    [SerializeField] private float resetValue;
    [SerializeField] private FloatReference valueToReset;
    void Start()
    {
        valueToReset.nb = resetValue;
    }

}
