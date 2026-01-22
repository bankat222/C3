using UnityEngine;

public class TurretLookAt_NewInput : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target == null) return;

        Vector2 dir = target.position - transform.position;
        transform.up = dir;
    }
}
