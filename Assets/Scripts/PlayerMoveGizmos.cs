using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveGizmos : MonoBehaviour
{
    public float speed = 5f;
    Vector3 moveDir;

    void Update()
    {
        Vector2 input = Keyboard.current.wKey.isPressed ? Vector2.up : Vector2.zero;

        if (Keyboard.current.aKey.isPressed) input += Vector2.left;
        if (Keyboard.current.dKey.isPressed) input += Vector2.right;
        if (Keyboard.current.sKey.isPressed) input += Vector2.down;

        moveDir = new Vector3(input.x, input.y, 0);

        if (moveDir.magnitude > 1)
            moveDir = moveDir.normalized;

        transform.Translate(moveDir * speed * Time.deltaTime);
    }
}
