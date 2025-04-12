using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class DeactivatedInSeconds : MonoBehaviour
{
    [SerializeField]
    private float secondsToDeactivate = 5f;
    
    private void OnEnabled()
    {
        Invoke("DeactivateObject", secondsToDeactivate);
    }

    private void DeactivateObject()
    {
        gameObject.SetActive(false);
    }
}
