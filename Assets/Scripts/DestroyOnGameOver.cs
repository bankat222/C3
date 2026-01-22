using UnityEngine;

public class DestroyOnGameOver : MonoBehaviour
{
    public GameObject target;

    public void DestroyTarget()
    {
        Destroy(target);
    }
}
