using UnityEngine;
using UnityEngine.InputSystem;

public class DamageInput : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private PlayerHealth playerHealth;

    void Awake()
    {
        inputActions = new PlayerInputActions();
        playerHealth = FindAnyObjectByType<PlayerHealth>();
    }

    void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Damage.performed += OnDamage;
    }

    void OnDisable()
    {
        inputActions.Player.Damage.performed -= OnDamage;
        inputActions.Player.Disable();
    }

    private void OnDamage(InputAction.CallbackContext ctx)
    {
        playerHealth.TakeDamage(20);
    }
}
