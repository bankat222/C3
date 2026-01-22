using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void OnGameOver()
    {
        Debug.Log("GAME OVER");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
