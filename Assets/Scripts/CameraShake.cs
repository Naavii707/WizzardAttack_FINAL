using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private float shakeDuration;

    [SerializeField]
    private float shakeMagnitudeX;
    
    [SerializeField]
    private float shakeMagnitudeY;

    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }

    public void Shake()
    {
        StartCoroutine(ShakeCoroutine());
    }

    private IEnumerator ShakeCoroutine()
    {
        float elapsedTime = 0f;
        while (elapsedTime < shakeDuration)
        {
            float x = Random.Range(-1f, 1f) * shakeMagnitudeX;
            float y = Random.Range(-1f, 1f) * shakeMagnitudeY;

            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPosition;
    }
}
