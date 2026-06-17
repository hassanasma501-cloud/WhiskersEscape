using UnityEngine;

public class Fromage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AjouterPoint();
            Destroy(gameObject);
        }
    }
}
