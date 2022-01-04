
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameManager gameManager;
    public NextLevel nextLevel;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        nextLevel.LoadNextLevel();
    }
}
