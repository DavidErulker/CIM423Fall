using UnityEngine;

public class DisappearOnTouch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false); // or Destroy(gameObject);
        }
    }
}
