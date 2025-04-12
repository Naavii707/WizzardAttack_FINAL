using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private UnityEvent onGameStart;

    [SerializeField]
    private UnityEvent onRespawnGame;

    [SerializeField]
    private float secondsToRestart = 3f;

    [SerializeField]
    private UnityEvent onFinishGame;

    [SerializeField]
    private float finalSecondsToRestart;

    [SerializeField]
    private UnityEvent onLoseGame;

    [SerializeField]
    private float secondsToShowGameOverScreen = 3f;

    [SerializeField]
    private UnityEvent onShowGameOverScreen;

    [SerializeField]
    private UnityEvent<int> onShowTimer;

    private void Awake()
    {
        secondsToRestart += secondsToShowGameOverScreen;
        finalSecondsToRestart += secondsToShowGameOverScreen;
    }

    void Start()
    {
        onGameStart.Invoke();
    }

    public void LoseGame()
    {
        onLoseGame?.Invoke();
        Invoke("ShowGameOverScreen", secondsToShowGameOverScreen);
    }

    public void RespawnGame()
    {
        Invoke("RestartGame", secondsToRestart);
    }


    public void FinishGame()
    {
        onFinishGame?.Invoke();
        Invoke("Start", finalSecondsToRestart);
        Invoke("RestartGame", finalSecondsToRestart);
        
    }

    public void RestartGame()
    {
        onRespawnGame?.Invoke();
    }

    public void ShowGameOverScreen()
    {
        onShowGameOverScreen?.Invoke();
        onShowTimer?.Invoke(4);
    }
}
