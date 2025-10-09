using UnityEngine;
using System.Collections;

public class AutoHideAfterEnable : MonoBehaviour
{
    [Tooltip("How long to stay visible after being enabled (seconds).")]
    public float seconds = 3f;

    private Coroutine hideRoutine;

    private void OnEnable()
    {
        // Restart the timer every time this object is enabled
        if (hideRoutine != null) StopCoroutine(hideRoutine);
        hideRoutine = StartCoroutine(HideAfterDelay());
    }

    private void OnDisable()
    {
        if (hideRoutine != null) StopCoroutine(hideRoutine);
        hideRoutine = null;
    }

    private IEnumerator HideAfterDelay()
    {
        // Realtime so it works even if Time.timeScale changes
        yield return new WaitForSecondsRealtime(seconds);
        gameObject.SetActive(false);
    }
}
