using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

    [Header("Observer Events")]
    public UnityEvent<int> onHealthChanged;
    public UnityEvent onDeath;

    void Awake()
    {
        currentHP = maxHP;
        onHealthChanged.Invoke(currentHP); // cập nhật UI ngay khi start
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);

        onHealthChanged.Invoke(currentHP);

        if (currentHP <= 0)
        {
            onDeath.Invoke();
        }
    }
}
