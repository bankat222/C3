using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RotateByMouse_NewSystem : MonoBehaviour
{
    public TMP_Text angleText;

    PlayerInputActions input;
    Camera cam;

    void Awake()
    {
        input = new PlayerInputActions();
        cam = Camera.main;
    }

    void OnEnable()
    {
        input.Player.Enable();
    }

    void OnDisable()
    {
        input.Player.Disable();
    }

    void Update()
    {
        Vector2 mouseScreen =
            input.Player.Look.ReadValue<Vector2>();

        Vector3 mouseWorld =
            cam.ScreenToWorldPoint(
                new Vector3(mouseScreen.x, mouseScreen.y, 10));

        Vector2 dir = mouseWorld - transform.position;

        float angle =
            Vector2.SignedAngle(Vector2.up, dir);

        transform.rotation =
            Quaternion.Euler(0, 0, angle);

        angleText.text =
            "Angle: " + angle.ToString("F1");
    }
}
