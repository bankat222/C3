using UnityEngine;

public class TurretSmooth_Target : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 180f;

    void Update()
    {
        if (target == null) return;

        Vector2 dir = target.position - transform.position;

        float angle =
            Vector2.SignedAngle(transform.up, dir);

        float step = rotateSpeed * Time.deltaTime;

        float rotate = Mathf.Clamp(angle, -step, step);

        transform.Rotate(0, 0, rotate);
    }
}
