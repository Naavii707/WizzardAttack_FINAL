using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerText : MonoBehaviour
{
    [SerializeField]
    private Text playerText;

    private Animator textAnimator;

    public string animationName = "ShowText";

    private void Start()
    {
        textAnimator = playerText.GetComponent<Animator>();
    }

    public void ShowText(string text)
    {
        playerText.text = text;
        textAnimator.Play(animationName);
    }
}
