using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text timerText;

    [SerializeField]
    private UnityEvent onSecondsPassed;

    private int currentSeconds;

    public void StartTimer(int startSeconds)
    {
        currentSeconds = startSeconds;
        SetTimer();
    }

    private void SetTimer()
    {
        onSecondsPassed?.Invoke();
        currentSeconds--;
        timerText.text = currentSeconds.ToString();
        if(currentSeconds > 0)
        {
            Invoke("SetTimer", 1f);
        }
    }
}
