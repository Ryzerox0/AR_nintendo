using UnityEngine;

public class ResetIntReference : MonoBehaviour
{
    [SerializeField] private int resetValue;
    [SerializeField] private IntReference valueToReset;
    void Start()
    {
        valueToReset.nb = resetValue;
    }

}
