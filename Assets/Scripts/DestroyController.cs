using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyController : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            Destroy(gameObject);
        }
    }
}
