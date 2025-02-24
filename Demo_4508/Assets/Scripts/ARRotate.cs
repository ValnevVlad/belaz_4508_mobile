using UnityEngine;

public class Example : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        transform.LookAt(Target);
    }
}